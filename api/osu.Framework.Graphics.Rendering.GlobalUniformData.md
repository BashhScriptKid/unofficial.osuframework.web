# <a id="osu_Framework_Graphics_Rendering_GlobalUniformData"></a> Struct GlobalUniformData

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public record struct GlobalUniformData : IEquatable<GlobalUniformData>
```

#### Implements

[IEquatable<GlobalUniformData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GlobalUniformData\>\(GlobalUniformData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GlobalUniformData\>\(GlobalUniformData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GlobalUniformData\>\(GlobalUniformData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GlobalUniformData\>\(GlobalUniformData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GlobalUniformData, TChild\>\(GlobalUniformData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GlobalUniformData, TChild\>\(GlobalUniformData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GlobalUniformData, TChild\>\(GlobalUniformData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GlobalUniformData\>\(GlobalUniformData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_AlphaExponent"></a> AlphaExponent

```csharp
public UniformFloat AlphaExponent
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_BackbufferDraw"></a> BackbufferDraw

```csharp
public UniformBool BackbufferDraw
```

#### Field Value

 [UniformBool](osu.Framework.Graphics.Shaders.Types.UniformBool.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_BorderColour"></a> BorderColour

```csharp
public UniformMatrix4 BorderColour
```

#### Field Value

 [UniformMatrix4](osu.Framework.Graphics.Shaders.Types.UniformMatrix4.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_BorderThickness"></a> BorderThickness

```csharp
public UniformFloat BorderThickness
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_CornerExponent"></a> CornerExponent

```csharp
public UniformFloat CornerExponent
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_CornerRadius"></a> CornerRadius

```csharp
public UniformFloat CornerRadius
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_DiscardInner"></a> DiscardInner

```csharp
public UniformBool DiscardInner
```

#### Field Value

 [UniformBool](osu.Framework.Graphics.Shaders.Types.UniformBool.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_EdgeOffset"></a> EdgeOffset

```csharp
public UniformVector2 EdgeOffset
```

#### Field Value

 [UniformVector2](osu.Framework.Graphics.Shaders.Types.UniformVector2.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_InnerCornerRadius"></a> InnerCornerRadius

```csharp
public UniformFloat InnerCornerRadius
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_IsClipSpaceYInverted"></a> IsClipSpaceYInverted

```csharp
public UniformBool IsClipSpaceYInverted
```

#### Field Value

 [UniformBool](osu.Framework.Graphics.Shaders.Types.UniformBool.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_IsDepthRangeZeroToOne"></a> IsDepthRangeZeroToOne

```csharp
public UniformBool IsDepthRangeZeroToOne
```

#### Field Value

 [UniformBool](osu.Framework.Graphics.Shaders.Types.UniformBool.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_IsMasking"></a> IsMasking

```csharp
public UniformBool IsMasking
```

#### Field Value

 [UniformBool](osu.Framework.Graphics.Shaders.Types.UniformBool.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_IsUvOriginTopLeft"></a> IsUvOriginTopLeft

```csharp
public UniformBool IsUvOriginTopLeft
```

#### Field Value

 [UniformBool](osu.Framework.Graphics.Shaders.Types.UniformBool.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_MaskingBlendRange"></a> MaskingBlendRange

```csharp
public UniformFloat MaskingBlendRange
```

#### Field Value

 [UniformFloat](osu.Framework.Graphics.Shaders.Types.UniformFloat.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_MaskingRect"></a> MaskingRect

```csharp
public UniformVector4 MaskingRect
```

#### Field Value

 [UniformVector4](osu.Framework.Graphics.Shaders.Types.UniformVector4.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_ProjMatrix"></a> ProjMatrix

```csharp
public UniformMatrix4 ProjMatrix
```

#### Field Value

 [UniformMatrix4](osu.Framework.Graphics.Shaders.Types.UniformMatrix4.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_ToMaskingSpace"></a> ToMaskingSpace

```csharp
public UniformMatrix3 ToMaskingSpace
```

#### Field Value

 [UniformMatrix3](osu.Framework.Graphics.Shaders.Types.UniformMatrix3.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_WrapModeS"></a> WrapModeS

```csharp
public UniformInt WrapModeS
```

#### Field Value

 [UniformInt](osu.Framework.Graphics.Shaders.Types.UniformInt.md)

### <a id="osu_Framework_Graphics_Rendering_GlobalUniformData_WrapModeT"></a> WrapModeT

```csharp
public UniformInt WrapModeT
```

#### Field Value

 [UniformInt](osu.Framework.Graphics.Shaders.Types.UniformInt.md)

