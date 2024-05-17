using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class ForkNodeUtils
    {
        public static void CreateForkList<T>(Node<T> ls1, Node<T> ls2, int n)
        {
            while(ls2.GetNext() != null)
                ls2 = ls2.GetNext();

            for (int i = 0; i < n-1; i++)
                ls1 = ls1.GetNext();

            ls2.SetNext(ls1);
        }

        public static Node<T> GetForkMeeting<T>(Node<T> ls1, Node<T> ls2)
        {
            int size_ls1 = NodeUtils.CountList(ls1);
            int size_ls2 = NodeUtils.CountList(ls2);

            int diff = Math.Abs(size_ls2 - size_ls1);

            if (size_ls1 > size_ls2)
            {
                for (int i = 0; i < diff; i++)
                    ls1 = ls1.GetNext();
            }

            else
            {
                for (int i = 0; i < diff; i++)
                    ls2 = ls2.GetNext();
            }

            while(ls1 != ls2 && ls1 != null && ls2 != null)
            {
                ls1 = ls1.GetNext();
                ls2 = ls2.GetNext();
            }

            if (ls1 == null || ls2 == null)
                return null;

            return ls1;
        }

        public static Node<T> MergeFrokList<T>(Node<T> l1, Node<T> l2)
        {
            Node<T> merge = GetForkMeeting(l1, l2);

            int size_l1 = NodeUtils.CountList(l1);
            int size_l2 = NodeUtils.CountList(l2);

            Node<T> head = size_l1 > size_l2 ? l1 : l2;
            Node<T> pos = head;

            while (pos.GetNext() != null)
                pos = pos.GetNext();

            Node<T> conn = size_l1 > size_l2 ? l2 : l1;

            pos.SetNext(conn);

            while (conn.GetNext() != merge)
                conn = conn.GetNext();

            conn.SetNext(null);


            return head;   
        }

    }
}
