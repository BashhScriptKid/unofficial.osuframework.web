# <a id="osu_Framework_Graphics_DrawNode"></a> Class DrawNode

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Contains all the information required to draw a single <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
A hierarchy of <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s is passed to the draw thread for rendering every frame.

```csharp
public class DrawNode : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawNode](osu.Framework.Graphics.DrawNode.md)

#### Derived

[CompositeDrawable.CompositeDrawableDrawNode](osu.Framework.Graphics.Containers.CompositeDrawable.CompositeDrawableDrawNode.md), 
[TexturedShaderDrawNode](osu.Framework.Graphics.TexturedShaderDrawNode.md)

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

[ObjectExtensions.AsNonNull<DrawNode\>\(DrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DrawNode\>\(DrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DrawNode\>\(DrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DrawNode\>\(DrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DrawNode, TChild\>\(DrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DrawNode, TChild\>\(DrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DrawNode, TChild\>\(DrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DrawNode\>\(DrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_DrawNode__ctor_osu_Framework_Graphics_IDrawable_"></a> DrawNode\(IDrawable\)

Creates a new <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.

```csharp
public DrawNode(IDrawable source)
```

#### Parameters

`source` [IDrawable](osu.Framework.Graphics.IDrawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to draw with this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.

## Properties

### <a id="osu_Framework_Graphics_DrawNode_CanDrawOpaqueInterior"></a> CanDrawOpaqueInterior

Whether this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> can draw a opaque interior. <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will only be invoked if this value is <pre><code class="lang-csharp">true</code></pre>.
Should not return <pre><code class="lang-csharp">true</code></pre> if <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will result in a no-op.

```csharp
protected virtual bool CanDrawOpaqueInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_DrawNode_DrawColourInfo"></a> DrawColourInfo

Contains the colour and blending information of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.

```csharp
protected DrawColourInfo DrawColourInfo { get; }
```

#### Property Value

 [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)

### <a id="osu_Framework_Graphics_DrawNode_DrawInfo"></a> DrawInfo

Contains the linear transformation of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.

```csharp
protected DrawInfo DrawInfo { get; }
```

#### Property Value

 [DrawInfo](osu.Framework.Graphics.DrawInfo.md)

### <a id="osu_Framework_Graphics_DrawNode_HasOwnOpaqueInterior"></a> HasOwnOpaqueInterior

Whether this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> has its own opaque interior.
If <code>false</code>, a child of the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> may be the source of the opaque interior.

```csharp
protected virtual bool HasOwnOpaqueInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_DrawNode_InvalidationID"></a> InvalidationID

Identifies the state of this draw node with an invalidation state of its corresponding
<xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. An update is required when the invalidation state of this draw node disagrees
with the invalidation state of its <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected long InvalidationID { get; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Graphics_DrawNode_IsDisposed"></a> IsDisposed

```csharp
protected bool IsDisposed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_DrawNode_Source"></a> Source

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> draws.

```csharp
protected IDrawable Source { get; }
```

#### Property Value

 [IDrawable](osu.Framework.Graphics.IDrawable.md)

## Methods

### <a id="osu_Framework_Graphics_DrawNode_ApplyState"></a> ApplyState\(\)

Applies the state of <xref href="osu.Framework.Graphics.DrawNode.Source" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for use in rendering.
The applied state must remain immutable.

```csharp
public virtual void ApplyState()
```

### <a id="osu_Framework_Graphics_DrawNode_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_DrawNode_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_DrawNode_Draw_osu_Framework_Graphics_Rendering_IRenderer_"></a> Draw\(IRenderer\)

Draws this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> to the screen.

```csharp
protected virtual void Draw(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw with.

#### Remarks

Subclasses must invoke <pre><code class="lang-csharp">base.Draw()</code></pre> prior to drawing vertices.

### <a id="osu_Framework_Graphics_DrawNode_DrawOpaqueInterior_osu_Framework_Graphics_Rendering_IRenderer_"></a> DrawOpaqueInterior\(IRenderer\)

Draws the opaque interior of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> to the screen, if <xref href="osu.Framework.Graphics.DrawNode.CanDrawOpaqueInterior" data-throw-if-not-resolved="false"></xref> indicates that an opaque interior can be drawn.
The opaque interior must be a fully-opaque, non-blended area of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>, clipped to the current masking area via <pre><code class="lang-csharp">DrawClipped()</code></pre>.
See <xref href="osu.Framework.Graphics.Sprites.SpriteDrawNode" data-throw-if-not-resolved="false"></xref> for an example implementation.

```csharp
protected virtual void DrawOpaqueInterior(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw with.

#### Remarks

Subclasses must invoke <pre><code class="lang-csharp">base.DrawOpaqueInterior()</code></pre> prior to drawing vertices.

### <a id="osu_Framework_Graphics_DrawNode_DrawOther_osu_Framework_Graphics_DrawNode_osu_Framework_Graphics_Rendering_IRenderer_"></a> DrawOther\(DrawNode, IRenderer\)

```csharp
protected static void DrawOther(DrawNode node, IRenderer renderer)
```

#### Parameters

`node` [DrawNode](osu.Framework.Graphics.DrawNode.md)

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_DrawNode_DrawOtherOpaqueInterior_osu_Framework_Graphics_DrawNode_osu_Framework_Graphics_Rendering_IRenderer_"></a> DrawOtherOpaqueInterior\(DrawNode, IRenderer\)

Draws the opaque interior of a <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.

```csharp
protected static void DrawOtherOpaqueInterior(DrawNode node, IRenderer renderer)
```

#### Parameters

`node` [DrawNode](osu.Framework.Graphics.DrawNode.md)

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_DrawNode_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

