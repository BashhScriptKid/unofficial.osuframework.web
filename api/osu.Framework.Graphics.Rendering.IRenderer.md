# <a id="osu_Framework_Graphics_Rendering_IRenderer"></a> Interface IRenderer

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

Draws to the screen.

```csharp
public interface IRenderer
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IRenderer\>\(IRenderer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[RendererExtensions.DrawClipped<T\>\(IRenderer, ref T, Texture, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawClipped\_\_1\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_\_\_0\_\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[RendererExtensions.DrawFrameBuffer\(IRenderer, IFrameBuffer, Quad, ColourInfo, Action<TexturedVertex2D\>?, Vector2?, Vector2?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Rendering\_IFrameBuffer\_osu\_Framework\_Graphics\_Primitives\_Quad\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osuTK\_Vector2\_\_), 
[RendererExtensions.DrawQuad\(IRenderer, Texture, Quad, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawQuad\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Primitives\_Quad\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[RendererExtensions.DrawTriangle\(IRenderer, Texture, Triangle, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawTriangle\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Primitives\_Triangle\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IRenderer\>\(IRenderer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IRenderer\>\(IRenderer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IRenderer\>\(IRenderer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[RendererExtensions.PopLocalMatrix\(IRenderer\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PopLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[RendererExtensions.PopOrtho\(IRenderer\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PopOrtho\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[RendererExtensions.PushLocalMatrix\(IRenderer, Matrix4\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osuTK\_Matrix4\_), 
[RendererExtensions.PushLocalMatrix\(IRenderer, Matrix3\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osuTK\_Matrix3\_), 
[RendererExtensions.PushOrtho\(IRenderer, RectangleF\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushOrtho\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[ContainerExtensions.WithChild<IRenderer, TChild\>\(IRenderer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IRenderer, TChild\>\(IRenderer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IRenderer, TChild\>\(IRenderer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IRenderer\>\(IRenderer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Rendering_IRenderer_INDICES_PER_QUAD"></a> INDICES\_PER\_QUAD

```csharp
public const int INDICES_PER_QUAD = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MAX_DRAW_NODES"></a> MAX\_DRAW\_NODES

Maximum number of <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> can draw with.
This is a carefully-chosen number to enable the update and draw threads to work concurrently without causing unnecessary load.

```csharp
public const int MAX_DRAW_NODES = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MAX_MIPMAP_LEVELS"></a> MAX\_MIPMAP\_LEVELS

```csharp
public const int MAX_MIPMAP_LEVELS = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MAX_QUADS"></a> MAX\_QUADS

Maximum number of quads in a quad vertex buffer.

```csharp
public const int MAX_QUADS = 10922
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MAX_VERTICES"></a> MAX\_VERTICES

Maximum number of vertices in a linear vertex buffer.

```csharp
public const int MAX_VERTICES = 65535
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_VERTICES_PER_QUAD"></a> VERTICES\_PER\_QUAD

```csharp
public const int VERTICES_PER_QUAD = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_VERTICES_PER_TRIANGLE"></a> VERTICES\_PER\_TRIANGLE

```csharp
public const int VERTICES_PER_TRIANGLE = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Rendering_IRenderer_AllowTearing"></a> AllowTearing

