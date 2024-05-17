using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueA
{
    // Each object holds a numeric value and a "priority"
    class Value
    {
        private int num;
        private int priority;

        public Value(int num, int priority)
        {
            this.num = num;
            this.priority = priority;
        }

        public int GetNum()
        {
            return this.num;
        }

        public int GetPriority()
        {
            return this.priority;
        }

        public override string ToString()
        {
            return this.num + ", P=" + this.priority;
        }
    }
}
