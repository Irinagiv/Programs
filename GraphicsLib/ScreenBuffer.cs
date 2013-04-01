using System;
using GeometryLib;

namespace GraphicsLib
{
    public class ScreenBuffer
    {
        char[] buffer;

        // конструктор
        public ScreenBuffer(int width, int height)
        {
            Size = new Size(width, height);

            buffer = new char[Size.GetHeight() * Size.GetWidth()];
            Fill(' ');
        }

        // свойства
        public Size Size { get; private set; }

        // методы
        public void Write(int x, int y, char value)
        {
            buffer[Size.GetWidth() * y + x] = value;
        }

        public char Read(int x, int y)
        {
            return buffer[Size.GetWidth() * y + x];
        }

        public void Fill(char color)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = color;
            }
        }

        public void Flush()
        {
            string output = string.Empty;
            for (int i = 0; i < buffer.Length; i++)
            {
                output += buffer[i];
            }
            Console.Write(output);
        }
    }
}
