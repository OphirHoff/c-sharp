﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETGAR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int x = 1; x <= num; x++)
                {
                    Console.Write("*");
                }
                num++;
                Console.WriteLine();
            }
        }
    }
}
