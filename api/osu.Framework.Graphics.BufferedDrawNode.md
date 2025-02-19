# <a id="osu_Framework_Graphics_BufferedDrawNode"></a> Class BufferedDrawNode

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public class BufferedDrawNode : TexturedShaderDrawNode, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DrawNode](osu.Framework.Graphics.DrawNode.md) ← 
[TexturedShaderDrawNode](osu.Framework.Graphics.TexturedShaderDrawNode.md) ← 
[BufferedDrawNode](osu.Framework.Graphics.BufferedDrawNode.md)

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

[ObjectExtensions.AsNonNull<BufferedDrawNode\>\(BufferedDrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BufferedDrawNode\>\(BufferedDrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BufferedDrawNode\>\(BufferedDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BufferedDrawNode\>\(BufferedDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BufferedDrawNode, TChild\>\(BufferedDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BufferedDrawNode, TChild\>\(BufferedDrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BufferedDrawNode, TChild\>\(BufferedDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BufferedDrawNode\>\(BufferedDrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_BufferedDrawNode__ctor_osu_Framework_Graphics_IBufferedDrawable_osu_Framework_Graphics_DrawNode_osu_Framework_Graphics_BufferedDrawNodeSharedData_"></a> BufferedDrawNode\(IBufferedDrawable, DrawNode, BufferedDrawNodeSharedData\)

```csharp
public BufferedDrawNode(IBufferedDrawable source, DrawNode child, BufferedDrawNodeSharedData sharedData)
```

#### Parameters

`source` [IBufferedDrawable](osu.Framework.Graphics.IBufferedDrawable.md)

`child` [DrawNode](osu.Framework.Graphics.DrawNode.md)

`sharedData` [BufferedDrawNodeSharedData](osu.Framework.Graphics.BufferedDrawNodeSharedData.md)

## Fields

### <a id="osu_Framework_Graphics_BufferedDrawNode_SharedData"></a> SharedData

Data shared amongst all <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref>s, providing storage for <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s.

```csharp
protected readonly BufferedDrawNodeSharedData SharedData
```

#### Field Value

 [BufferedDrawNodeSharedData](osu.Framework.Graphics.BufferedDrawNodeSharedData.md)

## Properties

### <a id="osu_Framework_Graphics_BufferedDrawNode_Child"></a> Child

The child <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> which is used to populate the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s with.

```csharp
protected DrawNode Child { get; }
```

#### Property Value

 [DrawNode](osu.Framework.Graphics.DrawNode.md)

### <a id="osu_Framework_Graphics_BufferedDrawNode_DrawColourInfo"></a> DrawColourInfo

Contains the colour and blending information of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.

```csharp
protected DrawColourInfo DrawColourInfo { get; }
```

#### Property Value

 [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)

### <a id="osu_Framework_Graphics_BufferedDrawNode_DrawRectangle"></a> DrawRectangle

```csharp
protected RectangleF DrawRectangle { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_BufferedDrawNode_RequiresRedraw"></a> RequiresRedraw

Whether this <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref> should be redrawn.

```csharp
protected bool RequiresRedraw { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BufferedDrawNode_Source"></a> Source

```csharp
protected IBufferedDrawable Source { get; }
```

#### Property Value

 [IBufferedDrawable](osu.Framework.Graphics.IBufferedDrawable.md)

## Methods

### <a id="osu_Framework_Graphics_BufferedDrawNode_ApplyState"></a> ApplyState\(\)

Applies the state of <xref href="osu.Framework.Graphics.DrawNode.Source" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for use in rendering.
The applied state must remain immutable.

```csharp
public override void ApplyState()
```

### <a id="osu_Framework_Graphics_BufferedDrawNode_BindFrameBuffer_osu_Framework_Graphics_Rendering_IFrameBuffer_"></a> BindFrameBuffer\(IFrameBuffer\)

Binds and initialises an <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref> if required.

```csharp
protected ValueInvokeOnDisposal<IFrameBuffer> BindFrameBuffer(IFrameBuffer frameBuffer)
```

#### Parameters

`frameBuffer` [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

The <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref> to bind.

#### Returns

 [ValueInvokeOnDisposal](osu.Framework.Allocation.ValueInvokeOnDisposal\-1.md)<[IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)\>

A token that must be disposed upon finishing use of <code class="paramref">frameBuffer</code>.

### <a id="osu_Framework_Graphics_BufferedDrawNode_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BufferedDrawNode_Draw_osu_Framework_Graphics_Rendering_IRenderer_"></a> Draw\(IRenderer\)

Draws this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> to the screen.

```csharp
protected override sealed void Draw(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to draw with.

#### Remarks

Subclasses must invoke <pre><code class="lang-csharp">base.Draw()</code></pre> prior to drawing vertices.

### <a id="osu_Framework_Graphics_BufferedDrawNode_DrawContents_osu_Framework_Graphics_Rendering_IRenderer_"></a> DrawContents\(IRenderer\)

Draws the applicable effect buffers of <xref href="osu.Framework.Graphics.BufferedDrawNode.SharedData" data-throw-if-not-resolved="false"></xref> to the back buffer.

```csharp
protected virtual void DrawContents(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

### <a id="osu_Framework_Graphics_BufferedDrawNode_GetDrawVersion"></a> GetDrawVersion\(\)

Retrieves the version of the state of this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>.
The <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref> will only re-render if this version is greater than that of the rendered <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s.

```csharp
protected virtual long GetDrawVersion()
```

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

A version representing this <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>'s state.

#### Remarks

By default, the <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref> is re-rendered with every <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> invalidation.

### <a id="osu_Framework_Graphics_BufferedDrawNode_PopulateContents_osu_Framework_Graphics_Rendering_IRenderer_"></a> PopulateContents\(IRenderer\)

Populates the contents of the effect buffers of <xref href="osu.Framework.Graphics.BufferedDrawNode.SharedData" data-throw-if-not-resolved="false"></xref>.
This is invoked after <xref href="osu.Framework.Graphics.BufferedDrawNode.Child" data-throw-if-not-resolved="false"></xref> has been rendered to the main buffer.

```csharp
protected virtual void PopulateContents(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

