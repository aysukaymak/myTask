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
    public partial class ucNewNote : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public int userId;
        public ucNewNote(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand save = new SqlCommand("insert into notes (user_id, header, note, date) " +
                                             "values (@user_id, @header, @note, @date)", connection_.Connection_());
            save.Parameters.AddWithValue("@user_id", userId);
            save.Parameters.AddWithValue("@header", richTextBoxHeader.Text);
            save.Parameters.AddWithValue("@note", richTextBoxNote.Text);
            save.Parameters.AddWithValue("@date",  (DateTime.Now).ToString("MM.dd.yyyy"));
            save.ExecuteNonQuery();
            connection_.Connection_().Close();
            log("added new note");
            refresh_items();
        }

        private void log(string op)
        {
            try
            {
                SqlCommand log = new SqlCommand("insert into history (user_id, header, date, operation) " +
                                 "values (@user_id, @header, @date, @operation)", connection_.Connection_());
                log.Parameters.AddWithValue("@user_id", userId);
                log.Parameters.AddWithValue("@header", richTextBoxHeader.Text);
                log.Parameters.AddWithValue("@date", (DateTime.Now).ToString("MM.dd.yyyy"));
                log.Parameters.AddWithValue("@operation", op);
                log.ExecuteNonQuery();
                connection_.Connection_().Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh_items();
        }

        private void refresh_items()
        {
            richTextBoxHeader.Text = "Untitled Note";
            richTextBoxNote.Text = string.Empty;
        }
    }

}
