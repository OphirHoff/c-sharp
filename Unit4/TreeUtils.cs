using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
//using VisualTree;

namespace Unit4
{
    // TNVH - TreeNodeValueHelper
    class TNVH<T>
    {
        public int left { get; }
        public int right { get; }
        public BinNode<T> node { get; }
        public TNVH(int left, int right, T value)
        {
            this.left = left;
            this.right = right;
            this.node = new BinNode<T>(value);
        }

        

        
    }
    class TreeUtils
    {
        public static int TreeSum(BinNode<int> t)
        {
            return 0;
        }

        public static void PrintInOrder<T>(BinNode<T> t)
        {
            if (t == null) return;

            PrintInOrder(t.GetLeft());
            Console.Write($"{t}, ");
            PrintInOrder(t.GetRight());
        }

        public static void PrintPreOrder<T>(BinNode<T> t)
        {
            if (t == null) return;

            Console.Write($"{t}, ");
            PrintPreOrder(t.GetLeft());
            PrintPreOrder(t.GetRight());
        }

        public static void PrintPostOrder<T>(BinNode<T> t)
        {
            if (t == null) return;

            PrintPostOrder(t.GetLeft());
            PrintPostOrder(t.GetRight());
            Console.Write($"{t}, ");
        }

        public static int TreeSize<T>(BinNode<T> t)
        {
            if (t == null) return 0;

            return 1 + TreeSize(t.GetLeft()) + TreeSize(t.GetRight());
        }

        public static bool IsLeaf<T>(BinNode<T> t)
        {
            return t.GetLeft() == null && t.GetRight() == null;
        }

        public static BinNode<T> CreateBinTreeFromArr<T>(TNVH<T>[] a)
        {
            int root = 1;
            // find the root
            bool[] bArr = new bool[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                bArr[a[i].left] = true;
                bArr[a[i].right] = true;
            }
            while (bArr[root])
                root++;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].left != 0)
                    a[i].node.SetLeft(a[a[i].left - 1].node);
                if (a[i].right != 0)
                    a[i].node.SetRight(a[a[i].right - 1].node);
            }
            return a[root - 1].node;
        }

        public static int CountLeaf<T>(BinNode<T> t)
        {
            if (t == null) return 0;

            if (IsLeaf(t)) return 1;

            return CountLeaf(t.GetLeft()) + CountLeaf(t.GetRight());
        }

        public static int CountGrandfather<T>(BinNode<T> tree)
        {
            if (tree == null) return 0;
            if (IsLeaf(tree)) return 0;

            int v = 0;
            if (tree.HasRight())
            {
                if (tree.GetRight().HasRight())
                    v = 1;

                else if (tree.GetRight().HasLeft())
                    v = 1;
            }

            else if (tree.HasLeft())
            {
                if (tree.GetLeft().HasRight())
                    v = 1;
                else if (tree.GetLeft().HasLeft())
                    v = 1;
            }

            return v + CountGrandfather(tree.GetLeft()) + CountGrandfather(tree.GetRight());
        }

        public static int MoreLeavesOnLeft<T>(BinNode<T> t)
        {
            // return the number of nodes in which the number of leaves on the left sub-tree is bigger then right sub-tree

            if (t == null) return 0;
            if (IsLeaf(t)) return 0;

            int v = 0;

            if (t.HasLeft())
            {
                if (CountLeaf(t.GetLeft()) > CountLeaf(t.GetRight()))
                {
                    v = 1;
                    Console.WriteLine(t);
                }
                    
            }

            return v + MoreLeavesOnLeft(t.GetLeft()) + MoreLeavesOnLeft(t.GetRight());
        }

        public static int CountNodesOnLevel<T>(BinNode<T> t, int level) { return CountNodesOnLevel(t, level, 1); } 
        public static int CountNodesOnLevel<T>(BinNode<T> t, int level, int curr)
        {
            if (t == null) return 0;
            if (curr == level) return 1;

            return CountNodesOnLevel(t.GetLeft(), level, curr + 1) + CountNodesOnLevel(t.GetRight(), level, curr + 1);
        }

        public static int CountNodesOnEvenLevel<T>(BinNode<T> t) { return CountNodesOnEvenLevel(t, 1); }
        public static int CountNodesOnEvenLevel<T>(BinNode<T> t, int curr)
        {
            if (t == null) return 0;
            int v = 0;
            if (curr % 2 == 0) v = 1;

            return v + CountNodesOnEvenLevel(t.GetLeft(), curr + 1) + CountNodesOnEvenLevel(t.GetRight(), curr + 1);
        }

        public static bool ChildEqual(BinNode<int> t)
        {
            if (t == null) return true;
            if (IsLeaf(t)) return true;

            bool sumOfChilds = true;
            if (t.HasLeft() && t.HasRight())
                sumOfChilds = t.GetLeft().GetValue() + t.GetRight().GetValue() == t.GetValue();
            else if (!t.HasRight())
                sumOfChilds = t.GetValue() == t.GetLeft().GetValue();
            else if (!t.HasLeft())
                sumOfChilds = t.GetValue() == t.GetRight().GetValue();

            return sumOfChilds && ChildEqual(t.GetLeft()) && ChildEqual(t.GetRight());
        }

        public static bool LightTree(BinNode<int> t)
        {
            if (t == null) return true;
            if (IsLeaf(t)) return true;
            if (!t.HasRight() || !t.HasLeft()) return false;

            int diff = Math.Abs(t.GetLeft().GetValue() - t.GetRight().GetValue());

            bool lessthentwo = diff < 2;
            if (!lessthentwo)
                return false;

            return LightTree(t.GetLeft()) && LightTree(t.GetRight());
        }
    }
}
