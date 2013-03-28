﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicsLib
{
    public class ScreenBuffer
    {
        int _width;
        int _height;
        char[] buffer;

        // конструктор
        public ScreenBuffer(int width, int height)
        {
            _width = width;
            _height = height;
            buffer = new char[_height * _width];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = ' ';
            }
        }

        // свойства
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        // методы
        public void Write(int x, int y, char value)
        {
            buffer[_width * y + x] = value;
        }

        public char Read(int x, int y)
        {
            return buffer[_width * y + x];
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