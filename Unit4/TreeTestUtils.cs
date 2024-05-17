using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class TreeTestUtils
    {
        public static BinNode<char> Tree1()
        {
            TNVH<char>[] vh = {
                new TNVH<char>(0,0,'e'),
                new TNVH<char>(1,0,'d'),
                new TNVH<char>(0,0,'f'),
                new TNVH<char>(3,2,'b'),
                new TNVH<char>(4,7,'a'),
                new TNVH<char>(0,0,'g'),
                new TNVH<char>(0,6,'c'),
                };
            return TreeUtils.CreateBinTreeFromArr(vh);// root = 5
        }

        public static BinNode<int> Tree2()
        {
            TNVH<int>[] vh = {
                new TNVH<int>(0,0,4),
                new TNVH<int>(1,0,4),
                new TNVH<int>(0,0,5),
                new TNVH<int>(3,2,9),
                new TNVH<int>(4,7,15),
                new TNVH<int>(0,0,6),
                new TNVH<int>(0,6,6),
                };
            return TreeUtils.CreateBinTreeFromArr(vh);// root = 5
        }

        public static BinNode<int> Tree3()
        {
            TNVH<int>[] vh = {
                new TNVH<int>(0,0,4),
                new TNVH<int>(1,0,2),
                new TNVH<int>(0,0,1),
                new TNVH<int>(3,2,7),
                new TNVH<int>(4,7,10),
                new TNVH<int>(0,0,1),
                new TNVH<int>(0,6,8),
                };
            return TreeUtils.CreateBinTreeFromArr(vh);// root = 5
        }

        public static void Test_CreateTreeFromArr()
        {
            BinNode<char> t = Tree1();
            Console.WriteLine(TreeUtils.CountLeaf(t));
        }

        public static void Test_PrintTree()
        {
            BinNode<char> t = Tree1();

            VisualTree.VisualBinTree<char>.DrawTree(t);
        }

        public static void Test_CountLeaf()
        {
            BinNode<char> t = Tree1();

            VisualTree.VisualBinTree<char>.DrawTree(t);

            Console.WriteLine(TreeUtils.CountLeaf(t));
        }

        public static void Test_CountGrandfather()
        {
            BinNode<char> t = Tree1();

            VisualTree.VisualBinTree<char>.DrawTree(t);

            Console.WriteLine(TreeUtils.CountGrandfather(t));
        }

        public static void Test_MoreLeavesOnLeft()
        {
            BinNode<char> t = Tree1();

            VisualTree.VisualBinTree<char>.DrawTree(t);

            Console.WriteLine(TreeUtils.MoreLeavesOnLeft(t));
        }
        
        public static void Test_CountNodesOnLevel()
        {
            BinNode<char> t = Tree1();

            VisualTree.VisualBinTree<char>.DrawTree(t);

            Console.WriteLine(TreeUtils.CountNodesOnLevel(t, 3));
        }

        public static void Test_CountNodesOnEvenLevel()
        {
            BinNode<char> t = Tree1();

            VisualTree.VisualBinTree<char>.DrawTree(t);

            Console.WriteLine(TreeUtils.CountNodesOnEvenLevel(t));
        }

        public static void Test_ChildEqual()
        {
            BinNode<int> t = Tree2();

            VisualTree.VisualBinTree<int>.DrawTree(t);

            Console.WriteLine(TreeUtils.ChildEqual(t));
        }

        public static void Test_LightTree()
        {
            BinNode<int> t = Tree3();

            VisualTree.VisualBinTree<int>.DrawTree(t);

            Console.WriteLine(TreeUtils.LightTree(t));
        }
    }
}
