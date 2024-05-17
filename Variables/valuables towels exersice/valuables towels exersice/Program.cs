using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuables_towels_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int towel_price = 25;

            Console.WriteLine("How many towels were taken? ");
            int towels_num = int.Parse(Console.ReadLine());

            int total = towel_price * towels_num;

            Console.WriteLine("Total: " + total);
        }
    }
}
