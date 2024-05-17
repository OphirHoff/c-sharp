using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class exercices
    {
        public static bool OleMamash(int[] arr)
        {
            bool ole = true;
            for(int i = 0; i < arr.Length-1; i++)
            {
                ole = arr[i] < arr[i + 1];
            }
            return ole;
        }

        public static bool YoredMamash(int[] arr)
        {
            bool yored = true;
            for (int i = 0; i < arr.Length-1; i++)
            {
                yored = arr[i] > arr[i + 1];
            }
            return yored;
        }

        public static bool Waves(int[] arr)
        {
            if (arr.Length % 3 != 0)
                return false;

            int[] first = new int[arr.Length / 3], second = new int[arr.Length / 3], third = new int[arr.Length / 3];
            int index = 0;
            for (int i = 0; i < arr.Length / 3; i++)
            {
                first[i] = arr[index];
                second[i] = arr[index + arr.Length / 3];
                third[i] = arr[index + 2 * (arr.Length / 3)];
                index++;
            }

            return OleMamash(first) && OleMamash(third) && YoredMamash(second);
            
        }

        // --
        public static void UpdateLst(Node<int> lst)
        {
            if (lst.GetNext() == null)
            {
                lst.SetNext(new Node<int>(-1 * lst.GetValue()));
                return;
            }

            if (lst.GetNext().GetValue() == 0)
            {
                lst.SetNext(lst.GetNext().GetNext());
                UpdateLst(lst);
                return;
            }

            Node<int> temp = new Node<int>(-1 * lst.GetValue());
            UpdateLst(lst.GetNext());
            temp.SetNext(lst.GetNext());
            lst.SetNext(temp);
        }
        
    }
}
