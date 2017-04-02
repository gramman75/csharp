using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Task taskA = Task.Run(() =>
            {
                Console.WriteLine("Start A...");
                throw new InvalidOperationException();
            });

            Task taskB = taskA.ContinueWith(parent =>
            {
                Console.WriteLine("Task B");
            });

            taskA.Wait();
            taskA.Exception.Handle(exception =>
            {

                Console.WriteLine(exception.GetType());
                return true;
            });

        }
    }
}
