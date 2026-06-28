namespace WinFormsApp01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tpSetting = new TabPage();
            tpPenalty = new TabPage();
            tpReports = new TabPage();
            BtnNext = new Sunny.UI.UIButton();
            BtnCancel = new Sunny.UI.UIButton();
            uiCheckBox1 = new Sunny.UI.UICheckBox();
            uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            LblTitle = new Sunny.UI.UILabel();
            pictureBox1 = new PictureBox();
            tpLoan = new TabPage();
            lvLoanReport = new ListView();
            BtnCaculate = new Sunny.UI.UIButton();
            txtLoanTerm = new Sunny.UI.UITextBox();
            txtLoanInterestRate = new Sunny.UI.UITextBox();
            txtLoanAmount = new Sunny.UI.UITextBox();
            cboLoanCustomer = new Sunny.UI.UIComboBox();
            uiLabel8 = new Sunny.UI.UILabel();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            tpCustomer = new TabPage();
            tpLogin = new TabPage();
            uiBtnLogin = new Sunny.UI.UIButton();
            USER_PWD = new Sunny.UI.UITextBox();
            USER_NAME = new Sunny.UI.UITextBox();
            uiLblPWD = new Sunny.UI.UILabel();
            uiLblUSER_NAME = new Sunny.UI.UILabel();
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tpuser_acc = new TabPage();
            GroupPermissions = new Sunny.UI.UIGroupBox();
            ChkSearchRecords = new Sunny.UI.UICheckBox();
            ChkSetting = new Sunny.UI.UICheckBox();
            ChkReports = new Sunny.UI.UICheckBox();
            ChkRepayment = new Sunny.UI.UICheckBox();
            ChkPenalty = new Sunny.UI.UICheckBox();
            ChkLoan = new Sunny.UI.UICheckBox();
            ChkCustomer = new Sunny.UI.UICheckBox();
            uiBtnview = new Sunny.UI.UIButton();
            uiBtndelete = new Sunny.UI.UIButton();
            uiBtnupdate = new Sunny.UI.UIButton();
            uiBtninsert = new Sunny.UI.UIButton();
            txtProfile = new Sunny.UI.UILabel();
            txtUserEmail = new Sunny.UI.UILabel();
            txtEmpName = new Sunny.UI.UILabel();
            txtNewPass = new Sunny.UI.UILabel();
            txtNewUser = new Sunny.UI.UILabel();
            CboUserProfile = new Sunny.UI.UIComboBox();
            uitxtUserEmail = new Sunny.UI.UITextBox();
            uitxtUserName = new Sunny.UI.UITextBox();
            uitxtUserPassword = new Sunny.UI.UITextBox();
            uitxtUserID = new Sunny.UI.UITextBox();
            tpRepayment = new TabPage();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            btnSaveRepayment = new Sunny.UI.UIButton();
            BtnSearch = new Sunny.UI.UIButton();
            txtTotalAmount = new Sunny.UI.UITextBox();
            txtInterestRate = new Sunny.UI.UITextBox();
            txtTotalAmoun = new Sunny.UI.UITextBox();
            txtPayAmount = new Sunny.UI.UITextBox();
            txtSearchLoanID = new Sunny.UI.UITextBox();
            tpSearchRecords = new TabPage();
            dgvRecords = new Sunny.UI.UIDataGridView();
            BtnResearch = new Sunny.UI.UIButton();
            BtnRefresh = new Sunny.UI.UIButton();
            BtnBack = new Sunny.UI.UIButton();
            TxtTotalAmounts = new Sunny.UI.UITextBox();
            TxtTotalCustomers = new Sunny.UI.UITextBox();
            TxtTotalLoans = new Sunny.UI.UITextBox();
            TxtSearch = new Sunny.UI.UITextBox();
            LblTotalAmounts = new Sunny.UI.UILabel();
            LblTotalLoans = new Sunny.UI.UILabel();
            LblTotalCustomers = new Sunny.UI.UILabel();
            LblSearch = new Sunny.UI.UILabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            tpReports.SuspendLayout();
            uiRichTextBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpLoan.SuspendLayout();
            tpLogin.SuspendLayout();
            uiTabControlMenu1.SuspendLayout();
            tpuser_acc.SuspendLayout();
            GroupPermissions.SuspendLayout();
            tpRepayment.SuspendLayout();
            tpSearchRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // tpSetting
            // 
            tpSetting.Location = new Point(201, 0);
            tpSetting.Name = "tpSetting";
            tpSetting.Size = new Size(837, 453);
            tpSetting.TabIndex = 6;
            tpSetting.Text = "Setting";
            tpSetting.UseVisualStyleBackColor = true;
            // 
            // tpPenalty
            // 
            tpPenalty.Location = new Point(201, 0);
            tpPenalty.Name = "tpPenalty";
            tpPenalty.Size = new Size(837, 453);
            tpPenalty.TabIndex = 5;
            tpPenalty.Text = "Penalty and interest";
            tpPenalty.UseVisualStyleBackColor = true;
            // 
            // tpReports
            // 
            tpReports.Controls.Add(BtnNext);
            tpReports.Controls.Add(BtnCancel);
            tpReports.Controls.Add(uiCheckBox1);
            tpReports.Controls.Add(uiRichTextBox1);
            tpReports.Controls.Add(pictureBox1);
            tpReports.Location = new Point(201, 0);
            tpReports.Name = "tpReports";
            tpReports.Size = new Size(837, 453);
            tpReports.TabIndex = 4;
            tpReports.Text = "Reports";
            tpReports.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            BtnNext.Font = new Font("Microsoft Sans Serif", 12F);
            BtnNext.Location = new Point(526, 312);
            BtnNext.MinimumSize = new Size(1, 1);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(243, 44);
            BtnNext.TabIndex = 4;
            BtnNext.Text = "Next";
            BtnNext.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Font = new Font("Microsoft Sans Serif", 12F);
            BtnCancel.Location = new Point(30, 312);
            BtnCancel.MinimumSize = new Size(1, 1);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(267, 44);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnCancel.Click += BtnCancel_Click;
            // 
            // uiCheckBox1
            // 
            uiCheckBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiCheckBox1.ForeColor = Color.FromArgb(48, 48, 48);
            uiCheckBox1.Location = new Point(30, 270);
            uiCheckBox1.MinimumSize = new Size(1, 1);
            uiCheckBox1.Name = "uiCheckBox1";
            uiCheckBox1.Size = new Size(295, 36);
            uiCheckBox1.TabIndex = 2;
            uiCheckBox1.Text = "ខ្ញុំបានអាន និងយល់ព្រមតាមលក្ខខណ្ឌ";
            uiCheckBox1.CheckedChanged += uiCheckBox1_CheckedChanged;
            // 
            // uiRichTextBox1
            // 
            uiRichTextBox1.Controls.Add(LblTitle);
            uiRichTextBox1.FillColor = Color.White;
            uiRichTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiRichTextBox1.Location = new Point(30, 82);
            uiRichTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiRichTextBox1.MinimumSize = new Size(1, 1);
            uiRichTextBox1.Name = "uiRichTextBox1";
            uiRichTextBox1.Padding = new Padding(2);
            uiRichTextBox1.ShowText = false;
            uiRichTextBox1.Size = new Size(739, 180);
            uiRichTextBox1.TabIndex = 1;
            uiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            uiRichTextBox1.TextChanged += uiRichTextBox1_TextChanged;
            // 
            // LblTitle
            // 
            LblTitle.Font = new Font("Microsoft Sans Serif", 12F);
            LblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            LblTitle.Location = new Point(230, 13);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(184, 29);
            LblTitle.TabIndex = 3;
            LblTitle.Text = "លក្ខខណ្ឌ(Conditions)";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(284, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tpLoan
            // 
            tpLoan.BackColor = Color.White;
            tpLoan.Controls.Add(lvLoanReport);
            tpLoan.Controls.Add(BtnCaculate);
            tpLoan.Controls.Add(txtLoanTerm);
            tpLoan.Controls.Add(txtLoanInterestRate);
            tpLoan.Controls.Add(txtLoanAmount);
            tpLoan.Controls.Add(cboLoanCustomer);
            tpLoan.Controls.Add(uiLabel8);
            tpLoan.Controls.Add(uiLabel7);
            tpLoan.Controls.Add(uiLabel6);
            tpLoan.Controls.Add(uiLabel5);
            tpLoan.Location = new Point(201, 0);
            tpLoan.Name = "tpLoan";
            tpLoan.Size = new Size(837, 453);
            tpLoan.TabIndex = 2;
            tpLoan.Text = "Loan";
            // 
            // lvLoanReport
            // 
            lvLoanReport.BackColor = Color.Maroon;
            lvLoanReport.ForeColor = Color.White;
            lvLoanReport.Location = new Point(467, 21);
            lvLoanReport.Name = "lvLoanReport";
            lvLoanReport.Size = new Size(367, 406);
            lvLoanReport.TabIndex = 9;
            lvLoanReport.UseCompatibleStateImageBehavior = false;
            lvLoanReport.View = View.Details;
            // 
            // BtnCaculate
            // 
            BtnCaculate.FillColor = Color.Maroon;
            BtnCaculate.Font = new Font("Microsoft Sans Serif", 12F);
            BtnCaculate.Location = new Point(205, 317);
            BtnCaculate.MinimumSize = new Size(1, 1);
            BtnCaculate.Name = "BtnCaculate";
            BtnCaculate.RectColor = Color.Maroon;
            BtnCaculate.Size = new Size(125, 44);
            BtnCaculate.TabIndex = 8;
            BtnCaculate.Text = "&Caculate";
            BtnCaculate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnCaculate.Click += BtnCaculate_Click;
            // 
            // txtLoanTerm
            // 
            txtLoanTerm.Font = new Font("Microsoft Sans Serif", 12F);
            txtLoanTerm.Location = new Point(114, 218);
            txtLoanTerm.Margin = new Padding(4, 5, 4, 5);
            txtLoanTerm.MinimumSize = new Size(1, 16);
            txtLoanTerm.Name = "txtLoanTerm";
            txtLoanTerm.Padding = new Padding(5);
            txtLoanTerm.RectColor = Color.Maroon;
            txtLoanTerm.ShowText = false;
            txtLoanTerm.Size = new Size(346, 36);
            txtLoanTerm.TabIndex = 7;
            txtLoanTerm.TextAlignment = ContentAlignment.MiddleLeft;
            txtLoanTerm.Watermark = "";
            // 
            // txtLoanInterestRate
            // 
            txtLoanInterestRate.Font = new Font("Microsoft Sans Serif", 12F);
            txtLoanInterestRate.Location = new Point(114, 150);
            txtLoanInterestRate.Margin = new Padding(4, 5, 4, 5);
            txtLoanInterestRate.MinimumSize = new Size(1, 16);
            txtLoanInterestRate.Name = "txtLoanInterestRate";
            txtLoanInterestRate.Padding = new Padding(5);
            txtLoanInterestRate.RectColor = Color.Maroon;
            txtLoanInterestRate.ShowText = false;
            txtLoanInterestRate.Size = new Size(346, 36);
            txtLoanInterestRate.TabIndex = 6;
            txtLoanInterestRate.TextAlignment = ContentAlignment.MiddleLeft;
            txtLoanInterestRate.Watermark = "";
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Font = new Font("Microsoft Sans Serif", 12F);
            txtLoanAmount.Location = new Point(114, 84);
            txtLoanAmount.Margin = new Padding(4, 5, 4, 5);
            txtLoanAmount.MinimumSize = new Size(1, 16);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Padding = new Padding(5);
            txtLoanAmount.RectColor = Color.Maroon;
            txtLoanAmount.ShowText = false;
            txtLoanAmount.Size = new Size(346, 36);
            txtLoanAmount.TabIndex = 5;
            txtLoanAmount.TextAlignment = ContentAlignment.MiddleLeft;
            txtLoanAmount.Watermark = "";
            // 
            // cboLoanCustomer
            // 
            cboLoanCustomer.DataSource = null;
            cboLoanCustomer.FillColor = Color.White;
            cboLoanCustomer.Font = new Font("Microsoft Sans Serif", 12F);
            cboLoanCustomer.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboLoanCustomer.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboLoanCustomer.Location = new Point(114, 21);
            cboLoanCustomer.Margin = new Padding(4, 5, 4, 5);
            cboLoanCustomer.MinimumSize = new Size(63, 0);
            cboLoanCustomer.Name = "cboLoanCustomer";
            cboLoanCustomer.Padding = new Padding(0, 0, 30, 2);
            cboLoanCustomer.RectColor = Color.Maroon;
            cboLoanCustomer.Size = new Size(346, 36);
            cboLoanCustomer.SymbolSize = 24;
            cboLoanCustomer.TabIndex = 4;
            cboLoanCustomer.TextAlignment = ContentAlignment.MiddleLeft;
            cboLoanCustomer.Watermark = "";
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel8.ForeColor = Color.Maroon;
            uiLabel8.Location = new Point(8, 225);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(125, 29);
            uiLabel8.TabIndex = 3;
            uiLabel8.Text = "Term :";
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel7.ForeColor = Color.Maroon;
            uiLabel7.Location = new Point(8, 157);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(125, 29);
            uiLabel7.TabIndex = 2;
            uiLabel7.Text = "Interest :";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel6.ForeColor = Color.Maroon;
            uiLabel6.Location = new Point(8, 91);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(125, 29);
            uiLabel6.TabIndex = 1;
            uiLabel6.Text = "Amount :";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel5.ForeColor = Color.Maroon;
            uiLabel5.Location = new Point(8, 28);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(125, 29);
            uiLabel5.TabIndex = 0;
            uiLabel5.Text = "ID :";
            // 
            // tpCustomer
            // 
            tpCustomer.Location = new Point(201, 0);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Size = new Size(837, 453);
            tpCustomer.TabIndex = 1;
            tpCustomer.Text = "Customer";
            tpCustomer.UseVisualStyleBackColor = true;
            // 
            // tpLogin
            // 
            tpLogin.BackColor = Color.White;
            tpLogin.Controls.Add(uiBtnLogin);
            tpLogin.Controls.Add(USER_PWD);
            tpLogin.Controls.Add(USER_NAME);
            tpLogin.Controls.Add(uiLblPWD);
            tpLogin.Controls.Add(uiLblUSER_NAME);
            tpLogin.Location = new Point(201, 0);
            tpLogin.Name = "tpLogin";
            tpLogin.Size = new Size(837, 453);
            tpLogin.TabIndex = 0;
            tpLogin.Text = "Log in";
            tpLogin.Click += tpLogin_Click;
            // 
            // uiBtnLogin
            // 
            uiBtnLogin.FillColor = Color.Maroon;
            uiBtnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtnLogin.Location = new Point(310, 296);
            uiBtnLogin.MinimumSize = new Size(1, 1);
            uiBtnLogin.Name = "uiBtnLogin";
            uiBtnLogin.RectColor = Color.FromArgb(64, 0, 0);
            uiBtnLogin.RectHoverColor = Color.Maroon;
            uiBtnLogin.RectSelectedColor = Color.FromArgb(255, 192, 192);
            uiBtnLogin.Size = new Size(125, 44);
            uiBtnLogin.TabIndex = 3;
            uiBtnLogin.Text = "LOG IN";
            uiBtnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiBtnLogin.Click += uiBtnLogin_Click;
            // 
            // USER_PWD
            // 
            USER_PWD.Font = new Font("Microsoft Sans Serif", 12F);
            USER_PWD.Location = new Point(215, 195);
            USER_PWD.Margin = new Padding(4, 5, 4, 5);
            USER_PWD.MinimumSize = new Size(1, 16);
            USER_PWD.Name = "USER_PWD";
            USER_PWD.Padding = new Padding(5);
            USER_PWD.RectColor = Color.Maroon;
            USER_PWD.ShowText = false;
            USER_PWD.Size = new Size(304, 36);
            USER_PWD.TabIndex = 3;
            USER_PWD.TextAlignment = ContentAlignment.MiddleLeft;
            USER_PWD.Watermark = "";
            // 
            // USER_NAME
            // 
            USER_NAME.ButtonFillColor = Color.Blue;
            USER_NAME.ButtonStyleInherited = false;
            USER_NAME.Font = new Font("Microsoft Sans Serif", 12F);
            USER_NAME.Location = new Point(215, 79);
            USER_NAME.Margin = new Padding(4, 5, 4, 5);
            USER_NAME.MinimumSize = new Size(1, 16);
            USER_NAME.Name = "USER_NAME";
            USER_NAME.Padding = new Padding(5);
            USER_NAME.RectColor = Color.Maroon;
            USER_NAME.ShowText = false;
            USER_NAME.Size = new Size(304, 36);
            USER_NAME.TabIndex = 2;
            USER_NAME.TextAlignment = ContentAlignment.MiddleLeft;
            USER_NAME.Watermark = "";
            // 
            // uiLblPWD
            // 
            uiLblPWD.Font = new Font("Microsoft Sans Serif", 12F);
            uiLblPWD.ForeColor = Color.Maroon;
            uiLblPWD.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            uiLblPWD.Location = new Point(51, 202);
            uiLblPWD.Name = "uiLblPWD";
            uiLblPWD.Size = new Size(157, 29);
            uiLblPWD.TabIndex = 1;
            uiLblPWD.Text = "USER_PWD :";
            // 
            // uiLblUSER_NAME
            // 
            uiLblUSER_NAME.Font = new Font("Microsoft Sans Serif", 12F);
            uiLblUSER_NAME.ForeColor = Color.Maroon;
            uiLblUSER_NAME.Location = new Point(51, 86);
            uiLblUSER_NAME.Name = "uiLblUSER_NAME";
            uiLblUSER_NAME.Size = new Size(157, 29);
            uiLblUSER_NAME.TabIndex = 0;
            uiLblUSER_NAME.Text = "USER_NAME :";
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(tpLogin);
            uiTabControlMenu1.Controls.Add(tpuser_acc);
            uiTabControlMenu1.Controls.Add(tpCustomer);
            uiTabControlMenu1.Controls.Add(tpLoan);
            uiTabControlMenu1.Controls.Add(tpPenalty);
            uiTabControlMenu1.Controls.Add(tpRepayment);
            uiTabControlMenu1.Controls.Add(tpReports);
            uiTabControlMenu1.Controls.Add(tpSearchRecords);
            uiTabControlMenu1.Controls.Add(tpSetting);
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMenu1.Location = new Point(0, 0);
            uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1038, 453);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabBackColor = Color.Maroon;
            uiTabControlMenu1.TabIndex = 0;
            uiTabControlMenu1.TabSelectedColor = Color.GhostWhite;
            uiTabControlMenu1.TabSelectedForeColor = Color.Maroon;
            uiTabControlMenu1.TabSelectedHighColor = Color.Transparent;
            uiTabControlMenu1.TabUnSelectedForeColor = Color.WhiteSmoke;
            // 
            // tpuser_acc
            // 
            tpuser_acc.Controls.Add(GroupPermissions);
            tpuser_acc.Controls.Add(uiBtnview);
            tpuser_acc.Controls.Add(uiBtndelete);
            tpuser_acc.Controls.Add(uiBtnupdate);
            tpuser_acc.Controls.Add(uiBtninsert);
            tpuser_acc.Controls.Add(txtProfile);
            tpuser_acc.Controls.Add(txtUserEmail);
            tpuser_acc.Controls.Add(txtEmpName);
            tpuser_acc.Controls.Add(txtNewPass);
            tpuser_acc.Controls.Add(txtNewUser);
            tpuser_acc.Controls.Add(CboUserProfile);
            tpuser_acc.Controls.Add(uitxtUserEmail);
            tpuser_acc.Controls.Add(uitxtUserName);
            tpuser_acc.Controls.Add(uitxtUserPassword);
            tpuser_acc.Controls.Add(uitxtUserID);
            tpuser_acc.Location = new Point(201, 0);
            tpuser_acc.Name = "tpuser_acc";
            tpuser_acc.Size = new Size(837, 453);
            tpuser_acc.TabIndex = 7;
            tpuser_acc.Text = "USER_ACCOUNT";
            tpuser_acc.UseVisualStyleBackColor = true;
            tpuser_acc.Click += tpuser_acc_Click;
            // 
            // GroupPermissions
            // 
            GroupPermissions.BackColor = Color.Maroon;
            GroupPermissions.Controls.Add(ChkSearchRecords);
            GroupPermissions.Controls.Add(ChkSetting);
            GroupPermissions.Controls.Add(ChkReports);
            GroupPermissions.Controls.Add(ChkRepayment);
            GroupPermissions.Controls.Add(ChkPenalty);
            GroupPermissions.Controls.Add(ChkLoan);
            GroupPermissions.Controls.Add(ChkCustomer);
            GroupPermissions.FillColor = Color.Maroon;
            GroupPermissions.Font = new Font("Microsoft Sans Serif", 12F);
            GroupPermissions.ForeColor = Color.White;
            GroupPermissions.ForeDisableColor = Color.White;
            GroupPermissions.Location = new Point(586, 5);
            GroupPermissions.Margin = new Padding(4, 5, 4, 5);
            GroupPermissions.MinimumSize = new Size(1, 1);
            GroupPermissions.Name = "GroupPermissions";
            GroupPermissions.Padding = new Padding(0, 32, 0, 0);
            GroupPermissions.RectColor = Color.White;
            GroupPermissions.RectDisableColor = Color.Transparent;
            GroupPermissions.Size = new Size(246, 448);
            GroupPermissions.TabIndex = 13;
            GroupPermissions.Text = "User Permissions";
            GroupPermissions.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // ChkSearchRecords
            // 
            ChkSearchRecords.CheckBoxColor = Color.White;
            ChkSearchRecords.Font = new Font("Microsoft Sans Serif", 12F);
            ChkSearchRecords.ForeColor = Color.White;
            ChkSearchRecords.Location = new Point(29, 325);
            ChkSearchRecords.MinimumSize = new Size(1, 1);
            ChkSearchRecords.Name = "ChkSearchRecords";
            ChkSearchRecords.Size = new Size(188, 36);
            ChkSearchRecords.TabIndex = 6;
            ChkSearchRecords.Text = "Search Records";
            // 
            // ChkSetting
            // 
            ChkSetting.CheckBoxColor = Color.White;
            ChkSetting.Font = new Font("Microsoft Sans Serif", 12F);
            ChkSetting.ForeColor = Color.White;
            ChkSetting.Location = new Point(29, 376);
            ChkSetting.MinimumSize = new Size(1, 1);
            ChkSetting.Name = "ChkSetting";
            ChkSetting.Size = new Size(188, 36);
            ChkSetting.TabIndex = 5;
            ChkSetting.Text = "Setting";
            // 
            // ChkReports
            // 
            ChkReports.CheckBoxColor = Color.White;
            ChkReports.Font = new Font("Microsoft Sans Serif", 12F);
            ChkReports.ForeColor = Color.White;
            ChkReports.Location = new Point(29, 269);
            ChkReports.MinimumSize = new Size(1, 1);
            ChkReports.Name = "ChkReports";
            ChkReports.Size = new Size(188, 36);
            ChkReports.TabIndex = 4;
            ChkReports.Text = "Report";
            // 
            // ChkRepayment
            // 
            ChkRepayment.CheckBoxColor = Color.White;
            ChkRepayment.Font = new Font("Microsoft Sans Serif", 12F);
            ChkRepayment.ForeColor = Color.White;
            ChkRepayment.Location = new Point(29, 208);
            ChkRepayment.MinimumSize = new Size(1, 1);
            ChkRepayment.Name = "ChkRepayment";
            ChkRepayment.Size = new Size(188, 36);
            ChkRepayment.TabIndex = 3;
            ChkRepayment.Text = "Repayment";
            ChkRepayment.CheckedChanged += ChkRepayment_CheckedChanged;
            // 
            // ChkPenalty
            // 
            ChkPenalty.CheckBoxColor = Color.White;
            ChkPenalty.Font = new Font("Microsoft Sans Serif", 12F);
            ChkPenalty.ForeColor = Color.White;
            ChkPenalty.Location = new Point(29, 149);
            ChkPenalty.MinimumSize = new Size(1, 1);
            ChkPenalty.Name = "ChkPenalty";
            ChkPenalty.Size = new Size(188, 36);
            ChkPenalty.TabIndex = 2;
            ChkPenalty.Text = "Penalty and Interest";
            // 
            // ChkLoan
            // 
            ChkLoan.CheckBoxColor = Color.White;
            ChkLoan.Font = new Font("Microsoft Sans Serif", 12F);
            ChkLoan.ForeColor = Color.WhiteSmoke;
            ChkLoan.Location = new Point(29, 88);
            ChkLoan.MinimumSize = new Size(1, 1);
            ChkLoan.Name = "ChkLoan";
            ChkLoan.Size = new Size(188, 36);
            ChkLoan.TabIndex = 1;
            ChkLoan.Text = "Loan";
            // 
            // ChkCustomer
            // 
            ChkCustomer.BackColor = Color.Maroon;
            ChkCustomer.CheckBoxColor = Color.White;
            ChkCustomer.Font = new Font("Microsoft Sans Serif", 12F);
            ChkCustomer.ForeColor = Color.White;
            ChkCustomer.Location = new Point(29, 35);
            ChkCustomer.MinimumSize = new Size(1, 1);
            ChkCustomer.Name = "ChkCustomer";
            ChkCustomer.Size = new Size(188, 36);
            ChkCustomer.TabIndex = 0;
            ChkCustomer.Text = "Customer";
            // 
            // uiBtnview
            // 
            uiBtnview.FillColor = Color.Maroon;
            uiBtnview.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtnview.Location = new Point(123, 394);
            uiBtnview.MinimumSize = new Size(1, 1);
            uiBtnview.Name = "uiBtnview";
            uiBtnview.RectColor = Color.Maroon;
            uiBtnview.RectHoverColor = Color.Maroon;
            uiBtnview.RectPressColor = Color.Maroon;
            uiBtnview.RectSelectedColor = Color.Maroon;
            uiBtnview.Size = new Size(447, 44);
            uiBtnview.TabIndex = 12;
            uiBtnview.Text = "&VIEW";
            uiBtnview.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiBtnview.Click += uiBtnview_Click;
            // 
            // uiBtndelete
            // 
            uiBtndelete.FillColor = Color.Maroon;
            uiBtndelete.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtndelete.Location = new Point(445, 321);
            uiBtndelete.MinimumSize = new Size(1, 1);
            uiBtndelete.Name = "uiBtndelete";
            uiBtndelete.RectColor = Color.Maroon;
            uiBtndelete.RectHoverColor = Color.Maroon;
            uiBtndelete.RectPressColor = Color.Maroon;
            uiBtndelete.RectSelectedColor = Color.Maroon;
            uiBtndelete.Size = new Size(125, 44);
            uiBtndelete.TabIndex = 11;
            uiBtndelete.Text = "&DELETE";
            uiBtndelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiBtnupdate
            // 
            uiBtnupdate.FillColor = Color.Maroon;
            uiBtnupdate.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtnupdate.Location = new Point(285, 321);
            uiBtnupdate.MinimumSize = new Size(1, 1);
            uiBtnupdate.Name = "uiBtnupdate";
            uiBtnupdate.RectColor = Color.Maroon;
            uiBtnupdate.RectHoverColor = Color.Maroon;
            uiBtnupdate.RectPressColor = Color.Maroon;
            uiBtnupdate.RectSelectedColor = Color.Maroon;
            uiBtnupdate.Size = new Size(125, 44);
            uiBtnupdate.TabIndex = 10;
            uiBtnupdate.Text = "&UPDATE";
            uiBtnupdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiBtninsert
            // 
            uiBtninsert.FillColor = Color.Maroon;
            uiBtninsert.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtninsert.Location = new Point(123, 321);
            uiBtninsert.MinimumSize = new Size(1, 1);
            uiBtninsert.Name = "uiBtninsert";
            uiBtninsert.RectColor = Color.Maroon;
            uiBtninsert.RectHoverColor = Color.Maroon;
            uiBtninsert.RectPressColor = Color.Maroon;
            uiBtninsert.RectSelectedColor = Color.Maroon;
            uiBtninsert.Size = new Size(125, 44);
            uiBtninsert.TabIndex = 9;
            uiBtninsert.Text = "&INSERT";
            uiBtninsert.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiBtninsert.Click += uiBtninsert_Click;
            // 
            // txtProfile
            // 
            txtProfile.Font = new Font("Microsoft Sans Serif", 12F);
            txtProfile.ForeColor = Color.Maroon;
            txtProfile.Location = new Point(12, 258);
            txtProfile.Name = "txtProfile";
            txtProfile.Size = new Size(181, 29);
            txtProfile.TabIndex = 4;
            txtProfile.Text = "USER_PROFILE :";
            // 
            // txtUserEmail
            // 
            txtUserEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtUserEmail.ForeColor = Color.Maroon;
            txtUserEmail.Location = new Point(12, 199);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(168, 29);
            txtUserEmail.TabIndex = 3;
            txtUserEmail.Text = "USER_EMAIL :";
            // 
            // txtEmpName
            // 
            txtEmpName.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmpName.ForeColor = Color.Maroon;
            txtEmpName.Location = new Point(12, 135);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(168, 29);
            txtEmpName.TabIndex = 2;
            txtEmpName.Text = "USER_NAME :";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Microsoft Sans Serif", 12F);
            txtNewPass.ForeColor = Color.Maroon;
            txtNewPass.Location = new Point(12, 73);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(211, 29);
            txtNewPass.TabIndex = 1;
            txtNewPass.Text = "USER_PASSWORD :";
            // 
            // txtNewUser
            // 
            txtNewUser.Font = new Font("Microsoft Sans Serif", 12F);
            txtNewUser.ForeColor = Color.Maroon;
            txtNewUser.Location = new Point(12, 20);
            txtNewUser.Name = "txtNewUser";
            txtNewUser.Size = new Size(125, 29);
            txtNewUser.TabIndex = 0;
            txtNewUser.Text = "USER_ID :";
            // 
            // CboUserProfile
            // 
            CboUserProfile.DataSource = null;
            CboUserProfile.FillColor = Color.White;
            CboUserProfile.Font = new Font("Microsoft Sans Serif", 12F);
            CboUserProfile.ItemHoverColor = Color.FromArgb(155, 200, 255);
            CboUserProfile.Items.AddRange(new object[] { "MASTRER", "USER" });
            CboUserProfile.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            CboUserProfile.Location = new Point(230, 251);
            CboUserProfile.Margin = new Padding(4, 5, 4, 5);
            CboUserProfile.MinimumSize = new Size(63, 0);
            CboUserProfile.Name = "CboUserProfile";
            CboUserProfile.Padding = new Padding(0, 0, 30, 2);
            CboUserProfile.RectColor = Color.Maroon;
            CboUserProfile.Size = new Size(302, 36);
            CboUserProfile.SymbolSize = 24;
            CboUserProfile.TabIndex = 8;
            CboUserProfile.TextAlignment = ContentAlignment.MiddleLeft;
            CboUserProfile.Watermark = "";
            CboUserProfile.SelectedIndexChanged += uicboUserProfile_SelectedIndexChanged;
            // 
            // uitxtUserEmail
            // 
            uitxtUserEmail.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtUserEmail.Location = new Point(230, 192);
            uitxtUserEmail.Margin = new Padding(4, 5, 4, 5);
            uitxtUserEmail.MinimumSize = new Size(1, 16);
            uitxtUserEmail.Name = "uitxtUserEmail";
            uitxtUserEmail.Padding = new Padding(5);
            uitxtUserEmail.RectColor = Color.Maroon;
            uitxtUserEmail.ShowText = false;
            uitxtUserEmail.Size = new Size(302, 36);
            uitxtUserEmail.TabIndex = 7;
            uitxtUserEmail.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtUserEmail.Watermark = "";
            // 
            // uitxtUserName
            // 
            uitxtUserName.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtUserName.Location = new Point(230, 128);
            uitxtUserName.Margin = new Padding(4, 5, 4, 5);
            uitxtUserName.MinimumSize = new Size(1, 16);
            uitxtUserName.Name = "uitxtUserName";
            uitxtUserName.Padding = new Padding(5);
            uitxtUserName.RectColor = Color.Maroon;
            uitxtUserName.ShowText = false;
            uitxtUserName.Size = new Size(302, 36);
            uitxtUserName.TabIndex = 6;
            uitxtUserName.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtUserName.Watermark = "";
            // 
            // uitxtUserPassword
            // 
            uitxtUserPassword.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtUserPassword.Location = new Point(230, 68);
            uitxtUserPassword.Margin = new Padding(4, 5, 4, 5);
            uitxtUserPassword.MinimumSize = new Size(1, 16);
            uitxtUserPassword.Name = "uitxtUserPassword";
            uitxtUserPassword.Padding = new Padding(5);
            uitxtUserPassword.RectColor = Color.Maroon;
            uitxtUserPassword.ShowText = false;
            uitxtUserPassword.Size = new Size(302, 36);
            uitxtUserPassword.TabIndex = 6;
            uitxtUserPassword.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtUserPassword.Watermark = "";
            // 
            // uitxtUserID
            // 
            uitxtUserID.ButtonFillColor = Color.Maroon;
            uitxtUserID.ButtonStyleInherited = false;
            uitxtUserID.Font = new Font("Microsoft Sans Serif", 12F);
            uitxtUserID.Location = new Point(230, 14);
            uitxtUserID.Margin = new Padding(4, 5, 4, 5);
            uitxtUserID.MinimumSize = new Size(1, 16);
            uitxtUserID.Name = "uitxtUserID";
            uitxtUserID.Padding = new Padding(5);
            uitxtUserID.RectColor = Color.Maroon;
            uitxtUserID.ShowText = false;
            uitxtUserID.Size = new Size(302, 36);
            uitxtUserID.TabIndex = 5;
            uitxtUserID.TextAlignment = ContentAlignment.MiddleLeft;
            uitxtUserID.Watermark = "";
            // 
            // tpRepayment
            // 
            tpRepayment.Controls.Add(uiLabel4);
            tpRepayment.Controls.Add(uiLabel3);
            tpRepayment.Controls.Add(uiLabel2);
            tpRepayment.Controls.Add(uiLabel1);
            tpRepayment.Controls.Add(btnSaveRepayment);
            tpRepayment.Controls.Add(BtnSearch);
            tpRepayment.Controls.Add(txtTotalAmount);
            tpRepayment.Controls.Add(txtInterestRate);
            tpRepayment.Controls.Add(txtTotalAmoun);
            tpRepayment.Controls.Add(txtPayAmount);
            tpRepayment.Controls.Add(txtSearchLoanID);
            tpRepayment.Location = new Point(201, 0);
            tpRepayment.Name = "tpRepayment";
            tpRepayment.Size = new Size(837, 453);
            tpRepayment.TabIndex = 8;
            tpRepayment.Text = "Repayment";
            tpRepayment.UseVisualStyleBackColor = true;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(3, 319);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(125, 29);
            uiLabel4.TabIndex = 9;
            uiLabel4.Text = "PAY NOW :";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(3, 261);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(197, 29);
            uiLabel3.TabIndex = 8;
            uiLabel3.Text = "TOATL AMOUNT :";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(2, 198);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(212, 29);
            uiLabel2.TabIndex = 7;
            uiLabel2.Text = "INTEREST RATE(%) :";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(17, 139);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 6;
            uiLabel1.Text = "AMOUNT :";
            // 
            // btnSaveRepayment
            // 
            btnSaveRepayment.FillColor = Color.FromArgb(192, 0, 0);
            btnSaveRepayment.Font = new Font("Microsoft Sans Serif", 12F);
            btnSaveRepayment.Location = new Point(356, 379);
            btnSaveRepayment.MinimumSize = new Size(1, 1);
            btnSaveRepayment.Name = "btnSaveRepayment";
            btnSaveRepayment.RectColor = Color.FromArgb(192, 0, 0);
            btnSaveRepayment.Size = new Size(196, 44);
            btnSaveRepayment.TabIndex = 5;
            btnSaveRepayment.Text = "SAVE &REPAYMENT";
            btnSaveRepayment.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSaveRepayment.Click += btnSaveRepayment_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.FillColor = Color.FromArgb(192, 0, 0);
            BtnSearch.Font = new Font("Microsoft Sans Serif", 12F);
            BtnSearch.Location = new Point(390, 70);
            BtnSearch.MinimumSize = new Size(1, 1);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.RectColor = Color.FromArgb(192, 0, 0);
            BtnSearch.Size = new Size(125, 44);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "SEARCH";
            BtnSearch.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnSearch.Click += BtnSearch_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Microsoft Sans Serif", 12F);
            txtTotalAmount.Location = new Point(221, 139);
            txtTotalAmount.Margin = new Padding(4, 5, 4, 5);
            txtTotalAmount.MinimumSize = new Size(1, 16);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Padding = new Padding(5);
            txtTotalAmount.RectColor = Color.FromArgb(192, 0, 0);
            txtTotalAmount.ShowText = false;
            txtTotalAmount.Size = new Size(458, 36);
            txtTotalAmount.TabIndex = 3;
            txtTotalAmount.TextAlignment = ContentAlignment.MiddleLeft;
            txtTotalAmount.Watermark = "";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Font = new Font("Microsoft Sans Serif", 12F);
            txtInterestRate.Location = new Point(221, 191);
            txtInterestRate.Margin = new Padding(4, 5, 4, 5);
            txtInterestRate.MinimumSize = new Size(1, 16);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Padding = new Padding(5);
            txtInterestRate.RectColor = Color.FromArgb(192, 0, 0);
            txtInterestRate.ShowText = false;
            txtInterestRate.Size = new Size(458, 36);
            txtInterestRate.TabIndex = 3;
            txtInterestRate.TextAlignment = ContentAlignment.MiddleLeft;
            txtInterestRate.Watermark = "";
            // 
            // txtTotalAmoun
            // 
            txtTotalAmoun.Font = new Font("Microsoft Sans Serif", 12F);
            txtTotalAmoun.Location = new Point(221, 254);
            txtTotalAmoun.Margin = new Padding(4, 5, 4, 5);
            txtTotalAmoun.MinimumSize = new Size(1, 16);
            txtTotalAmoun.Name = "txtTotalAmoun";
            txtTotalAmoun.Padding = new Padding(5);
            txtTotalAmoun.RectColor = Color.FromArgb(192, 0, 0);
            txtTotalAmoun.ShowText = false;
            txtTotalAmoun.Size = new Size(458, 36);
            txtTotalAmoun.TabIndex = 3;
            txtTotalAmoun.TextAlignment = ContentAlignment.MiddleLeft;
            txtTotalAmoun.Watermark = "";
            // 
            // txtPayAmount
            // 
            txtPayAmount.Font = new Font("Microsoft Sans Serif", 12F);
            txtPayAmount.Location = new Point(221, 312);
            txtPayAmount.Margin = new Padding(4, 5, 4, 5);
            txtPayAmount.MinimumSize = new Size(1, 16);
            txtPayAmount.Name = "txtPayAmount";
            txtPayAmount.Padding = new Padding(5);
            txtPayAmount.RectColor = Color.FromArgb(192, 0, 0);
            txtPayAmount.ShowText = false;
            txtPayAmount.Size = new Size(458, 36);
            txtPayAmount.TabIndex = 3;
            txtPayAmount.TextAlignment = ContentAlignment.MiddleLeft;
            txtPayAmount.Watermark = "";
            // 
            // txtSearchLoanID
            // 
            txtSearchLoanID.ButtonFillColor = Color.Blue;
            txtSearchLoanID.ButtonStyleInherited = false;
            txtSearchLoanID.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearchLoanID.Location = new Point(221, 14);
            txtSearchLoanID.Margin = new Padding(4, 5, 4, 5);
            txtSearchLoanID.MinimumSize = new Size(1, 16);
            txtSearchLoanID.Name = "txtSearchLoanID";
            txtSearchLoanID.Padding = new Padding(5);
            txtSearchLoanID.RectColor = Color.FromArgb(192, 0, 0);
            txtSearchLoanID.ShowText = false;
            txtSearchLoanID.Size = new Size(458, 36);
            txtSearchLoanID.TabIndex = 0;
            txtSearchLoanID.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchLoanID.Watermark = "";
            txtSearchLoanID.TextChanged += uiTextBox1_TextChanged;
            // 
            // tpSearchRecords
            // 
            tpSearchRecords.Controls.Add(dgvRecords);
            tpSearchRecords.Controls.Add(BtnResearch);
            tpSearchRecords.Controls.Add(BtnRefresh);
            tpSearchRecords.Controls.Add(BtnBack);
            tpSearchRecords.Controls.Add(TxtTotalAmounts);
            tpSearchRecords.Controls.Add(TxtTotalCustomers);
            tpSearchRecords.Controls.Add(TxtTotalLoans);
            tpSearchRecords.Controls.Add(TxtSearch);
            tpSearchRecords.Controls.Add(LblTotalAmounts);
            tpSearchRecords.Controls.Add(LblTotalLoans);
            tpSearchRecords.Controls.Add(LblTotalCustomers);
            tpSearchRecords.Controls.Add(LblSearch);
            tpSearchRecords.Controls.Add(uiPanel1);
            tpSearchRecords.Location = new Point(201, 0);
            tpSearchRecords.Name = "tpSearchRecords";
            tpSearchRecords.Size = new Size(837, 453);
            tpSearchRecords.TabIndex = 9;
            tpSearchRecords.Text = "Search Records";
            tpSearchRecords.UseVisualStyleBackColor = true;
            // 
            // dgvRecords
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecords.BackgroundColor = Color.White;
            dgvRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRecords.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecords.EnableHeadersVisualStyles = false;
            dgvRecords.Font = new Font("Microsoft Sans Serif", 12F);
            dgvRecords.GridColor = Color.FromArgb(80, 160, 255);
            dgvRecords.Location = new Point(31, 151);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RectColor = Color.Maroon;
            dgvRecords.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRecords.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvRecords.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRecords.SelectedIndex = -1;
            dgvRecords.Size = new Size(778, 103);
            dgvRecords.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvRecords.TabIndex = 6;
            // 
            // BtnResearch
            // 
            BtnResearch.FillColor = Color.Maroon;
            BtnResearch.Font = new Font("Microsoft Sans Serif", 12F);
            BtnResearch.Location = new Point(624, 94);
            BtnResearch.MinimumSize = new Size(1, 1);
            BtnResearch.Name = "BtnResearch";
            BtnResearch.Size = new Size(185, 36);
            BtnResearch.TabIndex = 3;
            BtnResearch.Text = "Search";
            BtnResearch.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnResearch.Click += BtnResearch_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.FillColor = Color.Maroon;
            BtnRefresh.Font = new Font("Microsoft Sans Serif", 12F);
            BtnRefresh.Location = new Point(38, 363);
            BtnRefresh.MinimumSize = new Size(1, 1);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.RectColor = Color.LightCoral;
            BtnRefresh.Size = new Size(134, 44);
            BtnRefresh.TabIndex = 4;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // BtnBack
            // 
            BtnBack.FillColor = Color.Maroon;
            BtnBack.Font = new Font("Microsoft Sans Serif", 12F);
            BtnBack.Location = new Point(684, 363);
            BtnBack.MinimumSize = new Size(1, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.RectColor = Color.LightCoral;
            BtnBack.Size = new Size(125, 44);
            BtnBack.TabIndex = 5;
            BtnBack.Text = "Back";
            BtnBack.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtTotalAmounts
            // 
            TxtTotalAmounts.Font = new Font("Microsoft Sans Serif", 12F);
            TxtTotalAmounts.Location = new Point(709, 291);
            TxtTotalAmounts.Margin = new Padding(4, 5, 4, 5);
            TxtTotalAmounts.MinimumSize = new Size(1, 16);
            TxtTotalAmounts.Name = "TxtTotalAmounts";
            TxtTotalAmounts.Padding = new Padding(5);
            TxtTotalAmounts.RectColor = Color.Firebrick;
            TxtTotalAmounts.ShowText = false;
            TxtTotalAmounts.Size = new Size(100, 36);
            TxtTotalAmounts.TabIndex = 3;
            TxtTotalAmounts.TextAlignment = ContentAlignment.MiddleLeft;
            TxtTotalAmounts.Watermark = "";
            // 
            // TxtTotalCustomers
            // 
            TxtTotalCustomers.Font = new Font("Microsoft Sans Serif", 12F);
            TxtTotalCustomers.Location = new Point(207, 291);
            TxtTotalCustomers.Margin = new Padding(4, 5, 4, 5);
            TxtTotalCustomers.MinimumSize = new Size(1, 16);
            TxtTotalCustomers.Name = "TxtTotalCustomers";
            TxtTotalCustomers.Padding = new Padding(5);
            TxtTotalCustomers.RectColor = Color.Maroon;
            TxtTotalCustomers.ShowText = false;
            TxtTotalCustomers.Size = new Size(57, 36);
            TxtTotalCustomers.TabIndex = 3;
            TxtTotalCustomers.TextAlignment = ContentAlignment.MiddleLeft;
            TxtTotalCustomers.Watermark = "";
            // 
            // TxtTotalLoans
            // 
            TxtTotalLoans.Font = new Font("Microsoft Sans Serif", 12F);
            TxtTotalLoans.Location = new Point(437, 291);
            TxtTotalLoans.Margin = new Padding(4, 5, 4, 5);
            TxtTotalLoans.MinimumSize = new Size(1, 16);
            TxtTotalLoans.Name = "TxtTotalLoans";
            TxtTotalLoans.Padding = new Padding(5);
            TxtTotalLoans.RectColor = Color.Maroon;
            TxtTotalLoans.ShowText = false;
            TxtTotalLoans.Size = new Size(60, 36);
            TxtTotalLoans.TabIndex = 3;
            TxtTotalLoans.TextAlignment = ContentAlignment.MiddleLeft;
            TxtTotalLoans.Watermark = "";
            // 
            // TxtSearch
            // 
            TxtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            TxtSearch.Location = new Point(238, 94);
            TxtSearch.Margin = new Padding(4, 5, 4, 5);
            TxtSearch.MinimumSize = new Size(1, 16);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Padding = new Padding(5);
            TxtSearch.RectColor = Color.Maroon;
            TxtSearch.ShowText = false;
            TxtSearch.Size = new Size(360, 36);
            TxtSearch.TabIndex = 5;
            TxtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            TxtSearch.Watermark = "";
            // 
            // LblTotalAmounts
            // 
            LblTotalAmounts.Font = new Font("Microsoft Sans Serif", 12F);
            LblTotalAmounts.ForeColor = Color.FromArgb(48, 48, 48);
            LblTotalAmounts.Location = new Point(541, 298);
            LblTotalAmounts.Name = "LblTotalAmounts";
            LblTotalAmounts.Size = new Size(190, 29);
            LblTotalAmounts.TabIndex = 4;
            LblTotalAmounts.Text = "Total Amounts:";
            // 
            // LblTotalLoans
            // 
            LblTotalLoans.Font = new Font("Microsoft Sans Serif", 12F);
            LblTotalLoans.ForeColor = Color.FromArgb(48, 48, 48);
            LblTotalLoans.Location = new Point(305, 298);
            LblTotalLoans.Name = "LblTotalLoans";
            LblTotalLoans.Size = new Size(125, 29);
            LblTotalLoans.TabIndex = 3;
            LblTotalLoans.Text = "Total Loans:";
            // 
            // LblTotalCustomers
            // 
            LblTotalCustomers.Font = new Font("Microsoft Sans Serif", 12F);
            LblTotalCustomers.ForeColor = Color.FromArgb(48, 48, 48);
            LblTotalCustomers.Location = new Point(31, 298);
            LblTotalCustomers.Name = "LblTotalCustomers";
            LblTotalCustomers.Size = new Size(169, 29);
            LblTotalCustomers.TabIndex = 2;
            LblTotalCustomers.Text = "Total Customers:";
            // 
            // LblSearch
            // 
            LblSearch.Font = new Font("Microsoft Sans Serif", 12F);
            LblSearch.ForeColor = Color.FromArgb(48, 48, 48);
            LblSearch.Location = new Point(31, 101);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(200, 29);
            LblSearch.TabIndex = 1;
            LblSearch.Text = "Search Customer:";
            // 
            // uiPanel1
            // 
            uiPanel1.FillColor = Color.Firebrick;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.ForeColor = Color.White;
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.Red;
            uiPanel1.Size = new Size(837, 56);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = "LOAN RECORDS";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 450);
            Controls.Add(uiTabControlMenu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Micro Loan Managermenet System";
            Load += Form1_Load;
            tpReports.ResumeLayout(false);
            uiRichTextBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpLoan.ResumeLayout(false);
            tpLogin.ResumeLayout(false);
            uiTabControlMenu1.ResumeLayout(false);
            tpuser_acc.ResumeLayout(false);
            GroupPermissions.ResumeLayout(false);
            tpRepayment.ResumeLayout(false);
            tpSearchRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpSetting;
        private TabPage tpPenalty;
        private TabPage tpReports;
        private TabPage tpLoan;
        private TabPage tpCustomer;
        private TabPage tpLogin;
        private Sunny.UI.UIButton uiBtnLogin;
        private Sunny.UI.UITextBox USER_PWD;
        private Sunny.UI.UITextBox USER_NAME;
        private Sunny.UI.UILabel uiLblPWD;
        private Sunny.UI.UILabel uiLblUSER_NAME;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tpRepayment;
        private Sunny.UI.UITextBox txtSearchLoanID;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnSaveRepayment;
        private Sunny.UI.UIButton BtnSearch;
        private Sunny.UI.UITextBox txtTotalAmount;
        private Sunny.UI.UITextBox txtInterestRate;
        private Sunny.UI.UITextBox txtTotalAmoun;
        private Sunny.UI.UITextBox txtPayAmount;
        private TabPage tpuser_acc;
        private Sunny.UI.UIButton uiBtnview;
        private Sunny.UI.UIButton uiBtndelete;
        private Sunny.UI.UIButton uiBtnupdate;
        private Sunny.UI.UIButton uiBtninsert;
        private Sunny.UI.UILabel txtProfile;
        private Sunny.UI.UILabel txtUserEmail;
        private Sunny.UI.UILabel txtEmpName;
        private Sunny.UI.UILabel txtNewPass;
        private Sunny.UI.UILabel txtNewUser;
        private Sunny.UI.UITextBox uitxtUserID;
        private Sunny.UI.UITextBox uitxtUserPassword;
        private Sunny.UI.UITextBox uitxtUserName;
        private Sunny.UI.UITextBox uitxtUserEmail;
        private Sunny.UI.UIComboBox CboUserProfile;
        private Sunny.UI.UITextBox txtLoanTerm;
        private Sunny.UI.UITextBox txtLoanInterestRate;
        private Sunny.UI.UITextBox txtLoanAmount;
        private Sunny.UI.UIComboBox cboLoanCustomer;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIGroupBox GroupPermissions;
        private Sunny.UI.UICheckBox ChkSetting;
        private Sunny.UI.UICheckBox ChkReports;
        private Sunny.UI.UICheckBox ChkRepayment;
        private Sunny.UI.UICheckBox ChkPenalty;
        private Sunny.UI.UICheckBox ChkLoan;
        private Sunny.UI.UICheckBox ChkCustomer;
        private ListView lvLoanReport;
        private Sunny.UI.UIButton BtnCaculate;
        private PictureBox pictureBox1;
        private Sunny.UI.UIButton BtnNext;
        private Sunny.UI.UIButton BtnCancel;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UILabel LblTitle;
        private TabPage tpSearchRecords;
        private Sunny.UI.UICheckBox ChkSearchRecords;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton BtnBack;
        private Sunny.UI.UITextBox TxtTotalAmounts;
        private Sunny.UI.UIButton BtnRefresh;
        private Sunny.UI.UIButton BtnResearch;
        private Sunny.UI.UITextBox TxtTotalCustomers;
        private Sunny.UI.UITextBox TxtTotalLoans;
        private Sunny.UI.UITextBox TxtSearch;
        private Sunny.UI.UILabel LblTotalAmounts;
        private Sunny.UI.UILabel LblTotalLoans;
        private Sunny.UI.UILabel LblTotalCustomers;
        private Sunny.UI.UILabel LblSearch;
        private Sunny.UI.UIDataGridView dgvRecords;
    }
}
