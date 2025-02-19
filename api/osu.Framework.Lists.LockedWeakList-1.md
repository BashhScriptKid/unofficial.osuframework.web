# <a id="osu_Framework_Lists_LockedWeakList_1"></a> Class LockedWeakList<T\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

A <xref href="osu.Framework.Lists.IWeakList%601" data-throw-if-not-resolved="false"></xref> which locks all operations.

```csharp
public class LockedWeakList<T> : IWeakList<T>, IEnumerable<T>, IEnumerable where T : class
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LockedWeakList<T\>](osu.Framework.Lists.LockedWeakList\-1.md)

#### Implements

[IWeakList<T\>](osu.Framework.Lists.IWeakList\-1.md), 
[IEnumerable<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LockedWeakList<T\>\>\(LockedWeakList<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LockedWeakList<T\>\>\(LockedWeakList<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<LockedWeakList<T\>\>\(LockedWeakList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LockedWeakList<T\>\>\(LockedWeakList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LockedWeakList<T\>, TChild\>\(LockedWeakList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LockedWeakList<T\>, TChild\>\(LockedWeakList<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LockedWeakList<T\>, TChild\>\(LockedWeakList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LockedWeakList<T\>\>\(LockedWeakList<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Lists_LockedWeakList_1_Add__0_"></a> Add\(T\)

Adds an item to this list. The item is added as a weak reference.

```csharp
public void Add(T item)
```

#### Parameters

`item` T

The item to add.

### <a id="osu_Framework_Lists_LockedWeakList_1_Add_System_WeakReference__0__"></a> Add\(WeakReference<T\>\)

Adds a weak reference to this list.

```csharp
public void Add(WeakReference<T> weakReference)
```

#### Parameters

`weakReference` [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<T\>

The weak reference to add.

### <a id="osu_Framework_Lists_LockedWeakList_1_Clear"></a> Clear\(\)

Clears all items from this list.

```csharp
public void Clear()
```

### <a id="osu_Framework_Lists_LockedWeakList_1_Contains__0_"></a> Contains\(T\)

Searches for an item in the list.

```csharp
public bool Contains(T item)
```

#### Parameters

`item` T

The item to search for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the item is alive and in this list.

### <a id="osu_Framework_Lists_LockedWeakList_1_Contains_System_WeakReference__0__"></a> Contains\(WeakReference<T\>\)

Searches for a weak reference in the list.

```csharp
public bool Contains(WeakReference<T> weakReference)
```

#### Parameters

`weakReference` [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<T\>

The weak reference to search for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the weak reference is in the list.

### <a id="osu_Framework_Lists_LockedWeakList_1_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public LockedWeakList<T>.Enumerator GetEnumerator()
```

#### Returns

 [LockedWeakList](osu.Framework.Lists.LockedWeakList\-1.md)<T\>.[Enumerator](osu.Framework.Lists.LockedWeakList\-1.Enumerator.md)

### <a id="osu_Framework_Lists_LockedWeakList_1_Remove__0_"></a> Remove\(T\)

Removes an item from this list.

```csharp
public bool Remove(T item)
```

#### Parameters

`item` T

The item to remove.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the item was removed.

### <a id="osu_Framework_Lists_LockedWeakList_1_Remove_System_WeakReference__0__"></a> Remove\(WeakReference<T\>\)

Removes a weak reference from this list.

```csharp
public bool Remove(WeakReference<T> weakReference)
```

#### Parameters

`weakReference` [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<T\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Lists_LockedWeakList_1_RemoveAt_System_Int32_"></a> RemoveAt\(int\)

Removes an item at an index from this list.

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the item to remove.

