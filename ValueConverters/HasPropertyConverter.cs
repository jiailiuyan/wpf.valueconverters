using System;
using System.Windows.Data;

namespace Community.Windows.ValueConverters
{
  [ValueConversion(typeof(object), typeof(bool), ParameterType = typeof(string))]
  public class HasPropertyConverter : ConverterBase
  {
    protected override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      var propertyName = parameter as string;
      if(value != null && !string.IsNullOrEmpty(propertyName))
      {
        return value.GetType().GetProperty(propertyName) != null;
      }

      return false;
    }
  }
}
