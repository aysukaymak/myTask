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
    public partial class ucHistory : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public int userId;
        public ucHistory(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            list_history(); //when form is opened, list notes in tileview
            tile_settings(); //tileview design settings
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void tile_settings()
        {
            // Set the tile size.
            tileViewHistory.OptionsTiles.ItemSize = new System.Drawing.Size(300, 160);

            // Create a table layout (columns and rows) for the Tile Template
            TableColumnDefinition tableColumnHeader = new TableColumnDefinition();
            TableColumnDefinition tableColumnDate = new TableColumnDefinition();
            TableColumnDefinition tableColumnOperation = new TableColumnDefinition();
            TableRowDefinition tableRow = new TableRowDefinition();
            // Set the columns length
            tableColumnHeader.Length.Value = 100;
            tableColumnDate.Length.Value = 100;
            tableColumnOperation.Length.Value = 100;
            // Adding columns and rows to tileView
            tileViewHistory.TileColumns.Add(tableColumnHeader);
            tileViewHistory.TileColumns.Add(tableColumnDate);
            tileViewHistory.TileColumns.Add(tableColumnOperation);
            tileViewHistory.TileRows.Add(tableRow);

            // Create the Tile Template's elements
            TileViewItemElement tileElementHeader = new TileViewItemElement();
            TileViewItemElement tileElementDate = new TileViewItemElement();
            TileViewItemElement tileElementOperation = new TileViewItemElement();

            // Visible data settings
            tileElementHeader.Column = tileViewHistory.Columns["header"];
            tileElementHeader.ColumnIndex = 0;
            tileElementHeader.RowIndex = 0;
            tileElementHeader.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileElementDate.Column = tileViewHistory.Columns["date"];
            tileElementDate.ColumnIndex = 1;
            tileElementDate.RowIndex = 0;
            tileElementDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileElementOperation.Column = tileViewHistory.Columns["operation"];
            tileElementOperation.ColumnIndex = 2;
            tileElementOperation.RowIndex = 0;
            tileElementDate.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewHistory.TileTemplate.Add(tileElementHeader);
            tileViewHistory.TileTemplate.Add(tileElementDate);
            tileViewHistory.TileTemplate.Add(tileElementOperation);
        }

        public void list_history()
        {
            //this function getting datas from note table and fills gridControlNotes(tileView) with these datas
            //i.e. just setting the datasource for tileview(notes list)
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select header, date, operation from history where user_id = {userId} order by date desc", connection_.Connection_()); //change user_id value after completed users and login tables
            da.Fill(dt);
            gridControlHistory.DataSource = dt;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            list_history();
        }
    }
}
