using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yield
{
    class MyList 
    {
        private int myProperty;

        public IEnumerator GetEnumerator()
        {
            for(int i=0; i < 10; i++)
            {
                yield return i;
            }
        }
        //public int MyProperty {
        //    get { return this.myProperty; }
        //    set { this.myProperty = value; }
        //}



    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            foreach (var item in list)
                Console.WriteLine(item);
        }


    }
}
