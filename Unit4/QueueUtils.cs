using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace Unit4
{
    class QueueUtils
    {
        public static Queue<T> CreateQueueFromArray<T>(T[] arr)
        {
            Queue<T> s = new Queue<T>();

            for (int i = 0; i < arr.Length; i++)
            {
                s.Insert(arr[i]);
            }

            return s;
        }
        public static void SpilledOn<T>(Queue<T> dest, Queue<T> src)
        {
            while (!src.IsEmpty())
            {
                T temp = src.Remove();
                dest.Insert(temp);
            }
        }

        public static Queue<T> Clone<T>(Queue<T> s)
        {
            Queue<T> t = new Queue<T>();
            Queue<T> s2 = new Queue<T>();

            SpilledOn(t, s);

            while(!t.IsEmpty())
            {
                T temp = t.Remove();
                s.Insert(temp);
                s2.Insert(temp);
            }

            return s2;
        }
        public static int GetSize<T>(Queue<T> q)
        {
            int count = 0;

            Queue<T> temp = Clone(q);
            while (!temp.IsEmpty())
            {
                temp.Remove();
                count++;
            }

            return count;
        }

        public static int GetSum(Queue<int> q)
        {
            int sum = 0;

            Queue<int> temp = Clone(q);
            while (!temp.IsEmpty())
            {
                
                sum+=temp.Remove();
            }

            return sum;
        }

        public static bool IsExist<T>(Queue<T> q, T e)
        {
            Queue<T> temp = Clone(q);

            while (!temp.IsEmpty())
            {
                if (EqualityComparer<T>.Default.Equals(temp.Remove(), e))
                    return true;
            }
            return false;
        }

        public static void LastToFirst<T>(Queue<T> q)
        {
            Queue<T> temp = new Queue<T>();

            int l = GetSize(q) - 1;

            for (int i = 0; i < l; i++)
            {
                temp.Insert(q.Remove());
            }

            while(!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
        }

        public static bool IsSorted(Queue<int> q)
        {
            Queue<int> temp = Clone(q);

            bool sorted = true;
            int last = q.Head();
            while(!temp.IsEmpty() && sorted)
            {
                int curr = temp.Remove();
                sorted = last <= curr;
                last = curr;
            }

            return sorted;
        }

        public static void InsertToSorted(Queue<int> q,  int val)
        {
            Queue<int> temp = new Queue<int>();

            bool found = false;

            while (!q.IsEmpty())
            {
                int curr = q.Remove();
                if (val < curr && !found)
                {
                    temp.Insert(val);
                    temp.Insert(curr);
                    found = true;
                }
                else
                {
                    temp.Insert(curr);
                    
                }
                
            }

            if (!found)
            {
                temp.Insert(val);
            }

            SpilledOn(q, temp);
        }

        public static int FindMin(Queue<int> q)
        {
            Queue<int> temp = Clone(q);

            int min = int.MaxValue;

            while(!temp.IsEmpty())
            {
                int val = temp.Remove();
                if (val < min)
                    min = val;
            }

            return min;
        }

        public static int FindMax(Queue<int> q)
        {
            Queue<int> temp = Clone(q);

            int max = int.MinValue;

            while (!temp.IsEmpty())
            {
                int val = temp.Remove();
                if (val > max)
                    max = val;
            }

            return max;
        }

        public static void RemoveMin(Queue<int> q)
        {
            Queue<int> temp = Clone(q);

            int min_index = 0;
            int min = int.MaxValue;
            int cnt = 0;

            while (!temp.IsEmpty())
            {
                int val = temp.Remove();
                if (val < min)
                {
                    min = val;
                    min_index = cnt;
                }
                cnt++;
            }

            SpilledOn(temp, q);

            int l = GetSize(temp);

            for (int i = 0; i < l; i++)
            {
                int val = temp.Remove();
                if (i != min_index)
                {
                    q.Insert(val);
                }
            }

        }

        public static void RemoveMax(Queue<int> q)
        {
            Queue<int> temp = Clone(q);

            int max_index = 0;
            int max = int.MinValue;
            int cnt = 0;

            while (!temp.IsEmpty())
            {
                int val = temp.Remove();
                if (val > max)
                {
                    max = val;
                    max_index = cnt;
                }
                cnt++;
            }

            SpilledOn(temp, q);

            int l = GetSize(temp);

            for (int i = 0; i < l; i++)
            {
                int val = temp.Remove();
                if (i != max_index)
                {
                    q.Insert(val);
                }
            }
        }

        public static void SortQueue(Queue<int> q)
        {
            int l = GetSize(q);
            Queue<int> temp = new Queue<int>();

            for (int i = 0; i < l; i++)
            {
                int val = FindMin(q);
                temp.Insert(val);
                RemoveMin(q);
            }

            SpilledOn(q, temp);
        }

        public static void Reverse<T>(Queue<T> q)
        {
            int l = GetSize(q);

            Queue<T> new_q = new Queue<T>();
            Queue<T> save_q = new Queue<T>();
            SpilledOn(save_q, q);

            for (int i = 0; i < l; i++)
            {
                Queue<T> temp = Clone(save_q);
                for (int j = 0; j < l - i - 1; j++)
                    temp.Remove();
                q.Insert(temp.Remove());
            }
        }

        public static void RemoveDuplicates(Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            SpilledOn(temp, q);

            while (!temp.IsEmpty())
            {
                int val = temp.Remove();
                if (!IsExist(q, val))
                    q.Insert(val);
            }
        }

        public static int Count(Queue<int> q, int n)
        {
            Queue<int> temp = Clone(q);

            int cnt = 0;

            while (!temp.IsEmpty())
            {
                if (temp.Remove() == n)
                    cnt++;
            }

            return cnt;
        }

        public static void RemoveSpec(Queue<int> q, int val)
        {
            Queue<int> temp = new Queue<int>();
            SpilledOn(temp, q);

            while (!temp.IsEmpty())
            {
                int curr = temp.Remove();
                if (curr != val)
                    q.Insert(curr);
            }
        }

        public static void InsertAtPos<T>(Queue<T> q, T e, int n)
        {
        }

        // --- Bagrut Exercices ---
        public static int ToNumber(Queue<int> q)
        {
            int num = 0;

            while (!q.IsEmpty())
            {
                int val = q.Remove();

                num *= 10;
                num += val;
            }

            return num;
        }

        public static int BigNumber(Queue<Queue<int>> q)
        {
            int max = int.MinValue;

            Queue<Queue<int>> clone = Clone(q);

            while (!clone.IsEmpty())
            {
                int val = ToNumber(clone.Remove());
                if (val > max)
                    max = val;
            }

            return max;
        }

        // ---
        public static void ConnectQueues<T>(Queue<T> q1, Queue<T> q2)
        {
            Queue<T> temp = Clone(q2);

            while (!temp.IsEmpty())
                q1.Insert(temp.Remove());
        }
        public static Queue<int> DoublesToPali(Queue<int> qd)
        {
            if (GetSize(qd) == 2)
                return qd;

            Queue<int> res = new Queue<int>();
            res.Insert(qd.Remove());
            int val = qd.Remove();
            ConnectQueues(res, DoublesToPali(qd));
            res.Insert(val);

            return res;
        }

        // ---
        public static bool IsIdentical(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> copy1 = Clone(q1);
            Queue<int> copy2 = Clone(q2);

            bool identical = true;

            while(identical && !copy1.IsEmpty() && !copy2.IsEmpty())
            {

                identical = copy1.Remove() == copy2.Remove();

                if ((!copy1.IsEmpty() && copy2.IsEmpty()) || (copy1.IsEmpty() && !copy2.IsEmpty()))
                    identical = false;  
            }

            return identical;
        }

        public static bool IsSimilar(Queue<int> q1, Queue<int> q2)
        {
            int size = GetSize(q1);

            bool similar = false;

            for (int i = 0; i < size && !similar; i++)
            {
                similar = IsIdentical(q1, q2);
                LastToFirst(q1);
            }

            return similar;

        }

        // -- Bagrut 2023
        public static bool TwoSum(Queue<int> q, int x)
        {
            bool found = false;
            Queue<int> copy = Clone(q);

            while (!found && !copy.IsEmpty())
            {
                Queue<int> temp = Clone(copy);
                int head = temp.Remove();

                while(!temp.IsEmpty() && !found)
                {
                    found = head + temp.Remove() == x;
                }

                copy.Remove();
            }

            return found;
            

        }
        
    }
}











