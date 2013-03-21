using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    public class GraphicsSubPrograms
    {
        const int terminalWidth = 80;
        const int terminalHeight = 25;

        const char white = '\u2588';         // символ фона
        const char lightGrey = '\u2593';     // кнопка
        const char grey = '\u2592';          // граница кнопки
        const char darkGrey = '\u2591';      // курсор
        const char brokenBar = '\u00A6';
        const char upDownArrow = '\u2195';
        const char black = ' ';

        public static void Test()
        {
            ScreenBuffer screenBuffer = new ScreenBuffer(terminalWidth, terminalHeight - 2);

            int x = 40;
            int y = 12;

            Rectangle cursor = new Rectangle(new Point(x, y), new Size(1, 1));
            Rectangle button1 = new Rectangle(new Point(5, 5), new Size(15, 5));
            Rectangle button2 = new Rectangle(new Point(32, 5), new Size(15, 5));
            Rectangle button3 = new Rectangle(new Point(59, 5), new Size(15, 5));
            Rectangle[] buttonArray = { button1, button2, button3 };
            string[] backgroundColorArray = { "brokenBar", "upDownArrow", "black" };

            screenBuffer.background = white;
            while (true)
            {
                screenBuffer.Clear();

                for (int i = 0; i < buttonArray.Length; i++)
                {
                    DrawButton(buttonArray[i], screenBuffer, backgroundColorArray[i]);
                }

                DrawRectangle(cursor, screenBuffer, darkGrey);

                Console.WriteLine("{0} {1}", cursor.LeftTopPoint.X, cursor.LeftTopPoint.Y);
                screenBuffer.Flush();

                var key = Console.ReadKey(false);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.Spacebar:
                        if (HitSubPrograms.HitRectangleFunction(button1, cursor.LeftTopPoint))
                            screenBuffer.Clear(brokenBar);
                        else
                            if (HitSubPrograms.HitRectangleFunction(button2, cursor.LeftTopPoint))
                                screenBuffer.Clear(upDownArrow);
                            else
                                if (HitSubPrograms.HitRectangleFunction(button3, cursor.LeftTopPoint))
                                    screenBuffer.Clear(black);
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
                cursor.LeftTopPoint = new Point(x, y);
            }
        }

        private static void DrawButton(Rectangle placeHolder, ScreenBuffer screenBuffer, string name)
        {
            var border = placeHolder;
            var newLeftTopPoint = new Point(placeHolder.LeftTopPoint.X + 1, placeHolder.LeftTopPoint.Y + 1);
            var newSize = new Size(placeHolder.Size.GetWidth() - 2, placeHolder.Size.GetHeight() - 2);
            var innerPlace = new Rectangle(newLeftTopPoint, newSize);

            DrawRectangle(border, screenBuffer, grey);
            DrawRectangle(innerPlace, screenBuffer, lightGrey);
            WriteButtonName(name, newLeftTopPoint.X + 2, newLeftTopPoint.Y + 1, screenBuffer);
        }

        private static void WriteButtonName(string str, int xCoord, int yCoord, ScreenBuffer screenbuffer)
        {
            for (int i = 0; i < str.Length; i++)
            {
                screenbuffer.Write(xCoord + i, yCoord, str[i]);
            }
        }

        public static void DrawRectangle(Rectangle rectangle, ScreenBuffer screenBuffer, char brush)
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
    }
}
