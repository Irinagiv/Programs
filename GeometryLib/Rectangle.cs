using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryLib
{
    public class Rectangle
    {
        public Point LeftTopPoint { get; set; }
        public Size Size { get; set; }

        public Rectangle(Point leftTopPoint, Size size)
        {
            LeftTopPoint = leftTopPoint;
            Size = size;
        }

        public Point RightBottomPoint
        {
            get
            {
                Point rightBottom = new Point(LeftTopPoint.X + Size.GetWidth() - 1, 
                                              LeftTopPoint.Y + Size.GetHeight() - 1);
                return rightBottom;
            }
        }

        public double RectangleAreaFunction()
        {
            return Size.GetWidth() * Size.GetHeight();
        }

        public static Point GetCenterPoint(Rectangle rectangle)
        {
            int x = rectangle.Size.GetWidth() / 2 + rectangle.LeftTopPoint.X;
            int y = rectangle.Size.GetHeight() / 2 + rectangle.LeftTopPoint.Y;
            return  new Point(x, y);
        }
    }
}
