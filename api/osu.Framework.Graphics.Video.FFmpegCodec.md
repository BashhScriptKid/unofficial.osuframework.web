# <a id="osu_Framework_Graphics_Video_FFmpegCodec"></a> Class FFmpegCodec

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class FFmpegCodec
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FFmpegCodec](osu.Framework.Graphics.Video.FFmpegCodec.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FFmpegCodec\>\(FFmpegCodec?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FFmpegCodec\>\(FFmpegCodec\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FFmpegCodec\>\(FFmpegCodec\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FFmpegCodec\>\(FFmpegCodec\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FFmpegCodec, TChild\>\(FFmpegCodec, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FFmpegCodec, TChild\>\(FFmpegCodec, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FFmpegCodec, TChild\>\(FFmpegCodec, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FFmpegCodec\>\(FFmpegCodec\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Video_FFmpegCodec__ctor_osu_Framework_Graphics_Video_FFmpegFuncs_FFmpeg_AutoGen_AVCodec__"></a> FFmpegCodec\(FFmpegFuncs, AVCodec\*\)

```csharp
public FFmpegCodec(FFmpegFuncs ffmpeg, AVCodec* codec)
```

#### Parameters

`ffmpeg` [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md)

`codec` AVCodec\*

## Fields

### <a id="osu_Framework_Graphics_Video_FFmpegCodec_Pointer"></a> Pointer

```csharp
public readonly AVCodec* Pointer
```

#### Field Value

 AVCodec\*

### <a id="osu_Framework_Graphics_Video_FFmpegCodec_SupportedHwDeviceTypes"></a> SupportedHwDeviceTypes

```csharp
public readonly Lazy<IReadOnlyList<AVHWDeviceType>> SupportedHwDeviceTypes
```

#### Field Value

 [Lazy](https://learn.microsoft.com/dotnet/api/system.lazy\-1)<[IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<AVHWDeviceType\>\>

## Properties

### <a id="osu_Framework_Graphics_Video_FFmpegCodec_Id"></a> Id

```csharp
public AVCodecID Id { get; }
```

#### Property Value

 AVCodecID

### <a id="osu_Framework_Graphics_Video_FFmpegCodec_IsDecoder"></a> IsDecoder

```csharp
public bool IsDecoder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Video_FFmpegCodec_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

