using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    public class Button
    {
        private string title;
        private Point leftTopPoint;
        private Size size;

        delegate void ButtonClick(GraphicsContext graphicsContext);
        private ButtonClick btnClick;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Point Position
        {
            get { return leftTopPoint; }
            set { leftTopPoint = value; }
        }

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public ButtonClick ClickHandler
        {
            get { return btnClick; }
            set { btnClick = value; }
        }

        public bool IsUnderCursor(Point pt)
        {
            return HitSubPrograms.HitRectangleFunction(new Rectangle(leftTopPoint, size), pt);
        }

        public void Draw(GraphicsContext graphicsContext)
        {
            graphicsContext.DrawRectangle(leftTopPoint, size, GraphicsContext.grey);
            graphicsContext.DrawRectangle(new Point(leftTopPoint.X + 1, leftTopPoint.Y + 1),
                                          new Size(size.GetWidth() - 2, size.GetHeight() - 2),
                                          GraphicsContext.lightGrey);
            graphicsContext.DrawText(leftTopPoint.X + 3, leftTopPoint.Y + 3, title);
        }

        //private static void DrawButton(Rectangle placeHolder, GraphicsContext graphicsContext, string name)
        //{
        //    var border = placeHolder;
        //    var newLeftTopPoint = new Point(placeHolder.LeftTopPoint.X + 1, placeHolder.LeftTopPoint.Y + 1);
        //    var newSize = new Size(placeHolder.Size.GetWidth() - 2, placeHolder.Size.GetHeight() - 2);
        //    var innerPlace = new Rectangle(newLeftTopPoint, newSize);

        //    graphicsContext.DrawRectangle(border, GraphicsContext.grey);
        //    graphicsContext.DrawRectangle(innerPlace, GraphicsContext.lightGrey);
        //    graphicsContext.DrawText(newLeftTopPoint.X + 2, newLeftTopPoint.Y + 1, name);
        //}
    }
}
