using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Threading;

namespace CanvasRepro
{
    public class MainWindow : Window
    {
        Canvas canvas;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            canvas = this.Find<Canvas>("Canvas");
            IBrush stroke = Brushes.Blue;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new System.TimeSpan(0, 0, 0, 0, 1);
            int xOff = 0;
            timer.Tick += (sender, args) =>
            {
                canvas.Children.Clear();
                xOff++;
                if (xOff > canvas.Width) xOff = 0;
                for(int i = 0; i < canvas.Height; i++)
                {
                    canvas.Children.Add(new Line { StartPoint = new Point(0, i), EndPoint = new Point(xOff, i), Stroke = stroke, StrokeThickness = 5});
                }
            };

            timer.Start();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
