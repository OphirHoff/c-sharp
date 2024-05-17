using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Box
    {
        private double length;
        private double width;
        private double depth;

        // Constructor בנאי
        public Box(double newLength, double newWidth, double newDepth)
        {
            this.length = newLength;
            this.width = newWidth;
            this.depth = newDepth;
        }

        // print
        public void Print()
        {
            Console.WriteLine("I am a BOX. My dimensions are: " + length + width + depth);
        }

        // פעולת ToString()
        public override string ToString()
        {
            string s = "Length: " + this.length + " Width: " + this.width + " Depth: " + this.depth;
            return s;
        }

        // פעולה קובעת אורך
        public void SetLength(double l)
        {
            this.length = l;
        }

        // פעולה קובעת רוחב
        public void SetWidth(double w)
        {
            this.width = w;
        }

        // פעולה קובעת עומק
        public void SetDepth(double d)
        {
            this.depth = d;
        }

        // פעולה מאחזרת אורך
        public double GetLength()
        {
            return this.length;
        }

        // פעולה מאחזרת רוחב
        public double GetWidth()
        {
            return this.width;
        }

        // פעולה מאחזרת עומק
        public double GetDepth()
        {
            return this.depth;
        }

        // פעולה לחישוב נפח
        public double Volume()
        {
            return this.length * this.width * this.depth;
        }

        // פעולה לחישוב שטח פנים
        public double SurfaceArea()
        {
            return (2 * length * width) + (2 * length * depth) + (2 * width * depth);
        }

        // פעולה בודקת אם הקופסא זהה לאחרת
        
    }
}
