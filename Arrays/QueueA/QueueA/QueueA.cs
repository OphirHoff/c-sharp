using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueA
{
    class QueueA<T>
    {
        private T[] arr;
        private int head;
        private int tail;
        private int cnt;
      

        public QueueA(int n)
        {
            if (n > 0)
            {
                this.arr = new T[n];
                this.head = 0;
                this.tail = 0;
                this.cnt = 0;
            }
        }

        public bool Insert(T val)
        {
            if (this.cnt == this.arr.Length)
            {
                Console.WriteLine("Queue is full!");
                return false;
            }


            this.arr[this.tail] = val;
            this.tail = (this.tail + 1) % this.arr.Length;
            this.cnt++;
            return true;
        }

        public T Remove()
        {
            if (cnt == 0)
                return arr[-1];

            T save = this.arr[head];
            this.head = (this.head + 1) % this.arr.Length;
            cnt--;
            return save;
        }

        public bool IsEmpty()
        {
            return this.cnt == 0;
        }

        public override string ToString()
        {
            if (cnt == 0)
                return "Queue empty";

            string s = "";

            int index = this.head;

            for (int i = cnt; i > 0; i--)
            {
                s += this.arr[index] + "|";
                index = (index + 1) % arr.Length;
            }

            return s;
        }

    }
}
