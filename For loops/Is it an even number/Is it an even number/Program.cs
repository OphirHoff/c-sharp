using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_it_an_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Repeat 5 times
            for (int i = 1; i <= 5; i++)
            {
                // Get number from user
                Console.WriteLine("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(num + "->" + num % 10);

                // Check if number's units is even
                if ((num % 10) % 2 == 0)
                    Console.WriteLine("Even");
            }
        }
    }
}
