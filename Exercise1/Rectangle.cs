using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Rectangle
    {
        public Point LeftBottomPoint { get; set; }
        public Size Size { get; set; }

        public Rectangle(Point leftBottomPoint, Size size)
        {
            LeftBottomPoint = leftBottomPoint;
            Size = size;
        }

        public Point RightTopPoint
        {
            get
            {
                Point rightTop = new Point(LeftBottomPoint.X + Size.GetWidth(), 
                                           LeftBottomPoint.Y + Size.GetHeight());
                return rightTop;
            }
        }

        public double RectangleAreaFunction()
        {
            return Size.GetWidth() * Size.GetHeight();
        }
    }
}
