# <a id="osu_Framework_Bindables_BindableFloat"></a> Class BindableFloat

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableFloat : BindableNumber<float>, IBindable, IParseable, IBindableNumber<float>, IBindable<float>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<float\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<float\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md) ← 
[BindableNumber<float\>](osu.Framework.Bindables.BindableNumber\-1.md) ← 
[BindableFloat](osu.Framework.Bindables.BindableFloat.md)

#### Implements

[IBindable](osu.Framework.Bindables.IBindable.md), 
[IParseable](osu.Framework.Bindables.IParseable.md), 
[IBindableNumber<float\>](osu.Framework.Bindables.IBindableNumber\-1.md), 
[IBindable<float\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Inherited Members

[BindableNumber<float\>.PrecisionChanged](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_PrecisionChanged), 
[BindableNumber<float\>.Precision](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Precision), 
[BindableNumber<float\>.Value](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Value), 
[BindableNumber<float\>.DefaultMinValue](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultMinValue), 
[BindableNumber<float\>.DefaultMaxValue](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultMaxValue), 
[BindableNumber<float\>.DefaultPrecision](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultPrecision), 
[BindableNumber<float\>.TriggerChange\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_TriggerChange), 
[BindableNumber<float\>.TriggerPrecisionChange\(BindableNumber<float\>, bool\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_TriggerPrecisionChange\_osu\_Framework\_Bindables\_BindableNumber\_\_0\_\_System\_Boolean\_), 
[BindableNumber<float\>.CopyTo\(Bindable<float\>\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[BindableNumber<float\>.UnbindEvents\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_UnbindEvents), 
[BindableNumber<float\>.IsInteger](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsInteger), 
[BindableNumber<float\>.Set<TNewValue\>\(TNewValue\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Set\_\_1\_\_\_0\_), 
[BindableNumber<float\>.Add<TNewValue\>\(TNewValue\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Add\_\_1\_\_\_0\_), 
[BindableNumber<float\>.SetProportional\(float, float\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_SetProportional\_System\_Single\_System\_Single\_), 
[BindableNumber<float\>.GetBoundCopy\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_GetBoundCopy), 
[BindableNumber<float\>.GetUnboundCopy\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_GetUnboundCopy), 
[BindableNumber<float\>.IsDefault](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsDefault), 
[BindableNumber<float\>.CreateInstance\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_CreateInstance), 
[BindableNumber<float\>.ClampValue\(float, float, float\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[BindableNumber<float\>.IsValidRange\(float, float\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsValidRange\_\_0\_\_0\_), 
[RangeConstrainedBindable<float\>.MinValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValueChanged), 
[RangeConstrainedBindable<float\>.MaxValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValueChanged), 
[RangeConstrainedBindable<float\>.MinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValue), 
[RangeConstrainedBindable<float\>.MaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValue), 
[RangeConstrainedBindable<float\>.Value](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_Value), 
[RangeConstrainedBindable<float\>.DefaultMinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMinValue), 
[RangeConstrainedBindable<float\>.DefaultMaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMaxValue), 
[RangeConstrainedBindable<float\>.HasDefinedRange](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_HasDefinedRange), 
[RangeConstrainedBindable<float\>.NormalizedValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_NormalizedValue), 
[RangeConstrainedBindable<float\>.TriggerChange\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerChange), 
[RangeConstrainedBindable<float\>.TriggerMinValueChange\(RangeConstrainedBindable<float\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMinValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<float\>.TriggerMaxValueChange\(RangeConstrainedBindable<float\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMaxValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<float\>.CopyTo\(Bindable<float\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<float\>.BindTo\(Bindable<float\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<float\>.UnbindEvents\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_UnbindEvents), 
[RangeConstrainedBindable<float\>.GetBoundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetBoundCopy), 
[RangeConstrainedBindable<float\>.GetUnboundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetUnboundCopy), 
[RangeConstrainedBindable<float\>.ClampValue\(float, float, float\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[RangeConstrainedBindable<float\>.IsValidRange\(float, float\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_IsValidRange\_\_0\_\_0\_), 
[Bindable<float\>.ValueChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ValueChanged), 
[Bindable<float\>.DisabledChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DisabledChanged), 
[Bindable<float\>.DefaultChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DefaultChanged), 
[Bindable<float\>.Disabled](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Disabled), 
[Bindable<float\>.IsDefault](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_IsDefault), 
[Bindable<float\>.SetDefault\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_SetDefault), 
[Bindable<float\>.Value](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Value), 
[Bindable<float\>.Default](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Default), 
[Bindable<float\>.Bindings](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Bindings), 
[Bindable<float\>.BindTarget](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTarget), 
[Bindable<float\>.CopyTo\(Bindable<float\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<float\>.BindTo\(Bindable<float\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<float\>.BindValueChanged\(Action<ValueChangedEvent<float\>\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindValueChanged\_System\_Action\_osu\_Framework\_Bindables\_ValueChangedEvent\_\_0\_\_\_System\_Boolean\_), 
[Bindable<float\>.BindDisabledChanged\(Action<bool\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindDisabledChanged\_System\_Action\_System\_Boolean\_\_System\_Boolean\_), 
[Bindable<float\>.Parse\(object, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Parse\_System\_Object\_System\_IFormatProvider\_), 
[Bindable<float\>.TriggerChange\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerChange), 
[Bindable<float\>.TriggerValueChange\(float, Bindable<float\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerValueChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<float\>.TriggerDefaultChange\(float, Bindable<float\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDefaultChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<float\>.TriggerDisabledChange\(Bindable<float\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDisabledChange\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<float\>.UnbindEvents\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindEvents), 
[Bindable<float\>.UnbindBindings\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindBindings), 
[Bindable<float\>.UnbindAll\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindAll), 
[Bindable<float\>.UnbindFrom\(IUnbindable\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindFrom\_osu\_Framework\_Bindables\_IUnbindable\_), 
[Bindable<float\>.Description](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Description), 
[Bindable<float\>.ToString\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString), 
[Bindable<float\>.ToString\(string, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString\_System\_String\_System\_IFormatProvider\_), 
[Bindable<float\>.GetUnboundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetUnboundCopy), 
[Bindable<float\>.CreateInstance\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CreateInstance), 
[Bindable<float\>.GetBoundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetBoundCopy), 
[Bindable<float\>.BeginLease\(bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BeginLease\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableFloat\>\(BindableFloat?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableFloat\>\(BindableFloat\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableFloat\>\(BindableFloat\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableFloat\>\(BindableFloat\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableFloat, TChild\>\(BindableFloat, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableFloat, TChild\>\(BindableFloat, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableFloat, TChild\>\(BindableFloat, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableFloat\>\(BindableFloat\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableFloat__ctor_System_Single_"></a> BindableFloat\(float\)

```csharp
public BindableFloat(float defaultValue = 0)
```

#### Parameters

`defaultValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Bindables_BindableFloat_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<float> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="osu_Framework_Bindables_BindableFloat_ToString_System_String_System_IFormatProvider_"></a> ToString\(string?, IFormatProvider?\)

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

