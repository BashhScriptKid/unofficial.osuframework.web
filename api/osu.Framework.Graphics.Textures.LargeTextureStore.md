# <a id="osu_Framework_Graphics_Textures_LargeTextureStore"></a> Class LargeTextureStore

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

A texture store that bypasses atlasing and removes textures from memory after dereferenced by all consumers.

```csharp
public class LargeTextureStore : TextureStore, ITextureStore, IResourceStore<Texture>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureStore](osu.Framework.Graphics.Textures.TextureStore.md) ← 
[LargeTextureStore](osu.Framework.Graphics.Textures.LargeTextureStore.md)

#### Implements

[ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md), 
[IResourceStore<Texture\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

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

[ObjectExtensions.AsNonNull<LargeTextureStore\>\(LargeTextureStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LargeTextureStore\>\(LargeTextureStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LargeTextureStore\>\(LargeTextureStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LargeTextureStore\>\(LargeTextureStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LargeTextureStore, TChild\>\(LargeTextureStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LargeTextureStore, TChild\>\(LargeTextureStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LargeTextureStore, TChild\>\(LargeTextureStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LargeTextureStore\>\(LargeTextureStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

It's recommended to use manual mipmaps since large textures are generally rendered at full resolution
and computing mipmaps automatically will be unnecessary overhead.

## Constructors

### <a id="osu_Framework_Graphics_Textures_LargeTextureStore__ctor_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__osu_Framework_Graphics_Textures_TextureFilteringMode_System_Boolean_"></a> LargeTextureStore\(IRenderer, IResourceStore<TextureUpload\>, TextureFilteringMode, bool\)

```csharp
public LargeTextureStore(IRenderer renderer, IResourceStore<TextureUpload> store = null, TextureFilteringMode filteringMode = TextureFilteringMode.Linear, bool manualMipmaps = true)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

`manualMipmaps` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Graphics_Textures_LargeTextureStore_CacheAndReturnTexture_System_String_osu_Framework_Graphics_Textures_Texture_"></a> CacheAndReturnTexture\(string, Texture\)

Caches and returns the given texture.

```csharp
protected override Texture CacheAndReturnTexture(string lookupKey, Texture texture)
```

#### Parameters

`lookupKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

The lookup key that uniquely identifies textures in the cache.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to be cached and returned.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to be returned.

### <a id="osu_Framework_Graphics_Textures_LargeTextureStore_TryGetCached_System_String_osu_Framework_Graphics_Textures_Texture__"></a> TryGetCached\(string, out Texture\)

Attempts to retrieve an existing cached texture.

```csharp
protected override bool TryGetCached(string lookupKey, out Texture texture)
```

#### Parameters

`lookupKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

The lookup key that uniquely identifies textures in the cache.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The returned texture. Null if the texture did not exist in the cache.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a cached texture was retrieved.

