using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_many_even_digits
{
    class Program
    {
        public static int evenDigits(int num)
        {
            int count = 0; // Even digits counter
            while (num != 0)
            {
                if ((num % 10) % 2 == 0) // check every digit if even
                {
                    count++;
                }
                num /= 10; // get rid of units
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(evenDigits(num));
        }
    }
}
