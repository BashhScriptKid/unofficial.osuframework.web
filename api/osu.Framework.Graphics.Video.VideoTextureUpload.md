# <a id="osu_Framework_Graphics_Video_VideoTextureUpload"></a> Class VideoTextureUpload

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class VideoTextureUpload : ITextureUpload, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[VideoTextureUpload](osu.Framework.Graphics.Video.VideoTextureUpload.md)

#### Implements

[ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<VideoTextureUpload\>\(VideoTextureUpload?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<VideoTextureUpload\>\(VideoTextureUpload\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<VideoTextureUpload\>\(VideoTextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<VideoTextureUpload\>\(VideoTextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<VideoTextureUpload, TChild\>\(VideoTextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<VideoTextureUpload, TChild\>\(VideoTextureUpload, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<VideoTextureUpload, TChild\>\(VideoTextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<VideoTextureUpload\>\(VideoTextureUpload\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_Bounds"></a> Bounds

The target bounds for this upload. If not specified, will assume to be (0, 0, width, height).

```csharp
public RectangleI Bounds { get; set; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_Data"></a> Data

The raw data to be uploaded.

```csharp
public ReadOnlySpan<Rgba32> Data { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Rgba32\>

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_Format"></a> Format

The texture format for this upload.

```csharp
public PixelFormat Format { get; }
```

#### Property Value

 PixelFormat

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_Frame"></a> Frame

```csharp
public AVFrame* Frame { get; }
```

#### Property Value

 AVFrame\*

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_Level"></a> Level

The target mipmap level to upload into.

```csharp
public int Level { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_GetPlaneHeight_System_UInt32_"></a> GetPlaneHeight\(uint\)

```csharp
public int GetPlaneHeight(uint plane)
```

#### Parameters

`plane` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_VideoTextureUpload_GetPlaneWidth_System_UInt32_"></a> GetPlaneWidth\(uint\)

```csharp
public int GetPlaneWidth(uint plane)
```

#### Parameters

`plane` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

