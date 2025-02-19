# <a id="osu_Framework_Graphics_Rendering_MaskingInfo"></a> Struct MaskingInfo

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

```csharp
public struct MaskingInfo : IEquatable<MaskingInfo>
```

#### Implements

[IEquatable<MaskingInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MaskingInfo\>\(MaskingInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MaskingInfo\>\(MaskingInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MaskingInfo\>\(MaskingInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MaskingInfo\>\(MaskingInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MaskingInfo, TChild\>\(MaskingInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MaskingInfo, TChild\>\(MaskingInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MaskingInfo, TChild\>\(MaskingInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MaskingInfo\>\(MaskingInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_AlphaExponent"></a> AlphaExponent

```csharp
public float AlphaExponent
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_BlendRange"></a> BlendRange

```csharp
public float BlendRange
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_BorderColour"></a> BorderColour

```csharp
public ColourInfo BorderColour
```

#### Field Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_BorderThickness"></a> BorderThickness

```csharp
public float BorderThickness
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_ConservativeScreenSpaceQuad"></a> ConservativeScreenSpaceQuad

```csharp
public Quad ConservativeScreenSpaceQuad
```

#### Field Value

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_CornerExponent"></a> CornerExponent

```csharp
public float CornerExponent
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_CornerRadius"></a> CornerRadius

```csharp
public float CornerRadius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_EdgeOffset"></a> EdgeOffset

```csharp
public Vector2 EdgeOffset
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_Hollow"></a> Hollow

```csharp
public bool Hollow
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_HollowCornerRadius"></a> HollowCornerRadius

```csharp
public float HollowCornerRadius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_MaskingRect"></a> MaskingRect

```csharp
public RectangleF MaskingRect
```

#### Field Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_ScreenSpaceAABB"></a> ScreenSpaceAABB

```csharp
public RectangleI ScreenSpaceAABB
```

#### Field Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_ToMaskingSpace"></a> ToMaskingSpace

This matrix transforms screen space coordinates to masking space (likely the parent
space of the container doing the masking).
It is used by a shader to determine which pixels to discard.

```csharp
public Matrix3 ToMaskingSpace
```

#### Field Value

 Matrix3

## Methods

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_Equals_osu_Framework_Graphics_Rendering_MaskingInfo_"></a> Equals\(MaskingInfo\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(MaskingInfo other)
```

#### Parameters

`other` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_Equals_System_Object_"></a> Equals\(object?\)

Indicates whether this instance and a specified object are equal.

```csharp
public override readonly bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override readonly int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

## Operators

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_op_Equality_osu_Framework_Graphics_Rendering_MaskingInfo__osu_Framework_Graphics_Rendering_MaskingInfo__"></a> operator ==\(in MaskingInfo, in MaskingInfo\)

```csharp
public static bool operator ==(in MaskingInfo left, in MaskingInfo right)
```

#### Parameters

`left` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

`right` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Rendering_MaskingInfo_op_Inequality_osu_Framework_Graphics_Rendering_MaskingInfo__osu_Framework_Graphics_Rendering_MaskingInfo__"></a> operator \!=\(in MaskingInfo, in MaskingInfo\)

```csharp
public static bool operator !=(in MaskingInfo left, in MaskingInfo right)
```

#### Parameters

`left` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

`right` [MaskingInfo](osu.Framework.Graphics.Rendering.MaskingInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

