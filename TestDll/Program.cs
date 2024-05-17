using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDll;

namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Add(7, 8));

            Student s1 = new Student("ophir", 012345, 16);
            Console.WriteLine(s1);
        }
    }
}
