using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Grades from 60 to 100 counter
            int above_60 = 0;
            // Grades from 90 to 100 counter
            int above_90 = 0;

            // Repeat 10 times
            for (int i = 1; i <= 10; i++)
            {
                //Get grade from user
                Console.WriteLine("Enter a grade: ");
                int grade = int.Parse(Console.ReadLine());

                // Check if grade is above 60 or 90
                if (grade >= 90)
                    above_90 += 1;
                else if (grade >= 60)
                    above_60 += 1;
                    
            }
            Console.WriteLine($"Grades above 60: {above_60}");
            Console.WriteLine($"Grades above 90: {above_90}");



        }
    }
}
