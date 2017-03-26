using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudy
{
    class StrCompare : IComparer<string>
    {
        int IComparer<string>.Compare(string x, string y)
        {
           return y.CompareTo(x);
        }
    }
    class Program
    {
        static string[] Keywords = {
"abstract", "add*", "alias*", "as", "ascending*",
"async*", "await*", "base","bool", "break",
"by*", "byte", "case", "catch", "char", "checked",
"class", "const", "continue", "decimal", "default",
"delegate", "descending*", "do", "double",
"dynamic*", "else", "enum", "event", "equals*",
"explicit", "extern", "false", "finally", "fixed",
"from*", "float", "for", "foreach", "get*", "global*",
"group*", "goto", "if", "implicit", "in", "int",
"into*", "interface", "internal", "is", "lock", "long",
"join*", "let*", "nameof*", "namespace", "new", "null",
"object", "on*", "operator", "orderby*", "out",
"override", "params", "partial*", "private", "protected",
"public", "readonly", "ref", "remove*", "return", "sbyte",
"sealed", "select*", "set*", "short", "sizeof",
"stackalloc", "static", "string", "struct", "switch",
"this", "throw", "true", "try", "typeof", "uint", "ulong",
"unsafe", "ushort", "using", "value*", "var*", "virtual",
"unchecked", "void", "volatile", "where*", "while", "yield*"};

        static void Main(string[] args)
        {
            IEnumerable<string> fileNames =
                from fileName in Directory.EnumerateFiles(@"c:\Windows")
                where File.GetLastAccessTime(fileName) < DateTime.Now
                orderby fileName
                select fileName;


            foreach(string fileName in fileNames)
            {
                Console.WriteLine(fileName);
            }

            var fileInfos =
                from fileName in Directory.EnumerateFiles(@"c:\windows")
                let file = new FileInfo(fileName)
                orderby file.Length
                select new
                {
                    name = fileName,
                    size = file.Length
                };

            foreach(var fileInfo in fileInfos)
            {
                Console.WriteLine($"File Name : {fileInfo.name}({fileInfo.size})");
            }

            IEnumerable<IGrouping<bool, string>> selection =
                from word in Keywords
                group word by word.Contains("*");

            foreach (IGrouping<bool, string> wordGroup in selection)
            {
                Console.WriteLine(wordGroup.Key ? "* exists" : " * is not exists");

                foreach(string word in wordGroup)
                {
                    Console.Write("{0} ", word);
                }
            }

            var selecton1 =
                from word in Keywords
                group word by word.Contains("*")
                into groups
                select new
                {
                    key = groups.Key,
                    items = groups
                };

            var numbers = new[] { 1, 2, 3 };

            var selection2 =
                from word in Keywords
                from num in numbers
                select new { word, num };

            foreach(var item in selection2)
            {
                Console.WriteLine(item);
            }

            var str = new[] { "a", "b", "c", "d", "a", "c" };
            var str1 = str.Distinct();
            var distinctStr=
                from s in str.Distinct()
                select s;

            foreach(var item in str1)
            {
                Console.WriteLine(item);
            }

            List<string> list = new List<string>(fileNames);

            list.Add("ggg");

            //list.Sort(new StrCompare());
            //list.Sort();
            Console.WriteLine("ggg index = {0}", list[list.BinarySearch("ggg")]);

        }

    }
}
