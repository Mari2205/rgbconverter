using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Color_Shower
{
    class HexRgbConverter : IValueConverter
    {
        public object Convert(object rgb, Type targetType, object parameter, CultureInfo culture)
        {
            if (rgb is Rgb)
            {
                Rgb rgbColor = (Rgb)rgb;
                string hex = ((byte)rgbColor.Red).ToString("X2") + ((byte)rgbColor.Green).ToString("X2") + ((byte)rgbColor.Blue).ToString("X2");
                return "#" + hex;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
