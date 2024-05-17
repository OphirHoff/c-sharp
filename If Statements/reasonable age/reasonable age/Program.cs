using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reasonable_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            // Get user's age
            int age = int.Parse(Console.ReadLine());

            // check if age meets the conditions
            if (age < 0 || age > 120)
                Console.WriteLine("Unreasonable age");
            else
                Console.WriteLine("Reasonable age");
        }
    }
}
