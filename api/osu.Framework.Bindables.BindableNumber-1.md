# <a id="osu_Framework_Bindables_BindableNumber_1"></a> Class BindableNumber<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableNumber<T> : RangeConstrainedBindable<T>, IBindable, IParseable, IBindableNumber<T>, IBindable<T>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable where T : struct, INumber<T>, IMinMaxValue<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<T\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<T\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md) ← 
[BindableNumber<T\>](osu.Framework.Bindables.BindableNumber\-1.md)

#### Implements

[IBindable](osu.Framework.Bindables.IBindable.md), 
[IParseable](osu.Framework.Bindables.IParseable.md), 
[IBindableNumber<T\>](osu.Framework.Bindables.IBindableNumber\-1.md), 
[IBindable<T\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<BindableNumber<T\>\>\(BindableNumber<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableNumber<T\>\>\(BindableNumber<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableNumber<T\>\>\(BindableNumber<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableNumber<T\>\>\(BindableNumber<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableNumber<T\>, TChild\>\(BindableNumber<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableNumber<T\>, TChild\>\(BindableNumber<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableNumber<T\>, TChild\>\(BindableNumber<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableNumber<T\>\>\(BindableNumber<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableNumber_1__ctor__0_"></a> BindableNumber\(T\)

```csharp
public BindableNumber(T defaultValue = default)
```

#### Parameters

`defaultValue` T

## Properties

### <a id="osu_Framework_Bindables_BindableNumber_1_DefaultMaxValue"></a> DefaultMaxValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MaxValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the maximum value of type <code class="typeparamref">T</code>.

```csharp
protected override T DefaultMaxValue { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_BindableNumber_1_DefaultMinValue"></a> DefaultMinValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MinValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the minimum value of type <code class="typeparamref">T</code>.

```csharp
protected override T DefaultMinValue { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_BindableNumber_1_DefaultPrecision"></a> DefaultPrecision

The default <xref href="osu.Framework.Bindables.BindableNumber%601.Precision" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual T DefaultPrecision { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_BindableNumber_1_IsDefault"></a> IsDefault

Check whether the current <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> is equal to <xref href="osu.Framework.Bindables.Bindable%601.Default" data-throw-if-not-resolved="false"></xref>.

```csharp
public override bool IsDefault { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableNumber_1_IsInteger"></a> IsInteger

Whether <code class="typeparamref">T</code> is an integer.

```csharp
public bool IsInteger { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableNumber_1_Precision"></a> Precision

The precision up to which the value of this bindable should be rounded.

```csharp
public T Precision { get; set; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_BindableNumber_1_Value"></a> Value

The current value of this bindable.

```csharp
public override T Value { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Bindables_BindableNumber_1_Add__1___0_"></a> Add<TNewValue\>\(TNewValue\)

```csharp
public void Add<TNewValue>(TNewValue val) where TNewValue : struct, INumber<TNewValue>
```

#### Parameters

`val` TNewValue

#### Type Parameters

`TNewValue` 

### <a id="osu_Framework_Bindables_BindableNumber_1_ClampValue__0__0__0_"></a> ClampValue\(T, T, T\)

Clamps <code class="paramref">value</code> to the range defined by <code class="paramref">minValue</code> and <code class="paramref">maxValue</code>.

```csharp
protected override sealed T ClampValue(T value, T minValue, T maxValue)
```

#### Parameters

`value` T

`minValue` T

`maxValue` T

#### Returns

 T

### <a id="osu_Framework_Bindables_BindableNumber_1_CopyTo_osu_Framework_Bindables_Bindable__0__"></a> CopyTo\(Bindable<T\>\)

Copies all values and value limitations of this bindable to another.

```csharp
public override void CopyTo(Bindable<T> them)
```

#### Parameters

`them` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

The target to copy to.

### <a id="osu_Framework_Bindables_BindableNumber_1_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<T> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_BindableNumber_1_GetBoundCopy"></a> GetBoundCopy\(\)

```csharp
public BindableNumber<T> GetBoundCopy()
```

#### Returns

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<T\>

### <a id="osu_Framework_Bindables_BindableNumber_1_GetUnboundCopy"></a> GetUnboundCopy\(\)

```csharp
public BindableNumber<T> GetUnboundCopy()
```

#### Returns

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<T\>

### <a id="osu_Framework_Bindables_BindableNumber_1_IsValidRange__0__0_"></a> IsValidRange\(T, T\)

Whether <code class="paramref">min</code> and <code class="paramref">max</code> constitute a valid range
(usually used to check that <code class="paramref">min</code> is indeed lesser than or equal to <code class="paramref">max</code>).

```csharp
protected override sealed bool IsValidRange(T min, T max)
```

#### Parameters

`min` T

The range's minimum value.

`max` T

The range's maximum value.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableNumber_1_Set__1___0_"></a> Set<TNewValue\>\(TNewValue\)

```csharp
public void Set<TNewValue>(TNewValue val) where TNewValue : struct, INumber<TNewValue>
```

#### Parameters

`val` TNewValue

#### Type Parameters

`TNewValue` 

### <a id="osu_Framework_Bindables_BindableNumber_1_SetProportional_System_Single_System_Single_"></a> SetProportional\(float, float\)

Sets the value of the bindable to Min + (Max - Min) * amt
<param name="amt">The proportional amount to set, ranging from 0 to 1.</param><param name="snap">If greater than 0, snap the final value to the closest multiple of this number.</param>

```csharp
public void SetProportional(float amt, float snap = 0)
```

#### Parameters

`amt` [float](https://learn.microsoft.com/dotnet/api/system.single)

`snap` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Bindables_BindableNumber_1_TriggerChange"></a> TriggerChange\(\)

Raise <xref href="osu.Framework.Bindables.Bindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.Bindable%601.DisabledChanged" data-throw-if-not-resolved="false"></xref> once, without any changes actually occurring.
This does not propagate to any outward bound bindables.

```csharp
public override void TriggerChange()
```

### <a id="osu_Framework_Bindables_BindableNumber_1_TriggerPrecisionChange_osu_Framework_Bindables_BindableNumber__0__System_Boolean_"></a> TriggerPrecisionChange\(BindableNumber<T\>, bool\)

```csharp
protected void TriggerPrecisionChange(BindableNumber<T> source = null, bool propagateToBindings = true)
```

#### Parameters

`source` [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<T\>

`propagateToBindings` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableNumber_1_UnbindEvents"></a> UnbindEvents\(\)

Unbinds any actions bound to the value changed events.

```csharp
public override void UnbindEvents()
```

### <a id="osu_Framework_Bindables_BindableNumber_1_PrecisionChanged"></a> PrecisionChanged

An event which is raised when <xref href="osu.Framework.Bindables.IBindableNumber%601.Precision" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
[CanBeNull]
public event Action<T> PrecisionChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

