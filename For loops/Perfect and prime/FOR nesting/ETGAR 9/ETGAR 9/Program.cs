using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int last = 5;

            for (int i = 1; i <= 5; i++)
            {
                for (int x = 5; x >= last; x--)
                {
                    Console.Write(x);
                }
                last--;
                Console.WriteLine();
            }
        }
    }
}
