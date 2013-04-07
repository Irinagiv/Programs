using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    public delegate double Click(double input1, double input2);

    public class UIElement
    {
        public string Title { get; set; }

        public Point Position { get; set; }

        public Size Size { get; set; }

        public char BorderColor { get; set; }

        public char InsideColor { get; set; }

        public Click ClickHandler { get; set; }

        public bool IsUnderCursor(Point pt)
        {
            return HitSubPrograms.HitRectangleFunction(new Rectangle(Position, Size), pt);
        }

        public virtual void Draw(GraphicsContext graphicsContext)
        {
            graphicsContext.DrawRectangle(Position, Size, BorderColor);
            graphicsContext.DrawRectangle(new Point(Position.X + 1, Position.Y + 1),
                                          new Size(Size.GetWidth() - 2, Size.GetHeight() - 2),
                                          InsideColor);
            graphicsContext.DrawText(Position.X + 1, Position.Y + 1, Title);
        }
    }
}
