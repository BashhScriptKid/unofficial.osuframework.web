# <a id="osu_Framework_Bindables_IBindableNumber_1"></a> Interface IBindableNumber<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IBindableNumber<T> : IBindable<T>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable where T : struct, IComparable<T>, IEquatable<T>
```

#### Type Parameters

`T` 

#### Implements

[IBindable<T\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IBindableNumber<T\>\>\(IBindableNumber<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBindableNumber<T\>\>\(IBindableNumber<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IBindableNumber<T\>\>\(IBindableNumber<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBindableNumber<T\>\>\(IBindableNumber<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<IBindableNumber<T\>, TChild\>\(IBindableNumber<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBindableNumber<T\>, TChild\>\(IBindableNumber<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBindableNumber<T\>, TChild\>\(IBindableNumber<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBindableNumber<T\>\>\(IBindableNumber<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Bindables_IBindableNumber_1_IsInteger"></a> IsInteger

Whether <code class="typeparamref">T</code> is an integer.

```csharp
bool IsInteger { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_IBindableNumber_1_MaxValue"></a> MaxValue

The maximum value of this bindable. <xref href="osu.Framework.Bindables.IBindable%601.Value?text=Value" data-throw-if-not-resolved="false"></xref> will never go above this value.

```csharp
T MaxValue { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_IBindableNumber_1_MinValue"></a> MinValue

The minimum value of this bindable. <xref href="osu.Framework.Bindables.IBindable%601.Value?text=Value" data-throw-if-not-resolved="false"></xref> will never go below this value.

```csharp
T MinValue { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_IBindableNumber_1_Precision"></a> Precision

The precision up to which the value of this bindable should be rounded.

```csharp
T Precision { get; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Bindables_IBindableNumber_1_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
IBindableNumber<T> GetBoundCopy()
```

#### Returns

 [IBindableNumber](osu.Framework.Bindables.IBindableNumber\-1.md)<T\>

A weakly bound copy of the specified bindable.

### <a id="osu_Framework_Bindables_IBindableNumber_1_MaxValueChanged"></a> MaxValueChanged

An event which is raised when <xref href="osu.Framework.Bindables.IBindableNumber%601.MaxValue" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
event Action<T> MaxValueChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

### <a id="osu_Framework_Bindables_IBindableNumber_1_MinValueChanged"></a> MinValueChanged

An event which is raised when <xref href="osu.Framework.Bindables.IBindableNumber%601.MinValue" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
event Action<T> MinValueChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

### <a id="osu_Framework_Bindables_IBindableNumber_1_PrecisionChanged"></a> PrecisionChanged

An event which is raised when <xref href="osu.Framework.Bindables.IBindableNumber%601.Precision" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
event Action<T> PrecisionChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

