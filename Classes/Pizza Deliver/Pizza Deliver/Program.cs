using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Deliver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deliver deliver1 = new Deliver("Avi", 0, 3, 60, 20, 2, 2);
            Deliver deliver2 = new Deliver("Shlomi", 0, 3, 80, 21, 2, 4);
            Deliver deliver3 = new Deliver("Micha", 0, 3, 83, 20, 1, 5);
            Deliver deliver4 = new Deliver("Ophir", 1, 3, 120, 24, 20, 100);

            Console.WriteLine(deliver1);
        }
    }
}
