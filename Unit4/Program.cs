using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unit4
{
    class Program
    {
        public static void Test_Dictionary()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            // init the dictionary
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                int v = int.Parse(Console.ReadLine());
                Console.WriteLine($"d[{s}]={v}");
                d[s] = v;
            }

            // check the values in the dictionary
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine($"d[{s}]={d[s]}");
            }

            // remove from dictionary

        }

        static void Main(string[] args)
        {
            Test_exercices.Test_UpdateLst();


            int[] test_case = { };
            if (test_case.Length == 0)
            {
                Console.Write("enter test number: ");
                test_case = new int[1];
                test_case[0] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < test_case.Length; i++)
            {
                switch (test_case[i])
                {
                    case 0:
                        break;
                    case 1:
                        TestUtils.Test_CreateListFromArray();
                        break;
                    case 2:
                        TestUtils.Test_ReverseListR();
                        break;
                    case 3:
                        TestUtils.Test_CompareList();
                        break;
                    case 4:
                        TestUtils.Test_CompareListR();
                        break;
                    case 5:
                        TestUtils.Test_CountList();
                        break;
                    case 6:
                        TestUtils.Test_CountListR();
                        break;
                    case 7:
                        TestUtils.Test_SumListR();
                        break;
                    case 8:
                        TestUtils.Test_IsExistR();
                        break;
                    case 9:
                        TestUtils.Test_FindMaxR();
                        break;
                    case 10:
                        TestUtils.Test_AbsValueR();
                        break;
                    case 11:
                        TestUtils.Test_GetNodeRefR();
                        break;
                    case 12:
                        TestUtils.Test_IsSortedR();
                        break;
                    case 13:
                        TestUtils.Test_CountSeqs();
                        break;
                    case 14:
                        TestUtils.Test_PrintAtoB();
                        break;
                    case 15:
                        TestUtils.Test_BalancedList();
                        break;
                    case 16:
                        TestUtils.Test_RemoveMax();
                        break;
                    case 17:
                        TestUtils.Test_RemoveDuplicates();
                        break;
                    case 18:
                        TestUtils.Test_InsertToSortedList();
                        break;
                    case 19:
                        TestUtils.Test_Sort();
                        break;
                    case 20:
                        TestUtils.Test_NegativeSequence();
                        break;
                    case 21:
                        TestUtils.Test_MergeSortedLists2();
                        break;
                    case 22:
                        RoundNodeTestUtils.Test_PrintRoundList();
                        break;
                    case 23:
                        TestUtils.Test_AddFollowingNum();
                        break;
                    case 24:
                        TestUtils.Test_ListsIntersection();
                        break;
                    case 25:
                        RoundNodeTestUtils.Test_DisconnectRoundList();
                        break;
                    case 26:
                        RoundNodeTestUtils.Test_IsRoundList();
                        break;
                    case 27:
                        RoundNodeTestUtils.Test_ListLength();
                        break;
                    case 28:
                        RoundNodeTestUtils.Test_SumList();
                        break;
                    case 29:
                        RoundNodeTestUtils.Test_RemoveHead();
                        break;
                    case 30:
                        RoundNodeTestUtils.Test_RemoveLast();
                        break;
                    case 31:
                        RoundNodeTestUtils.Test_IsExist();
                        break;
                    case 32:
                        RoundNodeTestUtils.Test_HasLoop();
                        break;
                    case 33:
                        RoundNodeTestUtils.Test_AddToLoop();
                        break;
                    case 34:
                        RoundNodeTestUtils.Test_SumNeighbors();
                        break;
                    case 35:
                        RoundNodeTestUtils.Test_RemoveEven();
                        break;
                    case 36:
                        RoundNodeTestUtils.Test_AddToEven();
                        break;
                    case 37:
                        ForkNodeTestUtils.Test_CreateForkList();
                        break;
                    case 38:
                        ForkNodeTestUtils.Test_GetForkMeeting();
                        break;
                    case 39:
                        ForkNodeTestUtils.Test_MergeForkList();
                        break;
                    case 40:
                        RoundNodeTestUtils.Test_PrintLoopRoundList();
                        break;
                    case 41:
                        BinNodeTestUtils.Test_CreateListFromArray();
                        break;
                    case 42:
                        BinNodeTestUtils.Test_InsertNodeToSorted();
                        break;
                    case 43:
                        BinNodeTestUtils.Test_RemoveBinNode();
                        break;
                    case 44:
                        BinNodeTestUtils.Test_IsExist();
                        break;
                    case 45:
                        BinNodeTestUtils.Test_GetLast();
                        break;
                    case 46:
                        BinNodeTestUtils.Test_IsPalindrome();
                        break;
                    case 47:
                        BinNodeTestUtils.Test_GetMiddle();
                        break;
                    case 48:
                        BinNodeTestUtils.Test_CreateReverseOrder();
                        break;
                    case 49:
                        BinNodeTestUtils.Test_MergeListsInMiddle();
                        break;
                    case 50:
                        Test_Dictionary();
                        break;
                    case 51:
                        PolynomialTestUtils.Test_SortPolynomial();
                        break;
                    case 52:
                        TestUtils.Test_IsPalindrome();
                        break;
                    case 53:
                        QueueTestUtils.Test_ToString();
                        break;
                    case 54:
                        QueueTestUtils.Test_CreateQueueFromArray();
                        break;
                    case 55:
                        QueueTestUtils.Test_SpilledOn();
                        break;
                    case 56:
                        QueueTestUtils.Test_Clone();
                        break;
                    case 57:
                        QueueTestUtils.Test_GetSize();
                        break;
                    case 58:
                        QueueTestUtils.Test_GetSum();
                        break;
                    case 59:
                        QueueTestUtils.Test_IsExist();
                        break;
                    case 60:
                        QueueTestUtils.Test_LastToFirst();
                        break;
                    case 61:
                        QueueTestUtils.Test_IsSorted();
                        break;
                    case 62:
                        QueueTestUtils.Test_InsertToSorted();
                        break;
                    case 63:
                        QueueTestUtils.Test_FindMinMax();
                        break;
                    case 64:
                        QueueTestUtils.Test_RemoveMinMax();
                        break;
                    case 65:
                        QueueTestUtils.Test_SortQueue();
                        break;
                    case 66:
                        QueueTestUtils.Test_Reverse();
                        break;
                    case 67:
                        QueueTestUtils.Test_RemoveDuplicates();
                        break;
                    case 68:
                        QueueTestUtils.Test_Count();
                        break;
                    case 69:
                        QueueTestUtils.Test_RemoveSpec();
                        break;
                    case 70:
                        QueueTestUtils.Test_ToNumber();
                        break;
                    case 71:
                        QueueTestUtils.Test_BigNumber();
                        break;
                    case 72:
                        QueueTestUtils.Test_DoublesToPali();
                        break;
                    case 73:
                        QueueTestUtils.Test_IsIdentical();
                        break;
                    case 74:
                        QueueTestUtils.Test_IsSimilar();
                        break;
                    case 75:
                        TreeTestUtils.Test_CreateTreeFromArr();
                        break;
                    case 76:
                        TreeTestUtils.Test_PrintTree();
                        break;
                    case 77:
                        TreeTestUtils.Test_CountGrandfather();
                        break;
                    case 78:
                        TreeTestUtils.Test_CountLeaf();
                        break;
                    case 79:
                        TreeTestUtils.Test_MoreLeavesOnLeft();
                        break;
                    case 80:
                        TreeTestUtils.Test_CountNodesOnLevel();
                        break;
                    case 81:
                        TreeTestUtils.Test_CountNodesOnEvenLevel();
                        break;
                    case 82:
                        TreeTestUtils.Test_ChildEqual();
                        break;
                    case 83:
                        TreeTestUtils.Test_LightTree();
                        break;
                    case 84:
                        QueueTestUtils.Test_TwoSum();
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();

            
        }
    }
}
