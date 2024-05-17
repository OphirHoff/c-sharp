using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_1_50_or_90_99
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number below 100: ");
            // get number from user
            int num = int.Parse(Console.ReadLine());

            // check if number meets the requirements
            if (num >= 1 && num <= 50 || num >= 90 && num <= 99)
                Console.WriteLine("BOOM");
            else
                Console.WriteLine("Oops");
        }
    }
}
