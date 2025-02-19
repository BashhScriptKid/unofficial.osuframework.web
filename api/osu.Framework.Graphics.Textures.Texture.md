# <a id="osu_Framework_Graphics_Textures_Texture"></a> Class Texture

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

```csharp
public class Texture : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Texture](osu.Framework.Graphics.Textures.Texture.md)

#### Derived

[DisposableTexture](osu.Framework.Graphics.Textures.DisposableTexture.md), 
[TextureRegion](osu.Framework.Graphics.Textures.TextureRegion.md)

#### Implements

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

[ObjectExtensions.AsNonNull<Texture\>\(Texture?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Texture\>\(Texture\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Texture\>\(Texture\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Texture\>\(Texture\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Texture, TChild\>\(Texture, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Texture, TChild\>\(Texture, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Texture, TChild\>\(Texture, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Texture\>\(Texture\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_Texture__ctor_osu_Framework_Graphics_Textures_Texture_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> Texture\(Texture, WrapMode, WrapMode\)

Creates a new texture using the same backing texture as another <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public Texture(Texture parent, WrapMode wrapModeS = WrapMode.None, WrapMode wrapModeT = WrapMode.None)
```

#### Parameters

`parent` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The other <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in horizontal direction.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in vertical direction.

## Fields

### <a id="osu_Framework_Graphics_Textures_Texture_AssetName"></a> AssetName

```csharp
public string AssetName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Textures_Texture_ScaleAdjust"></a> ScaleAdjust

At what multiple of our expected resolution is our underlying texture?

```csharp
public float ScaleAdjust
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Textures_Texture_WrapModeS"></a> WrapModeS

The texture wrap mode in horizontal direction.

```csharp
public readonly WrapMode WrapModeS
```

#### Field Value

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

### <a id="osu_Framework_Graphics_Textures_Texture_WrapModeT"></a> WrapModeT

The texture wrap mode in vertical direction.

```csharp
public readonly WrapMode WrapModeT
```

#### Field Value

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

## Properties

### <a id="osu_Framework_Graphics_Textures_Texture_Available"></a> Available

Whether <xref href="osu.Framework.Graphics.Textures.Texture.NativeTexture" data-throw-if-not-resolved="false"></xref> is in a usable state.

