using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1000;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(num + i);
                Console.WriteLine(i / 2);
                Console.WriteLine("--");
            }
        }
    }
}
