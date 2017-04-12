using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBStudy.DAO;
using DBStudy.Model;

namespace DBStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDAO products = new ProductDAO();

            foreach(Product product in products.GetList())
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
