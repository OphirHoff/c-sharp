using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int t = 1; t <= 10; t++)
            {

                int i = (t - 1) * 10;

                Console.WriteLine("i=" + i);
                Console.WriteLine("t=" + t);
                Console.WriteLine("sum=" + sum);
                Console.WriteLine("--");

                if (sum < 21)
                {
                    sum += t;
                }

            }
        }
    }
}
