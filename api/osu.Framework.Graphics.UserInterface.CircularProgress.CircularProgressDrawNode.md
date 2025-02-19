# <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode"></a> Class CircularProgress.CircularProgressDrawNode

Namespace: [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)  
Assembly: osu.Framework.dll  

```csharp
protected class CircularProgress.CircularProgressDrawNode : SpriteDrawNode, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawNode](osu.Framework.Graphics.DrawNode.md) ← 
[TexturedShaderDrawNode](osu.Framework.Graphics.TexturedShaderDrawNode.md) ← 
[SpriteDrawNode](osu.Framework.Graphics.Sprites.SpriteDrawNode.md) ← 
[CircularProgress.CircularProgressDrawNode](osu.Framework.Graphics.UserInterface.CircularProgress.CircularProgressDrawNode.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[SpriteDrawNode.Texture](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_Texture), 
[SpriteDrawNode.ScreenSpaceDrawQuad](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_ScreenSpaceDrawQuad), 
[SpriteDrawNode.DrawRectangle](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_DrawRectangle), 
[SpriteDrawNode.InflationAmount](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_InflationAmount), 
[SpriteDrawNode.TextureCoords](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_TextureCoords), 
[SpriteDrawNode.Source](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_Source), 
[SpriteDrawNode.ConservativeScreenSpaceDrawQuad](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_ConservativeScreenSpaceDrawQuad), 
[SpriteDrawNode.ApplyState\(\)](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_ApplyState), 
[SpriteDrawNode.Blit\(IRenderer\)](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_Blit\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[SpriteDrawNode.BlitOpaqueInterior\(IRenderer\)](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_BlitOpaqueInterior\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[SpriteDrawNode.Draw\(IRenderer\)](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_Draw\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[SpriteDrawNode.DrawOpaqueInterior\(IRenderer\)](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_DrawOpaqueInterior\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_), 
[SpriteDrawNode.CanDrawOpaqueInterior](osu.Framework.Graphics.Sprites.SpriteDrawNode.md\#osu\_Framework\_Graphics\_Sprites\_SpriteDrawNode\_CanDrawOpaqueInterior), 
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

[ObjectExtensions.AsNonNull<CircularProgress.CircularProgressDrawNode\>\(CircularProgress.CircularProgressDrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CircularProgress.CircularProgressDrawNode\>\(CircularProgress.CircularProgressDrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CircularProgress.CircularProgressDrawNode\>\(CircularProgress.CircularProgressDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CircularProgress.CircularProgressDrawNode\>\(CircularProgress.CircularProgressDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CircularProgress.CircularProgressDrawNode, TChild\>\(CircularProgress.CircularProgressDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CircularProgress.CircularProgressDrawNode, TChild\>\(CircularProgress.CircularProgressDrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CircularProgress.CircularProgressDrawNode, TChild\>\(CircularProgress.CircularProgressDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CircularProgress.CircularProgressDrawNode\>\(CircularProgress.CircularProgressDrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode__ctor_osu_Framework_Graphics_UserInterface_CircularProgress_"></a> CircularProgressDrawNode\(CircularProgress\)

```csharp
public CircularProgressDrawNode(CircularProgress source)
```

#### Parameters

`source` [CircularProgress](osu.Framework.Graphics.UserInterface.CircularProgress.md)

## Properties

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_CanDrawOpaqueInterior"></a> CanDrawOpaqueInterior

Whether this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> can draw a opaque interior. <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will only be invoked if this value is <pre><code class="lang-csharp">true</code></pre>.
Should not return <pre><code class="lang-csharp">true</code></pre> if <xref href="osu.Framework.Graphics.DrawNode.DrawOpaqueInterior(osu.Framework.Graphics.Rendering.IRenderer)" data-throw-if-not-resolved="false"></xref> will result in a no-op.

```csharp
protected override bool CanDrawOpaqueInterior { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_InnerRadius"></a> InnerRadius

```csharp
protected float InnerRadius { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_Progress"></a> Progress

```csharp
protected float Progress { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_RoundedCaps"></a> RoundedCaps

```csharp
protected bool RoundedCaps { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_Source"></a> Source

```csharp
public CircularProgress Source { get; }
```

#### Property Value

 [CircularProgress](osu.Framework.Graphics.UserInterface.CircularProgress.md)

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_TexelSize"></a> TexelSize

```csharp
protected float TexelSize { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_ApplyState"></a> ApplyState\(\)

Applies the state of <xref href="osu.Framework.Graphics.DrawNode.Source" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for use in rendering.
The applied state must remain immutable.

```csharp
public override void ApplyState()
```

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_BindUniformResources_osu_Framework_Graphics_Shaders_IShader_osu_Framework_Graphics_Rendering_IRenderer_"></a> BindUniformResources\(IShader, IRenderer\)

Binds uniform resources against the provided shader.

```csharp
protected override void BindUniformResources(IShader shader, IRenderer renderer)
```

#### Parameters

`shader` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

The shader to bind uniform resources against.

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to use for setting up uniform resources.

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_Blit_osu_Framework_Graphics_Rendering_IRenderer_"></a> Blit\(IRenderer\)

```csharp
protected override void Blit(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_UserInterface_CircularProgress_CircularProgressDrawNode_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

