# <a id="osu_Framework_Graphics_Textures_TextureUpload"></a> Class TextureUpload

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

Low level class for queueing texture uploads to the GPU.
Should be manually disposed if not queued for upload via <xref href="osu.Framework.Graphics.Textures.Texture.SetData(osu.Framework.Graphics.Textures.ITextureUpload)" data-throw-if-not-resolved="false"></xref>.

```csharp
public class TextureUpload : ITextureUpload, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

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

[ObjectExtensions.AsNonNull<TextureUpload\>\(TextureUpload?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextureUpload\>\(TextureUpload\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextureUpload\>\(TextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextureUpload\>\(TextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextureUpload, TChild\>\(TextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextureUpload, TChild\>\(TextureUpload, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextureUpload, TChild\>\(TextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextureUpload\>\(TextureUpload\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_TextureUpload__ctor_SixLabors_ImageSharp_Image_SixLabors_ImageSharp_PixelFormats_Rgba32__"></a> TextureUpload\(Image<Rgba32\>\)

Create an upload from a <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref>. This is the preferred method.

```csharp
public TextureUpload(Image<Rgba32> image)
```

#### Parameters

`image` Image<Rgba32\>

The texture to upload.

### <a id="osu_Framework_Graphics_Textures_TextureUpload__ctor_System_IO_Stream_"></a> TextureUpload\(Stream\)

Create an upload from an arbitrary image stream.
Note that this bypasses per-platform image loading optimisations.
Use <xref href="osu.Framework.Graphics.Textures.TextureLoaderStore" data-throw-if-not-resolved="false"></xref> as provided from GameHost where possible.

```csharp
public TextureUpload(Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The image content.

## Properties

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Bounds"></a> Bounds

The target bounds for this upload. If not specified, will assume to be (0, 0, width, height).

```csharp
public RectangleI Bounds { get; set; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Data"></a> Data

The raw data to be uploaded.

```csharp
public ReadOnlySpan<Rgba32> Data { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Rgba32\>

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Format"></a> Format

The texture format for this upload.

```csharp
public PixelFormat Format { get; }
```

#### Property Value

 PixelFormat

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Height"></a> Height

```csharp
public int Height { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Level"></a> Level

The target mipmap level to upload into.

```csharp
public int Level { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Width"></a> Width

```csharp
public int Width { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Textures_TextureUpload_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

