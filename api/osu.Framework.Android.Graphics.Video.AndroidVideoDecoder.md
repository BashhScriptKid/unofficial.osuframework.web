# <a id="osu_Framework_Android_Graphics_Video_AndroidVideoDecoder"></a> Class AndroidVideoDecoder

Namespace: [osu.Framework.Android.Graphics.Video](osu.Framework.Android.Graphics.Video.md)  
Assembly: osu.Framework.Android.dll  

```csharp
public class AndroidVideoDecoder : VideoDecoder, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
VideoDecoder ← 
[AndroidVideoDecoder](osu.Framework.Android.Graphics.Video.AndroidVideoDecoder.md)

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

[ObjectExtensions.AsNonNull<AndroidVideoDecoder\>\(AndroidVideoDecoder?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AndroidVideoDecoder\>\(AndroidVideoDecoder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AndroidVideoDecoder\>\(AndroidVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AndroidVideoDecoder\>\(AndroidVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AndroidVideoDecoder, TChild\>\(AndroidVideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AndroidVideoDecoder, TChild\>\(AndroidVideoDecoder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AndroidVideoDecoder, TChild\>\(AndroidVideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AndroidVideoDecoder\>\(AndroidVideoDecoder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Android_Graphics_Video_AndroidVideoDecoder__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_String_"></a> AndroidVideoDecoder\(IRenderer, string\)

```csharp
public AndroidVideoDecoder(IRenderer renderer, string filename)
```

#### Parameters

`renderer` IRenderer

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Android_Graphics_Video_AndroidVideoDecoder__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_IO_Stream_"></a> AndroidVideoDecoder\(IRenderer, Stream\)

```csharp
public AndroidVideoDecoder(IRenderer renderer, Stream videoStream)
```

#### Parameters

`renderer` IRenderer

`videoStream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

## Methods

### <a id="osu_Framework_Android_Graphics_Video_AndroidVideoDecoder_CreateFuncs"></a> CreateFuncs\(\)

```csharp
protected override FFmpegFuncs CreateFuncs()
```

#### Returns

 FFmpegFuncs

### <a id="osu_Framework_Android_Graphics_Video_AndroidVideoDecoder_GetAvailableDecoders_FFmpeg_AutoGen_AVInputFormat__FFmpeg_AutoGen_AVCodecID_osu_Framework_Graphics_Video_HardwareVideoDecoder_"></a> GetAvailableDecoders\(AVInputFormat\*, AVCodecID, HardwareVideoDecoder\)

```csharp
protected override IEnumerable<(FFmpegCodec codec, AVHWDeviceType hwDeviceType)> GetAvailableDecoders(AVInputFormat* inputFormat, AVCodecID codecId, HardwareVideoDecoder targetHwDecoders)
```

#### Parameters

`inputFormat` AVInputFormat\*

`codecId` AVCodecID

`targetHwDecoders` HardwareVideoDecoder

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<\(FFmpegCodec [codec](https://learn.microsoft.com/dotnet/api/system.valuetuple\-osu.framework.graphics.video.ffmpegcodec,ffmpeg.autogen.avhwdevicetype\-.codec), AVHWDeviceType [hwDeviceType](https://learn.microsoft.com/dotnet/api/system.valuetuple\-osu.framework.graphics.video.ffmpegcodec,ffmpeg.autogen.avhwdevicetype\-.hwdevicetype)\)\>

#### Remarks

Returned HW devices are not guaranteed to be available on the current machine, they only represent what the loaded FFmpeg libraries support.

