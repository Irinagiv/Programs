using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryLib;

namespace GraphicsLib
{
    public class GuiApplication
    {
        private GraphicsContext _graphicsContext;
        protected Button[] Buttons;
        private int _statusBarHeight;
        private Point _cursorStartPosition;
        private Point _cursorPosition;
        private Rectangle _cursor;
        private Size _cursorSize;
        private bool _needToClose;
        private char _cursorBrush;
        private string _statusMessage;

        public GuiApplication(int width, int height)
        {
            _cursorPosition = new Point(0, 0);
            _cursorSize = new Size(1, 1);
            _statusBarHeight = 2;
            _graphicsContext = new GraphicsContext(width, height - _statusBarHeight);
            Buttons = new Button[0];
            _statusMessage = "Нажмите клавиши со стрелками, чтобы переместить курсор";

            SetCursorStartPosition();
            _cursor = new Rectangle(_cursorPosition, _cursorSize);
        }

        private void SetCursorStartPosition()
        {
            var x = _graphicsContext.CanvasSize.GetWidth()/2;
            var y = _graphicsContext.CanvasSize.GetHeight()/2;
            _cursorStartPosition = new Point(x, y);
        }

        public void Run()
        {
            InitializeComponents();
            _needToClose = false;
            while (!_needToClose)
            {
                _graphicsContext.Clear();

                for (int i = 0; i < Buttons.Length; i++)
                {
                    Buttons[i].Draw(_graphicsContext);
                }

                DrawCursor(_graphicsContext);

                DrawStatus(_statusMessage);

                _graphicsContext.ToScreen();

                var keyInfo = Console.ReadKey(false);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        _cursorPosition.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        _cursorPosition.X++;
                        break;
                    case ConsoleKey.UpArrow:
                        _cursorPosition.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        _cursorPosition.Y++;
                        break;
                    case ConsoleKey.Escape:
                        Exit();
                        break;
                    default:
                        ProcessKey(keyInfo);
                        break;
                }
            }
        }

        private void DrawStatus(string statusMessage)
        {
            Console.WriteLine("[{0}, {1}] {2}", _cursorPosition.X, _cursorPosition.Y, statusMessage);
        }

        private void Exit()
        {
            _needToClose = true;
        }

        private void ProcessKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Spacebar)
            {
                _statusMessage = "CLICK";
                for (int i = 0; i < Buttons.Length; i++)
                {
                    if (Buttons[i].IsUnderCursor(_cursorPosition))
                        Buttons[i].ClickHandler(_graphicsContext);
                }
            }
        }

        private void DrawCursor(GraphicsContext graphicsContext)
        {
            _cursor.LeftTopPoint = _cursorPosition;
            _cursor.Size = _cursorSize;
            graphicsContext.DrawRectangle(_cursor, _cursorBrush);
        }

        private void InitializeComponents()
        {
            _graphicsContext.BackgroundColor = GraphicsContext.white;
            _cursorBrush = GraphicsContext.darkGrey;
            _cursorPosition = _cursorStartPosition;

            
        }
    }
}
