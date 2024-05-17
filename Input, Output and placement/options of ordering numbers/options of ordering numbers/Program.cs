using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace options_of_ordering_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}, {0}{2}{1}, {1}{0}{2}, {1}{2}{0}, {2}{0}{1}, {2}{1}{0}", num1, num2, num3);
        }
    }
}
