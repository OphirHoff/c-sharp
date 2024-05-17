using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_number_squared
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= 50; i++)
            {
                Console.WriteLine(i + ", Squared: " + Math.Pow(i,2));
            }
        }
    }
}
