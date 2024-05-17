using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_handed_in
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int all_done = 0;
            int not_everything = 0;
            int non_done = 0;

            // Get number of needed programs for this semester from user
            Console.WriteLine("How many programs are needed to be handed in this semester? ");
            int programs_needed = int.Parse(Console.ReadLine());

            // Repeat 30 times
            for (int i = 1; i <= 30; i++)
            {
                // Get number of programs handed in
                Console.WriteLine("How many programs did the student hand in? ");
                int programs_handed = int.Parse(Console.ReadLine());

                // Check if number of programs handed in is equal, less than the needed, or 0
                if (programs_handed == programs_needed)
                {
                    all_done++;
                }
                if (programs_handed  < programs_needed && programs_handed > 0)
                {
                    not_everything++;
                }
                else
                {
                    non_done++;
                }
            }
            Console.WriteLine($"{all_done} students handed in everything");
            Console.WriteLine($"{not_everything} students handed in only a part of the needed number");
            Console.WriteLine($"{non_done} students did not hand in anything");
        }
    }
}
