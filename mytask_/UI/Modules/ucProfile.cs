using DevExpress.Xpo.DB.Helpers;
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

namespace mytask_.UI.Modules
{
    public partial class ucProfile : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public ucProfile()
        {
            InitializeComponent();
            default_user_info();
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void default_user_info()
        {
            try
            {
                SqlCommand command = new SqlCommand($"select id, first_name, last_name, phone, email, password, image, birthday from users where id = {1}", connection_.Connection_()); //change user_id value after completed users and login tables
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textName.Text = reader["first_name"].ToString();
                    //pictureEdit1. Image = ;
                    textSurname.Text = reader["last_name"].ToString();
                    textEmail.Text = reader["email"].ToString();
                    textTelephone.Text = reader["phone"].ToString();
                    textBirthday.Text = reader["birthday"].ToString();
                    textPassword.Text = reader["password"].ToString();
                    labelHeader.Text = reader["first_name"].ToString().ToUpper() + " " + reader["last_name"].ToString().ToUpper() + "'S MYTASK";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonProfileUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonProfileUpdate.Checked)
            {
                set_enable_text(true);
                set_mask_text(false);
                
            } 
            else
            {
                set_enable_text(false);
                set_mask_text(true);
            }
        }

        private void set_enable_text(bool state)
        {
            buttonSave.Visible = state;
            textName.Enabled = state;
            textSurname.Enabled = state;
            textEmail.Enabled = state;
            textTelephone.Enabled = state;
            textBirthday.Enabled = state;
            textPassword.Enabled = state;
            pictureEdit1.Enabled = state;

        }

        private void set_mask_text(bool state)
        {
            textPassword.Properties.UseSystemPasswordChar = state;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*
             some sql queries here
             */

            set_enable_text(false);
            set_mask_text(true);
        }
    }
}
