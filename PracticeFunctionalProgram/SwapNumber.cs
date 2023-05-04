using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class SwapNumber
    {
        public static void SwapTheNumber()
        {
            int a = 31, b = 41;
            Console.WriteLine("before swapp {0} , {1} ", a, b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after swapp {0} , {1} ", a, b);

        }
        public static void SwapNumberWithoutVeriable()
        {
            int a = 3, b = 4;
            Console.WriteLine("before swapp {0} , {1} ", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swapp {0} , {1} ", a, b);
        }
    }
}
