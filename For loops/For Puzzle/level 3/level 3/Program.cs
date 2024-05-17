using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace level_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 30;
            
            for (int i = -10; i <= 10; i+=2)
            {
                Console.WriteLine(i);

                if (i > 10)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
