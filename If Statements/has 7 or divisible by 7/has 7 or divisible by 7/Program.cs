using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has_7_or_divisible_by_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number below 100 ");
            // get number from user
            int num = int.Parse(Console.ReadLine());

            //dozens of number
            int dozens = num / 10;
            
            // units if number
            int units = num % 10;

            // check if number meets the requirements
            if (dozens == 7 || units == 7)
                Console.WriteLine("BOOM");
            else if (num % 7 == 0)
                Console.WriteLine("BOOM");
            else
                Console.WriteLine(num);
        }
    }
}
