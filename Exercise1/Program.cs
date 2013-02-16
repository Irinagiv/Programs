
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
