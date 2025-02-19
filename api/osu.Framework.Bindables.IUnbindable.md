# <a id="osu_Framework_Bindables_IUnbindable"></a> Interface IUnbindable

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

Interface for objects that support publicly unbinding events or <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s.

```csharp
public interface IUnbindable
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IUnbindable\>\(IUnbindable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IUnbindable\>\(IUnbindable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IUnbindable\>\(IUnbindable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IUnbindable\>\(IUnbindable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IUnbindable, TChild\>\(IUnbindable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IUnbindable, TChild\>\(IUnbindable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IUnbindable, TChild\>\(IUnbindable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IUnbindable\>\(IUnbindable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Bindables_IUnbindable_UnbindAll"></a> UnbindAll\(\)

Calls <xref href="osu.Framework.Bindables.IUnbindable.UnbindEvents" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.IUnbindable.UnbindBindings" data-throw-if-not-resolved="false"></xref>

```csharp
void UnbindAll()
```

### <a id="osu_Framework_Bindables_IUnbindable_UnbindBindings"></a> UnbindBindings\(\)

Unbinds all bound <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s.

```csharp
void UnbindBindings()
```

### <a id="osu_Framework_Bindables_IUnbindable_UnbindEvents"></a> UnbindEvents\(\)

Unbinds all bound events.

```csharp
void UnbindEvents()
```

### <a id="osu_Framework_Bindables_IUnbindable_UnbindFrom_osu_Framework_Bindables_IUnbindable_"></a> UnbindFrom\(IUnbindable\)

Unbinds ourselves from another <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> such that we stop receiving updates it.
The other <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> will also stop receiving any events from us.

```csharp
void UnbindFrom(IUnbindable them)
```

#### Parameters

`them` [IUnbindable](osu.Framework.Bindables.IUnbindable.md)

The other bindable.

