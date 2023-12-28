using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void default_user_info()
        {
            //change these values after database creation
            //pictureEdit1. Image = ;
            textName.Text = "username";
            textSurname.Text = "surname";
            textEmail.Text = "email";
            textTelephone.Text = "00000000000";
            textBirthday.Text = "00.00.2000";
            textPassword.Text = "password";
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
