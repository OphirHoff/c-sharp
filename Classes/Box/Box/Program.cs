using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(2,3,4);
            Console.WriteLine(box1.SurfaceArea());

        }
    }
}
