using Avalonia;
using Avalonia.Markup.Xaml;

namespace CanvasRepro
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
