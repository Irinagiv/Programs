using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    static class InputOutputLib
    {
        public static void Test()
        {
            Rectangle rect1 = new Rectangle(new Point(2, 4), new Size(1, 1));
            Rectangle rect2 = new Rectangle(new Point(0, 7), new Size(5, 7));
            Rectangle rect3 = new Rectangle(new Point(15, 17), new Size(5, 3));
            Rectangle rect4 = new Rectangle(new Point(21, 4), new Size(7, 4));
            Rectangle rect5 = new Rectangle(new Point(35, 0), new Size(2, 1));
            Rectangle[] rectangleArray = { rect1, rect2, rect3, rect4, rect5 };

            ScreenBuffer screenBuffer = new ScreenBuffer(80, 25);
            for (int i = 0; i < rectangleArray.Length; i++)
            {
                DrawRectangle(rectangleArray[i], screenBuffer);
            }
            screenBuffer.Flush();
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

        public static void DrawRectangle(Rectangle rectangle, ScreenBuffer screenBuffer)
        {
            const int terminalWidth = 80;
            const int terminalHeight = 25;
            for (int foregroundChar = 0; foregroundChar < terminalHeight; foregroundChar++)
            {
                for (int backgroundChar = 0; backgroundChar < terminalWidth; backgroundChar++)
                {
                    Point pt = new Point(backgroundChar, foregroundChar);
                    if (HitSubPrograms.HitRectangleFunction(rectangle, pt, true))
                        screenBuffer.Write(backgroundChar, foregroundChar, '\u2588');
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
