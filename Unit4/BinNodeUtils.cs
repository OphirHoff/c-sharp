using System;
using System.Collections.Generic;

namespace Unit4
{
    public static class BinNodeUtils
    {
        public static BinNode<T> CreateListFromArray<T>(T[] arr)
        {
            BinNode<T> head = new BinNode<T>(arr[0]);

            BinNode<T> pos = head;
            for (int i = 1; i < arr.Length; i++)
            {
                pos.SetRight(new BinNode<T>(pos, arr[i], null));
                pos = pos.GetRight();
            }

            return head;
        }

        public static void InsertNodeAfter<T>(BinNode<T> left, BinNode<T> node)
        {

            BinNode<T> temp = left.GetRight();
            left.SetRight(node);
            left.GetRight().SetLeft(node);
            if (temp != null)
            {
                node.SetRight(temp);
                temp.SetLeft(node);
            }

        }

        public static BinNode<T> InsertNodeBefore<T>(BinNode<T> right, BinNode<T> node)
        {
            right.SetLeft(node);
            right.GetLeft().SetRight(right);
            return right.GetLeft(); // return new head
        }

        public static BinNode<int> InsertNodeToSorted(BinNode<int> lst, int n)
        {
            BinNode<int> head = lst;

            int cnt = 0;
            while (lst.GetRight() != null && lst.GetRight().GetValue() <= n)
            {
                lst = lst.GetRight();
                cnt++;
            }

            // If insertion is in first place
            if (cnt == 0)
                head = InsertNodeBefore(lst, new BinNode<int>(n));

            else
                InsertNodeAfter(lst, new BinNode<int>(n));

            return head;
        }

        public static BinNode<T> RemoveBinNode<T>(BinNode<T> lst, BinNode<T> node)
        {
            // if node if head
            if (!node.HasLeft())
            {
                node.GetRight().SetLeft(null);
                return node.GetRight();  // new head
            }

            // if node is last
            else if (!node.HasRight())
            {
                node.GetLeft().SetRight(null);
                return lst;
            }

            else
            {
                node.GetLeft().SetRight(node.GetRight());
                node.GetRight().SetLeft(node.GetLeft());
                return lst;
            }
        }

        public static bool IsExist<T>(BinNode<T> lst, BinNode<T> node)
        {
            bool found = false;
            while (!found && lst != null)
            {
                found = lst == node;
                lst = lst.GetRight();
            }
            return found;
        }

        public static bool IsExist(BinNode<int> lst, int n)
        {
            bool found = false;
            while (!found && lst != null)
            {
                found = lst.GetValue() == n;
                lst = lst.GetRight();
            }
            return found;
        }

        public static BinNode<T> GetLast<T>(BinNode<T> lst)
        {
            while (lst.GetRight() != null)
                lst = lst.GetRight();

            return lst;
        }

        public static bool IsPalindrome(BinNode<char> lst)
        {
            BinNode<char> last = GetLast(lst);

            bool pali = true;

            while (pali && lst != last)
            {
                pali = lst.GetValue() == last.GetValue();

                lst = lst.GetRight();
                last = last.GetLeft();
            }
            return pali;
        }

        public static BinNode<T> GetMiddle<T>(BinNode<T> lst)
        {
            BinNode<T> last = GetLast(lst);
            while (lst != last)
            {
                lst = lst.GetRight();
                last = last.GetLeft();
            }

            return lst;
        }

        public static BinNode<int> CreateReverseOrder()
        {
            int n = int.Parse(Console.ReadLine());
            BinNode<int> prev = null;
            BinNode<int> curr = null;

            while (n != -999)
            {
                curr = new BinNode<int>(n);
                curr.SetRight(prev);
                if (prev != null)
                    prev.SetLeft(curr);
                prev = curr;

                n = int.Parse(Console.ReadLine());
            }

            return curr;
        }

        public static BinNode<T> GetMiddleEven<T>(BinNode<T> lst)
        {
            int mid = Size(lst) / 2;
            for (int i = 0; i < mid-1; i++)
                lst = lst.GetRight();

            return lst;
        }

        public static void MergeListsInMiddle<T>(BinNode<T> lst1, BinNode<T> lst2)
        {
            BinNode<T> mid = GetMiddleEven(lst1);

            BinNode<T> save_l1_Right = mid.GetRight();
            mid.SetRight(lst2);
            lst2.SetLeft(mid);

            lst2 = GetLast(lst2);
            mid = save_l1_Right;
            lst2.SetRight(mid);
            mid.SetLeft(lst2);
        }

        public static int Size<T>(BinNode<T> chain)
        {
            int count = 0;
            while(chain != null)
            {
                chain = chain.GetRight();
                count++;
            }
                
            return count;
        }
        public static int Sum(BinNode<int> chain)
        {
            int sum = 0;
            return sum;
        }
        public static void PrintBinNode<T>(BinNode<T> lst)
        {
            while (lst != null)
            {
                Console.Write(lst.GetValue() + "-->");
                lst = lst.GetRight();
            }
        }
    }
}