# <a id="osu_Framework_Graphics_Rendering_INativeTexture"></a> Interface INativeTexture

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public interface INativeTexture : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<INativeTexture\>\(INativeTexture?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<INativeTexture\>\(INativeTexture\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<INativeTexture\>\(INativeTexture\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<INativeTexture\>\(INativeTexture\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<INativeTexture, TChild\>\(INativeTexture, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<INativeTexture, TChild\>\(INativeTexture, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<INativeTexture, TChild\>\(INativeTexture, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<INativeTexture\>\(INativeTexture\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_Available"></a> Available

Whether the texture is in a usable state.

```csharp
bool Available { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_BypassTextureUploadQueueing"></a> BypassTextureUploadQueueing

By default, texture uploads are queued for upload at the beginning of each frame, allowing loading them ahead of time.
When this is true, this will be bypassed and textures will only be uploaded on use. Should be set for every-frame texture uploads
to avoid overloading the global queue.

```csharp
bool BypassTextureUploadQueueing { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_Height"></a> Height

The height of the texture.

```csharp
int Height { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_Identifier"></a> Identifier

An identifier for this texture, to show up in the <xref href="osu.Framework.Graphics.Visualisation.TextureVisualiser" data-throw-if-not-resolved="false"></xref>.

```csharp
string Identifier { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_MaxSize"></a> MaxSize

Maximum texture size in any direction.

```csharp
int MaxSize { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_MipLevel"></a> MipLevel

The level of the texture to display, or null to display all levels automatically.
This is used by the texture visualiser tool for viewing textures on a specific mipmap level.

```csharp
int? MipLevel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_Renderer"></a> Renderer

The renderer that created this texture.

```csharp
IRenderer Renderer { get; }
```

#### Property Value

 [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_TotalBindCount"></a> TotalBindCount

The total number of times this texture has been bound, ever.

```csharp
ulong TotalBindCount { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_UploadComplete"></a> UploadComplete

Whether the latest data has been uploaded.

```csharp
bool UploadComplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_Width"></a> Width

The width of the texture.

```csharp
int Width { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_FlushUploads"></a> FlushUploads\(\)

Flush any unprocessed uploads without actually uploading.

```csharp
void FlushUploads()
```

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_GetByteSize"></a> GetByteSize\(\)

The size of this texture in bytes.

```csharp
int GetByteSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_SetData_osu_Framework_Graphics_Textures_ITextureUpload_"></a> SetData\(ITextureUpload\)

Sets the pixel data of the texture.

```csharp
void SetData(ITextureUpload upload)
```

#### Parameters

`upload` [ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md)

The <xref href="osu.Framework.Graphics.Textures.ITextureUpload" data-throw-if-not-resolved="false"></xref> containing the data.

### <a id="osu_Framework_Graphics_Rendering_INativeTexture_Upload"></a> Upload\(\)

Uploads this texture.

```csharp
bool Upload()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether any uploads occurred.

