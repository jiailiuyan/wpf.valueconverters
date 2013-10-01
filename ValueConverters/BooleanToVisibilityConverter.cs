using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Community.Windows.ValueConverters
{
  [ValueConversion(typeof(bool), typeof(Visibility))]
  public class BooleanToVisibilityConverter : ConverterBase
  {
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return (value is bool && (bool)value) ? Visibility.Visible : Visibility.Collapsed;
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value is Visibility && (Visibility)value == Visibility.Visible;
    }
  }
}
