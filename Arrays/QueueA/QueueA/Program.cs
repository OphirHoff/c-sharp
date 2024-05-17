using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueA
{
    class Program
    {
        public static void QueueCopy(QueueA<int> queue1, QueueA<int> queue2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int temp = queue1.Remove();
                queue1.Insert(temp);
                queue2.Insert(temp);
            }
        }

    public static void QueueReverse(QueueA<int> queue1, QueueA<int> queue2, int n)
    {

        // Make A new temporary array with same values as queue1
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = queue1.Remove();
            queue1.Insert(temp);
            arr[i] = temp;
        }

        // Insert() every value from arr in queue2 starting from the end
        for (int i = 0; i < arr.Length; i++)
        {
            queue2.Insert(arr[arr.Length - i - 1]);
        }
    }

        static public int SumEdges(QueueA<int> q, int n)
        {
            QueueA<int> newQ = new QueueA<int>(30); // Temp Queue

            // Copy q to newQ
            QueueCopy(q, newQ, n);

            // Find first value in q
            int first = newQ.Remove();

            int last = 0;
            if (newQ.IsEmpty()) 
                last = first; // if there was only 1 item in Queue

            else
            {
                // Find last value in q
                for (int i = 0; i < n - 1; i++)
                {
                    last = newQ.Remove();
                }
            }

            return first + last;
        }

        static void Main(string[] args)
        {
            //QueueA<int> arr1 = new QueueA<int>(7);

            Random rnd = new Random();
            //for (int i = 0; i < 7; i++)
            //{
            //    arr1.Insert(rnd.Next(1, 11));
            //}


            //QueueA<int> arr2 = new QueueA<int>(7);
            ////QueueCopy(arr1, arr2);

            //QueueReverse(arr1, arr2);

            //Console.WriteLine(arr1);
            //Console.WriteLine(arr2);


            //QueueA<char> Tor1 = new QueueA<char>(5);
            //for (int i = 0; i < 3; i++)
            //{
            //    Tor1.Insert('*');
            //}

            //Tor1.Insert('#');
            //Tor1.Remove();
            //Tor1.Insert('@');
            //Console.WriteLine(Tor1);

            //---------------------------------------------

            // PriorityQueue pq = new PriorityQueue(3);

            //// Priority => 1 -> 5
            //Value v1 = new Value(1, 5);
            //Value v2 = new Value(2, 1);
            //Value v3 = new Value(3, 3);

            ////      value  priority
            ////          ↓  ↓
            //pq.PqInsert(1, 5);
            //pq.PqInsert(2, 1);
            //pq.PqInsert(3, 3);

            //Console.WriteLine(pq);

            //pq.PqRemove();

            //Console.WriteLine(pq);

            //---------------------------------------------

            // Read file into array of integers
            int MaxLength = 30;
            string s = "";
            using (StreamReader sr = new StreamReader("a.txt"))
            {
                s = sr.ReadLine();
            }
            string[] numbersStrings = s.Split(' ');
            int[] numbers = new int[numbersStrings.Length];
            for (int i = 0; i < numbersStrings.Length; i++)
            {
                numbers[i] = int.Parse(numbersStrings[i]);
            }

            
            QueueA<int> q1 = new QueueA<int>(MaxLength); // New Queue
            int saveIndex = 0; // saves the index of number in list which after adding - sum of edges == 100
            int saveIforLoop = 0;
            bool cont = true;
            int cnt = 0; // counts the numbers of items in the queue

            // Go over numbers[]
            for (int i = 0; i < numbers.Length && cont; i++)
            {
                // for each number in numbers that is >0
                if (numbers[i] > 0)
                {
                    // Add to queue
                    q1.Insert(numbers[i]);
                    // Check If sum of edges == 100
                    if (SumEdges(q1, cnt + 1) == 100)
                    {
                        saveIndex = i; // save index
                        cont = false; // stop loop
                    }
                    cnt++;
                }

                // If item==0 remove from head of queue
                else if (numbers[i] == 0)
                {
                    q1.Remove();
                    cnt--;

                }
            }

            Console.WriteLine(saveIndex);
            
            Console.WriteLine(q1);

            //----------------------------------------

            //QueueA<int> tstQ = new QueueA<int>(10);
            //for (int i = 0; i < 10; i++)
            //{
            //    tstQ.Insert(rnd.Next(1, 11));
            //}
            //Console.WriteLine(tstQ);
            //whatDoIDo(tstQ);
            //Console.WriteLine(tstQ);
        }


        public static void queueShfoch(QueueA<int> q1, QueueA<int> q2)
        {
            while (!q1.IsEmpty())
                q2.Insert(q1.Remove());
        }

        public static QueueA<int> whatDoIDo(QueueA<int> q)
        {
            QueueA<int> qsod = new QueueA<int>(10);
            QueueA<int> qwhat = new QueueA<int>(10);
            int firstValue, currValue;
            if (!q.IsEmpty())
            {
                firstValue = q.Remove();
                while (!q.IsEmpty())
                {
                    currValue = q.Remove();
                    if (currValue <= firstValue)
                        qsod.Insert(currValue);
                    else
                        qwhat.Insert(currValue);
                }
                qsod = whatDoIDo(qsod);
                qwhat = whatDoIDo(qwhat);
                queueShfoch(qsod, q);
                q.Insert(firstValue);
                queueShfoch(qwhat, q);
            }
            return q;
        }

    }
}
