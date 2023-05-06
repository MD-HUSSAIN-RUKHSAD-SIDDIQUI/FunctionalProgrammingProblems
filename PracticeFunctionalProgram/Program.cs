using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programming Practice:");
            //VowelConsonant.Check();
            //SwapNumber.SwapTheNumber();
            //SwapNumber.SwapNumberWithoutVeriable();
            //QuotientAndRemainder.Find();
            //LargestNum.Find();
            //EvenOdd1.EvenAndOdd();
            //PrimeFactor.Find(12222);
            //LeapYear.Check();
            //int n=8;
            //Console.WriteLine(HarmonicNumber.Find(n));
            // read in one command-line argument
            //int n =int.TryParse(args[0]);
            /*double n;
            n =Convert.ToDouble(args[1]);

            int i = 0;                // count from 0 to N
            int powerOfTwo = 1;       // the ith power of two

            // repeat until i equals n
            while (i <= n)
            {
                Console.WriteLine(i + " " + powerOfTwo);   // print out the power of two
                powerOfTwo = 2 * powerOfTwo;                // double to get the next one
                i = i + 1;
            }
            */
           // Flipcoin.Check();
            HarmonicNumber.Find();
            Console.ReadKey();
           
        }
    }
}
