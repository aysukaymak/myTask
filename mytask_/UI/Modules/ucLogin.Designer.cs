namespace mytask_.UI.Modules
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogin));
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRegister = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelEmail.Location = new System.Drawing.Point(131, 191);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelPassword.Location = new System.Drawing.Point(131, 236);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(223, 188);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(169, 23);
            this.textEmail.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(223, 236);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(169, 23);
            this.textPassword.TabIndex = 6;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Palace Script MT", 70F);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(116, 39);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(308, 108);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "MyNote";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Appearance.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonLogin.Appearance.Options.UseForeColor = true;
            this.buttonLogin.Location = new System.Drawing.Point(298, 281);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 29);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Appearance.ForeColor = System.Drawing.Color.DarkKhaki;
            this.buttonRegister.Appearance.Options.UseForeColor = true;
            this.buttonRegister.Location = new System.Drawing.Point(134, 281);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(94, 29);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(663, 451);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.MaskedTextBox textEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox textPassword;
        private System.Windows.Forms.Label labelHeader;
        private DevExpress.XtraEditors.SimpleButton buttonLogin;
        private DevExpress.XtraEditors.SimpleButton buttonRegister;
    }
}
