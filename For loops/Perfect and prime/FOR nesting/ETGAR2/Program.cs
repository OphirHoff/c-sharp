using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int k = 1; k <= 4; k++)
            {
                for (int a = 1; a <= 5; a++)
                {
                    Console.Write(num);
                }
                num += 1;
                Console.WriteLine();
            }
        }
    }
}
