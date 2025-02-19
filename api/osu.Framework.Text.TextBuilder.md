# <a id="osu_Framework_Text_TextBuilder"></a> Class TextBuilder

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

A text builder for <xref href="osu.Framework.Graphics.Sprites.SpriteText" data-throw-if-not-resolved="false"></xref> and other text-based display components.

```csharp
public class TextBuilder : IHasLineBaseHeight
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextBuilder](osu.Framework.Text.TextBuilder.md)

#### Derived

[MultilineTextBuilder](osu.Framework.Text.MultilineTextBuilder.md), 
[TruncatingTextBuilder](osu.Framework.Text.TruncatingTextBuilder.md)

#### Implements

[IHasLineBaseHeight](osu.Framework.Graphics.Sprites.IHasLineBaseHeight.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextBuilder\>\(TextBuilder?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextBuilder\>\(TextBuilder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextBuilder\>\(TextBuilder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextBuilder\>\(TextBuilder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextBuilder, TChild\>\(TextBuilder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextBuilder, TChild\>\(TextBuilder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextBuilder, TChild\>\(TextBuilder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextBuilder\>\(TextBuilder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Text_TextBuilder__ctor_osu_Framework_Text_ITexturedGlyphLookupStore_osu_Framework_Graphics_Sprites_FontUsage_System_Single_System_Boolean_osuTK_Vector2_osuTK_Vector2_System_Collections_Generic_List_osu_Framework_Text_TextBuilderGlyph__System_Char___System_Char_System_Char_"></a> TextBuilder\(ITexturedGlyphLookupStore, FontUsage, float, bool, Vector2, Vector2, List<TextBuilderGlyph\>, char\[\], char, char\)

Creates a new <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public TextBuilder(ITexturedGlyphLookupStore store, FontUsage font, float maxWidth = 3.4028235E+38, bool useFontSizeAsHeight = true, Vector2 startOffset = default, Vector2 spacing = default, List<TextBuilderGlyph> characterList = null, char[] neverFixedWidthCharacters = null, char fallbackCharacter = '?', char fixedWidthReferenceCharacter = 'm')
```

#### Parameters

`store` [ITexturedGlyphLookupStore](osu.Framework.Text.ITexturedGlyphLookupStore.md)

The store from which glyphs are to be retrieved from.

`font` [FontUsage](osu.Framework.Graphics.Sprites.FontUsage.md)

The font to use for glyph lookups from <code class="paramref">store</code>.

`maxWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

The maximum width of the resulting text bounds.

`useFontSizeAsHeight` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True to use the provided <xref href="osu.Framework.Text.TextBuilder.font" data-throw-if-not-resolved="false"></xref> size as the height for each line. False if the height of each individual glyph should be used.

`startOffset` Vector2

The offset at which characters should begin being added at.

`spacing` Vector2

The spacing between characters.

`characterList` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[TextBuilderGlyph](osu.Framework.Text.TextBuilderGlyph.md)\>

That list to contain all resulting <xref href="osu.Framework.Text.TextBuilderGlyph" data-throw-if-not-resolved="false"></xref>s.

`neverFixedWidthCharacters` [char](https://learn.microsoft.com/dotnet/api/system.char)\[\]

The characters for which fixed width should never be applied.

`fallbackCharacter` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to use if a glyph lookup fails.

`fixedWidthReferenceCharacter` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to use to calculate the fixed width width. Defaults to 'm'.

## Fields

### <a id="osu_Framework_Text_TextBuilder_Characters"></a> Characters

The characters generated by this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly List<TextBuilderGlyph> Characters
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[TextBuilderGlyph](osu.Framework.Text.TextBuilderGlyph.md)\>

## Properties

### <a id="osu_Framework_Text_TextBuilder_Bounds"></a> Bounds

The bounding size of the composite text.

```csharp
public Vector2 Bounds { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Text_TextBuilder_CanAddCharacters"></a> CanAddCharacters

Whether characters can be added to this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool CanAddCharacters { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Text_TextBuilder_LineBaseHeight"></a> LineBaseHeight

Gets the current base height of the text in this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public float LineBaseHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

Thrown when attempting to access this property on a <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref> with multiple lines added.

## Methods

### <a id="osu_Framework_Text_TextBuilder_AddCharacter_System_Char_"></a> AddCharacter\(char\)

Appends a character to this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool AddCharacter(char character)
```

#### Parameters

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to append.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether characters can still be added.

### <a id="osu_Framework_Text_TextBuilder_AddNewLine"></a> AddNewLine\(\)

Adds a new line to this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddNewLine()
```

#### Remarks

A height equal to that of the font size will be assumed if the current line is empty, regardless of <xref href="osu.Framework.Text.TextBuilder.useFontSizeAsHeight" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Text_TextBuilder_AddText_System_String_"></a> AddText\(string\)

Appends text to this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public void AddText(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

The text to append.

### <a id="osu_Framework_Text_TextBuilder_HasAvailableSpace_System_Single_"></a> HasAvailableSpace\(float\)

Whether there is enough space in the available text bounds.

```csharp
protected virtual bool HasAvailableSpace(float length)
```

#### Parameters

`length` [float](https://learn.microsoft.com/dotnet/api/system.single)

The space requested.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Text_TextBuilder_OnWidthExceeded"></a> OnWidthExceeded\(\)

Invoked when a character is being added that exceeds the maximum width of the text bounds.

```csharp
protected virtual void OnWidthExceeded()
```

#### Remarks

The character will not continue being added if <xref href="osu.Framework.Text.TextBuilder.CanAddCharacters" data-throw-if-not-resolved="false"></xref> is changed during this invocation.

### <a id="osu_Framework_Text_TextBuilder_RemoveLastCharacter"></a> RemoveLastCharacter\(\)

Removes the last character added to this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.
If the character is the first character on a new line, the new line is also removed.

```csharp
public void RemoveLastCharacter()
```

### <a id="osu_Framework_Text_TextBuilder_Reset"></a> Reset\(\)

Resets this <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref> to a default state.

```csharp
public virtual void Reset()
```

