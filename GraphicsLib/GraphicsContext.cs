using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    public class GraphicsContext
    {
        public ScreenBuffer screenBuffer;
        public char backgroundColor;

        public char BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        public GraphicsContext(int width, int height)
        {
            screenBuffer = new ScreenBuffer(width, height);
        }

        public static readonly char white = '\u2588';
        public static readonly char lightGrey = '\u2593';
        public static readonly char grey = '\u2592';
        public static readonly char darkGrey = '\u2591';
        public static readonly char brokenBar = '\u00A6';
        public static readonly char upDownArrow = '\u2195';
        public static readonly char black = ' ';

        public void Clear()
        {
            screenBuffer.Fill(backgroundColor);
        }

        public void ToScreen()
        {
            screenBuffer.Flush();
        }

        public void DrawText(int x, int y, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                screenBuffer.Write(x + i, y, text[i]);
            }
        }

        public void DrawRectangle(Rectangle rectangle, char brush)
        {
            for (int y = 0; y < screenBuffer.Height; y++)
            {
                for (int x = 0; x < screenBuffer.Width; x++)
                {
                    Point pt = new Point(x, y);
                    if (HitSubPrograms.HitRectangleFunction(rectangle, pt))
                        screenBuffer.Write(x, y, brush);
                }
            }
        }

        public void DrawRectangle(Point pt, Size size, char brush)
        {
            Rectangle rectangle = new Rectangle(pt, size);
            DrawRectangle(rectangle, brush);
        }
    }
}
