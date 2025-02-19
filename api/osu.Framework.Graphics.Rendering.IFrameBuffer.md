# <a id="osu_Framework_Graphics_Rendering_IFrameBuffer"></a> Interface IFrameBuffer

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IFrameBuffer : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IFrameBuffer\>\(IFrameBuffer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IFrameBuffer\>\(IFrameBuffer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IFrameBuffer\>\(IFrameBuffer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IFrameBuffer\>\(IFrameBuffer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IFrameBuffer, TChild\>\(IFrameBuffer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IFrameBuffer, TChild\>\(IFrameBuffer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IFrameBuffer, TChild\>\(IFrameBuffer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IFrameBuffer\>\(IFrameBuffer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Rendering_IFrameBuffer_Size"></a> Size

The framebuffer's texture size.

```csharp
Vector2 Size { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Rendering_IFrameBuffer_Texture"></a> Texture

The framebuffer's backing texture.

```csharp
Texture Texture { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

## Methods

### <a id="osu_Framework_Graphics_Rendering_IFrameBuffer_Bind"></a> Bind\(\)

Binds the framebuffer.
<p>Does not clear the buffer or reset the viewport/ortho.</p>

```csharp
void Bind()
```

### <a id="osu_Framework_Graphics_Rendering_IFrameBuffer_Unbind"></a> Unbind\(\)

Unbinds the framebuffer.

```csharp
void Unbind()
```

