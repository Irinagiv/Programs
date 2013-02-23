
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
            bool result = HitRectangleWithEdgeFunction(rectangle, s);
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
            bool hit = HitRectangleWithEdgeFunction(outerRectangle, point);
            bool hitHollow = HitRectangleWithoutEdgeFunction(innerRectangle, point);
            bool hitDash = hit && !hitHollow;
            // Result
            return hitDash;
        }

        public static bool HitRectangleWithEdgeFunction(Rectangle rectangle, Point shoot)
        {
            bool betweenXRange = betweenIncluding(rectangle.LeftBottomPoint.X, shoot.X, rectangle.RightTopPoint.X);
            bool betweenYRange = betweenIncluding(rectangle.LeftBottomPoint.Y, shoot.Y, rectangle.RightTopPoint.Y);
            bool hit = betweenXRange && betweenYRange;
            return hit;
        }

        private static bool betweenIncluding(double min, double value, double max)
        {
            return min <= value && value <= max;
        }

        private static bool betweenExcluding(double min, double value, double max)
        {
            return min < value && value < max;
        }

        // Попадание внутрь полости прямоугольника, не включая границы
        public static bool HitRectangleWithoutEdgeFunction(Rectangle rectangle, Point shoot)
        {
            bool betweenXRange = betweenExcluding(rectangle.LeftBottomPoint.X, shoot.X, rectangle.RightTopPoint.X);
            bool betweenYRange = betweenExcluding(rectangle.LeftBottomPoint.Y, shoot.Y, rectangle.RightTopPoint.Y);
            bool hit = betweenXRange && betweenYRange;
            return hit;
        }
    }
}
