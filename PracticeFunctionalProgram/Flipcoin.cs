using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFunctionalProgram
{
    internal class Flipcoin
    {
        public static void Check()
        {
            double headCount=0.0, tailCount = 0.0;
            double headPercent, tailPercent;
            Console.WriteLine("Enter the no. of times you want to flip the coin");
            int n=Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                double num=random.NextDouble();


                Console.WriteLine("The random value generated is :" +num);
                if (num< 0.5)
                    tailCount++;
                else
                    headCount++;
                
                  
              
            }
            headPercent = headCount / n * 100;
            tailPercent = tailCount / n * 100;
            Console.WriteLine("Head% is :" + headPercent);
            Console.WriteLine("Tail% is :" + tailPercent);


        }
    }
}
