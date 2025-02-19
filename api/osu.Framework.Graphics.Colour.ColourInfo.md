# <a id="osu_Framework_Graphics_Colour_ColourInfo"></a> Struct ColourInfo

Namespace: [osu.Framework.Graphics.Colour](osu.Framework.Graphics.Colour.md)  
Assembly: osu.Framework.dll  

ColourInfo contains information about the colours of all 4 vertices of a quad.
These colours are always stored in linear space.

```csharp
public struct ColourInfo : IEquatable<ColourInfo>, IEquatable<SRGBColour>
```

#### Implements

[IEquatable<ColourInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<SRGBColour\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ColourInfo\>\(ColourInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ColourInfo\>\(ColourInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ColourInfo\>\(ColourInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ColourInfo\>\(ColourInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ColourInfo, TChild\>\(ColourInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ColourInfo, TChild\>\(ColourInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ColourInfo, TChild\>\(ColourInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ColourInfo\>\(ColourInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Colour_ColourInfo_BottomLeft"></a> BottomLeft

```csharp
public SRGBColour BottomLeft
```

#### Field Value

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_BottomRight"></a> BottomRight

```csharp
public SRGBColour BottomRight
```

#### Field Value

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_HasSingleColour"></a> HasSingleColour

```csharp
public bool HasSingleColour
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_TopLeft"></a> TopLeft

```csharp
public SRGBColour TopLeft
```

#### Field Value

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_TopRight"></a> TopRight

```csharp
public SRGBColour TopRight
```

#### Field Value

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

## Properties

### <a id="osu_Framework_Graphics_Colour_ColourInfo_AverageColour"></a> AverageColour

The average colour of all corners.

```csharp
public readonly SRGBColour AverageColour { get; }
```

#### Property Value

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_MaxAlpha"></a> MaxAlpha

The maximum alpha value of all four corners.

```csharp
public readonly float MaxAlpha { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_MinAlpha"></a> MinAlpha

The minimum alpha value of all four corners.

```csharp
public readonly float MinAlpha { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Colour_ColourInfo_ApplyChild_osu_Framework_Graphics_Colour_ColourInfo_"></a> ApplyChild\(ColourInfo\)

```csharp
public void ApplyChild(ColourInfo childColour)
```

#### Parameters

`childColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_ApplyChild_osu_Framework_Graphics_Colour_ColourInfo_osu_Framework_Graphics_Primitives_Quad_"></a> ApplyChild\(ColourInfo, Quad\)

```csharp
public void ApplyChild(ColourInfo childColour, Quad interp)
```

#### Parameters

`childColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`interp` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_Equals_osu_Framework_Graphics_Colour_ColourInfo_"></a> Equals\(ColourInfo\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(ColourInfo other)
```

#### Parameters

`other` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_Equals_osu_Framework_Graphics_Colour_SRGBColour_"></a> Equals\(SRGBColour\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(SRGBColour other)
```

#### Parameters

`other` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_GradientHorizontal_osu_Framework_Graphics_Colour_SRGBColour_osu_Framework_Graphics_Colour_SRGBColour_"></a> GradientHorizontal\(SRGBColour, SRGBColour\)

Creates a ColourInfo with a horizontal gradient.

```csharp
public static ColourInfo GradientHorizontal(SRGBColour c1, SRGBColour c2)
```

#### Parameters

`c1` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

The left colour of the gradient.

`c2` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

The right colour of the gradient.

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The created ColourInfo.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_GradientVertical_osu_Framework_Graphics_Colour_SRGBColour_osu_Framework_Graphics_Colour_SRGBColour_"></a> GradientVertical\(SRGBColour, SRGBColour\)

Creates a ColourInfo with a vertical gradient.

```csharp
public static ColourInfo GradientVertical(SRGBColour c1, SRGBColour c2)
```

#### Parameters

`c1` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

The top colour of the gradient.

`c2` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

The bottom colour of the gradient.

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The created ColourInfo.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_Interpolate_osuTK_Vector2_"></a> Interpolate\(Vector2\)

```csharp
public readonly SRGBColour Interpolate(Vector2 interp)
```

#### Parameters

`interp` Vector2

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_Interpolate_osu_Framework_Graphics_Primitives_Quad_"></a> Interpolate\(Quad\)

Interpolates this <xref href="osu.Framework.Graphics.Colour.ColourInfo" data-throw-if-not-resolved="false"></xref> across a quad.

```csharp
public readonly ColourInfo Interpolate(Quad quad)
```

#### Parameters

`quad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

#### Remarks

This method is especially useful when working with multi-colour <xref href="osu.Framework.Graphics.Colour.ColourInfo" data-throw-if-not-resolved="false"></xref>s.
When such a colour is interpolated across a quad that is a subset of the unit quad (0, 0, 1, 1),
the resulting colour can be thought of as the the original colour but "cropped" to the bounds of the subquad.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_MultiplyAlpha_System_Single_"></a> MultiplyAlpha\(float\)

Created a new ColourInfo with the alpha value of the colours of all vertices
multiplied by a given alpha parameter.

```csharp
public readonly ColourInfo MultiplyAlpha(float alpha)
```

#### Parameters

`alpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

The alpha parameter to multiply the alpha values of all vertices with.

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The new ColourInfo.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_SingleColour_osu_Framework_Graphics_Colour_SRGBColour_"></a> SingleColour\(SRGBColour\)

Creates a ColourInfo with a single linear colour assigned to all vertices.

```csharp
public static ColourInfo SingleColour(SRGBColour colour)
```

#### Parameters

`colour` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

The single linear colour to be assigned to all vertices.

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

The created ColourInfo.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_Colour_ColourInfo_TryExtractSingleColour_osu_Framework_Graphics_Colour_SRGBColour__"></a> TryExtractSingleColour\(out SRGBColour\)

Attempts to extract the single colour represented by this <xref href="osu.Framework.Graphics.Colour.ColourInfo" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly bool TryExtractSingleColour(out SRGBColour colour)
```

#### Parameters

`colour` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

The extracted colour. If <code>false</code> is returned, this represents the top-left colour.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the extracted colour is the single colour represented by this <xref href="osu.Framework.Graphics.Colour.ColourInfo" data-throw-if-not-resolved="false"></xref>.

## Operators

### <a id="osu_Framework_Graphics_Colour_ColourInfo_op_Implicit_osu_Framework_Graphics_Colour_SRGBColour__osu_Framework_Graphics_Colour_ColourInfo"></a> implicit operator ColourInfo\(SRGBColour\)

```csharp
public static implicit operator ColourInfo(SRGBColour colour)
```

#### Parameters

`colour` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_op_Implicit_osu_Framework_Graphics_Colour_ColourInfo__osu_Framework_Graphics_Colour_SRGBColour"></a> implicit operator SRGBColour\(ColourInfo\)

```csharp
public static implicit operator SRGBColour(ColourInfo colour)
```

#### Parameters

`colour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_op_Implicit_osuTK_Graphics_Color4__osu_Framework_Graphics_Colour_ColourInfo"></a> implicit operator ColourInfo\(Color4\)

```csharp
public static implicit operator ColourInfo(Color4 colour)
```

#### Parameters

`colour` Color4

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_op_Implicit_osu_Framework_Graphics_Colour_ColourInfo__osuTK_Graphics_Color4"></a> implicit operator Color4\(ColourInfo\)

```csharp
public static implicit operator Color4(ColourInfo colour)
```

#### Parameters

`colour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

#### Returns

 Color4

### <a id="osu_Framework_Graphics_Colour_ColourInfo_op_Implicit_osu_Framework_Graphics_Colour4__osu_Framework_Graphics_Colour_ColourInfo"></a> implicit operator ColourInfo\(Colour4\)

```csharp
public static implicit operator ColourInfo(Colour4 colour)
```

#### Parameters

`colour` [Colour4](osu.Framework.Graphics.Colour4.md)

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Colour_ColourInfo_op_Implicit_osu_Framework_Graphics_Colour_ColourInfo__osu_Framework_Graphics_Colour4"></a> implicit operator Colour4\(ColourInfo\)

```csharp
public static implicit operator Colour4(ColourInfo colour)
```

#### Parameters

`colour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

