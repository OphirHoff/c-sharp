using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st1 = "OphirH";
            string st2 = "offman";
            Console.WriteLine(st1.Length);

            string sub = st1.Substring(2,3);
            Console.WriteLine(sub);
        }
    }
}
