using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFTestApps.Converters
{
    internal class AppModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is int concurrentUserCount)
            {
                return concurrentUserCount > 1 ? "Multi User Mode" : "Single User Mode";
            }

            return "Unknown Mode";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
