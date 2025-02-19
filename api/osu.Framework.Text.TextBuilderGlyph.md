# <a id="osu_Framework_Text_TextBuilderGlyph"></a> Struct TextBuilderGlyph

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

A <xref href="osu.Framework.Text.ITexturedCharacterGlyph" data-throw-if-not-resolved="false"></xref> provided as final output from a <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public struct TextBuilderGlyph : ITexturedCharacterGlyph, ICharacterGlyph
```

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

[ObjectExtensions.AsNonNull<TextBuilderGlyph\>\(TextBuilderGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextBuilderGlyph\>\(TextBuilderGlyph\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextBuilderGlyph\>\(TextBuilderGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextBuilderGlyph\>\(TextBuilderGlyph\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TexturedCharacterGlyphExtensions.IsWhiteSpace<TextBuilderGlyph\>\(TextBuilderGlyph\)](osu.Framework.Text.TexturedCharacterGlyphExtensions.md\#osu\_Framework\_Text\_TexturedCharacterGlyphExtensions\_IsWhiteSpace\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextBuilderGlyph, TChild\>\(TextBuilderGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextBuilderGlyph, TChild\>\(TextBuilderGlyph, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextBuilderGlyph, TChild\>\(TextBuilderGlyph, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextBuilderGlyph\>\(TextBuilderGlyph\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Text_TextBuilderGlyph_Glyph"></a> Glyph

```csharp
public readonly ITexturedCharacterGlyph Glyph
```

#### Field Value

 [ITexturedCharacterGlyph](osu.Framework.Text.ITexturedCharacterGlyph.md)

## Properties

### <a id="osu_Framework_Text_TextBuilderGlyph_Baseline"></a> Baseline

The position of the baseline in this glyph.

```csharp
public readonly float Baseline { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TextBuilderGlyph_Character"></a> Character

The character represented by this glyph.

```csharp
public readonly char Character { get; }
```

#### Property Value

 [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="osu_Framework_Text_TextBuilderGlyph_DrawRectangle"></a> DrawRectangle

The rectangle for the character to be drawn in.

```csharp
public readonly RectangleF DrawRectangle { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Text_TextBuilderGlyph_Height"></a> Height

The height of the area that should be drawn.

```csharp
public readonly float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TextBuilderGlyph_LinePosition"></a> LinePosition

The top position of the line where this glyph will be placed on.

```csharp
public readonly float LinePosition { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TextBuilderGlyph_OnNewLine"></a> OnNewLine

Whether this is the first character on a new line.

```csharp
public readonly bool OnNewLine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Text_TextBuilderGlyph_Texture"></a> Texture

The texture for this character.

```csharp
public readonly Texture Texture { get; }
```

#### Property Value

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

### <a id="osu_Framework_Text_TextBuilderGlyph_Width"></a> Width

The width of the area that should be drawn.

```csharp
public readonly float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TextBuilderGlyph_XAdvance"></a> XAdvance

How much the current x-position should be moved after drawing a character.

```csharp
public readonly float XAdvance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TextBuilderGlyph_XOffset"></a> XOffset

How much the current x-position should be moved for drawing. This should not adjust the cursor position.

```csharp
public readonly float XOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Text_TextBuilderGlyph_YOffset"></a> YOffset

How much the current y-position should be moved for drawing. This should not adjust the cursor position.

```csharp
public readonly float YOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Text_TextBuilderGlyph_GetKerning__1___0_"></a> GetKerning<T\>\(T\)

Retrieves the kerning between this <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> and the one prior to it.

```csharp
public readonly float GetKerning<T>(T lastGlyph) where T : ICharacterGlyph
```

#### Parameters

`lastGlyph` T

The <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> prior to this one.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Type Parameters

`T` 

