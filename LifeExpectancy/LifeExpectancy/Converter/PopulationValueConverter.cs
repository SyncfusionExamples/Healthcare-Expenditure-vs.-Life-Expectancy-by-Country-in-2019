using System.Globalization;

namespace LifeExpectancy
{
    public class PopulationValueConver : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((double)value > 999999999)
                {
                    return ((double)value / 1000000000).ToString("0.00 B");
                }
                if ((double)value > 999999)
                {
                    return ((double)value / 1000000).ToString("0.00 M");
                }
                else
                {
                    return value;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
