# <a id="osu_Framework_Lists_ObservableArray_1"></a> Class ObservableArray<T\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

A wrapper for an array that provides notifications when elements are changed.

```csharp
public class ObservableArray<T> : IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable, IEquatable<ObservableArray<T>>, INotifyArrayChanged
```

#### Type Parameters

`T` 

The type of elements stored in the array.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ObservableArray<T\>](osu.Framework.Lists.ObservableArray\-1.md)

#### Implements

[IReadOnlyList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IEquatable<ObservableArray<T\>\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[INotifyArrayChanged](osu.Framework.Lists.INotifyArrayChanged.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ObservableArray<T\>\>\(ObservableArray<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ObservableArray<T\>\>\(ObservableArray<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<ObservableArray<T\>\>\(ObservableArray<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ObservableArray<T\>\>\(ObservableArray<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ObservableArray<T\>, TChild\>\(ObservableArray<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ObservableArray<T\>, TChild\>\(ObservableArray<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ObservableArray<T\>, TChild\>\(ObservableArray<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ObservableArray<T\>\>\(ObservableArray<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Lists_ObservableArray_1__ctor__0___"></a> ObservableArray\(T\[\]\)

```csharp
public ObservableArray(T[] arrayToWrap)
```

#### Parameters

`arrayToWrap` T\[\]

## Properties

### <a id="osu_Framework_Lists_ObservableArray_1_Count"></a> Count

Gets the number of elements in the collection.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_ObservableArray_1_Item_System_Int32_"></a> this\[int\]

Gets the element at the specified index in the read-only list.

```csharp
public T this[int index] { get; set; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Lists_ObservableArray_1_Equals_osu_Framework_Lists_ObservableArray__0__"></a> Equals\(ObservableArray<T\>\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(ObservableArray<T> other)
```

#### Parameters

`other` [ObservableArray](osu.Framework.Lists.ObservableArray\-1.md)<T\>

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Lists_ObservableArray_1_Equals_System_Object_"></a> Equals\(object\)

Determines whether the specified object is equal to the current object.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified object  is equal to the current object; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Lists_ObservableArray_1_GetEnumerator"></a> GetEnumerator\(\)

Returns an enumerator that iterates through the collection.

```csharp
public IEnumerator<T> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<T\>

An enumerator that can be used to iterate through the collection.

### <a id="osu_Framework_Lists_ObservableArray_1_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="osu_Framework_Lists_ObservableArray_1_OnArrayElementChanged"></a> OnArrayElementChanged\(\)

```csharp
protected void OnArrayElementChanged()
```

### <a id="osu_Framework_Lists_ObservableArray_1_ArrayElementChanged"></a> ArrayElementChanged

Invoked when an element of the array is changed via <xref href="osu.Framework.Lists.ObservableArray%601.Item(System.Int32)" data-throw-if-not-resolved="false"></xref>.

```csharp
[CanBeNull]
public event Action ArrayElementChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

## Operators

### <a id="osu_Framework_Lists_ObservableArray_1_op_Implicit__0____osu_Framework_Lists_ObservableArray__0_"></a> implicit operator ObservableArray<T\>\(T\[\]\)

```csharp
public static implicit operator ObservableArray<T>(T[] source)
```

#### Parameters

`source` T\[\]

#### Returns

 [ObservableArray](osu.Framework.Lists.ObservableArray\-1.md)<T\>

