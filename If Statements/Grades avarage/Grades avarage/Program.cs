using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_avarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first grade: ");
            // get first grade from user
            float grade1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second grade: ");
            // get second grade from user
            float grade2 = float.Parse(Console.ReadLine());

            float avarage = (grade1 + grade2) / 2;
            // whole number of avarage
            int whole_avarage = (int)avarage;
            // fraction of avarage
            float avarage_fraction = avarage - whole_avarage;

            // check fraction value
            if (avarage_fraction <= 0.49)
                Console.WriteLine($"Avarage: {avarage}, Round Avarage: {whole_avarage} (+{avarage_fraction})");
            else if (avarage_fraction >= 0.50)
                Console.WriteLine($"Avarage: {avarage}, Round Avarage: {whole_avarage + 1} (-{avarage_fraction})");





        }
    }
}
