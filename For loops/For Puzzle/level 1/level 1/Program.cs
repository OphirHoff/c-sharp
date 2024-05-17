using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 2; i <= 8; i++)
            {
                if (i != 5)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
