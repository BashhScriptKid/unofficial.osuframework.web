# <a id="osu_Framework_Bindables_BindableNumberWithCurrent_1"></a> Class BindableNumberWithCurrent<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

A bindable which holds a reference to a bound target, allowing switching between targets and handling unbind/rebind.

```csharp
public class BindableNumberWithCurrent<T> : BindableNumber<T>, IBindable, IParseable, IBindableNumber<T>, IBindableWithCurrent<T>, IBindable<T>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IHasCurrentValue<T> where T : struct, INumber<T>, IMinMaxValue<T>
```

#### Type Parameters

`T` 

The type of our stored <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref>.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<T\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<T\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md) ← 
[BindableNumber<T\>](osu.Framework.Bindables.BindableNumber\-1.md) ← 
[BindableNumberWithCurrent<T\>](osu.Framework.Bindables.BindableNumberWithCurrent\-1.md)

#### Implements

[IBindable](osu.Framework.Bindables.IBindable.md), 
[IParseable](osu.Framework.Bindables.IParseable.md), 
[IBindableNumber<T\>](osu.Framework.Bindables.IBindableNumber\-1.md), 
[IBindableWithCurrent<T\>](osu.Framework.Bindables.IBindableWithCurrent\-1.md), 
[IBindable<T\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IHasCurrentValue<T\>](osu.Framework.Graphics.UserInterface.IHasCurrentValue\-1.md)

#### Inherited Members

