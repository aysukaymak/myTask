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

            bool isAuthenticated = AuthenticateUser(email, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login Success!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email and password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            try
            {
                using (SqlConnection_ connection_ = new SqlConnection_())
                {
                    connection_.Connection_();

                    string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";
                    //BURAYA BAK
                    using (SqlCommand command = new SqlCommand(query, connection_.Connection_()))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        // eğer bir değer dönerse olumlu sonuçtur COUNT(*)
                        int count = (int)command.ExecuteScalar();

                        return count > 0; //if bigger than 0 user is authenticated

                    }
                    
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return false;
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
