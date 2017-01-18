using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataSetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName='C:\Users\gramman\gramman.mdf';Initial Catalog=gramman;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from SampleTable", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dt.DefaultView.RowFilter = "name = 'kim'";

                foreach(DataRowView data in dt.DefaultView)
                {
                    Console.WriteLine($"{data["id"]} {data["name"]} {data["age"]} {data["birthDate"]}");                    
                }
                    
            }
        }
    }
}
