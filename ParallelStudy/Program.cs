using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] r = new string[10];

            Parallel.For(0, 10, (i) =>
            {
                r[i] = WaitTime(i);
            });

            Console.WriteLine(string.Join("",r));
        }

        static string WaitTime(int i)
        {
            Thread.Sleep(i * 1000);
            return Convert.ToString(i);
        }
    }

}
