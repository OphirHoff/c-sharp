using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaclkA
{
    class StackA
    {
        private char[] arr;
        private int head;

        public StackA(int size)
        {
            arr = new char[size];
            head = 0;
        }

        public bool Push (char x)
        {
            if (head < arr.Length)
            {
                arr[head] = x;
                head++;
                return true;
            }
            return false;
        }

        public bool Is_Empty()
        {
            return head == 0;
        }

        public char Pop()
        {
            if (!Is_Empty())
            {
                head--;
                return arr[head];
            }
            Console.WriteLine("Error");
            return '!';
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < head; i++)
            {
                s += (arr[i] + "|");
            }
            return s;
        }
    }
}
