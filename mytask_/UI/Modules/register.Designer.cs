namespace mytask_.UI.Modules
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textTelephone = new System.Windows.Forms.MaskedTextBox();
            this.textBirthday = new System.Windows.Forms.MaskedTextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.MaskedTextBox();
            this.textName = new System.Windows.Forms.MaskedTextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonRegister = new DevExpress.XtraEditors.SimpleButton();
            this.buttonBackToLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.MaskedTextBox();
            this.textEmail = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.textTelephone);
            this.panelControl1.Controls.Add(this.textBirthday);
            this.panelControl1.Controls.Add(this.labelTelephone);
            this.panelControl1.Controls.Add(this.labelBirthday);
            this.panelControl1.Controls.Add(this.textSurname);
            this.panelControl1.Controls.Add(this.textName);
            this.panelControl1.Controls.Add(this.labelLastName);
            this.panelControl1.Controls.Add(this.labelFirstName);
            this.panelControl1.Controls.Add(this.buttonRegister);
            this.panelControl1.Controls.Add(this.buttonBackToLogin);
            this.panelControl1.Controls.Add(this.labelHeader);
            this.panelControl1.Controls.Add(this.textPassword);
            this.panelControl1.Controls.Add(this.textEmail);
            this.panelControl1.Controls.Add(this.labelPassword);
            this.panelControl1.Controls.Add(this.labelEmail);
            this.panelControl1.Location = new System.Drawing.Point(36, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(720, 656);
            this.panelControl1.TabIndex = 1;
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(368, 340);
            this.textTelephone.Mask = "(999) 000-0000";
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(169, 23);
            this.textTelephone.TabIndex = 39;
            // 
            // textBirthday
            // 
            this.textBirthday.Location = new System.Drawing.Point(368, 292);
            this.textBirthday.Mask = "00/00/0000";
            this.textBirthday.Name = "textBirthday";
            this.textBirthday.Size = new System.Drawing.Size(169, 23);
            this.textBirthday.TabIndex = 38;
            this.textBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.BackColor = System.Drawing.Color.Transparent;
            this.labelTelephone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTelephone.Location = new System.Drawing.Point(174, 340);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(93, 21);
            this.labelTelephone.TabIndex = 37;
            this.labelTelephone.Text = "Telephone:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthday.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelBirthday.Location = new System.Drawing.Point(174, 295);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(77, 21);
            this.labelBirthday.TabIndex = 36;
            this.labelBirthday.Text = "Birthday:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(368, 248);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(169, 23);
            this.textSurname.TabIndex = 35;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(368, 200);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 23);
            this.textName.TabIndex = 34;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelLastName.Location = new System.Drawing.Point(174, 248);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 21);
            this.labelLastName.TabIndex = 33;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelFirstName.Location = new System.Drawing.Point(174, 203);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(97, 21);
            this.labelFirstName.TabIndex = 32;
            this.labelFirstName.Text = "First Name:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.buttonRegister.Appearance.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonRegister.Appearance.Options.UseFont = true;
            this.buttonRegister.Appearance.Options.UseForeColor = true;
            this.buttonRegister.Location = new System.Drawing.Point(428, 505);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(109, 42);
            this.buttonRegister.TabIndex = 31;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.buttonBackToLogin.Appearance.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonBackToLogin.Appearance.Options.UseFont = true;
            this.buttonBackToLogin.Appearance.Options.UseForeColor = true;
            this.buttonBackToLogin.Location = new System.Drawing.Point(177, 505);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(169, 42);
            this.buttonBackToLogin.TabIndex = 30;
            this.buttonBackToLogin.Text = "Back To Login";
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Palace Script MT", 70F);
            this.labelHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHeader.Location = new System.Drawing.Point(184, 39);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(308, 108);
            this.labelHeader.TabIndex = 29;
            this.labelHeader.Text = "MyNote";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(368, 439);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(169, 23);
            this.textPassword.TabIndex = 28;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(368, 391);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(169, 23);
            this.textEmail.TabIndex = 27;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelPassword.Location = new System.Drawing.Point(174, 439);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 21);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelEmail.Location = new System.Drawing.Point(174, 394);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 21);
            this.labelEmail.TabIndex = 25;
            this.labelEmail.Text = "Email:";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 677);
            this.Controls.Add(this.panelControl1);
            this.MinimumSize = new System.Drawing.Size(800, 720);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNote - Register";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.MaskedTextBox textTelephone;
        private System.Windows.Forms.MaskedTextBox textBirthday;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.MaskedTextBox textSurname;
        private System.Windows.Forms.MaskedTextBox textName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private DevExpress.XtraEditors.SimpleButton buttonRegister;
        private DevExpress.XtraEditors.SimpleButton buttonBackToLogin;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.MaskedTextBox textPassword;
        private System.Windows.Forms.MaskedTextBox textEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
    }
}