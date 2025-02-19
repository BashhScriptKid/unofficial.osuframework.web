# <a id="osu_Framework_IO_Stores_GlyphStore"></a> Class GlyphStore

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

A basic glyph store that will load font sprite sheets every character retrieval.

```csharp
public class GlyphStore : IResourceStore<TextureUpload>, IGlyphStore, IResourceStore<CharacterGlyph>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GlyphStore](osu.Framework.IO.Stores.GlyphStore.md)

#### Derived

[RawCachingGlyphStore](osu.Framework.IO.Stores.RawCachingGlyphStore.md), 
[TimedExpiryGlyphStore](osu.Framework.IO.Stores.TimedExpiryGlyphStore.md)

#### Implements

[IResourceStore<TextureUpload\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IGlyphStore](osu.Framework.IO.Stores.IGlyphStore.md), 
[IResourceStore<CharacterGlyph\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GlyphStore\>\(GlyphStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GlyphStore\>\(GlyphStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GlyphStore\>\(GlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GlyphStore\>\(GlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GlyphStore, TChild\>\(GlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GlyphStore, TChild\>\(GlyphStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GlyphStore, TChild\>\(GlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GlyphStore\>\(GlyphStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Stores_GlyphStore__ctor_osu_Framework_IO_Stores_ResourceStore_System_Byte____System_String_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__"></a> GlyphStore\(ResourceStore<byte\[\]\>, string, IResourceStore<TextureUpload\>\)

Create a new glyph store.

```csharp
public GlyphStore(ResourceStore<byte[]> store, string assetName = null, IResourceStore<TextureUpload> textureLoader = null)
```

#### Parameters

`store` [ResourceStore](osu.Framework.IO.Stores.ResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The store to provide font resources.

`assetName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The base name of the font.

`textureLoader` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

An optional platform-specific store for loading textures. Should load for the store provided in <param ref="param" />.

## Fields

### <a id="osu_Framework_IO_Stores_GlyphStore_AssetName"></a> AssetName

```csharp
protected readonly string AssetName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Stores_GlyphStore_LoadedGlyphCount"></a> LoadedGlyphCount

```csharp
protected int LoadedGlyphCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_IO_Stores_GlyphStore_Store"></a> Store

```csharp
protected readonly ResourceStore<byte[]> Store
```

#### Field Value

 [ResourceStore](osu.Framework.IO.Stores.ResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

### <a id="osu_Framework_IO_Stores_GlyphStore_TextureLoader"></a> TextureLoader

```csharp
protected readonly IResourceStore<TextureUpload> TextureLoader
```

#### Field Value

 [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

## Properties

### <a id="osu_Framework_IO_Stores_GlyphStore_Baseline"></a> Baseline

The font's baseline position, or <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if not available (i.e. font not loaded or failed to load).

```csharp
public float? Baseline { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="osu_Framework_IO_Stores_GlyphStore_Font"></a> Font

```csharp
[CanBeNull]
protected BitmapFont Font { get; }
```

#### Property Value

 BitmapFont

### <a id="osu_Framework_IO_Stores_GlyphStore_FontName"></a> FontName

The font's full name to be used for lookups.

```csharp
public string FontName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_IO_Stores_GlyphStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_IO_Stores_GlyphStore_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Stores_GlyphStore_Get_System_Char_"></a> Get\(char\)

Retrieves a <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> that contains associated spacing information for a character.

```csharp
public CharacterGlyph Get(char character)
```

#### Parameters

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to retrieve the <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> for.

#### Returns

 [CharacterGlyph](osu.Framework.Text.CharacterGlyph.md)

The <xref href="osu.Framework.Text.CharacterGlyph" data-throw-if-not-resolved="false"></xref> containing associated spacing information for <code class="paramref">character</code>.

### <a id="osu_Framework_IO_Stores_GlyphStore_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
public TextureUpload Get(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

#### Returns

 [TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

The object.

### <a id="osu_Framework_IO_Stores_GlyphStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public virtual Task<TextureUpload> GetAsync(string name, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The object.

### <a id="osu_Framework_IO_Stores_GlyphStore_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_IO_Stores_GlyphStore_GetFilenameForPage_System_Int32_"></a> GetFilenameForPage\(int\)

```csharp
protected string GetFilenameForPage(int page)
```

#### Parameters

`page` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Stores_GlyphStore_GetKerning_System_Char_System_Char_"></a> GetKerning\(char, char\)

Retrieves the kerning for a pair of characters.

```csharp
public int GetKerning(char left, char right)
```

#### Parameters

`left` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to the left.

`right` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to the right.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The kerning.

### <a id="osu_Framework_IO_Stores_GlyphStore_GetPageImage_System_Int32_"></a> GetPageImage\(int\)

```csharp
protected virtual TextureUpload GetPageImage(int page)
```

#### Parameters

`page` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

### <a id="osu_Framework_IO_Stores_GlyphStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_IO_Stores_GlyphStore_HasGlyph_System_Char_"></a> HasGlyph\(char\)

Whether a glyph exists for the specified character in this store.

```csharp
public bool HasGlyph(char c)
```

#### Parameters

`c` [char](https://learn.microsoft.com/dotnet/api/system.char)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Stores_GlyphStore_LoadCharacter_SharpFNT_Character_"></a> LoadCharacter\(Character\)

```csharp
protected virtual TextureUpload LoadCharacter(Character character)
```

#### Parameters

`character` Character

#### Returns

 [TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

### <a id="osu_Framework_IO_Stores_GlyphStore_LoadFontAsync"></a> LoadFontAsync\(\)

Loads glyph information for consumption asynchronously.

```csharp
public Task LoadFontAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

