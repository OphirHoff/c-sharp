using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_equations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            // Get variable a value from user
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            // Get variable b value from user
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            // Get variable c value from user
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"{a}^x + {b}x + {c} = 0");

            Console.WriteLine("");

            // Quadratic formula using the given values
            double x1 = (double) ((-b + Math.Sqrt(b*b-4*a*c)) / (2*a));
            double x2 = (double) ((-b - Math.Sqrt(b*b-4*a*c)) / (2*a));

            // Command for no solution conditions
            if ((x1 / x1 != 1) || (x2 / x2 != 1))
                Console.WriteLine("No solution");
            else
            {
                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }

        }
    }
}
