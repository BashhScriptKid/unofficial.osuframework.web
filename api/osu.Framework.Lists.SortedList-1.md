# <a id="osu_Framework_Lists_SortedList_1"></a> Class SortedList<T\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

```csharp
public class SortedList<T> : ICollection<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SortedList<T\>](osu.Framework.Lists.SortedList\-1.md)

#### Implements

[ICollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
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

[ObjectExtensions.AsNonNull<SortedList<T\>\>\(SortedList<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SortedList<T\>\>\(SortedList<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<SortedList<T\>\>\(SortedList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SortedList<T\>\>\(SortedList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SortedList<T\>, TChild\>\(SortedList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SortedList<T\>, TChild\>\(SortedList<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SortedList<T\>, TChild\>\(SortedList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SortedList<T\>\>\(SortedList<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Lists_SortedList_1__ctor"></a> SortedList\(\)

Constructs a new <xref href="osu.Framework.Lists.SortedList%601" data-throw-if-not-resolved="false"></xref> with the default <code class="typeparamref">T</code> comparer.

```csharp
public SortedList()
```

### <a id="osu_Framework_Lists_SortedList_1__ctor_System_Func__0__0_System_Int32__"></a> SortedList\(Func<T, T, int\>\)

Constructs a new <xref href="osu.Framework.Lists.SortedList%601" data-throw-if-not-resolved="false"></xref> with a custom comparison function.

```csharp
public SortedList(Func<T, T, int> comparer)
```

#### Parameters

`comparer` [Func](https://learn.microsoft.com/dotnet/api/system.func\-3)<T, T, [int](https://learn.microsoft.com/dotnet/api/system.int32)\>

The comparison function.

### <a id="osu_Framework_Lists_SortedList_1__ctor_System_Collections_Generic_IComparer__0__"></a> SortedList\(IComparer<T\>\)

Constructs a new <xref href="osu.Framework.Lists.SortedList%601" data-throw-if-not-resolved="false"></xref> with a custom <xref href="System.Collections.Generic.IComparer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public SortedList(IComparer<T> comparer)
```

#### Parameters

`comparer` [IComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer\-1)<T\>

The comparer to use.

## Properties

### <a id="osu_Framework_Lists_SortedList_1_Comparer"></a> Comparer

```csharp
public IComparer<T> Comparer { get; }
```

#### Property Value

 [IComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer\-1)<T\>

### <a id="osu_Framework_Lists_SortedList_1_Count"></a> Count

Gets the number of elements contained in the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_Item_System_Int32_"></a> this\[int\]

Gets the element at the specified index in the read-only list.

```csharp
public T this[int index] { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Lists_SortedList_1_Add__0_"></a> Add\(T\)

```csharp
public virtual int Add(T value)
```

#### Parameters

`value` T

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_AddRange_System_Collections_Generic_IEnumerable__0__"></a> AddRange\(IEnumerable<T\>\)

```csharp
public void AddRange(IEnumerable<T> collection)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

### <a id="osu_Framework_Lists_SortedList_1_BinarySearch__0_"></a> BinarySearch\(T\)

```csharp
public int BinarySearch(T value)
```

#### Parameters

`value` T

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_Clear"></a> Clear\(\)

Removes all items from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual void Clear()
```

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

### <a id="osu_Framework_Lists_SortedList_1_Contains__0_"></a> Contains\(T\)

Determines whether the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> contains a specific value.

```csharp
public bool Contains(T item)
```

#### Parameters

`item` T

The object to locate in the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> is found in the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Lists_SortedList_1_CopyTo__0___System_Int32_"></a> CopyTo\(T\[\], int\)

Copies the elements of the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> to an <xref href="System.Array" data-throw-if-not-resolved="false"></xref>, starting at a particular <xref href="System.Array" data-throw-if-not-resolved="false"></xref> index.

```csharp
public void CopyTo(T[] array, int arrayIndex)
```

#### Parameters

`array` T\[\]

The one-dimensional <xref href="System.Array" data-throw-if-not-resolved="false"></xref> that is the destination of the elements copied from <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>. The <xref href="System.Array" data-throw-if-not-resolved="false"></xref> must have zero-based indexing.

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index in <code class="paramref">array</code> at which copying begins.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">array</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">arrayIndex</code> is less than 0.

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

The number of elements in the source <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is greater than the available space from <code class="paramref">arrayIndex</code> to the end of the destination <code class="paramref">array</code>.

### <a id="osu_Framework_Lists_SortedList_1_Find_System_Predicate__0__"></a> Find\(Predicate<T\>\)

```csharp
public T Find(Predicate<T> match)
```

#### Parameters

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<T\>

#### Returns

 T

### <a id="osu_Framework_Lists_SortedList_1_FindAll_System_Predicate__0__"></a> FindAll\(Predicate<T\>\)

```csharp
public IEnumerable<T> FindAll(Predicate<T> match)
```

#### Parameters

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<T\>

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

### <a id="osu_Framework_Lists_SortedList_1_FindIndex_System_Predicate__0__"></a> FindIndex\(Predicate<T\>\)

```csharp
public int FindIndex(Predicate<T> match)
```

#### Parameters

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<T\>

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_FindLast_System_Predicate__0__"></a> FindLast\(Predicate<T\>\)

```csharp
public T FindLast(Predicate<T> match)
```

#### Parameters

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<T\>

#### Returns

 T

### <a id="osu_Framework_Lists_SortedList_1_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public List<T>.Enumerator GetEnumerator()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.enumerator)

### <a id="osu_Framework_Lists_SortedList_1_IndexOf__0_"></a> IndexOf\(T\)

```csharp
public int IndexOf(T value)
```

#### Parameters

`value` T

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_Remove__0_"></a> Remove\(T\)

Removes the first occurrence of a specific object from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Remove(T item)
```

#### Parameters

`item` T

The object to remove from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> was successfully removed from the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>. This method also returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> if <code class="paramref">item</code> is not found in the original <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

### <a id="osu_Framework_Lists_SortedList_1_RemoveAll_System_Predicate__0__"></a> RemoveAll\(Predicate<T\>\)

```csharp
public int RemoveAll(Predicate<T> match)
```

#### Parameters

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<T\>

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_RemoveAt_System_Int32_"></a> RemoveAt\(int\)

```csharp
public virtual void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_RemoveRange_System_Int32_System_Int32_"></a> RemoveRange\(int, int\)

```csharp
public virtual void RemoveRange(int index, int count)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SortedList_1_Sort"></a> Sort\(\)

Re-sorts this <xref href="osu.Framework.Lists.SortedList%601" data-throw-if-not-resolved="false"></xref> by the comparer.

```csharp
public void Sort()
```

#### Remarks

This can be used to re-sort the <xref href="osu.Framework.Lists.SortedList%601" data-throw-if-not-resolved="false"></xref> if the comparer result has changed.

### <a id="osu_Framework_Lists_SortedList_1_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

