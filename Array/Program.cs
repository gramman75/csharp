using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[10, 10];
            string str = "Hello World!";

            for(int i=0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }

            char[] arrayStr = str.ToCharArray();

            for(int i=0; i < arrayStr.Length; i++)
            {
                Console.Write(arrayStr[i]);
            }

            // StringBuilder

            StringBuilder sb = new StringBuilder();

            for(int i=0; i < 26; i++)
            {
                sb.Append(i.ToString());
            }

            Console.WriteLine(sb.ToString());

            // enum


            // OR 연산자로 다중 플래그 할당
            Border b;
            b = Border.Top | Border.Bottom;

            Console.WriteLine((b & Border.Right));
            // & 연산자로 플래그 체크
            if ((b & Border.Top) != 0)
            {
                //HasFlag()이용 플래그 체크
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" 출력
                    Console.WriteLine(b.ToString());
                }
            }

            Console.WriteLine(Enum.GetName(typeof(Border), 4));

            foreach (string s in Enum.GetNames(typeof(Border)))
                Console.WriteLine(s);

            string str1 = null;

            Console.WriteLine("?? 연산자 {0}", str1??"Null");



        }
    }
}
