using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace mytask_
{
    class SqlConnection_
    {
        public SqlConnection Connection_()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
                return null; // Connection couldn't be established, return null or handle the error as needed.
            }
        }
    }
}
