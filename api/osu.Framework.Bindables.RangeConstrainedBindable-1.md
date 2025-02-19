# <a id="osu_Framework_Bindables_RangeConstrainedBindable_1"></a> Class RangeConstrainedBindable<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class RangeConstrainedBindable<T> : Bindable<T>, IBindable<T>, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<T\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<T\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md)

#### Implements

[IBindable<T\>](osu.Framework.Bindables.IBindable\-1.md), 
[IBindable](osu.Framework.Bindables.IBindable.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IParseable](osu.Framework.Bindables.IParseable.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<RangeConstrainedBindable<T\>\>\(RangeConstrainedBindable<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RangeConstrainedBindable<T\>\>\(RangeConstrainedBindable<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RangeConstrainedBindable<T\>\>\(RangeConstrainedBindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RangeConstrainedBindable<T\>\>\(RangeConstrainedBindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<RangeConstrainedBindable<T\>, TChild\>\(RangeConstrainedBindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RangeConstrainedBindable<T\>, TChild\>\(RangeConstrainedBindable<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RangeConstrainedBindable<T\>, TChild\>\(RangeConstrainedBindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RangeConstrainedBindable<T\>\>\(RangeConstrainedBindable<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1__ctor__0_"></a> RangeConstrainedBindable\(T\)

```csharp
protected RangeConstrainedBindable(T defaultValue = default)
```

#### Parameters

`defaultValue` T

## Properties

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_DefaultMaxValue"></a> DefaultMaxValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MaxValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the maximum value of type <code class="typeparamref">T</code>.

```csharp
protected abstract T DefaultMaxValue { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_DefaultMinValue"></a> DefaultMinValue

The default <xref href="osu.Framework.Bindables.RangeConstrainedBindable%601.MinValue" data-throw-if-not-resolved="false"></xref>. This should be equal to the minimum value of type <code class="typeparamref">T</code>.

```csharp
protected abstract T DefaultMinValue { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_HasDefinedRange"></a> HasDefinedRange

Whether this bindable has a user-defined range that is not the full range of the <code class="typeparamref">T</code> type.

```csharp
public bool HasDefinedRange { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_MaxValue"></a> MaxValue

```csharp
public T MaxValue { get; set; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_MinValue"></a> MinValue

```csharp
public T MinValue { get; set; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_NormalizedValue"></a> NormalizedValue

```csharp
public float NormalizedValue { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_Value"></a> Value

The current value of this bindable.

```csharp
public override T Value { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_BindTo_osu_Framework_Bindables_Bindable__0__"></a> BindTo\(Bindable<T\>\)

Binds this bindable to another such that bi-directional updates are propagated.
This will adopt any values and value limitations of the bindable bound to.

```csharp
public override void BindTo(Bindable<T> them)
```

#### Parameters

`them` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

The foreign bindable. This should always be the most permanent end of the bind (ie. a ConfigManager).

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to bind to an already bound object.

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_ClampValue__0__0__0_"></a> ClampValue\(T, T, T\)

Clamps <code class="paramref">value</code> to the range defined by <code class="paramref">minValue</code> and <code class="paramref">maxValue</code>.

```csharp
protected abstract T ClampValue(T value, T minValue, T maxValue)
```

#### Parameters

`value` T

`minValue` T

`maxValue` T

#### Returns

 T

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_CopyTo_osu_Framework_Bindables_Bindable__0__"></a> CopyTo\(Bindable<T\>\)

Copies all values and value limitations of this bindable to another.

```csharp
public override void CopyTo(Bindable<T> them)
```

#### Parameters

`them` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

The target to copy to.

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_GetBoundCopy"></a> GetBoundCopy\(\)

```csharp
public RangeConstrainedBindable<T> GetBoundCopy()
```

#### Returns

 [RangeConstrainedBindable](osu.Framework.Bindables.RangeConstrainedBindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_GetUnboundCopy"></a> GetUnboundCopy\(\)

```csharp
public RangeConstrainedBindable<T> GetUnboundCopy()
```

#### Returns

 [RangeConstrainedBindable](osu.Framework.Bindables.RangeConstrainedBindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_IsValidRange__0__0_"></a> IsValidRange\(T, T\)

Whether <code class="paramref">min</code> and <code class="paramref">max</code> constitute a valid range
(usually used to check that <code class="paramref">min</code> is indeed lesser than or equal to <code class="paramref">max</code>).

```csharp
protected abstract bool IsValidRange(T min, T max)
```

#### Parameters

`min` T

The range's minimum value.

`max` T

The range's maximum value.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_TriggerChange"></a> TriggerChange\(\)

Raise <xref href="osu.Framework.Bindables.Bindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.Bindable%601.DisabledChanged" data-throw-if-not-resolved="false"></xref> once, without any changes actually occurring.
This does not propagate to any outward bound bindables.

```csharp
public override void TriggerChange()
```

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_TriggerMaxValueChange_osu_Framework_Bindables_RangeConstrainedBindable__0__System_Boolean_"></a> TriggerMaxValueChange\(RangeConstrainedBindable<T\>, bool\)

```csharp
protected void TriggerMaxValueChange(RangeConstrainedBindable<T> source = null, bool propagateToBindings = true)
```

#### Parameters

`source` [RangeConstrainedBindable](osu.Framework.Bindables.RangeConstrainedBindable\-1.md)<T\>

`propagateToBindings` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_TriggerMinValueChange_osu_Framework_Bindables_RangeConstrainedBindable__0__System_Boolean_"></a> TriggerMinValueChange\(RangeConstrainedBindable<T\>, bool\)

```csharp
protected void TriggerMinValueChange(RangeConstrainedBindable<T> source = null, bool propagateToBindings = true)
```

#### Parameters

`source` [RangeConstrainedBindable](osu.Framework.Bindables.RangeConstrainedBindable\-1.md)<T\>

`propagateToBindings` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_UnbindEvents"></a> UnbindEvents\(\)

Unbinds any actions bound to the value changed events.

```csharp
public override void UnbindEvents()
```

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_MaxValueChanged"></a> MaxValueChanged

```csharp
public event Action<T> MaxValueChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

### <a id="osu_Framework_Bindables_RangeConstrainedBindable_1_MinValueChanged"></a> MinValueChanged

```csharp
public event Action<T> MinValueChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

