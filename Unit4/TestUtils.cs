using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.Policy;
//using VisualTree;

namespace Unit4
{
    public static class TestUtils
    {

        public static void Test_PrintList()
        {
            int[] a = { 4, 8, 2, 5, 8 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine();
            NodeUtils.PrintListR(l1);
        }
        public static void Test_CreateListFromArray()
        {
            Console.WriteLine($"--- {(new StackTrace()).GetFrame(0).GetMethod()} ---");
            int[] a = { 4, 8, 2, 5, 8 };
            //OtherUtils.ArrayPrint(a);

            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            Node<int> l2 = NodeUtils.CreateListFromArrayR(a, a.Length-1);

            //NodeUtils.PrintList(l1);
            //NodeUtils.PrintListR(l2);

            if (NodeUtils.Compare(l1, l2))
                Console.WriteLine("Test Pass");
            else
                Console.WriteLine("Test Failed");

        }
        //public static void Test_ReverseList()
        //{
        //    Console.WriteLine($"--- {(new StackTrace()).GetFrame(0).GetMethod()} ---");
        //    int[] a = { 4, 8, 2, 5, 8 };
        //    Node<int> l1 = NodeUtils.CreateListFromArray(a);
        //    Node<int> l2 = NodeUtils.ReverseList(l1);

        //    int[] exp_result = { 8, 5, 2, 8, 4 };
        //    Node<int> exp_result_list = NodeUtils.CreateListFromArray(exp_result);
        //    if (NodeUtils.Compare(exp_result_list, l2))
        //        Console.WriteLine("Test Pass");
        //    else
        //        Console.WriteLine("Test Failed");
        //}

        public static void Test_CompareList()
        {
            int[] a = { 7, 4, 0, 1, 5 };
            int[] b = { 7, 4, 0, 1, 5 };

            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            Node<int> l2 = NodeUtils.CreateListFromArray(b);

            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            if (NodeUtils.CompareList(l1, l2))
                Console.WriteLine("TEST 1: OK");
            else
                Console.WriteLine("TEST 1: X");

            b = new int[] { 7, 4, 0, 1 };
            l2 = NodeUtils.CreateListFromArray(b);

            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            if (!NodeUtils.CompareList(l1, l2))
                Console.WriteLine("TEST 2: OK");
            else
                Console.WriteLine("TEST 2: X");

            b = new int[] { 1, 2, 3, 4 };
            l2 = NodeUtils.CreateListFromArray(b);

            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            if (!NodeUtils.CompareList(l1, l2))
                Console.WriteLine("TEST 3: OK");
            else
                Console.WriteLine("TEST 3: X");

        }

        public static void Test_CompareListR()
        {
            int[] a = { 1, 2, 3, 5, 6, 7, 8, 9 };
            int[] b = { 1, 2, 3, 5, 6, 7, 8, 9 };

            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            Node<int> l2 = NodeUtils.CreateListFromArray(b);

            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            if (NodeUtils.CompareListR(l1, l2))
                Console.WriteLine("TEST 1: OK");
            else
                Console.WriteLine("TEST 1: X");

            b = new int[] { 1, 2, 3, 9 };
            l2 = NodeUtils.CreateListFromArray(b);

            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            if (!NodeUtils.CompareListR(l1, l2))
                Console.WriteLine("TEST 2: OK");
            else
                Console.WriteLine("TEST 2: X");

            b = new int[] { 6, 7, 8, 9, 1, 2, 3, 4, 5 };
            l2 = NodeUtils.CreateListFromArray(b);

            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            if (!NodeUtils.CompareListR(l1, l2))
                Console.WriteLine("TEST 3: OK");
            else
                Console.WriteLine("TEST 3: X");
        }

        public static void Test_CountList()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);

            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.CountList(l1));

