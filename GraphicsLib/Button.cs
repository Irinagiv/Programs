using GeometryLib;

namespace GraphicsLib
{

    public delegate void ButtonClick(GraphicsContext graphicsContext);

    public class Button
    {
        public string Title { get; set; }

        public Point Position { get; set; }

        public Size Size { get; set; }

        public ButtonClick ClickHandler { get; set; }

        public bool IsUnderCursor(Point pt)
        {
            return HitSubPrograms.HitRectangleFunction(new Rectangle(Position, Size), pt);
        }

        public void Draw(GraphicsContext graphicsContext)
        {
            graphicsContext.DrawRectangle(Position, Size, GraphicsContext.grey);
            graphicsContext.DrawRectangle(new Point(Position.X + 1, Position.Y + 1),
                                          new Size(Size.GetWidth() - 2, Size.GetHeight() - 2),
                                          GraphicsContext.lightGrey);
            graphicsContext.DrawText(Position.X + 3, Position.Y + 2, Title);
        }
    }
}