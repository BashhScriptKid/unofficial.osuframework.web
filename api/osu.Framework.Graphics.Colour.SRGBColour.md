# <a id="osu_Framework_Graphics_Colour_SRGBColour"></a> Struct SRGBColour

Namespace: [osu.Framework.Graphics.Colour](osu.Framework.Graphics.Colour.md)  
Assembly: osu.Framework.dll  

A wrapper struct around Color4 that takes care of converting between sRGB and linear colour spaces.
Internally this struct stores the colour in sRGB space, which is exposed by the <xref href="osu.Framework.Graphics.Colour.SRGBColour.SRGB" data-throw-if-not-resolved="false"></xref> member.
This struct converts to linear space by using the <xref href="osu.Framework.Graphics.Colour.SRGBColour.Linear" data-throw-if-not-resolved="false"></xref> member.

```csharp
public struct SRGBColour : IEquatable<SRGBColour>
```

#### Implements

[IEquatable<SRGBColour\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SRGBColour\>\(SRGBColour\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SRGBColour\>\(SRGBColour\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<SRGBColour\>\(SRGBColour\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SRGBColour\>\(SRGBColour\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SRGBColour, TChild\>\(SRGBColour, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SRGBColour, TChild\>\(SRGBColour, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SRGBColour, TChild\>\(SRGBColour, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SRGBColour\>\(SRGBColour\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Colour_SRGBColour_SRGB"></a> SRGB

A <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> representation of this colour in the sRGB space.

```csharp
public Color4 SRGB
```

#### Field Value

 Color4

## Properties

### <a id="osu_Framework_Graphics_Colour_SRGBColour_Alpha"></a> Alpha

The alpha component of this colour.

```csharp
public float Alpha { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_Linear"></a> Linear

A <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> representation of this colour in the linear space.

```csharp
public Color4 Linear { get; }
```

#### Property Value

 Color4

## Methods

### <a id="osu_Framework_Graphics_Colour_SRGBColour_Equals_osu_Framework_Graphics_Colour_SRGBColour_"></a> Equals\(SRGBColour\)

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

### <a id="osu_Framework_Graphics_Colour_SRGBColour_FromVector_osuTK_Vector4_"></a> FromVector\(Vector4\)

```csharp
public static SRGBColour FromVector(Vector4 v)
```

#### Parameters

`v` Vector4

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_MultiplyAlpha_System_Single_"></a> MultiplyAlpha\(float\)

Multiplies the alpha value of this colour by the given alpha factor.

```csharp
public void MultiplyAlpha(float alpha)
```

#### Parameters

`alpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

The alpha factor to multiply with.

### <a id="osu_Framework_Graphics_Colour_SRGBColour_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_Colour_SRGBColour_ToVector"></a> ToVector\(\)

```csharp
public readonly Vector4 ToVector()
```

#### Returns

 Vector4

## Operators

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Addition_osu_Framework_Graphics_Colour_SRGBColour_osu_Framework_Graphics_Colour_SRGBColour_"></a> operator \+\(SRGBColour, SRGBColour\)

```csharp
public static SRGBColour operator +(SRGBColour first, SRGBColour second)
```

#### Parameters

`first` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

`second` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Division_osu_Framework_Graphics_Colour_SRGBColour_System_Single_"></a> operator /\(SRGBColour, float\)

```csharp
public static SRGBColour operator /(SRGBColour first, float second)
```

#### Parameters

`first` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

`second` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Implicit_osuTK_Graphics_Color4__osu_Framework_Graphics_Colour_SRGBColour"></a> implicit operator SRGBColour\(Color4\)

```csharp
public static implicit operator SRGBColour(Color4 value)
```

#### Parameters

`value` Color4

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Implicit_osu_Framework_Graphics_Colour_SRGBColour__osuTK_Graphics_Color4"></a> implicit operator Color4\(SRGBColour\)

```csharp
public static implicit operator Color4(SRGBColour value)
```

#### Parameters

`value` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

#### Returns

 Color4

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Implicit_osu_Framework_Graphics_Colour4__osu_Framework_Graphics_Colour_SRGBColour"></a> implicit operator SRGBColour\(Colour4\)

```csharp
public static implicit operator SRGBColour(Colour4 value)
```

#### Parameters

`value` [Colour4](osu.Framework.Graphics.Colour4.md)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Implicit_osu_Framework_Graphics_Colour_SRGBColour__osu_Framework_Graphics_Colour4"></a> implicit operator Colour4\(SRGBColour\)

```csharp
public static implicit operator Colour4(SRGBColour value)
```

#### Parameters

`value` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Multiply_osu_Framework_Graphics_Colour_SRGBColour_osu_Framework_Graphics_Colour_SRGBColour_"></a> operator \*\(SRGBColour, SRGBColour\)

```csharp
public static SRGBColour operator *(SRGBColour first, SRGBColour second)
```

#### Parameters

`first` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

`second` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Colour_SRGBColour_op_Multiply_osu_Framework_Graphics_Colour_SRGBColour_System_Single_"></a> operator \*\(SRGBColour, float\)

```csharp
public static SRGBColour operator *(SRGBColour first, float second)
```

#### Parameters

`first` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

`second` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

