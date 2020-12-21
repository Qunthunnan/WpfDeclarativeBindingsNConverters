using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfDeclarativeBindings
{
    class SliderToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double sliderValue = (double)value;
            Color color = Colors.Black;
            if (sliderValue >= 0 && sliderValue < 25)
            {
                color = Colors.Orange;
            }
            else if (sliderValue >= 25 && sliderValue < 50)
            {
                color = Colors.OrangeRed;
            }
            else if (sliderValue >= 50 && sliderValue < 75)
            {
                color = Colors.Red;
            }
            else if (sliderValue >= 75 && sliderValue <= 100)
            {
                color = Colors.DarkRed;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
