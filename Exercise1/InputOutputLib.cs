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
            //HelloWorldCentred();

            Rectangle rectangle = new Rectangle(new Point(0, 7), new Size(5, 7));
            DrawRectangle(rectangle);
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

        public static void DrawRectangle(Rectangle rectangle)
        {
            const int terminalWidth = 80;
            const int terminalHeight = 25;
            for (int i = 0; i < terminalHeight; i++)
            {
                for (int j = 0; j < terminalWidth; j++)
                {
                    Point pt = new Point(j, i);
                    if (HitSubPrograms.HitRectangleFunction(rectangle, pt, true))
                        Console.Write('\u25A0');
                    else
                        Console.Write(' ');
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
