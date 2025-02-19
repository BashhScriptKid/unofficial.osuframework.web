# <a id="osu_Framework_Extensions_ImageExtensions_ImageExtensions"></a> Class ImageExtensions

Namespace: [osu.Framework.Extensions.ImageExtensions](osu.Framework.Extensions.ImageExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class ImageExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ImageExtensions](osu.Framework.Extensions.ImageExtensions.ImageExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Extensions_ImageExtensions_ImageExtensions_CreateReadOnlyPixelMemory__1_SixLabors_ImageSharp_Image___0__"></a> CreateReadOnlyPixelMemory<TPixel\>\(Image<TPixel\>\)

Creates a contiguous and read-only memory from the pixels of an <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref>.
Useful for retrieving unmanaged pointers to the entire pixel data of the <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref> for marshalling.

```csharp
public static ReadOnlyPixelMemory<TPixel> CreateReadOnlyPixelMemory<TPixel>(this Image<TPixel> image) where TPixel : unmanaged, IPixel<TPixel>
```

#### Parameters

`image` Image<TPixel\>

The <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [ReadOnlyPixelMemory](osu.Framework.Extensions.ImageExtensions.ReadOnlyPixelMemory\-1.md)<TPixel\>

The <xref href="osu.Framework.Extensions.ImageExtensions.ReadOnlyPixelMemory%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`TPixel` 

The type of pixels in <code class="paramref">image</code>.

#### Remarks

The returned <xref href="osu.Framework.Extensions.ImageExtensions.ReadOnlyPixelMemory%601" data-throw-if-not-resolved="false"></xref> must be disposed when usage is finished.

### <a id="osu_Framework_Extensions_ImageExtensions_ImageExtensions_CreateReadOnlyPixelSpan__1_SixLabors_ImageSharp_Image___0__"></a> CreateReadOnlyPixelSpan<TPixel\>\(Image<TPixel\>\)

Creates a contiguous and read-only span from the pixels of an <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref>.
Useful for retrieving unmanaged pointers to the entire pixel data of the <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref> for marshalling.

```csharp
public static ReadOnlyPixelSpan<TPixel> CreateReadOnlyPixelSpan<TPixel>(this Image<TPixel> image) where TPixel : unmanaged, IPixel<TPixel>
```

#### Parameters

`image` Image<TPixel\>

The <xref href="SixLabors.ImageSharp.Image%601" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [ReadOnlyPixelSpan](osu.Framework.Extensions.ImageExtensions.ReadOnlyPixelSpan\-1.md)<TPixel\>

The <xref href="osu.Framework.Extensions.ImageExtensions.ReadOnlyPixelSpan%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`TPixel` 

The type of pixels in <code class="paramref">image</code>.

#### Remarks

The returned <xref href="osu.Framework.Extensions.ImageExtensions.ReadOnlyPixelSpan%601" data-throw-if-not-resolved="false"></xref> must be disposed when usage is finished.

