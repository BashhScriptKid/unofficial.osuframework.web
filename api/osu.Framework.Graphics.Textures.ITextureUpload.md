# <a id="osu_Framework_Graphics_Textures_ITextureUpload"></a> Interface ITextureUpload

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ITextureUpload : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<ITextureUpload\>\(ITextureUpload?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITextureUpload\>\(ITextureUpload\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITextureUpload\>\(ITextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITextureUpload\>\(ITextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITextureUpload, TChild\>\(ITextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITextureUpload, TChild\>\(ITextureUpload, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITextureUpload, TChild\>\(ITextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITextureUpload\>\(ITextureUpload\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Textures_ITextureUpload_Bounds"></a> Bounds

The target bounds for this upload. If not specified, will assume to be (0, 0, width, height).

```csharp
RectangleI Bounds { get; set; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Textures_ITextureUpload_Data"></a> Data

The raw data to be uploaded.

```csharp
ReadOnlySpan<Rgba32> Data { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Rgba32\>

### <a id="osu_Framework_Graphics_Textures_ITextureUpload_Format"></a> Format

The texture format for this upload.

```csharp
PixelFormat Format { get; }
```

#### Property Value

 PixelFormat

### <a id="osu_Framework_Graphics_Textures_ITextureUpload_Level"></a> Level

The target mipmap level to upload into.

```csharp
int Level { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

