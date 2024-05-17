using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ophir", 15, 1.80, 65);
            Person p2 = new Person("Tom", 14, 1.70, 59);
            Person p3 = new Person("Tom", 20, 1.85, 70);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine(p2.GetName() + " has same name as " + p3.GetName() + ": " + p2.SameName(p3));

            Console.WriteLine(p2.Older(p1));


            if (p1.GoodBMI())
                Console.WriteLine(p1.GetName() + " Has good BMI");

            p1.AgePlusOne();
            Console.WriteLine(p1.GetAge());

            Console.WriteLine(p2.WhenRoundAge());
        }
    }
}
