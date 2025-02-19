# <a id="osu_Framework_Graphics_Video_FFmpegFuncs"></a> Class FFmpegFuncs

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

```csharp
public class FFmpegFuncs
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FFmpegFuncs\>\(FFmpegFuncs?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FFmpegFuncs\>\(FFmpegFuncs\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FFmpegFuncs\>\(FFmpegFuncs\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FFmpegFuncs\>\(FFmpegFuncs\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FFmpegFuncs, TChild\>\(FFmpegFuncs, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FFmpegFuncs, TChild\>\(FFmpegFuncs, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FFmpegFuncs, TChild\>\(FFmpegFuncs, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FFmpegFuncs\>\(FFmpegFuncs\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AVERROR_EOF"></a> AVERROR\_EOF

```csharp
public const int AVERROR_EOF = -541478725
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AVFMT_FLAG_GENPTS"></a> AVFMT\_FLAG\_GENPTS

```csharp
public const int AVFMT_FLAG_GENPTS = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AVSEEK_FLAG_BACKWARD"></a> AVSEEK\_FLAG\_BACKWARD

```csharp
public const int AVSEEK_FLAG_BACKWARD = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AVSEEK_SIZE"></a> AVSEEK\_SIZE

```csharp
public const int AVSEEK_SIZE = 65536
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AV_NOPTS_VALUE"></a> AV\_NOPTS\_VALUE

```csharp
public const long AV_NOPTS_VALUE = -9223372036854775808
```

#### Field Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AV_TIME_BASE"></a> AV\_TIME\_BASE

```csharp
public const int AV_TIME_BASE = 1000000
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_EAGAIN"></a> EAGAIN

```csharp
public static readonly int EAGAIN
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_ENOMEM"></a> ENOMEM

```csharp
public const int ENOMEM = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_codec_is_decoder"></a> av\_codec\_is\_decoder

```csharp
public FFmpegFuncs.AvCodecIsDecoderDelegate av_codec_is_decoder
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvCodecIsDecoderDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvCodecIsDecoderDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_codec_iterate"></a> av\_codec\_iterate

```csharp
public FFmpegFuncs.AvCodecIterateDelegate av_codec_iterate
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvCodecIterateDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvCodecIterateDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_dict_free"></a> av\_dict\_free

```csharp
[CanBeNull]
public FFmpegFuncs.AvDictFreeDelegate av_dict_free
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvDictFreeDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvDictFreeDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_dict_set"></a> av\_dict\_set

```csharp
[CanBeNull]
public FFmpegFuncs.AvDictSetDelegate av_dict_set
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvDictSetDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvDictSetDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_find_best_stream"></a> av\_find\_best\_stream

```csharp
public FFmpegFuncs.AvFindBestStreamDelegate av_find_best_stream
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFindBestStreamDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFindBestStreamDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_frame_alloc"></a> av\_frame\_alloc

```csharp
public FFmpegFuncs.AvFrameAllocDelegate av_frame_alloc
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFrameAllocDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFrameAllocDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_frame_free"></a> av\_frame\_free

```csharp
public FFmpegFuncs.AvFrameFreeDelegate av_frame_free
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFrameFreeDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFrameFreeDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_frame_get_buffer"></a> av\_frame\_get\_buffer

```csharp
public FFmpegFuncs.AvFrameGetBufferDelegate av_frame_get_buffer
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFrameGetBufferDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFrameGetBufferDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_frame_move_ref"></a> av\_frame\_move\_ref

```csharp
public FFmpegFuncs.AvFrameMoveRefDelegate av_frame_move_ref
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFrameMoveRefDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFrameMoveRefDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_frame_unref"></a> av\_frame\_unref

```csharp
public FFmpegFuncs.AvFrameUnrefDelegate av_frame_unref
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFrameUnrefDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFrameUnrefDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_freep"></a> av\_freep

```csharp
public FFmpegFuncs.AvFreepDelegate av_freep
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvFreepDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvFreepDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_hwdevice_ctx_create"></a> av\_hwdevice\_ctx\_create

```csharp
public FFmpegFuncs.AvHwdeviceCtxCreateDelegate av_hwdevice_ctx_create
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvHwdeviceCtxCreateDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvHwdeviceCtxCreateDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_hwframe_transfer_data"></a> av\_hwframe\_transfer\_data

```csharp
public FFmpegFuncs.AvHwframeTransferDataDelegate av_hwframe_transfer_data
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvHwframeTransferDataDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvHwframeTransferDataDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_malloc"></a> av\_malloc

```csharp
public FFmpegFuncs.AvMallocDelegate av_malloc
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvMallocDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvMallocDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_packet_alloc"></a> av\_packet\_alloc

```csharp
public FFmpegFuncs.AvPacketAllocDelegate av_packet_alloc
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvPacketAllocDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvPacketAllocDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_packet_free"></a> av\_packet\_free

```csharp
public FFmpegFuncs.AvPacketFreeDelegate av_packet_free
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvPacketFreeDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvPacketFreeDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_packet_unref"></a> av\_packet\_unref

