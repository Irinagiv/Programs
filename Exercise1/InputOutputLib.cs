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
            ReadInt();
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

        public static int ReadInt()
        {
            int accumulatedNumber = 0;
            int ch = Console.Read();
            while (ch != '\n')
            {
                if (IsDigit((char)ch))
                    accumulatedNumber = (accumulatedNumber * 10 + ch) - '0';
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
