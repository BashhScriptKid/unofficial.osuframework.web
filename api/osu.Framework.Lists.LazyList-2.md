# <a id="osu_Framework_Lists_LazyList_2"></a> Class LazyList<TSource, TTarget\>

Namespace: [osu.Framework.Lists](osu.Framework.Lists.md)  
Assembly: osu.Framework.dll  

A list that lazily applies a transformation to elements of a source list to a target type when its indexed or iterated.

```csharp
public class LazyList<TSource, TTarget> : IReadOnlyList<TTarget>, IReadOnlyCollection<TTarget>, IEnumerable<TTarget>, IEnumerable
```

#### Type Parameters

`TSource` 

The type of the source elements.

`TTarget` 

The type of the target elements.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LazyList<TSource, TTarget\>](osu.Framework.Lists.LazyList\-2.md)

#### Implements

[IReadOnlyList<TTarget\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<TTarget\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<TTarget\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
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

[ObjectExtensions.AsNonNull<LazyList<TSource, TTarget\>\>\(LazyList<TSource, TTarget\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.ForEach<TTarget\>\(IEnumerable<TTarget\>, Action<TTarget\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LazyList<TSource, TTarget\>\>\(LazyList<TSource, TTarget\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<TTarget\>\(IEnumerable<TTarget\>, TTarget\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<TTarget\>\(IEnumerable<TTarget\>, TTarget\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<TTarget\>\(IEnumerable<TTarget\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<LazyList<TSource, TTarget\>\>\(LazyList<TSource, TTarget\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LazyList<TSource, TTarget\>\>\(LazyList<TSource, TTarget\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LazyList<TSource, TTarget\>, TChild\>\(LazyList<TSource, TTarget\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LazyList<TSource, TTarget\>, TChild\>\(LazyList<TSource, TTarget\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LazyList<TSource, TTarget\>, TChild\>\(LazyList<TSource, TTarget\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LazyList<TSource, TTarget\>\>\(LazyList<TSource, TTarget\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Lists_LazyList_2__ctor_System_Collections_Generic_IReadOnlyList__0__System_Func__0__1__"></a> LazyList\(IReadOnlyList<TSource\>, Func<TSource, TTarget\>\)

Constructs a new lazy list from the given source list and with the given transformation.

```csharp
public LazyList(IReadOnlyList<TSource> source, Func<TSource, TTarget> map)
```

#### Parameters

`source` [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<TSource\>

The source list to get elements from.

`map` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TSource, TTarget\>

## Properties

### <a id="osu_Framework_Lists_LazyList_2_Count"></a> Count

The number of elements in this lazy list.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Lists_LazyList_2_Item_System_Int32_"></a> this\[int\]

Gets the element at the specified index from source, applies the transformation to it and returns the transformed element.

```csharp
public TTarget this[int index] { get; }
```

#### Property Value

 TTarget

