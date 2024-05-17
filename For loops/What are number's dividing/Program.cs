using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_are_number_s_dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get number from user
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            // Repeat from 1 to the number's value
            for (int i = 1; i <= 6; i++)
            {
                // Check if number is divisible by i
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
