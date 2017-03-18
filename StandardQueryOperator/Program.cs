using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQueryOperator
{

    class Patent
    {
        public string Title { get; set; }
        public string YearOfPublication { get; set; }
        public string ApplicationNumber { get; set; }
        public long[] InventorIds { get; set; }
        public override string ToString()
        {
            return $"{Title} ({YearOfPublication})";
        }
    }

    class Inventor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Name} ({City})";
        }
    }

    class PatentDataSet
    {
        public static readonly Patent[] Patents = new Patent[]{
            new Patent() {Title="Title1", ApplicationNumber="0001", YearOfPublication="2001", InventorIds = new long[]{1,2} },
            new Patent() {Title="Title2", ApplicationNumber="0002", YearOfPublication="2002", InventorIds = new long[]{1} },
            new Patent() {Title="Title3", ApplicationNumber="0003", YearOfPublication="2003", InventorIds = new long[]{2} },
            new Patent() {Title="Title4", ApplicationNumber="0004", YearOfPublication="2004", InventorIds = new long[]{3} }
        };
    }

    class InventorDataSet
    {
        public static readonly Inventor[] Inventors = new Inventor[]
        {
            new Inventor() { Id = 1, Name = "Kim", City = "Seoul1" },
            new Inventor() { Id = 2, Name = "Moon", City = "Seoul2" },
            new Inventor() { Id = 3, Name = "Geun", City = "Seoul3" }
        };
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Patent> patents = PatentDataSet.Patents;
            IEnumerable<Inventor>inventors = InventorDataSet.Inventors;

            //inventors = inventors.Where(
            //    inventor => inventor.Name.StartsWith("K"));

            //foreach(Patent item in patents)
            //{
            //    Console.WriteLine(item);
            //};

            //foreach(Inventor item in inventors)
            //{
            //    Console.WriteLine(item);
            //}

            // IEnumerable<Inventor> inventors = InventorDataSet.Inventors;
            IEnumerable<Inventor> filterInventors = inventors.Where(inventor => inventor.Name.StartsWith("K"));
            IEnumerable<string> str = filterInventors.Select(inventor => inventor.ToString());
            var obj = filterInventors.Select(inventor => new { Name = inventor.Name, City = inventor.City });

            Console.WriteLine(patents.Count(patent => patent.Title.EndsWith("1")));
        }
    }
}
