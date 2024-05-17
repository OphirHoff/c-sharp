using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Dictionary<TKey, TValue>
    {
        private float loadFactor;
        private int threshold;
        private int num_elements;
        private int table_size;
        private Node<KeyValue<TKey, TValue>>[] arr;
        int max_chain_length = 1;
        public TValue this[TKey key]
        {
            get => Get(key);
            set => Put(key, value);
        }
        public Dictionary() : this(4, 0.75f) { }
        public Dictionary(int init_size, float loadFactor)
        {
            this.loadFactor = loadFactor;
            this.arr = new Node<KeyValue<TKey, TValue>>[init_size];
            this.table_size = init_size;
            this.threshold = (int)(init_size * loadFactor);
            this.num_elements = 0;
        }

        public void Put(TKey key, TValue value)
        {
            int table_pos = Math.Abs(key.GetHashCode() % table_size);
            
            if (this.arr[table_pos] == null)
            {
                KeyValue<TKey, TValue> keyval = new KeyValue<TKey, TValue>(key, value);
                this.arr[table_pos] = new Node<KeyValue<TKey, TValue>>(keyval);
                this.num_elements++;
            }

            else
            {
                Node<KeyValue<TKey, TValue>> pos = this.arr[table_pos];
                Node<KeyValue<TKey, TValue>> prev = null;
                while (pos != null && !pos.GetValue().Key.Equals(key))
                {
                    prev = pos;
                    pos = pos.GetNext();
                }

                if (pos != null)
                    pos.GetValue().Val = value;

                else
                {
                    prev.SetNext(new Node<KeyValue<TKey, TValue>>(new KeyValue<TKey, TValue>(key, value)));
                    this.num_elements++;
                }

                CheckResize();
            }
        }

        public TValue Get(TKey key)
        {
            int table_pos = Math.Abs(key.GetHashCode() % table_size);
            if (arr[table_pos] == null)
                throw new KeyNotFoundException();

            Node<KeyValue<TKey, TValue>> pos = arr[table_pos];
            Node<KeyValue<TKey, TValue>> prev = null;
            while (!pos.GetValue().Key.Equals(key) && pos != null)
            {
                prev = pos;
                pos = pos.GetNext();
            }
        
            if (pos != null)
            {
                return pos.GetValue().Val;
            }

            throw new KeyNotFoundException();

        }

        public bool ContainsKey(TKey key)
        {
            int table_pos = key.GetHashCode() % table_size;
            if (arr[table_pos] == null)
                return false;

            Node<KeyValue<TKey, TValue>> pos = arr[table_pos];
            while (!pos.GetValue().Key.Equals(key) && pos != null)
                pos = pos.GetNext();

            return pos != null;
        }

        public bool Remove(TKey key)
        {
            int table_pos = key.GetHashCode();
            if (arr[table_pos] == null)
                return false;

            Node<KeyValue<TKey, TValue>> pos = arr[table_pos];
            Node<KeyValue<TKey, TValue>> prev = null;
            while (!pos.GetValue().Key.Equals(key) && pos != null)
            {
                prev = pos;
                pos = pos.GetNext();
            }

            if (pos != null)
            {
                prev.SetNext(pos.GetNext());
                this.num_elements--;
            }
                

            return pos != null;
                
        }

        private void CheckResize()
        {
            if (this.num_elements >= this.threshold)
                Resize();
        }

        private void Resize()
        {
            this.table_size *= 2;
            this.threshold = (int)(table_size * loadFactor);
            Node<KeyValue<TKey, TValue>>[] old_arr = (Node<KeyValue<TKey, TValue>>[])this.arr.Clone();
            this.arr = new Node<KeyValue<TKey, TValue>>[this.table_size];

            this.num_elements = 0;

            for (int i = 0; i < old_arr.Length; i++)
            {
                Node<KeyValue<TKey, TValue>> pos = old_arr[i];
                
                while (pos != null)
                {
                    Put(pos.GetValue().Key, pos.GetValue().Val);
                    pos = pos.GetNext();
                }
            }
        }
    }
}
