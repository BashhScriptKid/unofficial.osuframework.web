# <a id="osu_Framework_Graphics_Textures_TextureRegion"></a> Class TextureRegion

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

A sub-region of a <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public class TextureRegion : Texture, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Texture](osu.Framework.Graphics.Textures.Texture.md) ← 
[TextureRegion](osu.Framework.Graphics.Textures.TextureRegion.md)

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

[ObjectExtensions.AsNonNull<TextureRegion\>\(TextureRegion?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextureRegion\>\(TextureRegion\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextureRegion\>\(TextureRegion\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextureRegion\>\(TextureRegion\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextureRegion, TChild\>\(TextureRegion, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextureRegion, TChild\>\(TextureRegion, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextureRegion, TChild\>\(TextureRegion, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextureRegion\>\(TextureRegion\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_TextureRegion__ctor_osu_Framework_Graphics_Textures_Texture_osu_Framework_Graphics_Primitives_RectangleI_osu_Framework_Graphics_Textures_WrapMode_osu_Framework_Graphics_Textures_WrapMode_"></a> TextureRegion\(Texture, RectangleI, WrapMode, WrapMode\)

Creates a new sub-region of a <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public TextureRegion(Texture parent, RectangleI bounds, WrapMode wrapModeS, WrapMode wrapModeT)
```

#### Parameters

`parent` [Texture](osu.Framework.Graphics.Textures.Texture.md)

The <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref> to create a sub-region of.

`bounds` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The texture-space area in <code class="paramref">parent</code> which bounds this texture.

`wrapModeS` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The horizontal wrap mode for this region.

`wrapModeT` [WrapMode](osu.Framework.Graphics.Textures.WrapMode.md)

The vertical warp mode for this region.

## Properties

### <a id="osu_Framework_Graphics_Textures_TextureRegion_Height"></a> Height

The height of this <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public override int Height { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Textures_TextureRegion_Width"></a> Width

The width of this <xref href="osu.Framework.Graphics.Textures.Texture" data-throw-if-not-resolved="false"></xref>.

```csharp
public override int Width { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Textures_TextureRegion_GetTextureRect_System_Nullable_osu_Framework_Graphics_Primitives_RectangleF__"></a> GetTextureRect\(RectangleF?\)

Computes the UV coordinates of a sub-area of this texture.

```csharp
public override RectangleF GetTextureRect(RectangleF? area = null)
```

#### Parameters

`area` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)?

A display-space area of this texture to compute the UV coordinates of.<br />
    The full area is used if not provided: (0, 0, <xref href="osu.Framework.Graphics.Textures.Texture.DisplayWidth" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Textures.Texture.DisplayHeight" data-throw-if-not-resolved="false"></xref>).

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The UV coordinates of <code class="paramref">area</code> in this texture.

