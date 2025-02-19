# <a id="osu_Framework_Bindables_IBindable"></a> Interface IBindable

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

An interface which can be bound to other <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s in order to watch for (and react to) <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled?text=Disabled" data-throw-if-not-resolved="false"></xref> changes.

```csharp
public interface IBindable : ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable
```

#### Implements

[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IBindable\>\(IBindable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBindable\>\(IBindable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IBindable\>\(IBindable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBindable\>\(IBindable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<IBindable, TChild\>\(IBindable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBindable, TChild\>\(IBindable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBindable, TChild\>\(IBindable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBindable\>\(IBindable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Bindables_IBindable_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.IBindable.BindTo(osu.Framework.Bindables.IBindable)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
IBindable BindTarget { set; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable.md)

## Methods

### <a id="osu_Framework_Bindables_IBindable_BindTo_osu_Framework_Bindables_IBindable_"></a> BindTo\(IBindable\)

Binds ourselves to another bindable such that we receive any value limitations of the bindable we bind with.

```csharp
void BindTo(IBindable them)
```

#### Parameters

`them` [IBindable](osu.Framework.Bindables.IBindable.md)

The foreign bindable. This should always be the most permanent end of the bind (ie. a ConfigManager)

### <a id="osu_Framework_Bindables_IBindable_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
IBindable CreateInstance()
```

#### Returns

 [IBindable](osu.Framework.Bindables.IBindable.md)

### <a id="osu_Framework_Bindables_IBindable_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
IBindable GetBoundCopy()
```

#### Returns

 [IBindable](osu.Framework.Bindables.IBindable.md)

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

### <a id="osu_Framework_Bindables_IBindable_GetBoundCopyImplementation__1___0_"></a> GetBoundCopyImplementation<T\>\(T\)

Helper method which implements <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref> for use in final classes.

```csharp
protected static T GetBoundCopyImplementation<T>(T source) where T : IBindable
```

#### Parameters

`source` T

The source <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>.

#### Returns

 T

The bound copy.

#### Type Parameters

`T` 

The bindable type.

