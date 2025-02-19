# <a id="osu_Framework_Graphics_Video_FFmpegFuncs_AvioAllocContextDelegate"></a> Delegate FFmpegFuncs.AvioAllocContextDelegate

Namespace: [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)  
Assembly: osu.Framework.dll  

```csharp
public delegate AVIOContext* FFmpegFuncs.AvioAllocContextDelegate(byte* buffer, int buffer_size, int write_flag, void* opaque, avio_alloc_context_read_packet_func read_packet, avio_alloc_context_write_packet_func write_packet, avio_alloc_context_seek_func seek)
```

#### Parameters

`buffer` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\*

`buffer_size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`write_flag` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`opaque` [void](https://learn.microsoft.com/dotnet/api/system.void)\*

`read_packet` avio\_alloc\_context\_read\_packet\_func

`write_packet` avio\_alloc\_context\_write\_packet\_func

`seek` avio\_alloc\_context\_seek\_func

#### Returns

 AVIOContext\*

#### Extension Methods

[ObjectExtensions.AsNonNull<FFmpegFuncs.AvioAllocContextDelegate\>\(FFmpegFuncs.AvioAllocContextDelegate?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FFmpegFuncs.AvioAllocContextDelegate\>\(FFmpegFuncs.AvioAllocContextDelegate\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FFmpegFuncs.AvioAllocContextDelegate\>\(FFmpegFuncs.AvioAllocContextDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FFmpegFuncs.AvioAllocContextDelegate\>\(FFmpegFuncs.AvioAllocContextDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FFmpegFuncs.AvioAllocContextDelegate, TChild\>\(FFmpegFuncs.AvioAllocContextDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FFmpegFuncs.AvioAllocContextDelegate, TChild\>\(FFmpegFuncs.AvioAllocContextDelegate, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FFmpegFuncs.AvioAllocContextDelegate, TChild\>\(FFmpegFuncs.AvioAllocContextDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FFmpegFuncs.AvioAllocContextDelegate\>\(FFmpegFuncs.AvioAllocContextDelegate\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

