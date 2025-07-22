using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFTestApps.Converters
{
    public class GradeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is int grade)
            {
                if (grade >= 90)
                {
                    return "A";
                }
                else if (grade >= 80)
                {
                    return "B";
                }
                else if (grade >= 70)
                {
                    return "C";
                }
                else if (grade >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }

            return "Invalid Grade";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
