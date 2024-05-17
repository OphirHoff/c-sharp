using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class BinNodeTestUtils
    {
        public static void Test_CreateListFromArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            BinNode<int> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);
        }

        public static void Test_InsertNodeToSorted()
        {
            int[] arr = { 1, 2, 4 };
            BinNode<int> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);

            lst = BinNodeUtils.InsertNodeToSorted(lst, 3);

            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine();

            //---
            arr = new int[] { 1, 2, 3 };
            lst = BinNodeUtils.CreateListFromArray(arr);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);

            lst = BinNodeUtils.InsertNodeToSorted(lst, 4);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine();

            //--
            arr = new int[] { 2,3,4 };
            lst = BinNodeUtils.CreateListFromArray(arr);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);

            lst = BinNodeUtils.InsertNodeToSorted(lst, 1);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);
        }

        public static void Test_RemoveBinNode()
        {
            int[] arr = { 1, 2, 4 };
            BinNode<int> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);

            lst = BinNodeUtils.RemoveBinNode(lst, lst.GetRight());
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine();

            //--
            arr = new int[] { 1, 2, 3, 4, 5, 6 };
            lst = BinNodeUtils.CreateListFromArray(arr);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);

            lst = BinNodeUtils.RemoveBinNode(lst, lst);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine();

            //--
            arr = new int[] { 1, 2, 3 };
            lst = BinNodeUtils.CreateListFromArray(arr);
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);

            lst = BinNodeUtils.RemoveBinNode(lst, lst.GetRight().GetRight());
            Console.WriteLine();
            BinNodeUtils.PrintBinNode(lst);

        }

        public static void Test_IsExist()
        {
            int[] arr = { 1, 2, 3, 4 };
            BinNode<int> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);

            Console.WriteLine(BinNodeUtils.IsExist(lst, lst.GetRight()));

            Console.WriteLine(BinNodeUtils.IsExist(lst, 3));
            Console.WriteLine(BinNodeUtils.IsExist(lst, 0));
        }

        public static void Test_GetLast()
        {
            int[] arr = { 1, 2, 3, 4 };
            BinNode<int> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);

            Console.WriteLine();
            Console.WriteLine(BinNodeUtils.GetLast(lst));
        }

        public static void Test_IsPalindrome()
        {
            char[] arr = { '1', '2', '3', '4' };
            BinNode<char> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine(" | " + BinNodeUtils.IsPalindrome(lst));

            Console.WriteLine();

            arr = new char[] { '1', '2', '3', '4', '3', '2', '1' };
            lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine(" | " + BinNodeUtils.IsPalindrome(lst));
        }

        public static void Test_GetMiddle()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            BinNode<int> lst = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst);
            Console.WriteLine(" | " + BinNodeUtils.GetMiddle(lst));
        }

        public static void Test_CreateReverseOrder()
        {
            BinNode<int> lst = BinNodeUtils.CreateReverseOrder();
            BinNodeUtils.PrintBinNode(lst);
        }

        public static void Test_MergeListsInMiddle()
        {
            int[] arr = { 3, 6, 4, 88 };
            BinNode<int> lst1 = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst1);
            Console.WriteLine();

            arr = new int[] { 10, 40, 30 };
            BinNode<int> lst2 = BinNodeUtils.CreateListFromArray(arr);
            BinNodeUtils.PrintBinNode(lst2);
            Console.WriteLine();

            BinNodeUtils.MergeListsInMiddle(lst1, lst2);
            Console.WriteLine("Result : ");
            BinNodeUtils.PrintBinNode(lst1);


        }
    }

    
}
