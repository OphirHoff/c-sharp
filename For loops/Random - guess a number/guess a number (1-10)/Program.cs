using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_a_number__1_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11);

            Console.WriteLine("Guess a number (1-10): ");
            int guess = int.Parse(Console.ReadLine());

            bool guessed = false;

            for (int i = 1;  i < 5; i++)
            {
                if (guessed != true)
                    if (guess > num)
                        Console.WriteLine("Sorry , too big");
                    else if (guess < num)
                        Console.WriteLine("Sorry, to small");
                    else if (guess == num)
                    {
                        Console.WriteLine("CORRECT!!!");
                        guessed = true;
                    }
                    else
                        Console.WriteLine("Goodbye!");

                
            }
        }
    }
}
