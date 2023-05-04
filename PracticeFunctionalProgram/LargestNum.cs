using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class LargestNum
    {
        public static void Find()
        {
            Console.WriteLine("Welcome to my Program to Find largest Number");
            Console.WriteLine("Enter three Numbers");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largestNum = num1;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1+ "is grettest");
                }
                else
                {
                    Console.WriteLine(num3 + "is grettest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + "is grettest");
                }
                else
                {
                    Console.WriteLine(num3 + "is grettest");
                }
            }
        }
    }
}
