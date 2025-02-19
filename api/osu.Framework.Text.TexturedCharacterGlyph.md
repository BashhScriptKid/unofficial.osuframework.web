# <a id="osu_Framework_Text_TexturedCharacterGlyph"></a> Class TexturedCharacterGlyph

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class TexturedCharacterGlyph : ITexturedCharacterGlyph, ICharacterGlyph
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TexturedCharacterGlyph](osu.Framework.Text.TexturedCharacterGlyph.md)

#### Implements

[ITexturedCharacterGlyph](osu.Framework.Text.ITexturedCharacterGlyph.md), 
[ICharacterGlyph](osu.Framework.Text.ICharacterGlyph.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TexturedCharacterGlyph\>\(TexturedCharacterGlyph?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TexturedCharacterGlyph\>\(TexturedCharacterGlyph\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TexturedCharacterGlyph\>\(TexturedCharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TexturedCharacterGlyph\>\(TexturedCharacterGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TexturedCharacterGlyphExtensions.IsWhiteSpace<TexturedCharacterGlyph\>\(TexturedCharacterGlyph\)](osu.Framework.Text.TexturedCharacterGlyphExtensions.md\#osu\_Framework\_Text\_TexturedCharacterGlyphExtensions\_IsWhiteSpace\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TexturedCharacterGlyph, TChild\>\(TexturedCharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TexturedCharacterGlyph, TChild\>\(TexturedCharacterGlyph, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TexturedCharacterGlyph, TChild\>\(TexturedCharacterGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TexturedCharacterGlyph\>\(TexturedCharacterGlyph\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Text_TexturedCharacterGlyph__ctor_osu_Framework_Text_CharacterGlyph_osu_Framework_Graphics_Textures_Texture_System_Single_"></a> TexturedCharacterGlyph\(CharacterGlyph, Texture, float\)

Create a new <xref href="osu.Framework.Text.TexturedCharacterGlyph" data-throw-if-not-resolved="false"></xref> instance.

```csharp
public TexturedCharacterGlyph(CharacterGlyph glyph, Texture texture, float scale = 1)
```

#### Parameters

`glyph` [CharacterGlyph](osu.Framework.Text.CharacterGlyph.md)

The glyph.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture.

`scale` [float](https://learn.microsoft.com/dotnet/api/system.single)

A scale factor to apply to exposed glyph metrics.

## Fields

### <a id="osu_Framework_Text_TexturedCharacterGlyph_Scale"></a> Scale

An adjustment factor in scale. This is applied to all other returned metric properties.

```csharp
public readonly float Scale
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="osu_Framework_Text_TexturedCharacterGlyph_Baseline"></a> Baseline

The position of the baseline in this glyph.

```csharp
public float Baseline { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_Character"></a> Character

The character represented by this glyph.

```csharp
public char Character { get; }
```

#### Property Value

 [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_Height"></a> Height

The height of the area that should be drawn.

```csharp
public float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_Texture"></a> Texture

The texture for this character.

```csharp
public Texture Texture { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_Width"></a> Width

The width of the area that should be drawn.

```csharp
public float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_XAdvance"></a> XAdvance

How much the current x-position should be moved after drawing a character.

```csharp
public float XAdvance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_XOffset"></a> XOffset

How much the current x-position should be moved for drawing. This should not adjust the cursor position.

```csharp
public float XOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TexturedCharacterGlyph_YOffset"></a> YOffset

How much the current y-position should be moved for drawing. This should not adjust the cursor position.

```csharp
public float YOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Text_TexturedCharacterGlyph_GetKerning__1___0_"></a> GetKerning<T\>\(T\)

Retrieves the kerning between this <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> and the one prior to it.

```csharp
public float GetKerning<T>(T lastGlyph) where T : ICharacterGlyph
```

#### Parameters

`lastGlyph` T

The <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> prior to this one.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Type Parameters

`T` 

