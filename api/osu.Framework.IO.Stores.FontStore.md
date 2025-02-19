# <a id="osu_Framework_IO_Stores_FontStore"></a> Class FontStore

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

```csharp
public class FontStore : TextureStore, ITextureStore, IResourceStore<Texture>, IDisposable, ITexturedGlyphLookupStore
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureStore](osu.Framework.Graphics.Textures.TextureStore.md) ← 
[FontStore](osu.Framework.IO.Stores.FontStore.md)

#### Implements

[ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md), 
[IResourceStore<Texture\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[ITexturedGlyphLookupStore](osu.Framework.Text.ITexturedGlyphLookupStore.md)

#### Inherited Members

[TextureStore.Atlas](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_Atlas), 
[TextureStore.ScaleAdjust](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_ScaleAdjust), 
[TextureStore.AddTextureSource\(IResourceStore<TextureUpload\>\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_AddTextureSource\_osu\_Framework\_IO\_Stores\_IResourceStore\_osu\_Framework\_Graphics\_Textures\_TextureUpload\_\_), 
[TextureStore.RemoveTextureStore\(IResourceStore<TextureUpload\>\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_RemoveTextureStore\_osu\_Framework\_IO\_Stores\_IResourceStore\_osu\_Framework\_Graphics\_Textures\_TextureUpload\_\_), 
[TextureStore.AddStore\(ITextureStore\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_AddStore\_osu\_Framework\_Graphics\_Textures\_ITextureStore\_), 
[TextureStore.RemoveStore\(ITextureStore\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_RemoveStore\_osu\_Framework\_Graphics\_Textures\_ITextureStore\_), 
[TextureStore.GetAsync\(string, CancellationToken\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_GetAsync\_System\_String\_System\_Threading\_CancellationToken\_), 
[TextureStore.GetAsync\(string, WrapMode, WrapMode, CancellationToken\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_GetAsync\_System\_String\_osu\_Framework\_Graphics\_Textures\_WrapMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_System\_Threading\_CancellationToken\_), 
[TextureStore.Get\(string\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_Get\_System\_String\_), 
[TextureStore.Get\(string, WrapMode, WrapMode\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_Get\_System\_String\_osu\_Framework\_Graphics\_Textures\_WrapMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_), 
[TextureStore.GetStream\(string\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_GetStream\_System\_String\_), 
[TextureStore.GetAvailableResources\(\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_GetAvailableResources), 
[TextureStore.TryGetCached\(string, out Texture\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_TryGetCached\_System\_String\_osu\_Framework\_Graphics\_Textures\_Texture\_\_), 
[TextureStore.CacheAndReturnTexture\(string, Texture\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_CacheAndReturnTexture\_System\_String\_osu\_Framework\_Graphics\_Textures\_Texture\_), 
[TextureStore.Purge\(Texture\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_Purge\_osu\_Framework\_Graphics\_Textures\_Texture\_), 
[TextureStore.Dispose\(\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_Dispose), 
[TextureStore.Dispose\(bool\)](osu.Framework.Graphics.Textures.TextureStore.md\#osu\_Framework\_Graphics\_Textures\_TextureStore\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FontStore\>\(FontStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FontStore\>\(FontStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FontStore\>\(FontStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FontStore\>\(FontStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FontStore, TChild\>\(FontStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FontStore, TChild\>\(FontStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FontStore, TChild\>\(FontStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FontStore\>\(FontStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Stores_FontStore__ctor_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__System_Single_"></a> FontStore\(IRenderer, IResourceStore<TextureUpload\>, float\)

Construct a font store to be added to a parent font store via <xref href="osu.Framework.IO.Stores.FontStore.AddStore(osu.Framework.Graphics.Textures.ITextureStore)" data-throw-if-not-resolved="false"></xref>.

```csharp
public FontStore(IRenderer renderer, IResourceStore<TextureUpload> store = null, float scaleAdjust = 100)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to create textures with.

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The texture source.

