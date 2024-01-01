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
    public partial class ucProfile : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public int userId;
        public ucProfile(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            default_user_info();
        }

        SqlConnection_ connection_ = new SqlConnection_();

        private void default_user_info()
        {
            try
            {
                SqlCommand command = new SqlCommand($"select first_name, last_name, phone, email, password, image, birthday from users where id = {userId}", connection_.Connection_()); //change user_id value after completed users and login tables
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textName.Text = reader["first_name"].ToString();
                    //pictureEdit1.Image. = reader["image"].();
                    textSurname.Text = reader["last_name"].ToString();
                    textEmail.Text = reader["email"].ToString();
                    textTelephone.Text = reader["phone"].ToString();
                    dateEdit1.Text = reader["birthday"].ToString();
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
            buttonDiscard.Visible = state;
            textName.Enabled = state;
            textSurname.Enabled = state;
            textEmail.Enabled = state;
            textTelephone.Enabled = state;
            dateEdit1.Enabled = state;
            textPassword.Enabled = state;
            pictureEdit1.Enabled = state;

        }

        private void set_mask_text(bool state)
        {
            textPassword.Properties.UseSystemPasswordChar = state;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //if save button is clicked, update the data
            SqlCommand update = new SqlCommand("update users set first_name=@first_name, last_name=@last_name, phone=@phone, email=@email, password=@password, birthday=@birthday where id=@id", connection_.Connection_());
            update.Parameters.AddWithValue("@first_name", textName.Text);
            update.Parameters.AddWithValue("@last_name", textSurname.Text);
            update.Parameters.AddWithValue("@phone", textTelephone.Text);
            update.Parameters.AddWithValue("@email", textEmail.Text);
            update.Parameters.AddWithValue("@password", textPassword.Text);
            update.Parameters.AddWithValue("@birthday", DateTime.Parse(dateEdit1.Text));
            update.Parameters.AddWithValue("@id", userId);
            update.ExecuteNonQuery();
            connection_.Connection_().Close();
            default_user_info();
            set_enable_text(false);
            set_mask_text(true);
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            default_user_info();
            set_enable_text(false);
            set_mask_text(true);
        }
    }
}
