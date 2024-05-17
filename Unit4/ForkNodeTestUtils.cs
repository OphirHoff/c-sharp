using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class ForkNodeTestUtils
    {
        public static void Test_CreateForkList()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(l1);

            int[] b = { 4, 5, 6 };
            Node<int> l2 = NodeUtils.CreateListFromArray(b);
            NodeUtils.PrintList(l2);

            ForkNodeUtils.CreateForkList<int>(l1, l2, 7);
            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);
        }

        public static void Test_GetForkMeeting()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);

            int[] b = { 4, 5, 6 };
            Node<int> l2 = NodeUtils.CreateListFromArray(b);

            ForkNodeUtils.CreateForkList<int>(l1, l2, 7);
            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            Console.WriteLine(ForkNodeUtils.GetForkMeeting(l1, l2).GetValue());

            //-----------------------------------------------------

            a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            l1 = NodeUtils.CreateListFromArray(a);

            b = new int[] { 4, 5, 6 };
            l2 = NodeUtils.CreateListFromArray(b);

            Console.WriteLine(ForkNodeUtils.GetForkMeeting(l1, l2));
        }

        public static void Test_MergeForkList()
        {
            int[] a = { 5, 6, 10, 11, 12 };
            Node<int> l1 = NodeUtils.CreateListFromArray(a);

            int[] b = { 7, 8, 9 };
            Node<int> l2 = NodeUtils.CreateListFromArray(b);

            ForkNodeUtils.CreateForkList<int>(l1, l2, 3);
            NodeUtils.PrintList(l1);
            NodeUtils.PrintList(l2);

            
            NodeUtils.PrintList(ForkNodeUtils.MergeFrokList(l1, l2));

        }

    }
}
