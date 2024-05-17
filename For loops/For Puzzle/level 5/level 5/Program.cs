using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 300; i >= -399; i--)
            {
                Console.WriteLine("i = " + i + " digit = " + (i / 10) % 10);

                if (i == 10)
                {
                    i = -9;
                }
            }
        }
    }
}
