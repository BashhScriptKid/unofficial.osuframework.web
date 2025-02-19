# <a id="osu_Framework_Graphics_Textures_TextureAtlas"></a> Class TextureAtlas

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

```csharp
public class TextureAtlas
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureAtlas](osu.Framework.Graphics.Textures.TextureAtlas.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextureAtlas\>\(TextureAtlas?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextureAtlas\>\(TextureAtlas\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextureAtlas\>\(TextureAtlas\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextureAtlas\>\(TextureAtlas\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextureAtlas, TChild\>\(TextureAtlas, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextureAtlas, TChild\>\(TextureAtlas, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextureAtlas, TChild\>\(TextureAtlas, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextureAtlas\>\(TextureAtlas\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_TextureAtlas__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_Int32_System_Int32_System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_"></a> TextureAtlas\(IRenderer, int, int, bool, TextureFilteringMode\)

```csharp
public TextureAtlas(IRenderer renderer, int width, int height, bool manualMipmaps = false, TextureFilteringMode filteringMode = TextureFilteringMode.Linear)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`manualMipmaps` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

## Methods

### <a id="osu_Framework_Graphics_Textures_TextureAtlas_Add_System_Int32_System_Int32_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> Add\(int, int, WrapMode, WrapMode\)

Add (allocate) a new texture in the atlas.

```csharp
public Texture? Add(int width, int height, WrapMode wrapModeS = WrapMode.None, WrapMode wrapModeT = WrapMode.None)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the requested texture.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the requested texture.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The horizontal wrap mode of the texture.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The vertical wrap mode of the texture.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)?

A texture, or null if the requested size exceeds the atlas' bounds.

### <a id="osu_Framework_Graphics_Textures_TextureAtlas_Reset"></a> Reset\(\)

Creates a new empty texture.

```csharp
public void Reset()
```

#### Remarks

Existing textures created via <xref href="osu.Framework.Graphics.Textures.TextureAtlas.Add(System.Int32%2cSystem.Int32%2cosu.Framework.Graphics.Textures.WrapMode%2cosu.Framework.Graphics.Textures.WrapMode)" data-throw-if-not-resolved="false"></xref> are not cleared and remain accessible by usages.

