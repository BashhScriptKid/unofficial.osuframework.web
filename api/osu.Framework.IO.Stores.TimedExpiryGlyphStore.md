# <a id="osu_Framework_IO_Stores_TimedExpiryGlyphStore"></a> Class TimedExpiryGlyphStore

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

A glyph store which caches font sprite sheets in memory temporary, to allow for more efficient retrieval.

```csharp
public class TimedExpiryGlyphStore : GlyphStore, IResourceStore<TextureUpload>, IGlyphStore, IResourceStore<CharacterGlyph>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GlyphStore](osu.Framework.IO.Stores.GlyphStore.md) ← 
[TimedExpiryGlyphStore](osu.Framework.IO.Stores.TimedExpiryGlyphStore.md)

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

[ObjectExtensions.AsNonNull<TimedExpiryGlyphStore\>\(TimedExpiryGlyphStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TimedExpiryGlyphStore\>\(TimedExpiryGlyphStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TimedExpiryGlyphStore\>\(TimedExpiryGlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TimedExpiryGlyphStore\>\(TimedExpiryGlyphStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TimedExpiryGlyphStore, TChild\>\(TimedExpiryGlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TimedExpiryGlyphStore, TChild\>\(TimedExpiryGlyphStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TimedExpiryGlyphStore, TChild\>\(TimedExpiryGlyphStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TimedExpiryGlyphStore\>\(TimedExpiryGlyphStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

This store has a higher memory overhead than <xref href="osu.Framework.IO.Stores.RawCachingGlyphStore" data-throw-if-not-resolved="false"></xref>, but better performance and zero disk footprint.

## Constructors

### <a id="osu_Framework_IO_Stores_TimedExpiryGlyphStore__ctor_osu_Framework_IO_Stores_ResourceStore_System_Byte____System_String_"></a> TimedExpiryGlyphStore\(ResourceStore<byte\[\]\>, string\)

```csharp
public TimedExpiryGlyphStore(ResourceStore<byte[]> store, string assetName = null)
```

#### Parameters

`store` [ResourceStore](osu.Framework.IO.Stores.ResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

`assetName` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_IO_Stores_TimedExpiryGlyphStore_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Stores_TimedExpiryGlyphStore_GetPageImage_System_Int32_"></a> GetPageImage\(int\)

```csharp
protected override TextureUpload GetPageImage(int page)
```

#### Parameters

`page` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)

### <a id="osu_Framework_IO_Stores_TimedExpiryGlyphStore_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

