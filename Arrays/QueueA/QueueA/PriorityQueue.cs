using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QueueA
{
    class PriorityQueue
    {
        private Value num;
        private int TopPriority;
        private QueueA<Value> pq; // כל עצם במחלקה הוא תור בעל איברים מטיפוס Value
        private int size;

        public PriorityQueue(int size)
        {
            this.size = size;
            this.pq = new QueueA<Value>(size);
            this.TopPriority = 5;
        }

        public bool PqInsert(int x, int priority)
        {
            if (priority > 0) 
            {
                this.num = new Value(x, priority);
                this.pq.Insert(num);
                return true;
            }

            return false;
        }

        public bool PqIsEmpty()
        {
            return this.pq.IsEmpty();
        }

        public int PqRemove()
        {
            if (this.pq.IsEmpty())
                return this.pq.Remove().GetNum();

            int maxPriorityValue = 0;
            int maxPriorityIndex = 0;
            Value temp;

            for (int i = 0; i < this.size; i++)
            {
                temp = this.pq.Remove();
                if (temp.GetPriority() > maxPriorityValue)
                {
                    maxPriorityValue = temp.GetPriority();
                    maxPriorityIndex = i;
                }

                this.pq.Insert(temp);
            }

            bool cont = true;
            while (cont)
            {
                temp = this.pq.Remove();
                if (maxPriorityIndex > 0)
                    this.pq.Insert(temp);
                else
                    cont = false;
                maxPriorityIndex--;
            }

            return maxPriorityValue;
        }

        public override string ToString()
        {
            return this.pq.ToString();

        }

    }
}
