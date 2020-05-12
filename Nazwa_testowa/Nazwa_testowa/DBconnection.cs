using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alledrogo
{
    static class DBconnection
    {
        static readonly string connectionString =
                         @"Data Source=DESKTOP-MA3N1EE\SQLEXPRESS;
                    Initial Catalog=ZNorthwind;Integrated Security=True;
                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public static void Connection_Close(SqlConnection connection)
        {
            connection.Close();
        }
    }

}

