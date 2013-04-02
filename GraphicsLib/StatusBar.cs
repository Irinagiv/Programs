using System;
using GeometryLib;

namespace GraphicsLib
{
    class StatusBar
    {
        public StatusBar(int width)
        {
            Width = width;
            CursorPosition = new Point(0, 0);
        }

        public int Width { get; private set; }
        public string Message { get; set; }
        public Point CursorPosition { private get; set; }

        public void Output()
        {
            var output = string.Format("[{0}, {1}] {2}",
                                       CursorPosition.X,
                                       CursorPosition.Y,
                                       Message);
            output = output.PadRight(Width).Substring(0, Width);
            Console.Write(output);
        }
    }
}
