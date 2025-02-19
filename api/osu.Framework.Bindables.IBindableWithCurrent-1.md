# <a id="osu_Framework_Bindables_IBindableWithCurrent_1"></a> Interface IBindableWithCurrent<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IBindableWithCurrent<T> : IBindable<T>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IHasCurrentValue<T>
```

#### Type Parameters

`T` 

#### Implements

[IBindable<T\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IHasCurrentValue<T\>](osu.Framework.Graphics.UserInterface.IHasCurrentValue\-1.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IBindableWithCurrent<T\>\>\(IBindableWithCurrent<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBindableWithCurrent<T\>\>\(IBindableWithCurrent<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IBindableWithCurrent<T\>\>\(IBindableWithCurrent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBindableWithCurrent<T\>\>\(IBindableWithCurrent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<IBindableWithCurrent<T\>, TChild\>\(IBindableWithCurrent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBindableWithCurrent<T\>, TChild\>\(IBindableWithCurrent<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBindableWithCurrent<T\>, TChild\>\(IBindableWithCurrent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBindableWithCurrent<T\>\>\(IBindableWithCurrent<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Bindables_IBindableWithCurrent_1_Create"></a> Create\(\)

Creates a new <xref href="osu.Framework.Bindables.IBindableWithCurrent%601" data-throw-if-not-resolved="false"></xref> according to the specified value type.
If the value type is one supported by the <xref href="osu.Framework.Bindables.BindableNumber%601" data-throw-if-not-resolved="false"></xref>, an instance of <xref href="osu.Framework.Bindables.BindableNumberWithCurrent%601" data-throw-if-not-resolved="false"></xref> will be returned.
Otherwise an instance of <xref href="osu.Framework.Bindables.BindableWithCurrent%601" data-throw-if-not-resolved="false"></xref> will be returned instead.

```csharp
public static IBindableWithCurrent<T> Create()
```

#### Returns

 [IBindableWithCurrent](osu.Framework.Bindables.IBindableWithCurrent\-1.md)<T\>

