# <a id="osu_Framework_Platform_SDL3_SDL3Clipboard"></a> Class SDL3Clipboard

Namespace: [osu.Framework.Platform.SDL3](osu.Framework.Platform.SDL3.md)  
Assembly: osu.Framework.dll  

```csharp
public class SDL3Clipboard : Clipboard
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Clipboard](osu.Framework.Platform.Clipboard.md) ← 
[SDL3Clipboard](osu.Framework.Platform.SDL3.SDL3Clipboard.md)

#### Inherited Members

[Clipboard.GetText\(\)](osu.Framework.Platform.Clipboard.md\#osu\_Framework\_Platform\_Clipboard\_GetText), 
[Clipboard.SetText\(string\)](osu.Framework.Platform.Clipboard.md\#osu\_Framework\_Platform\_Clipboard\_SetText\_System\_String\_), 
[Clipboard.GetImage<TPixel\>\(\)](osu.Framework.Platform.Clipboard.md\#osu\_Framework\_Platform\_Clipboard\_GetImage\_\_1), 
[Clipboard.SetImage\(Image\)](osu.Framework.Platform.Clipboard.md\#osu\_Framework\_Platform\_Clipboard\_SetImage\_SixLabors\_ImageSharp\_Image\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SDL3Clipboard\>\(SDL3Clipboard?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SDL3Clipboard\>\(SDL3Clipboard\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SDL3Clipboard\>\(SDL3Clipboard\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SDL3Clipboard\>\(SDL3Clipboard\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SDL3Clipboard, TChild\>\(SDL3Clipboard, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SDL3Clipboard, TChild\>\(SDL3Clipboard, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SDL3Clipboard, TChild\>\(SDL3Clipboard, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SDL3Clipboard\>\(SDL3Clipboard\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_SDL3_SDL3Clipboard__ctor_SixLabors_ImageSharp_Formats_IImageFormat_"></a> SDL3Clipboard\(IImageFormat\)

```csharp
public SDL3Clipboard(IImageFormat imageFormat)
```

#### Parameters

`imageFormat` IImageFormat

## Methods

### <a id="osu_Framework_Platform_SDL3_SDL3Clipboard_GetImage__1"></a> GetImage<TPixel\>\(\)

Retrieve an image from the clipboard.

```csharp
public override Image<TPixel>? GetImage<TPixel>() where TPixel : unmanaged, IPixel<TPixel>
```

#### Returns

 Image<TPixel\>?

#### Type Parameters

`TPixel` 

### <a id="osu_Framework_Platform_SDL3_SDL3Clipboard_GetText"></a> GetText\(\)

Retrieve text from the clipboard.

```csharp
public override string? GetText()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_Platform_SDL3_SDL3Clipboard_SetImage_SixLabors_ImageSharp_Image_"></a> SetImage\(Image\)

Copy the image to the clipboard.

```csharp
public override bool SetImage(Image image)
```

#### Parameters

`image` Image

The image to copy to the clipboard

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the image was successfully copied or not

### <a id="osu_Framework_Platform_SDL3_SDL3Clipboard_SetText_System_String_"></a> SetText\(string\)

Copy text to the clipboard.

```csharp
public override void SetText(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

Text to copy to the clipboard

