<<<<<<< HEAD
﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicsLib
 {
     public class ScreenBuffer
     {
        int _width;
        int _height;
=======
﻿using System;
using GeometryLib;

namespace GraphicsLib
{
    public class ScreenBuffer
    {
>>>>>>> origin/master
        char[] buffer;
 
        // конструктор
        public ScreenBuffer(int width, int height)
        {
<<<<<<< HEAD
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
=======
            Size = new Size(width, height);

            buffer = new char[Size.GetHeight() * Size.GetWidth()];
            Fill(' ');
        }

        // свойства
        public Size Size { get; private set; }
>>>>>>> origin/master

        // методы
        public void Write(int x, int y, char value)
        {
<<<<<<< HEAD
           buffer[_width * y + x] = value;
=======
            buffer[Size.GetWidth() * y + x] = value;
>>>>>>> origin/master
        }
 
        public char Read(int x, int y)
        {
<<<<<<< HEAD
           return buffer[_width * y + x];
=======
            return buffer[Size.GetWidth() * y + x];
        }

        public void Fill(char color)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = color;
            }
>>>>>>> origin/master
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
