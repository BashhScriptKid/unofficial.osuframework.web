# <a id="osu_Framework_Platform_SDL2_SDL2Clipboard"></a> Class SDL2Clipboard

Namespace: [osu.Framework.Platform.SDL2](osu.Framework.Platform.SDL2.md)  
Assembly: osu.Framework.dll  

```csharp
public class SDL2Clipboard : Clipboard
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Clipboard](osu.Framework.Platform.Clipboard.md) ← 
[SDL2Clipboard](osu.Framework.Platform.SDL2.SDL2Clipboard.md)

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

[ObjectExtensions.AsNonNull<SDL2Clipboard\>\(SDL2Clipboard?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SDL2Clipboard\>\(SDL2Clipboard\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SDL2Clipboard\>\(SDL2Clipboard\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SDL2Clipboard\>\(SDL2Clipboard\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SDL2Clipboard, TChild\>\(SDL2Clipboard, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SDL2Clipboard, TChild\>\(SDL2Clipboard, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SDL2Clipboard, TChild\>\(SDL2Clipboard, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SDL2Clipboard\>\(SDL2Clipboard\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Platform_SDL2_SDL2Clipboard_GetImage__1"></a> GetImage<TPixel\>\(\)

Retrieve an image from the clipboard.

```csharp
public override Image<TPixel>? GetImage<TPixel>() where TPixel : unmanaged, IPixel<TPixel>
```

#### Returns

 Image<TPixel\>?

#### Type Parameters

`TPixel` 

### <a id="osu_Framework_Platform_SDL2_SDL2Clipboard_GetText"></a> GetText\(\)

Retrieve text from the clipboard.

```csharp
public override string? GetText()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_Platform_SDL2_SDL2Clipboard_SetImage_SixLabors_ImageSharp_Image_"></a> SetImage\(Image\)

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

### <a id="osu_Framework_Platform_SDL2_SDL2Clipboard_SetText_System_String_"></a> SetText\(string\)

Copy text to the clipboard.

```csharp
public override void SetText(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

Text to copy to the clipboard

