using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBStudy.DAO
{
    class DBHelper : IDisposable
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName='C:\Users\gramman\gramman.mdf';Initial Catalog=gramman;Integrated Security=True;";
        SqlConnection conn;
        public DBHelper()
        {
            conn = new SqlConnection(connectionString);
        }

        public SqlConnection Connection {
            get 
            {
                return conn;
            }
        }

        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
