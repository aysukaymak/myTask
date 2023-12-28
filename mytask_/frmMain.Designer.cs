namespace mytask_
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementSearch = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNew = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNewNote = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNewTask = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNotes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCalendar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementProfile = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fluentDesignFormContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.fluentDesignFormContainer1.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer1.Controls.Add(this.accordionControl1);
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1115, 714);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementSearch,
            this.accordionControlElementNew,
            this.accordionControlElementNotes,
            this.accordionControlElementCalendar,
            this.accordionControlElementProfile});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.LookAndFeel.SkinName = "Office 2019 Dark Gray";
            this.accordionControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(60, 714);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementSearch
            // 
            this.accordionControlElementSearch.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accordionControlElementSearch.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementSearch.Expanded = true;
            this.accordionControlElementSearch.Height = 50;
            this.accordionControlElementSearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementSearch.ImageOptions.SvgImage")));
            this.accordionControlElementSearch.Name = "accordionControlElementSearch";
            this.accordionControlElementSearch.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSearch.Text = "Search";
            this.accordionControlElementSearch.Click += new System.EventHandler(this.accordionControlElementSearch_Click);
            // 
            // accordionControlElementNew
            // 
            this.accordionControlElementNew.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElementNew.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementNew.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementNewNote,
            this.accordionControlElementNewTask});
            this.accordionControlElementNew.Expanded = true;
            this.accordionControlElementNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementNew.ImageOptions.SvgImage")));
            this.accordionControlElementNew.Name = "accordionControlElementNew";
            this.accordionControlElementNew.Text = "New";
            // 
            // accordionControlElementNewNote
            // 
            this.accordionControlElementNewNote.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accordionControlElementNewNote.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementNewNote.Expanded = true;
            this.accordionControlElementNewNote.Height = 50;
            this.accordionControlElementNewNote.Name = "accordionControlElementNewNote";
            this.accordionControlElementNewNote.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNewNote.Text = "New Note";
            this.accordionControlElementNewNote.Click += new System.EventHandler(this.accordionControlElementNewNote_Click);
            // 
            // accordionControlElementNewTask
            // 
            this.accordionControlElementNewTask.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElementNewTask.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementNewTask.Name = "accordionControlElementNewTask";
            this.accordionControlElementNewTask.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNewTask.Text = "New Task";
            this.accordionControlElementNewTask.Click += new System.EventHandler(this.accordionControlElementNewTask_Click);
            // 
            // accordionControlElementNotes
            // 
            this.accordionControlElementNotes.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.accordionControlElementNotes.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElementNotes.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementNotes.Expanded = true;
            this.accordionControlElementNotes.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElementNotes.Height = 50;
            this.accordionControlElementNotes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementNotes.ImageOptions.SvgImage")));
            this.accordionControlElementNotes.Name = "accordionControlElementNotes";
            this.accordionControlElementNotes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNotes.Text = "Notes";
            this.accordionControlElementNotes.Click += new System.EventHandler(this.accordionControlElementNotes_Click);
            // 
            // accordionControlElementCalendar
            // 
            this.accordionControlElementCalendar.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElementCalendar.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementCalendar.Expanded = true;
            this.accordionControlElementCalendar.Height = 50;
            this.accordionControlElementCalendar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementCalendar.ImageOptions.SvgImage")));
            this.accordionControlElementCalendar.Name = "accordionControlElementCalendar";
            this.accordionControlElementCalendar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCalendar.Text = "Calendar";
            this.accordionControlElementCalendar.Click += new System.EventHandler(this.accordionControlElementCalendar_Click);
            // 
            // accordionControlElementProfile
            // 
            this.accordionControlElementProfile.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F);
            this.accordionControlElementProfile.Appearance.Default.Options.UseFont = true;
            this.accordionControlElementProfile.Height = 50;
            this.accordionControlElementProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementProfile.ImageOptions.SvgImage")));
            this.accordionControlElementProfile.Name = "accordionControlElementProfile";
            this.accordionControlElementProfile.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementProfile.Text = "Profile";
            this.accordionControlElementProfile.Click += new System.EventHandler(this.accordionControlElementProfile_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1115, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav);
            // 
            // itemNav
            // 
            this.itemNav.Caption = "itemNav";
            this.itemNav.Id = 0;
            this.itemNav.Name = "itemNav";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // frmMain
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 753);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.InactiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTask";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSearch;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementNewNote;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementNotes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCalendar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProfile;
        private DevExpress.XtraBars.BarStaticItem itemNav;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementNew;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementNewTask;
    }
}

