# <a id="osu_Framework_IO_Stores_RawCachingGlyphStore"></a> Class RawCachingGlyphStore

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

A glyph store which caches font sprite sheets as raw pixels to disk on first use.

```csharp
public class RawCachingGlyphStore : GlyphStore, IResourceStore<TextureUpload>, IGlyphStore, IResourceStore<CharacterGlyph>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GlyphStore](osu.Framework.IO.Stores.GlyphStore.md) ← 
[RawCachingGlyphStore](osu.Framework.IO.Stores.RawCachingGlyphStore.md)

#### Implements

[IResourceStore<TextureUpload\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IGlyphStore](osu.Framework.IO.Stores.IGlyphStore.md), 
[IResourceStore<CharacterGlyph\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[GlyphStore.AssetName](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_AssetName), 
[GlyphStore.TextureLoader](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_TextureLoader), 
[GlyphStore.FontName](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_FontName), 
[GlyphStore.Baseline](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Baseline), 
[GlyphStore.Store](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Store), 
[GlyphStore.Font](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Font), 
[GlyphStore.LoadFontAsync\(\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_LoadFontAsync), 
[GlyphStore.HasGlyph\(char\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_HasGlyph\_System\_Char\_), 
[GlyphStore.GetPageImage\(int\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_GetPageImage\_System\_Int32\_), 
[GlyphStore.GetFilenameForPage\(int\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_GetFilenameForPage\_System\_Int32\_), 
[GlyphStore.Get\(char\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Get\_System\_Char\_), 
[GlyphStore.GetKerning\(char, char\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_GetKerning\_System\_Char\_System\_Char\_), 
[GlyphStore.Get\(string\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Get\_System\_String\_), 
[GlyphStore.GetAsync\(string, CancellationToken\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_GetAsync\_System\_String\_System\_Threading\_CancellationToken\_), 
[GlyphStore.LoadedGlyphCount](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_LoadedGlyphCount), 
[GlyphStore.LoadCharacter\(Character\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_LoadCharacter\_SharpFNT\_Character\_), 
[GlyphStore.GetStream\(string\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_GetStream\_System\_String\_), 
[GlyphStore.GetAvailableResources\(\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_GetAvailableResources), 
[GlyphStore.Dispose\(\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Dispose), 
[GlyphStore.Dispose\(bool\)](osu.Framework.IO.Stores.GlyphStore.md\#osu\_Framework\_IO\_Stores\_GlyphStore\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RawCachingGlyphStore\>\(RawCachingGlyphStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RawCachingGlyphStore\>\(RawCachingGlyphStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RawCachingGlyphStore\>\(RawCachingGlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RawCachingGlyphStore\>\(RawCachingGlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<RawCachingGlyphStore, TChild\>\(RawCachingGlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RawCachingGlyphStore, TChild\>\(RawCachingGlyphStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RawCachingGlyphStore, TChild\>\(RawCachingGlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RawCachingGlyphStore\>\(RawCachingGlyphStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

This results in memory efficient lookups with good performance on solid state backed devices.
Consider <xref href="osu.Framework.IO.Stores.TimedExpiryGlyphStore" data-throw-if-not-resolved="false"></xref> if disk IO is limited and memory usage is not an issue.

## Constructors

### <a id="osu_Framework_IO_Stores_RawCachingGlyphStore__ctor_osu_Framework_IO_Stores_ResourceStore_System_Byte____System_String_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__"></a> RawCachingGlyphStore\(ResourceStore<byte\[\]\>, string?, IResourceStore<TextureUpload\>?\)

```csharp
public RawCachingGlyphStore(ResourceStore<byte[]> store, string? assetName = null, IResourceStore<TextureUpload>? textureLoader = null)
```

#### Parameters

`store` [ResourceStore](osu.Framework.IO.Stores.ResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

`assetName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`textureLoader` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>?

## Methods

### <a id="osu_Framework_IO_Stores_RawCachingGlyphStore_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Stores_RawCachingGlyphStore_LoadCharacter_SharpFNT_Character_"></a> LoadCharacter\(Character\)

```csharp
protected override TextureUpload LoadCharacter(Character character)
```

#### Parameters

`character` Character

#### Returns

 [TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

