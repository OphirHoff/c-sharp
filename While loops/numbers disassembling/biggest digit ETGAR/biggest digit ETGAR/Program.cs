using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggest_digit_ETGAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call Random
            Random rnd = new Random();

            // biggest digit with highest digit location
            int biggest_digit_max = 0;

            // Repeat 10 times
            for (int i = 1; i <= 10; i++)
            {
                int num = rnd.Next(100, 10000); // Get random number

                int max = 0; // biggest digit
                int digit = 1; // digit location counter
                int digit_of_max = 0; // digit location of biggest digit

                while (num > 0) // disassembly number
                {
                    // check if units is bigger than current max digit
                    if (num % 10 > max) 
                    {
                        max = num % 10;
                        digit_of_max = digit; // update location of bigget digit
                    }

                    num /= 10; // ger rid of units
                    digit++;
                }

                // check if current digit location of the max digit is bigger than biggest location of max digit
                if (digit_of_max > biggest_digit_max)
                {
                    biggest_digit_max = digit_of_max;
                }

                Console.WriteLine(digit_of_max);
            }

            Console.WriteLine("The biggest is: " + biggest_digit_max);
        }
    }
}
