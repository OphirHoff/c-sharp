using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_whole_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a double number: ");
            // get a fraction from the user
            double num = double.Parse(Console.ReadLine());

            // print the fraction without the remainder
            Console.WriteLine(num - (num % 1));
        }
    }
}
