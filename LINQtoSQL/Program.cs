using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQtoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleTableDataContext db = new SampleTableDataContext();

            // 모든 컬럼 Return 
            //var data = from tb in db.SampleTable
            //           orderby tb.name ascending
            //           select tb;
    
            // 특정 컬럼 return
            //var data = from tb in db.SampleTable
            //           where tb.name == "kim"
            //           select new
            //           {
            //               name = tb.name,
            //               id = tb.id
            //           };

            // method방식 LINQ
            var data = db.SampleTable.Where(tb => tb.name == "kim").Select(p => new { name = p.name, id = p.id });

            foreach( var o in data)
            {
                Console.WriteLine("{0} - {1}",o.id, o.name);
            }

            var s = db.SampleTable.Sum(tb => tb.age);            
            Console.WriteLine($"Age Sum = {s}");


        }
    }
}
