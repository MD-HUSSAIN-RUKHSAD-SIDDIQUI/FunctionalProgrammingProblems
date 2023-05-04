using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class EvenOdd1
    {
        public static void EvenAndOdd()
        {
            Console.WriteLine("Welcome to Odd Even Program");
            Random rnd = new Random();
            int num = rnd.Next(3333335);
            Console.WriteLine("the random number generated is " + num);


            if (num % 2 == 0)
            {
                Console.WriteLine(num + " The number is even.");
            }
            else
            {
                Console.WriteLine(num + " The number is odd.");
            }
        }
    }
}
