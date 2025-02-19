# <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2"></a> Class NotifyDictionaryChangedEventArgs<TKey, TValue\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

Arguments for a dictionary's CollectionChanged event.

```csharp
public class NotifyDictionaryChangedEventArgs<TKey, TValue> : EventArgs where TKey : notnull
```

#### Type Parameters

`TKey` 

The type of keys in the dictionary.

`TValue` 

The type of values in the dictionary.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) ← 
[NotifyDictionaryChangedEventArgs<TKey, TValue\>](osu.Framework.Bindables.NotifyDictionaryChangedEventArgs\-2.md)

#### Inherited Members

[EventArgs.Empty](https://learn.microsoft.com/dotnet/api/system.eventargs.empty), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<NotifyDictionaryChangedEventArgs<TKey, TValue\>\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<NotifyDictionaryChangedEventArgs<TKey, TValue\>\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<NotifyDictionaryChangedEventArgs<TKey, TValue\>\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<NotifyDictionaryChangedEventArgs<TKey, TValue\>\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<NotifyDictionaryChangedEventArgs<TKey, TValue\>, TChild\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<NotifyDictionaryChangedEventArgs<TKey, TValue\>, TChild\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<NotifyDictionaryChangedEventArgs<TKey, TValue\>, TChild\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<NotifyDictionaryChangedEventArgs<TKey, TValue\>\>\(NotifyDictionaryChangedEventArgs<TKey, TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2__ctor_osu_Framework_Bindables_NotifyDictionaryChangedAction_System_Collections_Generic_KeyValuePair__0__1__"></a> NotifyDictionaryChangedEventArgs\(NotifyDictionaryChangedAction, KeyValuePair<TKey, TValue\>\)

Creates a new <xref href="osu.Framework.Bindables.NotifyDictionaryChangedEventArgs%602" data-throw-if-not-resolved="false"></xref> that describes an add or remove event.

```csharp
public NotifyDictionaryChangedEventArgs(NotifyDictionaryChangedAction action, KeyValuePair<TKey, TValue> item)
```

#### Parameters

`action` [NotifyDictionaryChangedAction](osu.Framework.Bindables.NotifyDictionaryChangedAction.md)

The action.

`item` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

The item affected.

### <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2__ctor_osu_Framework_Bindables_NotifyDictionaryChangedAction_System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair__0__1___"></a> NotifyDictionaryChangedEventArgs\(NotifyDictionaryChangedAction, ICollection<KeyValuePair<TKey, TValue\>\>\)

Creates a new <xref href="osu.Framework.Bindables.NotifyDictionaryChangedEventArgs%602" data-throw-if-not-resolved="false"></xref> that describes an add or remove event.

```csharp
public NotifyDictionaryChangedEventArgs(NotifyDictionaryChangedAction action, ICollection<KeyValuePair<TKey, TValue>> items)
```

#### Parameters

`action` [NotifyDictionaryChangedAction](osu.Framework.Bindables.NotifyDictionaryChangedAction.md)

The action.

`items` [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<[KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>\>

The items affected.

### <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2__ctor_System_Collections_Generic_KeyValuePair__0__1__System_Collections_Generic_KeyValuePair__0__1__"></a> NotifyDictionaryChangedEventArgs\(KeyValuePair<TKey, TValue\>, KeyValuePair<TKey, TValue\>\)

Creates a new <xref href="osu.Framework.Bindables.NotifyDictionaryChangedEventArgs%602" data-throw-if-not-resolved="false"></xref> that describes a replacement event.

```csharp
public NotifyDictionaryChangedEventArgs(KeyValuePair<TKey, TValue> newItem, KeyValuePair<TKey, TValue> oldItem)
```

#### Parameters

`newItem` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

The new (added) item.

`oldItem` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

The old (removed) item.

## Fields

### <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2_Action"></a> Action

The action that caused the event.

```csharp
public readonly NotifyDictionaryChangedAction Action
```

#### Field Value

 [NotifyDictionaryChangedAction](osu.Framework.Bindables.NotifyDictionaryChangedAction.md)

### <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2_NewItems"></a> NewItems

All newly-added items.

```csharp
public readonly ICollection<KeyValuePair<TKey, TValue>>? NewItems
```

#### Field Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<[KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>\>?

### <a id="osu_Framework_Bindables_NotifyDictionaryChangedEventArgs_2_OldItems"></a> OldItems

All removed items.

```csharp
public readonly ICollection<KeyValuePair<TKey, TValue>>? OldItems
```

#### Field Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<[KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>\>?

