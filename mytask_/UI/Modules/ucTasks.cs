using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytask_.UI.Modules
{
    public partial class ucTasks : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucTasks()
        {
            InitializeComponent();
            list_task(); //when form is opened, list notes in tileview
            tile_settings(); //tileview design settings
            set_initial_texts(); //display first row details in tileview, details are displayed in header, date and note fields of form
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void tile_settings()
        {
            // Set the tile size.
            tileViewTasks.OptionsTiles.ItemSize = new System.Drawing.Size(300, 160);

            // Create a table layout (columns and rows) for the Tile Template
            TableColumnDefinition tableColumnHeader = new TableColumnDefinition();
            TableColumnDefinition tableColumnStartDate = new TableColumnDefinition();
            TableColumnDefinition tableColumnEndDate = new TableColumnDefinition();
            TableColumnDefinition tableColumnSeperator = new TableColumnDefinition();
            TableColumnDefinition tableColumnId = new TableColumnDefinition();
            TableColumnDefinition tableColumnNote = new TableColumnDefinition();
            TableRowDefinition tableRow = new TableRowDefinition();
            // Set the columns length
            tableColumnHeader.Length.Value = 120;
            tableColumnStartDate.Length.Value = 120;
            tableColumnEndDate.Length.Value = 120;
            tableColumnSeperator.Length.Value = 10;
            tableColumnNote.Length.Value = 0;
            tableColumnId.Length.Value = 0;
            // Adding columns and rows to tileView
            tileViewTasks.TileColumns.Add(tableColumnHeader);
            tileViewTasks.TileColumns.Add(tableColumnStartDate);
            tileViewTasks.TileColumns.Add(tableColumnEndDate);
            tileViewTasks.TileColumns.Add(tableColumnSeperator);
            tileViewTasks.TileColumns.Add(tableColumnId);
            tileViewTasks.TileColumns.Add(tableColumnNote);
            tileViewTasks.TileRows.Add(tableRow);

            // Create the Tile Template's elements
            TileViewItemElement tileElementHeader = new TileViewItemElement();
            TileViewItemElement tileElementStartDate = new TileViewItemElement();
            TileViewItemElement tileElementEndDate = new TileViewItemElement();
            TileViewItemElement tileElementSeperator = new TileViewItemElement();
            TileViewItemElement tileElementId = new TileViewItemElement();
            TileViewItemElement tileElementNote = new TileViewItemElement();

            // Visible data settings
            tileElementHeader.Column = tileViewTasks.Columns["header"];
            tileElementHeader.ColumnIndex = 0;
            tileElementHeader.RowIndex = 0;
            tileElementHeader.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileElementStartDate.Column = tileViewTasks.Columns["start_date"];
            tileElementStartDate.ColumnIndex = 1;
            tileElementStartDate.RowIndex = 0;
            tileElementStartDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileElementSeperator.Column = tileViewTasks.Columns["seperator"];
            tileElementSeperator.ColumnIndex = 2;
            tileElementSeperator.RowIndex = 0;
            tileElementSeperator.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileElementEndDate.Column = tileViewTasks.Columns["end_date"];
            tileElementEndDate.ColumnIndex = 3;
            tileElementEndDate.RowIndex = 0;
            tileElementEndDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            // Unvisible data settings
            tileElementId.Column = tileViewTasks.Columns["id"];
            tileElementId.ColumnIndex = 2;
            tileElementId.RowIndex = 0;
            tileElementId.TextVisible = false;
            tileElementNote.Column = tileViewTasks.Columns["note"];
            tileElementNote.ColumnIndex = 3;
            tileElementNote.RowIndex = 0;
            tileElementNote.TextVisible = false;
            tileViewTasks.TileTemplate.Add(tileElementHeader);
            tileViewTasks.TileTemplate.Add(tileElementStartDate);
            tileViewTasks.TileTemplate.Add(tileElementEndDate);
            tileViewTasks.TileTemplate.Add(tileElementSeperator);
            tileViewTasks.TileTemplate.Add(tileElementId);
            tileViewTasks.TileTemplate.Add(tileElementNote);
        }

        private void tileViewTasks_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            set_enable_text(false);
            //when rows are clicked in tileview (when data is selected in the list), display data in related fields in the form
            display_data();
        }

        private void buttonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            //if upddate button is checked, enable editting
            //visible the save, delete and discard buttons
            if (buttonUpdate.Checked)
                set_enable_text(true);
            else
                set_enable_text(false);
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            //if discord button is clicked, discard the changes
            //with using displaydata() function, this function returns the original selected data
            //after that, unenable the fields; if you want update the data again, must be clicked the update(pencil) button
            display_data();
            set_enable_text(false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //if save button is clicked, update the data
            SqlCommand update = new SqlCommand("update tasks set header=@header, task=@task, start_date=@start_date, end_date=@end_date where id=@id", connection_.Connection_());
            update.Parameters.AddWithValue("@header", richTextBoxHeader.Text);
            update.Parameters.AddWithValue("@start_date", DateTime.Parse(dateEditStart.Text));
            update.Parameters.AddWithValue("@end_date", DateTime.Parse(dateEditEnd.Text));
            update.Parameters.AddWithValue("@task", richTextBoxTask.Text);
            update.Parameters.AddWithValue("@id", labelid.Text);
            update.ExecuteNonQuery();
            connection_.Connection_().Close();
            list_task(); //after updating, new data should be listing in tileview
            set_enable_text(false); //and again unenable the fields
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //if delete button is clicked, delete the data
            SqlCommand delete = new SqlCommand("delete from tasks where id=@id", connection_.Connection_());
            delete.Parameters.AddWithValue("@id", labelid.Text);
            delete.ExecuteNonQuery();
            connection_.Connection_().Close();
            list_task(); //after deleting, tileview list must be refresh
            set_enable_text(false);
            set_initial_texts(); //and new first row displaying in the fields of form
        }


        public void list_task()
        {
            //this function getting datas from note table and fills gridControlNotes(tileView) with these datas
            //i.e. just setting the datasource for tileview(notes list)
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id, header, task, start_date, end_date from tasks where user_id = {1} order by start_date desc", connection_.Connection_()); //change user_id value after completed users and login tables
            da.Fill(dt);
            gridControlTasks.DataSource = dt;
        }

        private void display_data()
        {
            //display the selected data in tileView
            int[] selectedRow = tileViewTasks.GetSelectedRows();
            richTextBoxHeader.Text = tileViewTasks.GetRowCellDisplayText(selectedRow[0], "header");
            dateEditStart.Text = tileViewTasks.GetRowCellDisplayText(selectedRow[0], "start_date");
            dateEditEnd.Text = tileViewTasks.GetRowCellDisplayText(selectedRow[0], "end_date");
            richTextBoxTask.Text = tileViewTasks.GetRowCellDisplayText(selectedRow[0], "task");
            labelid.Text = tileViewTasks.GetRowCellDisplayText(selectedRow[0], "id"); //this line just for storing id value for other operations. Therefore, labelid is unvisible in the form
        }

        private void set_enable_text(bool state)
        {
            //for users not see these buttons up to clicking pencil
            buttonSave.Visible = state;
            buttonDelete.Visible = state;
            buttonDiscard.Visible = state;
            //for users not enable the changes up to clicking pencil 
            richTextBoxHeader.Enabled = state;
            richTextBoxTask.Enabled = state;
            dateEditStart.Text = DateTime.Now.ToString("MM.dd.yyyy");
            dateEditEnd.Text = DateTime.Now.ToString("MM.dd.yyyy");
        }

        private void set_initial_texts()
        {
            //display first row details in tileview, details are displayed in header, date and note field
            richTextBoxHeader.Text = tileViewTasks.GetRowCellDisplayText(0, "header");
            dateEditStart.Text = tileViewTasks.GetRowCellDisplayText(0, "start_date");
            dateEditEnd.Text = tileViewTasks.GetRowCellDisplayText(0, "end_date");
            richTextBoxTask.Text = tileViewTasks.GetRowCellDisplayText(0, "task");
            labelid.Text = tileViewTasks.GetRowCellDisplayText(0, "id");
        }

    }
}