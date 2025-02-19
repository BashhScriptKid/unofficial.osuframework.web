# <a id="osu_Framework_Text_ITexturedCharacterGlyph"></a> Interface ITexturedCharacterGlyph

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

A <xref href="osu.Framework.Text.ICharacterGlyph" data-throw-if-not-resolved="false"></xref> with an associated <xref href="osu.Framework.Text.ITexturedCharacterGlyph.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface ITexturedCharacterGlyph : ICharacterGlyph
```

#### Implements

[ICharacterGlyph](osu.Framework.Text.ICharacterGlyph.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ITexturedCharacterGlyph\>\(ITexturedCharacterGlyph?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITexturedCharacterGlyph\>\(ITexturedCharacterGlyph\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITexturedCharacterGlyph\>\(ITexturedCharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITexturedCharacterGlyph\>\(ITexturedCharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TexturedCharacterGlyphExtensions.IsWhiteSpace<ITexturedCharacterGlyph\>\(ITexturedCharacterGlyph\)](osu.Framework.Text.TexturedCharacterGlyphExtensions.md\#osu\_Framework\_Text\_TexturedCharacterGlyphExtensions\_IsWhiteSpace\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITexturedCharacterGlyph, TChild\>\(ITexturedCharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITexturedCharacterGlyph, TChild\>\(ITexturedCharacterGlyph, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITexturedCharacterGlyph, TChild\>\(ITexturedCharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITexturedCharacterGlyph\>\(ITexturedCharacterGlyph\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Text_ITexturedCharacterGlyph_Height"></a> Height

The height of the area that should be drawn.

```csharp
float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_ITexturedCharacterGlyph_Texture"></a> Texture

The texture for this character.

```csharp
Texture Texture { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Text_ITexturedCharacterGlyph_Width"></a> Width

The width of the area that should be drawn.

```csharp
float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

