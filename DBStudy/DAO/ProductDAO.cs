using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBStudy.Model;
using System.Data.SqlClient;

namespace DBStudy.DAO
{
    class ProductDAO
    {
        public List<Product> GetList()
        {
            List<Product> list = new List<Product>();
            
            using(DBHelper db =  new DBHelper())
            {
                SqlConnection conn = db.Connection;
                conn.Open();

                string sql = "select * from product";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Product product = new Product
                    {
                        Id = Convert.ToInt32(rd["Id"]),
                        IsDiscontinued = Convert.ToBoolean(rd["IsDisContinued"]),
                        Package = rd["Package"].ToString(),
                        ProductName = rd["ProductName"].ToString(),
                        SupplierId = Convert.ToInt32(rd["SupplierId"]),
                        UnitPrice = Convert.ToInt32(rd["UnitPrice"])
                    };

                    list.Add(product);
                }
            }
            return list;
        }
    }
}
