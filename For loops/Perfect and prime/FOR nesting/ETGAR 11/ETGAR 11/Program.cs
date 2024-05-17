using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaces = 4;
            int last = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int x = 1; x <= spaces; x++)
                {
                    Console.Write(" ");
                }
                for (int y = 1; y <= last; y++)
                {
                    Console.Write(y);
                }
                spaces--;
                last++;
                Console.WriteLine();
            }

        }
    }
}
