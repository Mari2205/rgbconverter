using System.Windows;

namespace Color_Shower
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Color color = Color.FromRgb((byte)redSlider.Value, (byte)greenSlider.Value, (byte)blueSlider.Value);
            //whatColor.Background = new SolidColorBrush(color);
            //hexCode.Content = rgbConverter.Convert(color.R, color.G, color.B);

        }
    }
}
