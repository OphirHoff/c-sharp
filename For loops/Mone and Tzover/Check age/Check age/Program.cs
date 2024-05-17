using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counter
            int proper_age = 0;

            // Repeat 30 times
            for (int i = 1; i <= 30; i++)
            {
                // Get age from user
                Console.WriteLine("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                // Check if age meets the requirements
                if (age >= 22 && age <= 44)
                {
                    proper_age++;
                }
            }
            Console.WriteLine("People between 22 to 40 years old: " + proper_age);
        }
    }
}
