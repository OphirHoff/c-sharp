using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simetric_Sum_array
{
    internal class Pixel
    {
        private int red;
        private int green;
        private int blue;

        public bool IsRed()
        {
            return this.red > 0 && this.green == 0 && this.blue == 0;
        }
    }
}
