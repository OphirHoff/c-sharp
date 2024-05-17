using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Variable
    {
        private string name;
        private int num;

        enum X {a,s,d,f,g,h, };
        private X x;

        public void PrintX(int i)
        {
            Console.WriteLine((int)X );
        }

        public Variable(string name, int value)
        {
            this.name = name;
            this.num = value;
        }

        /*public void Add()
        {
            X x = (X)this.num;
            Console.WriteLine(x);
        }*/

        public override string ToString()
        {
            return name+num;
        }

    }
}
