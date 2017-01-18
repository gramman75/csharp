using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Program
    {

        #region method
        static void op(int x, int y, out int plus, out int minus, out int mul, ref int div)
        {
            plus = x + y;
            minus = x - y;
            mul = x * y;
            div = x / y;
        }
        static void Main(string[] args)
        {
            int plus, minus, mul, div = 0, x = 10, y = 5;

            op(x, y, out plus, out minus, out mul, ref div);

            Console.WriteLine($"x = {x} y={y} + : {plus} - :{minus} * : {mul} / : {div}");
        }
        #endregion method
    }
}
