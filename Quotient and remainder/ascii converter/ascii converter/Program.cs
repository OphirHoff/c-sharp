using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            // get input of any single character from the user
            char character = char.Parse(Console.ReadLine());
            
            // casting the input from a char variable into an integer
            int ascii_char = (int)character;

            Console.WriteLine($"Character's  ASCII number: {ascii_char}");
        }
    }
}
