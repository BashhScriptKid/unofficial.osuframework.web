# <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload"></a> Class ArrayPoolTextureUpload

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

```csharp
public class ArrayPoolTextureUpload : ITextureUpload, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ArrayPoolTextureUpload](osu.Framework.Graphics.Textures.ArrayPoolTextureUpload.md)

#### Implements

[ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ArrayPoolTextureUpload\>\(ArrayPoolTextureUpload?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ArrayPoolTextureUpload\>\(ArrayPoolTextureUpload\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ArrayPoolTextureUpload\>\(ArrayPoolTextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ArrayPoolTextureUpload\>\(ArrayPoolTextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ArrayPoolTextureUpload, TChild\>\(ArrayPoolTextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ArrayPoolTextureUpload, TChild\>\(ArrayPoolTextureUpload, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ArrayPoolTextureUpload, TChild\>\(ArrayPoolTextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ArrayPoolTextureUpload\>\(ArrayPoolTextureUpload\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload__ctor_System_Int32_System_Int32_System_Buffers_ArrayPool_SixLabors_ImageSharp_PixelFormats_Rgba32__"></a> ArrayPoolTextureUpload\(int, int, ArrayPool<Rgba32\>\)

Create an empty raw texture with an efficient shared memory backing.

```csharp
public ArrayPoolTextureUpload(int width, int height, ArrayPool<Rgba32> arrayPool = null)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the texture.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the texture.

`arrayPool` [ArrayPool](https://learn.microsoft.com/dotnet/api/system.buffers.arraypool\-1)<Rgba32\>

The source pool to retrieve memory from. Shared default is used if null.

## Properties

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload_Bounds"></a> Bounds

The target bounds for this upload. If not specified, will assume to be (0, 0, width, height).

```csharp
public RectangleI Bounds { get; set; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload_Data"></a> Data

The raw data to be uploaded.

```csharp
public ReadOnlySpan<Rgba32> Data { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Rgba32\>

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload_Format"></a> Format

The texture format for this upload.

```csharp
public virtual PixelFormat Format { get; }
```

#### Property Value

 PixelFormat

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload_Level"></a> Level

The target mipmap level to upload into.

```csharp
public int Level { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload_RawData"></a> RawData

```csharp
public Span<Rgba32> RawData { get; }
```

#### Property Value

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Rgba32\>

## Methods

### <a id="osu_Framework_Graphics_Textures_ArrayPoolTextureUpload_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

