using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_digit_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            while(num > 9 && num < 100)
            {
                if (num % 10 == (num / 10) + 2)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
            }
        }
            
    }
}
