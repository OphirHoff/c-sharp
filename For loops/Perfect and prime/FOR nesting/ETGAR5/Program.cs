using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int x = 1; x <= 4; x++)
            {
                for (int i = num; i <= num+4; i++)
                {
                    Console.Write(i);
                }

                num++;
                Console.WriteLine();
            }
        }
    }
}
