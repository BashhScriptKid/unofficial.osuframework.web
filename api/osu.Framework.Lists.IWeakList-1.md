# <a id="osu_Framework_Lists_IWeakList_1"></a> Interface IWeakList<T\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

A slim interface for a list which stores weak references of objects.

```csharp
public interface IWeakList<T> where T : class
```

#### Type Parameters

`T` 

#### Extension Methods

[ObjectExtensions.AsNonNull<IWeakList<T\>\>\(IWeakList<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IWeakList<T\>\>\(IWeakList<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IWeakList<T\>\>\(IWeakList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IWeakList<T\>\>\(IWeakList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IWeakList<T\>, TChild\>\(IWeakList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IWeakList<T\>, TChild\>\(IWeakList<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IWeakList<T\>, TChild\>\(IWeakList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IWeakList<T\>\>\(IWeakList<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Lists_IWeakList_1_Add__0_"></a> Add\(T\)

Adds an item to this list. The item is added as a weak reference.

```csharp
void Add(T item)
```

#### Parameters

`item` T

The item to add.

### <a id="osu_Framework_Lists_IWeakList_1_Add_System_WeakReference__0__"></a> Add\(WeakReference<T\>\)

Adds a weak reference to this list.

```csharp
void Add(WeakReference<T> weakReference)
```

#### Parameters

`weakReference` [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<T\>

The weak reference to add.

### <a id="osu_Framework_Lists_IWeakList_1_Clear"></a> Clear\(\)

Clears all items from this list.

```csharp
void Clear()
```

### <a id="osu_Framework_Lists_IWeakList_1_Contains__0_"></a> Contains\(T\)

Searches for an item in the list.

```csharp
bool Contains(T item)
```

#### Parameters

`item` T

The item to search for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the item is alive and in this list.

### <a id="osu_Framework_Lists_IWeakList_1_Contains_System_WeakReference__0__"></a> Contains\(WeakReference<T\>\)

Searches for a weak reference in the list.

```csharp
bool Contains(WeakReference<T> weakReference)
```

#### Parameters

`weakReference` [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<T\>

The weak reference to search for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the weak reference is in the list.

### <a id="osu_Framework_Lists_IWeakList_1_Remove__0_"></a> Remove\(T\)

Removes an item from this list.

```csharp
bool Remove(T item)
```

#### Parameters

`item` T

The item to remove.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the item was removed.

### <a id="osu_Framework_Lists_IWeakList_1_Remove_System_WeakReference__0__"></a> Remove\(WeakReference<T\>\)

Removes a weak reference from this list.

```csharp
bool Remove(WeakReference<T> weakReference)
```

#### Parameters

`weakReference` [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<T\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Lists_IWeakList_1_RemoveAt_System_Int32_"></a> RemoveAt\(int\)

Removes an item at an index from this list.

```csharp
void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the item to remove.

