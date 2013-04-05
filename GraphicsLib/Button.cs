<<<<<<< HEAD
﻿﻿using System;
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

        public delegate void ButtonClick(GraphicsContext graphicsContext);
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
            graphicsContext.DrawText(leftTopPoint.X + 3, leftTopPoint.Y + 2, title);
        }
    }
}
=======
﻿using GeometryLib;

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
>>>>>>> origin/master
