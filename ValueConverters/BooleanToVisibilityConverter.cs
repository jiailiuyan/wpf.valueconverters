using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Community.Windows.ValueConverters
{
  /// <summary>
	/// Value converter that translates true to <see cref="Visibility.Visible"/> and false to <see cref="Visibility.Collapsed"/>
	/// </summary>
  [ValueConversion(typeof(bool), typeof(Visibility))]
  public class BooleanToVisibilityConverter : ConverterBase<BooleanToVisibilityConverter>
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
