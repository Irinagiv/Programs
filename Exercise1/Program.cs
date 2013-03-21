using System;
using GeometryLib;
using GraphicsLib;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            double s1 = AreaSubPrograms.RectangleAreaProcedure();
            double s2 = AreaSubPrograms.HollowRectangleAreaProcedure();

            bool test1Passed = HitSubPrograms.TestHitRectangle();
            bool hitDash = HitSubPrograms.TestHitHollowRectangle();

            GraphicsSubPrograms.Test();
        }
    }
}