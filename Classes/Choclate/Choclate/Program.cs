using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choclate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Choclate choclate1 = new Choclate("Lindt", 1, 80, 311222, true);

            Console.WriteLine(choclate1.HowManyCubesLeft());
            choclate1.Eat(2);
            Console.WriteLine(choclate1.HowManyCubesLeft());
            //choclate1.EatAll();
            //Console.WriteLine(choclate1.HowManyCubesLeft());

            choclate1.Draw();
        }
    }
}
