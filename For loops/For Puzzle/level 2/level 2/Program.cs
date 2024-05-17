using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num2 = 0;
            for (int i = 0; i < 10; i++)
            {
                int num = 30 + i;
                num2 = num2 + num;
                Console.WriteLine(num);
                Console.WriteLine(num2);
            }
        }
    }
}
