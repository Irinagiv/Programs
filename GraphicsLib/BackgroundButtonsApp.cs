using GeometryLib;

namespace GraphicsLib
{
    class BackgroundButtonsApp : GuiApplication
    {
        const int TerminalWidth = 80;
        const int TerminalHeight = 25;
        
        public BackgroundButtonsApp() : base(TerminalWidth, TerminalHeight)
        {
            
        }

        protected override void InitializeComponents()
        {
            base.InitializeComponents();
            var buttons = new[]
            {
                new Button
                    {
                        Title = "brokenBar", 
                        Position = new Point(5, 5), 
                        Size = new Size(15, 5),
                        ClickHandler = context => context.BackgroundColor = GraphicsContext.brokenBar
                    },
                new Button
                    {
                        Title = "upDownArrow",
                        Position = new Point(32, 5), 
                        Size = new Size(15, 5),
                        ClickHandler = context => context.BackgroundColor = GraphicsContext.upDownArrow
                    },
                new Button
                    {
                        Title = "black", 
                        Position = new Point(59, 5), 
                        Size = new Size(15, 5),
                        ClickHandler = context => context.BackgroundColor = GraphicsContext.black
                    }
            };
            Buttons = buttons;
        }
    }
}
