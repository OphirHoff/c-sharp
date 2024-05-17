using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user's name
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            // Get number of exercises
            Console.WriteLine("How many exercises would you like to have?");
            int exercises = int.Parse(Console.ReadLine());

            // Correct and wrong answeres counters
            int correct = 0;
            int wrong = 0;

            // Repeat as many times as the user asked for
            for (int i = 1; i <= exercises; i++)
            {
                // Call the random command
                Random rnd = new Random();

                // Toss two numbers and an operation
                int num1 = rnd.Next(1, 100);
                int num2 = rnd.Next(1, 100);
                int operation = rnd.Next(1, 4);

                // Check operation and give user the equation according to it
                if (operation == 1)
                {
                    Console.WriteLine($"{num1} + {num2} = ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == num1 + num2)
                        correct++;
                    else
                        wrong++;
                }

                if (operation == 2)
                {
                    Console.WriteLine($"{num1} - {num2} = ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == num1 - num2)
                        correct++;
                    else
                        wrong++;
                }

                if (operation == 3)
                {
                    num2 = rnd.Next(1, 10);
                    Console.WriteLine($"{num1} * {num2} = ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == num1 * num2)
                        correct++;
                    else
                        wrong++;

                }

                if (operation == 4)
                {
                    num1 = rnd.Next(10, 99);
                    num2 = rnd.Next(1, 10);
                    Console.WriteLine($"{num1} / {num2} = ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == num1 / num2)
                        correct++;
                    else
                        wrong++;
                }
            }

            Console.WriteLine($"You answered {exercises} exercises.");
            Console.WriteLine($"{correct} of them right! (:");
            Console.WriteLine($"{wrong} of them wrong... ):");

            // Calculate rounded final grade
            double grade = Math.Round(((double) correct / exercises) * 100);
            Console.WriteLine($"Your final grade is: {(grade)}.");

            // Check final grade and respond accordingly
            if (grade > 90)
                Console.Write($"Well Done {name}!");
            else if (grade > 80)
                Console.Write($"Very good {name}.");
            else
                Console.WriteLine($"{name} you need to improve...");

        }
    }
}
