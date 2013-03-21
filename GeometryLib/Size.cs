using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryLib
{
    public class Size
    {
        int _width;
        int _height;

        public Size(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int value)
        {
            if (value >= 0)
            {
                _width = value;
            }
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetHeight(int value)
        {
            if (value >= 0)
            {
                _height = value;
            }
        }
    }
}
