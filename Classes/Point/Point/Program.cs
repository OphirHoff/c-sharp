using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // יצירת נק 1
            Point p1 = new Point(1,1);
            Console.WriteLine(p1); // print

            // יצירת נק 2
            Point p2 = new Point(4,5);
            Console.WriteLine(p2);

            // בדיקה האם הם שווים
            Console.WriteLine("Same point: " + p1.Equals(p2));

            // בדיקה האם מעל, מתחת, מימין, משמאל
            Console.WriteLine(p2.IsAbove(p1));
            Console.WriteLine(p1.IsUnder(p2));
            Console.WriteLine(p1.IsLeft(p2));
            Console.WriteLine(p1.IsRight(p2));
            Console.WriteLine(p1.WhichQuadrand());

            // הדפסת המרחק בין שתי הנקודות
            Console.WriteLine(p1.Distance(p2));

            // הדפסת נקודת שיקוף לנק 1
            Console.WriteLine(p1.MirrorPoint());

            // הזזת נק 1
            p1.Move(-1, 1);
            Console.WriteLine(p1);
        }
    }
}
