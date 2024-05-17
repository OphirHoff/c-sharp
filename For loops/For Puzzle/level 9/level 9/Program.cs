using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = (double)1 / 3;

            for (double i = 1 + num; i < 14.4; i += num)
            {
                Console.WriteLine("d=" + i);
            }
        }
    }
}
