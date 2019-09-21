using System;
using Avalonia;
using Avalonia.Logging.Serilog;

namespace CanvasRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Make this work with GTK/Skia/Cairo depending on command-line args
            // again.
            BuildAvaloniaApp().Start<MainWindow>();
        }

        /// <summary>
        /// This method is needed for IDE previewer infrastructure
        /// </summary>
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .LogToDebug()
                .UsePlatformDetect();
    }
}
