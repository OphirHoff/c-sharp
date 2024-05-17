using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication: " + x*y);
        }
    }
}
