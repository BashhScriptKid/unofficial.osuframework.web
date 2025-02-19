# <a id="osu_Framework_Text_MultilineTextBuilder"></a> Class MultilineTextBuilder

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class MultilineTextBuilder : TextBuilder, IHasLineBaseHeight
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextBuilder](osu.Framework.Text.TextBuilder.md) ← 
[MultilineTextBuilder](osu.Framework.Text.MultilineTextBuilder.md)

#### Implements

[IHasLineBaseHeight](osu.Framework.Graphics.Sprites.IHasLineBaseHeight.md)

#### Inherited Members

[TextBuilder.Bounds](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_Bounds), 
[TextBuilder.Characters](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_Characters), 
[TextBuilder.LineBaseHeight](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_LineBaseHeight), 
[TextBuilder.Reset\(\)](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_Reset), 
[TextBuilder.AddText\(string\)](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_AddText\_System\_String\_), 
[TextBuilder.AddCharacter\(char\)](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_AddCharacter\_System\_Char\_), 
[TextBuilder.AddNewLine\(\)](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_AddNewLine), 
[TextBuilder.RemoveLastCharacter\(\)](osu.Framework.Text.TextBuilder.md\#osu\_Framework\_Text\_TextBuilder\_RemoveLastCharacter), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MultilineTextBuilder\>\(MultilineTextBuilder?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MultilineTextBuilder\>\(MultilineTextBuilder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MultilineTextBuilder\>\(MultilineTextBuilder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MultilineTextBuilder\>\(MultilineTextBuilder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MultilineTextBuilder, TChild\>\(MultilineTextBuilder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MultilineTextBuilder, TChild\>\(MultilineTextBuilder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MultilineTextBuilder, TChild\>\(MultilineTextBuilder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MultilineTextBuilder\>\(MultilineTextBuilder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Text_MultilineTextBuilder__ctor_osu_Framework_Text_ITexturedGlyphLookupStore_osu_Framework_Graphics_Sprites_FontUsage_System_Single_System_Boolean_osuTK_Vector2_osuTK_Vector2_System_Collections_Generic_List_osu_Framework_Text_TextBuilderGlyph__System_Char___System_Char_System_Char_"></a> MultilineTextBuilder\(ITexturedGlyphLookupStore, FontUsage, float, bool, Vector2, Vector2, List<TextBuilderGlyph\>, char\[\], char, char\)

Creates a new <xref href="osu.Framework.Text.TextBuilder" data-throw-if-not-resolved="false"></xref>.

```csharp
public MultilineTextBuilder(ITexturedGlyphLookupStore store, FontUsage font, float maxWidth, bool useFontSizeAsHeight = true, Vector2 startOffset = default, Vector2 spacing = default, List<TextBuilderGlyph> characterList = null, char[] neverFixedWidthCharacters = null, char fallbackCharacter = '?', char fixedWidthReferenceCharacter = 'm')
```

#### Parameters

`store` [ITexturedGlyphLookupStore](osu.Framework.Text.ITexturedGlyphLookupStore.md)

The store from which glyphs are to be retrieved from.

`font` [FontUsage](osu.Framework.Graphics.Sprites.FontUsage.md)

The font to use for glyph lookups from <code class="paramref">store</code>.

`maxWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

The maximum width of the resulting text bounds.

`useFontSizeAsHeight` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True to use the provided <code class="paramref">font</code> size as the height for each line. False if the height of each individual glyph should be used.

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

## Methods

### <a id="osu_Framework_Text_MultilineTextBuilder_OnWidthExceeded"></a> OnWidthExceeded\(\)

Invoked when a character is being added that exceeds the maximum width of the text bounds.

```csharp
protected override void OnWidthExceeded()
```

#### Remarks

The character will not continue being added if <xref href="osu.Framework.Text.TextBuilder.CanAddCharacters" data-throw-if-not-resolved="false"></xref> is changed during this invocation.

