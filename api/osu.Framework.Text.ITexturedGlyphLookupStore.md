# <a id="osu_Framework_Text_ITexturedGlyphLookupStore"></a> Interface ITexturedGlyphLookupStore

Namespace: [osu.Framework.Text](osu.Framework.Text.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ITexturedGlyphLookupStore
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ITexturedGlyphLookupStore\>\(ITexturedGlyphLookupStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITexturedGlyphLookupStore\>\(ITexturedGlyphLookupStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITexturedGlyphLookupStore\>\(ITexturedGlyphLookupStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITexturedGlyphLookupStore\>\(ITexturedGlyphLookupStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITexturedGlyphLookupStore, TChild\>\(ITexturedGlyphLookupStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITexturedGlyphLookupStore, TChild\>\(ITexturedGlyphLookupStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITexturedGlyphLookupStore, TChild\>\(ITexturedGlyphLookupStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITexturedGlyphLookupStore\>\(ITexturedGlyphLookupStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Text_ITexturedGlyphLookupStore_Get_System_String_System_Char_"></a> Get\(string?, char\)

Retrieves a glyph from the store.

```csharp
ITexturedCharacterGlyph? Get(string? fontName, char character)
```

#### Parameters

`fontName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The name of the font.

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to retrieve.

#### Returns

 [ITexturedCharacterGlyph](osu.Framework.Text.ITexturedCharacterGlyph.md)?

The character glyph.

### <a id="osu_Framework_Text_ITexturedGlyphLookupStore_GetAsync_System_String_System_Char_"></a> GetAsync\(string, char\)

Retrieves a glyph from the store asynchronously.

```csharp
Task<ITexturedCharacterGlyph?> GetAsync(string fontName, char character)
```

#### Parameters

`fontName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the font.

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to retrieve.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ITexturedCharacterGlyph](osu.Framework.Text.ITexturedCharacterGlyph.md)?\>

The character glyph.

