# <a id="osu_Framework_Graphics_Rendering_RendererExtensions"></a> Class RendererExtensions

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public static class RendererExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RendererExtensions](osu.Framework.Graphics.Rendering.RendererExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_DrawClipped__1_osu_Framework_Graphics_Rendering_IRenderer___0__osu_Framework_Graphics_Textures_Texture_osu_Framework_Graphics_Colour_ColourInfo_System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__System_Action_osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D__System_Nullable_osuTK_Vector2__System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__"></a> DrawClipped<T\>\(IRenderer, ref T, Texture, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)

Clips a <xref href="osu.Framework.Graphics.Primitives.IConvexPolygon" data-throw-if-not-resolved="false"></xref> to the current masking area and draws the resulting triangles to the screen using the specified texture.

```csharp
public static void DrawClipped<T>(this IRenderer renderer, ref T polygon, Texture texture, ColourInfo drawColour, RectangleF? textureRect = null, Action<TexturedVertex2D>? vertexAction = null, Vector2? inflationPercentage = null, RectangleF? textureCoords = null) where T : IConvexPolygon
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw the texture with.

`polygon` T

The polygon to draw.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to fill the triangle with.

`drawColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The vertex colour.

`textureRect` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

The texture rectangle.

`vertexAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[TexturedVertex2D](osu.Framework.Graphics.Rendering.Vertices.TexturedVertex2D.md)\>?

An action that adds vertices to a <xref href="osu.Framework.Graphics.Rendering.IVertexBatch%601" data-throw-if-not-resolved="false"></xref>.

`inflationPercentage` Vector2?

The percentage amount that <code class="paramref">textureRect</code> should be inflated.

`textureCoords` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

The texture coordinates of the polygon's vertices (translated from the corresponding quad's rectangle).

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_DrawFrameBuffer_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_Graphics_Rendering_IFrameBuffer_osu_Framework_Graphics_Primitives_Quad_osu_Framework_Graphics_Colour_ColourInfo_System_Action_osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D__System_Nullable_osuTK_Vector2__System_Nullable_osuTK_Vector2__"></a> DrawFrameBuffer\(IRenderer, IFrameBuffer, Quad, ColourInfo, Action<TexturedVertex2D\>?, Vector2?, Vector2?\)

Draws a <xref href="osu.Framework.Graphics.OpenGL.Buffers.GLFrameBuffer" data-throw-if-not-resolved="false"></xref> to the screen.

```csharp
public static void DrawFrameBuffer(this IRenderer renderer, IFrameBuffer frameBuffer, Quad vertexQuad, ColourInfo drawColour, Action<TexturedVertex2D>? vertexAction = null, Vector2? inflationPercentage = null, Vector2? blendRangeOverride = null)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw the framebuffer with.

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

The <xref href="osu.Framework.Graphics.OpenGL.Buffers.GLFrameBuffer" data-throw-if-not-resolved="false"></xref> to draw.

`vertexQuad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

The destination vertices.

`drawColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The colour to draw the <code class="paramref">frameBuffer</code> with.

`vertexAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[TexturedVertex2D](osu.Framework.Graphics.Rendering.Vertices.TexturedVertex2D.md)\>?

An action that adds vertices to a <xref href="osu.Framework.Graphics.Rendering.IVertexBatch%601" data-throw-if-not-resolved="false"></xref>.

`inflationPercentage` Vector2?

The percentage amount that the frame buffer area  should be inflated.

`blendRangeOverride` Vector2?

The range over which the edges of the frame buffer should be blended.

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_DrawQuad_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_Graphics_Textures_Texture_osu_Framework_Graphics_Primitives_Quad_osu_Framework_Graphics_Colour_ColourInfo_System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__System_Action_osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D__System_Nullable_osuTK_Vector2__System_Nullable_osuTK_Vector2__System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__"></a> DrawQuad\(IRenderer, Texture, Quad, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, Vector2?, RectangleF?\)

Draws a textured quad to the screen.

```csharp
public static void DrawQuad(this IRenderer renderer, Texture texture, Quad vertexQuad, ColourInfo drawColour, RectangleF? textureRect = null, Action<TexturedVertex2D>? vertexAction = null, Vector2? inflationPercentage = null, Vector2? blendRangeOverride = null, RectangleF? textureCoords = null)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw the texture with.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to fill the triangle with.

`vertexQuad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

The quad to draw.

`drawColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The vertex colour.

`textureRect` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

The texture rectangle.

`vertexAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[TexturedVertex2D](osu.Framework.Graphics.Rendering.Vertices.TexturedVertex2D.md)\>?

An action that adds vertices to a <xref href="osu.Framework.Graphics.Rendering.IVertexBatch%601" data-throw-if-not-resolved="false"></xref>.

`inflationPercentage` Vector2?

The percentage amount that <code class="paramref">textureRect</code> should be inflated.

`blendRangeOverride` Vector2?

The range over which the edges of the <code class="paramref">textureRect</code> should be blended.

`textureCoords` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

The texture coordinates of the quad's vertices.

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_DrawTriangle_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_Graphics_Textures_Texture_osu_Framework_Graphics_Primitives_Triangle_osu_Framework_Graphics_Colour_ColourInfo_System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__System_Action_osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D__System_Nullable_osuTK_Vector2__System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__"></a> DrawTriangle\(IRenderer, Texture, Triangle, ColourInfo, RectangleF?, Action<TexturedVertex2D\>?, Vector2?, RectangleF?\)

Draws a textured triangle to the screen.

```csharp
public static void DrawTriangle(this IRenderer renderer, Texture texture, Triangle vertexTriangle, ColourInfo drawColour, RectangleF? textureRect = null, Action<TexturedVertex2D>? vertexAction = null, Vector2? inflationPercentage = null, RectangleF? textureCoords = null)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw the texture with.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to fill the triangle with.

`vertexTriangle` [Triangle](osu.Framework.Graphics.Primitives.Triangle.md)

The triangle to draw.

`drawColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The vertex colour.

`textureRect` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

The texture rectangle.

`vertexAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[TexturedVertex2D](osu.Framework.Graphics.Rendering.Vertices.TexturedVertex2D.md)\>?

An action that adds vertices to a <xref href="osu.Framework.Graphics.Rendering.IVertexBatch%601" data-throw-if-not-resolved="false"></xref>.

`inflationPercentage` Vector2?

The percentage amount that <code class="paramref">textureRect</code> should be inflated.

`textureCoords` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

The texture coordinates of the triangle's vertices (translated from the corresponding quad's rectangle).

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_PopLocalMatrix_osu_Framework_Graphics_Rendering_IRenderer_"></a> PopLocalMatrix\(IRenderer\)

