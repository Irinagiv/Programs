using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    class GraphicsContext
    {
        public ScreenBuffer screenBuffer;

        const int terminalWidth = 80;
        const int terminalHeight = 25;

        const char white = '\u2588';         
        const char lightGrey = '\u2593';     
        const char grey = '\u2592';          
        const char darkGrey = '\u2591';      
        const char brokenBar = '\u00A6';
        const char upDownArrow = '\u2195';
        const char black = ' ';

        public void Clear(char color)
        {
            for (int i = 0; i < screenBuffer.buffer.Length; i++)
            {
                screenBuffer.buffer[i] = color;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < screenBuffer.buffer.Length; i++)
            {
                screenBuffer.buffer[i] = white;
            }
        }

        public void ToScreen()
        {
            for (int i = 0; i < screenBuffer.buffer.Length; i++)
            {
                Console.Write(screenBuffer.buffer[i]);
            }
        }

        public void DrawText(int x, int y, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                screenBuffer.Write(x + i, y, text[i]);
            }
        }

        public void DrawRectangle(Rectangle rectangle, char color)
        {
            for (int i = 0; i < terminalHeight; i++)
            {
                for (int j = 0; j < terminalWidth; j++)
                {
                    Point pt = new Point(j, i);
                    if (HitSubPrograms.HitRectangleFunction(rectangle, pt, true))
                        Console.Write(color);
                    else
                        Console.Write(' ');
                }
            }
        }

        public void DrawRectangle(Point pt, Size size, char brush)
        {
            int startIndex = screenBuffer._width * pt.Y + pt.X;
            int endIndex = screenBuffer._width * (pt.Y + size.GetHeight()) + (pt.X + size.GetWidth());
            for (int i = startIndex; i < endIndex; i++)
            {
                screenBuffer.buffer[i] = brush;
            }
        }
    }
}
