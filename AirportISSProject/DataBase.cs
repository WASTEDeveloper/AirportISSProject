using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportISSProject
{
    class DataBase
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=airportiss");

        public void openConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void closeConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return Connection;
        }
    }
}
