# <a id="osu_Framework_Graphics_Video_VideoDecoder_DecoderState"></a> Enum VideoDecoder.DecoderState

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

Represents the possible states the decoder can be in.

```csharp
public enum VideoDecoder.DecoderState
```

#### Extension Methods

[ObjectExtensions.AsNonNull<VideoDecoder.DecoderState\>\(VideoDecoder.DecoderState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<VideoDecoder.DecoderState\>\(VideoDecoder.DecoderState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<VideoDecoder.DecoderState\>\(VideoDecoder.DecoderState, VideoDecoder.DecoderState\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<VideoDecoder.DecoderState\>\(VideoDecoder.DecoderState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<VideoDecoder.DecoderState\>\(VideoDecoder.DecoderState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<VideoDecoder.DecoderState, TChild\>\(VideoDecoder.DecoderState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<VideoDecoder.DecoderState, TChild\>\(VideoDecoder.DecoderState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<VideoDecoder.DecoderState, TChild\>\(VideoDecoder.DecoderState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<VideoDecoder.DecoderState\>\(VideoDecoder.DecoderState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`EndOfStream = 3` 

The decoder has reached the end of the video data.



`Faulted = 2` 

The decoder has faulted with an exception.



`Ready = 0` 

The decoder is ready to begin decoding. This is the default state before the decoder starts operations.



`Running = 1` 

The decoder is currently running and decoding frames.



`Stopped = 4` 

The decoder has been completely stopped and cannot be resumed.