`scaleAdjust` [float](https://learn.microsoft.com/dotnet/api/system.single)

The raw pixel height of the font. Can be used to apply a global scale or metric to font usages.

### <a id="osu_Framework_IO_Stores_FontStore__ctor_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__System_Single_osu_Framework_Graphics_Textures_TextureFilteringMode_"></a> FontStore\(IRenderer, IResourceStore<TextureUpload\>, float, TextureFilteringMode\)

Construct a font store with a custom filtering mode to be added to a parent font store via <xref href="osu.Framework.IO.Stores.FontStore.AddStore(osu.Framework.Graphics.Textures.ITextureStore)" data-throw-if-not-resolved="false"></xref>.
All fonts that use the specified filter mode should be nested inside this store to make optimal use of texture atlases.

```csharp
public FontStore(IRenderer renderer, IResourceStore<TextureUpload> store = null, float scaleAdjust = 100, TextureFilteringMode minFilterMode = TextureFilteringMode.Linear)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to create textures with.

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The texture source.

`scaleAdjust` [float](https://learn.microsoft.com/dotnet/api/system.single)

The raw pixel height of the font. Can be used to apply a global scale or metric to font usages.

`minFilterMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

The texture minification filtering mode to use.

## Methods

### <a id="osu_Framework_IO_Stores_FontStore_AddStore_osu_Framework_Graphics_Textures_ITextureStore_"></a> AddStore\(ITextureStore\)

Adds a nested texture store to use during <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref> lookup if not found in this store.

```csharp
public override void AddStore(ITextureStore store)
```

#### Parameters

`store` [ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md)

The store to add.

#### Remarks

Of note, nested stores will use their own sources and not include any sources added via <xref href="osu.Framework.Graphics.Textures.TextureStore.AddTextureSource(osu.Framework.IO.Stores.IResourceStore%7bosu.Framework.Graphics.Textures.TextureUpload%7d)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_IO_Stores_FontStore_AddTextureSource_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__"></a> AddTextureSource\(IResourceStore<TextureUpload\>\)

Adds a texture data lookup source to load <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>s with.

```csharp
public override void AddTextureSource(IResourceStore<TextureUpload> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The store to add.

#### Remarks

Lookup sources can be implemented easily using a <xref href="osu.Framework.Graphics.Textures.TextureLoaderStore" data-throw-if-not-resolved="false"></xref> to provide the final <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_IO_Stores_FontStore_Get_System_String_System_Char_"></a> Get\(string, char\)

Retrieves a glyph from the store.

```csharp
public ITexturedCharacterGlyph Get(string fontName, char character)
```

#### Parameters

`fontName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the font.

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to retrieve.

#### Returns

 [ITexturedCharacterGlyph](osu.Framework.Text.ITexturedCharacterGlyph.md)

The character glyph.

### <a id="osu_Framework_IO_Stores_FontStore_GetAsync_System_String_System_Char_"></a> GetAsync\(string, char\)

Retrieves a glyph from the store asynchronously.

```csharp
public Task<ITexturedCharacterGlyph> GetAsync(string fontName, char character)
```

#### Parameters

`fontName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the font.

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to retrieve.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ITexturedCharacterGlyph](osu.Framework.Text.ITexturedCharacterGlyph.md)\>

The character glyph.

### <a id="osu_Framework_IO_Stores_FontStore_RemoveStore_osu_Framework_Graphics_Textures_ITextureStore_"></a> RemoveStore\(ITextureStore\)

Removes a nested texture store.

```csharp
public override void RemoveStore(ITextureStore store)
```

#### Parameters

`store` [ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md)

The store to remove.

### <a id="osu_Framework_IO_Stores_FontStore_RemoveTextureStore_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__"></a> RemoveTextureStore\(IResourceStore<TextureUpload\>\)

Removes a texture data lookup source.

```csharp
public override void RemoveTextureStore(IResourceStore<TextureUpload> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The store to remove.

