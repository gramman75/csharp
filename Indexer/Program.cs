using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexer
{
    class MyIndexer
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }

        }

        protected virtual void TestMethod()
        {
            Console.WriteLine("Protected Test"); 
        }
    }

    class TestClass : MyIndexer
    {
        public void Run()
        {
            this.TestMethod();
        }
    }

    class DummyClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

            MyIndexer idx = new MyIndexer();
            TestClass tst = new TestClass();
            DummyClass dmy = new DummyClass();

            tst.Run();
            Console.WriteLine(idx[3]);
            idx[3] = 10;
            Console.WriteLine(idx[3]);


            if ((dmy is MyIndexer))
                Console.WriteLine("Child of MyIndexer");
        }
    }
}
