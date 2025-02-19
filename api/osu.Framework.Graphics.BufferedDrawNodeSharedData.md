# <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData"></a> Class BufferedDrawNodeSharedData

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Contains data which is shared between all <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref>s of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public class BufferedDrawNodeSharedData : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BufferedDrawNodeSharedData](osu.Framework.Graphics.BufferedDrawNodeSharedData.md)

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

[ObjectExtensions.AsNonNull<BufferedDrawNodeSharedData\>\(BufferedDrawNodeSharedData?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BufferedDrawNodeSharedData\>\(BufferedDrawNodeSharedData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BufferedDrawNodeSharedData\>\(BufferedDrawNodeSharedData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BufferedDrawNodeSharedData\>\(BufferedDrawNodeSharedData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BufferedDrawNodeSharedData, TChild\>\(BufferedDrawNodeSharedData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BufferedDrawNodeSharedData, TChild\>\(BufferedDrawNodeSharedData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BufferedDrawNodeSharedData, TChild\>\(BufferedDrawNodeSharedData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BufferedDrawNodeSharedData\>\(BufferedDrawNodeSharedData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

This should be constructed _once_ per <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, and given to the constructor of <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref>.

## Constructors

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData__ctor_osu_Framework_Graphics_Rendering_RenderBufferFormat___System_Boolean_System_Boolean_"></a> BufferedDrawNodeSharedData\(RenderBufferFormat\[\], bool, bool\)

Creates a new <xref href="osu.Framework.Graphics.BufferedDrawNodeSharedData" data-throw-if-not-resolved="false"></xref> with no effect buffers.

```csharp
public BufferedDrawNodeSharedData(RenderBufferFormat[] formats = null, bool pixelSnapping = false, bool clipToRootNode = false)
```

#### Parameters

`formats` [RenderBufferFormat](osu.Framework.Graphics.Rendering.RenderBufferFormat.md)\[\]

`pixelSnapping` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`clipToRootNode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData__ctor_System_Int32_osu_Framework_Graphics_Rendering_RenderBufferFormat___System_Boolean_System_Boolean_"></a> BufferedDrawNodeSharedData\(int, RenderBufferFormat\[\], bool, bool\)

Creates a new <xref href="osu.Framework.Graphics.BufferedDrawNodeSharedData" data-throw-if-not-resolved="false"></xref> with a specific amount of effect buffers.

```csharp
public BufferedDrawNodeSharedData(int effectBufferCount, RenderBufferFormat[] mainBufferFormats = null, bool pixelSnapping = false, bool clipToRootNode = false)
```

#### Parameters

`effectBufferCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of effect buffers.

`mainBufferFormats` [RenderBufferFormat](osu.Framework.Graphics.Rendering.RenderBufferFormat.md)\[\]

The render buffer formats to attach to the main frame buffer.

`pixelSnapping` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the frame buffer position should be snapped to the nearest pixel when blitting.
    This amounts to setting the texture filtering mode to "nearest".

`clipToRootNode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the frame buffer should be clipped to be contained in the root node..

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

If <code class="paramref">effectBufferCount</code> is less than 0.

## Fields

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_ClipToRootNode"></a> ClipToRootNode

Whether the frame buffer should be clipped to be contained in the root node.

```csharp
public readonly bool ClipToRootNode
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_PixelSnapping"></a> PixelSnapping

Whether the frame buffer position should be snapped to the nearest pixel when blitting.
This amounts to setting the texture filtering mode to "nearest".

```csharp
public readonly bool PixelSnapping
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_CurrentEffectBuffer"></a> CurrentEffectBuffer

The <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref> which contains the most up-to-date drawn effect.

```csharp
public IFrameBuffer CurrentEffectBuffer { get; }
```

#### Property Value

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_IsInitialised"></a> IsInitialised

```csharp
public bool IsInitialised { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_MainBuffer"></a> MainBuffer

The <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref> which contains the original version of the rendered <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public IFrameBuffer MainBuffer { get; }
```

#### Property Value

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

## Methods

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_GetNextEffectBuffer"></a> GetNextEffectBuffer\(\)

Retrieves the next <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref> which effects can be rendered to.

```csharp
public IFrameBuffer GetNextEffectBuffer()
```

#### Returns

 [IFrameBuffer](osu.Framework.Graphics.Rendering.IFrameBuffer.md)

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

If there are no available effect buffers.

### <a id="osu_Framework_Graphics_BufferedDrawNodeSharedData_Initialise_osu_Framework_Graphics_Rendering_IRenderer_"></a> Initialise\(IRenderer\)

```csharp
public void Initialise(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

