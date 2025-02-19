# <a id="osu_Framework_Graphics_Video_VideoDecoder"></a> Class VideoDecoder

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

Represents a video decoder that can be used convert video streams and files into textures.

```csharp
public class VideoDecoder : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[VideoDecoder](osu.Framework.Graphics.Video.VideoDecoder.md)

#### Implements

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

[ObjectExtensions.AsNonNull<VideoDecoder\>\(VideoDecoder?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<VideoDecoder\>\(VideoDecoder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<VideoDecoder\>\(VideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<VideoDecoder\>\(VideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<VideoDecoder, TChild\>\(VideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<VideoDecoder, TChild\>\(VideoDecoder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<VideoDecoder, TChild\>\(VideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<VideoDecoder\>\(VideoDecoder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Video_VideoDecoder__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_String_"></a> VideoDecoder\(IRenderer, string\)

Creates a new video decoder that decodes the given video file.

```csharp
public VideoDecoder(IRenderer renderer, string filename)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to display the video.

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to the file that should be decoded.

### <a id="osu_Framework_Graphics_Video_VideoDecoder__ctor_osu_Framework_Graphics_Rendering_IRenderer_System_IO_Stream_"></a> VideoDecoder\(IRenderer, Stream\)

Creates a new video decoder that decodes the given video stream.

```csharp
public VideoDecoder(IRenderer renderer, Stream videoStream)
```

#### Parameters

`renderer` [IRenderer](osu.Framework.Graphics.Rendering.IRenderer.md)

The renderer to display the video.

