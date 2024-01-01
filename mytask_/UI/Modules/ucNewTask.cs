using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors;
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
    public partial class ucNewTask : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public int userId;
        public ucNewTask(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            dateEditStart.Text = DateTime.Now.ToString("MM.dd.yyyy");
            dateEditEnd.Text = DateTime.Now.ToString("MM.dd.yyyy");
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand save = new SqlCommand("insert into tasks (user_id, header, task, start_date, end_date) " +
                                 "values (@user_id, @header, @task, @start_date, @end_date)", connection_.Connection_());
            save.Parameters.AddWithValue("@user_id", userId);
            save.Parameters.AddWithValue("@header", richTextBoxHeader.Text);
            save.Parameters.AddWithValue("@task", richTextBoxTask.Text);
            save.Parameters.AddWithValue("@start_date", DateTime.Parse(dateEditStart.Text));
            save.Parameters.AddWithValue("@end_date", DateTime.Parse(dateEditEnd.Text));
            save.ExecuteNonQuery();
            connection_.Connection_().Close();
            refresh_items();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh_items();
        }

        private void refresh_items()
        {
            richTextBoxHeader.Text = "Untitled Task";
            richTextBoxTask.Text = string.Empty;
            dateEditStart.Text = DateTime.Now.ToString("MM.dd.yyyy");
            dateEditEnd.Text = DateTime.Now.ToString("MM.dd.yyyy");
        }
    }

}
