<<<<<<< HEAD
﻿using System;

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

            InputOutputLib.Test();
        }
    }
}
=======
﻿
namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            double s1 = AreaSubPrograms.RectangleAreaProcedure();
            double s2 = AreaSubPrograms.HollowRectangleAreaProcedure();

            bool hit = HitSubPrograms.HitRectangle();
            bool hitDash = HitSubPrograms.HitHollowRectangle();
        }
    }
}
>>>>>>> origin/master
