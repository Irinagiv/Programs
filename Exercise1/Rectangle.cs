using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Rectangle
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
    }
}
