using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        private double x;
        private double y;
        
        // Constructor I
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Constructor II - משכפל
        public Point (Point other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        // פעולה מאחזרת ערך X
        public double GetX()
        {
            return this.x;
        }

        // פעולה מאחזרת ערך Y
        public double GetY()
        {
            return this.y;
        }

        // פעולה קובעת ערך X
        public void SetX(double num)
        {
            this.x = num;
        }

        // פעולה קובעת ערך Y
        public void SetY(double num)
        {
            this.y = num;
        }

        public override string ToString()
        {
            return $"({this.x},{this.y})";
        }

        // פעולה שמחזירה האם הנקודה זהה לאחרת
        public bool Equals(Point other)
        {
            return this.x == other.x && this.y == other.y;
        }

        // פעולה שמחזירה האם הנקודה נמצאת מעל לאחרת
        public bool IsAbove(Point other)
        {
            return this.y > other.y;
        }

        // פעולה שמחזירה האם הנקודה נמצאת מתחת לאחרת
        public bool IsUnder(Point other)
        {
            return !IsAbove(other); // בהנחה שאין לשתי הנק אותו ערך Y
        }

        // פעולה שמחזירה האם הנקודה נמצאת משמאל לנקודה אחרת
        public bool IsLeft(Point other)
        {
            return this.x < other.x;
        }

        // פעולה שמחזירה האם הנקודה נמצאת מימן לנק אחרת
        public bool IsRight(Point other)
        {
            return !IsLeft(other);
        }

        // פעולה שמחזירה באיזה רביע נמצאת הנקודה
        public int WhichQuadrand()
        {
            if (this.x > 0 && this.y > 0)
                return 1;
            else if (this.x < 0 && this.y > 0)
                return 2;
            else if (this.x < 0 && this.y < 0)
                return 3;
            else if (this.x > 0 && this.y < 0)
                return 4;

            return 0;
        }

        // פעולה שמחזירה מרחק בין שתי נקודות
        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(this.y - other.y, 2) + Math.Pow(this.x - other.x, 2));
        }

        // פעולה שמחזירה שיקוף של נקודה
        public Point MirrorPoint()
        {
            return new Point(this.x * -1, this.y);
        }

        // פעולה שמזיזה נקודה
        public void Move(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }
    }
}
