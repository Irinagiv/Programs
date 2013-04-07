using GeometryLib;

namespace GraphicsLib
{
    class BackgroundButtonsApp : GuiApplication
    {
        const int TerminalWidth = 80;
        const int TerminalHeight = 25;

        public BackgroundButtonsApp()
            : base(TerminalWidth, TerminalHeight)
        {

        }

        protected override void InitializeComponents()
        {
            base.InitializeComponents();
            var buttons = new[]
            {
                new Button
                    {
                        Title = "+", 
                        Position = new Point(20, 13), 
                        Size = new Size(3, 3),
                        BorderColor = GraphicsContext.grey,
                        InsideColor = GraphicsContext.lightGrey,
                        ClickHandler = (input1, input2) => input1 + input2
                    },
                new Button
                    {
                        Title = "-",
                        Position = new Point(24, 13), 
                        Size = new Size(3, 3),
                        BorderColor = GraphicsContext.grey,
                        InsideColor = GraphicsContext.lightGrey,
                        ClickHandler = (input1, input2) => input1 - input2
                    },
                new Button
                    {
                        Title = "*", 
                        Position = new Point(28, 13), 
                        Size = new Size(3, 3),
                        BorderColor = GraphicsContext.grey,
                        InsideColor = GraphicsContext.lightGrey,
                        ClickHandler = (input1, input2) => input1 * input2
                    },
                new Button
                    {
                        Title = "/",
                        Position = new Point(32, 13), 
                        Size = new Size(3, 3),
                        BorderColor = GraphicsContext.grey,
                        InsideColor = GraphicsContext.lightGrey,
                        ClickHandler = (input1, input2) => input1 / input2
                    }
            };
            Buttons = buttons;

            var textBoxs = new[]
            {
                new TextBox
                {
                    Text = string.Empty,
                    Position = new Point(20, 1),
                    Size = new Size(15, 4),
                    BorderColor = GraphicsContext.grey,
                    InsideColor = GraphicsContext.white,
                },
                new TextBox
                {
                    Text = string.Empty,
                    Position = new Point(20, 7),
                    Size = new Size(15, 4),
                    BorderColor = GraphicsContext.grey,
                    InsideColor = GraphicsContext.white,
                },
                new TextBox
                {
                    Text = string.Empty,
                    Position = new Point(20, 17),
                    Size = new Size(15, 4),
                    BorderColor = GraphicsContext.grey,
                    InsideColor = GraphicsContext.white,
                },
            };
            TextBoxs = textBoxs;
        }
    }
}
