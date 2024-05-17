using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace which_is_bigger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            // Get first number from user
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            // Get second number from user
            int num2 = int.Parse(Console.ReadLine());

            // Check which of the numbers is bigger
            if (num1 > num2)
                Console.WriteLine("First number is bigger");
            else if (num2 > num1)
                Console.WriteLine("Second number is bigger");

        }
    }
}
