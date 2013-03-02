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
            int k = ReadInt();
            Console.Write(WriteInt(k));
            while (k != -35)
            {
                k = ReadInt();
                Console.Write(WriteInt(k));
            }
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
            int c = Console.Read();
            return c - '0';
        }

        static int WriteInt(int accumulatedNumber)
        {
            int nextDigit = ReadInt();
            if (nextDigit == -16 || nextDigit == -35)
            {
                Console.Write(' ');
                return accumulatedNumber;
            }
            int result = WriteInt(accumulatedNumber * 10 + nextDigit);
            return result;  
        }

        static bool IsDigit(char ch)
        {
            return HitSubPrograms.Between('0', ch, '9'); 
        }
    }
}
