using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Community.Windows.ValueConverters
{
  [MarkupExtensionReturnType(typeof(IValueConverter))]
  public abstract class ConverterBase : MarkupExtension, IValueConverter
  {
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      return this;
    }

    protected abstract object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture);

    protected virtual object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      try
      {
        return Convert(value, targetType, parameter, culture);
      }
      catch
      {
        return DependencyProperty.UnsetValue;
      }
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      try
      {
        return ConvertBack(value, targetType, parameter, culture);
      }
      catch
      {
        return DependencyProperty.UnsetValue;
      }
    }
  }
}
