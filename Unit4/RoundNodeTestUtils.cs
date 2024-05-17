using System;

namespace Unit4
{
    class RoundNodeTestUtils
    {
        public static void Test_PrintRoundList()
        {
            Console.WriteLine();

            int[] a = { 3, 1, 5, 7, 2, 9 };
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + ",");

            Console.WriteLine();
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l1);
            RoundNodeUtils.PrintRoundList(l1);

        }

        public static void Test_DisconnectRoundList()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l1);
            RoundNodeUtils.PrintRoundList(l1);

            Console.WriteLine();

            RoundNodeUtils.DisconnectRoundList(l1);


            NodeUtils.PrintList(l1);
        }

        public static void Test_IsRoundList()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("result (expecting true) = " + RoundNodeUtils.IsRoundList(l));
            Console.WriteLine();

            RoundNodeUtils.DisconnectRoundList(l);
            Console.WriteLine("result (expecting false) = " + RoundNodeUtils.IsRoundList(l));

        }

        public static void Test_ListLength()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();

            Console.WriteLine(RoundNodeUtils.ListLength(l));
        }

        public static void Test_SumList()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();

            Console.WriteLine("result=" + RoundNodeUtils.SumList(l));
        }

        public static void Test_RemoveHead()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();

            l = RoundNodeUtils.RemoveHead(l);
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
        }

        public static void Test_RemoveLast()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();

            RoundNodeUtils.RemoveLast(l);

            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
        }

        public static void Test_IsExist()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();

            Console.WriteLine("value=2 | result=" + RoundNodeUtils.IsExist(l, 2));
            Console.WriteLine("value=1 | result=" + RoundNodeUtils.IsExist(l, 1));
            Console.WriteLine("value=4 | result=" + RoundNodeUtils.IsExist(l, 4));
        }

        public static void Test_RemoveEven()
        {
            int[] a = { 2, 1, 1, 2, 1 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            Console.WriteLine();

            l = RoundNodeUtils.RemoveEven(l);
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();


            a = new int[] { 4, 9, 3, 12, 22, 23, 0, 0, 8, 5 };
            l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            Console.WriteLine();

            l = RoundNodeUtils.RemoveEven(l);
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();
        }

        public static void Test_AddToEven()
        {
            int[] a = { 3, 6, 2, 9, 5, 4};
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            RoundNodeUtils.AddToEven(l);
            Console.WriteLine();
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();
            Console.WriteLine();

            a = new int[] { 8, 9, 2, 2, 0, 13, 1, 6 };
            l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            Console.WriteLine();
            RoundNodeUtils.AddToEven(l);
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);

        }

        public static void Test_AddToLoop()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            Console.WriteLine();

            l = RoundNodeUtils.AddToLoop(l, new Node<int>(16));

            Console.Write("value added = 16 | Result : ");
            RoundNodeUtils.PrintRoundList(l);
        }

        public static void Test_SumNeighbors()
        {
            int[] a = { 3, 1, 5, 7, 2, 9 };
            Node<int> l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            Console.WriteLine();

            RoundNodeUtils.SumNeighbors(l);
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();

            a = new int[] { 5, 1, 8, 2 };
            l = NodeUtils.CreateListFromArray(a);
            RoundNodeUtils.MakeListRound(l);
            RoundNodeUtils.PrintRoundList(l);

            Console.WriteLine();

            RoundNodeUtils.SumNeighbors(l);
            Console.Write("result : ");
            RoundNodeUtils.PrintRoundList(l);
            Console.WriteLine();
        }

        public static void Test_HasLoop()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 }; 
            Node<int> l = NodeUtils.CreateListFromArray(a);
            Node<int> l2 = NodeUtils.CloneList(l);
            NodeUtils.PrintList(l);
            Console.WriteLine();
            Console.WriteLine("result (linear) : " + RoundNodeUtils.HasLoop(l));


            Node<int> pos = l2;
            Node<int> three = null;
            while (pos.GetValue() != 6)
            {
                pos = pos.GetNext();
                if (pos.GetValue() == 3) three = pos;
            }

            pos.SetNext(three);

            Console.WriteLine();
            Console.WriteLine("result (circular) : " + RoundNodeUtils.HasLoop(l2));
        }

        public static void Test_PrintLoopRoundList()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Node<int> lst = NodeUtils.CreateListFromArray(a);

            NodeUtils.PrintList(lst);

            RoundNodeUtils.CreateLoopList(lst, 6);

            RoundNodeUtils.PrintLoopRoundList(lst);

        }
    }
}
