# <a id="osu_Framework_Bindables_IBindableDictionary_2"></a> Interface IBindableDictionary<TKey, TValue\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IBindableDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription where TKey : notnull
```

#### Type Parameters

`TKey` 

`TValue` 

#### Implements

[IReadOnlyDictionary<TKey, TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IBindableDictionary<TKey, TValue\>\>\(IBindableDictionary<TKey, TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, Action<KeyValuePair<TKey, TValue\>\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBindableDictionary<TKey, TValue\>\>\(IBindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, KeyValuePair<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>, KeyValuePair<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<KeyValuePair<TKey, TValue\>\>\(IEnumerable<KeyValuePair<TKey, TValue\>\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<IBindableDictionary<TKey, TValue\>\>\(IBindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBindableDictionary<TKey, TValue\>\>\(IBindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IBindableDictionary<TKey, TValue\>, TChild\>\(IBindableDictionary<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBindableDictionary<TKey, TValue\>, TChild\>\(IBindableDictionary<TKey, TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBindableDictionary<TKey, TValue\>, TChild\>\(IBindableDictionary<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBindableDictionary<TKey, TValue\>\>\(IBindableDictionary<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Bindables_IBindableDictionary_2_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.IBindableDictionary%602.BindTo(osu.Framework.Bindables.IBindableDictionary%7b%600%2c%601%7d)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
IBindableDictionary<TKey, TValue> BindTarget { set; }
```

#### Property Value

 [IBindableDictionary](osu.Framework.Bindables.IBindableDictionary\-2.md)<TKey, TValue\>

## Methods

### <a id="osu_Framework_Bindables_IBindableDictionary_2_BindCollectionChanged_osu_Framework_Bindables_NotifyDictionaryChangedEventHandler__0__1__System_Boolean_"></a> BindCollectionChanged\(NotifyDictionaryChangedEventHandler<TKey, TValue\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.IBindableDictionary%602.CollectionChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately
with an <xref href="osu.Framework.Bindables.NotifyDictionaryChangedAction.Add" data-throw-if-not-resolved="false"></xref> event for the entire contents of this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref>.

```csharp
void BindCollectionChanged(NotifyDictionaryChangedEventHandler<TKey, TValue> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [NotifyDictionaryChangedEventHandler](osu.Framework.Bindables.NotifyDictionaryChangedEventHandler\-2.md)<TKey, TValue\>

The action to perform when this <xref href="osu.Framework.Bindables.BindableDictionary%602" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_IBindableDictionary_2_BindTo_osu_Framework_Bindables_IBindableDictionary__0__1__"></a> BindTo\(IBindableDictionary<TKey, TValue\>\)

Binds self to another bindable such that we receive any values and value limitations of the bindable we bind width.

```csharp
void BindTo(IBindableDictionary<TKey, TValue> them)
```

#### Parameters

`them` [IBindableDictionary](osu.Framework.Bindables.IBindableDictionary\-2.md)<TKey, TValue\>

The foreign bindable. This should always be the most permanent end of the bind (ie. a ConfigManager)

### <a id="osu_Framework_Bindables_IBindableDictionary_2_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
IBindableDictionary<TKey, TValue> GetBoundCopy()
```

#### Returns

 [IBindableDictionary](osu.Framework.Bindables.IBindableDictionary\-2.md)<TKey, TValue\>

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

### <a id="osu_Framework_Bindables_IBindableDictionary_2_CollectionChanged"></a> CollectionChanged

An event which is raised when this <xref href="osu.Framework.Bindables.IBindableDictionary%602" data-throw-if-not-resolved="false"></xref> changes.

```csharp
event NotifyDictionaryChangedEventHandler<TKey, TValue>? CollectionChanged
```

#### Event Type

 [NotifyDictionaryChangedEventHandler](osu.Framework.Bindables.NotifyDictionaryChangedEventHandler\-2.md)<TKey, TValue\>?

