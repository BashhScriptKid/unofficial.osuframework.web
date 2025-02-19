# <a id="osu_Framework_Bindables_BindableDouble"></a> Class BindableDouble

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableDouble : BindableNumber<double>, IBindable, IParseable, IBindableNumber<double>, IBindable<double>, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<double\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[RangeConstrainedBindable<double\>](osu.Framework.Bindables.RangeConstrainedBindable\-1.md) ← 
[BindableNumber<double\>](osu.Framework.Bindables.BindableNumber\-1.md) ← 
[BindableDouble](osu.Framework.Bindables.BindableDouble.md)

#### Implements

[IBindable](osu.Framework.Bindables.IBindable.md), 
[IParseable](osu.Framework.Bindables.IParseable.md), 
[IBindableNumber<double\>](osu.Framework.Bindables.IBindableNumber\-1.md), 
[IBindable<double\>](osu.Framework.Bindables.IBindable\-1.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Inherited Members

[BindableNumber<double\>.PrecisionChanged](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_PrecisionChanged), 
[BindableNumber<double\>.Precision](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Precision), 
[BindableNumber<double\>.Value](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Value), 
[BindableNumber<double\>.DefaultMinValue](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultMinValue), 
[BindableNumber<double\>.DefaultMaxValue](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultMaxValue), 
[BindableNumber<double\>.DefaultPrecision](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_DefaultPrecision), 
[BindableNumber<double\>.TriggerChange\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_TriggerChange), 
[BindableNumber<double\>.TriggerPrecisionChange\(BindableNumber<double\>, bool\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_TriggerPrecisionChange\_osu\_Framework\_Bindables\_BindableNumber\_\_0\_\_System\_Boolean\_), 
[BindableNumber<double\>.CopyTo\(Bindable<double\>\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[BindableNumber<double\>.UnbindEvents\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_UnbindEvents), 
[BindableNumber<double\>.IsInteger](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsInteger), 
[BindableNumber<double\>.Set<TNewValue\>\(TNewValue\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Set\_\_1\_\_\_0\_), 
[BindableNumber<double\>.Add<TNewValue\>\(TNewValue\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_Add\_\_1\_\_\_0\_), 
[BindableNumber<double\>.SetProportional\(float, float\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_SetProportional\_System\_Single\_System\_Single\_), 
[BindableNumber<double\>.GetBoundCopy\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_GetBoundCopy), 
[BindableNumber<double\>.GetUnboundCopy\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_GetUnboundCopy), 
[BindableNumber<double\>.IsDefault](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsDefault), 
[BindableNumber<double\>.CreateInstance\(\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_CreateInstance), 
[BindableNumber<double\>.ClampValue\(double, double, double\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[BindableNumber<double\>.IsValidRange\(double, double\)](osu.Framework.Bindables.BindableNumber\-1.md\#osu\_Framework\_Bindables\_BindableNumber\_1\_IsValidRange\_\_0\_\_0\_), 
[RangeConstrainedBindable<double\>.MinValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValueChanged), 
[RangeConstrainedBindable<double\>.MaxValueChanged](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValueChanged), 
[RangeConstrainedBindable<double\>.MinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MinValue), 
[RangeConstrainedBindable<double\>.MaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_MaxValue), 
[RangeConstrainedBindable<double\>.Value](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_Value), 
[RangeConstrainedBindable<double\>.DefaultMinValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMinValue), 
[RangeConstrainedBindable<double\>.DefaultMaxValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_DefaultMaxValue), 
[RangeConstrainedBindable<double\>.HasDefinedRange](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_HasDefinedRange), 
[RangeConstrainedBindable<double\>.NormalizedValue](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_NormalizedValue), 
[RangeConstrainedBindable<double\>.TriggerChange\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerChange), 
[RangeConstrainedBindable<double\>.TriggerMinValueChange\(RangeConstrainedBindable<double\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMinValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<double\>.TriggerMaxValueChange\(RangeConstrainedBindable<double\>, bool\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_TriggerMaxValueChange\_osu\_Framework\_Bindables\_RangeConstrainedBindable\_\_0\_\_System\_Boolean\_), 
[RangeConstrainedBindable<double\>.CopyTo\(Bindable<double\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<double\>.BindTo\(Bindable<double\>\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[RangeConstrainedBindable<double\>.UnbindEvents\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_UnbindEvents), 
[RangeConstrainedBindable<double\>.GetBoundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetBoundCopy), 
[RangeConstrainedBindable<double\>.GetUnboundCopy\(\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_GetUnboundCopy), 
[RangeConstrainedBindable<double\>.ClampValue\(double, double, double\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_ClampValue\_\_0\_\_0\_\_0\_), 
[RangeConstrainedBindable<double\>.IsValidRange\(double, double\)](osu.Framework.Bindables.RangeConstrainedBindable\-1.md\#osu\_Framework\_Bindables\_RangeConstrainedBindable\_1\_IsValidRange\_\_0\_\_0\_), 
[Bindable<double\>.ValueChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ValueChanged), 
[Bindable<double\>.DisabledChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DisabledChanged), 
[Bindable<double\>.DefaultChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DefaultChanged), 
[Bindable<double\>.Disabled](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Disabled), 
[Bindable<double\>.IsDefault](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_IsDefault), 
[Bindable<double\>.SetDefault\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_SetDefault), 
[Bindable<double\>.Value](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Value), 
[Bindable<double\>.Default](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Default), 
[Bindable<double\>.Bindings](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Bindings), 
[Bindable<double\>.BindTarget](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTarget), 
[Bindable<double\>.CopyTo\(Bindable<double\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<double\>.BindTo\(Bindable<double\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<double\>.BindValueChanged\(Action<ValueChangedEvent<double\>\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindValueChanged\_System\_Action\_osu\_Framework\_Bindables\_ValueChangedEvent\_\_0\_\_\_System\_Boolean\_), 
[Bindable<double\>.BindDisabledChanged\(Action<bool\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindDisabledChanged\_System\_Action\_System\_Boolean\_\_System\_Boolean\_), 
[Bindable<double\>.Parse\(object, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Parse\_System\_Object\_System\_IFormatProvider\_), 
[Bindable<double\>.TriggerChange\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerChange), 
[Bindable<double\>.TriggerValueChange\(double, Bindable<double\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerValueChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<double\>.TriggerDefaultChange\(double, Bindable<double\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDefaultChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<double\>.TriggerDisabledChange\(Bindable<double\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDisabledChange\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<double\>.UnbindEvents\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindEvents), 
[Bindable<double\>.UnbindBindings\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindBindings), 
[Bindable<double\>.UnbindAll\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindAll), 
[Bindable<double\>.UnbindFrom\(IUnbindable\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindFrom\_osu\_Framework\_Bindables\_IUnbindable\_), 
[Bindable<double\>.Description](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Description), 
[Bindable<double\>.ToString\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString), 
[Bindable<double\>.ToString\(string, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString\_System\_String\_System\_IFormatProvider\_), 
[Bindable<double\>.GetUnboundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetUnboundCopy), 
[Bindable<double\>.CreateInstance\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CreateInstance), 
[Bindable<double\>.GetBoundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetBoundCopy), 
[Bindable<double\>.BeginLease\(bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BeginLease\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableDouble\>\(BindableDouble?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableDouble\>\(BindableDouble\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableDouble\>\(BindableDouble\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableDouble\>\(BindableDouble\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableDouble, TChild\>\(BindableDouble, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableDouble, TChild\>\(BindableDouble, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableDouble, TChild\>\(BindableDouble, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableDouble\>\(BindableDouble\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableDouble__ctor_System_Double_"></a> BindableDouble\(double\)

```csharp
public BindableDouble(double defaultValue = 0)
```

#### Parameters

`defaultValue` [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Bindables_BindableDouble_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<double> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Bindables_BindableDouble_ToString_System_String_System_IFormatProvider_"></a> ToString\(string?, IFormatProvider?\)

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

