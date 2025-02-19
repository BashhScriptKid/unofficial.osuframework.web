# <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload"></a> Class MemoryAllocatorTextureUpload

Namespace: [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)  
Assembly: osu.Framework.dll  

```csharp
public class MemoryAllocatorTextureUpload : ITextureUpload, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MemoryAllocatorTextureUpload](osu.Framework.Graphics.Textures.MemoryAllocatorTextureUpload.md)

#### Implements

[ITextureUpload](osu.Framework.Graphics.Textures.ITextureUpload.md), 
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

[ObjectExtensions.AsNonNull<MemoryAllocatorTextureUpload\>\(MemoryAllocatorTextureUpload?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MemoryAllocatorTextureUpload\>\(MemoryAllocatorTextureUpload\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MemoryAllocatorTextureUpload\>\(MemoryAllocatorTextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MemoryAllocatorTextureUpload\>\(MemoryAllocatorTextureUpload\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MemoryAllocatorTextureUpload, TChild\>\(MemoryAllocatorTextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MemoryAllocatorTextureUpload, TChild\>\(MemoryAllocatorTextureUpload, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MemoryAllocatorTextureUpload, TChild\>\(MemoryAllocatorTextureUpload, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MemoryAllocatorTextureUpload\>\(MemoryAllocatorTextureUpload\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload__ctor_System_Int32_System_Int32_SixLabors_ImageSharp_Memory_MemoryAllocator_"></a> MemoryAllocatorTextureUpload\(int, int, MemoryAllocator\)

Create an empty raw texture with an efficient shared memory backing.

```csharp
public MemoryAllocatorTextureUpload(int width, int height, MemoryAllocator memoryAllocator = null)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the texture.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the texture.

`memoryAllocator` MemoryAllocator

The source to retrieve memory from. Shared default is used if null.

## Properties

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_Bounds"></a> Bounds

The target bounds for this upload. If not specified, will assume to be (0, 0, width, height).

```csharp
public RectangleI Bounds { get; set; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_Data"></a> Data

The raw data to be uploaded.

```csharp
public ReadOnlySpan<Rgba32> Data { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Rgba32\>

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_Format"></a> Format

The texture format for this upload.

```csharp
public virtual PixelFormat Format { get; }
```

#### Property Value

 PixelFormat

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_Level"></a> Level

The target mipmap level to upload into.

```csharp
public int Level { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_RawData"></a> RawData

```csharp
public Span<Rgba32> RawData { get; }
```

#### Property Value

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Rgba32\>

## Methods

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Textures_MemoryAllocatorTextureUpload_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

