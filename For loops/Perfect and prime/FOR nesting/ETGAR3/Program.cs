using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int num = 1;
                for (int x = 1; x <= 4; x++)
                {
                    Console.Write(num);
                    num += 1;
                }
                Console.WriteLine();
            }
        }
    }
}
