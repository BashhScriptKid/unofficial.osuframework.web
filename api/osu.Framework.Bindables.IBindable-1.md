# <a id="osu_Framework_Bindables_IBindable_1"></a> Interface IBindable<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

An interface which can be bound to other <xref href="osu.Framework.Bindables.IBindable%601" data-throw-if-not-resolved="false"></xref>s in order to watch for (and react to) <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled?text=Disabled" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.IBindable%601.Value?text=Value" data-throw-if-not-resolved="false"></xref> changes.

```csharp
public interface IBindable<T> : ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable
```

#### Type Parameters

`T` 

The type of value encapsulated by this <xref href="osu.Framework.Bindables.IBindable%601" data-throw-if-not-resolved="false"></xref>.

#### Implements

[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IBindable<T\>\>\(IBindable<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBindable<T\>\>\(IBindable<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IBindable<T\>\>\(IBindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBindable<T\>\>\(IBindable<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<IBindable<T\>, TChild\>\(IBindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBindable<T\>, TChild\>\(IBindable<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBindable<T\>, TChild\>\(IBindable<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBindable<T\>\>\(IBindable<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Bindables_IBindable_1_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.IBindable%601.BindTo(osu.Framework.Bindables.IBindable%7b%600%7d)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
IBindable<T> BindTarget { set; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

### <a id="osu_Framework_Bindables_IBindable_1_Default"></a> Default

The default value of this bindable. Used when querying <xref href="osu.Framework.Bindables.IHasDefaultValue.IsDefault?text=IsDefault" data-throw-if-not-resolved="false"></xref>.

```csharp
T Default { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Bindables_IBindable_1_Value"></a> Value

The current value of this bindable.

```csharp
T Value { get; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Bindables_IBindable_1_BindTo_osu_Framework_Bindables_IBindable__0__"></a> BindTo\(IBindable<T\>\)

Binds ourselves to another bindable such that we receive any values and value limitations of the bindable we bind width.

```csharp
void BindTo(IBindable<T> them)
```

#### Parameters

`them` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

The foreign bindable. This should always be the most permanent end of the bind (ie. a ConfigManager)

### <a id="osu_Framework_Bindables_IBindable_1_BindValueChanged_System_Action_osu_Framework_Bindables_ValueChangedEvent__0___System_Boolean_"></a> BindValueChanged\(Action<ValueChangedEvent<T\>\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.IBindable%601.ValueChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately.

```csharp
void BindValueChanged(Action<ValueChangedEvent<T>> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ValueChangedEvent](osu.Framework.Bindables.ValueChangedEvent\-1.md)<T\>\>

The action to perform when <xref href="osu.Framework.Bindables.IBindable%601.Value" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_IBindable_1_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
IBindable<T> GetBoundCopy()
```

#### Returns

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<T\>

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

### <a id="osu_Framework_Bindables_IBindable_1_ValueChanged"></a> ValueChanged

An event which is raised when <xref href="osu.Framework.Bindables.IBindable%601.Value" data-throw-if-not-resolved="false"></xref> has changed.

```csharp
event Action<ValueChangedEvent<T>> ValueChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ValueChangedEvent](osu.Framework.Bindables.ValueChangedEvent\-1.md)<T\>\>

