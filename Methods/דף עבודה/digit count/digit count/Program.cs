using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_count
{
    internal class Program
    {
        public static int Digit_num_count (int num, int digit)
        {
            int count = 0;
            
            while (num > 0)
            {
                if ((num % 10) == digit)
                {
                    count++;
                }
                num /= 10;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number (digit)");
            int digit = int.Parse(Console.ReadLine());

            while (digit != 0)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                int pelet = Digit_num_count(num, digit);
                Console.WriteLine($"This number has the digit {digit} - {pelet} times in it");
            }
        }
    }
}
