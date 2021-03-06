﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace TestDateTimeTimePicker
{
    public class DateTimeConv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTime d = (DateTime)value;

            return new DateTimeOffset(d.Year,d.Month,d.Day,d.Hour,d.Minute,d.Second, new TimeSpan());

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return new DateTime(((DateTimeOffset)value).Ticks);

        }
    }
}
