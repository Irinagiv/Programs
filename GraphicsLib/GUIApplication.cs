using System;
using GeometryLib;
using InputOutputLib;

namespace GraphicsLib
{
    public class GuiApplication
    {
        private readonly GraphicsContext _graphicsContext;
        private readonly StatusBar _statusBar;
        private readonly Cursor _cursor;
        protected Button[] Buttons;
        protected TextBox[] TextBoxs;
        private bool _needToClose;

        public GuiApplication(int width, int height)
        {
            _cursor = new Cursor();
            _statusBar = new StatusBar(width - 1);
            const int statusBarHeight = 1;
            _graphicsContext = new GraphicsContext(width, height - statusBarHeight);
            Buttons = new Button[0];
            TextBoxs = new TextBox[0];
        }

        private void SetCursorStartPositionCentered()
        {
            var centerOfScreen = Rectangle.GetCenterPoint(new Rectangle(new Point(0, 0), _graphicsContext.CanvasSize));
            _cursor.Position = centerOfScreen;
        }

        public void Run()
        {
            InitializeComponents();
            _needToClose = false;

            while (!_needToClose)
            {
                OutputGraphics();

                var keyInfo = RecieveSignal();

                ReactToSignal(keyInfo);
            }
            ShowOnExitMessage();
        }

        private void ReactToSignal(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                    MoveCursor(keyInfo);
                    break;
                case ConsoleKey.Escape:
                    Exit();
                    break;
                default:
                    ProcessKey(keyInfo);
                    break;
            }
        }

        private static ConsoleKeyInfo RecieveSignal()
        {
            var keyInfo = Console.ReadKey(false);
            return keyInfo;
        }

        private void OutputGraphics()
        {
            _graphicsContext.Clear();

            for (int i = 0; i < Buttons.Length; i++)
            {
                Buttons[i].Draw(_graphicsContext);
            }

            for (int j = 0; j < TextBoxs.Length; j++)
            {
                TextBoxs[j].Draw(_graphicsContext);
            }

            _cursor.Draw(_graphicsContext);

            _graphicsContext.ToScreen();

            _statusBar.Output();
        }

        private void ShowOnExitMessage()
        {
            _statusBar.Output();
            Console.WriteLine();
        }

        private void MoveCursor(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    _cursor.MoveLeft();
                    _statusBar.Message = "Left";
                    break;
                case ConsoleKey.RightArrow:
                    _cursor.MoveRight();
                    _statusBar.Message = "Right";
                    break;
                case ConsoleKey.UpArrow:
                    _cursor.MoveUp();
                    _statusBar.Message = "Up";
                    break;
                case ConsoleKey.DownArrow:
                    _cursor.MoveDown();
                    _statusBar.Message = "Down";
                    break;
            }
            _statusBar.CursorPosition = _cursor.Position;
        }

        private void Exit()
        {
            _needToClose = true;
            _statusBar.Message = "Exit";
        }

        private void ProcessKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Spacebar)
            {
                _statusBar.Message = "Click";
                for (int i = 0; i < Buttons.Length; i++)
                {
                    if (Buttons[i].IsUnderCursor(_cursor.Position))
                    {
                        TextBoxs[2].Text = Buttons[i].ClickHandler(Double.Parse(TextBoxs[0].Text),
                                                                   Double.Parse(TextBoxs[1].Text))
                                           .ToString();
                    }
                }
            }
            if (InputOutputSubPrograms.IsDigit(key.KeyChar))
            {
                _statusBar.Message = "Input number";
                for (int i = 0; i < TextBoxs.Length; i++)
                {
                    if (TextBoxs[i].IsUnderCursor(_cursor.Position))
                        TextBoxs[i].AddNumber(key.KeyChar);
                }
            }
            if (key.Key == ConsoleKey.F1)
            {
                for (int i = 0; i < TextBoxs.Length; i++)
                {
                    if (TextBoxs[i].IsUnderCursor(_cursor.Position))
                        TextBoxs[i].DeleteNumber();
                }
            }
        }

        protected virtual void InitializeComponents()
        {
            _graphicsContext.BackgroundColor = GraphicsContext.white;
            _statusBar.Message = "Нажмите клавиши со стрелками, чтобы переместить курсор";
            SetCursorStartPositionCentered();

        }
    }
}
