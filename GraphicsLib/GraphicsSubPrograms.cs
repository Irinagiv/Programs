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

        //delegate void ButtonClick(GraphicsContext graphicsContext);
        
        public static void Test()
        {
            GraphicsContext graphicsContext = new GraphicsContext(terminalWidth, terminalHeight - 2);

            int x = 40;
            int y = 12;

            Rectangle cursor = new Rectangle(new Point(x, y), new Size(1, 1));
            
            Button[] buttonArray = {new Button{ Title = "brokenBar", Position = new Point(5, 5), Size = new Size(15, 5) },
                                    new Button{ Title = "upDownArrow", Position = new Point(32, 5), Size = new Size(15, 5) },
                                    new Button{ Title = "black", Position = new Point(59, 5), Size = new Size(15, 5) }};

            //Rectangle button1 = new Rectangle(new Point(5, 5), new Size(15, 5));
            //Rectangle button2 = new Rectangle(new Point(32, 5), new Size(15, 5));
            //Rectangle button3 = new Rectangle(new Point(59, 5), new Size(15, 5));
            //Rectangle[] buttonArray = { button1, button2, button3 };
            //string[] backgroundColorNameArray = { "brokenBar", "upDownArrow", "black" };

            buttonArray[0].ClickHandler = BackgroundFill1;
            buttonArray[1].ClickHandler = BackgroundFill2;
            buttonArray[2].ClickHandler = BackgroundFill3;

            //ButtonClick[] btnClick = new ButtonClick[3];
            //btnClick[0] = BackgroundFill1;
            //btnClick[1] = BackgroundFill2;
            //btnClick[2] = BackgroundFill3;

            graphicsContext.BackgroundColor = GraphicsContext.white;
            while (true)
            {
                graphicsContext.Clear();
                
                for (int i = 0; i < buttonArray.Length; i++)
                {
                    buttonArray[i].Draw(graphicsContext);
                    //DrawButton(buttonArray[i], graphicsContext, backgroundColorNameArray[i]);
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
                        for (int i = 0; i < buttonArray.Length; i++)
                        {
                            if (buttonArray[i].IsUnderCursor(cursor.LeftTopPoint))
                                buttonArray[i].ClickHandler(graphicsContext);

                            //if (HitSubPrograms.HitRectangleFunction(buttonArray[i], cursor.LeftTopPoint))
                            //    btnClick[i](graphicsContext);
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
                cursor.LeftTopPoint = new Point(x, y);
            }
        }

        private static void BackgroundFill1(GraphicsContext graphicsContext)
        {
            graphicsContext.BackgroundColor = GraphicsContext.brokenBar;
        }

        private static void BackgroundFill2(GraphicsContext graphicsContext)
        {
            graphicsContext.BackgroundColor = GraphicsContext.upDownArrow;
        }

        private static void BackgroundFill3(GraphicsContext graphicsContext)
        {
            graphicsContext.BackgroundColor = GraphicsContext.black;
        } 
    }
}
