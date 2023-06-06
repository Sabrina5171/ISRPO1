using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_registr_and_authoriz
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; server = 3306; username = root; password = root; database = app2");
        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
