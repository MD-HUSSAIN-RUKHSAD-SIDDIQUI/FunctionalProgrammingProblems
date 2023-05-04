using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class QuotientAndRemainder
    {
        public static void Find()
        {
            Console.WriteLine("WelCome To Quotient And Reminder Program");
            Console.WriteLine("Enter Your Dividend");

            int divid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your  Divisor");

            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = divid / divisor;
            int remainder = divid% divisor;
            Console.WriteLine("the quotiont is  " + quotient);
            Console.WriteLine("the remider is  " + remainder);
        }
    }
}
