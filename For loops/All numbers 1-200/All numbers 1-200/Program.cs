using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_numbers_1_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for( int i = 1; i <= 200; i++ )
            {
                if (i % 8 == 0)
                    Console.WriteLine(i + " Good");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
