using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number from user
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            // Get a character from user
            Console.WriteLine("Enter a character: ");
            char character = char.Parse(Console.ReadLine());

            // print charcter as many times as the number was given
            for (int i = 1; i <= num; i++)
            {
                Console.Write(character);
            }
        }
    }
}
