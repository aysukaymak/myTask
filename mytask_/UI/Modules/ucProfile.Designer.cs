namespace mytask_.UI.Modules
{
    partial class ucProfile
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.buttonProfileUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.textPassword = new System.Windows.Forms.MaskedTextBox();
            this.textBirthday = new System.Windows.Forms.MaskedTextBox();
            this.textTelephone = new System.Windows.Forms.MaskedTextBox();
            this.textSurname = new System.Windows.Forms.MaskedTextBox();
            this.textName = new System.Windows.Forms.MaskedTextBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonPicture = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.buttonPicture);
            this.panelControl1.Controls.Add(this.buttonProfileUpdate);
            this.panelControl1.Controls.Add(this.textPassword);
            this.panelControl1.Controls.Add(this.textBirthday);
            this.panelControl1.Controls.Add(this.textTelephone);
            this.panelControl1.Controls.Add(this.textSurname);
            this.panelControl1.Controls.Add(this.textName);
            this.panelControl1.Controls.Add(this.labelBirthday);
            this.panelControl1.Controls.Add(this.labelPassword);
            this.panelControl1.Controls.Add(this.labelTelephone);
            this.panelControl1.Controls.Add(this.labelSurname);
            this.panelControl1.Controls.Add(this.labelName);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1165, 747);
            this.panelControl1.TabIndex = 0;
            // 
            // buttonProfileUpdate
            // 
            this.buttonProfileUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.buttonProfileUpdate.Appearance.Options.UseFont = true;
            this.buttonProfileUpdate.Location = new System.Drawing.Point(383, 303);
            this.buttonProfileUpdate.Name = "buttonProfileUpdate";
            this.buttonProfileUpdate.Size = new System.Drawing.Size(295, 48);
            this.buttonProfileUpdate.TabIndex = 10;
            this.buttonProfileUpdate.Text = "UPDATE PROFILE";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(503, 244);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(130, 23);
            this.textPassword.TabIndex = 9;
            // 
            // textBirthday
            // 
            this.textBirthday.Location = new System.Drawing.Point(503, 188);
            this.textBirthday.Mask = "00/00/0000";
            this.textBirthday.Name = "textBirthday";
            this.textBirthday.Size = new System.Drawing.Size(97, 23);
            this.textBirthday.TabIndex = 8;
            this.textBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(503, 142);
            this.textTelephone.Mask = "(999) 000-0000";
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(97, 23);
            this.textTelephone.TabIndex = 7;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(503, 97);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(130, 23);
            this.textSurname.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(503, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(130, 23);
            this.textName.TabIndex = 0;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelBirthday.Location = new System.Drawing.Point(379, 184);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(91, 24);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelPassword.Location = new System.Drawing.Point(379, 240);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(101, 24);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelTelephone.Location = new System.Drawing.Point(379, 138);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(111, 24);
            this.labelTelephone.TabIndex = 3;
            this.labelTelephone.Text = "Telephone:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelSurname.Location = new System.Drawing.Point(379, 93);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(96, 24);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelName.Location = new System.Drawing.Point(379, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonPicture
            // 
            this.buttonPicture.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buttonPicture.Appearance.Options.UseFont = true;
            this.buttonPicture.Location = new System.Drawing.Point(102, 357);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(180, 28);
            this.buttonPicture.TabIndex = 11;
            this.buttonPicture.Text = "UPLOAD PICTURE";
            // 
            // ucProfile
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucProfile";
            this.Size = new System.Drawing.Size(1165, 747);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.MaskedTextBox textName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.MaskedTextBox textPassword;
        private System.Windows.Forms.MaskedTextBox textBirthday;
        private System.Windows.Forms.MaskedTextBox textTelephone;
        private System.Windows.Forms.MaskedTextBox textSurname;
        private DevExpress.XtraEditors.SimpleButton buttonProfileUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.SimpleButton buttonPicture;
    }
}
