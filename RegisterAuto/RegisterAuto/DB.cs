using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAuto
{
    class DB
    {
        MySqlConnection connecction = new MySqlConnection("server = localhost; port = 3306; username = root; password = root; database = app2");

        public void openConnection()
        {
            if(connecction.State == System.Data.ConnectionState.Closed)
            {
                connecction.Open();
            }
        }
        public void closeConnection()
        {
            if (connecction.State == System.Data.ConnectionState.Open)
            {
                connecction.Close();
            }
        }
       public MySqlConnection getConnection()
        {
            return connecction;
        }
    }
}
