using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace tasker
{
    internal class DataBase
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;

        SqlConnection connection = new SqlConnection("Server=localhost; Database=TaskerWF; Integrated Security=True; TrustServerCertificate=True;");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
           
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
