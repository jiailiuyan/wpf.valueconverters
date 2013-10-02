Community.Windows.ValueConverters
===================

This project is a collection of useful '[WPF Value Converters](http://wpftutorial.net/ValueConverters.html)'. All converters derive from [ConverterBase](https://github.com/resnyanskiy/wpf.valueconverters/blob/master/ValueConverters/ConverterBase.cs) class, which allow to use they as markup extension. Derived converters can also have multiple parameters. Take a look at [this article (ru)](http://habrahabr.ru/post/141107/) for technical details.

```xml
<Label Content="{Binding Path=Date, 
                         Converter={converters:DateTimeToString Calendar='Gregorian', Format ='Today is {0}'}}"/>
```

* NuGet package - http://www.nuget.org/packages/Community.Windows.ValueConverters/
* Documentation - http://github.com/resnyanskiy/wpf.valueconverters/wiki/

There is several open source projects, containing WPF Value Converters. So why I created another one? Table below gives the answer.
<table>
<tr>
  <th>Project</th>
  <th>Dedicated assembly</th>
  <th>StringFormat friendly</th>
  <th>NuGet package</th>
  <th>GitHub repository</th>
  </tr>
<tr>
  <td><a href="http://wpfcontrib.codeplex.com/">WPF Contrib</a></td>
  <td>no</td>
  <td>YES</td>
  <td>no</td>
  <td>no</td>
</tr>
<tr>
  <td><a href="http://alfa.codeplex.com/">Alfa - .NET code library</a></td>
  <td>YES</td>
  <td>no</td>
  <td>YES</td>
  <td>no</td>
</tr>
<tr>
  <td><a href="http://wpftoolkit.codeplex.com/">Extended WPF Toolkit</a></td>
  <td>no</td>
  <td>YES</td>
  <td>YES</td>
  <td>no</td>
</tr>
<tr>
  <td><a href="http://wpfconverters.codeplex.com/">Kent.Boogaart.Converters</a></td>
  <td>no</td>
  <td>no</td>
  <td>YES</td>
  <td>no</td>
</tr>
<tr>
  <td><a href="http://www.nuget.org/packages/XamlConverters/">XamlConverters</a></td>
  <td>n/a</td>
  <td>n/a</td>
  <td>YES</td>
  <td>n/a</td>
</tr>
<tr>
  <td><a href="http://www.nuget.org/packages/Analects.XAMLConverters/">Analects.XAMLConverters</a></td>
  <td>no</td>
  <td>YES</td>
  <td>YES</td>
  <td>YES</td>
</tr>
<tr>
  <td><a href="http://github.com/resnyanskiy/wpf.valueconverters/">Community.Windows.ValueConverters</a></td>
  <td>YES</td>
  <td>YES</td>
  <td>YES</td>
  <td>YES</td>
</tr>
</table>