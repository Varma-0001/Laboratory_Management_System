using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Laboratory_Management_System.DbConnection
{
    internal class DbConnection
    {
        // use the fully-qualified provider type so it doesn't collide with DataBase.MySqlConnection
        private MySql.Data.MySqlClient.MySqlConnection con;

        public MySql.Data.MySqlClient.MySqlConnection Getconnection()
        {
            if (con == null)
            {
                // replace with your real connection string
                string connectionString = "server=localhost;user id=root;password=;database=lb;";
                con = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            }
            return con;
        }
    }
}