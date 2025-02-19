# <a id="osu_Framework_Graphics_Textures_TextureLoaderStore"></a> Class TextureLoaderStore

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

Handles the parsing of image data from standard image formats into <xref href="osu.Framework.Graphics.Textures.TextureUpload" data-throw-if-not-resolved="false"></xref>s ready for GPU consumption.

```csharp
public class TextureLoaderStore : IResourceStore<TextureUpload>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextureLoaderStore](osu.Framework.Graphics.Textures.TextureLoaderStore.md)

#### Implements

[IResourceStore<TextureUpload\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
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

[ObjectExtensions.AsNonNull<TextureLoaderStore\>\(TextureLoaderStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextureLoaderStore\>\(TextureLoaderStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextureLoaderStore\>\(TextureLoaderStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextureLoaderStore\>\(TextureLoaderStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextureLoaderStore, TChild\>\(TextureLoaderStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextureLoaderStore, TChild\>\(TextureLoaderStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextureLoaderStore, TChild\>\(TextureLoaderStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextureLoaderStore\>\(TextureLoaderStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore__ctor_osu_Framework_IO_Stores_IResourceStore_System_Byte____"></a> TextureLoaderStore\(IResourceStore<byte\[\]\>\)

```csharp
public TextureLoaderStore(IResourceStore<byte[]> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

## Methods

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_Get_System_String_"></a> Get\(string\)

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

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public Task<TextureUpload> GetAsync(string name, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[TextureUpload](osu.Framework.Graphics.Textures.TextureUpload.md)\>

The object.

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_Graphics_Textures_TextureLoaderStore_ImageFromStream__1_System_IO_Stream_"></a> ImageFromStream<TPixel\>\(Stream\)

```csharp
protected virtual Image<TPixel> ImageFromStream<TPixel>(Stream stream) where TPixel : unmanaged, IPixel<TPixel>
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

#### Returns

 Image<TPixel\>

#### Type Parameters

`TPixel` 

