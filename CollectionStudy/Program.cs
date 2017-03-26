using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStudy
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class ContactEquality : IEqualityComparer<Contact>
    {
        public bool Equals(Contact x, Contact y)
        {
            if (object.ReferenceEquals(x, y))
                return true;

            if (x == null || y == null)
                return false;

            return x.FirstName == y.FirstName && x.LastName == y.LastName;
            
        }

        public int GetHashCode(Contact obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 0;

            return obj.FirstName.GetHashCode() + obj.LastName.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> llist = new LinkedList<string>();
            List<string> list = new List<string>();
            var contacts = new Dictionary<Contact, string>(new ContactEquality());

            contacts.Add(new Contact("k", "m"), "kim"); 
            contacts.Add(new Contact("k", "g"), "moon");

            var contactKey = new Contact("k", "m");

            contacts.Add(contactKey, "geun");

            list.Add("Good");
            list.Add("Boy");
            list.Add("Girl");
            list.Add("Bye");

            int idx = list.BinarySearch("Cool");
            Console.WriteLine(idx);
            List<string> result = list.FindAll(str => str.StartsWith("B"));

            if (idx < 0)
            {
                list.Insert(~idx, "Cool");
            }

            foreach(string item in result)
            {
                Console.WriteLine(item);
            }

            // Initializer를 이용한 초기화.
            var colorMap = new Dictionary<string, ConsoleColor>()
            {
                {"Error", ConsoleColor.Red },
                {"Warning", ConsoleColor.Yellow }
            };
            // Dictionary에 추가. ContainsKey()를 이용하여 존재 여부 확인.
            if (!colorMap.ContainsKey("Information"))
                colorMap.Add("Infomation", ConsoleColor.Green);

            // Key와 Value를 각각 추출하여 사용
            // Collection이 신규로 생성되는 것이 아니고 참조형태로 Return
            List<string> k = colorMap.Keys.ToList<string>();
            List<ConsoleColor> v = colorMap.Values.ToList<ConsoleColor>();
            
            
            for(int i=0; i < v.Count; i++)
            {
                v[i] = ConsoleColor.Red;
            }

            // Dictionary loop를 통한 접근. KeyValuePari<>사용
            foreach(KeyValuePair<string, ConsoleColor> item in colorMap)
            {
                Console.BackgroundColor = item.Value;
                Console.WriteLine(item.Key);
            }

           
        }

        public static bool StartWith(string str)
        {
            return str.StartsWith("B");
        }
    }
}
