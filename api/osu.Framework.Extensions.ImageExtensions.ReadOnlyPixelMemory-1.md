# <a id="osu_Framework_Extensions_ImageExtensions_ReadOnlyPixelMemory_1"></a> Struct ReadOnlyPixelMemory<TPixel\>

Namespace: [osu.Framework.Extensions.ImageExtensions](osu.Framework.Extensions.ImageExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public struct ReadOnlyPixelMemory<TPixel> : IDisposable where TPixel : unmanaged, IPixel<TPixel>
```

#### Type Parameters

`TPixel` 

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ReadOnlyPixelMemory<TPixel\>\>\(ReadOnlyPixelMemory<TPixel\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ReadOnlyPixelMemory<TPixel\>\>\(ReadOnlyPixelMemory<TPixel\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ReadOnlyPixelMemory<TPixel\>\>\(ReadOnlyPixelMemory<TPixel\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ReadOnlyPixelMemory<TPixel\>\>\(ReadOnlyPixelMemory<TPixel\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ReadOnlyPixelMemory<TPixel\>, TChild\>\(ReadOnlyPixelMemory<TPixel\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ReadOnlyPixelMemory<TPixel\>, TChild\>\(ReadOnlyPixelMemory<TPixel\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ReadOnlyPixelMemory<TPixel\>, TChild\>\(ReadOnlyPixelMemory<TPixel\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ReadOnlyPixelMemory<TPixel\>\>\(ReadOnlyPixelMemory<TPixel\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Extensions_ImageExtensions_ReadOnlyPixelMemory_1_Span"></a> Span

The span of pixels.

```csharp
public ReadOnlySpan<TPixel> Span { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<TPixel\>

## Methods

### <a id="osu_Framework_Extensions_ImageExtensions_ReadOnlyPixelMemory_1_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

