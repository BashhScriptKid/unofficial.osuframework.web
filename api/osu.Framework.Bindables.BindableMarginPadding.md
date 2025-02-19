# <a id="osu_Framework_Bindables_BindableMarginPadding"></a> Class BindableMarginPadding

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableMarginPadding : RangeConstrainedBindable<MarginPadding>, IBindable<MarginPadding>, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<MarginPadding\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<MarginPadding\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md) ← 
[BindableMarginPadding](osu.Framework.Bindables.BindableMarginPadding.md)

#### Implements

[IBindable<MarginPadding\>](osu.Framework.Bindables.IBindable\-1.md), 
[IBindable](osu.Framework.Bindables.IBindable.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IParseable](osu.Framework.Bindables.IParseable.md)

#### Inherited Members

[RangeConstrainedBindable<MarginPadding\>.MinValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValueChanged), 
[RangeConstrainedBindable<MarginPadding\>.MaxValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValueChanged), 
[RangeConstrainedBindable<MarginPadding\>.MinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValue), 
[RangeConstrainedBindable<MarginPadding\>.MaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValue), 
[RangeConstrainedBindable<MarginPadding\>.Value](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_Value), 
[RangeConstrainedBindable<MarginPadding\>.DefaultMinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMinValue), 
[RangeConstrainedBindable<MarginPadding\>.DefaultMaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMaxValue), 
[RangeConstrainedBindable<MarginPadding\>.HasDefinedRange](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_HasDefinedRange), 
[RangeConstrainedBindable<MarginPadding\>.NormalizedValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_NormalizedValue), 
[RangeConstrainedBindable<MarginPadding\>.TriggerChange\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerChange), 
[RangeConstrainedBindable<MarginPadding\>.TriggerMinValueChange\(RangeConstrainedBindable<MarginPadding\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMinValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<MarginPadding\>.TriggerMaxValueChange\(RangeConstrainedBindable<MarginPadding\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMaxValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<MarginPadding\>.CopyTo\(Bindable<MarginPadding\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<MarginPadding\>.BindTo\(Bindable<MarginPadding\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<MarginPadding\>.UnbindEvents\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_UnbindEvents), 
[RangeConstrainedBindable<MarginPadding\>.GetBoundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetBoundCopy), 
[RangeConstrainedBindable<MarginPadding\>.GetUnboundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetUnboundCopy), 
[RangeConstrainedBindable<MarginPadding\>.ClampValue\(MarginPadding, MarginPadding, MarginPadding\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[RangeConstrainedBindable<MarginPadding\>.IsValidRange\(MarginPadding, MarginPadding\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_IsValidRange\_\_0\_\_0\_), 
[Bindable<MarginPadding\>.ValueChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ValueChanged), 
[Bindable<MarginPadding\>.DisabledChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DisabledChanged), 
[Bindable<MarginPadding\>.DefaultChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DefaultChanged), 
[Bindable<MarginPadding\>.Disabled](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Disabled), 
[Bindable<MarginPadding\>.IsDefault](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_IsDefault), 
[Bindable<MarginPadding\>.SetDefault\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_SetDefault), 
[Bindable<MarginPadding\>.Value](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Value), 
[Bindable<MarginPadding\>.Default](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Default), 
[Bindable<MarginPadding\>.Bindings](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Bindings), 
[Bindable<MarginPadding\>.BindTarget](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTarget), 
[Bindable<MarginPadding\>.CopyTo\(Bindable<MarginPadding\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<MarginPadding\>.BindTo\(Bindable<MarginPadding\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<MarginPadding\>.BindValueChanged\(Action<ValueChangedEvent<MarginPadding\>\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindValueChanged\_System\_Action\_osu\_Framework\_Bindables\_ValueChangedEvent\_\_0\_\_\_System\_Boolean\_), 
[Bindable<MarginPadding\>.BindDisabledChanged\(Action<bool\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindDisabledChanged\_System\_Action\_System\_Boolean\_\_System\_Boolean\_), 
[Bindable<MarginPadding\>.Parse\(object, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Parse\_System\_Object\_System\_IFormatProvider\_), 
[Bindable<MarginPadding\>.TriggerChange\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerChange), 
[Bindable<MarginPadding\>.TriggerValueChange\(MarginPadding, Bindable<MarginPadding\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerValueChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<MarginPadding\>.TriggerDefaultChange\(MarginPadding, Bindable<MarginPadding\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDefaultChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<MarginPadding\>.TriggerDisabledChange\(Bindable<MarginPadding\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDisabledChange\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<MarginPadding\>.UnbindEvents\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindEvents), 
[Bindable<MarginPadding\>.UnbindBindings\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindBindings), 
[Bindable<MarginPadding\>.UnbindAll\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindAll), 
[Bindable<MarginPadding\>.UnbindFrom\(IUnbindable\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindFrom\_osu\_Framework\_Bindables\_IUnbindable\_), 
[Bindable<MarginPadding\>.Description](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Description), 
[Bindable<MarginPadding\>.ToString\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString), 
[Bindable<MarginPadding\>.ToString\(string, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString\_System\_String\_System\_IFormatProvider\_), 
[Bindable<MarginPadding\>.GetUnboundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetUnboundCopy), 
[Bindable<MarginPadding\>.CreateInstance\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CreateInstance), 
[Bindable<MarginPadding\>.GetBoundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetBoundCopy), 
[Bindable<MarginPadding\>.BeginLease\(bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BeginLease\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableMarginPadding\>\(BindableMarginPadding?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableMarginPadding\>\(BindableMarginPadding\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableMarginPadding\>\(BindableMarginPadding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableMarginPadding\>\(BindableMarginPadding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableMarginPadding, TChild\>\(BindableMarginPadding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableMarginPadding, TChild\>\(BindableMarginPadding, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableMarginPadding, TChild\>\(BindableMarginPadding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableMarginPadding\>\(BindableMarginPadding\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableMarginPadding__ctor_osu_Framework_Graphics_MarginPadding_"></a> BindableMarginPadding\(MarginPadding\)

```csharp
public BindableMarginPadding(MarginPadding defaultValue = default)
```

#### Parameters

`defaultValue` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

## Properties

### <a id="osu_Framework_Bindables_BindableMarginPadding_DefaultMaxValue"></a> DefaultMaxValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MaxValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the maximum value of type <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override MarginPadding DefaultMaxValue { get; }
```

#### Property Value

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

### <a id="osu_Framework_Bindables_BindableMarginPadding_DefaultMinValue"></a> DefaultMinValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MinValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the minimum value of type <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override MarginPadding DefaultMinValue { get; }
```

#### Property Value

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

## Methods

### <a id="osu_Framework_Bindables_BindableMarginPadding_ClampValue_osu_Framework_Graphics_MarginPadding_osu_Framework_Graphics_MarginPadding_osu_Framework_Graphics_MarginPadding_"></a> ClampValue\(MarginPadding, MarginPadding, MarginPadding\)

Clamps <code class="paramref">value</code> to the range defined by <code class="paramref">minValue</code> and <code class="paramref">maxValue</code>.

```csharp
protected override sealed MarginPadding ClampValue(MarginPadding value, MarginPadding minValue, MarginPadding maxValue)
```

#### Parameters

`value` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

`minValue` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

`maxValue` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

#### Returns

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

### <a id="osu_Framework_Bindables_BindableMarginPadding_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<MarginPadding> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[MarginPadding](osu.Framework.Graphics.MarginPadding.md)\>

### <a id="osu_Framework_Bindables_BindableMarginPadding_IsValidRange_osu_Framework_Graphics_MarginPadding_osu_Framework_Graphics_MarginPadding_"></a> IsValidRange\(MarginPadding, MarginPadding\)

Whether <code class="paramref">min</code> and <code class="paramref">max</code> constitute a valid range
(usually used to check that <code class="paramref">min</code> is indeed lesser than or equal to <code class="paramref">max</code>).

```csharp
protected override sealed bool IsValidRange(MarginPadding min, MarginPadding max)
```

#### Parameters

`min` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The range's minimum value.

`max` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The range's maximum value.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableMarginPadding_Parse_System_Object_System_IFormatProvider_"></a> Parse\(object?, IFormatProvider\)

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

