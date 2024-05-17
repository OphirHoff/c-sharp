using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuables_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0.30;

            Console.WriteLine("Enter number of pages: ");
            int pages_num = int.Parse(Console.ReadLine());

            double total = price * pages_num;
            Console.WriteLine("Total: " + total);

        }
    }
}
