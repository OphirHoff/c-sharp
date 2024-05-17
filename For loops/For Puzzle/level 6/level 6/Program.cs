using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace level_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 69; i <= 75; i++)
            {
                if (i != 75)
                    Console.Write((char)i + ", ");
                else
                    Console.Write((char)i);
            }
        }
    }
}
