using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num >= 0)
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);
            }
        }
    }
}
