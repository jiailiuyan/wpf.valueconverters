using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace Community.Windows.ValueConverters
{
  public abstract class ConverterBase<T> : MarkupExtension, IValueConverter where T : class, new()
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
