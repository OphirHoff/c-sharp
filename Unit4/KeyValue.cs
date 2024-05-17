using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class KeyValue<TKey, TValue>
    {
        TKey key;
        TValue val;
        public KeyValue(TKey k, TValue v)
        {
            key = k;
            val = v;
        }
        public TKey Key
        {
            get => key;
            set => key = value;
        }
        public TValue Val
        {
            get => val;
            set => val = value;
        }
    }
}
