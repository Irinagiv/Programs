using GeometryLib;

namespace GraphicsLib
{
    public class Cursor
    {
        private readonly Size _cursorSize;

        public char Brush { get; set; }

        public Point Position { get; set; }

        public Cursor()
        {
            Position = new Point(0, 0);
            _cursorSize = new Size(1, 1);
        }

        public void Draw(GraphicsContext graphicsContext)
        {
            graphicsContext.DrawRectangle(Position, _cursorSize, GraphicsContext.darkGrey);
        }

        public void MoveLeft()
        {
            Position.X--;
        }

        public void MoveRight()
        {
            Position.X++;
        }

        public void MoveUp()
        {
            Position.Y--;
        }

        public void MoveDown()
        {
            Position.Y++;
        }
    }
}
