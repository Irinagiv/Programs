using System;
using GeometryLib;

namespace GraphicsLib
{
    public class GraphicsSubPrograms
    {

        public static void Test_EmptyApp()
        {
            var app = new GuiApplication(80, 25);
            app.Run();
        }

        public static void Test_AppWithButtons()
        {
            var app = new BackgroundButtonsApp();
            app.Run();
        }
    }
}
