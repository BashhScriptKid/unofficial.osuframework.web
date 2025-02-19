# <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer"></a> Class DummyRenderer

Namespace: [osu.Framework.Graphics.Rendering.Dummy](osu.Framework.Graphics.Rendering.Dummy.md)  
Assembly: osu.Framework.dll  

An <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref> that does nothing. May be used for tests that don't have a visual output.

```csharp
public sealed class DummyRenderer : Renderer, IRenderer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Renderer](osu.Framework.Graphics.Rendering.Renderer.md) ← 
[DummyRenderer](osu.Framework.Graphics.Rendering.Dummy.DummyRenderer.md)

#### Implements

[IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

#### Inherited Members

[Renderer.MaxTextureSize](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_MaxTextureSize), 
[Renderer.MaxTexturesUploadedPerFrame](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_MaxTexturesUploadedPerFrame), 
[Renderer.MaxPixelsUploadedPerFrame](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_MaxPixelsUploadedPerFrame), 
[Renderer.IsDepthRangeZeroToOne](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_IsDepthRangeZeroToOne), 
[Renderer.IsUvOriginTopLeft](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_IsUvOriginTopLeft), 
[Renderer.IsClipSpaceYInverted](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_IsClipSpaceYInverted), 
[Renderer.FrameIndex](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_FrameIndex), 
[Renderer.CurrentMaskingInfo](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CurrentMaskingInfo), 
[Renderer.Viewport](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_Viewport), 
[Renderer.Scissor](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_Scissor), 
[Renderer.ScissorOffset](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_ScissorOffset), 
[Renderer.ProjectionMatrix](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_ProjectionMatrix), 
[Renderer.CurrentDepthInfo](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CurrentDepthInfo), 
[Renderer.CurrentStencilInfo](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CurrentStencilInfo), 
[Renderer.CurrentWrapModeS](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CurrentWrapModeS), 
[Renderer.CurrentWrapModeT](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CurrentWrapModeT), 
[Renderer.IsMaskingActive](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_IsMaskingActive), 
[Renderer.UsingBackbuffer](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_UsingBackbuffer), 
[Renderer.WhitePixel](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_WhitePixel), 
[Renderer.IsInitialised](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_IsInitialised), 
[Renderer.CurrentBlendingParameters](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CurrentBlendingParameters), 
[Renderer.ScheduleExpensiveOperation\(ScheduledDelegate\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_ScheduleExpensiveOperation\_osu\_Framework\_Threading\_ScheduledDelegate\_), 
[Renderer.ScheduleDisposal<T\>\(Action<T\>, T\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_ScheduleDisposal\_\_1\_System\_Action\_\_\_0\_\_\_\_0\_), 
[Renderer.Clear\(ClearInfo\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_Clear\_osu\_Framework\_Graphics\_Rendering\_ClearInfo\_), 
[Renderer.SetBlend\(BlendingParameters\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_SetBlend\_osu\_Framework\_Graphics\_BlendingParameters\_), 
[Renderer.SetBlendMask\(BlendingMask\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_SetBlendMask\_osu\_Framework\_Graphics\_BlendingMask\_), 
[Renderer.PushViewport\(RectangleI\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushViewport\_osu\_Framework\_Graphics\_Primitives\_RectangleI\_), 
[Renderer.PopViewport\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopViewport), 
[Renderer.PushScissor\(RectangleI\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushScissor\_osu\_Framework\_Graphics\_Primitives\_RectangleI\_), 
[Renderer.PushScissorState\(bool\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushScissorState\_System\_Boolean\_), 
[Renderer.PushScissorOffset\(Vector2I\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushScissorOffset\_osu\_Framework\_Graphics\_Primitives\_Vector2I\_), 
[Renderer.PopScissor\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopScissor), 
[Renderer.PopScissorState\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopScissorState), 
[Renderer.PopScissorOffset\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopScissorOffset), 
[Renderer.PushProjectionMatrix\(Matrix4\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushProjectionMatrix\_osuTK\_Matrix4\_), 
[Renderer.PopProjectionMatrix\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopProjectionMatrix), 
[Renderer.PushMaskingInfo\(in MaskingInfo, bool\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushMaskingInfo\_osu\_Framework\_Graphics\_Rendering\_MaskingInfo\_\_System\_Boolean\_), 
[Renderer.PopMaskingInfo\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopMaskingInfo), 
[Renderer.PushDepthInfo\(DepthInfo\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushDepthInfo\_osu\_Framework\_Graphics\_Rendering\_DepthInfo\_), 
[Renderer.PushStencilInfo\(StencilInfo\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PushStencilInfo\_osu\_Framework\_Graphics\_Rendering\_StencilInfo\_), 
[Renderer.PopDepthInfo\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopDepthInfo), 
[Renderer.PopStencilInfo\(\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_PopStencilInfo), 
[Renderer.BindTexture\(Texture, int, WrapMode?, WrapMode?\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_BindTexture\_osu\_Framework\_Graphics\_Textures\_Texture\_System\_Int32\_System\_Nullable\_osu\_Framework\_Graphics\_Textures\_WrapMode\_\_System\_Nullable\_osu\_Framework\_Graphics\_Textures\_WrapMode\_\_), 
[Renderer.BindTexture\(INativeTexture, int, WrapMode, WrapMode\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_BindTexture\_osu\_Framework\_Graphics\_Rendering\_INativeTexture\_System\_Int32\_osu\_Framework\_Graphics\_Textures\_WrapMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_), 
[Renderer.UnbindTexture\(int\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_UnbindTexture\_System\_Int32\_), 
[Renderer.BindFrameBuffer\(IFrameBuffer\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_BindFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_IFrameBuffer\_), 
[Renderer.UnbindFrameBuffer\(IFrameBuffer?\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_UnbindFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_IFrameBuffer\_), 
[Renderer.DeleteFrameBuffer\(IFrameBuffer\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_DeleteFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_IFrameBuffer\_), 
[Renderer.DrawVertices\(PrimitiveTopology, int, int\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_DrawVertices\_osu\_Framework\_Graphics\_Rendering\_PrimitiveTopology\_System\_Int32\_System\_Int32\_), 
[Renderer.DrawVerticesImplementation\(PrimitiveTopology, int, int\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_DrawVerticesImplementation\_osu\_Framework\_Graphics\_Rendering\_PrimitiveTopology\_System\_Int32\_System\_Int32\_), 
[Renderer.BindShader\(IShader\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_BindShader\_osu\_Framework\_Graphics\_Shaders\_IShader\_), 
[Renderer.UnbindShader\(IShader\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_UnbindShader\_osu\_Framework\_Graphics\_Shaders\_IShader\_), 
[Renderer.BindUniformBuffer\(string, IUniformBuffer\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_BindUniformBuffer\_System\_String\_osu\_Framework\_Graphics\_Rendering\_IUniformBuffer\_), 
[Renderer.CreateFrameBuffer\(RenderBufferFormat\[\]?, TextureFilteringMode\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CreateFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_RenderBufferFormat\_\_\_osu\_Framework\_Graphics\_Textures\_TextureFilteringMode\_), 
[Renderer.CreateTexture\(int, int, bool, TextureFilteringMode, WrapMode, WrapMode, Color4?\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CreateTexture\_System\_Int32\_System\_Int32\_System\_Boolean\_osu\_Framework\_Graphics\_Textures\_TextureFilteringMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_System\_Nullable\_osuTK\_Graphics\_Color4\_\_), 
[Renderer.CreateVideoTexture\(int, int\)](osu.Framework.Graphics.Rendering.Renderer.md\#osu\_Framework\_Graphics\_Rendering\_Renderer\_CreateVideoTexture\_System\_Int32\_System\_Int32\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DummyRenderer\>\(DummyRenderer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[RendererExtensions.DrawClipped<T\>\(IRenderer, ref T, Texture, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawClipped\_\_1\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_\_\_0\_\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[RendererExtensions.DrawFrameBuffer\(IRenderer, IFrameBuffer, Quad, ColourInfo, Action<TexturedVertex2D\>?, Vector2?, Vector2?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawFrameBuffer\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Rendering\_IFrameBuffer\_osu\_Framework\_Graphics\_Primitives\_Quad\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osuTK\_Vector2\_\_), 
[RendererExtensions.DrawQuad\(IRenderer, Texture, Quad, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawQuad\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Primitives\_Quad\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[RendererExtensions.DrawTriangle\(IRenderer, Texture, Triangle, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_DrawTriangle\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Textures\_Texture\_osu\_Framework\_Graphics\_Primitives\_Triangle\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_System\_Action\_osu\_Framework\_Graphics\_Rendering\_Vertices\_TexturedVertex2D\_\_System\_Nullable\_osuTK\_Vector2\_\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DummyRenderer\>\(DummyRenderer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DummyRenderer\>\(DummyRenderer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DummyRenderer\>\(DummyRenderer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[RendererExtensions.PopLocalMatrix\(IRenderer\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PopLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[RendererExtensions.PopOrtho\(IRenderer\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PopOrtho\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[RendererExtensions.PushLocalMatrix\(IRenderer, Matrix4\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osuTK\_Matrix4\_), 
[RendererExtensions.PushLocalMatrix\(IRenderer, Matrix3\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushLocalMatrix\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osuTK\_Matrix3\_), 
[RendererExtensions.PushOrtho\(IRenderer, RectangleF\)](osu.Framework.Graphics.Rendering.RendererExtensions.md\#osu\_Framework\_Graphics\_Rendering\_RendererExtensions\_PushOrtho\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[ContainerExtensions.WithChild<DummyRenderer, TChild\>\(DummyRenderer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DummyRenderer, TChild\>\(DummyRenderer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DummyRenderer, TChild\>\(DummyRenderer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DummyRenderer\>\(DummyRenderer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_AllowTearing"></a> AllowTearing

```csharp
protected override bool AllowTearing { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_IsClipSpaceYInverted"></a> IsClipSpaceYInverted

Whether the y-coordinate ranges from -1 (top) to 1 (bottom). If <code>false</code>, the y-coordinate ranges from -1 (bottom) to 1 (top).

```csharp
public override bool IsClipSpaceYInverted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_IsDepthRangeZeroToOne"></a> IsDepthRangeZeroToOne

Whether the depth is in the range [0, 1] (i.e. Reversed-Z). If <code>false</code>, depth is in the range [-1, 1].

```csharp
public override bool IsDepthRangeZeroToOne { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_IsUvOriginTopLeft"></a> IsUvOriginTopLeft

Whether the texture coordinates begin in the top-left of the texture. If <code>false</code>, (0, 0) corresponds to the bottom-left texel of the texture.

```csharp
public override bool IsUvOriginTopLeft { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_VerticalSync"></a> VerticalSync

```csharp
protected override bool VerticalSync { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_ClearCurrent"></a> ClearCurrent\(\)

Invoked when the rendering thread is suspended and no more commands will be enqueued.
This is mainly required for OpenGL renderers to mark context as current before performing GL calls.

```csharp
protected override void ClearCurrent()
```

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_ClearImplementation_osu_Framework_Graphics_Rendering_ClearInfo_"></a> ClearImplementation\(ClearInfo\)

Informs the graphics device to clear the color and depth targets of the currently bound framebuffer.

```csharp
protected override void ClearImplementation(ClearInfo clearInfo)
```

#### Parameters

`clearInfo` [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

The clear parameters.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateFrameBuffer_osu_Framework_Graphics_Rendering_RenderBufferFormat___osu_Framework_Graphics_Textures_TextureFilteringMode_"></a> CreateFrameBuffer\(RenderBufferFormat\[\]?, TextureFilteringMode\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>.

```csharp
public override IFrameBuffer CreateFrameBuffer(RenderBufferFormat[]? renderBufferFormats = null, TextureFilteringMode filteringMode = TextureFilteringMode.Linear)
```

#### Parameters

`renderBufferFormats` [RenderBufferFormat](osu.Framework.Graphics.Rendering.RenderBufferFormat.md)\[\]?

Any render buffer formats.

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

The texture filtering mode.

#### Returns

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

The <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateLinearBatch__1_System_Int32_System_Int32_osu_Framework_Graphics_Rendering_PrimitiveTopology_"></a> CreateLinearBatch<TVertex\>\(int, int, PrimitiveTopology\)

Creates a new linear vertex batch, accepting vertices and drawing as a given primitive type.

```csharp
protected override IVertexBatch<TVertex> CreateLinearBatch<TVertex>(int size, int maxBuffers, PrimitiveTopology topology) where TVertex : unmanaged, IEquatable<TVertex>, IVertex
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

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateNativeTexture_System_Int32_System_Int32_System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_System_Nullable_osuTK_Graphics_Color4__"></a> CreateNativeTexture\(int, int, bool, TextureFilteringMode, Color4?\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override INativeTexture CreateNativeTexture(int width, int height, bool manualMipmaps = false, TextureFilteringMode filteringMode = TextureFilteringMode.Linear, Color4? initialisationColour = null)
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

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateNativeVideoTexture_System_Int32_System_Int32_"></a> CreateNativeVideoTexture\(int, int\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref> for video sprites.

```csharp
protected override INativeTexture CreateNativeVideoTexture(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the texture.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the texture.

#### Returns

 [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)

The video <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateQuadBatch__1_System_Int32_System_Int32_"></a> CreateQuadBatch<TVertex\>\(int, int\)

Creates a new quad vertex batch, accepting vertices and drawing as quads.

```csharp
protected override IVertexBatch<TVertex> CreateQuadBatch<TVertex>(int size, int maxBuffers) where TVertex : unmanaged, IEquatable<TVertex>, IVertex
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

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateShader_System_String_osu_Framework_Graphics_Rendering_IShaderPart___osu_Framework_Graphics_Shaders_ShaderCompilationStore_"></a> CreateShader\(string, IShaderPart\[\], ShaderCompilationStore\)

Creates a new <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override IShader CreateShader(string name, IShaderPart[] parts, ShaderCompilationStore compilationStore)
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

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateShaderPart_osu_Framework_Graphics_Shaders_IShaderStore_System_String_System_Byte___osu_Framework_Graphics_Shaders_ShaderPartType_"></a> CreateShaderPart\(IShaderStore, string, byte\[\]?, ShaderPartType\)

Creates a new <xref href="osu.Framework.Graphics.Rendering.IShaderPart" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override IShaderPart CreateShaderPart(IShaderStore store, string name, byte[]? rawData, ShaderPartType partType)
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

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateShaderStorageBufferObject__1_System_Int32_System_Int32_"></a> CreateShaderStorageBufferObject<TData\>\(int, int\)

Creates a buffer that can be used to store an array of data for use in a <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override IShaderStorageBufferObject<TData> CreateShaderStorageBufferObject<TData>(int uboSize, int ssboSize) where TData : unmanaged, IEquatable<TData>
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

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateTexture_System_Int32_System_Int32_System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_osu_Framework_Graphics_Textures_WrapMode_"></a> CreateTexture\(int, int, bool, TextureFilteringMode, WrapMode\)

```csharp
public Texture CreateTexture(int width, int height, bool manualMipmaps = false, TextureFilteringMode filteringMode = TextureFilteringMode.Linear, WrapMode wrapModeS = WrapMode.None)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`manualMipmaps` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_CreateUniformBuffer__1"></a> CreateUniformBuffer<TData\>\(\)

Creates a buffer that stores data for a uniform block of a <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override IUniformBuffer<TData> CreateUniformBuffer<TData>() where TData : unmanaged, IEquatable<TData>
```

#### Returns

 [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer\-1.md)<TData\>

#### Type Parameters

`TData` 

The type of data in the buffer.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_DeleteFrameBufferImplementation_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> DeleteFrameBufferImplementation\(IFrameBuffer\)

```csharp
protected override void DeleteFrameBufferImplementation(IFrameBuffer frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_DrawVerticesImplementation_osu_Framework_Graphics_Rendering_PrimitiveTopology_System_Int32_System_Int32_"></a> DrawVerticesImplementation\(PrimitiveTopology, int, int\)

```csharp
public override void DrawVerticesImplementation(PrimitiveTopology topology, int vertexStart, int verticesCount)
```

#### Parameters

`topology` [PrimitiveTopology](osu.Framework.Graphics.Rendering.PrimitiveTopology.md)

`vertexStart` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`verticesCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_Initialise_osu_Framework_Platform_IGraphicsSurface_"></a> Initialise\(IGraphicsSurface\)

Performs a once-off initialisation of this <xref href="osu.Framework.Graphics.Rendering.Renderer" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void Initialise(IGraphicsSurface graphicsSurface)
```

#### Parameters

`graphicsSurface` [IGraphicsSurface](osu.Framework.Platform.IGraphicsSurface.md)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_MakeCurrent"></a> MakeCurrent\(\)

Invoked when the rendering thread is active and commands will be enqueued.
This is mainly required for OpenGL renderers to mark context as current before performing GL calls.

```csharp
protected override void MakeCurrent()
```

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetBlendImplementation_osu_Framework_Graphics_BlendingParameters_"></a> SetBlendImplementation\(BlendingParameters\)

Updates the graphics device with the new blending parameters.

```csharp
protected override void SetBlendImplementation(BlendingParameters blendingParameters)
```

#### Parameters

`blendingParameters` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

The blending parameters.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetBlendMaskImplementation_osu_Framework_Graphics_BlendingMask_"></a> SetBlendMaskImplementation\(BlendingMask\)

Updates the graphics device with the new blending mask.

```csharp
protected override void SetBlendMaskImplementation(BlendingMask blendingMask)
```

#### Parameters

`blendingMask` [BlendingMask](osu.Framework.Graphics.BlendingMask.md)

The blending mask.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetDepthInfoImplementation_osu_Framework_Graphics_Rendering_DepthInfo_"></a> SetDepthInfoImplementation\(DepthInfo\)

Updates the graphics device with new depth parameters.

```csharp
protected override void SetDepthInfoImplementation(DepthInfo depthInfo)
```

#### Parameters

`depthInfo` [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

The depth parameters to use.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetFrameBufferImplementation_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> SetFrameBufferImplementation\(IFrameBuffer?\)

Informs the graphics device to use the given framebuffer for drawing.

```csharp
protected override void SetFrameBufferImplementation(IFrameBuffer? frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)?

The framebuffer to use, or null to use the backbuffer (i.e. main framebuffer).

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetScissorImplementation_osu_Framework_Graphics_Primitives_RectangleI_"></a> SetScissorImplementation\(RectangleI\)

Updates the graphics device with a new scissor rectangle.

```csharp
protected override void SetScissorImplementation(RectangleI scissor)
```

#### Parameters

`scissor` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The scissor rectangle to use.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetScissorStateImplementation_System_Boolean_"></a> SetScissorStateImplementation\(bool\)

Updates the graphics device with the new scissor state.

```csharp
protected override void SetScissorStateImplementation(bool enabled)
```

#### Parameters

`enabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether scissor should be enabled.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetShaderImplementation_osu_Framework_Graphics_Shaders_IShader_"></a> SetShaderImplementation\(IShader\)

Informs the graphics device to use the given shader for drawing.

```csharp
protected override void SetShaderImplementation(IShader shader)
```

#### Parameters

`shader` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

The shader to use.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetStencilInfoImplementation_osu_Framework_Graphics_Rendering_StencilInfo_"></a> SetStencilInfoImplementation\(StencilInfo\)

Updates the graphics device with new stencil parameters.

```csharp
protected override void SetStencilInfoImplementation(StencilInfo stencilInfo)
```

#### Parameters

`stencilInfo` [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

The stencil parameters to use.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetTextureImplementation_osu_Framework_Graphics_Rendering_INativeTexture_System_Int32_"></a> SetTextureImplementation\(INativeTexture?, int\)

Informs the graphics device to use the given texture for drawing.

```csharp
protected override bool SetTextureImplementation(INativeTexture? texture, int unit)
```

#### Parameters

`texture` [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)?

The texture, or null to use default texture.

`unit` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The sampling unit in which the texture is to be bound.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the texture was set successfully.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetUniformBufferImplementation_System_String_osu_Framework_Graphics_Rendering_IUniformBuffer_"></a> SetUniformBufferImplementation\(string, IUniformBuffer\)

```csharp
protected override void SetUniformBufferImplementation(string blockName, IUniformBuffer buffer)
```

#### Parameters

`blockName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buffer` [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md)

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetUniformImplementation__1_osu_Framework_Graphics_Shaders_IUniformWithValue___0__"></a> SetUniformImplementation<T\>\(IUniformWithValue<T\>\)

Informs the graphics device to update the value of the given uniform.

```csharp
protected override void SetUniformImplementation<T>(IUniformWithValue<T> uniform) where T : unmanaged, IEquatable<T>
```

#### Parameters

`uniform` [IUniformWithValue](osu.Framework.Graphics.Shaders.IUniformWithValue\-1.md)<T\>

The uniform to update.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SetViewportImplementation_osu_Framework_Graphics_Primitives_RectangleI_"></a> SetViewportImplementation\(RectangleI\)

Updates the graphics device with a new viewport rectangle.

```csharp
protected override void SetViewportImplementation(RectangleI viewport)
```

#### Parameters

`viewport` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The viewport to use.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_SwapBuffers"></a> SwapBuffers\(\)

Swaps the back buffer with the front buffer to display the new frame.

```csharp
protected override void SwapBuffers()
```

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_TakeScreenshot"></a> TakeScreenshot\(\)

Returns an image containing the current content of the backbuffer, i.e. takes a screenshot.

```csharp
protected override Image<Rgba32> TakeScreenshot()
```

#### Returns

 Image<Rgba32\>

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_WaitUntilIdle"></a> WaitUntilIdle\(\)

Waits until all renderer commands have been fully executed GPU-side, as signaled by the graphics backend.

```csharp
protected override void WaitUntilIdle()
```

#### Remarks

This is equivalent to a <code>glFinish</code> call.

### <a id="osu_Framework_Graphics_Rendering_Dummy_DummyRenderer_WaitUntilNextFrameReady"></a> WaitUntilNextFrameReady\(\)

```csharp
protected override void WaitUntilNextFrameReady()
```

