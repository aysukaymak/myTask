using System;
using System.Configuration;
using System.Data.SqlClient;

namespace mytask_
{
    class SqlConnection_ : IDisposable
    {
        private SqlConnection connection;

        public SqlConnection Connection_()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error: " + ex.Message);
                return null; // Connection couldn't be established, return null or handle the error as needed.
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // managed kaynakları serbest bırakın
                if (connection != null)
                {
                    connection.Dispose();
                    connection = null;
                }
            }
        }

        // Destructor
        ~SqlConnection_()
        {
            Dispose(false);
        }
    }
}
