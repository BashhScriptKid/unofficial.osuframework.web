# <a id="osu_Framework_Bindables_BindableSize"></a> Class BindableSize

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

Represents a <xref href="System.Drawing.Size" data-throw-if-not-resolved="false"></xref> bindable with defined component-wise constraints applied to it.

```csharp
public class BindableSize : RangeConstrainedBindable<Size>, IBindable<Size>, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<Size\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<Size\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md) ← 
[BindableSize](osu.Framework.Bindables.BindableSize.md)

#### Implements

[IBindable<Size\>](osu.Framework.Bindables.IBindable\-1.md), 
[IBindable](osu.Framework.Bindables.IBindable.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IParseable](osu.Framework.Bindables.IParseable.md)

#### Inherited Members

[RangeConstrainedBindable<Size\>.MinValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValueChanged), 
[RangeConstrainedBindable<Size\>.MaxValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValueChanged), 
[RangeConstrainedBindable<Size\>.MinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValue), 
[RangeConstrainedBindable<Size\>.MaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValue), 
[RangeConstrainedBindable<Size\>.Value](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_Value), 
[RangeConstrainedBindable<Size\>.DefaultMinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMinValue), 
[RangeConstrainedBindable<Size\>.DefaultMaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMaxValue), 
[RangeConstrainedBindable<Size\>.HasDefinedRange](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_HasDefinedRange), 
[RangeConstrainedBindable<Size\>.NormalizedValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_NormalizedValue), 
[RangeConstrainedBindable<Size\>.TriggerChange\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerChange), 
[RangeConstrainedBindable<Size\>.TriggerMinValueChange\(RangeConstrainedBindable<Size\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMinValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<Size\>.TriggerMaxValueChange\(RangeConstrainedBindable<Size\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMaxValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<Size\>.CopyTo\(Bindable<Size\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<Size\>.BindTo\(Bindable<Size\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<Size\>.UnbindEvents\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_UnbindEvents), 
[RangeConstrainedBindable<Size\>.GetBoundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetBoundCopy), 
[RangeConstrainedBindable<Size\>.GetUnboundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetUnboundCopy), 
[RangeConstrainedBindable<Size\>.ClampValue\(Size, Size, Size\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[RangeConstrainedBindable<Size\>.IsValidRange\(Size, Size\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_IsValidRange\_\_0\_\_0\_), 
[Bindable<Size\>.ValueChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ValueChanged), 
[Bindable<Size\>.DisabledChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DisabledChanged), 
[Bindable<Size\>.DefaultChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DefaultChanged), 
[Bindable<Size\>.Disabled](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Disabled), 
[Bindable<Size\>.IsDefault](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_IsDefault), 
[Bindable<Size\>.SetDefault\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_SetDefault), 
[Bindable<Size\>.Value](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Value), 
[Bindable<Size\>.Default](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Default), 
[Bindable<Size\>.Bindings](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Bindings), 
[Bindable<Size\>.BindTarget](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTarget), 
[Bindable<Size\>.CopyTo\(Bindable<Size\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<Size\>.BindTo\(Bindable<Size\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<Size\>.BindValueChanged\(Action<ValueChangedEvent<Size\>\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindValueChanged\_System\_Action\_osu\_Framework\_Bindables\_ValueChangedEvent\_\_0\_\_\_System\_Boolean\_), 
[Bindable<Size\>.BindDisabledChanged\(Action<bool\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindDisabledChanged\_System\_Action\_System\_Boolean\_\_System\_Boolean\_), 
[Bindable<Size\>.Parse\(object, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Parse\_System\_Object\_System\_IFormatProvider\_), 
[Bindable<Size\>.TriggerChange\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerChange), 
[Bindable<Size\>.TriggerValueChange\(Size, Bindable<Size\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerValueChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<Size\>.TriggerDefaultChange\(Size, Bindable<Size\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDefaultChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<Size\>.TriggerDisabledChange\(Bindable<Size\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDisabledChange\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<Size\>.UnbindEvents\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindEvents), 
[Bindable<Size\>.UnbindBindings\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindBindings), 
[Bindable<Size\>.UnbindAll\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindAll), 
[Bindable<Size\>.UnbindFrom\(IUnbindable\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindFrom\_osu\_Framework\_Bindables\_IUnbindable\_), 
[Bindable<Size\>.Description](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Description), 
[Bindable<Size\>.ToString\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString), 
[Bindable<Size\>.ToString\(string, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString\_System\_String\_System\_IFormatProvider\_), 
[Bindable<Size\>.GetUnboundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetUnboundCopy), 
[Bindable<Size\>.CreateInstance\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CreateInstance), 
[Bindable<Size\>.GetBoundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetBoundCopy), 
[Bindable<Size\>.BeginLease\(bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BeginLease\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableSize\>\(BindableSize?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableSize\>\(BindableSize\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableSize\>\(BindableSize\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableSize\>\(BindableSize\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableSize, TChild\>\(BindableSize, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableSize, TChild\>\(BindableSize, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableSize, TChild\>\(BindableSize, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableSize\>\(BindableSize\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableSize__ctor_System_Drawing_Size_"></a> BindableSize\(Size\)

```csharp
public BindableSize(Size defaultValue = default)
```

#### Parameters

`defaultValue` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

## Properties

### <a id="osu_Framework_Bindables_BindableSize_DefaultMaxValue"></a> DefaultMaxValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MaxValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the maximum value of type <xref href="System.Drawing.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override Size DefaultMaxValue { get; }
```

