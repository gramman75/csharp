using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStramStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = File.Create(@"c:\test1.txt");

            file.WriteAll
            file.Close();
           
        }
    }
}
