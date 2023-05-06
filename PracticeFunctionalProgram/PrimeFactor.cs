using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class PrimeFactor
    {
        public static void Find(int n)
        {
            Console.WriteLine("Prime Factors of" + " " + n + "\t are:");
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n = n / 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n = n / i;

                }
            }
            if (n > 2)
                Console.Write(n);

        }
    }
}
