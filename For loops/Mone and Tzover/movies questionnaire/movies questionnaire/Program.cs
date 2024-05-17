using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace movies_questionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counters
            int love_comedy = 0;
            int all_three = 0;
            int exactly_two = 0;

            // Repeat 10 times
            for (int i = 1; i <= 3; i++)
            {
                // Get what movies types the students likes
                Console.WriteLine("Do you love comedy movies? (y or n): ");
                char comedy = char.Parse(Console.ReadLine());

                Console.WriteLine("Do you love drama movies? (y or n): ");
                char drama = char.Parse(Console.ReadLine());

                Console.WriteLine("Do you love thriller movies? (y or n): ");
                char thriller = char.Parse(Console.ReadLine());

                // Check if student likes comedy
                if (comedy == 'y')
                {
                    love_comedy++;
                }
                // Check if student likes all movie types
                if (drama == 'y' && thriller == 'y' && comedy == 'y')
                {
                    all_three++;
                }
                // Check if student likes exactly two types of movies
                if ((thriller == 'y' && drama == 'y') || (thriller == 'y' && comedy == 'y') || (drama == 'y' && comedy == 'y'))
                {
                    exactly_two++;
                }
            }
            Console.WriteLine(love_comedy + " Students love comedy movies");
            Console.WriteLine(all_three + " Students love all three types");
            Console.WriteLine(exactly_two + " Students love exactly two movie types");

        }
    }
}