```csharp
public FFmpegFuncs.AvPacketUnrefDelegate av_packet_unref
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvPacketUnrefDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvPacketUnrefDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_read_frame"></a> av\_read\_frame

```csharp
public FFmpegFuncs.AvReadFrameDelegate av_read_frame
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvReadFrameDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvReadFrameDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_seek_frame"></a> av\_seek\_frame

```csharp
public FFmpegFuncs.AvSeekFrameDelegate av_seek_frame
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvSeekFrameDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvSeekFrameDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_strdup"></a> av\_strdup

```csharp
public FFmpegFuncs.AvStrDupDelegate av_strdup
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvStrDupDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvStrDupDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_av_strerror"></a> av\_strerror

```csharp
public FFmpegFuncs.AvStrErrorDelegate av_strerror
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvStrErrorDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvStrErrorDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_alloc_context3"></a> avcodec\_alloc\_context3

```csharp
public FFmpegFuncs.AvcodecAllocContext3Delegate avcodec_alloc_context3
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecAllocContext3Delegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecAllocContext3Delegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_flush_buffers"></a> avcodec\_flush\_buffers

```csharp
public FFmpegFuncs.AvcodecFlushBuffersDelegate avcodec_flush_buffers
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecFlushBuffersDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecFlushBuffersDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_free_context"></a> avcodec\_free\_context

```csharp
public FFmpegFuncs.AvcodecFreeContextDelegate avcodec_free_context
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecFreeContextDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecFreeContextDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_get_hw_config"></a> avcodec\_get\_hw\_config

```csharp
public FFmpegFuncs.AvcodecGetHwConfigDelegate avcodec_get_hw_config
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecGetHwConfigDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecGetHwConfigDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_open2"></a> avcodec\_open2

```csharp
public FFmpegFuncs.AvcodecOpen2Delegate avcodec_open2
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecOpen2Delegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecOpen2Delegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_parameters_to_context"></a> avcodec\_parameters\_to\_context

```csharp
public FFmpegFuncs.AvcodecParametersToContextDelegate avcodec_parameters_to_context
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecParametersToContextDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecParametersToContextDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_receive_frame"></a> avcodec\_receive\_frame

```csharp
public FFmpegFuncs.AvcodecReceiveFrameDelegate avcodec_receive_frame
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecReceiveFrameDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecReceiveFrameDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avcodec_send_packet"></a> avcodec\_send\_packet

```csharp
public FFmpegFuncs.AvcodecSendPacketDelegate avcodec_send_packet
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvcodecSendPacketDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvcodecSendPacketDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avformat_alloc_context"></a> avformat\_alloc\_context

```csharp
public FFmpegFuncs.AvformatAllocContextDelegate avformat_alloc_context
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvformatAllocContextDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvformatAllocContextDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avformat_close_input"></a> avformat\_close\_input

```csharp
public FFmpegFuncs.AvformatCloseInputDelegate avformat_close_input
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvformatCloseInputDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvformatCloseInputDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avformat_find_stream_info"></a> avformat\_find\_stream\_info

```csharp
public FFmpegFuncs.AvformatFindStreamInfoDelegate avformat_find_stream_info
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvformatFindStreamInfoDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvformatFindStreamInfoDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avformat_open_input"></a> avformat\_open\_input

```csharp
public FFmpegFuncs.AvformatOpenInputDelegate avformat_open_input
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvformatOpenInputDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvformatOpenInputDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avio_alloc_context"></a> avio\_alloc\_context

```csharp
public FFmpegFuncs.AvioAllocContextDelegate avio_alloc_context
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvioAllocContextDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvioAllocContextDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_avio_context_free"></a> avio\_context\_free

```csharp
public FFmpegFuncs.AvioContextFreeDelegate avio_context_free
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[AvioContextFreeDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.AvioContextFreeDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_sws_freeContext"></a> sws\_freeContext

```csharp
public FFmpegFuncs.SwsFreeContextDelegate sws_freeContext
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[SwsFreeContextDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.SwsFreeContextDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_sws_getCachedContext"></a> sws\_getCachedContext

```csharp
public FFmpegFuncs.SwsGetCachedContextDelegate sws_getCachedContext
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[SwsGetCachedContextDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.SwsGetCachedContextDelegate.md)

### <a id="osu_Framework_Graphics_Video_FFmpegFuncs_sws_scale"></a> sws\_scale

```csharp
public FFmpegFuncs.SwsScaleDelegate sws_scale
```

#### Field Value

 [FFmpegFuncs](osu.Framework.Graphics.Video.FFmpegFuncs.md).[SwsScaleDelegate](osu.Framework.Graphics.Video.FFmpegFuncs.SwsScaleDelegate.md)

