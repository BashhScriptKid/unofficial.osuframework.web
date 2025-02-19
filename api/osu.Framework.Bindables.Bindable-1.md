# <a id="osu_Framework_Bindables_Bindable_1"></a> Class Bindable<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

A generic implementation of a <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>

```csharp
public class Bindable<T> : IBindable<T>, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable
```

#### Type Parameters

`T` 

The type of our stored <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref>.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Bindable<T\>](osu.Framework.Bindables.Bindable\-1.md)

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

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Bindable<T\>\>\(Bindable<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Bindable<T\>\>\(Bindable<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Bindable<T\>\>\(Bindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Bindable<T\>\>\(Bindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<Bindable<T\>, TChild\>\(Bindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Bindable<T\>, TChild\>\(Bindable<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Bindable<T\>, TChild\>\(Bindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Bindable<T\>\>\(Bindable<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_Bindable_1__ctor__0_"></a> Bindable\(T\)

Creates a new bindable instance initialised with a default value.

```csharp
public Bindable(T defaultValue = default)
```

#### Parameters

`defaultValue` T

The initial and default value for this bindable.

## Properties

### <a id="osu_Framework_Bindables_Bindable_1_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.Bindable%601.BindTo(osu.Framework.Bindables.Bindable%7b%600%7d)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
public IBindable<T> BindTarget { set; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_Bindable_1_Bindings"></a> Bindings

```csharp
protected LockedWeakList<Bindable<T>> Bindings { get; }
```

#### Property Value

 [LockedWeakList](osu.Framework.Lists.LockedWeakList\-1.md)<[Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>\>

### <a id="osu_Framework_Bindables_Bindable_1_Default"></a> Default

The default value of this bindable. Used when calling <xref href="osu.Framework.Bindables.Bindable%601.SetDefault" data-throw-if-not-resolved="false"></xref> or querying <xref href="osu.Framework.Bindables.Bindable%601.IsDefault" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual T Default { get; set; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_Bindable_1_Description"></a> Description

The description for this object.

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Bindables_Bindable_1_Disabled"></a> Disabled

Whether this bindable has been disabled. When disabled, attempting to change the <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> will result in an <xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual bool Disabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_Bindable_1_IsDefault"></a> IsDefault

Check whether the current <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> is equal to <xref href="osu.Framework.Bindables.Bindable%601.Default" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual bool IsDefault { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_Bindable_1_Value"></a> Value

The current value of this bindable.

```csharp
public virtual T Value { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Bindables_Bindable_1_BeginLease_System_Boolean_"></a> BeginLease\(bool\)

Takes out a mutually exclusive lease on this bindable.
During a lease, the bindable will be set to <xref href="osu.Framework.Bindables.Bindable%601.Disabled" data-throw-if-not-resolved="false"></xref>, but changes can still be applied via the <xref href="osu.Framework.Bindables.LeasedBindable%601" data-throw-if-not-resolved="false"></xref> returned by this call.
You should end a lease by calling <xref href="osu.Framework.Bindables.LeasedBindable%601.Return" data-throw-if-not-resolved="false"></xref> when done.

```csharp
public LeasedBindable<T> BeginLease(bool revertValueOnReturn)
```

#### Parameters

`revertValueOnReturn` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> when <xref href="osu.Framework.Bindables.Bindable%601.BeginLease(System.Boolean)" data-throw-if-not-resolved="false"></xref> was called should be restored when the lease ends.

#### Returns

 [LeasedBindable](osu.Framework.Bindables.LeasedBindable\-1.md)<T\>

A bindable with a lease.

### <a id="osu_Framework_Bindables_Bindable_1_BindDisabledChanged_System_Action_System_Boolean__System_Boolean_"></a> BindDisabledChanged\(Action<bool\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.Bindable%601.DisabledChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately.

```csharp
public void BindDisabledChanged(Action<bool> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The action to perform when <xref href="osu.Framework.Bindables.Bindable%601.Disabled" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_Bindable_1_BindTo_osu_Framework_Bindables_Bindable__0__"></a> BindTo\(Bindable<T\>\)

Binds this bindable to another such that bi-directional updates are propagated.
This will adopt any values and value limitations of the bindable bound to.

```csharp
public virtual void BindTo(Bindable<T> them)
```

#### Parameters

`them` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

The foreign bindable. This should always be the most permanent end of the bind (ie. a ConfigManager).

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to bind to an already bound object.

### <a id="osu_Framework_Bindables_Bindable_1_BindValueChanged_System_Action_osu_Framework_Bindables_ValueChangedEvent__0___System_Boolean_"></a> BindValueChanged\(Action<ValueChangedEvent<T\>\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.Bindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately.

```csharp
public void BindValueChanged(Action<ValueChangedEvent<T>> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ValueChangedEvent](osu.Framework.Bindables.ValueChangedEvent\-1.md)<T\>\>

The action to perform when <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_Bindable_1_CopyTo_osu_Framework_Bindables_Bindable__0__"></a> CopyTo\(Bindable<T\>\)

Copies all values and value limitations of this bindable to another.

```csharp
public virtual void CopyTo(Bindable<T> them)
```

#### Parameters

`them` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

The target to copy to.

### <a id="osu_Framework_Bindables_Bindable_1_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected virtual Bindable<T> CreateInstance()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_Bindable_1_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
public Bindable<T> GetBoundCopy()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

### <a id="osu_Framework_Bindables_Bindable_1_GetUnboundCopy"></a> GetUnboundCopy\(\)

Create an unbound clone of this bindable.

```csharp
public Bindable<T> GetUnboundCopy()
```

#### Returns

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_Bindable_1_Parse_System_Object_System_IFormatProvider_"></a> Parse\(object, IFormatProvider\)

Parse an object into this instance.
An object deriving T can be parsed, or a string can be parsed if T is an enum type.

```csharp
public virtual void Parse(object input, IFormatProvider provider)
```

#### Parameters

`input` [object](https://learn.microsoft.com/dotnet/api/system.object)

The input which is to be parsed.

`provider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)

An object that provides culture-specific formatting information about <code class="paramref">input</code>.

### <a id="osu_Framework_Bindables_Bindable_1_SetDefault"></a> SetDefault\(\)

Revert the current <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> to the defined <xref href="osu.Framework.Bindables.Bindable%601.Default" data-throw-if-not-resolved="false"></xref>.

```csharp
public void SetDefault()
```

### <a id="osu_Framework_Bindables_Bindable_1_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="osu_Framework_Bindables_Bindable_1_ToString_System_String_System_IFormatProvider_"></a> ToString\(string, IFormatProvider\)

Formats the value of the current instance using the specified format.

```csharp
public virtual string ToString(string format, IFormatProvider formatProvider)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)

The format to use.  

 -or-  

 A null reference (<code>Nothing</code> in Visual Basic) to use the default format defined for the type of the <xref href="System.IFormattable" data-throw-if-not-resolved="false"></xref> implementation.

`formatProvider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)

The provider to use to format the value.  

 -or-  

 A null reference (<code>Nothing</code> in Visual Basic) to obtain the numeric format information from the current locale setting of the operating system.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The value of the current instance in the specified format.

### <a id="osu_Framework_Bindables_Bindable_1_TriggerChange"></a> TriggerChange\(\)

Raise <xref href="osu.Framework.Bindables.Bindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.Bindable%601.DisabledChanged" data-throw-if-not-resolved="false"></xref> once, without any changes actually occurring.
This does not propagate to any outward bound bindables.

```csharp
public virtual void TriggerChange()
```

### <a id="osu_Framework_Bindables_Bindable_1_TriggerDefaultChange__0_osu_Framework_Bindables_Bindable__0__System_Boolean_System_Boolean_"></a> TriggerDefaultChange\(T, Bindable<T\>, bool, bool\)

```csharp
protected void TriggerDefaultChange(T previousValue, Bindable<T> source, bool propagateToBindings = true, bool bypassChecks = false)
```

#### Parameters

`previousValue` T

`source` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

`propagateToBindings` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassChecks` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_Bindable_1_TriggerDisabledChange_osu_Framework_Bindables_Bindable__0__System_Boolean_System_Boolean_"></a> TriggerDisabledChange\(Bindable<T\>, bool, bool\)

```csharp
protected void TriggerDisabledChange(Bindable<T> source, bool propagateToBindings = true, bool bypassChecks = false)
```

#### Parameters

`source` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

`propagateToBindings` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassChecks` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_Bindable_1_TriggerValueChange__0_osu_Framework_Bindables_Bindable__0__System_Boolean_System_Boolean_"></a> TriggerValueChange\(T, Bindable<T\>, bool, bool\)

```csharp
protected void TriggerValueChange(T previousValue, Bindable<T> source, bool propagateToBindings = true, bool bypassChecks = false)
```

#### Parameters

`previousValue` T

`source` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<T\>

`propagateToBindings` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassChecks` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_Bindable_1_UnbindAll"></a> UnbindAll\(\)

Calls <xref href="osu.Framework.Bindables.Bindable%601.UnbindEvents" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.Bindable%601.UnbindBindings" data-throw-if-not-resolved="false"></xref>.
Also returns any active lease.

```csharp
public void UnbindAll()
```

### <a id="osu_Framework_Bindables_Bindable_1_UnbindBindings"></a> UnbindBindings\(\)

Remove all bound <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref>s via <xref href="osu.Framework.Bindables.Bindable%601.GetBoundCopy" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Bindables.Bindable%601.BindTo(osu.Framework.Bindables.Bindable%7b%600%7d)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void UnbindBindings()
```

### <a id="osu_Framework_Bindables_Bindable_1_UnbindEvents"></a> UnbindEvents\(\)

Unbinds any actions bound to the value changed events.

```csharp
public virtual void UnbindEvents()
```

### <a id="osu_Framework_Bindables_Bindable_1_UnbindFrom_osu_Framework_Bindables_IUnbindable_"></a> UnbindFrom\(IUnbindable\)

Unbinds ourselves from another <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> such that we stop receiving updates it.
The other <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> will also stop receiving any events from us.

```csharp
public virtual void UnbindFrom(IUnbindable them)
```

#### Parameters

`them` [IUnbindable](osu.Framework.Bindables.IUnbindable.md)

The other bindable.

### <a id="osu_Framework_Bindables_Bindable_1_DefaultChanged"></a> DefaultChanged

An event which is raised when <xref href="osu.Framework.Bindables.Bindable%601.Default" data-throw-if-not-resolved="false"></xref> has changed (or manually via <xref href="osu.Framework.Bindables.Bindable%601.TriggerDefaultChange(%600%2cosu.Framework.Bindables.Bindable%7b%600%7d%2cSystem.Boolean%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>).

```csharp
[CanBeNull]
public event Action<ValueChangedEvent<T>> DefaultChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ValueChangedEvent](osu.Framework.Bindables.ValueChangedEvent\-1.md)<T\>\>

### <a id="osu_Framework_Bindables_Bindable_1_DisabledChanged"></a> DisabledChanged

An event which is raised when <xref href="osu.Framework.Bindables.Bindable%601.Disabled" data-throw-if-not-resolved="false"></xref> has changed (or manually via <xref href="osu.Framework.Bindables.Bindable%601.TriggerDisabledChange(osu.Framework.Bindables.Bindable%7b%600%7d%2cSystem.Boolean%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>).

```csharp
[CanBeNull]
public event Action<bool> DisabledChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Bindables_Bindable_1_ValueChanged"></a> ValueChanged

An event which is raised when <xref href="osu.Framework.Bindables.Bindable%601.Value" data-throw-if-not-resolved="false"></xref> has changed (or manually via <xref href="osu.Framework.Bindables.Bindable%601.TriggerValueChange(%600%2cosu.Framework.Bindables.Bindable%7b%600%7d%2cSystem.Boolean%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>).

```csharp
[CanBeNull]
public event Action<ValueChangedEvent<T>> ValueChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ValueChangedEvent](osu.Framework.Bindables.ValueChangedEvent\-1.md)<T\>\>

