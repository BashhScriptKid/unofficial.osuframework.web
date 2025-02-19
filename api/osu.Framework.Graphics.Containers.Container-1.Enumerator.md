# <a id="osu_Framework_Graphics_Containers_Container_1_Enumerator"></a> Struct Container<T\>.Enumerator

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

```csharp
public struct Container<T>.Enumerator : IEnumerator<T>, IEnumerator, IDisposable
```

#### Implements

[IEnumerator<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1), 
[IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.ienumerator), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Container<T\>.Enumerator\>\(Container<T\>.Enumerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Container<T\>.Enumerator\>\(Container<T\>.Enumerator\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Container<T\>.Enumerator\>\(Container<T\>.Enumerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Container<T\>.Enumerator\>\(Container<T\>.Enumerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Container<T\>.Enumerator, TChild\>\(Container<T\>.Enumerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Container<T\>.Enumerator, TChild\>\(Container<T\>.Enumerator, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Container<T\>.Enumerator, TChild\>\(Container<T\>.Enumerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Container<T\>.Enumerator\>\(Container<T\>.Enumerator\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Containers_Container_1_Enumerator_Current"></a> Current

Gets the element in the collection at the current position of the enumerator.

```csharp
public readonly T Current { get; }
```

#### Property Value

 T

## Methods

### <a id="osu_Framework_Graphics_Containers_Container_1_Enumerator_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Containers_Container_1_Enumerator_MoveNext"></a> MoveNext\(\)

Advances the enumerator to the next element of the collection.

```csharp
public bool MoveNext()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the enumerator was successfully advanced to the next element; <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> if the enumerator has passed the end of the collection.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

The collection was modified after the enumerator was created.

### <a id="osu_Framework_Graphics_Containers_Container_1_Enumerator_Reset"></a> Reset\(\)

Sets the enumerator to its initial position, which is before the first element in the collection.

```csharp
public void Reset()
```

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

The collection was modified after the enumerator was created.

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

The enumerator does not support being reset.

