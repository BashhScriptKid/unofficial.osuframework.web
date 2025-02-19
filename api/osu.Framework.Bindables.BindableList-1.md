# <a id="osu_Framework_Bindables_BindableList_1"></a> Class BindableList<T\>

Namespace: [osu.Framework.Bindables](osu.Framework.Bindables.md)  
Assembly: osu.Framework.dll  

```csharp
public class BindableList<T> : IBindableList<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, INotifyCollectionChanged, IBindable, ICanBeDisabled, IHasDefaultValue, IUnbindable, IHasDescription, IFormattable, IParseable, IList<T>, ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BindableList<T\>](osu.Framework.Bindables.BindableList\-1.md)

#### Implements

[IBindableList<T\>](osu.Framework.Bindables.IBindableList\-1.md), 
[IReadOnlyList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[INotifyCollectionChanged](https://learn.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged), 
[IBindable](osu.Framework.Bindables.IBindable.md), 
[ICanBeDisabled](osu.Framework.Bindables.ICanBeDisabled.md), 
[IHasDefaultValue](osu.Framework.Bindables.IHasDefaultValue.md), 
[IUnbindable](osu.Framework.Bindables.IUnbindable.md), 
[IHasDescription](osu.Framework.Bindables.IHasDescription.md), 
[IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable), 
[IParseable](osu.Framework.Bindables.IParseable.md), 
[IList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IEnumerable<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IList](https://learn.microsoft.com/dotnet/api/system.collections.ilist), 
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.icollection), 
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

[ObjectExtensions.AsNonNull<BindableList<T\>\>\(BindableList<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BindableList<T\>\>\(BindableList<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<BindableList<T\>\>\(BindableList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BindableList<T\>\>\(BindableList<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<BindableList<T\>, TChild\>\(BindableList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BindableList<T\>, TChild\>\(BindableList<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BindableList<T\>, TChild\>\(BindableList<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BindableList<T\>\>\(BindableList<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Bindables_BindableList_1__ctor_System_Collections_Generic_IEnumerable__0__"></a> BindableList\(IEnumerable<T\>\)

Creates a new <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>, optionally adding the items of the given collection.

```csharp
public BindableList(IEnumerable<T> items = null)
```

#### Parameters

`items` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The items that are going to be contained in the newly created <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

## Properties

### <a id="osu_Framework_Bindables_BindableList_1_BindTarget"></a> BindTarget

An alias of <xref href="osu.Framework.Bindables.BindableList%601.BindTo(osu.Framework.Bindables.BindableList%7b%600%7d)" data-throw-if-not-resolved="false"></xref> provided for use in object initializer scenarios.
Passes the provided value as the foreign (more permanent) bindable.

```csharp
public IBindableList<T> BindTarget { set; }
```

#### Property Value

 [IBindableList](osu.Framework.Bindables.IBindableList\-1.md)<T\>

### <a id="osu_Framework_Bindables_BindableList_1_Count"></a> Count

Gets the number of elements in the collection.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Bindables_BindableList_1_Description"></a> Description

The description for this object.

```csharp
public string Description { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Bindables_BindableList_1_Disabled"></a> Disabled

Whether this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> has been disabled. When disabled, attempting to change the contents of this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> will result in an <xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Disabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableList_1_IsDefault"></a> IsDefault

Check whether this object has its default value.

```csharp
public bool IsDefault { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableList_1_IsReadOnly"></a> IsReadOnly

Gets a value indicating whether the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only.

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableList_1_IsSynchronized"></a> IsSynchronized

Gets a value indicating whether access to the <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref> is synchronized (thread safe).

```csharp
public bool IsSynchronized { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Bindables_BindableList_1_SyncRoot"></a> SyncRoot

Gets an object that can be used to synchronize access to the <xref href="System.Collections.ICollection" data-throw-if-not-resolved="false"></xref>.

```csharp
public object SyncRoot { get; }
```

#### Property Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Bindables_BindableList_1_Item_System_Int32_"></a> this\[int\]

Gets or sets the item at an index in this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public T this[int index] { get; set; }
```

#### Property Value

 T

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when setting a value while this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

## Methods

### <a id="osu_Framework_Bindables_BindableList_1_Add__0_"></a> Add\(T\)

Adds a single item to this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Add(T item)
```

#### Parameters

`item` T

The item to be added.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_AddRange_System_Collections_Generic_IEnumerable__0__"></a> AddRange\(IEnumerable<T\>\)

Adds a collection of items to this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddRange(IEnumerable<T> items)
```

#### Parameters

`items` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The collection whose items should be added to this collection.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this collection is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>

### <a id="osu_Framework_Bindables_BindableList_1_BinarySearch__0_"></a> BinarySearch\(T\)

```csharp
public int BinarySearch(T item)
```

#### Parameters

`item` T

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Bindables_BindableList_1_BindCollectionChanged_System_Collections_Specialized_NotifyCollectionChangedEventHandler_System_Boolean_"></a> BindCollectionChanged\(NotifyCollectionChangedEventHandler, bool\)

Bind an action to <xref href="osu.Framework.Bindables.BindableList%601.CollectionChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately
with an <xref href="System.Collections.Specialized.NotifyCollectionChangedAction.Add" data-throw-if-not-resolved="false"></xref> event for the entire contents of this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void BindCollectionChanged(NotifyCollectionChangedEventHandler onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [NotifyCollectionChangedEventHandler](https://learn.microsoft.com/dotnet/api/system.collections.specialized.notifycollectionchangedeventhandler)

The action to perform when this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_BindableList_1_BindDisabledChanged_System_Action_System_Boolean__System_Boolean_"></a> BindDisabledChanged\(Action<bool\>, bool\)

Bind an action to <xref href="osu.Framework.Bindables.ICanBeDisabled.DisabledChanged" data-throw-if-not-resolved="false"></xref> with the option of running the bound action once immediately.

```csharp
public void BindDisabledChanged(Action<bool> onChange, bool runOnceImmediately = false)
```

#### Parameters

`onChange` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

The action to perform when <xref href="osu.Framework.Bindables.ICanBeDisabled.Disabled" data-throw-if-not-resolved="false"></xref> changes.

`runOnceImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the action provided in <code class="paramref">onChange</code> should be run once immediately.

### <a id="osu_Framework_Bindables_BindableList_1_BindTo_osu_Framework_Bindables_BindableList__0__"></a> BindTo\(BindableList<T\>\)

Binds this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> to another.

```csharp
public void BindTo(BindableList<T> them)
```

#### Parameters

`them` [BindableList](osu.Framework.Bindables.BindableList\-1.md)<T\>

The <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> to be bound to.

### <a id="osu_Framework_Bindables_BindableList_1_Clear"></a> Clear\(\)

Clears the contents of this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Clear()
```

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_Contains__0_"></a> Contains\(T\)

Determines if an item is in this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Contains(T item)
```

#### Parameters

`item` T

The item to locate in this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<pre><code class="lang-csharp">true</code></pre> if this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> contains the given item.

### <a id="osu_Framework_Bindables_BindableList_1_CopyTo__0___System_Int32_"></a> CopyTo\(T\[\], int\)

Copies the contents of this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> to the given array, starting at the given index.

```csharp
public void CopyTo(T[] array, int arrayIndex)
```

#### Parameters

`array` T\[\]

The array that is the destination of the items copied from this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index at which the copying begins.

### <a id="osu_Framework_Bindables_BindableList_1_CopyTo_System_Array_System_Int32_"></a> CopyTo\(Array, int\)

Copies the contents of this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> to the given array, starting at the given index.

```csharp
public void CopyTo(Array array, int index)
```

#### Parameters

`array` [Array](https://learn.microsoft.com/dotnet/api/system.array)

The array that is the destination of the items copied from this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index at which the copying begins.

### <a id="osu_Framework_Bindables_BindableList_1_CreateInstance"></a> CreateInstance\(\)

Creates a new instance of this <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> for use in <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.
The returned instance must have match the most derived type of the bindable class this method is implemented on.

```csharp
protected virtual BindableList<T> CreateInstance()
```

#### Returns

 [BindableList](osu.Framework.Bindables.BindableList\-1.md)<T\>

### <a id="osu_Framework_Bindables_BindableList_1_GetBoundCopy"></a> GetBoundCopy\(\)

Retrieve a new bindable instance weakly bound to the configuration backing.
If you are further binding to events of a bindable retrieved using this method, ensure to hold
a local reference.

```csharp
public BindableList<T> GetBoundCopy()
```

#### Returns

 [BindableList](osu.Framework.Bindables.BindableList\-1.md)<T\>

A weakly bound copy of the specified bindable.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to instantiate a copy bindable that's not matching the original's type.

### <a id="osu_Framework_Bindables_BindableList_1_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public List<T>.Enumerator GetEnumerator()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>.[Enumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1.enumerator)

### <a id="osu_Framework_Bindables_BindableList_1_IndexOf__0_"></a> IndexOf\(T\)

Retrieves the index of an item in this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public int IndexOf(T item)
```

#### Parameters

`item` T

The item to retrieve the index of.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the item, or -1 if the item isn't in this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_Insert_System_Int32__0_"></a> Insert\(int, T\)

Inserts an item at the specified index in this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Insert(int index, T item)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index to insert at.

`item` T

The item to insert.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_Move_System_Int32_System_Int32_"></a> Move\(int, int\)

Moves an item in this collection.

```csharp
public void Move(int oldIndex, int newIndex)
```

#### Parameters

`oldIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the item to move.

`newIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index specifying the new location of the item.

### <a id="osu_Framework_Bindables_BindableList_1_Parse_System_Object_System_IFormatProvider_"></a> Parse\(object, IFormatProvider\)

Parse an object into this instance.
A collection holding items of type <code class="typeparamref">T</code> can be parsed. Null results in an empty <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Parse(object input, IFormatProvider provider)
```

#### Parameters

`input` [object](https://learn.microsoft.com/dotnet/api/system.object)

The input which is to be parsed.

`provider` [IFormatProvider](https://learn.microsoft.com/dotnet/api/system.iformatprovider)

Not valid for <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_Remove__0_"></a> Remove\(T\)

Removes an item from this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Remove(T item)
```

#### Parameters

`item` T

The item to remove from this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<pre><code class="lang-csharp">true</code></pre> if the removal was successful.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_RemoveAll_System_Predicate__0__"></a> RemoveAll\(Predicate<T\>\)

Removes all items from this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> that match a predicate.

```csharp
public int RemoveAll(Predicate<T> match)
```

#### Parameters

`match` [Predicate](https://learn.microsoft.com/dotnet/api/system.predicate\-1)<T\>

The predicate.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Bindables_BindableList_1_RemoveAt_System_Int32_"></a> RemoveAt\(int\)

Removes an item at the specified index from this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the item to remove.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown if this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Bindables_BindableList_1_RemoveRange_System_Int32_System_Int32_"></a> RemoveRange\(int, int\)

Removes <code class="paramref">count</code> items starting from <code class="paramref">index</code>.

```csharp
public void RemoveRange(int index, int count)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index to start removing from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The count of items to be removed.

### <a id="osu_Framework_Bindables_BindableList_1_ReplaceRange_System_Int32_System_Int32_System_Collections_Generic_IEnumerable__0__"></a> ReplaceRange\(int, int, IEnumerable<T\>\)

Replaces <code class="paramref">count</code> items starting from <code class="paramref">index</code> with <code class="paramref">newItems</code>.

```csharp
public void ReplaceRange(int index, int count, IEnumerable<T> newItems)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index to start removing from.

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The count of items to be removed.

`newItems` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The items to replace the removed items with.

### <a id="osu_Framework_Bindables_BindableList_1_UnbindAll"></a> UnbindAll\(\)

Calls <xref href="osu.Framework.Bindables.IUnbindable.UnbindEvents" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Bindables.IUnbindable.UnbindBindings" data-throw-if-not-resolved="false"></xref>

```csharp
public void UnbindAll()
```

### <a id="osu_Framework_Bindables_BindableList_1_UnbindBindings"></a> UnbindBindings\(\)

Unbinds all bound <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>s.

```csharp
public void UnbindBindings()
```

### <a id="osu_Framework_Bindables_BindableList_1_UnbindEvents"></a> UnbindEvents\(\)

Unbinds all bound events.

```csharp
public virtual void UnbindEvents()
```

### <a id="osu_Framework_Bindables_BindableList_1_UnbindFrom_osu_Framework_Bindables_IUnbindable_"></a> UnbindFrom\(IUnbindable\)

Unbinds ourselves from another <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> such that we stop receiving updates it.
The other <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref> will also stop receiving any events from us.

```csharp
public virtual void UnbindFrom(IUnbindable them)
```

#### Parameters

`them` [IUnbindable](osu.Framework.Bindables.IUnbindable.md)

The other bindable.

### <a id="osu_Framework_Bindables_BindableList_1_CollectionChanged"></a> CollectionChanged

An event which is raised when this <xref href="osu.Framework.Bindables.BindableList%601" data-throw-if-not-resolved="false"></xref> changes.

```csharp
public event NotifyCollectionChangedEventHandler CollectionChanged
```

#### Event Type

 [NotifyCollectionChangedEventHandler](https://learn.microsoft.com/dotnet/api/system.collections.specialized.notifycollectionchangedeventhandler)

### <a id="osu_Framework_Bindables_BindableList_1_DisabledChanged"></a> DisabledChanged

An event which is raised when <xref href="osu.Framework.Bindables.BindableList%601.Disabled" data-throw-if-not-resolved="false"></xref>'s state has changed (or manually via <xref href="osu.Framework.Bindables.BindableList%601.triggerDisabledChange(System.Boolean)" data-throw-if-not-resolved="false"></xref>).

```csharp
[CanBeNull]
public event Action<bool> DisabledChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

