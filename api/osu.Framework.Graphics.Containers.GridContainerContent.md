# <a id="osu_Framework_Graphics_Containers_GridContainerContent"></a> Class GridContainerContent

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

A wrapper for the content of a <xref href="osu.Framework.Graphics.Containers.GridContainer" data-throw-if-not-resolved="false"></xref> that provides notifications when elements are changed.

```csharp
public class GridContainerContent : ObservableArray<ObservableArray<Drawable>>, IReadOnlyList<ObservableArray<Drawable>>, IReadOnlyCollection<ObservableArray<Drawable>>, IEnumerable<ObservableArray<Drawable>>, IEnumerable, IEquatable<ObservableArray<ObservableArray<Drawable>>>, INotifyArrayChanged
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ObservableArray<ObservableArray<Drawable\>\>](osu.Framework.Lists.ObservableArray\-1.md) ← 
[GridContainerContent](osu.Framework.Graphics.Containers.GridContainerContent.md)

#### Implements

[IReadOnlyList<ObservableArray<Drawable\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<ObservableArray<Drawable\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<ObservableArray<Drawable\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IEquatable<ObservableArray<ObservableArray<Drawable\>\>\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[INotifyArrayChanged](osu.Framework.Lists.INotifyArrayChanged.md)

#### Inherited Members

[ObservableArray<ObservableArray<Drawable\>\>.ArrayElementChanged](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_ArrayElementChanged), 
[ObservableArray<ObservableArray<Drawable\>\>.GetEnumerator\(\)](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_GetEnumerator), 
[ObservableArray<ObservableArray<Drawable\>\>.Equals\(ObservableArray<ObservableArray<Drawable\>\>\)](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_Equals\_osu\_Framework\_Lists\_ObservableArray\_\_0\_\_), 
[ObservableArray<ObservableArray<Drawable\>\>.Equals\(object\)](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_Equals\_System\_Object\_), 
[ObservableArray<ObservableArray<Drawable\>\>.GetHashCode\(\)](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_GetHashCode), 
[ObservableArray<ObservableArray<Drawable\>\>.Count](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_Count), 
[ObservableArray<ObservableArray<Drawable\>\>.this\[int\]](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_Item\_System\_Int32\_), 
[ObservableArray<ObservableArray<Drawable\>\>.OnArrayElementChanged\(\)](osu.Framework.Lists.ObservableArray\-1.md\#osu\_Framework\_Lists\_ObservableArray\_1\_OnArrayElementChanged), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GridContainerContent\>\(GridContainerContent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[EnumerableExtensions.CartesianProduct<Drawable\>\(IEnumerable<IEnumerable<Drawable\>\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_CartesianProduct\_\_1\_System\_Collections\_Generic\_IEnumerable\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_), 
[EnumerableExtensions.ForEach<ObservableArray<Drawable\>\>\(IEnumerable<ObservableArray<Drawable\>\>, Action<ObservableArray<Drawable\>\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GridContainerContent\>\(GridContainerContent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<ObservableArray<Drawable\>\>\(IEnumerable<ObservableArray<Drawable\>\>, ObservableArray<Drawable\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<ObservableArray<Drawable\>\>\(IEnumerable<ObservableArray<Drawable\>\>, ObservableArray<Drawable\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<ObservableArray<Drawable\>\>\(IEnumerable<ObservableArray<Drawable\>\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[ObjectExtensions.IsNotNull<GridContainerContent\>\(GridContainerContent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GridContainerContent\>\(GridContainerContent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GridContainerContent, TChild\>\(GridContainerContent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GridContainerContent, TChild\>\(GridContainerContent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GridContainerContent, TChild\>\(GridContainerContent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GridContainerContent\>\(GridContainerContent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Operators

### <a id="osu_Framework_Graphics_Containers_GridContainerContent_op_Implicit_osu_Framework_Graphics_Drawable______osu_Framework_Graphics_Containers_GridContainerContent"></a> implicit operator GridContainerContent\(Drawable\[\]\[\]\)

```csharp
public static implicit operator GridContainerContent(Drawable[][] drawables)
```

#### Parameters

`drawables` [Drawable](osu.Framework.Graphics.Drawable.md)\[\]\[\]

#### Returns

 [GridContainerContent](osu.Framework.Graphics.Containers.GridContainerContent.md)

