# <a id="osu_Framework_IO_Stores_IGlyphStore"></a> Interface IGlyphStore

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

Interface for a <xref href="osu.Framework.IO.Stores.IResourceStore%601" data-throw-if-not-resolved="false"></xref> of <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IGlyphStore : IResourceStore<CharacterGlyph>, IDisposable
```

#### Implements

[IResourceStore<CharacterGlyph\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IGlyphStore\>\(IGlyphStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IGlyphStore\>\(IGlyphStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IGlyphStore\>\(IGlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IGlyphStore\>\(IGlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IGlyphStore, TChild\>\(IGlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IGlyphStore, TChild\>\(IGlyphStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IGlyphStore, TChild\>\(IGlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IGlyphStore\>\(IGlyphStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_IO_Stores_IGlyphStore_Baseline"></a> Baseline

The font's baseline position, or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if not available (i.e. font not loaded or failed to load).

```csharp
float? Baseline { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="osu_Framework_IO_Stores_IGlyphStore_FontName"></a> FontName

The font's full name to be used for lookups.

```csharp
string FontName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_IO_Stores_IGlyphStore_Get_System_Char_"></a> Get\(char\)

Retrieves a <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> that contains associated spacing information for a character.

```csharp
CharacterGlyph? Get(char character)
```

#### Parameters

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to retrieve the <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> for.

#### Returns

 [CharacterGlyph](osu.Framework.Text.CharacterGlyph.md)?

The <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> containing associated spacing information for <code class="paramref">character</code>.

### <a id="osu_Framework_IO_Stores_IGlyphStore_GetKerning_System_Char_System_Char_"></a> GetKerning\(char, char\)

Retrieves the kerning for a pair of characters.

```csharp
int GetKerning(char left, char right)
```

#### Parameters

`left` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to the left.

`right` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to the right.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The kerning.

### <a id="osu_Framework_IO_Stores_IGlyphStore_HasGlyph_System_Char_"></a> HasGlyph\(char\)

Whether a glyph exists for the specified character in this store.

```csharp
bool HasGlyph(char c)
```

#### Parameters

`c` [char](https://learn.microsoft.com/dotnet/api/system.char)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Stores_IGlyphStore_LoadFontAsync"></a> LoadFontAsync\(\)

Loads glyph information for consumption asynchronously.

```csharp
Task LoadFontAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

