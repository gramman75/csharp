using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DBConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName='C:\Users\stmkmk\gramman.mdf';Initial Catalog=gramman;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into gram(id) values (@id)", conn);
                var param1 = new SqlParameter("@id", SqlDbType.VarChar, 50).Value = "bcd";
                cmd.Parameters.Add(param1);
                cmd.ExecuteNonQuery();                


                //SqlCommand cmd1 = new SqlCommand("insert into gram(id) values (@id)", conn);
                //SqlParameter param2 = new SqlParameter("@id", SqlDbType.VarChar, 50);
                //param2.Value = "FFF";
                //cmd1.Parameters.Add(param2);
                //cmd1.ExecuteNonQuery();

            }

        }
    }
}
