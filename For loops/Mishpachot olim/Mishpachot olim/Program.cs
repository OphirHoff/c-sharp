using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishpachot_olim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get number of families
            Console.WriteLine("Enter number of families: ");
            int families_num = int.Parse(Console.ReadLine());

            // repeat as many times as number of families given
            for (int i = 1; i <= families_num; i++)
            {
                Console.WriteLine("Enter number of boys in family: ");
                int boys = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number of girls in family: ");
                int girls = int.Parse(Console.ReadLine());

                // Check if boys number equals to girls number
                if (boys == girls)
                    Console.WriteLine("Boys number equals to girls number.");

            }
        }
    }
}
