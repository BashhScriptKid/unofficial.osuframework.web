# <a id="osu_Framework_Graphics_Textures_ITextureStore"></a> Interface ITextureStore

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

Provides drawable-ready <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>s.

```csharp
public interface ITextureStore : IResourceStore<Texture>, IDisposable
```

#### Implements

[IResourceStore<Texture\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<ITextureStore\>\(ITextureStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITextureStore\>\(ITextureStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITextureStore\>\(ITextureStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITextureStore\>\(ITextureStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITextureStore, TChild\>\(ITextureStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITextureStore, TChild\>\(ITextureStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITextureStore, TChild\>\(ITextureStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITextureStore\>\(ITextureStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Textures_ITextureStore_Get_System_String_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> Get\(string, WrapMode, WrapMode\)

Retrieves a texture from the store.

```csharp
Texture? Get(string name, WrapMode wrapModeS, WrapMode wrapModeT)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the texture.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in horizontal direction.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in vertical direction.

#### Returns

 [Texture](osu.Framework.Graphics.Textures.Texture.md)?

The texture.

### <a id="osu_Framework_Graphics_Textures_ITextureStore_GetAsync_System_String_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_System_Threading_CancellationToken_"></a> GetAsync\(string, WrapMode, WrapMode, CancellationToken\)

Retrieves a texture from the store asynchronously.

```csharp
Task<Texture?> GetAsync(string name, WrapMode wrapModeS, WrapMode wrapModeT, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the texture.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in horizontal direction.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The texture wrap mode in vertical direction.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Texture](osu.Framework.Graphics.Textures.Texture.md)?\>

The texture.

