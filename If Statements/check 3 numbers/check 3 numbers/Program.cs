using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace check_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            // Get first number from user
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            // Get second number from user
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            // Get third number from user
            int c = int.Parse(Console.ReadLine());

            // Check first condition
            if (a * a + b * b == c * c)
                Console.WriteLine("This is a Pythagorean triple!");

            // Define bigget number as max and smallest as min
            int max = 0;
            int min = 0;

            // Check which one of the numbers are the biggest and smallest
            if (a >= b && a >= c)
            {
                max = a;
                if (b >= c)
                    min = c;
                else
                    min = b;
            }
            
            if (b >= a && b >= c)
            {
                max = b;
                if (a >= c)
                    min = c;
                else
                    min = a;
            }
            
            if (c >= a && c >= b)
            {
                max = c;
                if (a >= b)
                    min = b;
                else
                    min = a;
            }

            Console.WriteLine($"{max} is the biggest, {min} is the smallest");

            // Avarage of the numbers
            double avarage = (a + b + c) / 3;

            // Check which one of the numbers is bigger than the avarage
            if (a > avarage)
                Console.WriteLine(a + " Is bigger than the avarage");
            if (b > avarage)
                Console.WriteLine(b + " Is bigger than the avarage");
            if (c > avarage)
                Console.WriteLine(c + " Is bigger than the avarage");
        }
    }
}
