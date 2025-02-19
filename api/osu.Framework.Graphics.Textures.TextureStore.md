# <a id="osu_Framework_Graphics_Textures_TextureStore"></a> Class TextureStore

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

Provides drawable-ready <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>s sourced from any number of provided sources (via constructor parameter or <xref href="osu.Framework.Graphics.Textures.TextureStore.AddTextureSource(osu.Framework.IO.Stores.IResourceStore%7bosu.Framework.Graphics.Textures.TextureUpload%7d)" data-throw-if-not-resolved="false"></xref>).

```csharp
public class TextureStore : ITextureStore, IResourceStore<Texture>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureStore](osu.Framework.Graphics.Textures.TextureStore.md)

#### Derived

[FontStore](osu.Framework.IO.Stores.FontStore.md), 
[LargeTextureStore](osu.Framework.Graphics.Textures.LargeTextureStore.md)

#### Implements

[ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md), 
[IResourceStore<Texture\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
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

[ObjectExtensions.AsNonNull<TextureStore\>\(TextureStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextureStore\>\(TextureStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextureStore\>\(TextureStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextureStore\>\(TextureStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextureStore, TChild\>\(TextureStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextureStore, TChild\>\(TextureStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextureStore, TChild\>\(TextureStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextureStore\>\(TextureStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_TextureStore__ctor_osu_Framework_Graphics_Rendering_IRenderer_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__System_Boolean_osu_Framework_Graphics_Textures_TextureFilteringMode_System_Boolean_System_Single_"></a> TextureStore\(IRenderer, IResourceStore<TextureUpload\>, bool, TextureFilteringMode, bool, float\)

```csharp
public TextureStore(IRenderer renderer, IResourceStore<TextureUpload> store = null, bool useAtlas = true, TextureFilteringMode filteringMode = TextureFilteringMode.Linear, bool manualMipmaps = false, float scaleAdjust = 2)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

`useAtlas` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`filteringMode` [TextureFilteringMode](osu.Framework.Graphics.Textures.TextureFilteringMode.md)

`manualMipmaps` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`scaleAdjust` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="osu_Framework_Graphics_Textures_TextureStore_Atlas"></a> Atlas

```csharp
protected TextureAtlas Atlas
```

#### Field Value

 [TextureAtlas](osu.Framework.Graphics.Textures.TextureAtlas.md)

### <a id="osu_Framework_Graphics_Textures_TextureStore_ScaleAdjust"></a> ScaleAdjust

Decides at what resolution multiple this <xref href="osu.Framework.Graphics.Textures.TextureStore" data-throw-if-not-resolved="false"></xref> is providing sprites at.
ie. if we are providing high resolution (at 2x the resolution of standard 1366x768) sprites this should be 2.

```csharp
public readonly float ScaleAdjust
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Textures_TextureStore_AddStore_osu_Framework_Graphics_Textures_ITextureStore_"></a> AddStore\(ITextureStore\)

Adds a nested texture store to use during <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref> lookup if not found in this store.

```csharp
public virtual void AddStore(ITextureStore store)
```

#### Parameters

`store` [ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md)

The store to add.

#### Remarks

Of note, nested stores will use their own sources and not include any sources added via <xref href="osu.Framework.Graphics.Textures.TextureStore.AddTextureSource(osu.Framework.IO.Stores.IResourceStore%7bosu.Framework.Graphics.Textures.TextureUpload%7d)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Textures_TextureStore_AddTextureSource_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__"></a> AddTextureSource\(IResourceStore<TextureUpload\>\)

Adds a texture data lookup source to load <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>s with.

```csharp
public virtual void AddTextureSource(IResourceStore<TextureUpload> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The store to add.

#### Remarks

Lookup sources can be implemented easily using a <xref href="osu.Framework.Graphics.Textures.TextureLoaderStore" data-throw-if-not-resolved="false"></xref> to provide the final <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Textures_TextureStore_CacheAndReturnTexture_System_String_osu_Framework_Graphics_Textures_Texture_"></a> CacheAndReturnTexture\(string, Texture\)

Caches and returns the given texture.

```csharp
[CanBeNull]
protected virtual Texture CacheAndReturnTexture(string lookupKey, Texture texture)
```

#### Parameters

`lookupKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

The lookup key that uniquely identifies textures in the cache.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to be cached and returned.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to be returned.

### <a id="osu_Framework_Graphics_Textures_TextureStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Textures_TextureStore_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Textures_TextureStore_Get_System_String_"></a> Get\(string\)

Retrieves a texture from the store and adds it to the atlas.

```csharp
public Texture Get(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the texture.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture.

### <a id="osu_Framework_Graphics_Textures_TextureStore_Get_System_String_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> Get\(string, WrapMode, WrapMode\)

Retrieves a texture from the store and adds it to the atlas.

```csharp
public virtual Texture Get(string name, WrapMode wrapModeS, WrapMode wrapModeT)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the texture.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in horizontal direction.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in vertical direction.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture.

### <a id="osu_Framework_Graphics_Textures_TextureStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves a texture from the store and adds it to the atlas.

```csharp
public Task<Texture> GetAsync(string name, CancellationToken cancellationToken)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the texture.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Texture](osu.Framework.Graphics.Textures.Texture.md)\>

The texture.

### <a id="osu_Framework_Graphics_Textures_TextureStore_GetAsync_System_String_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_System_Threading_CancellationToken_"></a> GetAsync\(string, WrapMode, WrapMode, CancellationToken\)

Retrieves a texture from the store and adds it to the atlas.

```csharp
public Task<Texture> GetAsync(string name, WrapMode wrapModeT, WrapMode wrapModeS, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the texture.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in vertical direction.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in horizontal direction.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Texture](osu.Framework.Graphics.Textures.Texture.md)\>

The texture.

### <a id="osu_Framework_Graphics_Textures_TextureStore_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_Graphics_Textures_TextureStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_Graphics_Textures_TextureStore_Purge_osu_Framework_Graphics_Textures_Texture_"></a> Purge\(Texture\)

Disposes and removes a texture from the cache.

```csharp
protected void Purge(Texture texture)
```

#### Parameters

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The texture to purge from the cache.

### <a id="osu_Framework_Graphics_Textures_TextureStore_RemoveStore_osu_Framework_Graphics_Textures_ITextureStore_"></a> RemoveStore\(ITextureStore\)

Removes a nested texture store.

```csharp
public virtual void RemoveStore(ITextureStore store)
```

#### Parameters

`store` [ITextureStore](osu.Framework.Graphics.Textures.ITextureStore.md)

The store to remove.

### <a id="osu_Framework_Graphics_Textures_TextureStore_RemoveTextureStore_osu_Framework_IO_Stores_IResourceStore_osu_Framework_Graphics_Textures_TextureUpload__"></a> RemoveTextureStore\(IResourceStore<TextureUpload\>\)

Removes a texture data lookup source.

```csharp
public virtual void RemoveTextureStore(IResourceStore<TextureUpload> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The store to remove.

### <a id="osu_Framework_Graphics_Textures_TextureStore_TryGetCached_System_String_osu_Framework_Graphics_Textures_Texture__"></a> TryGetCached\(string, out Texture\)

Attempts to retrieve an existing cached texture.

```csharp
protected virtual bool TryGetCached(string lookupKey, out Texture texture)
```

#### Parameters

`lookupKey` [string](https://learn.microsoft.com/dotnet/api/system.string)

The lookup key that uniquely identifies textures in the cache.

`texture` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The returned texture. Null if the texture did not exist in the cache.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a cached texture was retrieved.

