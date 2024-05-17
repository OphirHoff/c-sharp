using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueA;

namespace Queue_Methods
{
    internal class Program
    {

        public static QueueA<T> CreateQueuefromArray<T>(T[] arr)
        {
            QueueA<T> q = new QueueA<T>(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                q.Insert(arr[i]);
            }

            return q;
        }

        public static void SpilledOn<T>(QueueA<T> from, QueueA<T> to)
        {
            while(!from.IsEmpty())
            {
                to.Insert(from.Remove());
            }
        }

        public static QueueA<T> Clone<T>(QueueA<T> origin)
        {
            QueueA<T> temp = new QueueA<T>(1000); // temp queue to save values
            SpilledOn(origin, temp);              // move values from original q to temp q

            QueueA<T> newQ = new QueueA<T>(1000); // Clone q

            // move values to clone and back to original queue
            while(!temp.IsEmpty())
            {
                T save = temp.Remove();
                newQ.Insert(save);
                origin.Insert(save);
            }

            return newQ;
        }

        public static int Size<T>(QueueA<T> q)
        {
            // Clone q and remove until empty (using counter)

            QueueA<T> temp = Clone(q);

            int cnt = 0;
            while(!temp.IsEmpty())
            {
                temp.Remove();
                cnt++;
            }

            return cnt;
        }

        public static int Sum(QueueA<int> q)
        {
            // Clone q, remove and sum up all values until empty

            QueueA<int> temp = Clone(q);

            int sum = 0;
            while(!temp.IsEmpty())
            {
                sum += temp.Remove();
            }

            return sum;
        }

        public static bool IsExist<T>(QueueA<T> q, T eivar)
        {
            // Clone q, remove and compare to eivar (from T datatype) until found or empty

            QueueA<T> temp = Clone(q);

            bool found = false;
            while (!found && !temp.IsEmpty())
            {
                // Comparing two generic variables (temp.Remove() == eivar impermissible)
                if (EqualityComparer<T>.Default.Equals(temp.Remove(), eivar))
                    found = true;
            }

            return found;
        }

        public static void MakeLastFirst<T>(QueueA<T> q)
        {
            // Clone original queue
            QueueA<T> saveQ = Clone(q);



            // Find last value in queue + length
            int cnt = 0; // len of q
            T last = q.Remove();
            while (!q.IsEmpty())
            {
                last = q.Remove();
                cnt++;
            }

            // Insert last value first
            q.Insert(last);

            // Insert rest of values
            for (int i = 0; i < cnt; i++)
            {
                q.Insert(saveQ.Remove());
            }
        }

        public static bool IsSorted(QueueA<int> q)
        {
            QueueA<int> copyQ = Clone(q);

            int last = copyQ.Remove(); // holds last value in queue
            int current = copyQ.Remove();
            bool sorted = true;
            while(sorted && !copyQ.IsEmpty())
            {
                if (last > current)
                    sorted = false;
                last = current;
                current = copyQ.Remove();
            }

            return sorted;
        }

        public static void InsertToSrotedQueue(QueueA<int> q, int num)
        {
            // new queue for sorting
            QueueA<int> newQ = new QueueA<int>(1000);

            
            bool found = false;
            int last = 0;
            // Look for value in q bigger then new value (num)
            while(!found && !q.IsEmpty())
            {
                last = q.Remove();

                if (last > num)
                {
                    // Insert new value before q value that is bigger
                    newQ.Insert(num);
                    found = true;
                }
                newQ.Insert(last);
            }
            
            // in case didn't find a bigger valuw in queue
            if (!found)
                newQ.Insert(num);

            // move all the rest of values to newQ
            while (!q.IsEmpty())
                newQ.Insert(q.Remove());

            // Return sorted queue values to original queue reference
            SpilledOn<int>(newQ, q);
        }

        public static int FindMin(QueueA<int> q)
        {
            // Iterate through queue to find smallest value

            QueueA<int> temp = Clone(q);

            int min = temp.Remove();
            while (!temp.IsEmpty())
            {
                min = Math.Min(temp.Remove(), min);
            }

            return min;
        }

        public static int FindMax(QueueA<int> q)
        {
            // Iterate through queue to find biggest value

            QueueA<int> temp = Clone(q);

            int max = temp.Remove();
            while (!temp.IsEmpty())
            {
                max = Math.Max(temp.Remove(), max);
            }

            return max;
        }

        public static void RemoveMax(QueueA<int> q)
        {
            QueueA<int> saveQ = Clone(q);

            // Find max value index in queue
            int max = q.Remove();
            int maxIndex = 0;
            int cnt = 1;
            while (!q.IsEmpty())
            {
                int last = q.Remove();
                if (last > max)
                {
                    max = last;
                    maxIndex = cnt;
                }

                cnt++;

            }

            // Remake queue without max value
            for (int i = 0; i < cnt; i++)
            {
                int value = saveQ.Remove();

                if (i != maxIndex)
                    q.Insert(value);
            }
        }

        public static void RemoveMin(QueueA<int> q)
        {
            QueueA<int> saveQ = Clone(q);

            // Find min value index in queue
            int min = q.Remove();
            int minIndex = 0;
            int cnt = 1;
            while (!q.IsEmpty())
            {
                int last = q.Remove();
                if (last < min)
                {
                    min = last;
                    minIndex = cnt;
                }
                cnt++;
            }

            // Remake queue without min value
            for (int i = 0; i < cnt; i++)
            {
                int value = saveQ.Remove();

                if (i != minIndex)
                    q.Insert(value);
            }
        }

        static public void Sort(QueueA<int> q)
        {
            QueueA<int> temp = new QueueA<int>(1000);

            while (!q.IsEmpty())
            {
                temp.Insert(FindMin(q));
                RemoveMin(q);
            }

            SpilledOn(temp, q);
        }

        public static void Reverese<T>(ref QueueA<T> q)
        {
            QueueA<T> temp = new QueueA<T>(1000);

            while(!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                MakeLastFirst(temp);
            }
            
            q = temp;
        }

        public static void RemoveDuplicates<T>(QueueA<T> q)
        {
            // Move values from queue to array
            T[] arr = new T[Size(q)];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = q.Remove();

            // Get rid of duplicates using Distinct()
            arr = arr.Distinct().ToArray();

            // Make a queue out of array
            QueueA<T> temp = CreateQueuefromArray(arr);

            // return values to original queue
            SpilledOn(temp, q);
        }

        public static int CountOccurrence<T>(QueueA<T> q, T obj)
        {
            QueueA<T> temp = Clone(q);

            int q_size = Size(q);

            int cnt = 0;
            while(!temp.IsEmpty())
            {
                if (Equals(obj, temp.Remove()))
                    cnt++;
            }

            return cnt;
        }

        public static void RemoveObject<T>(QueueA<T> q, T obj)
        {
            QueueA<T> temp = new QueueA<T>(Size(q));
            SpilledOn(q, temp);

            while(!temp.IsEmpty())
            {
                T next = temp.Remove();

                // Put back into original queue only if not same as obj
                if (!Equals(next, obj))
                    q.Insert(next);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = {2, 1, 3, 1};
            QueueA<int> q1 = CreateQueuefromArray<int>(arr);

            QueueA<int> q2 = new QueueA<int>(10);
            //SpilledOn<int>(q1, q2);

            //InsertToSrotedQueue(q1, 10);
           
            Console.WriteLine(q1);
            RemoveObject(q1, 1);
            Console.WriteLine(q1);
        }
    }
}
