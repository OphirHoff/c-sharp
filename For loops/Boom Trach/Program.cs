using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boom_Trach
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 150; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Boom Trach");

                else if (i % 3 == 0)
                    Console.WriteLine("Boom");

                else if (i % 5 == 0)
                    Console.WriteLine("Trach");
                
            }
        }
    }
}
