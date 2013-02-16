
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
