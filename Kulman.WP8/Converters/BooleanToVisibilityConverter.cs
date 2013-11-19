﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Kulman.WP8.Converters
{
    /// <summary>
    /// Converts true to Visibility.Collapsed
    /// Can be inverted
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public bool IsInverted { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isVisible = (bool)value;

            if (IsInverted)
            {
                return isVisible ? Visibility.Collapsed : Visibility.Visible;
            }
            return isVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
