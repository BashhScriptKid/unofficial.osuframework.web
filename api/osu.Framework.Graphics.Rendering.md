# <a id="osu_Framework_Graphics_Rendering"></a> Namespace osu.Framework.Graphics.Rendering

### Namespaces

 [osu.Framework.Graphics.Rendering.Dummy](osu.Framework.Graphics.Rendering.Dummy.md)

 [osu.Framework.Graphics.Rendering.Vertices](osu.Framework.Graphics.Rendering.Vertices.md)

### Classes

 [DepthValue](osu.Framework.Graphics.Rendering.DepthValue.md)

The depth value used to draw 2D objects to the screen.
Starts at -1f and increments to 1f for each <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which draws a opaque interior through <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref>.

 [Renderer](osu.Framework.Graphics.Rendering.Renderer.md)

Represents a base <xref href="osu.Framework.Graphics.Rendering.IRenderer" data-throw-if-not-resolved="false"></xref> implementation for working renderers.

 [RendererExtensions](osu.Framework.Graphics.Rendering.RendererExtensions.md)

 [ShaderStorageBufferObjectStack<TData\>](osu.Framework.Graphics.Rendering.ShaderStorageBufferObjectStack\-1.md)

A wrapper around <xref href="osu.Framework.Graphics.Rendering.IShaderStorageBufferObject%601" data-throw-if-not-resolved="false"></xref> providing push/pop semantics for writing
an arbitrary amount of data to an unbounded set of shader storage buffer objects.

### Structs

 [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

Information for how the current frame buffer should be cleared.

 [DepthInfo](osu.Framework.Graphics.Rendering.DepthInfo.md)

Information for how depth should be handled.

 [GlobalUniformData](osu.Framework.Graphics.Rendering.GlobalUniformData.md)

 [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

 [StencilInfo](osu.Framework.Graphics.Rendering.StencilInfo.md)

### Interfaces

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

 [INativeTexture](osu.Framework.Graphics.Rendering.INativeTexture.md)

 [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

Draws to the screen.

 [IShaderPart](osu.Framework.Graphics.Rendering.IShaderPart.md)

 [IShaderStorageBufferObject<TData\>](osu.Framework.Graphics.Rendering.IShaderStorageBufferObject\-1.md)

A buffer which stores an array of data for use in a shader.

 [IUniformBuffer<TData\>](osu.Framework.Graphics.Rendering.IUniformBuffer\-1.md)

A buffer which stores data for a uniform block.

 [IUniformBuffer](osu.Framework.Graphics.Rendering.IUniformBuffer.md)

A buffer which stores data for a uniform block.

 [IVertexBatch](osu.Framework.Graphics.Rendering.IVertexBatch.md)

 [IVertexBatch<TVertex\>](osu.Framework.Graphics.Rendering.IVertexBatch\-1.md)

### Enums

 [BufferTestFunction](osu.Framework.Graphics.Rendering.BufferTestFunction.md)

 [FlushBatchSource](osu.Framework.Graphics.Rendering.FlushBatchSource.md)

 [PrimitiveTopology](osu.Framework.Graphics.Rendering.PrimitiveTopology.md)

 [RenderBufferFormat](osu.Framework.Graphics.Rendering.RenderBufferFormat.md)

 [StencilOperation](osu.Framework.Graphics.Rendering.StencilOperation.md)