            a = new int[] { 2, 5, 8 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result2=" + NodeUtils.CountList(l1));

            a = new int[] { 1, 6, 4, 7, 2, 3, 4, 8 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result3=" + NodeUtils.CountList(l1));

        }

        public static void Test_CountListR()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);

            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.CountListR(l1));

            a = new int[] { 2, 5, 8 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result2=" + NodeUtils.CountListR(l1));

            a = new int[] { 1, 6, 4, 7, 2, 3, 4, 8 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result3=" + NodeUtils.CountListR(l1));
        }

        public static void Test_SumList()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.SumList(l1));

            a = new int[] { 6, 0, 1 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.SumList(l1));

            a = new int[] { 1, 0, 0, 0, 0, 0, 1 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.SumList(l1));
        }

        public static void Test_SumListR()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.SumListR(l1));

            a = new int[] { 6, 0, 1 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.SumListR(l1));

            a = new int[] { 1, 0, 0, 0, 0, 0, 1 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("result1=" + NodeUtils.SumListR(l1));
        }

        public static void Test_IsExist()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("val=3 : " + NodeUtils.IsExist(l1, 3));
            Console.WriteLine("val=1 : " + NodeUtils.IsExist(l1, 1));
            Console.WriteLine("val=6 : " + NodeUtils.IsExist(l1, 6));

        }

        public static void Test_IsExistR()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("val=3 : " + NodeUtils.IsExistR(l1, 3));
            Console.WriteLine("val=1 : " + NodeUtils.IsExistR(l1, 1));
            Console.WriteLine("val=6 : " + NodeUtils.IsExistR(l1, 6));
        }

        public static void Test_FindMax()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("Max=" + NodeUtils.FindMax(l1));

            a = new int[] {-1, -2, -3, -4, -5, 0};
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("Max=" + NodeUtils.FindMax(l1));

            a = new int[] { 5 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("Max=" + NodeUtils.FindMax(l1));
        }

        public static void Test_FindMaxR()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("Max=" + NodeUtils.FindMaxR(l1));

            a = new int[] { -1, 0, -4 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("Max=" + NodeUtils.FindMaxR(l1));

            a = new int[] { 99 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("Max=" + NodeUtils.FindMaxR(l1));
        }

        public static void Test_AbsValue()
        {
            int[] a = { 1, -2, 3, -4, -5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            NodeUtils.AbsValue(l1);
            Console.WriteLine("Result : ");
            NodeUtils.PrintList(l1);
            Console.WriteLine();

            a = new int[] { -1, 0, -4 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            NodeUtils.AbsValue(l1);
            Console.WriteLine("Result : ");
            NodeUtils.PrintList(l1);
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 4 , -99};
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            NodeUtils.AbsValue(l1);
            Console.WriteLine("Result : ");
            NodeUtils.PrintList(l1);

        }

        public static void Test_AbsValueR()
        {
            int[] a = { 1, -2, 3, -4, -5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            NodeUtils.AbsValueR(l1);
            Console.WriteLine("Result : ");
            NodeUtils.PrintList(l1);
            Console.WriteLine();

            a = new int[] { -1, 0, -4 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            NodeUtils.AbsValueR(l1);
            Console.WriteLine("Result : ");
            NodeUtils.PrintList(l1);
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 4, -99 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            NodeUtils.AbsValueR(l1);
            Console.WriteLine("Result : ");
            NodeUtils.PrintList(l1); 

        }

        public static void Test_GetNodeRef()
        {
            int [] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("location=3, value=" + NodeUtils.GetNodeRef<int>(l1, 3));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 9 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("location=4, value=" + NodeUtils.GetNodeRef<int>(l1, 4));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 9 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("location=5, value=" + NodeUtils.GetNodeRef<int>(l1, 5));
            Console.WriteLine();
        }

        public static void Test_GetNodeRefR()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("location=3, value=" + NodeUtils.GetNodeRefR<int>(l1, 3));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 10 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("location=4, value=" + NodeUtils.GetNodeRefR<int>(l1, 4));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 9 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("location=5, value=" + NodeUtils.GetNodeRefR<int>(l1, 5));
            Console.WriteLine();
        }

        public static void Test_IsSorted()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSorted(l1));
            Console.WriteLine();

            a = new int[] { 2, 2, 3, 9 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSorted(l1));
            Console.WriteLine();

            a = new int[] { 1, 2, 4, 5, 8, 8, 7 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSorted(l1));
            Console.WriteLine();

            a = new int[] { 10, 20, 30, 19, 40, 50 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSorted(l1));
            Console.WriteLine();

            a = new int[] { 2 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSorted(l1));
            Console.WriteLine();
        }

        public static void Test_IsSortedR()
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSortedR(l1));
            Console.WriteLine();

            a = new int[] { 2, 2, 3, 9 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSortedR(l1));
            Console.WriteLine();

            a = new int[] { 1, 2, 4, 5, 8, 8, 7 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSortedR(l1));
            Console.WriteLine();

            a = new int[] { 10, 20, 30, 19, 40, 50 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSortedR(l1));
            Console.WriteLine();

            a = new int[] { 2 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("sorted=" + NodeUtils.IsSortedR(l1));
            Console.WriteLine();
        }

        public static void Test_CountSeqs()
        {
            Console.WriteLine();

            int[] a = { 4, 5, 6, 6, 3, 4, 4, 4, 22, 3 };
            Node<int> l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("value=4, result=" + NodeUtils.CountSeqs(l1, 4));
            Console.WriteLine();

            a = new int[] { 7, 3, 7, 7, 7, 9, 0, -1, 7, 7, 3, 3 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("value=7, result=" + NodeUtils.CountSeqs(l1, 7));
            Console.WriteLine();

            a = new int[] { 1, 2, 3 };
            l1 = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l1);
            Console.WriteLine("value=4, result=" + NodeUtils.CountSeqs(l1, 4));
            Console.WriteLine();
        }

        public static void Test_PrintAtoB()
        {
            Console.WriteLine();

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("input=5,8 | result=");
            NodeUtils.PrintAtoB(l, 5, 8);
            Console.WriteLine();
            Console.WriteLine();

            a = new int[] { 3, 8, 6, 7, 7, 9, 4, 5, 3, 1 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("input=6,9 | result=");
            NodeUtils.PrintAtoB(l, 6, 9);
            Console.WriteLine();
            Console.WriteLine();

            a = new int[] { 110, 32, 11, 76 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("input=1,4 | result=");
            NodeUtils.PrintAtoB(l, 1, 4);
        }

        public static void Test_BalancedList()
        {
            int[] a = { 5,10,2,8,7,3 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("(expacting true)=>" + NodeUtils.BalancedList(l));
            Console.WriteLine();

            a = new int[] { 2, 9, 5, 7, 1, 6, 3, 8 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("(expacting true)=>" + NodeUtils.BalancedList(l));
            Console.WriteLine();

            a = new int[] { 10, 20, 30, 40, 50, 60, 70 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("(expacting true)=>" + NodeUtils.BalancedList(l));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 4, 5, 10 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("(expacting false)=>" + NodeUtils.BalancedList(l));
            Console.WriteLine();
        }

        public static void Test_RemoveMax()
        {
            int[] a = { 11, 7, 2, 8, 10, 3 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            (Node<int> max, Node<int> lst) = NodeUtils.RemoveMax(l);
            Console.WriteLine("max value = " + max);
            Console.Write("Updated list : ");
            NodeUtils.PrintList<int>(lst);
            Console.WriteLine();

            a = new int[] { 2, 9, 5, 7, 1, 6, 3, 10 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            (max, lst) = NodeUtils.RemoveMax(l);
            Console.WriteLine("max value = " + max);
            Console.Write("Updated list : ");
            NodeUtils.PrintList<int>(lst);
            Console.WriteLine();

            a = new int[] { 7, 3, 7, 7, 7, 9, 0, -1, 7, 7, 3, 3 };
            l = NodeUtils.CreateListFromArray<int>(a);
            NodeUtils.PrintList(l);
            (max, lst) = NodeUtils.RemoveMax(l);
            Console.WriteLine("max value = " + max);
            Console.Write("Updated list : ");
            NodeUtils.PrintList<int>(lst);

        }

        public static void Test_RemoveDuplicates()
        {
            Console.WriteLine();

            int[] a = { 5, 3, 3, 2, 0, 1 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("result=");
            NodeUtils.PrintList(NodeUtils.RemoveDuplicates(l));
            Console.WriteLine();

            a = new int[] { 2, 6, 4, 2, 8, 4, 4, 6, 1, 9 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("result=");
            NodeUtils.PrintList(NodeUtils.RemoveDuplicates(l));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 4, 5, 1, 5, 5 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("result=");
            NodeUtils.PrintList(NodeUtils.RemoveDuplicates(l));
        }

        public static void Test_InsertToSortedList()
        {
            Console.WriteLine();

            int[] a = { 1, 2, 3, 5 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            NodeUtils.InsertToSortedList(l, new Node<int>(4));
            Console.Write("new value = 4 | result : ");
            NodeUtils.PrintList(l);
            Console.WriteLine();

            a = new int[] { 1, 1 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            NodeUtils.InsertToSortedList(l, new Node<int>(2));
            Console.Write("new value = 2 | result : ");
            NodeUtils.PrintList(l);
            Console.WriteLine();

            a = new int[] { 1, 2, 2, 19, 23, 24 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            NodeUtils.InsertToSortedList(l, new Node<int>(7));
            Console.Write("new value = 7 | result : ");
            NodeUtils.PrintList(l);
        }

        public static void Test_Sort()
        {
            Console.WriteLine();

            int[] a = { 3, 2, 1, 5, 4 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("Sorted : ");
            NodeUtils.PrintList(NodeUtils.Sort(l));
            Console.WriteLine();

            a = new int[] { 5, 2, 3, 1, 3, 9, 10, 7, 4 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("Sorted : ");
            NodeUtils.PrintList(NodeUtils.Sort(l));
            Console.WriteLine();

            a = new int[] { 100, 90, 80, 70, 65, 35, 11, 78, -2, 0 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("Sorted : ");
            NodeUtils.PrintList(NodeUtils.Sort(l));
            Console.WriteLine();
        }

        public static void Test_ReverseList()
        {
            int[] a = { 4, 8, 2, 5, 8 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("reversed : ");
            NodeUtils.PrintList(NodeUtils.ReverseList<int>(l));
            Console.WriteLine();

            a = new int[] { 5, 2, 3, 1, 3, 9, 10, 7, 4 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("reversed : ");
            NodeUtils.PrintList(NodeUtils.ReverseList<int>(l));
            Console.WriteLine();

            a = new int[] { 4, 7, 2, 9, 5 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("reversed : ");
            NodeUtils.PrintList(NodeUtils.ReverseList<int>(l));

        }
        public static void Test_ReverseListR()
        {
            int[] a = { 4, 8, 2, 5, 8 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("reversed : ");
            NodeUtils.PrintList(NodeUtils.ReverseListR<int>(l));
            Console.WriteLine();

            a = new int[] { 5, 2, 3, 1, 3, 9, 10, 7, 4 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("reversed : ");
            NodeUtils.PrintList(NodeUtils.ReverseListR<int>(l));
            Console.WriteLine();

            a = new int[] { 4, 7, 2, 9, 5 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.Write("reversed : ");
            NodeUtils.PrintList(NodeUtils.ReverseListR<int>(l));

        }

        public static void Test_NegativeSequence()
        {
            int[] a = { 2, -1, -3, 5 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("result=" + NodeUtils.NegativeSequence(l));
            Console.WriteLine();

            a = new int[] { 4, -2, -9, 1, 2, -8, -3, -1, 6, -5, -1 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("result=" + NodeUtils.NegativeSequence(l));
            Console.WriteLine();

            a = new int[] { -5, 1, 1, -9, 3, -8, -4, -99, -12, 0, 0, -5, -11, -5, 100, -23 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("result=" + NodeUtils.NegativeSequence(l));
            Console.WriteLine();

            a = new int[] { 1, 2, 3, 7, 3, 0 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine("result=" + NodeUtils.NegativeSequence(l));
        }

        public static void Test_MergeSortedLists()
        {
            Console.WriteLine();

            int[] a = { 1, 4, 9 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            Console.Write("list1 : ");
            NodeUtils.PrintList(l1);

            int[] b = { 2, 5 };
            Node<int> l2 = NodeUtils.CreateListFromArray(b);
            Console.Write("list2 : ");
            NodeUtils.PrintList(l2);

            Console.WriteLine("merged : ");
            NodeUtils.PrintList(NodeUtils.MergeSortedLists(l1, l2));
            Console.WriteLine();

            a = new int[] { 1, 5, 9, 22 };
            l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            b = new int[] { 0, 2, 11, 24, 220 };
            l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.WriteLine("merged : ");
            NodeUtils.PrintList(NodeUtils.MergeSortedLists(l1, l2));
            Console.WriteLine();

            a = new int[] { 10, 20, 30, 40, 50, 100 };
            l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            b = new int[] { 1, 2, 3, 4, 19, 20, 40, 42, 99, 101 };
            l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.WriteLine("merged : ");
            NodeUtils.PrintList(NodeUtils.MergeSortedLists(l1, l2));
        }

        public static void Test_MergeSortedLists2()
        {
            Console.WriteLine();

            int[] a = { 1, 4, 9 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            Console.Write("list1 : ");
            NodeUtils.PrintList(l1);

            int[] b = { 2, 5 };
            Node<int> l2 = NodeUtils.CreateListFromArray(b);
            Console.Write("list2 : ");
            NodeUtils.PrintList(l2);

            Console.WriteLine("merged : ");
            NodeUtils.PrintList(NodeUtils.MergeSortedLists2(l1, l2));
            Console.WriteLine();

            a = new int[] { 2, 3, 9 };
            l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            b = new int[] { 1, 1 };
            l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.WriteLine("merged : ");
            NodeUtils.PrintList(NodeUtils.MergeSortedLists2(l1, l2));
            Console.WriteLine();

            a = new int[] { 10, 20, 30, 40, 50, 100 };
            l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            b = new int[] { 1, 2, 3, 4, 19, 20, 40, 42, 99, 101 };
            l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.WriteLine("merged : ");
            NodeUtils.PrintList(NodeUtils.MergeSortedLists2(l1, l2));


        }

        public static void Test_AddFollowingNum()
        {
            Console.WriteLine();

            int[] a = { 9, 15, 20 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            NodeUtils.AddFollowingNum(l, 15);
            Console.Write("val=15 | result : ");
            NodeUtils.PrintList(l);
            Console.WriteLine();

            a = new int[] { 1, 3, 7, 11 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            NodeUtils.AddFollowingNum(l, 7);
            Console.Write("val=7 | result : ");
            NodeUtils.PrintList(l);
            Console.WriteLine();

            a = new int[] { -3, 2, 18, 9 };
            l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            NodeUtils.AddFollowingNum(l, 9);
            Console.Write("val=9 | result : ");
            NodeUtils.PrintList(l);
            Console.WriteLine();
        }

        public static void Test_ListsIntersection()
        {
            Console.WriteLine();

            int[] a = { 3,1,5 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            int[] b = { 2, 3, 6 };
            Node<int> l2= NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.Write("result : ");
            NodeUtils.PrintList(NodeUtils.ListsIntersection(l1, l2));

            Console.WriteLine();


            a = new int[] { 1, 8, 2, 6, 3 };
            l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            b = new int[] { 9, 1, 7, 3, 6 };
            l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.Write("result : ");
            NodeUtils.PrintList(NodeUtils.ListsIntersection(l1, l2));



            Console.WriteLine();

            a = new int[] { 4, -2, 18, 55, 27 };
            l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            b = new int[] { -2, 0, 1, 4 };
            l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            Console.Write("result : ");
            NodeUtils.PrintList(NodeUtils.ListsIntersection(l1, l2));

        }

        public static void Test_IsPalindrome()
        {
            char[] a = { 'a', 'b', 'c', 'b', 'a' };
            Node<char> l = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l);
            Console.WriteLine(NodeUtils.IsPalindrome(l));
        }
    }
}