```csharp
bool AllowTearing { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CacheStorage"></a> CacheStorage

A <xref href="osu.Framework.Platform.Storage" data-throw-if-not-resolved="false"></xref> that can be used to cache objects.

```csharp
Storage? CacheStorage { set; }
```

#### Property Value

 [Storage](osu.Framework.Platform.Storage.md)?

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CurrentDepthInfo"></a> CurrentDepthInfo

The current depth parameters.

```csharp
DepthInfo CurrentDepthInfo { get; }
```

#### Property Value

 [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CurrentMaskingInfo"></a> CurrentMaskingInfo

The current masking parameters.

```csharp
ref readonly MaskingInfo CurrentMaskingInfo { get; }
```

#### Property Value

 [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CurrentStencilInfo"></a> CurrentStencilInfo

The current stencil parameters.

```csharp
StencilInfo CurrentStencilInfo { get; }
```

#### Property Value

 [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CurrentWrapModeS"></a> CurrentWrapModeS

The current horizontal texture wrap mode.

```csharp
WrapMode CurrentWrapModeS { get; }
```

#### Property Value

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CurrentWrapModeT"></a> CurrentWrapModeT

The current vertical texture wrap mode.

```csharp
WrapMode CurrentWrapModeT { get; }
```

#### Property Value

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_FrameIndex"></a> FrameIndex

The current frame index.

```csharp
ulong FrameIndex { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_IsClipSpaceYInverted"></a> IsClipSpaceYInverted

Whether the y-coordinate ranges from -1 (top) to 1 (bottom). If <code>false</code>, the y-coordinate ranges from -1 (bottom) to 1 (top).

```csharp
bool IsClipSpaceYInverted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_IsDepthRangeZeroToOne"></a> IsDepthRangeZeroToOne

Whether the depth is in the range [0, 1] (i.e. Reversed-Z). If <code>false</code>, depth is in the range [-1, 1].

```csharp
bool IsDepthRangeZeroToOne { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_IsInitialised"></a> IsInitialised

Whether this <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref> has been initialised using <xref href="osu.Framework.Graphics.Rendering.IRenderer.Initialise(osu.Framework.Platform.IGraphicsSurface)" data-throw-if-not-resolved="false"></xref>.

```csharp
bool IsInitialised { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_IsMaskingActive"></a> IsMaskingActive

Whether any masking parameters are currently applied.

```csharp
bool IsMaskingActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_IsUvOriginTopLeft"></a> IsUvOriginTopLeft

Whether the texture coordinates begin in the top-left of the texture. If <code>false</code>, (0, 0) corresponds to the bottom-left texel of the texture.

```csharp
bool IsUvOriginTopLeft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MaxPixelsUploadedPerFrame"></a> MaxPixelsUploadedPerFrame

The maximum number of pixels to upload per frame.
Defaults to 2 megapixels (8mb alloc).

```csharp
int MaxPixelsUploadedPerFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MaxTextureSize"></a> MaxTextureSize

The maximum allowed texture size.

```csharp
int MaxTextureSize { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MaxTexturesUploadedPerFrame"></a> MaxTexturesUploadedPerFrame

The maximum number of texture uploads to dequeue and upload per frame.
Defaults to 32.

```csharp
int MaxTexturesUploadedPerFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_ProjectionMatrix"></a> ProjectionMatrix

The current projection matrix.

```csharp
Matrix4 ProjectionMatrix { get; }
```

#### Property Value

 Matrix4

### <a id="osu_Framework_Graphics_Rendering_IRenderer_Scissor"></a> Scissor

The current scissor rectangle.

```csharp
RectangleI Scissor { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_ScissorOffset"></a> ScissorOffset

The current scissor offset.

```csharp
Vector2I ScissorOffset { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_UsingBackbuffer"></a> UsingBackbuffer

Whether the currently bound framebuffer is the backbuffer.

```csharp
bool UsingBackbuffer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_VerticalSync"></a> VerticalSync

Enables or disables vertical sync.

```csharp
bool VerticalSync { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_Viewport"></a> Viewport

The current viewport.

```csharp
RectangleI Viewport { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_WhitePixel"></a> WhitePixel

The texture for a white pixel.

```csharp
Texture WhitePixel { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

## Methods

### <a id="osu_Framework_Graphics_Rendering_IRenderer_BeginFrame_osuTK_Vector2_"></a> BeginFrame\(Vector2\)

Resets any states to prepare for drawing a new frame.

```csharp
void BeginFrame(Vector2 windowSize)
```

#### Parameters

`windowSize` Vector2

The full window size.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_BindTexture_osu_Framework_Graphics_Textures_Texture_System_Int32_System_Nullable_osu_Framework_Graphics_Textures_WrapMode__System_Nullable_osu_Framework_Graphics_Textures_WrapMode__"></a> BindTexture\(Texture, int, WrapMode?, WrapMode?\)

Binds a texture.

```csharp
bool BindTexture(Texture texture, int unit = 0, WrapMode? wrapModeS = null, WrapMode? wrapModeT = null)
```

#### Parameters

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to bind.

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be bound.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)?

The texture's horizontal wrap mode.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)?

The texture's vertex wrap mode.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the texture was successfully bound.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_Clear_osu_Framework_Graphics_Rendering_ClearInfo_"></a> Clear\(ClearInfo\)

Clears the currently bound frame buffer.

```csharp
void Clear(ClearInfo clearInfo)
```

#### Parameters

`clearInfo` [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

The clearing parameters.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_ClearCurrent"></a> ClearCurrent\(\)

Invoked when the rendering thread is suspended and no more commands will be enqueued.
This is mainly required for OpenGL renderers to mark context as current before performing GL calls.

```csharp
void ClearCurrent()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateFrameBuffer_osu_Framework_Graphics_Rendering_RenderBufferFormat___osu_Framework_Graphics_Textures_TextureFilteringMode_"></a> CreateFrameBuffer\(RenderBufferFormat\[\]?, TextureFilteringMode\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>.

```csharp
IFrameBuffer CreateFrameBuffer(RenderBufferFormat[]? renderBufferFormats = null, TextureFilteringMode filteringMode = TextureFilteringMode.Linear)
```

#### Parameters

`renderBufferFormats` [RenderBufferFormat](osu.Framework.Graphics.Rendering.RenderBufferFormat.md)\[\]?

Any render buffer formats.

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

The texture filtering mode.

#### Returns

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

The <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateLinearBatch__1_System_Int32_System_Int32_osu_Framework_Graphics_Rendering_PrimitiveTopology_"></a> CreateLinearBatch<TVertex\>\(int, int, PrimitiveTopology\)

Creates a new linear vertex batch, accepting vertices and drawing as a given primitive type.

```csharp
IVertexBatch<TVertex> CreateLinearBatch<TVertex>(int size, int maxBuffers, PrimitiveTopology topology) where TVertex : unmanaged, IEquatable<TVertex>, IVertex
```

#### Parameters

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Number of quads.

`maxBuffers` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Maximum number of vertex buffers.

`topology` [PrimitiveTopology](osu.Framework.Graphics.Rendering.PrimitiveTopology.md)

The type of primitive the vertices are drawn as.

#### Returns

 [IVertexBatch](osu.Framework.Graphics.Rendering.IVertexBatch\-1.md)<TVertex\>

#### Type Parameters

`TVertex` 

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateQuadBatch__1_System_Int32_System_Int32_"></a> CreateQuadBatch<TVertex\>\(int, int\)

Creates a new quad vertex batch, accepting vertices and drawing as quads.

```csharp
IVertexBatch<TVertex> CreateQuadBatch<TVertex>(int size, int maxBuffers) where TVertex : unmanaged, IEquatable<TVertex>, IVertex
```

#### Parameters

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Number of quads.

`maxBuffers` [int](https://learn.microsoft.com/dotnet/api/system.int32)

Maximum number of vertex buffers.

#### Returns

 [IVertexBatch](osu.Framework.Graphics.Rendering.IVertexBatch\-1.md)<TVertex\>

#### Type Parameters

`TVertex` 

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateShader_System_String_osu_Framework_Graphics_Rendering_IShaderPart___"></a> CreateShader\(string, IShaderPart\[\]\)

Creates a new <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
IShader CreateShader(string name, IShaderPart[] parts)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the shader.

`parts` [IShaderPart](osu.Framework.Graphics.Rendering.IShaderPart.md)\[\]

The <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref>s associated with this shader.

#### Returns

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)

The <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateShaderPart_osu_Framework_Graphics_Shaders_IShaderStore_System_String_System_Byte___osu_Framework_Graphics_Shaders_ShaderPartType_"></a> CreateShaderPart\(IShaderStore, string, byte\[\]?, ShaderPartType\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref>.

```csharp
IShaderPart CreateShaderPart(IShaderStore store, string name, byte[]? rawData, ShaderPartType partType)
```

#### Parameters

`store` [IShaderStore](osu.Framework.Graphics.Shaders.IShaderStore.md)

The shader store to load headers with.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the shader part.

`rawData` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]?

The content of the shader part.

`partType` [ShaderPartType](osu.Framework.Graphics.Shaders.ShaderPartType.md)

The type of the shader part.

#### Returns

 [IShaderPart](osu.Framework.Graphics.Rendering.IShaderPart.md)

The <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateShaderStorageBufferObject__1_System_Int32_System_Int32_"></a> CreateShaderStorageBufferObject<TData\>\(int, int\)

Creates a buffer that can be used to store an array of data for use in a <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
IShaderStorageBufferObject<TData> CreateShaderStorageBufferObject<TData>(int uboSize, int ssboSize) where TData : unmanaged, IEquatable<TData>
```

#### Parameters

`uboSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of elements this buffer should contain if Shader Storage Buffer Objects <b>are not</b> supported by the platform.
    A safe value is <code>16384/{data_size}</code>. The value must match the definition of the UBO implementation in the shader.

`ssboSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of elements this buffer should contain if Shader Storage Buffer Objects <b>are</b> supported by the platform.
    May be any value up to <code>{vram_size}/{data_size}</code>.

#### Returns

 [IShaderStorageBufferObject](osu.Framework.Graphics.Rendering.IShaderStorageBufferObject\-1.md)<TData\>

An <xref href="osu.Framework.Graphics.Rendering.IShaderStorageBufferObject%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`TData` 

The type of data to be stored in the buffer.

#### Remarks

<ul><li>Internally, this buffer may be implemented as either a "Uniform Buffer Object" (UBO) or
a "Shader Storage Buffer Object" (SSBO) depending on the capabilities of the platform.</li><li>UBOs are more broadly supported but cannot hold as much data as SSBOs.</li><li>Shaders must provide implementations for both types of buffers to properly support this storage.</li></ul>

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateTexture_System_Int32_System_Int32_System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_System_Nullable_osuTK_Graphics_Color4__"></a> CreateTexture\(int, int, bool, TextureFilteringMode, WrapMode, WrapMode, Color4?\)

Creates a new <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
Texture CreateTexture(int width, int height, bool manualMipmaps = false, TextureFilteringMode filteringMode = TextureFilteringMode.Linear, WrapMode wrapModeS = WrapMode.None, WrapMode wrapModeT = WrapMode.None, Color4? initialisationColour = null)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the texture.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the texture.

`manualMipmaps` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether manual mipmaps will be uploaded to the texture. If false, the texture will compute mipmaps automatically.

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

The filtering mode.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture's horizontal wrap mode.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture's vertex wrap mode.

`initialisationColour` Color4?

The colour to initialise texture levels with (in the case of sub region initial uploads). If null, no initialisation is provided out-of-the-box.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

The <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateUniformBuffer__1"></a> CreateUniformBuffer<TData\>\(\)

Creates a buffer that stores data for a uniform block of a <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
IUniformBuffer<TData> CreateUniformBuffer<TData>() where TData : unmanaged, IEquatable<TData>
```

#### Returns

 [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer\-1.md)<TData\>

#### Type Parameters

`TData` 

The type of data in the buffer.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_CreateVideoTexture_System_Int32_System_Int32_"></a> CreateVideoTexture\(int, int\)

Creates a new video texture.

```csharp
Texture CreateVideoTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_FinishFrame"></a> FinishFrame\(\)

Performs any last actions before a frame ends.

```csharp
void FinishFrame()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_Initialise_osu_Framework_Platform_IGraphicsSurface_"></a> Initialise\(IGraphicsSurface\)

Performs a once-off initialisation of this <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref>.

```csharp
void Initialise(IGraphicsSurface graphicsSurface)
```

#### Parameters

`graphicsSurface` [IGraphicsSurface](osu.Framework.Platform.IGraphicsSurface.md)

### <a id="osu_Framework_Graphics_Rendering_IRenderer_MakeCurrent"></a> MakeCurrent\(\)

Invoked when the rendering thread is active and commands will be enqueued.
This is mainly required for OpenGL renderers to mark context as current before performing GL calls.

```csharp
void MakeCurrent()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopDepthInfo"></a> PopDepthInfo\(\)

Restores the last depth parameters.

```csharp
void PopDepthInfo()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopMaskingInfo"></a> PopMaskingInfo\(\)

Restores the last masking parameters.

```csharp
void PopMaskingInfo()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopProjectionMatrix"></a> PopProjectionMatrix\(\)

Restores the last projection matrix.

```csharp
void PopProjectionMatrix()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopScissor"></a> PopScissor\(\)

Restores the last scissor rectangle.

```csharp
void PopScissor()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopScissorOffset"></a> PopScissorOffset\(\)

Restores the last scissor offset.

```csharp
void PopScissorOffset()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopScissorState"></a> PopScissorState\(\)

Restores the last scissor test enablement state.

```csharp
void PopScissorState()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopStencilInfo"></a> PopStencilInfo\(\)

Restores the last stencil parameters.

```csharp
void PopStencilInfo()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PopViewport"></a> PopViewport\(\)

Restores the last viewport rectangle.

```csharp
void PopViewport()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushDepthInfo_osu_Framework_Graphics_Rendering_DepthInfo_"></a> PushDepthInfo\(DepthInfo\)

Applies new depth parameters.

```csharp
void PushDepthInfo(DepthInfo depthInfo)
```

#### Parameters

`depthInfo` [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

The depth parameters.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushMaskingInfo_osu_Framework_Graphics_Rendering_MaskingInfo__System_Boolean_"></a> PushMaskingInfo\(in MaskingInfo, bool\)

Applies new masking parameters.

```csharp
void PushMaskingInfo(in MaskingInfo maskingInfo, bool overwritePreviousScissor = false)
```

#### Parameters

`maskingInfo` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

The masking parameters.

`overwritePreviousScissor` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to use the last scissor rectangle.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushProjectionMatrix_osuTK_Matrix4_"></a> PushProjectionMatrix\(Matrix4\)

Applies a new projection matrix.

```csharp
void PushProjectionMatrix(Matrix4 matrix)
```

#### Parameters

`matrix` Matrix4

The matrix.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushScissor_osu_Framework_Graphics_Primitives_RectangleI_"></a> PushScissor\(RectangleI\)

Applies a new scissor rectangle.

```csharp
void PushScissor(RectangleI scissor)
```

#### Parameters

`scissor` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The scissor rectangle.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushScissorOffset_osu_Framework_Graphics_Primitives_Vector2I_"></a> PushScissorOffset\(Vector2I\)

Applies a new scissor offset to the scissor rectangle.

```csharp
void PushScissorOffset(Vector2I offset)
```

#### Parameters

`offset` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

The scissor offset.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushScissorState_System_Boolean_"></a> PushScissorState\(bool\)

Applies a new scissor test enablement state.

```csharp
void PushScissorState(bool enabled)
```

#### Parameters

`enabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the scissor test is enabled.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushStencilInfo_osu_Framework_Graphics_Rendering_StencilInfo_"></a> PushStencilInfo\(StencilInfo\)

Applies new stencil parameters.

```csharp
void PushStencilInfo(StencilInfo stencilInfo)
```

#### Parameters

`stencilInfo` [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

The stencil parameters.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_PushViewport_osu_Framework_Graphics_Primitives_RectangleI_"></a> PushViewport\(RectangleI\)

Applies a new viewport rectangle.

```csharp
void PushViewport(RectangleI viewport)
```

#### Parameters

`viewport` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The viewport rectangle.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_ScheduleDisposal__1_System_Action___0____0_"></a> ScheduleDisposal<T\>\(Action<T\>, T\)

Schedules a disposal action to be run on the next frame.

```csharp
void ScheduleDisposal<T>(Action<T> disposalAction, T target)
```

#### Parameters

`disposalAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The disposal action.

`target` T

The target to be disposed.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Rendering_IRenderer_ScheduleExpensiveOperation_osu_Framework_Threading_ScheduledDelegate_"></a> ScheduleExpensiveOperation\(ScheduledDelegate\)

Schedules an expensive operation to a queue from which a maximum of one operation is performed per frame.

```csharp
void ScheduleExpensiveOperation(ScheduledDelegate operation)
```

#### Parameters

`operation` [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

The operation to schedule.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_SetBlend_osu_Framework_Graphics_BlendingParameters_"></a> SetBlend\(BlendingParameters\)

Sets the current blending state.

```csharp
void SetBlend(BlendingParameters blendingParameters)
```

#### Parameters

`blendingParameters` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

The blending parameters.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_SetBlendMask_osu_Framework_Graphics_BlendingMask_"></a> SetBlendMask\(BlendingMask\)

Sets a mask deciding which colour components are affected during blending.

```csharp
void SetBlendMask(BlendingMask blendingMask)
```

#### Parameters

`blendingMask` [BlendingMask](osu.Framework.Graphics.BlendingMask.md)

The blending mask.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_SwapBuffers"></a> SwapBuffers\(\)

Swaps the back buffer with the front buffer to display the new frame.

```csharp
void SwapBuffers()
```

### <a id="osu_Framework_Graphics_Rendering_IRenderer_TakeScreenshot"></a> TakeScreenshot\(\)

Returns an image containing the current content of the backbuffer, i.e. takes a screenshot.

```csharp
Image<Rgba32> TakeScreenshot()
```

#### Returns

 Image<Rgba32\>

### <a id="osu_Framework_Graphics_Rendering_IRenderer_WaitUntilIdle"></a> WaitUntilIdle\(\)

Waits until all renderer commands have been fully executed GPU-side, as signaled by the graphics backend.

```csharp
void WaitUntilIdle()
```

#### Remarks

This is equivalent to a <code>glFinish</code> call.

### <a id="osu_Framework_Graphics_Rendering_IRenderer_WaitUntilNextFrameReady"></a> WaitUntilNextFrameReady\(\)

Waits until the GPU signals that the next frame is ready to be rendered.

```csharp
void WaitUntilNextFrameReady()
```

