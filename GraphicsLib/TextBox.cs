using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    public class TextBox : UIElement
    {
        public string Text { get; set; }

        public TextBox() : base() { }

        public void AddNumber(char number)
        {
            Text += number;
        }

        public void DeleteNumber()
        {
            if (!(Text == string.Empty))
                Text = Text.Substring(0, Text.Length - 1);
        }

        public override void Draw(GraphicsContext graphicsContext)
        {
            graphicsContext.DrawRectangle(Position, Size, BorderColor);
            graphicsContext.DrawRectangle(new Point(Position.X + 1, Position.Y + 1),
                                          new Size(Size.GetWidth() - 2, Size.GetHeight() - 2),
                                          InsideColor);

            Point pt = new Point(Position.X + Size.GetWidth(), Position.Y + Size.GetHeight() - 2);

            for (int i = Text.Length - 1; i >= 0; i--)
            {
                if ((pt.X - Text.Length - 1 + i) >= Position.X + 1)
                    graphicsContext.DrawNumber(pt.X - Text.Length - 1 + i, pt.Y, Text[i]);
            }
        }
    }
}
