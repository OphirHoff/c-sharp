using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simetric_Sum_array
{
    internal class Structure
    {
        private Pixel arr;

        public bool IsBalanced()
        {
            int red = 0;
            int green = 0;
            int blue = 0;

            //for (int i = 0; i< this.arr.Length; i++)
            //{
            //    if (arr[i].IsRed())
            //        red++;
            //    else if (arr[i].IsGreen())
            //        green++;
            //    else
            //        (arr[i].IsBlue())
            //            blue++;
            //}

            return red == green && green == blue;
        }
    }
}
