using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                int num = 5;
                for (int x = 1; x <= 5; x++)
                {
                    Console.Write(num);
                    num -= 1;
                }
                Console.WriteLine();
            }
        }
    }
}
