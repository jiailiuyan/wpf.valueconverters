using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Community.Windows.ValueConverters
{
  [ValueConversion(typeof(object), typeof(Visibility), ParameterType = typeof(string))]
  public class EqualityToVisibilityConverter : ConverterBase
  {
    public bool Invert { get; set; }

    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var stringToCompare = (string)parameter;
      if(value != null && !string.IsNullOrEmpty(stringToCompare))
      {
        var flag = stringToCompare.Equals(value.ToString());
        return flag ^ Invert ? Visibility.Visible : Visibility.Hidden;
      }

      return false;
    }
  }
}
