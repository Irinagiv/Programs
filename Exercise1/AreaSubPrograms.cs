<<<<<<< HEAD
﻿
namespace Exercise1
{
    public class AreaSubPrograms
    {
        public static double RectangleAreaProcedure()
        {
            // Given:
            double a = 5;
            double b = 4;
            // Desired:
            double area;
            // Solution
            area = a * b;
            // Result
            return area;
        }

        public static double HollowRectangleAreaProcedure()
        {
            // Нахождение площади полого прямоугольника
            // Given:
            double A = 10;
            double B = 20;
            double c = 5;
            double d = 3;
            // Desired:
            double areaDash;
            // Solution
            double s1 = RectangleAreaFunction(A, B);
            double s2 = RectangleAreaFunction(c, d);
            areaDash = s1 - s2;
            // Result
            return areaDash;
        }

        static double RectangleAreaFunction(double a, double b)
        {
            return a * b;
        }
    }
}
=======
﻿
namespace Exercise1
{
    public class AreaSubPrograms
    {
        public static double RectangleAreaProcedure()
        {
            // Given:
            double a = 5;
            double b = 4;
            // Desired:
            double area;
            // Solution
            area = a * b;
            // Result
            return area;
        }

        public static double HollowRectangleAreaProcedure()
        {
            // Нахождение площади полого прямоугольника
            // Given:
            double A = 10;
            double B = 20;
            double c = 5;
            double d = 3;
            // Desired:
            double areaDash;
            // Solution
            double s1 = RectangleAreaFunction(A, B);
            double s2 = RectangleAreaFunction(c, d);
            areaDash = s1 - s2;
            // Result
            return areaDash;
        }

        static double RectangleAreaFunction(double a, double b)
        {
            return a * b;
        }
    }
}
>>>>>>> origin/master
