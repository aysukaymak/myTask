using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.XtraPrinting;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace mytask_.UI.Modules
{
    public partial class ucNotes : DevExpress.DXperience.Demos.TutorialControlBase
    {

        public ucNotes()
        {
            InitializeComponent();
            list_notes(); //when form is opened, list notes in tileview
            tile_settings(); //tileview design settings
            set_initial_texts(); //display first row details in tileview, details are displayed in header, date and note fields of form
        }

        SqlConnection_ connection_ = new SqlConnection_();
       
        private void tile_settings()
        {
            // Set the tile size.
            tileViewNotes.OptionsTiles.ItemSize = new System.Drawing.Size(300, 160);

            // Create a table layout (columns and rows) for the Tile Template
            TableColumnDefinition tableColumnHeader = new TableColumnDefinition();
            TableColumnDefinition tableColumnDate = new TableColumnDefinition();
            TableColumnDefinition tableColumnId = new TableColumnDefinition();
            TableColumnDefinition tableColumnNote = new TableColumnDefinition();
            TableRowDefinition tableRow = new TableRowDefinition();
            // Set the columns length
            tableColumnHeader.Length.Value = 120;
            tableColumnDate.Length.Value = 120;
            tableColumnNote.Length.Value = 0;
            tableColumnId.Length.Value = 0;
            // Adding columns and rows to tileView
            tileViewNotes.TileColumns.Add(tableColumnHeader);
            tileViewNotes.TileColumns.Add(tableColumnDate);
            tileViewNotes.TileColumns.Add(tableColumnId);
            tileViewNotes.TileColumns.Add(tableColumnNote);
            tileViewNotes.TileRows.Add(tableRow);

            // Create the Tile Template's elements
            TileViewItemElement tileElementHeader = new TileViewItemElement();
            TileViewItemElement tileElementDate = new TileViewItemElement();
            TileViewItemElement tileElementId = new TileViewItemElement();
            TileViewItemElement tileElementNote = new TileViewItemElement();

            // Visible data settings
            tileElementHeader.Column = tileViewNotes.Columns["header"];
            tileElementHeader.ColumnIndex = 0;
            tileElementHeader.RowIndex = 0;
            tileElementHeader.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileElementDate.Column = tileViewNotes.Columns["date"];
            tileElementDate.ColumnIndex = 1;
            tileElementDate.RowIndex = 0;
            tileElementDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            // Unvisible data settings
            tileElementId.Column = tileViewNotes.Columns["id"];
            tileElementId.ColumnIndex = 2;
            tileElementId.RowIndex = 0;
            tileElementId.TextVisible = false;
            tileElementNote.Column = tileViewNotes.Columns["note"];
            tileElementNote.ColumnIndex = 3;
            tileElementNote.RowIndex = 0;
            tileElementNote.TextVisible = false;
            tileViewNotes.TileTemplate.Add(tileElementHeader);
            tileViewNotes.TileTemplate.Add(tileElementDate);
            tileViewNotes.TileTemplate.Add(tileElementId);
            tileViewNotes.TileTemplate.Add(tileElementNote);
        }

        private void tileViewNotes_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            set_enable_text(false);
            //when rows are clicked in tileview (when data is selected in the list), display data in related fields in the form
            display_data();
        }

        private void buttonUpdate_CheckedChanged_1(object sender, EventArgs e)
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
            SqlCommand update = new SqlCommand("update notes set header=@header, note=@note, date=@date where id=@id", connection_.Connection_());
            update.Parameters.AddWithValue("@header", richTextBoxHeader.Text);
            update.Parameters.AddWithValue("@date", labelNoteDate.Text);
            update.Parameters.AddWithValue("@note", richTextBoxNote.Text);
            update.Parameters.AddWithValue("@id", labelid.Text);
            update.ExecuteNonQuery();
            connection_.Connection_().Close();
            list_notes(); //after updating, new data should be listing in tileview
            set_enable_text(false); //and again unenable the fields
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //if delete button is clicked, delete the data
            SqlCommand delete = new SqlCommand("delete from notes where id=@id", connection_.Connection_());
            delete.Parameters.AddWithValue("@id", labelid.Text);
            delete.ExecuteNonQuery();
            connection_.Connection_().Close();
            list_notes(); //after deleting, tileview list must be refresh
            set_enable_text(false);
            set_initial_texts(); //and new first row displaying in the fields of form
        }

        public void list_notes()
        {
            //this function getting datas from note table and fills gridControlNotes(tileView) with these datas
            //i.e. just setting the datasource for tileview(notes list)
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id, header, note, date from notes where user_id = {1} order by date desc", connection_.Connection_()); //change user_id value after completed users and login tables
            da.Fill(dt);
            gridControlNotes.DataSource = dt;
        }

        private void display_data()
        {
            //display the selected data in tileView
            int[] selectedRow = tileViewNotes.GetSelectedRows();
            richTextBoxHeader.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "header");
            labelNoteDate.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "date");
            richTextBoxNote.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "note");
            labelid.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "id"); //this line just for storing id value for other operations. Therefore, labelid is unvisible in the form
        }

        private void set_enable_text(bool state)
        {
            //for users not see these buttons up to clicking pencil
            buttonSave.Visible = state;
            buttonDelete.Visible = state;
            buttonDiscard.Visible = state;
            //for users not enable the changes up to clicking pencil 
            richTextBoxHeader.Enabled = state; 
            richTextBoxNote.Enabled = state;
            labelNoteDate.Text = DateTime.Now.ToString("MM.dd.yyyy");
        }

        private void set_initial_texts()
        {
            //display first row details in tileview, details are displayed in header, date and note field
            richTextBoxHeader.Text = tileViewNotes.GetRowCellDisplayText(0, "header");
            labelNoteDate.Text = tileViewNotes.GetRowCellDisplayText(0, "date");
            richTextBoxNote.Text = tileViewNotes.GetRowCellDisplayText(0, "note");
            labelid.Text = tileViewNotes.GetRowCellDisplayText(0, "id");
        }
    }
}