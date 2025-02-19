# <a id="osu_Framework_iOS_Graphics_Video_IOSVideoDecoder"></a> Class IOSVideoDecoder

Namespace: [osu.Framework.iOS.Graphics.Video](osu.Framework.iOS.Graphics.Video.md)  
Assembly: osu.Framework.iOS.dll  

```csharp
public class IOSVideoDecoder : VideoDecoder, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
VideoDecoder ← 
[IOSVideoDecoder](osu.Framework.iOS.Graphics.Video.IOSVideoDecoder.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

VideoDecoder.Duration, 
VideoDecoder.IsRunning, 
VideoDecoder.IsFaulted, 
VideoDecoder.LastDecodedFrameTime, 
VideoDecoder.FrameRate, 
VideoDecoder.CanSeek, 
VideoDecoder.State, 
VideoDecoder.TargetHardwareVideoDecoders, 
VideoDecoder.Seek\(double\), 
VideoDecoder.ReturnFrames\(IEnumerable<DecodedFrame\>\), 
VideoDecoder.StartDecoding\(\), 
VideoDecoder.StopDecodingAsync\(\), 
VideoDecoder.GetDecodedFrames\(\), 
VideoDecoder.GetConversionMatrix\(\), 
VideoDecoder.GetAvailableDecoders\(AVInputFormat\*, AVCodecID, HardwareVideoDecoder\), 
VideoDecoder.CreateFuncs\(\), 
VideoDecoder.Dispose\(\), 
VideoDecoder.Dispose\(bool\), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IOSVideoDecoder\>\(IOSVideoDecoder?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IOSVideoDecoder\>\(IOSVideoDecoder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IOSVideoDecoder\>\(IOSVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IOSVideoDecoder\>\(IOSVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IOSVideoDecoder, TChild\>\(IOSVideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IOSVideoDecoder, TChild\>\(IOSVideoDecoder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IOSVideoDecoder, TChild\>\(IOSVideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IOSVideoDecoder\>\(IOSVideoDecoder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_iOS_Graphics_Video_IOSVideoDecoder__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_String_"></a> IOSVideoDecoder\(IRenderer, string\)

```csharp
public IOSVideoDecoder(IRenderer renderer, string filename)
```

#### Parameters

`renderer` IRenderer

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_iOS_Graphics_Video_IOSVideoDecoder__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_IO_Stream_"></a> IOSVideoDecoder\(IRenderer, Stream\)

```csharp
public IOSVideoDecoder(IRenderer renderer, Stream videoStream)
```

#### Parameters

`renderer` IRenderer

`videoStream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

## Methods

### <a id="osu_Framework_iOS_Graphics_Video_IOSVideoDecoder_CreateFuncs"></a> CreateFuncs\(\)

```csharp
protected override FFmpegFuncs CreateFuncs()
```

#### Returns

 FFmpegFuncs

