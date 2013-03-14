using System;

namespace Exercise1
{
    static class InputOutputLib
    {
        const int terminalWidth = 80;
        const int terminalHeight = 25;

        const char white = '\u2588';
        const char lightGrey = '\u2593';
        const char grey = '\u2592';
        const char darkGrey = '\u2591';
        const char black = ' ';

        public static void Test()
        {

            ScreenBuffer screenBuffer = new ScreenBuffer(terminalWidth, terminalHeight - 2);
            
            int x = 40;
            int y = 12;

            Rectangle cursor = new Rectangle(new Point(x, y), new Size(1, 1));
            Rectangle button = new Rectangle(new Point(5, 5), new Size(15, 5) );

            while (true)
            {
                screenBuffer.Clear(white);
                DrawButton(button, screenBuffer);
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
                    case ConsoleKey.Escape:
                        return;
                }
                cursor.LeftTopPoint = new Point(x, y);
            }
        }

        private static void DrawButton(Rectangle placeHolder, ScreenBuffer screenBuffer)
        {
            var border = placeHolder;
            var newLeftTopPoint = new Point(placeHolder.LeftTopPoint.X + 1, placeHolder.LeftTopPoint.Y + 1);
            var newSize = new Size(placeHolder.Size.GetWidth() - 2, placeHolder.Size.GetHeight() - 2);
            var innerPlace = new Rectangle(newLeftTopPoint, newSize);
            
            DrawRectangle(border, screenBuffer, grey);
            DrawRectangle(innerPlace, screenBuffer, lightGrey);
        }

        static void HelloWorldCentred()
        {
            const int width = 80;
            const int wordLength = 5;
            int middlePageLength = width / 2 - wordLength / 2;
            AddEmptyLine(middlePageLength);
            Console.Write('H');
            Console.Write('e');
            Console.Write('l');
            Console.Write('l');
            Console.Write('o');
            Console.Write('\n');
            AddEmptyLine(middlePageLength);
            Console.Write('w');
            Console.Write('o');
            Console.Write('r');
            Console.Write('l');
            Console.Write('d');
        }

        static void AddEmptyLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(' ');
            }
        }

        static void AddNewLines(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write('\n');
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

        public static int ReadInt()
        {
            int accumulatedNumber = 0;
            int ch = Console.Read();
            while (ch != '\n')
            {
                if (IsDigit((char)ch))
                    accumulatedNumber = accumulatedNumber * 10 + ch - '0';
                ch = Console.Read();
            }

            return accumulatedNumber;
        }

        static bool IsDigit(char ch)
        {
            bool res = HitSubPrograms.Between('0', ch, '9');
            return res; 
        }
    }
}
