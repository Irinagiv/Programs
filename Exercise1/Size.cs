using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Size
    {
        double _width;
        double _height;

        public Size(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetWidth()
        {
            return _width;
        }

        public void SetWidth(double value)
        {
            if (value >= 0)
            {
                _width = value;
            }
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetHeight(double value)
        {
            if (value >= 0)
            {
                _height = value;
            }
        }
    }
}
