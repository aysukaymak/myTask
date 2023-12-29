namespace mytask_.UI.Modules
{
    partial class ucSearch
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
            this.comboOrder = new System.Windows.Forms.ComboBox();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTask_dbDataSet = new mytask_.myTask_dbDataSet();
            this.notesTableAdapter = new mytask_.myTask_dbDataSetTableAdapters.notesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textKeywords = new System.Windows.Forms.MaskedTextBox();
            this.textHeader = new System.Windows.Forms.MaskedTextBox();
            this.textDate1 = new System.Windows.Forms.MaskedTextBox();
            this.textDate2 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTask_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboOrder
            // 
            this.comboOrder.FormattingEnabled = true;
            this.comboOrder.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.comboOrder.Location = new System.Drawing.Point(155, 71);
            this.comboOrder.Name = "comboOrder";
            this.comboOrder.Size = new System.Drawing.Size(164, 25);
            this.comboOrder.TabIndex = 2;
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.labelOrderBy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelOrderBy.Location = new System.Drawing.Point(28, 72);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(110, 24);
            this.labelOrderBy.TabIndex = 4;
            this.labelOrderBy.Text = "ORDER BY:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.headerDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.notesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(931, 362);
            this.dataGridView2.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "header";
            this.headerDataGridViewTextBoxColumn.HeaderText = "header";
            this.headerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.Width = 125;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 500;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesBindingSource
            // 
            this.notesBindingSource.DataMember = "notes";
            this.notesBindingSource.DataSource = this.myTask_dbDataSet;
            // 
            // myTask_dbDataSet
            // 
            this.myTask_dbDataSet.DataSetName = "myTask_dbDataSet";
            this.myTask_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(392, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Header:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Keywords:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(390, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Between:";
            // 
            // textKeywords
            // 
            this.textKeywords.Location = new System.Drawing.Point(155, 149);
            this.textKeywords.Name = "textKeywords";
            this.textKeywords.Size = new System.Drawing.Size(162, 24);
            this.textKeywords.TabIndex = 12;
            // 
            // textHeader
            // 
            this.textHeader.Location = new System.Drawing.Point(495, 68);
            this.textHeader.Name = "textHeader";
            this.textHeader.Size = new System.Drawing.Size(162, 24);
            this.textHeader.TabIndex = 13;
            // 
            // textDate1
            // 
            this.textDate1.Location = new System.Drawing.Point(551, 149);
            this.textDate1.Mask = "00/00/0000";
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(83, 24);
            this.textDate1.TabIndex = 14;
            this.textDate1.ValidatingType = typeof(System.DateTime);
            // 
            // textDate2
            // 
            this.textDate2.Location = new System.Drawing.Point(671, 149);
            this.textDate2.Mask = "00/00/0000";
            this.textDate2.Name = "textDate2";
            this.textDate2.Size = new System.Drawing.Size(83, 24);
            this.textDate2.TabIndex = 15;
            this.textDate2.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label6.Location = new System.Drawing.Point(640, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "-";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonSearch.Appearance.Options.UseFont = true;
            this.buttonSearch.Location = new System.Drawing.Point(793, 92);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 39);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Search Notes";
            // 
            // ucSearch
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mytask_.Properties.Resources._92cbcb8a_d011_4708_a81c_6dade883b95b;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDate2);
            this.Controls.Add(this.textDate1);
            this.Controls.Add(this.textHeader);
            this.Controls.Add(this.textKeywords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelOrderBy);
            this.Controls.Add(this.comboOrder);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(976, 621);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTask_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboOrder;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private myTask_dbDataSet myTask_dbDataSet;
        private myTask_dbDataSetTableAdapters.notesTableAdapter notesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textKeywords;
        private System.Windows.Forms.MaskedTextBox textHeader;
        private System.Windows.Forms.MaskedTextBox textDate1;
        private System.Windows.Forms.MaskedTextBox textDate2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton buttonSearch;
    }
}