#### Property Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

### <a id="osu_Framework_Bindables_BindableSize_DefaultMinValue"></a> DefaultMinValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MinValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the minimum value of type <xref href="System.Drawing.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override Size DefaultMinValue { get; }
```

#### Property Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

## Methods

### <a id="osu_Framework_Bindables_BindableSize_ClampValue_System_Drawing_Size_System_Drawing_Size_System_Drawing_Size_"></a> ClampValue\(Size, Size, Size\)

Clamps <code class="paramref">value</code> to the range defined by <code class="paramref">minValue</code> and <code class="paramref">maxValue</code>.

```csharp
protected override sealed Size ClampValue(Size value, Size minValue, Size maxValue)
```

#### Parameters

`value` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

`minValue` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

`maxValue` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

#### Returns

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

### <a id="osu_Framework_Bindables_BindableSize_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<Size> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)\>

### <a id="osu_Framework_Bindables_BindableSize_IsValidRange_System_Drawing_Size_System_Drawing_Size_"></a> IsValidRange\(Size, Size\)

Whether <code class="paramref">min</code> and <code class="paramref">max</code> constitute a valid range
(usually used to check that <code class="paramref">min</code> is indeed lesser than or equal to <code class="paramref">max</code>).

```csharp
protected override sealed bool IsValidRange(Size min, Size max)
```

#### Parameters

`min` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

The range's minimum value.

`max` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

The range's maximum value.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableSize_Parse_System_Object_System_IFormatProvider_"></a> Parse\(object?, IFormatProvider\)

Parse an object into this instance.
An object deriving T can be parsed, or a string can be parsed if T is an enum type.

```csharp
public override void Parse(object? input, IFormatProvider provider)
```

#### Parameters

`input` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The input which is to be parsed.

`provider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)

An object that provides culture-specific formatting information about <code class="paramref">input</code>.

### <a id="osu_Framework_Bindables_BindableSize_ToString_System_String_System_IFormatProvider_"></a> ToString\(string?, IFormatProvider?\)

Formats the value of the current instance using the specified format.

```csharp
public override string ToString(string? format, IFormatProvider? formatProvider)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The format to use.  

 -or-  

 A null reference (<code>Nothing</code> in Visual Basic) to use the default format defined for the type of the <xref href="System.IFormattable" data-throw-if-not-resolved="false"></xref> implementation.

`formatProvider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)?

The provider to use to format the value.  

 -or-  

 A null reference (<code>Nothing</code> in Visual Basic) to obtain the numeric format information from the current locale setting of the operating system.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The value of the current instance in the specified format.

