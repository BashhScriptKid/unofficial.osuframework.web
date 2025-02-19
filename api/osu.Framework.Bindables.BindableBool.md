# <a id="osu_Framework_Bindables_BindableBool"></a> Class BindableBool

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableBool : Bindable<bool>, IBindable<bool>, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<bool\>](osu.Framework.Bindables.Bindable\-1.md) ← 
[BindableBool](osu.Framework.Bindables.BindableBool.md)

#### Implements

[IBindable<bool\>](osu.Framework.Bindables.IBindable\-1.md), 
[IBindable](osu.Framework.Bindables.IBindable.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IParseable](osu.Framework.Bindables.IParseable.md)

#### Inherited Members

[Bindable<bool\>.ValueChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ValueChanged), 
[Bindable<bool\>.DisabledChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DisabledChanged), 
[Bindable<bool\>.DefaultChanged](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_DefaultChanged), 
[Bindable<bool\>.Disabled](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Disabled), 
[Bindable<bool\>.IsDefault](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_IsDefault), 
[Bindable<bool\>.SetDefault\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_SetDefault), 
[Bindable<bool\>.Value](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Value), 
[Bindable<bool\>.Default](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Default), 
[Bindable<bool\>.Bindings](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Bindings), 
[Bindable<bool\>.BindTarget](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTarget), 
[Bindable<bool\>.CopyTo\(Bindable<bool\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CopyTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<bool\>.BindTo\(Bindable<bool\>\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindTo\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_), 
[Bindable<bool\>.BindValueChanged\(Action<ValueChangedEvent<bool\>\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindValueChanged\_System\_Action\_osu\_Framework\_Bindables\_ValueChangedEvent\_\_0\_\_\_System\_Boolean\_), 
[Bindable<bool\>.BindDisabledChanged\(Action<bool\>, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BindDisabledChanged\_System\_Action\_System\_Boolean\_\_System\_Boolean\_), 
[Bindable<bool\>.Parse\(object, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Parse\_System\_Object\_System\_IFormatProvider\_), 
[Bindable<bool\>.TriggerChange\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerChange), 
[Bindable<bool\>.TriggerValueChange\(bool, Bindable<bool\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerValueChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<bool\>.TriggerDefaultChange\(bool, Bindable<bool\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDefaultChange\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<bool\>.TriggerDisabledChange\(Bindable<bool\>, bool, bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_TriggerDisabledChange\_osu\_Framework\_Bindables\_Bindable\_\_0\_\_System\_Boolean\_System\_Boolean\_), 
[Bindable<bool\>.UnbindEvents\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindEvents), 
[Bindable<bool\>.UnbindBindings\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindBindings), 
[Bindable<bool\>.UnbindAll\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindAll), 
[Bindable<bool\>.UnbindFrom\(IUnbindable\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_UnbindFrom\_osu\_Framework\_Bindables\_IUnbindable\_), 
[Bindable<bool\>.Description](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_Description), 
[Bindable<bool\>.ToString\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString), 
[Bindable<bool\>.ToString\(string, IFormatProvider\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_ToString\_System\_String\_System\_IFormatProvider\_), 
[Bindable<bool\>.GetUnboundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetUnboundCopy), 
[Bindable<bool\>.CreateInstance\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_CreateInstance), 
[Bindable<bool\>.GetBoundCopy\(\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_GetBoundCopy), 
[Bindable<bool\>.BeginLease\(bool\)](osu.Framework.Bindables.Bindable\-1.md\#osu\_Framework\_Bindables\_Bindable\_1\_BeginLease\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BindableBool\>\(BindableBool?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableBool\>\(BindableBool\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BindableBool\>\(BindableBool\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableBool\>\(BindableBool\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableBool, TChild\>\(BindableBool, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableBool, TChild\>\(BindableBool, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableBool, TChild\>\(BindableBool, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableBool\>\(BindableBool\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableBool__ctor_System_Boolean_"></a> BindableBool\(bool\)

```csharp
public BindableBool(bool value = false)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Bindables_BindableBool_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected override Bindable<bool> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Bindables_BindableBool_Parse_System_Object_System_IFormatProvider_"></a> Parse\(object?, IFormatProvider\)

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

### <a id="osu_Framework_Bindables_BindableBool_Toggle"></a> Toggle\(\)

```csharp
public void Toggle()
```

