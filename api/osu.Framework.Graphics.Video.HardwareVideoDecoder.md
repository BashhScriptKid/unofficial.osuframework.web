# <a id="osu_Framework_Graphics_Video_HardwareVideoDecoder"></a> Enum HardwareVideoDecoder

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

Represents a list of usable hardware video decoders.

```csharp
[Flags]
public enum HardwareVideoDecoder
```

#### Extension Methods

[ObjectExtensions.AsNonNull<HardwareVideoDecoder\>\(HardwareVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HardwareVideoDecoder\>\(HardwareVideoDecoder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<HardwareVideoDecoder\>\(HardwareVideoDecoder, HardwareVideoDecoder\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HardwareVideoDecoder\>\(HardwareVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HardwareVideoDecoder\>\(HardwareVideoDecoder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<HardwareVideoDecoder, TChild\>\(HardwareVideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HardwareVideoDecoder, TChild\>\(HardwareVideoDecoder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HardwareVideoDecoder, TChild\>\(HardwareVideoDecoder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HardwareVideoDecoder\>\(HardwareVideoDecoder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Any = 2147483647` 

`D3D11VA = 256` 



Windows only.

`DXVA2 = 8` 



Windows only.

`MediaCodec = 64` 



Android only.

`NVDEC = 1` 



Windows and Linux only.

`None = 0` 

Disables hardware decoding.



`QuickSyncVideo = 4` 

Windows and Linux only.



`VAAPI = 32` 



Linux only.

`VDPAU = 16` 



Linux only.

`VideoToolbox = 128` 



Apple devices only.

## Remarks

Contains decoders for ALL platforms.

