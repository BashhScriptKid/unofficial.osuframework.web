# <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode"></a> Class SpriteDrawNode

Namespace: [osu.Framework.Graphics.Sprites](osu.Framework.Graphics.Sprites.md)  
Assembly: osu.Framework.dll  

Draw node containing all necessary information to draw a <xref href="osu.Framework.Graphics.Sprites.Sprite" data-throw-if-not-resolved="false"></xref>.

```csharp
public class SpriteDrawNode : TexturedShaderDrawNode, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawNode](osu.Framework.Graphics.DrawNode.md) ← 
[TexturedShaderDrawNode](osu.Framework.Graphics.TexturedShaderDrawNode.md) ← 
[SpriteDrawNode](osu.Framework.Graphics.Sprites.SpriteDrawNode.md)

#### Derived

[CircularProgress.CircularProgressDrawNode](osu.Framework.Graphics.UserInterface.CircularProgress.CircularProgressDrawNode.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[TexturedShaderDrawNode.Source](osu.Framework.Graphics.TexturedShaderDrawNode.md\#osu\_Framework\_Graphics\_TexturedShaderDrawNode\_Source), 
[TexturedShaderDrawNode.ApplyState\(\)](osu.Framework.Graphics.TexturedShaderDrawNode.md\#osu\_Framework\_Graphics\_TexturedShaderDrawNode\_ApplyState), 
[TexturedShaderDrawNode.BindTextureShader\(IRenderer\)](osu.Framework.Graphics.TexturedShaderDrawNode.md\#osu\_Framework\_Graphics\_TexturedShaderDrawNode\_BindTextureShader\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[TexturedShaderDrawNode.UnbindTextureShader\(IRenderer\)](osu.Framework.Graphics.TexturedShaderDrawNode.md\#osu\_Framework\_Graphics\_TexturedShaderDrawNode\_UnbindTextureShader\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[TexturedShaderDrawNode.BindUniformResources\(IShader, IRenderer\)](osu.Framework.Graphics.TexturedShaderDrawNode.md\#osu\_Framework\_Graphics\_TexturedShaderDrawNode\_BindUniformResources\_osu\_Framework\_Graphics\_Shaders\_IShader\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[DrawNode.DrawInfo](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_DrawInfo), 
[DrawNode.DrawColourInfo](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_DrawColourInfo), 
[DrawNode.InvalidationID](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_InvalidationID), 
[DrawNode.Source](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_Source), 
[DrawNode.ApplyState\(\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_ApplyState), 
[DrawNode.Draw\(IRenderer\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_Draw\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[DrawNode.DrawOpaqueInterior\(IRenderer\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_DrawOpaqueInterior\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[DrawNode.DrawOther\(DrawNode, IRenderer\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_DrawOther\_osu\_Framework\_Graphics\_DrawNode\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[DrawNode.DrawOtherOpaqueInterior\(DrawNode, IRenderer\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_DrawOtherOpaqueInterior\_osu\_Framework\_Graphics\_DrawNode\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[DrawNode.CanDrawOpaqueInterior](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_CanDrawOpaqueInterior), 
[DrawNode.HasOwnOpaqueInterior](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_HasOwnOpaqueInterior), 
[DrawNode.ToString\(\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_ToString), 
[DrawNode.IsDisposed](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_IsDisposed), 
[DrawNode.Dispose\(\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_Dispose), 
[DrawNode.Dispose\(bool\)](osu.Framework.Graphics.DrawNode.md\#osu\_Framework\_Graphics\_DrawNode\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SpriteDrawNode\>\(SpriteDrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SpriteDrawNode\>\(SpriteDrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SpriteDrawNode\>\(SpriteDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SpriteDrawNode\>\(SpriteDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SpriteDrawNode, TChild\>\(SpriteDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SpriteDrawNode, TChild\>\(SpriteDrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SpriteDrawNode, TChild\>\(SpriteDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SpriteDrawNode\>\(SpriteDrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode__ctor_osu_Framework_Graphics_Sprites_Sprite_"></a> SpriteDrawNode\(Sprite\)

```csharp
public SpriteDrawNode(Sprite source)
```

#### Parameters

`source` [Sprite](osu.Framework.Graphics.Sprites.Sprite.md)

## Fields

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_ConservativeScreenSpaceDrawQuad"></a> ConservativeScreenSpaceDrawQuad

```csharp
protected Quad ConservativeScreenSpaceDrawQuad
```

#### Field Value

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

## Properties

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_CanDrawOpaqueInterior"></a> CanDrawOpaqueInterior

Whether this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> can draw a opaque interior. <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will only be invoked if this value is <pre><code class="lang-csharp">true</code></pre>.
Should not return <pre><code class="lang-csharp">true</code></pre> if <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will result in a no-op.

```csharp
protected override bool CanDrawOpaqueInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_DrawRectangle"></a> DrawRectangle

```csharp
protected RectangleF DrawRectangle { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_InflationAmount"></a> InflationAmount

```csharp
protected Vector2 InflationAmount { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_ScreenSpaceDrawQuad"></a> ScreenSpaceDrawQuad

```csharp
protected Quad ScreenSpaceDrawQuad { get; }
```

#### Property Value

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_Source"></a> Source

```csharp
protected Sprite Source { get; }
```

#### Property Value

 [Sprite](osu.Framework.Graphics.Sprites.Sprite.md)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_Texture"></a> Texture

```csharp
protected Texture Texture { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_TextureCoords"></a> TextureCoords

```csharp
protected RectangleF TextureCoords { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

## Methods

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_ApplyState"></a> ApplyState\(\)

Applies the state of <xref href="osu.Framework.Graphics.DrawNode.Source" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for use in rendering.
The applied state must remain immutable.

```csharp
public override void ApplyState()
```

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_Blit_osu_Framework_Graphics_Rendering_IRenderer_"></a> Blit\(IRenderer\)

```csharp
protected virtual void Blit(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_BlitOpaqueInterior_osu_Framework_Graphics_Rendering_IRenderer_"></a> BlitOpaqueInterior\(IRenderer\)

```csharp
protected virtual void BlitOpaqueInterior(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_Draw_osu_Framework_Graphics_Rendering_IRenderer_"></a> Draw\(IRenderer\)

Draws this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> to the screen.

```csharp
protected override void Draw(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw with.

#### Remarks

Subclasses must invoke <pre><code class="lang-csharp">base.Draw()</code></pre> prior to drawing vertices.

### <a id="osu_Framework_Graphics_Sprites_SpriteDrawNode_DrawOpaqueInterior_osu_Framework_Graphics_Rendering_IRenderer_"></a> DrawOpaqueInterior\(IRenderer\)

Draws the opaque interior of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> to the screen, if <xref href="osu.Framework.Graphics.DrawNode.CanDrawOpaqueInterior" data-throw-if-not-resolved="false"></xref> indicates that an opaque interior can be drawn.
The opaque interior must be a fully-opaque, non-blended area of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>, clipped to the current masking area via <pre><code class="lang-csharp">DrawClipped()</code></pre>.
See <xref href="osu.Framework.Graphics.Sprites.SpriteDrawNode" data-throw-if-not-resolved="false"></xref> for an example implementation.

```csharp
protected override void DrawOpaqueInterior(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw with.

#### Remarks

Subclasses must invoke <pre><code class="lang-csharp">base.DrawOpaqueInterior()</code></pre> prior to drawing vertices.

