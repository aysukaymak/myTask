using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytask_.UI.Modules
{
    public partial class ucSearch : DevExpress.DXperience.Demos.TutorialControlBase
    {

        string orderByColumn;
        public int userId;
        public ucSearch(int userId)
        {
            InitializeComponent();
            InitDefaultTexts();
            this.userId = userId;
        }

        public void InitDefaultTexts()
        {
            textDate1.Text = "01.01.1900";
            textDate2.Text = "01.01.2050";
            comboOrder.SelectedIndex = 0;
            
        }

        SqlConnection_ connection_ = new SqlConnection_();
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Build the SQL query based on the search criteria
            StringBuilder queryBuilder = new StringBuilder("SELECT id, header, note, date FROM notes WHERE user_id = 1");

            // Add filters based on user input
            if (!string.IsNullOrWhiteSpace(textHeader.Text))
                queryBuilder.Append($" AND header LIKE '%{textHeader.Text}%'");

            if (!string.IsNullOrWhiteSpace(textKeywords.Text))
                queryBuilder.Append($" AND note LIKE '%{textKeywords.Text}%'");

            if (!string.IsNullOrWhiteSpace(textDate1.Text))
            {
                queryBuilder.Append($" AND date >= '{textDate1.Text}'");
            }
            

            if (!string.IsNullOrWhiteSpace(textDate2.Text))
            {
                queryBuilder.Append($" AND date <= '{textDate2.Text}'");
            }



            // Add order by clause based on user selection
            string sortOrder = (checkASC.Checked) ? "ASC" : "DESC";

            string orderByColumn = comboOrder.Text;

            queryBuilder.Append($" ORDER BY {orderByColumn} {sortOrder}");

            // Execute the query and update the DataGridView
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(queryBuilder.ToString(), connection_.Connection_());
            da.Fill(dt);
            dataGridViewNotes.DataSource = dt;
        }

        private void checkASC_CheckedChanged(object sender, EventArgs e)
        {
            checkDESC.Checked = !checkASC.Checked;
        }

        private void checkDESC_CheckedChanged(object sender, EventArgs e)
        {
            checkASC.Checked = !checkDESC.Checked;
        }
    }
}
