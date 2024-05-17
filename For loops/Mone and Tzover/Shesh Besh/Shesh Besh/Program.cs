using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shesh_Besh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Import random command
            Random rnd = new Random();

            // All outputs counter
            int Double = 0;
            int six = 0;
            int Double_six = 0;
            int five_six = 0;
            int one = 0;

            // Repeat a 1000 times
            for (int i = 1; i <= 1000; i++)
            {
                // Toss two numbers from 1 to 6
                int cube1 = rnd.Next(1, 7);
                int cube2 = rnd.Next(1, 7);

                // Chech if the numbers meets the requirements
                // and update counters accordingly
                if (cube1 == cube2)
                    Double++;
                if (cube1 == 6)
                    six++;
                if (cube2 == 6)
                    six++;
                if (cube1 == 6 && cube2 == 6)
                    Double_six++;
                if ((cube1 == 5 && cube2 == 6) || (cube1 == 6 && cube2 == 5))
                    five_six++;
                if (cube1 == 1)
                    one++;
                if (cube2 == 1)
                    one++;
            }

            Console.WriteLine($"Double: {Double} times,");
            Console.WriteLine($"Six: {six} times,");
            Console.WriteLine($"Double six: {Double_six} times,");
            Console.WriteLine($"Five and six: {five_six} times,");
            Console.WriteLine($"One: {one} times.");
        }
    }
}