```csharp
public virtual bool Available { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Textures_Texture_BypassTextureUploadQueueing"></a> BypassTextureUploadQueueing

By default, texture uploads are queued for upload at the beginning of each frame, allowing loading them ahead of time.
When this is true, this will be bypassed and textures will only be uploaded on use. Should be set for every-frame texture uploads
to avoid overloading the global queue.

```csharp
public bool BypassTextureUploadQueueing { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Textures_Texture_DisplayHeight"></a> DisplayHeight

The height of this texture when drawn to the screen.

```csharp
public float DisplayHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Textures_Texture_DisplaySize"></a> DisplaySize

The size of this texture when drawn to the screen.

```csharp
public Vector2 DisplaySize { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Textures_Texture_DisplayWidth"></a> DisplayWidth

The width of this texture when drawn to the screen.

```csharp
public float DisplayWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Textures_Texture_Height"></a> Height

The height of this <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual int Height { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Textures_Texture_Opacity"></a> Opacity

The texture opacity.

```csharp
public Opacity Opacity { get; protected set; }
```

#### Property Value

 [Opacity](osu.Framework.Graphics.Textures.Opacity.md)

### <a id="osu_Framework_Graphics_Textures_Texture_Size"></a> Size

The size of this <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 Size { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Textures_Texture_UploadComplete"></a> UploadComplete

Whether the latest data has been uploaded.

```csharp
public bool UploadComplete { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Textures_Texture_Width"></a> Width

The width of this <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual int Width { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Textures_Texture_Bind_System_Int32_"></a> Bind\(int\)

Binds this texture for drawing.

```csharp
public bool Bind(int unit = 0)
```

#### Parameters

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be bound.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the texture was successfully bound.

### <a id="osu_Framework_Graphics_Textures_Texture_Bind_System_Int32_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> Bind\(int, WrapMode, WrapMode\)

Binds this texture for drawing.

```csharp
public bool Bind(int unit, WrapMode wrapModeS, WrapMode wrapModeT)
```

#### Parameters

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be bound.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The horizontal wrap mode.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The vertical wrap mode.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the texture was successfully bound.

### <a id="osu_Framework_Graphics_Textures_Texture_ComputeOpacity_osu_Framework_Graphics_Textures_ITextureUpload_"></a> ComputeOpacity\(ITextureUpload\)

```csharp
protected static Opacity ComputeOpacity(ITextureUpload upload)
```

#### Parameters

`upload` [ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md)

#### Returns

 [Opacity](osu.Framework.Graphics.Textures.Opacity.md)

### <a id="osu_Framework_Graphics_Textures_Texture_Crop_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Axes_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> Crop\(RectangleF, Axes, WrapMode, WrapMode\)

Crop the texture.

```csharp
public Texture Crop(RectangleF cropRectangle, Axes relativeSizeAxes = Axes.None, WrapMode wrapModeS = WrapMode.None, WrapMode wrapModeT = WrapMode.None)
```

#### Parameters

`cropRectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The rectangle the cropped texture should reference.

`relativeSizeAxes` [Axes](osu.Framework.Graphics.Axes.md)

Which axes have a relative size in [0,1] in relation to the texture size.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in horizontal direction.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in vertical direction.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

The cropped texture.

### <a id="osu_Framework_Graphics_Textures_Texture_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Textures_Texture_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Textures_Texture_FromStream_osu_Framework_Graphics_Rendering_IRenderer_System_IO_Stream_osu_Framework_Graphics_Textures_TextureAtlas_"></a> FromStream\(IRenderer, Stream?, TextureAtlas?\)

Creates a texture from a data stream representing a bitmap.

```csharp
public static Texture? FromStream(IRenderer renderer, Stream? stream, TextureAtlas? atlas = null)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)?

The data stream containing the texture data.

`atlas` [TextureAtlas](osu.Framework.Graphics.Textures.TextureAtlas.md)?

The atlas to add the texture to.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)?

The created texture.

### <a id="osu_Framework_Graphics_Textures_Texture_GetTextureRect_System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__"></a> GetTextureRect\(RectangleF?\)

Computes the UV coordinates of a sub-area of this texture.

```csharp
public virtual RectangleF GetTextureRect(RectangleF? area = null)
```

#### Parameters

`area` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

A display-space area of this texture to compute the UV coordinates of.<br />
    The full area is used if not provided: (0, 0, <xref href="osu.Framework.Graphics.Textures.Texture.DisplayWidth" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Textures.Texture.DisplayHeight" data-throw-if-not-resolved="false"></xref>).

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The UV coordinates of <code class="paramref">area</code> in this texture.

### <a id="osu_Framework_Graphics_Textures_Texture_SetData_osu_Framework_Graphics_Textures_ITextureUpload_"></a> SetData\(ITextureUpload\)

Queue a <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref> to be uploaded on the draw thread.
The provided upload will be disposed after the upload is completed.

```csharp
public void SetData(ITextureUpload upload)
```

#### Parameters

`upload` [ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md)

The texture data to upload.

### <a id="osu_Framework_Graphics_Textures_Texture_SetData_osu_Framework_Graphics_Textures_ITextureUpload_osu_Framework_Graphics_Textures_Opacity_"></a> SetData\(ITextureUpload, Opacity\)

Queue a <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref> to be uploaded on the draw thread.
The provided upload will be disposed after the upload is completed.

```csharp
public void SetData(ITextureUpload upload, Opacity opacity)
```

#### Parameters

`upload` [ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md)

The texture data to upload.

`opacity` [Opacity](osu.Framework.Graphics.Textures.Opacity.md)

The texture's opacity, if known.

### <a id="osu_Framework_Graphics_Textures_Texture_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="osu_Framework_Graphics_Textures_Texture_UpdateOpacity_osu_Framework_Graphics_Textures_ITextureUpload_System_Nullable_osu_Framework_Graphics_Textures_Opacity___"></a> UpdateOpacity\(ITextureUpload, ref Opacity?\)

```csharp
protected void UpdateOpacity(ITextureUpload upload, ref Opacity? uploadOpacity)
```

#### Parameters

`upload` [ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md)

`uploadOpacity` [Opacity](osu.Framework.Graphics.Textures.Opacity.md)?

