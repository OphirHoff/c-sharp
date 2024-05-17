using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory_driving_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counter
            int failed = 0;

            // Get number of tested from user
            Console.WriteLine("How many were tested? ");
            int tested = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tested; i++)
            {
                // Get number of mistakes made on traffic signs questions
                Console.WriteLine("How many mistakes were made on traffic signs questions? ");
                int sign_mistakes = int.Parse(Console.ReadLine());

                // Mistakes on other types of questions
                Console.WriteLine("How many other mistakes were made on other questions? ");
                int otherQuestions_mistakes = int.Parse(Console.ReadLine());

                // Check if student failed according to requirements
                if (sign_mistakes > 0 || otherQuestions_mistakes > 3)
                {
                    failed++;
                }
            }

            double fails_precentage = (failed / tested) * 100;
            Console.WriteLine($"{failed} failed. That's {fails_precentage}% of the tests");
        }
    }
}
