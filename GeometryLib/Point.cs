using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryLib
{
    public class Point
    {
        int _x;
        int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
