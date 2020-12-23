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
            if (sliderValue<=50)
            {
                color.R = (byte)(sliderValue * 5.1);
                color.B = 255;
            }

            if (sliderValue>50)
            {
                color.B = (byte)(255-((sliderValue-50) * 5.1));
                color.R = 255;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
