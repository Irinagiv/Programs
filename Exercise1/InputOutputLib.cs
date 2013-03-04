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
            ReadInt("a85\n", 0);
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

        public static int ReadInt(string characters, int output = 0)
        {
            while (characters[0] != '\n')
            {
                int integer = (int)characters[0];
                if (IsDigit(characters[0]) == false)
                {
                    int result = ReadInt(characters.Remove(0, 1), 0);
                    return result;
                }
                    int accumulatedNumber = integer - '0';
                    int intermediateResult = output * 10 + accumulatedNumber;
                    ReadInt(characters.Remove(0, 1), intermediateResult);         
                    return intermediateResult;
            }
            return 0;
        }

        static bool IsDigit(char ch)
        {
            bool res = HitSubPrograms.Between('0', ch, '9');
            return res; 
        }
    }
}
