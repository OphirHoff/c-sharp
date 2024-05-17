using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_two_digit_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            // Get number from user
            int num = int.Parse(Console.ReadLine());

            // Check if number has two digits
            if (num > 9 && num < 100)
                Console.WriteLine(num * 10);
        }
    }
}
