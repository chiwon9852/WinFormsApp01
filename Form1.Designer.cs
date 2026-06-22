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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            uiTabControlMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(tabPage1);
            uiTabControlMenu1.Controls.Add(tabPage2);
            uiTabControlMenu1.Controls.Add(tabPage3);
            uiTabControlMenu1.Controls.Add(tabPage4);
            uiTabControlMenu1.Controls.Add(tabPage5);
            uiTabControlMenu1.Controls.Add(tabPage6);
            uiTabControlMenu1.Controls.Add(tabPage7);
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
            // tabPage1
            // 
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(602, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Log in";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(602, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(201, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(602, 453);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Loan";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(201, 0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(602, 453);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Payment";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(201, 0);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(602, 453);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Reports";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(201, 0);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(602, 453);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "user";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(201, 0);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(602, 453);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Setting";
            tabPage7.UseVisualStyleBackColor = true;
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
            uiTabControlMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
    }
}
