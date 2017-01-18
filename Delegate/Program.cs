using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    class Program
    {
        delegate int MyDelegate(string s);

        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        static void Main(string[] args)
        {

            new Program().Test();
        }

        void Test()
        {
            //MyDelegate m = new MyDelegate(StringToInt);
            //Run(m);

            Run(                ))
            //Run(delegate (string s)
            //{
            //    return int.Parse(s);
            //});

            Run((string s) => { return int.Parse(s); });
        }

        void Run(MyDelegate m)
        {
            Console.WriteLine(m("1234"));

        }

    }
}
