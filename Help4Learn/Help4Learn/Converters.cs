using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Help4Learn
{
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Substring(10, 5);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class WeekNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value + " - " + calculateDay((int)value + 6);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private int calculateDay(int newValue)
        {
            int newDay = 0;

            if (newValue - 6 > 24)
            {
                newDay = newValue - 30;
            }
            else
            {
                newDay = newValue;
            }

            return newDay;
        }
    }
}
