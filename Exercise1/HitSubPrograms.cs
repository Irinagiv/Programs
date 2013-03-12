
namespace Exercise1
{
    class HitSubPrograms
    {
        public static bool TestHitRectangle()
        {
            // Вычисление попадания внутрь прямоугольника
            // Given:
            Point leftBottomPoint = new Point(2, 3);
            Point s = new Point(6, 4);
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
            
            bool betweenXRange = Between(rectangle.LeftTopPoint.X, shoot.X, rectangle.RightBottomPoint.X, edgeIncluding);
            bool betweenYRange = Between(rectangle.LeftTopPoint.Y, shoot.Y, rectangle.RightBottomPoint.Y, edgeIncluding);
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