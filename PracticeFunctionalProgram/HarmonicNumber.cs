using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class HarmonicNumber
    {
        public static void Find()
        {
            Console.WriteLine("To print the nth harmonic value please enter the value of N:");
           double n= Convert.ToDouble(Console.ReadLine());


            // H1 = 1
            double harmonic = 1;

            // loop to apply the formula
            // Hn = H1 + H2 + H3 ... +
            // Hn-1 + Hn-1 + 1/n
            for (double i =2; i<=n; i++)
            {
                Console.WriteLine("Harmonic values :" + harmonic);
                harmonic =(harmonic)+(Convert.ToDouble(1 / i));
                //Console.WriteLine("Harmonic values are:"+harmonic);
            }

            Console.WriteLine("Nth Harmonic value is:\t"+ harmonic);
            Console.ReadKey();
        }
    }
}
