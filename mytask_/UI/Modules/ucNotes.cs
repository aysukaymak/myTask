using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Tile;
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
            list_notes();
            tile_settings();
        }

        SqlConnection_ connection_ = new SqlConnection_();

       
        private void tile_settings()
        {
            // Set the tile size.
            tileViewNotes.OptionsTiles.ItemSize = new System.Drawing.Size(300, 160);

            // Create a table layout (columns and rows) for the Tile Template.
            TableColumnDefinition tableColumnHeader = new TableColumnDefinition();
            TableColumnDefinition tableColumnDate = new TableColumnDefinition();
            TableColumnDefinition tableColumnId = new TableColumnDefinition();
            TableColumnDefinition tableColumnNote = new TableColumnDefinition();
            TableRowDefinition tableRow = new TableRowDefinition();
            tableColumnHeader.Length.Value = 120;
            tableColumnDate.Length.Value = 120;
            tableColumnNote.Length.Value = 0;
            tableColumnId.Length.Value = 0;
            tileViewNotes.TileColumns.Add(tableColumnHeader);
            tileViewNotes.TileColumns.Add(tableColumnDate);
            tileViewNotes.TileColumns.Add(tableColumnId);
            tileViewNotes.TileColumns.Add(tableColumnNote);
            tileViewNotes.TileRows.Add(tableRow);

            // Create the Tile Template's elements.
            TileViewItemElement tileElementHeader = new TileViewItemElement();
            TileViewItemElement tileElementDate = new TileViewItemElement();
            TileViewItemElement tileElementId = new TileViewItemElement();
            TileViewItemElement tileElementNote = new TileViewItemElement();

            //visible data
            tileElementHeader.Column = tileViewNotes.Columns["header"];
            tileElementHeader.ColumnIndex = 0;
            tileElementHeader.RowIndex = 0;
            tileElementHeader.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileElementDate.Column = tileViewNotes.Columns["date"];
            tileElementDate.ColumnIndex = 1;
            tileElementDate.RowIndex = 0;
            tileElementDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            //unvisible data
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

        public void list_notes()
        {   
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select id, header, note, date from notes where user_id = {1} order by date desc", connection_.Connection_()); //change user_id value after completed users and login tables
            da.Fill(dt);
            gridControlNotes.DataSource = dt;

        }

        private void tileViewNotes_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            int[] selectedRow = tileViewNotes.GetSelectedRows();
            labelNoteHeader.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "header");
            labelNoteDate.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "date");
            richTextBoxNote.Text = tileViewNotes.GetRowCellDisplayText(selectedRow[0], "note");
        }

        private void tileViewNotes_GroupHeaderContextButtonClick(object sender, GroupHeaderContextButtonClickEventArgs e)
        {

        }
    }
}