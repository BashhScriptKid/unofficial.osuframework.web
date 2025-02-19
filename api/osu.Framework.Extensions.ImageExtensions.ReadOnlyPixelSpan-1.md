# <a id="osu_Framework_Extensions_ImageExtensions_ReadOnlyPixelSpan_1"></a> Struct ReadOnlyPixelSpan<TPixel\>

Namespace: [osu.Framework.Extensions.ImageExtensions](osu.Framework.Extensions.ImageExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly ref struct ReadOnlyPixelSpan<TPixel> where TPixel : unmanaged, IPixel<TPixel>
```

#### Type Parameters

`TPixel` 

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="osu_Framework_Extensions_ImageExtensions_ReadOnlyPixelSpan_1_Span"></a> Span

The span of pixels.

```csharp
public readonly ReadOnlySpan<TPixel> Span
```

#### Field Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<TPixel\>

## Methods

### <a id="osu_Framework_Extensions_ImageExtensions_ReadOnlyPixelSpan_1_Dispose"></a> Dispose\(\)

```csharp
public void Dispose()
```

