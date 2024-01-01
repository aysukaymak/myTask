namespace mytask_.UI.Modules
{
    partial class ucTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTasks));
            this.richTextBoxTask = new System.Windows.Forms.RichTextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateEditEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDiscard = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelDate = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelid = new DevExpress.XtraEditors.LabelControl();
            this.richTextBoxHeader = new System.Windows.Forms.RichTextBox();
            this.buttonUpdate = new DevExpress.XtraEditors.CheckButton();
            this.gridControlTasks = new DevExpress.XtraGrid.GridControl();
            this.tileViewTasks = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.buttonRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxTask
            // 
            this.richTextBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.richTextBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTask.Enabled = false;
            this.richTextBoxTask.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxTask.Location = new System.Drawing.Point(568, 171);
            this.richTextBoxTask.Name = "richTextBoxTask";
            this.richTextBoxTask.Size = new System.Drawing.Size(744, 600);
            this.richTextBoxTask.TabIndex = 17;
            this.richTextBoxTask.Text = "";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.buttonRefresh);
            this.panelControl1.Controls.Add(this.dateEditEnd);
            this.panelControl1.Controls.Add(this.dateEditStart);
            this.panelControl1.Controls.Add(this.buttonSave);
            this.panelControl1.Controls.Add(this.buttonDiscard);
            this.panelControl1.Controls.Add(this.buttonDelete);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.labelDate);
            this.panelControl1.Controls.Add(this.separatorControl2);
            this.panelControl1.Controls.Add(this.richTextBoxTask);
            this.panelControl1.Controls.Add(this.labelid);
            this.panelControl1.Controls.Add(this.richTextBoxHeader);
            this.panelControl1.Controls.Add(this.buttonUpdate);
            this.panelControl1.Controls.Add(this.gridControlTasks);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1331, 794);
            this.panelControl1.TabIndex = 1;
            // 
            // dateEditEnd
            // 
            this.dateEditEnd.EditValue = null;
            this.dateEditEnd.Location = new System.Drawing.Point(771, 106);
            this.dateEditEnd.Name = "dateEditEnd";
            this.dateEditEnd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dateEditEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEditEnd.Properties.Appearance.Options.UseBackColor = true;
            this.dateEditEnd.Properties.Appearance.Options.UseFont = true;
            this.dateEditEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Size = new System.Drawing.Size(143, 28);
            this.dateEditEnd.TabIndex = 37;
            // 
            // dateEditStart
            // 
            this.dateEditStart.EditValue = null;
            this.dateEditStart.Location = new System.Drawing.Point(568, 106);
            this.dateEditStart.Name = "dateEditStart";
            this.dateEditStart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dateEditStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateEditStart.Properties.Appearance.Options.UseBackColor = true;
            this.dateEditStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStart.Size = new System.Drawing.Size(143, 28);
            this.dateEditStart.TabIndex = 36;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonSave.Appearance.Options.UseForeColor = true;
            this.buttonSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.buttonSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonSave.ImageOptions.SvgImage")));
            this.buttonSave.Location = new System.Drawing.Point(1133, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonSave.Size = new System.Drawing.Size(50, 50);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.buttonDiscard.Location = new System.Drawing.Point(1077, 21);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonDiscard.Size = new System.Drawing.Size(50, 50);
            this.buttonDiscard.TabIndex = 13;
            this.buttonDiscard.Visible = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
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
            this.buttonDelete.Location = new System.Drawing.Point(1021, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonDelete.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete.TabIndex = 33;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.separatorControl1.Location = new System.Drawing.Point(568, 78);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(10);
            this.separatorControl1.Size = new System.Drawing.Size(744, 21);
            this.separatorControl1.TabIndex = 15;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelDate.Appearance.Options.UseFont = true;
            this.labelDate.Appearance.Options.UseForeColor = true;
            this.labelDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelDate.Location = new System.Drawing.Point(732, 108);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(18, 24);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "to";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl2.AutoSizeMode = true;
            this.separatorControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.separatorControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.separatorControl2.Location = new System.Drawing.Point(568, 140);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(10);
            this.separatorControl2.Size = new System.Drawing.Size(744, 21);
            this.separatorControl2.TabIndex = 18;
            // 
            // labelid
            // 
            this.labelid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelid.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelid.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelid.Appearance.Options.UseFont = true;
            this.labelid.Appearance.Options.UseForeColor = true;
            this.labelid.Location = new System.Drawing.Point(1245, 108);
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
            this.richTextBoxHeader.Location = new System.Drawing.Point(568, 21);
            this.richTextBoxHeader.Name = "richTextBoxHeader";
            this.richTextBoxHeader.Size = new System.Drawing.Size(427, 51);
            this.richTextBoxHeader.TabIndex = 34;
            this.richTextBoxHeader.Text = "Header";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonUpdate.ImageOptions.SvgImage")));
            this.buttonUpdate.Location = new System.Drawing.Point(1189, 21);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.TabIndex = 32;
            this.buttonUpdate.CheckedChanged += new System.EventHandler(this.buttonUpdate_CheckedChanged);
            // 
            // gridControlTasks
            // 
            this.gridControlTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlTasks.Location = new System.Drawing.Point(0, 0);
            this.gridControlTasks.MainView = this.tileViewTasks;
            this.gridControlTasks.Name = "gridControlTasks";
            this.gridControlTasks.Size = new System.Drawing.Size(538, 794);
            this.gridControlTasks.TabIndex = 20;
            this.gridControlTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewTasks});
            // 
            // tileViewTasks
            // 
            this.tileViewTasks.DetailHeight = 372;
            this.tileViewTasks.GridControl = this.gridControlTasks;
            this.tileViewTasks.Name = "tileViewTasks";
            this.tileViewTasks.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileViewTasks.OptionsTiles.IndentBetweenGroups = 0;
            this.tileViewTasks.OptionsTiles.IndentBetweenItems = 0;
            this.tileViewTasks.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(30);
            this.tileViewTasks.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileViewTasks.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileViewTasks.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileViewTasks.OptionsTiles.RowCount = 0;
            this.tileViewTasks.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileViewTasks_ItemClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonRefresh.Appearance.Options.UseForeColor = true;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefresh.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.buttonRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.buttonRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonRefresh.ImageOptions.SvgImage")));
            this.buttonRefresh.Location = new System.Drawing.Point(1245, 21);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonRefresh.Size = new System.Drawing.Size(50, 50);
            this.buttonRefresh.TabIndex = 38;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ucTasks
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucTasks";
            this.Size = new System.Drawing.Size(1331, 794);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxTask;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonDiscard;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelDate;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.LabelControl labelid;
        private System.Windows.Forms.RichTextBox richTextBoxHeader;
        private DevExpress.XtraEditors.CheckButton buttonUpdate;
        private DevExpress.XtraGrid.GridControl gridControlTasks;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewTasks;
        private DevExpress.XtraEditors.DateEdit dateEditEnd;
        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private DevExpress.XtraEditors.SimpleButton buttonRefresh;
    }
}
