using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class ConnectionsManager
    {
        public static SqlConnection GetConnection()  
        {
            //con string get app config file or hardcode
            string connectionString = "Data Source=.;Initial Catalog=POSdb;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
