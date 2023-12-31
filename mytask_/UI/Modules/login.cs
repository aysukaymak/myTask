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
    public partial class login : Form
    {

        private string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mytask;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public login()
        {
            InitializeComponent();
        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Email and password cannot be empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            bool isAuthenticated = AuthenticateUser(email, password) > 0 ;

            if (isAuthenticated)
            {
                MessageBox.Show("Login Success!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                int userId = AuthenticateUser(email, password);
                RedirectUserToMainPage(userId);
            }
            else
            {
                MessageBox.Show("Email and password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RedirectUserToMainPage(int userId)
        {
            frmMain mainForm = new frmMain(userId);
            this.Hide();
            mainForm.Show();
        }

        private int AuthenticateUser(string email, string password)
        {
            try
            {
                using (SqlConnection_ connection_ = new SqlConnection_())
                {
                    connection_.Connection_();

                    string query = "SELECT id FROM users WHERE email = @Email AND password = @Password";
                    //BURAYA BAK
                    using (SqlCommand command = new SqlCommand(query, connection_.Connection_()))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        // eğer sonuc dönmezse null'dır dönerse null değildir ID değeridir
                        object userID = command.ExecuteScalar();

                        return (userID != null) ? Convert.ToInt32(userID) : -1 ;    

                    }
                    
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return -1;
            }
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // register.cs formunu oluşturun
            register registerForm = new register();

            this.Hide();
            // register formunu gösterin
            registerForm.Show();
        }
    }
}
