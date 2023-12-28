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
    public partial class ucNotes : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucNotes()
        {
            InitializeComponent();
            gridControlNotes.DataSource = GetData();
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
            TableRowDefinition tableRow = new TableRowDefinition();
            tableColumnHeader.Length.Value = 120;
            tableColumnDate.Length.Value = 120;
            tileViewNotes.TileColumns.Add(tableColumnHeader);
            tileViewNotes.TileColumns.Add(tableColumnDate);
            tileViewNotes.TileRows.Add(tableRow);


            // Create the Tile Template's elements.
            TileViewItemElement tileElementHeader = new TileViewItemElement();
            TileViewItemElement tileElementDate = new TileViewItemElement();

            tileElementHeader.Column = tileViewNotes.Columns["header"];
            tileElementHeader.ColumnIndex = 0;
            tileElementHeader.RowIndex = 0;
            tileElementHeader.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileElementDate.Column = tileViewNotes.Columns["date"];
            tileElementDate.ColumnIndex = 1;
            tileElementDate.RowIndex = 0;
            tileElementDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewNotes.TileTemplate.Add(tileElementHeader);
            tileViewNotes.TileTemplate.Add(tileElementDate);
        }

        private DataTable GetData()
        {   
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select header, date from notes", connection_.Connection_());
            da.Fill(dt);
            return dt;
        }
    }
}