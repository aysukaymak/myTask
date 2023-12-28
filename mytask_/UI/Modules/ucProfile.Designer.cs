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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textName = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textSurname = new System.Windows.Forms.MaskedTextBox();
            this.textTelephone = new System.Windows.Forms.MaskedTextBox();
            this.textBirthday = new System.Windows.Forms.MaskedTextBox();
            this.textAdress = new System.Windows.Forms.MaskedTextBox();
            this.buttonProfileUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.buttonProfileUpdate);
            this.panelControl1.Controls.Add(this.textAdress);
            this.panelControl1.Controls.Add(this.textBirthday);
            this.panelControl1.Controls.Add(this.textTelephone);
            this.panelControl1.Controls.Add(this.textSurname);
            this.panelControl1.Controls.Add(this.textName);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1165, 747);
            this.panelControl1.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(503, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(379, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(379, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(379, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(379, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(379, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(503, 97);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(100, 23);
            this.textSurname.TabIndex = 6;
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(503, 142);
            this.textTelephone.Mask = "(999) 000-0000";
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(100, 23);
            this.textTelephone.TabIndex = 7;
            // 
            // textBirthday
            // 
            this.textBirthday.Location = new System.Drawing.Point(503, 188);
            this.textBirthday.Mask = "00/00/0000";
            this.textBirthday.Name = "textBirthday";
            this.textBirthday.Size = new System.Drawing.Size(100, 23);
            this.textBirthday.TabIndex = 8;
            this.textBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(503, 244);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(350, 23);
            this.textAdress.TabIndex = 9;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textAdress;
        private System.Windows.Forms.MaskedTextBox textBirthday;
        private System.Windows.Forms.MaskedTextBox textTelephone;
        private System.Windows.Forms.MaskedTextBox textSurname;
        private DevExpress.XtraEditors.SimpleButton buttonProfileUpdate;
    }
}
