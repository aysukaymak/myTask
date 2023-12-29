namespace mytask_.UI.Modules
{
    partial class ucNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNotes));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelid = new DevExpress.XtraEditors.LabelControl();
            this.richTextBoxHeader = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.buttonUpdate = new DevExpress.XtraEditors.CheckButton();
            this.gridControlNotes = new DevExpress.XtraGrid.GridControl();
            this.tileViewNotes = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.labelNoteDate = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.buttonDiscard = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.buttonSave);
            this.panelControl1.Controls.Add(this.buttonDiscard);
            this.panelControl1.Controls.Add(this.buttonDelete);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.labelNoteDate);
            this.panelControl1.Controls.Add(this.separatorControl2);
            this.panelControl1.Controls.Add(this.richTextBoxNote);
            this.panelControl1.Controls.Add(this.labelid);
            this.panelControl1.Controls.Add(this.richTextBoxHeader);
            this.panelControl1.Controls.Add(this.buttonUpdate);
            this.panelControl1.Controls.Add(this.gridControlNotes);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1165, 747);
            this.panelControl1.TabIndex = 0;
            // 
            // labelid
            // 
            this.labelid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelid.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelid.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelid.Appearance.Options.UseFont = true;
            this.labelid.Appearance.Options.UseForeColor = true;
            this.labelid.Location = new System.Drawing.Point(1089, 102);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(59, 24);
            this.labelid.TabIndex = 35;
            this.labelid.Text = "labelid";
            this.labelid.Visible = false;
            // 
            // richTextBoxHeader
            // 
            this.richTextBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.richTextBoxHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHeader.Enabled = false;
            this.richTextBoxHeader.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.richTextBoxHeader.Location = new System.Drawing.Point(497, 20);
            this.richTextBoxHeader.Name = "richTextBoxHeader";
            this.richTextBoxHeader.Size = new System.Drawing.Size(435, 48);
            this.richTextBoxHeader.TabIndex = 34;
            this.richTextBoxHeader.Text = "Header";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonDelete.Appearance.Options.UseForeColor = true;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.buttonDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonDelete.ImageOptions.SvgImage")));
            this.buttonDelete.Location = new System.Drawing.Point(938, 20);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonDelete.Size = new System.Drawing.Size(48, 48);
            this.buttonDelete.TabIndex = 33;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonUpdate.ImageOptions.SvgImage")));
            this.buttonUpdate.Location = new System.Drawing.Point(1100, 20);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonUpdate.Size = new System.Drawing.Size(48, 48);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.CheckedChanged += new System.EventHandler(this.buttonUpdate_CheckedChanged_1);
            // 
            // gridControlNotes
            // 
            this.gridControlNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlNotes.Location = new System.Drawing.Point(0, 0);
            this.gridControlNotes.MainView = this.tileViewNotes;
            this.gridControlNotes.Name = "gridControlNotes";
            this.gridControlNotes.Size = new System.Drawing.Size(471, 747);
            this.gridControlNotes.TabIndex = 20;
            this.gridControlNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewNotes});
            // 
            // tileViewNotes
            // 
            this.tileViewNotes.GridControl = this.gridControlNotes;
            this.tileViewNotes.Name = "tileViewNotes";
            this.tileViewNotes.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileViewNotes.OptionsTiles.IndentBetweenGroups = 0;
            this.tileViewNotes.OptionsTiles.IndentBetweenItems = 0;
            this.tileViewNotes.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(30);
            this.tileViewNotes.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileViewNotes.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileViewNotes.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileViewNotes.OptionsTiles.RowCount = 0;
            this.tileViewNotes.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileViewNotes_ItemClick);
            // 
            // labelNoteDate
            // 
            this.labelNoteDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNoteDate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelNoteDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelNoteDate.Appearance.Options.UseFont = true;
            this.labelNoteDate.Appearance.Options.UseForeColor = true;
            this.labelNoteDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelNoteDate.Location = new System.Drawing.Point(497, 102);
            this.labelNoteDate.Name = "labelNoteDate";
            this.labelNoteDate.Size = new System.Drawing.Size(43, 24);
            this.labelNoteDate.TabIndex = 19;
            this.labelNoteDate.Text = "Date";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl2.AutoSizeMode = true;
            this.separatorControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.separatorControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.separatorControl2.Location = new System.Drawing.Point(497, 132);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(651, 19);
            this.separatorControl2.TabIndex = 18;
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.richTextBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNote.Enabled = false;
            this.richTextBoxNote.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxNote.Location = new System.Drawing.Point(497, 161);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(651, 565);
            this.richTextBoxNote.TabIndex = 17;
            this.richTextBoxNote.Text = "";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.separatorControl1.Location = new System.Drawing.Point(497, 73);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(651, 19);
            this.separatorControl1.TabIndex = 15;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscard.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonDiscard.Appearance.Options.UseForeColor = true;
            this.buttonDiscard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDiscard.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonDiscard.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.buttonDiscard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonDiscard.ImageOptions.SvgImage")));
            this.buttonDiscard.Location = new System.Drawing.Point(992, 20);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonDiscard.Size = new System.Drawing.Size(48, 48);
            this.buttonDiscard.TabIndex = 13;
            this.buttonDiscard.Visible = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonSave.Appearance.Options.UseForeColor = true;
            this.buttonSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.buttonSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonSave.ImageOptions.SvgImage")));
            this.buttonSave.Location = new System.Drawing.Point(1046, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonSave.Size = new System.Drawing.Size(48, 48);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ucNotes
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucNotes";
            this.Size = new System.Drawing.Size(1165, 747);
//            this.AutoValidateChanged += new System.EventHandler(this.ucNotes_AutoValidateChanged);
//            this.Load += new System.EventHandler(this.ucNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton buttonDiscard;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.LabelControl labelNoteDate;
        private DevExpress.XtraGrid.GridControl gridControlNotes;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewNotes;
        private DevExpress.XtraEditors.CheckButton buttonUpdate;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private System.Windows.Forms.RichTextBox richTextBoxHeader;
        private DevExpress.XtraEditors.LabelControl labelid;
    }
}
