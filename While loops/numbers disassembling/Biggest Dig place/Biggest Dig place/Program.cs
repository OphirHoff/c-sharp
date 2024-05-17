using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_Dig_place
{
    internal class Program
    {
        public static int BiggestDigPlace (int num)
        {
            int max = 0;
            int digCount = 0;
            int max_dig = 0;

            while (num > 0)
            {
                digCount++;

                if (num % 10 > max)
                {
                    max = num % 10;
                    max_dig = digCount;
                }
                num /= 10;
            }

            return max_dig;
        }
        static void Main(string[] args)
        {
            int max = 0;
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                int num = rnd.Next(10, 10001);
                
                int maxDigitIndex = BiggestDigPlace(num);

                Console.WriteLine(num);
                Console.WriteLine(maxDigitIndex);

                if (maxDigitIndex > max)
                {
                    max = maxDigitIndex;
                }
            }


            Console.WriteLine("max => " + max);
        }
    }
}
