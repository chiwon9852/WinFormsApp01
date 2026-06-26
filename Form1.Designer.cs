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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tpSetting = new TabPage();
            tpPI = new TabPage();
            tpReports = new TabPage();
            tpLaon = new TabPage();
            tpCustomer = new TabPage();
            tpuser_acc = new TabPage();
            uiBtnview = new Sunny.UI.UIButton();
            uiBtndelete = new Sunny.UI.UIButton();
            uiBtnupdate = new Sunny.UI.UIButton();
            uiBtninsert = new Sunny.UI.UIButton();
            uicboUserProfile = new Sunny.UI.UIComboBox();
            uitxtUserEmail = new Sunny.UI.UITextBox();
            uitxtUserName = new Sunny.UI.UITextBox();
            uitxtUserPassword = new Sunny.UI.UITextBox();
            uitxtUserID = new Sunny.UI.UITextBox();
            txtProfile = new Sunny.UI.UILabel();
            txtUserEmail = new Sunny.UI.UILabel();
            txtEmpName = new Sunny.UI.UILabel();
            txtNewPass = new Sunny.UI.UILabel();
            txtNewUser = new Sunny.UI.UILabel();
            tpLogin = new TabPage();
            uiBtnLogin = new Sunny.UI.UIButton();
            USER_PWD = new Sunny.UI.UITextBox();
            USER_NAME = new Sunny.UI.UITextBox();
            uiLblPWD = new Sunny.UI.UILabel();
            uiLblUSER_NAME = new Sunny.UI.UILabel();
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tpRP = new TabPage();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiTextBox4 = new Sunny.UI.UITextBox();
            uiTextBox5 = new Sunny.UI.UITextBox();
            BtnSearch = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            tpuser_acc.SuspendLayout();
            tpLogin.SuspendLayout();
            uiTabControlMenu1.SuspendLayout();
            tpRP.SuspendLayout();
            SuspendLayout();
            // 
            // tpSetting
            // 
            tpSetting.Location = new Point(201, 0);
            tpSetting.Name = "tpSetting";
            tpSetting.Size = new Size(602, 453);
            tpSetting.TabIndex = 6;
            tpSetting.Text = "Setting";
            tpSetting.UseVisualStyleBackColor = true;
            // 
            // tpPI
            // 
            tpPI.Location = new Point(201, 0);
            tpPI.Name = "tpPI";
            tpPI.Size = new Size(602, 453);
            tpPI.TabIndex = 5;
            tpPI.Text = "Panalty and interest";
            tpPI.UseVisualStyleBackColor = true;
            // 
            // tpReports
            // 
            tpReports.Location = new Point(201, 0);
            tpReports.Name = "tpReports";
            tpReports.Size = new Size(602, 453);
            tpReports.TabIndex = 4;
            tpReports.Text = "Reports";
            tpReports.UseVisualStyleBackColor = true;
            // 
            // tpLaon
            // 
            tpLaon.Location = new Point(201, 0);
            tpLaon.Name = "tpLaon";
            tpLaon.Size = new Size(602, 453);
            tpLaon.TabIndex = 2;
            tpLaon.Text = "Laon";
            tpLaon.UseVisualStyleBackColor = true;
            // 
            // tpCustomer
            // 
            tpCustomer.Location = new Point(201, 0);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Size = new Size(602, 453);
            tpCustomer.TabIndex = 1;
            tpCustomer.Text = "Customer";
            tpCustomer.UseVisualStyleBackColor = true;
            // 
            // tpuser_acc
            // 
            tpuser_acc.Controls.Add(uiBtnview);
            tpuser_acc.Controls.Add(uiBtndelete);
            tpuser_acc.Controls.Add(uiBtnupdate);
            tpuser_acc.Controls.Add(uiBtninsert);
            tpuser_acc.Controls.Add(uicboUserProfile);
            tpuser_acc.Controls.Add(uitxtUserEmail);
            tpuser_acc.Controls.Add(uitxtUserName);
            tpuser_acc.Controls.Add(uitxtUserPassword);
            tpuser_acc.Controls.Add(uitxtUserID);
            tpuser_acc.Controls.Add(txtProfile);
            tpuser_acc.Controls.Add(txtUserEmail);
            tpuser_acc.Controls.Add(txtEmpName);
            tpuser_acc.Controls.Add(txtNewPass);
            tpuser_acc.Controls.Add(txtNewUser);
            tpuser_acc.Location = new Point(201, 0);
            tpuser_acc.Name = "tpuser_acc";
            tpuser_acc.Size = new Size(602, 453);
            tpuser_acc.TabIndex = 7;
            tpuser_acc.Text = "USER_ACCOUNT";
            tpuser_acc.UseVisualStyleBackColor = true;
            tpuser_acc.Click += tpuser_acc_Click;
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
            // uicboUserProfile
            // 
            uicboUserProfile.DataSource = null;
            uicboUserProfile.FillColor = Color.White;
            uicboUserProfile.Font = new Font("Microsoft Sans Serif", 12F);
            uicboUserProfile.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uicboUserProfile.Items.AddRange(new object[] { "MASTRER", "USER" });
            uicboUserProfile.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uicboUserProfile.Location = new Point(230, 251);
            uicboUserProfile.Margin = new Padding(4, 5, 4, 5);
            uicboUserProfile.MinimumSize = new Size(63, 0);
            uicboUserProfile.Name = "uicboUserProfile";
            uicboUserProfile.Padding = new Padding(0, 0, 30, 2);
            uicboUserProfile.RectColor = Color.Maroon;
            uicboUserProfile.Size = new Size(302, 36);
            uicboUserProfile.SymbolSize = 24;
            uicboUserProfile.TabIndex = 8;
            uicboUserProfile.TextAlignment = ContentAlignment.MiddleLeft;
            uicboUserProfile.Watermark = "";
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
            txtNewPass.Location = new Point(12, 75);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(224, 29);
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
            tpLogin.Size = new Size(602, 453);
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
            uiTabControlMenu1.Controls.Add(tpLaon);
            uiTabControlMenu1.Controls.Add(tpPI);
            uiTabControlMenu1.Controls.Add(tpRP);
            uiTabControlMenu1.Controls.Add(tpReports);
            uiTabControlMenu1.Controls.Add(tpSetting);
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMenu1.Location = new Point(0, 0);
            uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(803, 453);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabBackColor = Color.Maroon;
            uiTabControlMenu1.TabIndex = 0;
            uiTabControlMenu1.TabSelectedColor = Color.GhostWhite;
            uiTabControlMenu1.TabSelectedForeColor = Color.Maroon;
            uiTabControlMenu1.TabSelectedHighColor = Color.Transparent;
            uiTabControlMenu1.TabUnSelectedForeColor = Color.WhiteSmoke;
            // 
            // tpRP
            // 
            tpRP.Controls.Add(uiLabel4);
            tpRP.Controls.Add(uiLabel3);
            tpRP.Controls.Add(uiLabel2);
            tpRP.Controls.Add(uiLabel1);
            tpRP.Controls.Add(uiButton2);
            tpRP.Controls.Add(BtnSearch);
            tpRP.Controls.Add(uiTextBox2);
            tpRP.Controls.Add(uiTextBox3);
            tpRP.Controls.Add(uiTextBox4);
            tpRP.Controls.Add(uiTextBox5);
            tpRP.Controls.Add(uiTextBox1);
            tpRP.Location = new Point(201, 0);
            tpRP.Name = "tpRP";
            tpRP.Size = new Size(602, 453);
            tpRP.TabIndex = 8;
            tpRP.Text = "Repayment";
            tpRP.UseVisualStyleBackColor = true;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox1.Location = new Point(56, 5);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(458, 36);
            uiTextBox1.TabIndex = 0;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox2.Location = new Point(132, 141);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(458, 36);
            uiTextBox2.TabIndex = 3;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox3.Location = new Point(132, 203);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(458, 36);
            uiTextBox3.TabIndex = 3;
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
            // 
            // uiTextBox4
            // 
            uiTextBox4.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox4.Location = new Point(132, 257);
            uiTextBox4.Margin = new Padding(4, 5, 4, 5);
            uiTextBox4.MinimumSize = new Size(1, 16);
            uiTextBox4.Name = "uiTextBox4";
            uiTextBox4.Padding = new Padding(5);
            uiTextBox4.ShowText = false;
            uiTextBox4.Size = new Size(458, 36);
            uiTextBox4.TabIndex = 3;
            uiTextBox4.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox4.Watermark = "";
            // 
            // uiTextBox5
            // 
            uiTextBox5.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox5.Location = new Point(132, 312);
            uiTextBox5.Margin = new Padding(4, 5, 4, 5);
            uiTextBox5.MinimumSize = new Size(1, 16);
            uiTextBox5.Name = "uiTextBox5";
            uiTextBox5.Padding = new Padding(5);
            uiTextBox5.ShowText = false;
            uiTextBox5.Size = new Size(458, 36);
            uiTextBox5.TabIndex = 3;
            uiTextBox5.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox5.Watermark = "";
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new Font("Microsoft Sans Serif", 12F);
            BtnSearch.Location = new Point(209, 62);
            BtnSearch.MinimumSize = new Size(1, 1);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(125, 44);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "SEARCH";
            BtnSearch.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton2.Location = new Point(294, 381);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(125, 44);
            uiButton2.TabIndex = 5;
            uiButton2.Text = "uiButton2";
            uiButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(0, 148);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 6;
            uiLabel1.Text = "uiLabel1";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(0, 203);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 7;
            uiLabel2.Text = "uiLabel2";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(0, 257);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 29);
            uiLabel3.TabIndex = 8;
            uiLabel3.Text = "uiLabel3";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(0, 319);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(125, 29);
            uiLabel4.TabIndex = 9;
            uiLabel4.Text = "uiLabel4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uiTabControlMenu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Micro Loan Managermenet System";
            Load += Form1_Load;
            tpuser_acc.ResumeLayout(false);
            tpLogin.ResumeLayout(false);
            uiTabControlMenu1.ResumeLayout(false);
            tpRP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpSetting;
        private TabPage tpPI;
        private TabPage tpReports;
        private TabPage tpLaon;
        private TabPage tpCustomer;
        private TabPage tpuser_acc;
        private Sunny.UI.UIButton uiBtnview;
        private Sunny.UI.UIButton uiBtndelete;
        private Sunny.UI.UIButton uiBtnupdate;
        private Sunny.UI.UIButton uiBtninsert;
        private Sunny.UI.UIComboBox uicboUserProfile;
        private Sunny.UI.UITextBox uitxtUserEmail;
        private Sunny.UI.UITextBox uitxtUserName;
        private Sunny.UI.UITextBox uitxtUserPassword;
        private Sunny.UI.UITextBox uitxtUserID;
        private Sunny.UI.UILabel txtProfile;
        private Sunny.UI.UILabel txtUserEmail;
        private Sunny.UI.UILabel txtEmpName;
        private Sunny.UI.UILabel txtNewPass;
        private Sunny.UI.UILabel txtNewUser;
        private TabPage tpLogin;
        private Sunny.UI.UIButton uiBtnLogin;
        private Sunny.UI.UITextBox USER_PWD;
        private Sunny.UI.UITextBox USER_NAME;
        private Sunny.UI.UILabel uiLblPWD;
        private Sunny.UI.UILabel uiLblUSER_NAME;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tpRP;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton BtnSearch;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox uiTextBox5;
    }
}
