﻿namespace mytask_.UI.Modules
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.buttonRegister = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
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
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.buttonRegister);
            this.panelControl1.Controls.Add(this.buttonLogin);
            this.panelControl1.Controls.Add(this.labelHeader);
            this.panelControl1.Controls.Add(this.textPassword);
            this.panelControl1.Controls.Add(this.textEmail);
            this.panelControl1.Controls.Add(this.labelPassword);
            this.panelControl1.Controls.Add(this.labelEmail);
            this.panelControl1.Location = new System.Drawing.Point(1, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(517, 448);
            this.panelControl1.TabIndex = 2;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Appearance.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonRegister.Appearance.Options.UseForeColor = true;
            this.buttonRegister.Location = new System.Drawing.Point(119, 287);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(94, 29);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "Register";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Appearance.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonLogin.Appearance.Options.UseForeColor = true;
            this.buttonLogin.Location = new System.Drawing.Point(283, 287);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 29);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Palace Script MT", 80F);
            this.labelHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHeader.Location = new System.Drawing.Point(86, 38);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(354, 124);
            this.labelHeader.TabIndex = 14;
            this.labelHeader.Text = "MyNote";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(208, 242);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(169, 23);
            this.textPassword.TabIndex = 13;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(208, 194);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(169, 23);
            this.textEmail.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.labelPassword.Location = new System.Drawing.Point(116, 242);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.labelEmail.Location = new System.Drawing.Point(116, 197);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 16);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton buttonRegister;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.MaskedTextBox textPassword;
        private System.Windows.Forms.MaskedTextBox textEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
    }
}