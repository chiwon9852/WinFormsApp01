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
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tpLogin = new TabPage();
            uiBtnLogin = new Sunny.UI.UIButton();
            USER_PWD = new Sunny.UI.UITextBox();
            USER_NAME = new Sunny.UI.UITextBox();
            uiLblPWD = new Sunny.UI.UILabel();
            uiLblUSER_NAME = new Sunny.UI.UILabel();
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
            tpCustomer = new TabPage();
            tpLaon = new TabPage();
            tpPayment = new TabPage();
            tpReports = new TabPage();
            tpUser = new TabPage();
            tpSetting = new TabPage();
            uiTabControlMenu1.SuspendLayout();
            tpLogin.SuspendLayout();
            tpuser_acc.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(tpLogin);
            uiTabControlMenu1.Controls.Add(tpuser_acc);
            uiTabControlMenu1.Controls.Add(tpCustomer);
            uiTabControlMenu1.Controls.Add(tpLaon);
            uiTabControlMenu1.Controls.Add(tpPayment);
            uiTabControlMenu1.Controls.Add(tpReports);
            uiTabControlMenu1.Controls.Add(tpUser);
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
            // tpLogin
            // 
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
            tpLogin.UseVisualStyleBackColor = true;
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
            // tpCustomer
            // 
            tpCustomer.Location = new Point(201, 0);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Size = new Size(602, 453);
            tpCustomer.TabIndex = 1;
            tpCustomer.Text = "Customer";
            tpCustomer.UseVisualStyleBackColor = true;
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
            // tpPayment
            // 
            tpPayment.Location = new Point(201, 0);
            tpPayment.Name = "tpPayment";
            tpPayment.Size = new Size(602, 453);
            tpPayment.TabIndex = 3;
            tpPayment.Text = "Payment";
            tpPayment.UseVisualStyleBackColor = true;
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
            // tpUser
            // 
            tpUser.Location = new Point(201, 0);
            tpUser.Name = "tpUser";
            tpUser.Size = new Size(602, 453);
            tpUser.TabIndex = 5;
            tpUser.Text = "User";
            tpUser.UseVisualStyleBackColor = true;
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
            uiTabControlMenu1.ResumeLayout(false);
            tpLogin.ResumeLayout(false);
            tpuser_acc.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tpLogin;
        private TabPage tpCustomer;
        private TabPage tpLaon;
        private TabPage tpPayment;
        private TabPage tpReports;
        private TabPage tpUser;
        private TabPage tpSetting;
        private Sunny.UI.UILabel uiLblUSER_NAME;
        private Sunny.UI.UILabel uiLblPWD;
        private Sunny.UI.UIButton uiBtnLogin;
        private Sunny.UI.UITextBox USER_PWD;
        private Sunny.UI.UITextBox USER_NAME;
        private TabPage tpuser_acc;
        private Sunny.UI.UILabel txtUserEmail;
        private Sunny.UI.UILabel txtEmpName;
        private Sunny.UI.UILabel txtNewPass;
        private Sunny.UI.UILabel txtNewUser;
        private Sunny.UI.UILabel txtProfile;
        private Sunny.UI.UIComboBox uicboUserProfile;
        private Sunny.UI.UITextBox uitxtUserEmail;
        private Sunny.UI.UITextBox uitxtUserName;
        private Sunny.UI.UITextBox uitxtUserPassword;
        private Sunny.UI.UITextBox uitxtUserID;
        private Sunny.UI.UIButton uiBtninsert;
        private Sunny.UI.UIButton uiBtnview;
        private Sunny.UI.UIButton uiBtndelete;
        private Sunny.UI.UIButton uiBtnupdate;
    }
}