[BindableNumber<T\>.PrecisionChanged](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_PrecisionChanged), 
[BindableNumber<T\>.Precision](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Precision), 
[BindableNumber<T\>.Value](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Value), 
[BindableNumber<T\>.DefaultMinValue](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultMinValue), 
[BindableNumber<T\>.DefaultMaxValue](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultMaxValue), 
[BindableNumber<T\>.DefaultPrecision](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultPrecision), 
[BindableNumber<T\>.TriggerChange\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_TriggerChange), 
[BindableNumber<T\>.TriggerPrecisionChange\(BindableNumber<T\>, bool\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_TriggerPrecisionChange\_osu\_Framework\_Bindables\_BindableNumber\_\_0\_\_System\_Boolean\_), 
[BindableNumber<T\>.CopyTo\(Bindable<T\>\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[BindableNumber<T\>.UnbindEvents\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_UnbindEvents), 
[BindableNumber<T\>.IsInteger](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsInteger), 
[BindableNumber<T\>.Set<TNewValue\>\(TNewValue\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Set\_\_1\_\_\_0\_), 
[BindableNumber<T\>.Add<TNewValue\>\(TNewValue\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Add\_\_1\_\_\_0\_), 
[BindableNumber<T\>.SetProportional\(float, float\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_SetProportional\_System\_Single\_System\_Single\_), 
[BindableNumber<T\>.GetBoundCopy\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_GetBoundCopy), 
[BindableNumber<T\>.GetUnboundCopy\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_GetUnboundCopy), 
[BindableNumber<T\>.IsDefault](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsDefault), 
[BindableNumber<T\>.CreateInstance\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_CreateInstance), 
[BindableNumber<T\>.ClampValue\(T, T, T\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[BindableNumber<T\>.IsValidRange\(T, T\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsValidRange\_\_0\_\_0\_), 
[RangeConstrainedBindable<T\>.MinValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValueChanged), 
[RangeConstrainedBindable<T\>.MaxValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValueChanged), 
[RangeConstrainedBindable<T\>.MinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValue), 
[RangeConstrainedBindable<T\>.MaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValue), 
[RangeConstrainedBindable<T\>.Value](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_Value), 
[RangeConstrainedBindable<T\>.DefaultMinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMinValue), 
[RangeConstrainedBindable<T\>.DefaultMaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMaxValue), 
[RangeConstrainedBindable<T\>.HasDefinedRange](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_HasDefinedRange), 
[RangeConstrainedBindable<T\>.NormalizedValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_NormalizedValue), 
[RangeConstrainedBindable<T\>.TriggerChange\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerChange), 
[RangeConstrainedBindable<T\>.TriggerMinValueChange\(RangeConstrainedBindable<T\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMinValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<T\>.TriggerMaxValueChange\(RangeConstrainedBindable<T\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMaxValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<T\>.CopyTo\(Bindable<T\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<T\>.BindTo\(Bindable<T\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<T\>.UnbindEvents\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_UnbindEvents), 
[RangeConstrainedBindable<T\>.GetBoundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetBoundCopy), 
[RangeConstrainedBindable<T\>.GetUnboundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetUnboundCopy), 
[RangeConstrainedBindable<T\>.ClampValue\(T, T, T\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[RangeConstrainedBindable<T\>.IsValidRange\(T, T\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_IsValidRange\_\_0\_\_0\_), 
[Bindable<T\>.ValueChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ValueChanged), 
[Bindable<T\>.DisabledChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DisabledChanged), 
[Bindable<T\>.DefaultChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DefaultChanged), 
[Bindable<T\>.Disabled](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Disabled), 
[Bindable<T\>.IsDefault](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_IsDefault), 
[Bindable<T\>.SetDefault\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_SetDefault), 
[Bindable<T\>.Value](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Value), 
[Bindable<T\>.Default](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Default), 
[Bindable<T\>.Bindings](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Bindings), 
[Bindable<T\>.BindTarget](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTarget), 
[Bindable<T\>.CopyTo\(Bindable<T\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<T\>.BindTo\(Bindable<T\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<T\>.BindValueChanged\(Action<ValueChangedEvent<T\>\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindValueChanged\_System\_Action\_osu\_Framework\_Bindables\_ValueChangedEvent\_\_0\_\_\_System\_Boolean\_), 
[Bindable<T\>.BindDisabledChanged\(Action<bool\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindDisabledChanged\_System\_Action\_System\_Boolean\_\_System\_Boolean\_), 
[Bindable<T\>.Parse\(object, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Parse\_System\_Object\_System\_IFormatProvider\_), 
[Bindable<T\>.TriggerChange\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerChange), 
[Bindable<T\>.TriggerValueChange\(T, Bindable<T\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerValueChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<T\>.TriggerDefaultChange\(T, Bindable<T\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDefaultChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<T\>.TriggerDisabledChange\(Bindable<T\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDisabledChange\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<T\>.UnbindEvents\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindEvents), 
[Bindable<T\>.UnbindBindings\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindBindings), 
[Bindable<T\>.UnbindAll\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindAll), 
[Bindable<T\>.UnbindFrom\(IUnbindable\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindFrom\_osu\_Framework\_Bindables\_IUnbindable\_), 
[Bindable<T\>.Description](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Description), 
[Bindable<T\>.ToString\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString), 
[Bindable<T\>.ToString\(string, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString\_System\_String\_System\_IFormatProvider\_), 
[Bindable<T\>.GetUnboundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetUnboundCopy), 
[Bindable<T\>.CreateInstance\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CreateInstance), 
[Bindable<T\>.GetBoundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetBoundCopy), 
[Bindable<T\>.BeginLease\(bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BeginLease\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableNumberWithCurrent<T\>\>\(BindableNumberWithCurrent<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableNumberWithCurrent<T\>\>\(BindableNumberWithCurrent<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableNumberWithCurrent<T\>\>\(BindableNumberWithCurrent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableNumberWithCurrent<T\>\>\(BindableNumberWithCurrent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableNumberWithCurrent<T\>, TChild\>\(BindableNumberWithCurrent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableNumberWithCurrent<T\>, TChild\>\(BindableNumberWithCurrent<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableNumberWithCurrent<T\>, TChild\>\(BindableNumberWithCurrent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableNumberWithCurrent<T\>\>\(BindableNumberWithCurrent<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableNumberWithCurrent_1__ctor__0_"></a> BindableNumberWithCurrent\(T\)

```csharp
public BindableNumberWithCurrent(T defaultValue = default)
```

#### Parameters

`defaultValue` T

## Properties

### <a id="osu_Framework_Bindables_BindableNumberWithCurrent_1_Current"></a> Current

Gets or sets the <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> that provides the current value.

```csharp
public Bindable<T> Current { get; set; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

#### Remarks

A provided <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> will be bound to, rather than be stored internally.

## Methods

### <a id="osu_Framework_Bindables_BindableNumberWithCurrent_1_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<T> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

