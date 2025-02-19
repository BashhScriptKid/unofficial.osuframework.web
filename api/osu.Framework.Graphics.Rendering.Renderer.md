# <a id="osu_Framework_Graphics_Rendering_Renderer"></a> Class Renderer

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

Represents a base <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref> implementation for working renderers.

```csharp
public abstract class Renderer : IRenderer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Renderer](osu.Framework.Graphics.Rendering.Renderer.md)

#### Derived

[DummyRenderer](osu.Framework.Graphics.Rendering.Dummy.DummyRenderer.md)

#### Implements

[IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Renderer\>\(Renderer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[RendererExtensions.DrawClipped<T\>\(IRenderer, ref T, Texture, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawClipped\_\_1\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_\_\_0\_\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[RendererExtensions.DrawFrameBuffer\(IRenderer, IFrameBuffer, Quad, ColourInfo, Action<TexturedVertex2D\>?, Vector2?, Vector2?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Rendering\_IFrameBuffer\_osu\_Framework\_Graphics\_Primitives\_Quad\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osuTK\_Vector2\_\_), 
[RendererExtensions.DrawQuad\(IRenderer, Texture, Quad, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawQuad\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Primitives\_Quad\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[RendererExtensions.DrawTriangle\(IRenderer, Texture, Triangle, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawTriangle\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Primitives\_Triangle\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Renderer\>\(Renderer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Renderer\>\(Renderer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Renderer\>\(Renderer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[RendererExtensions.PopLocalMatrix\(IRenderer\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PopLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[RendererExtensions.PopOrtho\(IRenderer\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PopOrtho\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[RendererExtensions.PushLocalMatrix\(IRenderer, Matrix4\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osuTK\_Matrix4\_), 
[RendererExtensions.PushLocalMatrix\(IRenderer, Matrix3\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osuTK\_Matrix3\_), 
[RendererExtensions.PushOrtho\(IRenderer, RectangleF\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushOrtho\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[ContainerExtensions.WithChild<Renderer, TChild\>\(Renderer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Renderer, TChild\>\(Renderer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Renderer, TChild\>\(Renderer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Renderer\>\(Renderer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_Renderer__ctor"></a> Renderer\(\)

```csharp
protected Renderer()
```

## Properties

### <a id="osu_Framework_Graphics_Rendering_Renderer_AllowTearing"></a> AllowTearing

```csharp
protected abstract bool AllowTearing { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CacheStorage"></a> CacheStorage

```csharp
protected Storage? CacheStorage { set; }
```

#### Property Value

 [Storage](osu.Framework.Platform.Storage.md)?

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentBlendingMask"></a> CurrentBlendingMask

```csharp
protected BlendingMask CurrentBlendingMask { get; }
```

#### Property Value

 [BlendingMask](osu.Framework.Graphics.BlendingMask.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentBlendingParameters"></a> CurrentBlendingParameters

```csharp
public BlendingParameters CurrentBlendingParameters { get; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentClearInfo"></a> CurrentClearInfo

```csharp
protected ClearInfo CurrentClearInfo { get; }
```

#### Property Value

 [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentDepthInfo"></a> CurrentDepthInfo

The current depth parameters.

```csharp
public DepthInfo CurrentDepthInfo { get; }
```

#### Property Value

 [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentMaskingInfo"></a> CurrentMaskingInfo

The current masking parameters.

```csharp
public ref readonly MaskingInfo CurrentMaskingInfo { get; }
```

#### Property Value

 [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentStencilInfo"></a> CurrentStencilInfo

The current stencil parameters.

```csharp
public StencilInfo CurrentStencilInfo { get; }
```

#### Property Value

 [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentWrapModeS"></a> CurrentWrapModeS

The current horizontal texture wrap mode.

```csharp
public WrapMode CurrentWrapModeS { get; }
```

#### Property Value

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_CurrentWrapModeT"></a> CurrentWrapModeT

The current vertical texture wrap mode.

```csharp
public WrapMode CurrentWrapModeT { get; }
```

#### Property Value

 [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_FrameBuffer"></a> FrameBuffer

The current framebuffer, or null if the backbuffer is used.

```csharp
protected IFrameBuffer? FrameBuffer { get; }
```

#### Property Value

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)?

### <a id="osu_Framework_Graphics_Rendering_Renderer_FrameIndex"></a> FrameIndex

The current frame index.

```csharp
public ulong FrameIndex { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="osu_Framework_Graphics_Rendering_Renderer_IsClipSpaceYInverted"></a> IsClipSpaceYInverted

Whether the y-coordinate ranges from -1 (top) to 1 (bottom). If <code>false</code>, the y-coordinate ranges from -1 (bottom) to 1 (top).

```csharp
public abstract bool IsClipSpaceYInverted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_IsDepthRangeZeroToOne"></a> IsDepthRangeZeroToOne

Whether the depth is in the range [0, 1] (i.e. Reversed-Z). If <code>false</code>, depth is in the range [-1, 1].

```csharp
public abstract bool IsDepthRangeZeroToOne { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_IsInitialised"></a> IsInitialised

Whether this <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref> has been initialised using <xref href="osu.Framework.Graphics.Rendering.IRenderer.Initialise(osu.Framework.Platform.IGraphicsSurface)" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool IsInitialised { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_IsMaskingActive"></a> IsMaskingActive

Whether any masking parameters are currently applied.

```csharp
public bool IsMaskingActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_IsUvOriginTopLeft"></a> IsUvOriginTopLeft

Whether the texture coordinates begin in the top-left of the texture. If <code>false</code>, (0, 0) corresponds to the bottom-left texel of the texture.

```csharp
public abstract bool IsUvOriginTopLeft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_MaxPixelsUploadedPerFrame"></a> MaxPixelsUploadedPerFrame

The maximum number of pixels to upload per frame.
Defaults to 2 megapixels (8mb alloc).

```csharp
public int MaxPixelsUploadedPerFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Renderer_MaxTextureSize"></a> MaxTextureSize

The maximum allowed texture size.

```csharp
public int MaxTextureSize { get; protected set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Renderer_MaxTexturesUploadedPerFrame"></a> MaxTexturesUploadedPerFrame

The maximum number of texture uploads to dequeue and upload per frame.
Defaults to 32.

```csharp
public int MaxTexturesUploadedPerFrame { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Renderer_ProjectionMatrix"></a> ProjectionMatrix

The current projection matrix.

```csharp
public Matrix4 ProjectionMatrix { get; }
```

#### Property Value

 Matrix4

### <a id="osu_Framework_Graphics_Rendering_Renderer_Scissor"></a> Scissor

The current scissor rectangle.

```csharp
public RectangleI Scissor { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_ScissorOffset"></a> ScissorOffset

The current scissor offset.

```csharp
public Vector2I ScissorOffset { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_ScissorState"></a> ScissorState

Whether scissor is currently enabled.

```csharp
protected bool ScissorState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_Shader"></a> Shader

The current shader, or null if no shader is currently bound.

```csharp
protected IShader? Shader { get; }
```

#### Property Value

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)?

### <a id="osu_Framework_Graphics_Rendering_Renderer_UsingBackbuffer"></a> UsingBackbuffer

Whether the currently bound framebuffer is the backbuffer.

```csharp
public bool UsingBackbuffer { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_VerticalSync"></a> VerticalSync

```csharp
protected abstract bool VerticalSync { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Renderer_Viewport"></a> Viewport

The current viewport.

```csharp
public RectangleI Viewport { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_WhitePixel"></a> WhitePixel

The texture for a white pixel.

```csharp
public Texture WhitePixel { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

## Methods

### <a id="osu_Framework_Graphics_Rendering_Renderer_BeginFrame_osuTK_Vector2_"></a> BeginFrame\(Vector2\)

Resets any states to prepare for drawing a new frame.

```csharp
protected virtual void BeginFrame(Vector2 windowSize)
```

#### Parameters

`windowSize` Vector2

The full window size.

### <a id="osu_Framework_Graphics_Rendering_Renderer_BindFrameBuffer_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> BindFrameBuffer\(IFrameBuffer\)

```csharp
public void BindFrameBuffer(IFrameBuffer frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_BindShader_osu_Framework_Graphics_Shaders_IShader_"></a> BindShader\(IShader\)

```csharp
public void BindShader(IShader shader)
```

#### Parameters

`shader` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_BindTexture_osu_Framework_Graphics_Textures_Texture_System_Int32_System_Nullable_osu_Framework_Graphics_Textures_WrapMode__System_Nullable_osu_Framework_Graphics_Textures_WrapMode__"></a> BindTexture\(Texture, int, WrapMode?, WrapMode?\)

Binds a texture.

```csharp
public bool BindTexture(Texture texture, int unit, WrapMode? wrapModeS, WrapMode? wrapModeT)
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

### <a id="osu_Framework_Graphics_Rendering_Renderer_BindTexture_osu_Framework_Graphics_Rendering_INativeTexture_System_Int32_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> BindTexture\(INativeTexture, int, WrapMode, WrapMode\)

Binds a native texture. Generally used by internal components of renderer implementations.

```csharp
public bool BindTexture(INativeTexture texture, int unit = 0, WrapMode wrapModeS = WrapMode.None, WrapMode wrapModeT = WrapMode.None)
```

#### Parameters

`texture` [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)

The native texture to bind.

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be bound.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture's horizontal wrap mode.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture's vertex wrap mode.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the texture was successfully bound.

### <a id="osu_Framework_Graphics_Rendering_Renderer_BindUniformBuffer_System_String_osu_Framework_Graphics_Rendering_IUniformBuffer_"></a> BindUniformBuffer\(string, IUniformBuffer\)

```csharp
public void BindUniformBuffer(string blockName, IUniformBuffer buffer)
```

#### Parameters

`blockName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buffer` [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_Clear_osu_Framework_Graphics_Rendering_ClearInfo_"></a> Clear\(ClearInfo\)

Clears the currently bound frame buffer.

```csharp
public void Clear(ClearInfo clearInfo)
```

#### Parameters

`clearInfo` [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

The clearing parameters.

### <a id="osu_Framework_Graphics_Rendering_Renderer_ClearCurrent"></a> ClearCurrent\(\)

Invoked when the rendering thread is suspended and no more commands will be enqueued.
This is mainly required for OpenGL renderers to mark context as current before performing GL calls.

```csharp
protected abstract void ClearCurrent()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_ClearImplementation_osu_Framework_Graphics_Rendering_ClearInfo_"></a> ClearImplementation\(ClearInfo\)

Informs the graphics device to clear the color and depth targets of the currently bound framebuffer.

```csharp
protected abstract void ClearImplementation(ClearInfo clearInfo)
```

#### Parameters

`clearInfo` [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

The clear parameters.

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateFrameBuffer_osu_Framework_Graphics_Rendering_RenderBufferFormat___osu_Framework_Graphics_Textures_TextureFilteringMode_"></a> CreateFrameBuffer\(RenderBufferFormat\[\]?, TextureFilteringMode\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>.

```csharp
public abstract IFrameBuffer CreateFrameBuffer(RenderBufferFormat[]? renderBufferFormats = null, TextureFilteringMode filteringMode = TextureFilteringMode.Linear)
```

#### Parameters

`renderBufferFormats` [RenderBufferFormat](osu.Framework.Graphics.Rendering.RenderBufferFormat.md)\[\]?

Any render buffer formats.

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

The texture filtering mode.

#### Returns

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

The <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateLinearBatch__1_System_Int32_System_Int32_osu_Framework_Graphics_Rendering_PrimitiveTopology_"></a> CreateLinearBatch<TVertex\>\(int, int, PrimitiveTopology\)

Creates a new linear vertex batch, accepting vertices and drawing as a given primitive type.

```csharp
protected abstract IVertexBatch<TVertex> CreateLinearBatch<TVertex>(int size, int maxBuffers, PrimitiveTopology topology) where TVertex : unmanaged, IEquatable<TVertex>, IVertex
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

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateNativeTexture_System_Int32_System_Int32_System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_System_Nullable_osuTK_Graphics_Color4__"></a> CreateNativeTexture\(int, int, bool, TextureFilteringMode, Color4?\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract INativeTexture CreateNativeTexture(int width, int height, bool manualMipmaps = false, TextureFilteringMode filteringMode = TextureFilteringMode.Linear, Color4? initialisationColour = null)
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

`initialisationColour` Color4?

The colour to initialise texture levels with (in the case of sub region initial uploads). If null, no initialisation is provided out-of-the-box.

#### Returns

 [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)

The <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateNativeVideoTexture_System_Int32_System_Int32_"></a> CreateNativeVideoTexture\(int, int\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref> for video sprites.

```csharp
protected abstract INativeTexture CreateNativeVideoTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the texture.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the texture.

#### Returns

 [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)

The video <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateQuadBatch__1_System_Int32_System_Int32_"></a> CreateQuadBatch<TVertex\>\(int, int\)

Creates a new quad vertex batch, accepting vertices and drawing as quads.

```csharp
protected abstract IVertexBatch<TVertex> CreateQuadBatch<TVertex>(int size, int maxBuffers) where TVertex : unmanaged, IEquatable<TVertex>, IVertex
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

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateShader_System_String_osu_Framework_Graphics_Rendering_IShaderPart___osu_Framework_Graphics_Shaders_ShaderCompilationStore_"></a> CreateShader\(string, IShaderPart\[\], ShaderCompilationStore\)

Creates a new <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract IShader CreateShader(string name, IShaderPart[] parts, ShaderCompilationStore compilationStore)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the shader.

`parts` [IShaderPart](osu.Framework.Graphics.Rendering.IShaderPart.md)\[\]

The <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref>s associated with this shader.

`compilationStore` [ShaderCompilationStore](osu.Framework.Graphics.Shaders.ShaderCompilationStore.md)

#### Returns

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)

The <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateShaderPart_osu_Framework_Graphics_Shaders_IShaderStore_System_String_System_Byte___osu_Framework_Graphics_Shaders_ShaderPartType_"></a> CreateShaderPart\(IShaderStore, string, byte\[\]?, ShaderPartType\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract IShaderPart CreateShaderPart(IShaderStore store, string name, byte[]? rawData, ShaderPartType partType)
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

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateShaderStorageBufferObject__1_System_Int32_System_Int32_"></a> CreateShaderStorageBufferObject<TData\>\(int, int\)

Creates a buffer that can be used to store an array of data for use in a <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract IShaderStorageBufferObject<TData> CreateShaderStorageBufferObject<TData>(int uboSize, int ssboSize) where TData : unmanaged, IEquatable<TData>
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

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateTexture_System_Int32_System_Int32_System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_System_Nullable_osuTK_Graphics_Color4__"></a> CreateTexture\(int, int, bool, TextureFilteringMode, WrapMode, WrapMode, Color4?\)

Creates a new <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public Texture CreateTexture(int width, int height, bool manualMipmaps, TextureFilteringMode filteringMode, WrapMode wrapModeS, WrapMode wrapModeT, Color4? initialisationColour)
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

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateUniformBuffer__1"></a> CreateUniformBuffer<TData\>\(\)

Creates a buffer that stores data for a uniform block of a <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract IUniformBuffer<TData> CreateUniformBuffer<TData>() where TData : unmanaged, IEquatable<TData>
```

#### Returns

 [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer\-1.md)<TData\>

#### Type Parameters

`TData` 

The type of data in the buffer.

### <a id="osu_Framework_Graphics_Rendering_Renderer_CreateVideoTexture_System_Int32_System_Int32_"></a> CreateVideoTexture\(int, int\)

Creates a new video texture.

```csharp
public Texture CreateVideoTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_DeleteFrameBuffer_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> DeleteFrameBuffer\(IFrameBuffer\)

Deletes a frame buffer.

```csharp
public void DeleteFrameBuffer(IFrameBuffer frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

The frame buffer to delete.

### <a id="osu_Framework_Graphics_Rendering_Renderer_DeleteFrameBufferImplementation_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> DeleteFrameBufferImplementation\(IFrameBuffer\)

```csharp
protected abstract void DeleteFrameBufferImplementation(IFrameBuffer frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_DrawVertices_osu_Framework_Graphics_Rendering_PrimitiveTopology_System_Int32_System_Int32_"></a> DrawVertices\(PrimitiveTopology, int, int\)

```csharp
public void DrawVertices(PrimitiveTopology topology, int vertexStart, int verticesCount)
```

#### Parameters

`topology` [PrimitiveTopology](osu.Framework.Graphics.Rendering.PrimitiveTopology.md)

`vertexStart` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`verticesCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Renderer_DrawVerticesImplementation_osu_Framework_Graphics_Rendering_PrimitiveTopology_System_Int32_System_Int32_"></a> DrawVerticesImplementation\(PrimitiveTopology, int, int\)

```csharp
public abstract void DrawVerticesImplementation(PrimitiveTopology topology, int vertexStart, int verticesCount)
```

#### Parameters

`topology` [PrimitiveTopology](osu.Framework.Graphics.Rendering.PrimitiveTopology.md)

`vertexStart` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`verticesCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Renderer_FinishFrame"></a> FinishFrame\(\)

Performs any last actions before a frame ends.

```csharp
protected virtual void FinishFrame()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_FlushCurrentBatch_System_Nullable_osu_Framework_Graphics_Rendering_FlushBatchSource__"></a> FlushCurrentBatch\(FlushBatchSource?\)

Flushes the currently active vertex batch.

```csharp
protected void FlushCurrentBatch(FlushBatchSource? source)
```

#### Parameters

`source` [FlushBatchSource](osu.Framework.Graphics.Rendering.FlushBatchSource.md)?

The source performing the flush, for profiling purposes.

### <a id="osu_Framework_Graphics_Rendering_Renderer_Initialise_osu_Framework_Platform_IGraphicsSurface_"></a> Initialise\(IGraphicsSurface\)

Performs a once-off initialisation of this <xref href="osu.Framework.Graphics.Rendering.Renderer" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract void Initialise(IGraphicsSurface graphicsSurface)
```

#### Parameters

`graphicsSurface` [IGraphicsSurface](osu.Framework.Platform.IGraphicsSurface.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_MakeCurrent"></a> MakeCurrent\(\)

Invoked when the rendering thread is active and commands will be enqueued.
This is mainly required for OpenGL renderers to mark context as current before performing GL calls.

```csharp
protected abstract void MakeCurrent()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopDepthInfo"></a> PopDepthInfo\(\)

Restores the last depth parameters.

```csharp
public void PopDepthInfo()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopMaskingInfo"></a> PopMaskingInfo\(\)

Restores the last masking parameters.

```csharp
public void PopMaskingInfo()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopProjectionMatrix"></a> PopProjectionMatrix\(\)

Restores the last projection matrix.

```csharp
public void PopProjectionMatrix()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopScissor"></a> PopScissor\(\)

Restores the last scissor rectangle.

```csharp
public void PopScissor()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopScissorOffset"></a> PopScissorOffset\(\)

Restores the last scissor offset.

```csharp
public void PopScissorOffset()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopScissorState"></a> PopScissorState\(\)

Restores the last scissor test enablement state.

```csharp
public void PopScissorState()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopStencilInfo"></a> PopStencilInfo\(\)

Restores the last stencil parameters.

```csharp
public void PopStencilInfo()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PopViewport"></a> PopViewport\(\)

Restores the last viewport rectangle.

```csharp
public void PopViewport()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushDepthInfo_osu_Framework_Graphics_Rendering_DepthInfo_"></a> PushDepthInfo\(DepthInfo\)

Applies new depth parameters.

```csharp
public void PushDepthInfo(DepthInfo depthInfo)
```

#### Parameters

`depthInfo` [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

The depth parameters.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushMaskingInfo_osu_Framework_Graphics_Rendering_MaskingInfo__System_Boolean_"></a> PushMaskingInfo\(in MaskingInfo, bool\)

Applies new masking parameters.

```csharp
public void PushMaskingInfo(in MaskingInfo maskingInfo, bool overwritePreviousScissor = false)
```

#### Parameters

`maskingInfo` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

The masking parameters.

`overwritePreviousScissor` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to use the last scissor rectangle.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushProjectionMatrix_osuTK_Matrix4_"></a> PushProjectionMatrix\(Matrix4\)

Applies a new projection matrix.

```csharp
public void PushProjectionMatrix(Matrix4 matrix)
```

#### Parameters

`matrix` Matrix4

The matrix.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushScissor_osu_Framework_Graphics_Primitives_RectangleI_"></a> PushScissor\(RectangleI\)

Applies a new scissor rectangle.

```csharp
public void PushScissor(RectangleI scissor)
```

#### Parameters

`scissor` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The scissor rectangle.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushScissorOffset_osu_Framework_Graphics_Primitives_Vector2I_"></a> PushScissorOffset\(Vector2I\)

Applies a new scissor offset to the scissor rectangle.

```csharp
public void PushScissorOffset(Vector2I offset)
```

#### Parameters

`offset` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

The scissor offset.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushScissorState_System_Boolean_"></a> PushScissorState\(bool\)

Applies a new scissor test enablement state.

```csharp
public void PushScissorState(bool enabled)
```

#### Parameters

`enabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the scissor test is enabled.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushStencilInfo_osu_Framework_Graphics_Rendering_StencilInfo_"></a> PushStencilInfo\(StencilInfo\)

Applies new stencil parameters.

```csharp
public void PushStencilInfo(StencilInfo stencilInfo)
```

#### Parameters

`stencilInfo` [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

The stencil parameters.

### <a id="osu_Framework_Graphics_Rendering_Renderer_PushViewport_osu_Framework_Graphics_Primitives_RectangleI_"></a> PushViewport\(RectangleI\)

Applies a new viewport rectangle.

```csharp
public void PushViewport(RectangleI viewport)
```

#### Parameters

`viewport` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The viewport rectangle.

### <a id="osu_Framework_Graphics_Rendering_Renderer_ScheduleDisposal__1_System_Action___0____0_"></a> ScheduleDisposal<T\>\(Action<T\>, T\)

Schedules a disposal action to be run on the next frame.

```csharp
public void ScheduleDisposal<T>(Action<T> disposalAction, T target)
```

#### Parameters

`disposalAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The disposal action.

`target` T

The target to be disposed.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Rendering_Renderer_ScheduleExpensiveOperation_osu_Framework_Threading_ScheduledDelegate_"></a> ScheduleExpensiveOperation\(ScheduledDelegate\)

Schedules an expensive operation to a queue from which a maximum of one operation is performed per frame.

```csharp
public void ScheduleExpensiveOperation(ScheduledDelegate operation)
```

#### Parameters

`operation` [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

The operation to schedule.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetBlend_osu_Framework_Graphics_BlendingParameters_"></a> SetBlend\(BlendingParameters\)

Sets the current blending state.

```csharp
public void SetBlend(BlendingParameters blendingParameters)
```

#### Parameters

`blendingParameters` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

The blending parameters.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetBlendImplementation_osu_Framework_Graphics_BlendingParameters_"></a> SetBlendImplementation\(BlendingParameters\)

Updates the graphics device with the new blending parameters.

```csharp
protected abstract void SetBlendImplementation(BlendingParameters blendingParameters)
```

#### Parameters

`blendingParameters` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

The blending parameters.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetBlendMask_osu_Framework_Graphics_BlendingMask_"></a> SetBlendMask\(BlendingMask\)

Sets a mask deciding which colour components are affected during blending.

```csharp
public void SetBlendMask(BlendingMask blendingMask)
```

#### Parameters

`blendingMask` [BlendingMask](osu.Framework.Graphics.BlendingMask.md)

The blending mask.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetBlendMaskImplementation_osu_Framework_Graphics_BlendingMask_"></a> SetBlendMaskImplementation\(BlendingMask\)

Updates the graphics device with the new blending mask.

```csharp
protected abstract void SetBlendMaskImplementation(BlendingMask blendingMask)
```

#### Parameters

`blendingMask` [BlendingMask](osu.Framework.Graphics.BlendingMask.md)

The blending mask.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetDepthInfoImplementation_osu_Framework_Graphics_Rendering_DepthInfo_"></a> SetDepthInfoImplementation\(DepthInfo\)

Updates the graphics device with new depth parameters.

```csharp
protected abstract void SetDepthInfoImplementation(DepthInfo depthInfo)
```

#### Parameters

`depthInfo` [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

The depth parameters to use.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetFrameBufferImplementation_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> SetFrameBufferImplementation\(IFrameBuffer?\)

Informs the graphics device to use the given framebuffer for drawing.

```csharp
protected abstract void SetFrameBufferImplementation(IFrameBuffer? frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)?

The framebuffer to use, or null to use the backbuffer (i.e. main framebuffer).

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetScissorImplementation_osu_Framework_Graphics_Primitives_RectangleI_"></a> SetScissorImplementation\(RectangleI\)

Updates the graphics device with a new scissor rectangle.

```csharp
protected abstract void SetScissorImplementation(RectangleI scissor)
```

#### Parameters

`scissor` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The scissor rectangle to use.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetScissorStateImplementation_System_Boolean_"></a> SetScissorStateImplementation\(bool\)

Updates the graphics device with the new scissor state.

```csharp
protected abstract void SetScissorStateImplementation(bool enabled)
```

#### Parameters

`enabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether scissor should be enabled.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetShaderImplementation_osu_Framework_Graphics_Shaders_IShader_"></a> SetShaderImplementation\(IShader\)

Informs the graphics device to use the given shader for drawing.

```csharp
protected abstract void SetShaderImplementation(IShader shader)
```

#### Parameters

`shader` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

The shader to use.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetStencilInfoImplementation_osu_Framework_Graphics_Rendering_StencilInfo_"></a> SetStencilInfoImplementation\(StencilInfo\)

Updates the graphics device with new stencil parameters.

```csharp
protected abstract void SetStencilInfoImplementation(StencilInfo stencilInfo)
```

#### Parameters

`stencilInfo` [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

The stencil parameters to use.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetTextureImplementation_osu_Framework_Graphics_Rendering_INativeTexture_System_Int32_"></a> SetTextureImplementation\(INativeTexture?, int\)

Informs the graphics device to use the given texture for drawing.

```csharp
protected abstract bool SetTextureImplementation(INativeTexture? texture, int unit)
```

#### Parameters

`texture` [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)?

The texture, or null to use default texture.

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be bound.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the texture was set successfully.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetUniformBufferImplementation_System_String_osu_Framework_Graphics_Rendering_IUniformBuffer_"></a> SetUniformBufferImplementation\(string, IUniformBuffer\)

```csharp
protected abstract void SetUniformBufferImplementation(string blockName, IUniformBuffer buffer)
```

#### Parameters

`blockName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buffer` [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetUniformImplementation__1_osu_Framework_Graphics_Shaders_IUniformWithValue___0__"></a> SetUniformImplementation<T\>\(IUniformWithValue<T\>\)

Informs the graphics device to update the value of the given uniform.

```csharp
protected abstract void SetUniformImplementation<T>(IUniformWithValue<T> uniform) where T : unmanaged, IEquatable<T>
```

#### Parameters

`uniform` [IUniformWithValue](osu.Framework.Graphics.Shaders.IUniformWithValue\-1.md)<T\>

The uniform to update.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Rendering_Renderer_SetViewportImplementation_osu_Framework_Graphics_Primitives_RectangleI_"></a> SetViewportImplementation\(RectangleI\)

Updates the graphics device with a new viewport rectangle.

```csharp
protected abstract void SetViewportImplementation(RectangleI viewport)
```

#### Parameters

`viewport` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The viewport to use.

### <a id="osu_Framework_Graphics_Rendering_Renderer_SwapBuffers"></a> SwapBuffers\(\)

Swaps the back buffer with the front buffer to display the new frame.

```csharp
protected abstract void SwapBuffers()
```

### <a id="osu_Framework_Graphics_Rendering_Renderer_TakeScreenshot"></a> TakeScreenshot\(\)

Returns an image containing the current content of the backbuffer, i.e. takes a screenshot.

```csharp
protected abstract Image<Rgba32> TakeScreenshot()
```

#### Returns

 Image<Rgba32\>

### <a id="osu_Framework_Graphics_Rendering_Renderer_UnbindFrameBuffer_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> UnbindFrameBuffer\(IFrameBuffer?\)

```csharp
public void UnbindFrameBuffer(IFrameBuffer? frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)?

### <a id="osu_Framework_Graphics_Rendering_Renderer_UnbindShader_osu_Framework_Graphics_Shaders_IShader_"></a> UnbindShader\(IShader\)

```csharp
public void UnbindShader(IShader shader)
```

#### Parameters

`shader` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

### <a id="osu_Framework_Graphics_Rendering_Renderer_UnbindTexture_System_Int32_"></a> UnbindTexture\(int\)

Unbinds any bound texture.

```csharp
public void UnbindTexture(int unit = 0)
```

#### Parameters

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be unbound.

### <a id="osu_Framework_Graphics_Rendering_Renderer_WaitUntilIdle"></a> WaitUntilIdle\(\)

Waits until all renderer commands have been fully executed GPU-side, as signaled by the graphics backend.

```csharp
protected abstract void WaitUntilIdle()
```

#### Remarks

This is equivalent to a <code>glFinish</code> call.

### <a id="osu_Framework_Graphics_Rendering_Renderer_WaitUntilNextFrameReady"></a> WaitUntilNextFrameReady\(\)

```csharp
protected abstract void WaitUntilNextFrameReady()
```

