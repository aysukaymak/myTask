using DevExpress.XtraScheduler.Outlook.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Policy;
using System.Data.SqlClient;

namespace mytask_.UI.Modules
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            this.Close();
            loginForm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string surname = textSurname.Text;
            string birthdayText = textBirthday.Text;
            string telephone = textTelephone.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;


            DateTime birthday;

            // Giriş metnini DateTime'a dönüştürmeye çalışın
            if (!DateTime.TryParse(birthdayText, out birthday))
            {
                MessageBox.Show("Invalid birthday format. Please use MM/dd/yyyy format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(birthdayText) ||
        string.IsNullOrEmpty(telephone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All of the text boxes must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsEmailUsed(email))
            {
                MessageBox.Show("This email is already on use. Please pick another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddUserToDatabase(name,surname,birthday,telephone,email,password);

            login loginForm = new login();
            this.Close();
            loginForm.Show();
        }
        private bool IsEmailUsed(string email)
        {
            return false;
        }

        private void AddUserToDatabase(string name, string surname, DateTime birthday, string telephone, string email, string password)
        {
            try
            {
                using (SqlConnection_ connection_ = new SqlConnection_())
                {
                    connection_.Connection_();

                    // Kullanıcıyı eklemek için SQL sorgusu
                    string insertQuery = "INSERT INTO users (first_name, last_name, birthday, phone, email, password) " +
                                         "VALUES (@Name, @Surname, CONVERT(DATETIME, @Birthday, 101), @Telephone, @Email, @Password)";
                    //101 represents MM/dd/yyyy and this is better for security
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection_.Connection_()))
                    {
                        // Parametreleri ekleyin
                        insertCommand.Parameters.AddWithValue("@Name", name);
                        insertCommand.Parameters.AddWithValue("@Surname", surname);
                        insertCommand.Parameters.AddWithValue("@Birthday", birthday);
                        insertCommand.Parameters.AddWithValue("@Telephone", telephone);
                        insertCommand.Parameters.AddWithValue("@Email", email);
                        insertCommand.Parameters.AddWithValue("@Password", password);

                        // Kullanıcıyı ekleyin
                        insertCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration is success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration is failure: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