Restores the last projection matrix after a call to <xref href="osu.Framework.Graphics.Rendering.RendererExtensions.PushLocalMatrix(osu.Framework.Graphics.Rendering.IRenderer%2cosuTK.Matrix4)" data-throw-if-not-resolved="false"></xref>.

```csharp
public static void PopLocalMatrix(this IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer.

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_PopOrtho_osu_Framework_Graphics_Rendering_IRenderer_"></a> PopOrtho\(IRenderer\)

Restores the last projection rectangle.

```csharp
public static void PopOrtho(this IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer.

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_PushLocalMatrix_osu_Framework_Graphics_Rendering_IRenderer_osuTK_Matrix4_"></a> PushLocalMatrix\(IRenderer, Matrix4\)

Applies a new projection matrix so that all drawn vertices are transformed by <code class="paramref">matrix</code>. This also affects masking.

```csharp
public static void PushLocalMatrix(this IRenderer renderer, Matrix4 matrix)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer.

`matrix` Matrix4

The matrix.

#### Remarks

After usage, restore the last state with <xref href="osu.Framework.Graphics.Rendering.RendererExtensions.PopLocalMatrix(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_PushLocalMatrix_osu_Framework_Graphics_Rendering_IRenderer_osuTK_Matrix3_"></a> PushLocalMatrix\(IRenderer, Matrix3\)

Applies a new projection matrix so that all drawn vertices are transformed by <code class="paramref">matrix</code>. This also affects masking.

```csharp
public static void PushLocalMatrix(this IRenderer renderer, Matrix3 matrix)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer.

`matrix` Matrix3

The matrix.

#### Remarks

After usage, restore the last state with <xref href="osu.Framework.Graphics.Rendering.RendererExtensions.PopLocalMatrix(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Rendering_RendererExtensions_PushOrtho_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_Graphics_Primitives_RectangleF_"></a> PushOrtho\(IRenderer, RectangleF\)

Applies a new orthographic projection rectangle.

```csharp
public static void PushOrtho(this IRenderer renderer, RectangleF ortho)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer.

`ortho` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The rectangle to create the orthographic projection from.

#### Remarks

After usage, restore the last state with <xref href="osu.Framework.Graphics.Rendering.RendererExtensions.PopOrtho(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Rendering.IRenderer.PopProjectionMatrix" data-throw-if-not-resolved="false"></xref>.

