using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLESS2
{
    internal class SQLClass
    {
        SqlConnection connection = null;
        public SQLClass()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdbConnection"].ConnectionString;
            /*string connectionString = @"Data Source = \\127.134.052.017\\SQLEXPRESS
(localdb)\MSSQLLocalDB; Initial Catalog = Library;Integrated Security = False;User= Password=";*/
            connection = new SqlConnection(connectionString);
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public void InsertCommand(string commandString)
        {
            SqlCommand command = new SqlCommand(commandString, connection);
            command.ExecuteNonQuery();
        }
    }
}
