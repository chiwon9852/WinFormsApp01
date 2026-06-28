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
            // ចាប់យកផ្ទាំងទាំង ៨ តាមឈ្មោះពិតប្រាកដនៅលើ UI របស់បងមកផ្ទុកក្នុង Array
            allTabs = new TabPage[] {
        tpLogin,       // Index 0
        tpuser_acc,    // Index 1 (បងមើលឈ្មោះក្នុងរូបថត: tpuser_acc)
        tpCustomer,    // Index 2 (បងមើលឈ្មោះក្នុងរូបថត: tpCustomer)
        tpLaon,        // Index 3
        tpRepayment,     // Index 4
        tpReports,     // Index 5
        tpPI,        // Index 6
        tpSetting      // Index 7
        };

            // បើកកម្មវិធីដំបូង លាក់ទាំងអស់ ទុកតែផ្ទាំង Login
            CheckUserPermission("guest");
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
                // បើជាបុគ្គលិក (User) ឱ្យរត់រកមើលផ្ទាំងណាដែលមានឈ្មោះពិតថា "tpCustomer"
                foreach (TabPage tab in allTabs)
                {
                    if (tab != null && tab.Name == "tpCustomer")
                    {
                        uiTabControlMenu1.TabPages.Add(tab);
                        break;
                    }
                }
            }
            else if (role == "guest")
            {
                // ពេលដំបូងបង្អស់ បង្ហាញតែផ្ទាំង Login មួយគត់
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

                string query = "SELECT UserRole FROM tbl_Users WHERE Username LIKE @user AND Password LIKE @pass AND Status = 'Active'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@user", USER_NAME.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", USER_PWD.Text.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string currentRole = reader["UserRole"].ToString();
                    MessageBox.Show("ឡុកអ៊ីនចូលប្រព័ន្ធជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();

                    // ហៅមុខងារឆែកសិទ្ធិបើក Tab ទៅតាម Role
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
                uicboUserProfile.SelectedIndex == -1)
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

                string query = "INSERT INTO tbl_Users (Username, Password, EmployeeName, UserRole, Status) " +
                               "VALUES (@user, @pass, @name, @role, 'Active')";

                SqlCommand cmd = new SqlCommand(query, Connection.conn);

                cmd.Parameters.AddWithValue("@user", uitxtUserID.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", uitxtUserPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@name", uitxtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@role", uicboUserProfile.SelectedItem.ToString());

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("បានបង្កើតគណនីបុគ្គលិកថ្មីដោយជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uitxtUserID.Clear();
                    uitxtUserPassword.Clear();
                    uitxtUserName.Clear();
                    uicboUserProfile.SelectedIndex = -1;
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

        private void tpLogin_Click(object sender, EventArgs e) { }
        private void tpuser_acc_Click(object sender, EventArgs e) { }

        private void tprepay_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // 1. បង្កើតខ្សែភ្ជាប់ទៅកាន់ SQL Server របស់អ្នក
            string connectionString = @"Server=MAMAMILA\SQLEXPRESS; Database=MICROLOAN; Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 2. សរសេរកូដ Query ដើម្បីទៅទាញទិន្នន័យមក (ឧទាហរណ៍)
                    string query = "SELECT Principal, Interest FROM Table_Loan WHERE LoanID = @LoanID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LoanID", txtSearchLoanID.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // បង្ហាញទិន្នន័យលើ TextBox នីមួយៗ
                        txtPrincipal.Text = reader["Principal"].ToString();
                        txtInterest.Text = reader["Interest"].ToString();

                        // ផ្នែកគណនាប្រាក់ពិន័យ និងប្រាក់សរុប អាចបន្ថែមនៅត្រង់នេះ...
                    }
                    else
                    {
                        MessageBox.Show("រកមិនឃើញទិន្នន័យកិច្ចសន្យានេះទេ!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("មានបញ្ហាភ្ជាប់ទៅកាន់ Database: " + ex.Message);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // 1. ពិនិត្យមើលថា តើមានទិន្នន័យនៅក្នុងប្រឡោះស្វែងរកដែរឬទេ បើគ្មានទេមិនឲ្យបង់ឡើយ
            if (string.IsNullOrEmpty(txtSearchLoanID.Text))
            {
                MessageBox.Show("សូមស្វែងរកលេខកូដកិច្ចសន្យាខ្ចីប្រាក់ជាមុនសិន!", "ព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. ខ្សែភ្ជាប់ទៅកាន់ SQL Server របស់អ្នក (ដូរឈ្មោះ Database របស់អ្នកផង)
            string connectionString = @"Server=MAMAMILA\SQLEXPRESS; Database=ឈ្មោះDatabaseរបស់អ្នក; Integrated Security=True; TrustServerCertificate=True;";

            // 3. សរសេរកូដ SQL Query ដើម្បីរក្សាទុកប្រវត្តិបង់ប្រាក់ចូល Table_Repayment
            string query = @"INSERT INTO Table_Repayment (LoanID, PrincipalPaid, InterestPaid, PenaltyPaid, TotalPaid, PaymentDate) 
                     VALUES (@LoanID, @Principal, @Interest, @Penalty, @Total, @PaymentDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // 4. ចាប់យកតម្លៃពី TextBox នីមួយៗផ្ញើទៅឲ្យ SQL (ប្ដូរប្រភេទទៅជា Decimal/Double សម្រាប់លុយកាក់)
                    cmd.Parameters.AddWithValue("@LoanID", txtSearchLoanID.Text);
                    cmd.Parameters.AddWithValue("@Principal", Convert.ToDecimal(txtPrincipal.Text));
                    cmd.Parameters.AddWithValue("@Interest", Convert.ToDecimal(txtInterest.Text));
                    cmd.Parameters.AddWithValue("@Penalty", Convert.ToDecimal(txtPenalty.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now); // កត់ត្រាថ្ងៃខែឆ្នាំបច្ចុប្បន្នដែលមកបង់

                    // 5. ដំណើរការកូដ
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ការទូទាត់ប្រាក់ទទួលបានជោគជ័យ និងបានរក្សាទុកក្នុងប្រព័ន្ធ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 6. សម្អាតប្រឡោះ TextBox ទាំងអស់ឡើងវិញ ដើម្បីរង់ចាំទទួលអ្នកបន្ទាប់
                        ClearTextBoxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("មានបញ្ហាក្នុងការរក្សាទុកទិន្នន័យ៖ " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtSearchLoanID.Clear();
            txtPrincipal.Clear();
            txtInterest.Clear();
            txtPenalty.Clear();
            txtAmount.Clear();
        }
    }
}