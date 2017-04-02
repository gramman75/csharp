using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingStudy
{
    class Program
    {
        public const int repetition = 1000;
        public bool result = true;

        public void DoWork2(string t)
        {
            if (result)
            {
                Console.WriteLine(result? t : "");
                result = false;
            }

        }

        public static void DoWork(object str)
        {
            for (int i = 0; i < repetition; i++)
            {
                Console.Write(str);
            }
        }
        static void Main(string[] args)
        {
            Task<string> task1 = Task<string>.Run(() =>
            {
                Thread.Sleep(10000);
                return "Done task1";
            });
            
            TaskStatus ts =  task1.Status;

            Console.WriteLine(ts);
            foreach(Char sym in BusySymbol())
            {

                if (ts != task1.Status)
                {
                    Console.WriteLine(ts);
                    ts = task1.Status;
                }

                if (task1.IsCompleted)
                {
                    Console.Write('\b');
                    break;
                }
                Console.Write(sym);
            }

            task1.Wait();
            Console.WriteLine(task1.Result);
        }

        public static IEnumerable<char> BusySymbol()
        {
            string BusyChar = @"\|/-\|/-";
            int nextChar = 0;
            while (true)
            {
                yield return BusyChar[nextChar];
                nextChar = (nextChar+1) % BusyChar.Length;
                yield return '\b'; 
            }
        }
    }
}

