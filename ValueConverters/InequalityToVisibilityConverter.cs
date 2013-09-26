using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Community.Windows.ValueConverters
{
  [ValueConversion(typeof(object), typeof(Visibility), ParameterType = typeof(string))]
  public class InequalityToVisibilityConverter : ConverterBase<InequalityToVisibilityConverter>
  {
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var stringToCompare = (string)parameter;
      if(value != null && !string.IsNullOrEmpty(stringToCompare))
      {
        return stringToCompare.Equals(value.ToString()) ? Visibility.Hidden : Visibility.Visible;
      }

      return false;
    }
  }
}
