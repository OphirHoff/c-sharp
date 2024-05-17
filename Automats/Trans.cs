using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automats
{
    class Trans
    {
        string curr;
        char ch;
        string next;

        public Trans(string curr, char ch, string next)
        {
            this.curr = curr;
            this.ch = ch;
            this.next = next;
        }

        public string GetCurr() { return this.curr; }
        public char GetCh() { return this.ch; }
        public string GetNext() { return this.next; }
    }
}
