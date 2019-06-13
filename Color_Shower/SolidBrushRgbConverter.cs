using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Diagnostics;

namespace Color_Shower
{
    public class SolidBrushRgbConverter : IValueConverter
    {
        public object Convert(object rgb, Type targetType, object parameter, CultureInfo culture)
        {
            if (rgb is Rgb)
            {
                Rgb rgbColor = (Rgb)rgb;
                Color color = Color.FromRgb((byte)rgbColor.Red, (byte)rgbColor.Green, (byte)rgbColor.Blue);
                return new SolidColorBrush(color);
            }
            return new SolidColorBrush(Color.FromRgb(110, 110, 110));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
