using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int first = 1;
            int last = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int x = first; x <= last; x++)
                {
                    Console.Write(x);
                }
                first++;
                last += 2;
                Console.WriteLine();
            }
        }
    }
}
