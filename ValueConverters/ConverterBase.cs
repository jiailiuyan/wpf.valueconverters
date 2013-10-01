using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace Community.Windows.ValueConverters
{
  [MarkupExtensionReturnType(typeof(IValueConverter))]
  public abstract class ConverterBase : MarkupExtension, IValueConverter
  {
    public abstract object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture);

    public virtual object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      return this;
    }
  }
}
