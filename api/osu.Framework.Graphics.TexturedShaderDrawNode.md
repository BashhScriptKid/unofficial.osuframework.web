# <a id="osu_Framework_Graphics_TexturedShaderDrawNode"></a> Class TexturedShaderDrawNode

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class TexturedShaderDrawNode : DrawNode, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawNode](osu.Framework.Graphics.DrawNode.md) ← 
[TexturedShaderDrawNode](osu.Framework.Graphics.TexturedShaderDrawNode.md)

#### Derived

[BufferedDrawNode](osu.Framework.Graphics.BufferedDrawNode.md), 
[SpriteDrawNode](osu.Framework.Graphics.Sprites.SpriteDrawNode.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

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

[ObjectExtensions.AsNonNull<TexturedShaderDrawNode\>\(TexturedShaderDrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TexturedShaderDrawNode\>\(TexturedShaderDrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TexturedShaderDrawNode\>\(TexturedShaderDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TexturedShaderDrawNode\>\(TexturedShaderDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TexturedShaderDrawNode, TChild\>\(TexturedShaderDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TexturedShaderDrawNode, TChild\>\(TexturedShaderDrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TexturedShaderDrawNode, TChild\>\(TexturedShaderDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TexturedShaderDrawNode\>\(TexturedShaderDrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_TexturedShaderDrawNode__ctor_osu_Framework_Graphics_ITexturedShaderDrawable_"></a> TexturedShaderDrawNode\(ITexturedShaderDrawable\)

```csharp
protected TexturedShaderDrawNode(ITexturedShaderDrawable source)
```

#### Parameters

`source` [ITexturedShaderDrawable](osu.Framework.Graphics.ITexturedShaderDrawable.md)

## Properties

### <a id="osu_Framework_Graphics_TexturedShaderDrawNode_Source"></a> Source

```csharp
protected ITexturedShaderDrawable Source { get; }
```

#### Property Value

 [ITexturedShaderDrawable](osu.Framework.Graphics.ITexturedShaderDrawable.md)

## Methods

### <a id="osu_Framework_Graphics_TexturedShaderDrawNode_ApplyState"></a> ApplyState\(\)

Applies the state of <xref href="osu.Framework.Graphics.DrawNode.Source" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for use in rendering.
The applied state must remain immutable.

```csharp
public override void ApplyState()
```

### <a id="osu_Framework_Graphics_TexturedShaderDrawNode_BindTextureShader_osu_Framework_Graphics_Rendering_IRenderer_"></a> BindTextureShader\(IRenderer\)

Binds the <xref href="osu.Framework.Graphics.Shaders.IShader" data-throw-if-not-resolved="false"></xref> used for rendering the texture.

```csharp
protected void BindTextureShader(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to use for setting up uniform resources.

### <a id="osu_Framework_Graphics_TexturedShaderDrawNode_BindUniformResources_osu_Framework_Graphics_Shaders_IShader_osu_Framework_Graphics_Rendering_IRenderer_"></a> BindUniformResources\(IShader, IRenderer\)

Binds uniform resources against the provided shader.

```csharp
protected virtual void BindUniformResources(IShader shader, IRenderer renderer)
```

#### Parameters

`shader` [IShader](osu.Framework.Graphics.Shaders.IShader.md)

The shader to bind uniform resources against.

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to use for setting up uniform resources.

### <a id="osu_Framework_Graphics_TexturedShaderDrawNode_UnbindTextureShader_osu_Framework_Graphics_Rendering_IRenderer_"></a> UnbindTextureShader\(IRenderer\)

```csharp
protected void UnbindTextureShader(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

