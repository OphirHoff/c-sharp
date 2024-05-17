using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class QueueTestUtils
    {
        public static void Test_ToString()
        {
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(3);

            Console.WriteLine(q);
        }

        public static void Test_CreateQueueFromArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

        }

        public static void Test_SpilledOn()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Queue<int> newQ = new Queue<int>();

            QueueUtils.SpilledOn(newQ, q);
            Console.WriteLine(newQ);
        }

        public static void Test_Clone()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Queue<int> q2 = QueueUtils.Clone(q);
            Console.WriteLine(q2);
        }

        public static void Test_GetSize()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Console.WriteLine(QueueUtils.GetSize(q));
        }

        public static void Test_GetSum()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);
            Console.WriteLine("sum: " + QueueUtils.GetSum(q));
        }

        public static void Test_IsExist()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Console.WriteLine(QueueUtils.IsExist(q, 3));
            Console.WriteLine(QueueUtils.IsExist(q, 6));
        }

        public static void Test_LastToFirst()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.LastToFirst(q);
            Console.WriteLine(q);
        }

        public static void Test_IsSorted()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Console.WriteLine(QueueUtils.IsSorted(q));

            arr = new int[] { 2, 2, 3, 5, 4 };
            q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);
            Console.WriteLine(QueueUtils.IsSorted(q));
        }

        public static void Test_InsertToSorted()
        {
            
            int[] arr = { 1, 2, 4, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.InsertToSorted(q, 6);
            Console.WriteLine(q);
        }

        public static void Test_FindMinMax()
        {
            int[] arr = { 4, 2, 8, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);
            Console.WriteLine("min: " + QueueUtils.FindMin(q));
            Console.WriteLine("max: " + QueueUtils.FindMax(q));
        }

        public static void Test_RemoveMinMax()
        {
            int[] arr = { 0, 2, 8, 5, 7, 1 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.RemoveMin(q);
            Console.WriteLine(q);

            int[] arr1 = { 0, 2, 8, 5, 7, 1 };
            Queue<int> q1 = QueueUtils.CreateQueueFromArray(arr1);
            Console.WriteLine(q1);

            QueueUtils.RemoveMax(q1);
            Console.WriteLine(q1);
        }

        public static void Test_SortQueue()
        {
            int[] arr = { 2, 4, 3, 1 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.SortQueue(q);
            Console.WriteLine(q);

            int[] arr1 = { 0, 2, 8, 5, 7, 1 };
            Queue<int> q1 = QueueUtils.CreateQueueFromArray(arr1);
            Console.WriteLine(q1);

            QueueUtils.SortQueue(q1);
            Console.WriteLine(q1);
        }

        public static void Test_Reverse()
        {
            int[] arr = { 0, 2, 8, 5, 7, 1 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.Reverse(q);
            Console.WriteLine(q);

        }

        public static void Test_RemoveDuplicates()
        {
            int[] arr = { 1, 3, 2, 4, 3, 3, 3, 8, 5, 4, 0, 1, 10 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.RemoveDuplicates(q);
            Console.WriteLine(q);
        }

        public static void Test_Count()
        {
            int[] arr = { 1, 3, 2, 4, 3, 3, 3, 8, 5, 4, 0, 1, 10 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Console.WriteLine(QueueUtils.Count(q, 3));
        }

        public static void Test_RemoveSpec()
        {
            int[] arr = { 1, 3, 2, 4, 3, 3, 3, 8, 5, 4, 0, 1, 10 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            QueueUtils.RemoveSpec(q, 3);
            Console.WriteLine(q);

        }

        // Bagrut Exercices
        public static void Test_ToNumber()
        {
            int[] arr = { 1, 9, 6 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine(q);

            Console.WriteLine(QueueUtils.ToNumber(q));
        }

        public static void Test_BigNumber()
        {
            Queue<Queue<int>> lst = new Queue<Queue<int>>();

            int[] arr = { 6, 2 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);
            lst.Insert(q);

            arr = new int[] { 4, 2, 7 };
            q = QueueUtils.CreateQueueFromArray(arr);
            lst.Insert(q);

            arr = new int[] { 8, 2 };
            q = QueueUtils.CreateQueueFromArray(arr);
            lst.Insert(q);

            arr = new int[] { 6, 9, 1 };
            q = QueueUtils.CreateQueueFromArray(arr);
            lst.Insert(q);

            Console.WriteLine(lst);

            Console.WriteLine();

            Console.WriteLine(QueueUtils.BigNumber(lst));
        }

        public static void Test_DoublesToPali()
        {
            int[] arr = { 1, 1, 4, 4, 3, 3, 7, 7, 5, 5 };
            Queue<int> q = QueueUtils.CreateQueueFromArray(arr);

            
            Queue<int> new_q = QueueUtils.DoublesToPali(q);
            Console.WriteLine(new_q);
        }

        public static void Test_IsIdentical()
        {
            int[] arr = { 6, 2, 8, 9 };
            Queue<int> q1 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q1 : " + q1);

            arr = new int[] { 6, 2, 8, 9};
            Queue<int> q2 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q2 : " +q2);

            Console.WriteLine(QueueUtils.IsIdentical(q1, q2));

            Console.WriteLine("q1 : " + q1);
            Console.WriteLine("q2 : " + q2);

            Console.WriteLine();

            Console.WriteLine("q1 : " + q1);
            arr = new int[] { 6, 2, 8, 9, 7 };
            q2 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q2 : " + q2);

            Console.WriteLine(QueueUtils.IsIdentical(q1, q2));

            Console.WriteLine("q1 : " + q1);
            Console.WriteLine("q2 : " + q2);
        }

        public static void Test_IsSimilar()
        {
            int[] arr = { 5, 7, 4, 6 };
            Queue<int> q1 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q1 : " + q1);

            arr = new int[] { 4, 6, 5, 7 };
            Queue<int> q2 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q2 : " + q2);

            Console.WriteLine(QueueUtils.IsSimilar(q1, q2));

            Console.WriteLine("q1 : " + q1);
            Console.WriteLine("q2 : " + q2);

            Console.WriteLine();

            Console.WriteLine("q1 : " + q1);

            arr = new int[] { 4, 6, 5, 3 };
            q2 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q2 : " + q2);

            Console.WriteLine(QueueUtils.IsSimilar(q1, q2));

            Console.WriteLine("q1 : " + q1);
            Console.WriteLine("q2 : " + q2);
        }

        public static void Test_TwoSum()
        {
            int[] arr = { 5, 4, 1, 4, 3, 15, 9 };
            Queue<int> q1 = QueueUtils.CreateQueueFromArray(arr);
            Console.WriteLine("q : " + q1);

            Console.WriteLine(QueueUtils.TwoSum(q1, 10));
        }
    }
}
