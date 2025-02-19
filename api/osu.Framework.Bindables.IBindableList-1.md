# <a id="osu_Framework_Bindables_IBindableList_1"></a> Interface IBindableList<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

A readonly interface which can be bound to other <xref href="osu.Framework.Bindables.IBindableList%601" data-throw-if-not-resolved="false"></xref>s in order to watch for state and content changes.

```csharp
public interface IBindableList<T> : IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, INotifyCollectionChanged
```

#### Type Parameters

`T` 

The type of value encapsulated by this <xref href="osu.Framework.Bindables.IBindableList%601" data-throw-if-not-resolved="false"></xref>.

#### Implements

[IReadOnlyList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[INotifyCollectionChanged](https://learn.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged)

#### Extension Methods

[ObjectExtensions.AsNonNull<IBindableList<T\>\>\(IBindableList<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBindableList<T\>\>\(IBindableList<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<IBindableList<T\>\>\(IBindableList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBindableList<T\>\>\(IBindableList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IBindableList<T\>, TChild\>\(IBindableList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBindableList<T\>, TChild\>\(IBindableList<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBindableList<T\>, TChild\>\(IBindableList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBindableList<T\>\>\(IBindableList<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Bindables_IBindableList_1_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.IBindableList%601.BindTo(osu.Framework.Bindables.IBindableList%7b%600%7d)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
IBindableList<T> BindTarget { set; }
```

#### Property Value

 [IBindableList](osu.Framework.Bindables.IBindableList\-1.md)<T\>

## Methods

### <a id="osu_Framework_Bindables_IBindableList_1_BindCollectionChanged_System_Collections_Specialized_NotifyCollectionChangedEventHandler_System_Boolean_"></a> BindCollectionChanged\(NotifyCollectionChangedEventHandler, bool\)

Bind an action to <xref href="System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately
with an <xref href="System.Collections.Specialized.NotifyCollectionChangedAction.Add" data-throw-if-not-resolved="false"></xref> event for the entire contents of this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
void BindCollectionChanged(NotifyCollectionChangedEventHandler onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [NotifyCollectionChangedEventHandler](https://learn.microsoft.com/dotnet/api/system.collections.specialized.notifycollectionchangedeventhandler)

The action to perform when this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_IBindableList_1_BindTo_osu_Framework_Bindables_IBindableList__0__"></a> BindTo\(IBindableList<T\>\)

Binds self to another bindable such that we receive any values and value limitations of the bindable we bind width.

```csharp
void BindTo(IBindableList<T> them)
```

#### Parameters

`them` [IBindableList](osu.Framework.Bindables.IBindableList\-1.md)<T\>

The foreign bindable. This should always be the most permanent end of the bind (ie. a ConfigManager)

### <a id="osu_Framework_Bindables_IBindableList_1_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
IBindableList<T> GetBoundCopy()
```

#### Returns

 [IBindableList](osu.Framework.Bindables.IBindableList\-1.md)<T\>

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

