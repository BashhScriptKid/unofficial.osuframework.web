# <a id="osu_Framework_Graphics_Textures_DisposableTexture"></a> Class DisposableTexture

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

A texture which can cleans up any resources held by the underlying <xref href="osu.Framework.Graphics.Rendering.INativeTexture" data-throw-if-not-resolved="false"></xref> on <xref href="osu.Framework.Graphics.Textures.DisposableTexture.Dispose(System.Boolean)" data-throw-if-not-resolved="false"></xref>.

```csharp
public class DisposableTexture : Texture, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Texture](osu.Framework.Graphics.Textures.Texture.md) ← 
[DisposableTexture](osu.Framework.Graphics.Textures.DisposableTexture.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[Texture.AssetName](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_AssetName), 
[Texture.ScaleAdjust](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_ScaleAdjust), 
[Texture.DisplayWidth](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_DisplayWidth), 
[Texture.DisplayHeight](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_DisplayHeight), 
[Texture.DisplaySize](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_DisplaySize), 
[Texture.Opacity](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Opacity), 
[Texture.WrapModeS](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_WrapModeS), 
[Texture.WrapModeT](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_WrapModeT), 
[Texture.Crop\(RectangleF, Axes, WrapMode, WrapMode\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Crop\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_osu\_Framework\_Graphics\_Axes\_osu\_Framework\_Graphics\_Textures\_WrapMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_), 
[Texture.FromStream\(IRenderer, Stream?, TextureAtlas?\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_FromStream\_osu\_Framework\_Graphics\_Rendering\_IRenderer\_System\_IO\_Stream\_osu\_Framework\_Graphics\_Textures\_TextureAtlas\_), 
[Texture.Width](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Width), 
[Texture.Height](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Height), 
[Texture.Size](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Size), 
[Texture.Bind\(int\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Bind\_System\_Int32\_), 
[Texture.Bind\(int, WrapMode, WrapMode\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Bind\_System\_Int32\_osu\_Framework\_Graphics\_Textures\_WrapMode\_osu\_Framework\_Graphics\_Textures\_WrapMode\_), 
[Texture.SetData\(ITextureUpload\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_SetData\_osu\_Framework\_Graphics\_Textures\_ITextureUpload\_), 
[Texture.SetData\(ITextureUpload, Opacity\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_SetData\_osu\_Framework\_Graphics\_Textures\_ITextureUpload\_osu\_Framework\_Graphics\_Textures\_Opacity\_), 
[Texture.ComputeOpacity\(ITextureUpload\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_ComputeOpacity\_osu\_Framework\_Graphics\_Textures\_ITextureUpload\_), 
[Texture.UpdateOpacity\(ITextureUpload, ref Opacity?\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_UpdateOpacity\_osu\_Framework\_Graphics\_Textures\_ITextureUpload\_System\_Nullable\_osu\_Framework\_Graphics\_Textures\_Opacity\_\_\_), 
[Texture.GetTextureRect\(RectangleF?\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_GetTextureRect\_System\_Nullable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_\_), 
[Texture.ToString\(\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_ToString), 
[Texture.Available](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Available), 
[Texture.UploadComplete](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_UploadComplete), 
[Texture.BypassTextureUploadQueueing](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_BypassTextureUploadQueueing), 
[Texture.Dispose\(\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Dispose), 
[Texture.Dispose\(bool\)](osu.Framework.Graphics.Textures.Texture.md\#osu\_Framework\_Graphics\_Textures\_Texture\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DisposableTexture\>\(DisposableTexture?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DisposableTexture\>\(DisposableTexture\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DisposableTexture\>\(DisposableTexture\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DisposableTexture\>\(DisposableTexture\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DisposableTexture, TChild\>\(DisposableTexture, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DisposableTexture, TChild\>\(DisposableTexture, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DisposableTexture, TChild\>\(DisposableTexture, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DisposableTexture\>\(DisposableTexture\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_DisposableTexture__ctor_osu_Framework_Graphics_Textures_Texture_"></a> DisposableTexture\(Texture\)

```csharp
public DisposableTexture(Texture parent)
```

#### Parameters

`parent` [Texture](osu.Framework.Graphics.Textures.Texture.md)

## Methods

### <a id="osu_Framework_Graphics_Textures_DisposableTexture_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

