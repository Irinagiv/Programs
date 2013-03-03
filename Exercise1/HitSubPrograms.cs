<<<<<<< HEAD
﻿
namespace Exercise1
{
    class HitSubPrograms
    {
        public static bool TestHitRectangle()
        {
            // Вычисление попадания внутрь прямоугольника
            // Given:
            Point leftBottomPoint = new Point(2, 3);
            Point s = new Point(5, 3);
            Size size = new Size(4, 3);
            bool expectingResults = true;

            Rectangle rectangle = new Rectangle(leftBottomPoint, size); 
            
            // Solution
            bool result = HitRectangleFunction(rectangle, s);   // по умолчанию edgeIncluding = true
            // Result
            return  expectingResults == result;
        }

        public static bool TestHitHollowRectangle()
        {
            // Вычисление попадания внутрь полого прямоугольника
            // Given:
            Rectangle outerRectangle = new Rectangle(new Point(2, 3), new Size(8, 4));
            Rectangle innerRectangle = new Rectangle(new Point(3.5, 4), new Size(5, 2));
            Point point = new Point(6.3, 4);
            
            // Solution
            bool hitOuter = HitRectangleFunction(outerRectangle, point, true);
            bool hitInner = HitRectangleFunction(innerRectangle, point, false);
            bool hitDash = hitOuter && !hitInner;
            // Result
            return hitDash;
        }

        public static bool HitRectangleFunction(Rectangle rectangle, Point shoot, bool edgeIncluding = true)
        {
            
            bool betweenXRange = Between(rectangle.LeftBottomPoint.X, shoot.X, rectangle.RightTopPoint.X, edgeIncluding);
            bool betweenYRange = Between(rectangle.LeftBottomPoint.Y, shoot.Y, rectangle.RightTopPoint.Y, edgeIncluding);
            bool hit = betweenXRange && betweenYRange;
            return hit;
        }

        public static bool Between(double min, double value, double max, bool including = true)
        {
            if(including)
                return min <= value && value <= max;
            else
                return min < value && value < max;
        }
    }
}
=======
﻿
namespace Exercise1
{
    class HitSubPrograms
    {
        public static bool HitRectangle()
        {
            // Вычисление попадания внутрь прямоугольника
            // Given:
            double Ax = 3;
            double Ay = 2;
            double Sx = 5;
            double Sy = 3;
            double Aw = 4;
            double Ah = 3;
            // Solution
            bool hit = HitRectangleFunction(Ax, Ay, Sx, Sy, Aw, Ah);
            // Result
            return hit;
        }

        public static bool HitHollowRectangle()
        {
            // Вычисление попадания внутрь полого прямоугольника
            // Given:
            double Ax = 2; double Ay = 3;
            double Aw = 8; double Ah = 4;
            double Bx = 3.5; double By = 4;
            double Bw = 5; double Bh = 2;
            double Sx = 6.3;
            double Sy = 4;
            // Solution
            bool hit = HitRectangleFunction(Ax, Ay, Sx, Sy, Aw, Ah);
            bool hitHollow = HitHollowRectangleFunction(Bx, By, Sx, Sy, Bw, Bh);
            bool hitDash = hit && !hitHollow;
            // Result
            return hitDash;
        }

        static bool HitRectangleFunction(double Rx, double Ry, double Px, double Py, double Rw, double Rh)
        {
            bool between1 = Rx <= Px && Px <= Rx + Rw;
            bool between2 = Ry <= Py && Py <= Ry + Rh;
            bool hit = between1 && between2;
            return hit;
        }

        // Попадание внутрь полости прямоугольника, не включая границы
        static bool HitHollowRectangleFunction(double Rx, double Ry, double Px, double Py, double Rw, double Rh)
        {
            bool between1 = Rx < Px && Px < Rx + Rw;
            bool between2 = Ry < Py && Py < Ry + Rh;
            bool hit = between1 && between2;
            return hit;
        }
    }
}
>>>>>>> origin/master
