# <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1"></a> Struct SlimReadOnlyListWrapper<T\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

A wrapper that provides a read-only view into a <xref href="System.Collections.Generic.List%601" data-throw-if-not-resolved="false"></xref>.
This can be instantiated via the <xref href="osu.Framework.Extensions.ListExtensions.ListExtensions.AsSlimReadOnly%60%601(System.Collections.Generic.List%7b%60%600%7d)" data-throw-if-not-resolved="false"></xref> extension method.

```csharp
public readonly struct SlimReadOnlyListWrapper<T> : IList<T>, ICollection<T>, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
```

#### Type Parameters

`T` 

The type of elements contained by the list.

#### Implements

[IList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IList](https://learn.microsoft.com/dotnet/api/system.collections.ilist), 
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.icollection), 
[IReadOnlyList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SlimReadOnlyListWrapper<T\>\>\(SlimReadOnlyListWrapper<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SlimReadOnlyListWrapper<T\>\>\(SlimReadOnlyListWrapper<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<SlimReadOnlyListWrapper<T\>\>\(SlimReadOnlyListWrapper<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SlimReadOnlyListWrapper<T\>\>\(SlimReadOnlyListWrapper<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SlimReadOnlyListWrapper<T\>, TChild\>\(SlimReadOnlyListWrapper<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SlimReadOnlyListWrapper<T\>, TChild\>\(SlimReadOnlyListWrapper<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SlimReadOnlyListWrapper<T\>, TChild\>\(SlimReadOnlyListWrapper<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SlimReadOnlyListWrapper<T\>\>\(SlimReadOnlyListWrapper<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1__ctor_System_Collections_Generic_List__0__"></a> SlimReadOnlyListWrapper\(List<T\>\)

```csharp
public SlimReadOnlyListWrapper(List<T> list)
```

#### Parameters

`list` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

## Properties

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Count"></a> Count

Gets the number of elements contained in the <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref>.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_IsFixedSize"></a> IsFixedSize

Gets a value indicating whether the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> has a fixed size.

```csharp
public bool IsFixedSize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_IsSynchronized"></a> IsSynchronized

Gets a value indicating whether access to the <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref> is synchronized (thread safe).

```csharp
public bool IsSynchronized { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_SyncRoot"></a> SyncRoot

Gets an object that can be used to synchronize access to the <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref>.

```csharp
public object SyncRoot { get; }
```

#### Property Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Item_System_Int32_"></a> this\[int\]

Gets or sets the element at the specified index.

```csharp
public T this[int index] { get; set; }
```

#### Property Value

 T

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">index</code> is not a valid index in the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref>.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The property is set and the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref> is read-only.

## Methods

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Add__0_"></a> Add\(T\)

Adds an item to the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Add(T item)
```

#### Parameters

`item` T

The object to add to the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Add_System_Object_"></a> Add\(object?\)

Adds an item to the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

```csharp
public int Add(object? value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to add to the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The position into which the new element was inserted, or -1 to indicate that the item was not inserted into the collection.

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> is read-only.  

 -or-  

 The <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> has a fixed size.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Contains_System_Object_"></a> Contains\(object?\)

Determines whether the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> contains a specific value.

```csharp
public bool Contains(object? value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to locate in the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the <xref href="System.Object" data-throw-if-not-resolved="false"></xref> is found in the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Contains__0_"></a> Contains\(T\)

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

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_CopyTo__0___System_Int32_"></a> CopyTo\(T\[\], int\)

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

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_CopyTo_System_Array_System_Int32_"></a> CopyTo\(Array, int\)

Copies the elements of the <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref> to an <xref href="System.Array" data-throw-if-not-resolved="false"></xref>, starting at a particular <xref href="System.Array" data-throw-if-not-resolved="false"></xref> index.

```csharp
public void CopyTo(Array array, int index)
```

#### Parameters

`array` [Array](https://learn.microsoft.com/dotnet/api/system.array)

The one-dimensional <xref href="System.Array" data-throw-if-not-resolved="false"></xref> that is the destination of the elements copied from <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref>. The <xref href="System.Array" data-throw-if-not-resolved="false"></xref> must have zero-based indexing.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index in <code class="paramref">array</code> at which copying begins.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

<code class="paramref">array</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">index</code> is less than zero.

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

   <code class="paramref">array</code> is multidimensional.  

-or-  

The number of elements in the source <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref> is greater than the available space from <code class="paramref">index</code> to the end of the destination <code class="paramref">array</code>.  

-or-  

The type of the source <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref> cannot be cast automatically to the type of the destination <code class="paramref">array</code>.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public List<T>.Enumerator GetEnumerator()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.enumerator)

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_IndexOf_System_Object_"></a> IndexOf\(object?\)

Determines the index of a specific item in the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

```csharp
public int IndexOf(object? value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to locate in the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of <code class="paramref">value</code> if found in the list; otherwise, -1.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_IndexOf__0_"></a> IndexOf\(T\)

Determines the index of a specific item in the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public int IndexOf(T item)
```

#### Parameters

`item` T

The object to locate in the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of <code class="paramref">item</code> if found in the list; otherwise, -1.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Insert_System_Int32_System_Object_"></a> Insert\(int, object?\)

Inserts an item to the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> at the specified index.

```csharp
public void Insert(int index, object? value)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index at which <code class="paramref">value</code> should be inserted.

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to insert into the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">index</code> is not a valid index in the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> is read-only.  

 -or-  

 The <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> has a fixed size.

 [NullReferenceException](https://learn.microsoft.com/dotnet/api/system.nullreferenceexception)

<code class="paramref">value</code> is null reference in the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Insert_System_Int32__0_"></a> Insert\(int, T\)

Inserts an item to the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref> at the specified index.

```csharp
public void Insert(int index, T item)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index at which <code class="paramref">item</code> should be inserted.

`item` T

The object to insert into the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">index</code> is not a valid index in the <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref>.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.Generic.IList%601" data-throw-if-not-resolved="false"></xref> is read-only.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Remove_System_Object_"></a> Remove\(object?\)

Removes the first occurrence of a specific object from the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Remove(object? value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to remove from the <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> is read-only.  

 -or-  

 The <xref href="System.Collections.IList" data-throw-if-not-resolved="false"></xref> has a fixed size.

### <a id="osu_Framework_Lists_SlimReadOnlyListWrapper_1_Remove__0_"></a> Remove\(T\)

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

