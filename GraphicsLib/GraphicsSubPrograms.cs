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

        public static void Test()
        {
            GraphicsContext graphicsContext = new GraphicsContext(terminalWidth, terminalHeight - 2);

            int x = 40;
            int y = 12;

            Rectangle cursor = new Rectangle(new Point(x, y), new Size(1, 1));
            Rectangle button1 = new Rectangle(new Point(5, 5), new Size(15, 5));
            Rectangle button2 = new Rectangle(new Point(32, 5), new Size(15, 5));
            Rectangle button3 = new Rectangle(new Point(59, 5), new Size(15, 5));
            Rectangle[] buttonArray = { button1, button2, button3 };
            string[] backgroundColorArray = { "brokenBar", "upDownArrow", "black" };

            graphicsContext.backgroundColor = GraphicsContext.white;
            while (true)
            {
                graphicsContext.Clear();
                
                for (int i = 0; i < buttonArray.Length; i++)
                {
                    DrawButton(buttonArray[i], graphicsContext, backgroundColorArray[i]);
                }

                graphicsContext.DrawRectangle(cursor, GraphicsContext.darkGrey);
                
                Console.WriteLine("{0} {1}", cursor.LeftTopPoint.X, cursor.LeftTopPoint.Y);
                graphicsContext.ToScreen();
                
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
                            graphicsContext.backgroundColor = GraphicsContext.brokenBar;
                        else
                            if (HitSubPrograms.HitRectangleFunction(button2, cursor.LeftTopPoint))
                                graphicsContext.backgroundColor = GraphicsContext.upDownArrow;
                            else
                                if (HitSubPrograms.HitRectangleFunction(button3, cursor.LeftTopPoint))
                                    graphicsContext.backgroundColor = GraphicsContext.black;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
                cursor.LeftTopPoint = new Point(x, y);
            }
        }

        private static void DrawButton(Rectangle placeHolder, GraphicsContext graphicsContext, string name)
        {
            var border = placeHolder;
            var newLeftTopPoint = new Point(placeHolder.LeftTopPoint.X + 1, placeHolder.LeftTopPoint.Y + 1);
            var newSize = new Size(placeHolder.Size.GetWidth() - 2, placeHolder.Size.GetHeight() - 2);
            var innerPlace = new Rectangle(newLeftTopPoint, newSize);

            graphicsContext.DrawRectangle(border, GraphicsContext.grey);
            graphicsContext.DrawRectangle(innerPlace, GraphicsContext.lightGrey);
            graphicsContext.DrawText(newLeftTopPoint.X + 2, newLeftTopPoint.Y + 1, name);
        }
    }
}