`videoStream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream that should be decoded.

## Fields

### <a id="osu_Framework_Graphics_Video_VideoDecoder_TargetHardwareVideoDecoders"></a> TargetHardwareVideoDecoders

Determines which hardware acceleration device(s) should be used.

```csharp
public readonly Bindable<HardwareVideoDecoder> TargetHardwareVideoDecoders
```

#### Field Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[HardwareVideoDecoder](osu.Framework.Graphics.Video.HardwareVideoDecoder.md)\>

## Properties

### <a id="osu_Framework_Graphics_Video_VideoDecoder_CanSeek"></a> CanSeek

True if the decoder can seek, false otherwise. Determined by the stream this decoder was created with.

```csharp
public bool CanSeek { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_Duration"></a> Duration

The duration of the video that is being decoded. Can only be queried after the decoder has started decoding has loaded. This value may be an estimate by FFmpeg, depending on the video loaded.

```csharp
public double Duration { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_FrameRate"></a> FrameRate

The frame rate of the video stream this decoder is decoding.

```csharp
public double FrameRate { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_IsFaulted"></a> IsFaulted

True if the decoder has faulted after starting to decode. You can try to restart a failed decoder by invoking <xref href="osu.Framework.Graphics.Video.VideoDecoder.StartDecoding" data-throw-if-not-resolved="false"></xref> again.

```csharp
public bool IsFaulted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_IsRunning"></a> IsRunning

True if the decoder currently does not decode any more frames, false otherwise.

```csharp
public bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_LastDecodedFrameTime"></a> LastDecodedFrameTime

The timestamp of the last frame that was decoded by this video decoder, or 0 if no frames have been decoded.

```csharp
public float LastDecodedFrameTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_State"></a> State

The current state of the decoding process.

```csharp
public VideoDecoder.DecoderState State { get; }
```

#### Property Value

 [VideoDecoder](osu.Framework.Graphics.Video.VideoDecoder.md).[DecoderState](osu.Framework.Graphics.Video.VideoDecoder.DecoderState.md)

## Methods

### <a id="osu_Framework_Graphics_Video_VideoDecoder_CreateFuncs"></a> CreateFuncs\(\)

```csharp
protected virtual FFmpegFuncs CreateFuncs()
```

#### Returns

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Video_VideoDecoder_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Video_VideoDecoder_Finalize"></a> \~VideoDecoder\(\)

```csharp
protected ~VideoDecoder()
```

### <a id="osu_Framework_Graphics_Video_VideoDecoder_GetAvailableDecoders_FFmpeg_AutoGen_AVInputFormat__FFmpeg_AutoGen_AVCodecID_osu_Framework_Graphics_Video_HardwareVideoDecoder_"></a> GetAvailableDecoders\(AVInputFormat\*, AVCodecID, HardwareVideoDecoder\)

```csharp
protected virtual IEnumerable<(FFmpegCodec codec, AVHWDeviceType hwDeviceType)> GetAvailableDecoders(AVInputFormat* inputFormat, AVCodecID codecId, HardwareVideoDecoder targetHwDecoders)
```

#### Parameters

`inputFormat` AVInputFormat\*

`codecId` AVCodecID

`targetHwDecoders` [HardwareVideoDecoder](osu.Framework.Graphics.Video.HardwareVideoDecoder.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<\([FFmpegCodec](osu.Framework.Graphics.Video.FFmpegCodec.md) [codec](https://learn.microsoft.com/dotnet/api/system.valuetuple\-osu.framework.graphics.video.ffmpegcodec,ffmpeg.autogen.avhwdevicetype\-.codec), AVHWDeviceType [hwDeviceType](https://learn.microsoft.com/dotnet/api/system.valuetuple\-osu.framework.graphics.video.ffmpegcodec,ffmpeg.autogen.avhwdevicetype\-.hwdevicetype)\)\>

#### Remarks

Returned HW devices are not guaranteed to be available on the current machine, they only represent what the loaded FFmpeg libraries support.

### <a id="osu_Framework_Graphics_Video_VideoDecoder_GetConversionMatrix"></a> GetConversionMatrix\(\)

```csharp
public Matrix3 GetConversionMatrix()
```

#### Returns

 Matrix3

### <a id="osu_Framework_Graphics_Video_VideoDecoder_GetDecodedFrames"></a> GetDecodedFrames\(\)

Gets all frames that have been decoded by the decoder up until the point in time when this method was called.
Retrieving decoded frames using this method consumes them, ie calling this method again will never retrieve the same frame twice.

```csharp
public IEnumerable<DecodedFrame> GetDecodedFrames()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[DecodedFrame](osu.Framework.Graphics.Video.DecodedFrame.md)\>

The frames that have been decoded up until the point in time this method was called.

### <a id="osu_Framework_Graphics_Video_VideoDecoder_ReturnFrames_System_Collections_Generic_IEnumerable_osu_Framework_Graphics_Video_DecodedFrame__"></a> ReturnFrames\(IEnumerable<DecodedFrame\>\)

Returns the given frames back to the decoder, allowing the decoder to reuse the textures contained in the frames to draw new frames.

```csharp
public void ReturnFrames(IEnumerable<DecodedFrame> frames)
```

#### Parameters

`frames` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[DecodedFrame](osu.Framework.Graphics.Video.DecodedFrame.md)\>

The frames that should be returned to the decoder.

### <a id="osu_Framework_Graphics_Video_VideoDecoder_Seek_System_Double_"></a> Seek\(double\)

Seek the decoder to the given timestamp. This will fail if <xref href="osu.Framework.Graphics.Video.VideoDecoder.CanSeek" data-throw-if-not-resolved="false"></xref> is false.

```csharp
public void Seek(double targetTimestamp)
```

#### Parameters

`targetTimestamp` [double](https://learn.microsoft.com/dotnet/api/system.double)

The timestamp to seek to.

### <a id="osu_Framework_Graphics_Video_VideoDecoder_StartDecoding"></a> StartDecoding\(\)

Starts the decoding process. The decoding will happen asynchronously in a separate thread. The decoded frames can be retrieved by using <xref href="osu.Framework.Graphics.Video.VideoDecoder.GetDecodedFrames" data-throw-if-not-resolved="false"></xref>.

```csharp
public void StartDecoding()
```

### <a id="osu_Framework_Graphics_Video_VideoDecoder_StopDecodingAsync"></a> StopDecodingAsync\(\)

Stops the decoding process.

```csharp
public Task StopDecodingAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

