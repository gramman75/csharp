using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    class Person
    {
        public int Age { get; set; }

        public delegate void ChangeAge(Person sender);
        public event ChangeAge AgeChange;

        public void changeAge(int a)
        {
            Age = a;
            if (AgeChange != null)
            {
                AgeChange(this);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person();
            student.AgeChange += (sender) => { Console.WriteLine(sender.Age); };
            student.AgeChange += (sender) => { Console.WriteLine("나이가 변경되었습니다"); };
            student.changeAge(100);

        }
    }
}
