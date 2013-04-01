using System;
using GeometryLib;

namespace GraphicsLib
{
    public class GraphicsSubPrograms
    {
        const int terminalWidth = 80;
        const int terminalHeight = 25;

        public static void Test()
        {
            const int nonBufferZoneHeight = 2;
            GraphicsContext graphicsContext = new GraphicsContext(terminalWidth, terminalHeight - nonBufferZoneHeight);

            int x = graphicsContext.CanvasSize.GetWidth() / 2;
            int y = graphicsContext.CanvasSize.GetHeight() / 2;

            Rectangle cursor = new Rectangle(new Point(x, y), new Size(1, 1));
            
            Button[] buttons = 
            {
                new Button
                    {
                        Title = "brokenBar", 
                        Position = new Point(5, 5), 
                        Size = new Size(15, 5),
                        ClickHandler = context => context.BackgroundColor = GraphicsContext.brokenBar
                    },
                new Button
                    {
                        Title = "upDownArrow",
                        Position = new Point(32, 5), 
                        Size = new Size(15, 5),
                        ClickHandler = context => context.BackgroundColor = GraphicsContext.upDownArrow
                    },
                new Button
                    {
                        Title = "black", 
                        Position = new Point(59, 5), 
                        Size = new Size(15, 5),
                        ClickHandler = context => context.BackgroundColor = GraphicsContext.black
                    }
            };
            
            graphicsContext.BackgroundColor = GraphicsContext.white;
            while (true)
            {
                graphicsContext.Clear();
                
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].Draw(graphicsContext);
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
                        for (int i = 0; i < buttons.Length; i++)
                        {
                            if (buttons[i].IsUnderCursor(cursor.LeftTopPoint))
                                buttons[i].ClickHandler(graphicsContext);
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
                cursor.LeftTopPoint = new Point(x, y);
            }
        }
    }
}
