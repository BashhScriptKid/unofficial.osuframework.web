# <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode"></a> Class CompositeDrawable.CompositeDrawableDrawNode

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

A draw node responsible for rendering a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> and the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s of its children.

```csharp
protected class CompositeDrawable.CompositeDrawableDrawNode : DrawNode, IDisposable, ICompositeDrawNode
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawNode](osu.Framework.Graphics.DrawNode.md) ← 
[CompositeDrawable.CompositeDrawableDrawNode](osu.Framework.Graphics.Containers.CompositeDrawable.CompositeDrawableDrawNode.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[ICompositeDrawNode](osu.Framework.Graphics.ICompositeDrawNode.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<CompositeDrawable.CompositeDrawableDrawNode\>\(CompositeDrawable.CompositeDrawableDrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CompositeDrawable.CompositeDrawableDrawNode\>\(CompositeDrawable.CompositeDrawableDrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CompositeDrawable.CompositeDrawableDrawNode\>\(CompositeDrawable.CompositeDrawableDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CompositeDrawable.CompositeDrawableDrawNode\>\(CompositeDrawable.CompositeDrawableDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CompositeDrawable.CompositeDrawableDrawNode, TChild\>\(CompositeDrawable.CompositeDrawableDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CompositeDrawable.CompositeDrawableDrawNode, TChild\>\(CompositeDrawable.CompositeDrawableDrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CompositeDrawable.CompositeDrawableDrawNode, TChild\>\(CompositeDrawable.CompositeDrawableDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CompositeDrawable.CompositeDrawableDrawNode\>\(CompositeDrawable.CompositeDrawableDrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode__ctor_osu_Framework_Graphics_Containers_CompositeDrawable_"></a> CompositeDrawableDrawNode\(CompositeDrawable\)

```csharp
public CompositeDrawableDrawNode(CompositeDrawable source)
```

#### Parameters

`source` [CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)

## Properties

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_AddChildDrawNodes"></a> AddChildDrawNodes

Whether <xref href="osu.Framework.Graphics.ICompositeDrawNode.Children" data-throw-if-not-resolved="false"></xref> should be updated by the parenting <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual bool AddChildDrawNodes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_CanDrawOpaqueInterior"></a> CanDrawOpaqueInterior

Whether this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> can draw a opaque interior. <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will only be invoked if this value is <pre><code class="lang-csharp">true</code></pre>.
Should not return <pre><code class="lang-csharp">true</code></pre> if <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will result in a no-op.

```csharp
protected override bool CanDrawOpaqueInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_Children"></a> Children

The <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s of the children of our <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public List<DrawNode> Children { get; set; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[DrawNode](osu.Framework.Graphics.DrawNode.md)\>

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_HasOwnOpaqueInterior"></a> HasOwnOpaqueInterior

Whether this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> has its own opaque interior.
If <code>false</code>, a child of the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> may be the source of the opaque interior.

```csharp
protected override bool HasOwnOpaqueInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_Shader"></a> Shader

The <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref> to use for rendering.

```csharp
protected IShader Shader { get; }
```

#### Property Value

 [IShader](osu.Framework.Graphics.Shaders.IShader.md)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_Source"></a> Source

```csharp
protected CompositeDrawable Source { get; }
```

#### Property Value

 [CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)

## Methods

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_ApplyState"></a> ApplyState\(\)

Applies the state of <xref href="osu.Framework.Graphics.DrawNode.Source" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for use in rendering.
The applied state must remain immutable.

```csharp
public override void ApplyState()
```

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_Draw_osu_Framework_Graphics_Rendering_IRenderer_"></a> Draw\(IRenderer\)

Draws this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> to the screen.

```csharp
protected override void Draw(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw with.

#### Remarks

Subclasses must invoke <pre><code class="lang-csharp">base.Draw()</code></pre> prior to drawing vertices.

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_CompositeDrawableDrawNode_DrawOpaqueInterior_osu_Framework_Graphics_Rendering_IRenderer_"></a> DrawOpaqueInterior\(IRenderer\)

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

