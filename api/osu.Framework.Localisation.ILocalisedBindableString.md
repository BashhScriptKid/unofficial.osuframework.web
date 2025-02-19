# <a id="osu_Framework_Localisation_ILocalisedBindableString"></a> Interface ILocalisedBindableString

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

An <xref href="osu.Framework.Bindables.IBindable%601" data-throw-if-not-resolved="false"></xref> which has its value set depending on the current locale of the <xref href="osu.Framework.Localisation.LocalisationManager" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface ILocalisedBindableString : IBindable<string>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable
```

#### Implements

[IBindable<string\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Extension Methods

[ObjectExtensions.AsNonNull<ILocalisedBindableString\>\(ILocalisedBindableString?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ILocalisedBindableString\>\(ILocalisedBindableString\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ILocalisedBindableString\>\(ILocalisedBindableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ILocalisedBindableString\>\(ILocalisedBindableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<ILocalisedBindableString, TChild\>\(ILocalisedBindableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ILocalisedBindableString, TChild\>\(ILocalisedBindableString, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ILocalisedBindableString, TChild\>\(ILocalisedBindableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ILocalisedBindableString\>\(ILocalisedBindableString\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Localisation_ILocalisedBindableString_Text"></a> Text

Sets the original, un-localised text.

```csharp
LocalisableString Text { set; }
```

#### Property Value

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

