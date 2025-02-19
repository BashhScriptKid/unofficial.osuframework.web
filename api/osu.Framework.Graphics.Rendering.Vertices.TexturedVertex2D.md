# <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D"></a> Struct TexturedVertex2D

Namespace: [osu.Framework.Graphics.Rendering.Vertices](osu.Framework.Graphics.Rendering.Vertices.md)  
Assembly: osu.Framework.dll  

```csharp
public struct TexturedVertex2D : IEquatable<TexturedVertex2D>, IVertex
```

#### Implements

[IEquatable<TexturedVertex2D\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IVertex](osu.Framework.Graphics.Rendering.Vertices.IVertex.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TexturedVertex2D\>\(TexturedVertex2D\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TexturedVertex2D\>\(TexturedVertex2D\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TexturedVertex2D\>\(TexturedVertex2D\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TexturedVertex2D\>\(TexturedVertex2D\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TexturedVertex2D, TChild\>\(TexturedVertex2D, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TexturedVertex2D, TChild\>\(TexturedVertex2D, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TexturedVertex2D, TChild\>\(TexturedVertex2D, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TexturedVertex2D\>\(TexturedVertex2D\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D__ctor"></a> TexturedVertex2D\(\)

```csharp
[Obsolete("Initialise this type with an IRenderer instead", true)]
public TexturedVertex2D()
```

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D__ctor_osu_Framework_Graphics_Rendering_IRenderer_"></a> TexturedVertex2D\(IRenderer\)

```csharp
public TexturedVertex2D(IRenderer renderer)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

## Fields

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_BlendRange"></a> BlendRange

```csharp
[VertexMember(2, VertexAttribPointerType.Float)]
public Vector2 BlendRange
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_Colour"></a> Colour

```csharp
[VertexMember(4, VertexAttribPointerType.Float)]
public Color4 Colour
```

#### Field Value

 Color4

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_Position"></a> Position

```csharp
[VertexMember(2, VertexAttribPointerType.Float)]
public Vector2 Position
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_TexturePosition"></a> TexturePosition

```csharp
[VertexMember(2, VertexAttribPointerType.Float)]
public Vector2 TexturePosition
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_TextureRect"></a> TextureRect

```csharp
[VertexMember(4, VertexAttribPointerType.Float)]
public Vector4 TextureRect
```

#### Field Value

 Vector4

## Methods

### <a id="osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_Equals_osu_Framework_Graphics_Rendering_Vertices_TexturedVertex2D_"></a> Equals\(TexturedVertex2D\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(TexturedVertex2D other)
```

#### Parameters

`other` [TexturedVertex2D](osu.Framework.Graphics.Rendering.Vertices.TexturedVertex2D.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

