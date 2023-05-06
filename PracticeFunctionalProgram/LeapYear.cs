using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class LeapYear
    {
        public static void Check()
        {
            Console.WriteLine("Enter a four Digit number to check if it a leap year or not:");
            int n=Convert.ToInt32(Console.ReadLine());
            if((n>=1000) && (n<=9999))
            {
                if (((n % 4 == 0) && (n % 100 != 0)) || (n % 400 == 0))
                {
                    Console.WriteLine("Specified year is Leap year");

                }
                else 
                {
                    Console.WriteLine("Specified Year is not Leap Year");
                }
      
            }
            Console.WriteLine("You have Entered Wrong Number to check Leap year or not");

        }
    }
}
