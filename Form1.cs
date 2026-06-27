using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        // ប្រកាស Array ទុកផ្ទុក Tab ទាំងអស់
        TabPage[] allTabs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {
                if (GroupPermissions != null)
                {
                    GroupPermissions.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load: " + ex.Message);
            }

            // ចាប់យកផ្ទាំងទាំង ៨ មកផ្ទុកក្នុង Array (ឈ្មោះត្រូវបេះបិទជាមួយលក្ខខណ្ឌខាងក្រោម)
            allTabs = new TabPage[] {
                tpLogin,       // Index 0
                tpuser_acc,    // Index 1
                tpCustomer,    // Index 2
                tpLoan,        // Index 3
                tpRepayment,   // Index 4
                tpReports,     // Index 5
                tpPenalty,     // Index 6
                tpSetting      // Index 7
            };

            // បើកកម្មវិធីដំបូង លាក់ទាំងអស់ ទុកតែផ្ទាំង Login
            CheckUserPermission("guest");
            // ==========================================================

            try
            {
                if (Connection.conn.State == ConnectionState.Closed) Connection.conn.Open();

                // ⚠️ សូមប្ដូរពាក្យ tbl_Customers ទៅជាឈ្មោះតារាងអតិថិជនពិតប្រាកដក្នុង SQL របស់ប្អូន
                string query = "SELECT CustomerID FROM Customer WHERE Status = 'Active'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader reader = cmd.ExecuteReader();

                cboLoanCustomer.Items.Clear(); // ឈ្មោះ ComboBox របស់ប្អូនត្រង់ប្រអប់ ID
                while (reader.Read())
                {
                    cboLoanCustomer.Items.Add(reader["CustomerID"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ទាញទិន្នន័យ ID បរាជ័យ: " + ex.Message);
            }
            finally
            {
                if (Connection.conn.State == ConnectionState.Open) Connection.conn.Close();
            }
            // ១. ដូរ View របស់ ListView ទៅជា Details តាមរយៈកូដ
            lvLoanReport.View = View.Details;

            // ២. ចាប់ផ្ដើមថែម Columns និងកំណត់ទំហំ (Width) របស់វា
            lvLoanReport.Columns.Add("No", 50);             // Column ទី ១៖ លំដាប់លេខរៀង ទំហំ 50
            lvLoanReport.Columns.Add("Customer ID", 100);    // Column ទី ២៖ ID អតិថិជន ទំហំ 100
            lvLoanReport.Columns.Add("Amount", 120);         // Column ទី ៣៖ ចំនួនប្រាក់ខ្ចី ទំហំ 120
            lvLoanReport.Columns.Add("Interest", 90);        // Column ទី ៤៖ ការប្រាក់ % ទំហំ 90
            lvLoanReport.Columns.Add("Term", 90);            // Column ទី ៥៖ រយៈពេលខែ ទំហំ 90

        }

        public static class UserSession
        {
            public static string Role { get; set; }
            public static bool CanCustomer { get; set; }
            public static bool CanLoan { get; set; }
            public static bool CanPenalty { get; set; }
            public static bool CanRepayment { get; set; }
            public static bool CanReport { get; set; }
            public static bool CanSetting { get; set; }
        }

        private void CheckUserPermission(string userRole)
        {
            // ១. លុបផ្ទាំងទាំងអស់ចេញពីអេក្រង់សិន
            uiTabControlMenu1.TabPages.Clear();

            if (allTabs == null || allTabs.Length == 0) return;

            string role = userRole.Trim().ToLower();

            if (role == "master")
            {
                // បើជា Master ឱ្យបង្ហាញគ្រប់ Tab ទាំងអស់
                foreach (TabPage tab in allTabs)
                {
                    if (tab != null) uiTabControlMenu1.TabPages.Add(tab);
                }
            }
            else if (role == "user")
            {
                // បើកបង្ហាញ TabPage ទៅតាមសិទ្ធិដែលបានកំណត់ក្នុង Database
                foreach (TabPage tab in allTabs)
                {
                    if (tab == null) continue;

                    // 1. សិទ្ធិ Customer
                    if (tab.Name == "tpCustomer" && UserSession.CanCustomer)
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                    }
                    // 2. សិទ្ធិ Loan
                    else if (tab.Name == "tpLoan" && UserSession.CanLoan)
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                    }
                    // 3. សិទ្ធិ Penalty (កែឈ្មោះឱ្យត្រូវនឹង tpPenalty ក្នុង Array)
                    else if (tab.Name == "tpPenalty" && UserSession.CanPenalty)
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                    }
                    // 4. សិទ្ធិ Repayment
                    else if (tab.Name == "tpRepayment" && UserSession.CanRepayment)
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                    }
                    // 5. សិទ្ធិ Report (កែឈ្មោះឱ្យត្រូវនឹង tpReports មាន s)
                    else if (tab.Name == "tpReports" && UserSession.CanReport)
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                    }
                    // 6. សិទ្ធិ Setting
                    else if (tab.Name == "tpSetting" && UserSession.CanSetting)
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                    }
                }
            }
            else if (role == "guest")
            {
                // បើមិនទាន់ Login បង្ហាញតែផ្ទាំង Login
                foreach (TabPage tab in allTabs)
                {
                    if (tab != null && tab.Name == "tpLogin")
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                        break;
                    }
                }
            }
        }

        private void uiBtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(USER_NAME.Text) || string.IsNullOrEmpty(USER_PWD.Text))
            {
                MessageBox.Show("សូមបំពេញ Username និង Password!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Connection.conn.State == ConnectionState.Closed)
                {
                    Connection.conn.Open();
                }

                // ថែមការទាញយក Column សិទ្ធិទាំង ៦ ពី SQL
                string query = "SELECT UserRole, CanCustomer, CanLoan, CanPenalty, CanRepayment, CanReport, CanSetting FROM tbl_Users WHERE Username LIKE @user AND Password LIKE @pass AND Status = 'Active'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@user", USER_NAME.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", USER_PWD.Text.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string currentRole = reader["UserRole"].ToString();

                    // ញាត់តម្លៃសិទ្ធិចូលទៅក្នុង UserSession ទុកឱ្យកម្មវិធីប្រើ
                    UserSession.Role = currentRole;
                    UserSession.CanCustomer = reader["CanCustomer"] != DBNull.Value && Convert.ToBoolean(reader["CanCustomer"]);
                    UserSession.CanLoan = reader["CanLoan"] != DBNull.Value && Convert.ToBoolean(reader["CanLoan"]);
                    UserSession.CanPenalty = reader["CanPenalty"] != DBNull.Value && Convert.ToBoolean(reader["CanPenalty"]);
                    UserSession.CanRepayment = reader["CanRepayment"] != DBNull.Value && Convert.ToBoolean(reader["CanRepayment"]);
                    UserSession.CanReport = reader["CanReport"] != DBNull.Value && Convert.ToBoolean(reader["CanReport"]);
                    UserSession.CanSetting = reader["CanSetting"] != DBNull.Value && Convert.ToBoolean(reader["CanSetting"]);

                    MessageBox.Show("ឡុកអ៊ីនចូលប្រព័ន្ធជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();

                    // ឆែកសិទ្ធិបើក Tab
                    CheckUserPermission(currentRole);
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Username ឬ Password មិនត្រឹមត្រូវឡើយ!", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Connection.conn.State == ConnectionState.Open)
                {
                    Connection.conn.Close();
                }
            }
        }

        private void uiBtninsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uitxtUserID.Text) ||
                string.IsNullOrEmpty(uitxtUserPassword.Text) ||
                string.IsNullOrEmpty(uitxtUserName.Text) ||
                CboUserProfile.SelectedIndex == -1)
            {
                MessageBox.Show("សូមបំពេញព័ត៌មានកាតព្វកិច្ចឱ្យបានគ្រប់ជ្រុងជ្រោយ!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Connection.conn.State == ConnectionState.Closed)
                {
                    Connection.conn.Open();
                }

                // កែ Query ឱ្យរក្សាទុកទាំងសិទ្ធិដែលបានធិកលើ CheckBox ចូលទៅ Database ដែរ
                string query = "INSERT INTO tbl_Users (Username, Password, EmployeeName, UserRole, Status, CanCustomer, CanLoan, CanPenalty, CanRepayment, CanReport, CanSetting) " +
                               "VALUES (@user, @pass, @name, @role, 'Active', @canCust, @canLoan, @canPen, @canRepay, @canRep, @canSet)";

                SqlCommand cmd = new SqlCommand(query, Connection.conn);

                cmd.Parameters.AddWithValue("@user", uitxtUserID.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", uitxtUserPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@name", uitxtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@role", CboUserProfile.SelectedItem.ToString());

                // បើជា master គឺឱ្យ True ទាំងអស់ បើជា user គឺយកតាមការធិកជាក់ស្តែង
                string selectedRole = CboUserProfile.SelectedItem.ToString().ToLower().Trim();
                if (selectedRole == "master")
                {
                    cmd.Parameters.AddWithValue("@canCust", true);
                    cmd.Parameters.AddWithValue("@canLoan", true);
                    cmd.Parameters.AddWithValue("@canPen", true);
                    cmd.Parameters.AddWithValue("@canRepay", true);
                    cmd.Parameters.AddWithValue("@canRep", true);
                    cmd.Parameters.AddWithValue("@canSet", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@canCust", ChkCustomer.Checked);
                    cmd.Parameters.AddWithValue("@canLoan", ChkLoan.Checked);
                    cmd.Parameters.AddWithValue("@canPen", ChkPenalty.Checked);
                    cmd.Parameters.AddWithValue("@canRepay", ChkRepayment.Checked);
                    cmd.Parameters.AddWithValue("@canRep", ChkReports.Checked); // ប្រកាស ChkReports តាមប្អូនសរសេរ
                    cmd.Parameters.AddWithValue("@canSet", ChkSetting.Checked);
                }

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("បានបង្កើតគណនីបុគ្គលិកថ្មីដោយជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uitxtUserID.Clear();
                    uitxtUserPassword.Clear();
                    uitxtUserName.Clear();
                    CboUserProfile.SelectedIndex = -1;

                    // Clear CheckBox
                    ChkCustomer.Checked = false;
                    ChkLoan.Checked = false;
                    ChkPenalty.Checked = false;
                    ChkRepayment.Checked = false;
                    ChkReports.Checked = false;
                    ChkSetting.Checked = false;
                }
                else
                {
                    MessageBox.Show("ការរក្សាទុកទិន្នន័យបរាជ័យ!", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហាពេលបញ្ចូលទិន្នន័យ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Connection.conn.State == ConnectionState.Open)
                {
                    Connection.conn.Close();
                }
            }
        }

        private void uicboUserProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUserProfile.SelectedItem == null) return;

            string selectedProfile = CboUserProfile.SelectedItem.ToString().ToLower().Trim();

            if (selectedProfile == "user")
            {
                GroupPermissions.Enabled = true;

                // លុបការធិកចាស់ៗចោលទុកឱ្យធិកថ្មី
                ChkCustomer.Checked = false;
                ChkLoan.Checked = false;
                ChkPenalty.Checked = false;
                ChkRepayment.Checked = false;
                ChkReports.Checked = false;
                ChkSetting.Checked = false;
            }
            else if (selectedProfile == "master")
            {
                GroupPermissions.Enabled = false;

                // ធិកឱ្យទាំងអស់អូតូ
                ChkCustomer.Checked = true;
                ChkLoan.Checked = true;
                ChkPenalty.Checked = true;
                ChkRepayment.Checked = true;
                ChkReports.Checked = true;
                ChkSetting.Checked = true;
            }
            else
            {
                GroupPermissions.Enabled = false;
            }
        }

        private void tpLogin_Click(object sender, EventArgs e) { }
        private void tpuser_acc_Click(object sender, EventArgs e) { }
        private void uiBtnview_Click(object sender, EventArgs e) { }
        private void tprepay_Click(object sender, EventArgs e) { }

        private void BtnCaculate_Click(object sender, EventArgs e)
        {
            // ១. ត្រួតពិនិត្យមើលថាតើបុគ្គលិកបានរើសឈ្មោះអតិថិជនហើយឬនៅ
            if (cboLoanCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("សូមជ្រើសរើសអតិថិជនសិន!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ២. ចាប់យកតម្លៃលេខពី TextBox នីមួយៗមកបម្លែងជាប្រភេទលេខ decimal
            decimal loanAmount = Convert.ToDecimal(txtLoanAmount.Text);       // ប្រាក់ដើមខ្ចី
            decimal interestRate = Convert.ToDecimal(txtLoanInterestRate.Text); // អត្រាការប្រាក់ (គិតជា %)
            decimal months = Convert.ToDecimal(txtLoanTerm.Text);             // ចំនួនខែដែលខ្ចី

            // ៣. គណនាតាមរូបមន្តកម្ចី
            // រកប្រាក់ការសរុប = ប្រាក់ដើម x (អត្រាការប្រាក់ / 100) x ចំនួនខែ
            decimal totalInterest = loanAmount * (interestRate / 100) * months;

            // រកប្រាក់សរុបត្រូវសង = ប្រាក់ដើម + ប្រាក់ការសរុប
            decimal totalAmount = loanAmount + totalInterest;

            // ៤. បោះទិន្នន័យបង្ហាញចូលទៅក្នុង ListView (ដូចគំរូរូបភាពទី ៣)
            int rowCount = lvLoanReport.Items.Count + 1; // រកលំដាប់លេខរៀង (No)

            ListViewItem item = new ListViewItem(rowCount.ToString()); // ថែមលេខរៀងចូល Column ទី ១
            item.SubItems.Add(cboLoanCustomer.SelectedItem.ToString()); // ថែមឈ្មោះចូល Column ទី ២
            item.SubItems.Add(loanAmount.ToString("N2"));              // ថែមប្រាក់ដើមចូល Column ទី ៣
            item.SubItems.Add(totalInterest.ToString("N2"));           // ថែមប្រាក់ការចូល Column ទី ៤
            item.SubItems.Add(totalAmount.ToString("N2"));             // ថែមប្រាក់សរុបចូល Column ទី ៥

            // បញ្ចូល Row ថ្មីនេះទៅក្នុង ListView
            lvLoanReport.Items.Add(item);
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchLoanID.Text))
            {
                MessageBox.Show("សូមវាយបញ្ចូល Loan ID សិន!", "ដំណឹង", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Connection.conn.State == ConnectionState.Closed) Connection.conn.Open();

                // ១. ពិនិត្យមើលក្នុង Query (ត្រូវប្រាកដថាប្រើពាក្យ @custId)
                string query = "SELECT LoanAmount, InterestRate, (LoanAmount + (LoanAmount * (InterestRate/100) * TermMonths)) AS TotalAmount " +
                               "FROM Loan WHERE CustomerID = @custId AND Status = 'Active'";

                SqlCommand cmd = new SqlCommand(query, Connection.conn);

                // ២. ពិនិត្យមើលត្រង់កន្លែងថែម Parameter (ត្រូវតែ @custId ដូចគ្នា បេះបិទ)
                // ⚠️ ត្រូវប្រាកដថាប្អូនមិនមែនសរសេរ @loanId ឬ @custID (ID ធំ) នោះទេ
                cmd.Parameters.AddWithValue("@custId", txtSearchLoanID.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtLoanAmount.Text = Convert.ToDecimal(reader["LoanAmount"]).ToString("N2");
                    txtInterestRate.Text = Convert.ToDecimal(reader["InterestRate"]).ToString("F2");
                    txtTotalAmount.Text = Convert.ToDecimal(reader["TotalAmount"]).ToString("N2");
                }
                else
                {
                    MessageBox.Show("រកមិនឃើញទិន្នន័យកម្ចី ឬកម្ចីនេះត្រូវបានបិទរួចរាល់ហើយ!", "មិនជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoanAmount.Clear(); txtInterestRate.Clear(); txtTotalAmount.Clear();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Search: " + ex.Message);
            }
            finally
            {
                if (Connection.conn.State == ConnectionState.Open) Connection.conn.Close();
            }
        }


        private void btnSaveRepayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPayAmount.Text) || string.IsNullOrEmpty(txtSearchLoanID.Text))
            {
                MessageBox.Show("សូមបំពេញព័ត៌មាន និងចំនួនទឹកប្រាក់ដែលត្រូវបង់ឱ្យបានត្រឹមត្រូវ!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Connection.conn.State == ConnectionState.Closed) Connection.conn.Open();

                // ១. កូដបញ្ចូលទៅតារាង Repayment
                string insertQuery = "INSERT INTO Repayment (LoanID, PayAmount) VALUES (@loanId, @payAmount)";
                SqlCommand cmdInsert = new SqlCommand(insertQuery, Connection.conn);
                cmdInsert.Parameters.AddWithValue("@loanId", txtSearchLoanID.Text);
                cmdInsert.Parameters.AddWithValue("@payAmount", Convert.ToDecimal(txtPayAmount.Text));
                cmdInsert.ExecuteNonQuery();

                // ២. កូដកែប្រែស្ថានភាពទៅជា 'Closed' ក្នុងតារាង Loan (ឧទាហរណ៍ថាគាត់បង់ដាច់)
                // 💡 ប្អូនអាចអភិវឌ្ឍបន្ថែមឆែកលក្ខខណ្ឌបើបង់គ្រប់ទើបដូរ Status ក៏បាន
                string updateQuery = "UPDATE Loan SET Status = 'Closed' WHERE LoanID = @loanId";
                SqlCommand cmdUpdate = new SqlCommand(updateQuery, Connection.conn);
                cmdUpdate.Parameters.AddWithValue("@loanId", txtSearchLoanID.Text);
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("រក្សាទុកការបង់ប្រាក់សងត្រឡប់បានជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // សម្អាតប្រអប់ក្រោយរក្សាទុកជោគជ័យ
                txtSearchLoanID.Clear(); txtLoanAmount.Clear(); txtInterestRate.Clear(); txtTotalAmount.Clear(); txtPayAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Save Repayment: " + ex.Message);
            }
            finally
            {
                if (Connection.conn.State == ConnectionState.Open) Connection.conn.Close();
            }
        }
    }
}