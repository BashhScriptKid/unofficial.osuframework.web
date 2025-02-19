# <a id="osu_Framework_Graphics_Colour4"></a> Struct Colour4

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Represents an RGBA colour in the linear colour space, having colour components in the range 0-1.
Stored internally as a <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref> for performance.

```csharp
public readonly struct Colour4 : IEquatable<Colour4>
```

#### Implements

[IEquatable<Colour4\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Colour4\>\(Colour4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Colour4\>\(Colour4\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Colour4\>\(Colour4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Colour4\>\(Colour4\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Colour4, TChild\>\(Colour4, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Colour4, TChild\>\(Colour4, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Colour4, TChild\>\(Colour4, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Colour4\>\(Colour4\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Colour4__ctor_System_Single_System_Single_System_Single_System_Single_"></a> Colour4\(float, float, float, float\)

Creates a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with the specified RGBA components in the 0-1 range.

```csharp
public Colour4(float r, float g, float b, float a)
```

#### Parameters

`r` [float](https://learn.microsoft.com/dotnet/api/system.single)

The red component, in the 0-1 range.

`g` [float](https://learn.microsoft.com/dotnet/api/system.single)

The green component, in the 0-1 range.

`b` [float](https://learn.microsoft.com/dotnet/api/system.single)

The blue component, in the 0-1 range.

`a` [float](https://learn.microsoft.com/dotnet/api/system.single)

The alpha component, in the 0-1 range.

### <a id="osu_Framework_Graphics_Colour4__ctor_System_Byte_System_Byte_System_Byte_System_Byte_"></a> Colour4\(byte, byte, byte, byte\)

Creates a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with the specified RGBA components in the 0-255 range.

```csharp
public Colour4(byte r, byte g, byte b, byte a)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The red component, in the 0-255 range.

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The green component, in the 0-255 range.

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The blue component, in the 0-255 range.

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The alpha component, in the 0-255 range.

### <a id="osu_Framework_Graphics_Colour4__ctor_System_Numerics_Vector4_"></a> Colour4\(Vector4\)

Creates a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with the specified <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref>,
where XYZW maps to RGBA.

```csharp
public Colour4(Vector4 vector)
```

#### Parameters

`vector` [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

The source vector, whose components should be in the 0-1 range.

## Fields

### <a id="osu_Framework_Graphics_Colour4_Vector"></a> Vector

<xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref> representation of the colour, where XYZW maps to RGBA,
and each component is in the 0-1 range.

```csharp
public readonly Vector4 Vector
```

#### Field Value

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

## Properties

### <a id="osu_Framework_Graphics_Colour4_A"></a> A

Represents the alpha component of the RGBA colour in the 0-1 range.

```csharp
public float A { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Colour4_AliceBlue"></a> AliceBlue

Gets the system color with (R, G, B, A) = (240, 248, 255, 255).

```csharp
public static Colour4 AliceBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_AntiqueWhite"></a> AntiqueWhite

Gets the system color with (R, G, B, A) = (250, 235, 215, 255).

```csharp
public static Colour4 AntiqueWhite { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Aqua"></a> Aqua

Gets the system color with (R, G, B, A) = (0, 255, 255, 255).

```csharp
public static Colour4 Aqua { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Aquamarine"></a> Aquamarine

Gets the system color with (R, G, B, A) = (127, 255, 212, 255).

```csharp
public static Colour4 Aquamarine { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Azure"></a> Azure

Gets the system color with (R, G, B, A) = (240, 255, 255, 255).

```csharp
public static Colour4 Azure { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_B"></a> B

Represents the blue component of the linear RGBA colour in the 0-1 range.

```csharp
public float B { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Colour4_Beige"></a> Beige

Gets the system color with (R, G, B, A) = (245, 245, 220, 255).

```csharp
public static Colour4 Beige { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Bisque"></a> Bisque

Gets the system color with (R, G, B, A) = (255, 228, 196, 255).

```csharp
public static Colour4 Bisque { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Black"></a> Black

Gets the system color with (R, G, B, A) = (0, 0, 0, 255).

```csharp
public static Colour4 Black { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_BlanchedAlmond"></a> BlanchedAlmond

Gets the system color with (R, G, B, A) = (255, 235, 205, 255).

```csharp
public static Colour4 BlanchedAlmond { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Blue"></a> Blue

Gets the system color with (R, G, B, A) = (0, 0, 255, 255).

```csharp
public static Colour4 Blue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_BlueViolet"></a> BlueViolet

Gets the system color with (R, G, B, A) = (138, 43, 226, 255).

```csharp
public static Colour4 BlueViolet { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Brown"></a> Brown

Gets the system color with (R, G, B, A) = (165, 42, 42, 255).

```csharp
public static Colour4 Brown { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_BurlyWood"></a> BurlyWood

Gets the system color with (R, G, B, A) = (222, 184, 135, 255).

```csharp
public static Colour4 BurlyWood { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_CadetBlue"></a> CadetBlue

Gets the system color with (R, G, B, A) = (95, 158, 160, 255).

```csharp
public static Colour4 CadetBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Chartreuse"></a> Chartreuse

Gets the system color with (R, G, B, A) = (127, 255, 0, 255).

```csharp
public static Colour4 Chartreuse { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Chocolate"></a> Chocolate

Gets the system color with (R, G, B, A) = (210, 105, 30, 255).

```csharp
public static Colour4 Chocolate { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Coral"></a> Coral

Gets the system color with (R, G, B, A) = (255, 127, 80, 255).

```csharp
public static Colour4 Coral { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_CornflowerBlue"></a> CornflowerBlue

Gets the system color with (R, G, B, A) = (100, 149, 237, 255).

```csharp
public static Colour4 CornflowerBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Cornsilk"></a> Cornsilk

Gets the system color with (R, G, B, A) = (255, 248, 220, 255).

```csharp
public static Colour4 Cornsilk { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Crimson"></a> Crimson

Gets the system color with (R, G, B, A) = (220, 20, 60, 255).

```csharp
public static Colour4 Crimson { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Cyan"></a> Cyan

Gets the system color with (R, G, B, A) = (0, 255, 255, 255).

```csharp
public static Colour4 Cyan { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkBlue"></a> DarkBlue

Gets the system color with (R, G, B, A) = (0, 0, 139, 255).

```csharp
public static Colour4 DarkBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkCyan"></a> DarkCyan

Gets the system color with (R, G, B, A) = (0, 139, 139, 255).

```csharp
public static Colour4 DarkCyan { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkGoldenrod"></a> DarkGoldenrod

Gets the system color with (R, G, B, A) = (184, 134, 11, 255).

```csharp
public static Colour4 DarkGoldenrod { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkGray"></a> DarkGray

Gets the system color with (R, G, B, A) = (169, 169, 169, 255).

```csharp
public static Colour4 DarkGray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkGreen"></a> DarkGreen

Gets the system color with (R, G, B, A) = (0, 100, 0, 255).

```csharp
public static Colour4 DarkGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkKhaki"></a> DarkKhaki

Gets the system color with (R, G, B, A) = (189, 183, 107, 255).

```csharp
public static Colour4 DarkKhaki { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkMagenta"></a> DarkMagenta

Gets the system color with (R, G, B, A) = (139, 0, 139, 255).

```csharp
public static Colour4 DarkMagenta { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkOliveGreen"></a> DarkOliveGreen

Gets the system color with (R, G, B, A) = (85, 107, 47, 255).

```csharp
public static Colour4 DarkOliveGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkOrange"></a> DarkOrange

Gets the system color with (R, G, B, A) = (255, 140, 0, 255).

```csharp
public static Colour4 DarkOrange { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkOrchid"></a> DarkOrchid

Gets the system color with (R, G, B, A) = (153, 50, 204, 255).

```csharp
public static Colour4 DarkOrchid { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkRed"></a> DarkRed

Gets the system color with (R, G, B, A) = (139, 0, 0, 255).

```csharp
public static Colour4 DarkRed { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkSalmon"></a> DarkSalmon

Gets the system color with (R, G, B, A) = (233, 150, 122, 255).

```csharp
public static Colour4 DarkSalmon { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkSeaGreen"></a> DarkSeaGreen

Gets the system color with (R, G, B, A) = (143, 188, 139, 255).

```csharp
public static Colour4 DarkSeaGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkSlateBlue"></a> DarkSlateBlue

Gets the system color with (R, G, B, A) = (72, 61, 139, 255).

```csharp
public static Colour4 DarkSlateBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkSlateGray"></a> DarkSlateGray

Gets the system color with (R, G, B, A) = (47, 79, 79, 255).

```csharp
public static Colour4 DarkSlateGray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkTurquoise"></a> DarkTurquoise

Gets the system color with (R, G, B, A) = (0, 206, 209, 255).

```csharp
public static Colour4 DarkTurquoise { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DarkViolet"></a> DarkViolet

Gets the system color with (R, G, B, A) = (148, 0, 211, 255).

```csharp
public static Colour4 DarkViolet { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DeepPink"></a> DeepPink

Gets the system color with (R, G, B, A) = (255, 20, 147, 255).

```csharp
public static Colour4 DeepPink { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DeepSkyBlue"></a> DeepSkyBlue

Gets the system color with (R, G, B, A) = (0, 191, 255, 255).

```csharp
public static Colour4 DeepSkyBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DimGray"></a> DimGray

Gets the system color with (R, G, B, A) = (105, 105, 105, 255).

```csharp
public static Colour4 DimGray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_DodgerBlue"></a> DodgerBlue

Gets the system color with (R, G, B, A) = (30, 144, 255, 255).

```csharp
public static Colour4 DodgerBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Firebrick"></a> Firebrick

Gets the system color with (R, G, B, A) = (178, 34, 34, 255).

```csharp
public static Colour4 Firebrick { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_FloralWhite"></a> FloralWhite

Gets the system color with (R, G, B, A) = (255, 250, 240, 255).

```csharp
public static Colour4 FloralWhite { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_ForestGreen"></a> ForestGreen

Gets the system color with (R, G, B, A) = (34, 139, 34, 255).

```csharp
public static Colour4 ForestGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Fuchsia"></a> Fuchsia

Gets the system color with (R, G, B, A) = (255, 0, 255, 255).

```csharp
public static Colour4 Fuchsia { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_G"></a> G

Represents the green component of the linear RGBA colour in the 0-1 range.

```csharp
public float G { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Colour4_Gainsboro"></a> Gainsboro

Gets the system color with (R, G, B, A) = (220, 220, 220, 255).

```csharp
public static Colour4 Gainsboro { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_GhostWhite"></a> GhostWhite

Gets the system color with (R, G, B, A) = (248, 248, 255, 255).

```csharp
public static Colour4 GhostWhite { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Gold"></a> Gold

Gets the system color with (R, G, B, A) = (255, 215, 0, 255).

```csharp
public static Colour4 Gold { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Goldenrod"></a> Goldenrod

Gets the system color with (R, G, B, A) = (218, 165, 32, 255).

```csharp
public static Colour4 Goldenrod { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Gray"></a> Gray

Gets the system color with (R, G, B, A) = (128, 128, 128, 255).

```csharp
public static Colour4 Gray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Green"></a> Green

Gets the system color with (R, G, B, A) = (0, 128, 0, 255).

```csharp
public static Colour4 Green { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_GreenYellow"></a> GreenYellow

Gets the system color with (R, G, B, A) = (173, 255, 47, 255).

```csharp
public static Colour4 GreenYellow { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Honeydew"></a> Honeydew

Gets the system color with (R, G, B, A) = (240, 255, 240, 255).

```csharp
public static Colour4 Honeydew { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_HotPink"></a> HotPink

Gets the system color with (R, G, B, A) = (255, 105, 180, 255).

```csharp
public static Colour4 HotPink { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_IndianRed"></a> IndianRed

Gets the system color with (R, G, B, A) = (205, 92, 92, 255).

```csharp
public static Colour4 IndianRed { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Indigo"></a> Indigo

Gets the system color with (R, G, B, A) = (75, 0, 130, 255).

```csharp
public static Colour4 Indigo { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Ivory"></a> Ivory

Gets the system color with (R, G, B, A) = (255, 255, 240, 255).

```csharp
public static Colour4 Ivory { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Khaki"></a> Khaki

Gets the system color with (R, G, B, A) = (240, 230, 140, 255).

```csharp
public static Colour4 Khaki { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Lavender"></a> Lavender

Gets the system color with (R, G, B, A) = (230, 230, 250, 255).

```csharp
public static Colour4 Lavender { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LavenderBlush"></a> LavenderBlush

Gets the system color with (R, G, B, A) = (255, 240, 245, 255).

```csharp
public static Colour4 LavenderBlush { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LawnGreen"></a> LawnGreen

Gets the system color with (R, G, B, A) = (124, 252, 0, 255).

```csharp
public static Colour4 LawnGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LemonChiffon"></a> LemonChiffon

Gets the system color with (R, G, B, A) = (255, 250, 205, 255).

```csharp
public static Colour4 LemonChiffon { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightBlue"></a> LightBlue

Gets the system color with (R, G, B, A) = (173, 216, 230, 255).

```csharp
public static Colour4 LightBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightCoral"></a> LightCoral

Gets the system color with (R, G, B, A) = (240, 128, 128, 255).

```csharp
public static Colour4 LightCoral { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightCyan"></a> LightCyan

Gets the system color with (R, G, B, A) = (224, 255, 255, 255).

```csharp
public static Colour4 LightCyan { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightGoldenrodYellow"></a> LightGoldenrodYellow

Gets the system color with (R, G, B, A) = (250, 250, 210, 255).

```csharp
public static Colour4 LightGoldenrodYellow { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightGray"></a> LightGray

Gets the system color with (R, G, B, A) = (211, 211, 211, 255).

```csharp
public static Colour4 LightGray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightGreen"></a> LightGreen

Gets the system color with (R, G, B, A) = (144, 238, 144, 255).

```csharp
public static Colour4 LightGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightPink"></a> LightPink

Gets the system color with (R, G, B, A) = (255, 182, 193, 255).

```csharp
public static Colour4 LightPink { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightSalmon"></a> LightSalmon

Gets the system color with (R, G, B, A) = (255, 160, 122, 255).

```csharp
public static Colour4 LightSalmon { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightSeaGreen"></a> LightSeaGreen

Gets the system color with (R, G, B, A) = (32, 178, 170, 255).

```csharp
public static Colour4 LightSeaGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightSkyBlue"></a> LightSkyBlue

Gets the system color with (R, G, B, A) = (135, 206, 250, 255).

```csharp
public static Colour4 LightSkyBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightSlateGray"></a> LightSlateGray

Gets the system color with (R, G, B, A) = (119, 136, 153, 255).

```csharp
public static Colour4 LightSlateGray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightSteelBlue"></a> LightSteelBlue

Gets the system color with (R, G, B, A) = (176, 196, 222, 255).

```csharp
public static Colour4 LightSteelBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LightYellow"></a> LightYellow

Gets the system color with (R, G, B, A) = (255, 255, 224, 255).

```csharp
public static Colour4 LightYellow { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Lime"></a> Lime

Gets the system color with (R, G, B, A) = (0, 255, 0, 255).

```csharp
public static Colour4 Lime { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_LimeGreen"></a> LimeGreen

Gets the system color with (R, G, B, A) = (50, 205, 50, 255).

```csharp
public static Colour4 LimeGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Linen"></a> Linen

Gets the system color with (R, G, B, A) = (250, 240, 230, 255).

```csharp
public static Colour4 Linen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Magenta"></a> Magenta

Gets the system color with (R, G, B, A) = (255, 0, 255, 255).

```csharp
public static Colour4 Magenta { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Maroon"></a> Maroon

Gets the system color with (R, G, B, A) = (128, 0, 0, 255).

```csharp
public static Colour4 Maroon { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumAquamarine"></a> MediumAquamarine

Gets the system color with (R, G, B, A) = (102, 205, 170, 255).

```csharp
public static Colour4 MediumAquamarine { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumBlue"></a> MediumBlue

Gets the system color with (R, G, B, A) = (0, 0, 205, 255).

```csharp
public static Colour4 MediumBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumOrchid"></a> MediumOrchid

Gets the system color with (R, G, B, A) = (186, 85, 211, 255).

```csharp
public static Colour4 MediumOrchid { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumPurple"></a> MediumPurple

Gets the system color with (R, G, B, A) = (147, 112, 219, 255).

```csharp
public static Colour4 MediumPurple { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumSeaGreen"></a> MediumSeaGreen

Gets the system color with (R, G, B, A) = (60, 179, 113, 255).

```csharp
public static Colour4 MediumSeaGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumSlateBlue"></a> MediumSlateBlue

Gets the system color with (R, G, B, A) = (123, 104, 238, 255).

```csharp
public static Colour4 MediumSlateBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumSpringGreen"></a> MediumSpringGreen

Gets the system color with (R, G, B, A) = (0, 250, 154, 255).

```csharp
public static Colour4 MediumSpringGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumTurquoise"></a> MediumTurquoise

Gets the system color with (R, G, B, A) = (72, 209, 204, 255).

```csharp
public static Colour4 MediumTurquoise { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MediumVioletRed"></a> MediumVioletRed

Gets the system color with (R, G, B, A) = (199, 21, 133, 255).

```csharp
public static Colour4 MediumVioletRed { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MidnightBlue"></a> MidnightBlue

Gets the system color with (R, G, B, A) = (25, 25, 112, 255).

```csharp
public static Colour4 MidnightBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MintCream"></a> MintCream

Gets the system color with (R, G, B, A) = (245, 255, 250, 255).

```csharp
public static Colour4 MintCream { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MistyRose"></a> MistyRose

Gets the system color with (R, G, B, A) = (255, 228, 225, 255).

```csharp
public static Colour4 MistyRose { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Moccasin"></a> Moccasin

Gets the system color with (R, G, B, A) = (255, 228, 181, 255).

```csharp
public static Colour4 Moccasin { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_NavajoWhite"></a> NavajoWhite

Gets the system color with (R, G, B, A) = (255, 222, 173, 255).

```csharp
public static Colour4 NavajoWhite { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Navy"></a> Navy

Gets the system color with (R, G, B, A) = (0, 0, 128, 255).

```csharp
public static Colour4 Navy { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_OldLace"></a> OldLace

Gets the system color with (R, G, B, A) = (253, 245, 230, 255).

```csharp
public static Colour4 OldLace { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Olive"></a> Olive

Gets the system color with (R, G, B, A) = (128, 128, 0, 255).

```csharp
public static Colour4 Olive { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_OliveDrab"></a> OliveDrab

Gets the system color with (R, G, B, A) = (107, 142, 35, 255).

```csharp
public static Colour4 OliveDrab { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Orange"></a> Orange

Gets the system color with (R, G, B, A) = (255, 165, 0, 255).

```csharp
public static Colour4 Orange { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_OrangeRed"></a> OrangeRed

Gets the system color with (R, G, B, A) = (255, 69, 0, 255).

```csharp
public static Colour4 OrangeRed { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Orchid"></a> Orchid

Gets the system color with (R, G, B, A) = (218, 112, 214, 255).

```csharp
public static Colour4 Orchid { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PaleGoldenrod"></a> PaleGoldenrod

Gets the system color with (R, G, B, A) = (238, 232, 170, 255).

```csharp
public static Colour4 PaleGoldenrod { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PaleGreen"></a> PaleGreen

Gets the system color with (R, G, B, A) = (152, 251, 152, 255).

```csharp
public static Colour4 PaleGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PaleTurquoise"></a> PaleTurquoise

Gets the system color with (R, G, B, A) = (175, 238, 238, 255).

```csharp
public static Colour4 PaleTurquoise { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PaleVioletRed"></a> PaleVioletRed

Gets the system color with (R, G, B, A) = (219, 112, 147, 255).

```csharp
public static Colour4 PaleVioletRed { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PapayaWhip"></a> PapayaWhip

Gets the system color with (R, G, B, A) = (255, 239, 213, 255).

```csharp
public static Colour4 PapayaWhip { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PeachPuff"></a> PeachPuff

Gets the system color with (R, G, B, A) = (255, 218, 185, 255).

```csharp
public static Colour4 PeachPuff { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Peru"></a> Peru

Gets the system color with (R, G, B, A) = (205, 133, 63, 255).

```csharp
public static Colour4 Peru { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Pink"></a> Pink

Gets the system color with (R, G, B, A) = (255, 192, 203, 255).

```csharp
public static Colour4 Pink { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Plum"></a> Plum

Gets the system color with (R, G, B, A) = (221, 160, 221, 255).

```csharp
public static Colour4 Plum { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_PowderBlue"></a> PowderBlue

Gets the system color with (R, G, B, A) = (176, 224, 230, 255).

```csharp
public static Colour4 PowderBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Purple"></a> Purple

Gets the system color with (R, G, B, A) = (128, 0, 128, 255).

```csharp
public static Colour4 Purple { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_R"></a> R

Represents the red component of the linear RGBA colour in the 0-1 range.

```csharp
public float R { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Colour4_Red"></a> Red

Gets the system color with (R, G, B, A) = (255, 0, 0, 255).

```csharp
public static Colour4 Red { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_RosyBrown"></a> RosyBrown

Gets the system color with (R, G, B, A) = (188, 143, 143, 255).

```csharp
public static Colour4 RosyBrown { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_RoyalBlue"></a> RoyalBlue

Gets the system color with (R, G, B, A) = (65, 105, 225, 255).

```csharp
public static Colour4 RoyalBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SaddleBrown"></a> SaddleBrown

Gets the system color with (R, G, B, A) = (139, 69, 19, 255).

```csharp
public static Colour4 SaddleBrown { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Salmon"></a> Salmon

Gets the system color with (R, G, B, A) = (250, 128, 114, 255).

```csharp
public static Colour4 Salmon { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SandyBrown"></a> SandyBrown

Gets the system color with (R, G, B, A) = (244, 164, 96, 255).

```csharp
public static Colour4 SandyBrown { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SeaGreen"></a> SeaGreen

Gets the system color with (R, G, B, A) = (46, 139, 87, 255).

```csharp
public static Colour4 SeaGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SeaShell"></a> SeaShell

Gets the system color with (R, G, B, A) = (255, 245, 238, 255).

```csharp
public static Colour4 SeaShell { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Sienna"></a> Sienna

Gets the system color with (R, G, B, A) = (160, 82, 45, 255).

```csharp
public static Colour4 Sienna { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Silver"></a> Silver

Gets the system color with (R, G, B, A) = (192, 192, 192, 255).

```csharp
public static Colour4 Silver { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SkyBlue"></a> SkyBlue

Gets the system color with (R, G, B, A) = (135, 206, 235, 255).

```csharp
public static Colour4 SkyBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SlateBlue"></a> SlateBlue

Gets the system color with (R, G, B, A) = (106, 90, 205, 255).

```csharp
public static Colour4 SlateBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SlateGray"></a> SlateGray

Gets the system color with (R, G, B, A) = (112, 128, 144, 255).

```csharp
public static Colour4 SlateGray { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Snow"></a> Snow

Gets the system color with (R, G, B, A) = (255, 250, 250, 255).

```csharp
public static Colour4 Snow { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SpringGreen"></a> SpringGreen

Gets the system color with (R, G, B, A) = (0, 255, 127, 255).

```csharp
public static Colour4 SpringGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_SteelBlue"></a> SteelBlue

Gets the system color with (R, G, B, A) = (70, 130, 180, 255).

```csharp
public static Colour4 SteelBlue { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Tan"></a> Tan

Gets the system color with (R, G, B, A) = (210, 180, 140, 255).

```csharp
public static Colour4 Tan { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Teal"></a> Teal

Gets the system color with (R, G, B, A) = (0, 128, 128, 255).

```csharp
public static Colour4 Teal { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Thistle"></a> Thistle

Gets the system color with (R, G, B, A) = (216, 191, 216, 255).

```csharp
public static Colour4 Thistle { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Tomato"></a> Tomato

Gets the system color with (R, G, B, A) = (255, 99, 71, 255).

```csharp
public static Colour4 Tomato { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Transparent"></a> Transparent

Gets the system color with (R, G, B, A) = (255, 255, 255, 0).

```csharp
public static Colour4 Transparent { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Turquoise"></a> Turquoise

Gets the system color with (R, G, B, A) = (64, 224, 208, 255).

```csharp
public static Colour4 Turquoise { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Violet"></a> Violet

Gets the system color with (R, G, B, A) = (238, 130, 238, 255).

```csharp
public static Colour4 Violet { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Wheat"></a> Wheat

Gets the system color with (R, G, B, A) = (245, 222, 179, 255).

```csharp
public static Colour4 Wheat { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_White"></a> White

Gets the system color with (R, G, B, A) = (255, 255, 255, 255).

```csharp
public static Colour4 White { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_WhiteSmoke"></a> WhiteSmoke

Gets the system color with (R, G, B, A) = (245, 245, 245, 255).

```csharp
public static Colour4 WhiteSmoke { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Yellow"></a> Yellow

Gets the system color with (R, G, B, A) = (255, 255, 0, 255).

```csharp
public static Colour4 Yellow { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_YellowGreen"></a> YellowGreen

Gets the system color with (R, G, B, A) = (154, 205, 50, 255).

```csharp
public static Colour4 YellowGreen { get; }
```

#### Property Value

 [Colour4](osu.Framework.Graphics.Colour4.md)

## Methods

### <a id="osu_Framework_Graphics_Colour4_Clamped"></a> Clamped\(\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with its individual components clamped to the 0-1 range.

```csharp
public Colour4 Clamped()
```

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Darken_System_Single_"></a> Darken\(float\)

Returns a darkened version of the colour.

```csharp
public Colour4 Darken(float amount)
```

#### Parameters

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

Percentage light reduction

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Equals_osu_Framework_Graphics_Colour4_"></a> Equals\(Colour4\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Colour4 other)
```

#### Parameters

`other` [Colour4](osu.Framework.Graphics.Colour4.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Colour4_Equals_System_Object_"></a> Equals\(object\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Colour4_FromARGB_System_UInt32_"></a> FromARGB\(uint\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> from the passed 32-bit unsigned integer in the format ARGB.

```csharp
public static Colour4 FromARGB(uint argb)
```

#### Parameters

`argb` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The source colour in Argb32 format.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_FromHSL_System_Single_System_Single_System_Single_System_Single_"></a> FromHSL\(float, float, float, float\)

Converts an HSL colour to a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref>. All components should be in the range 0-1.

```csharp
public static Colour4 FromHSL(float hue, float saturation, float lightness, float alpha = 1)
```

#### Parameters

`hue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The hue, between 0 and 1.

`saturation` [float](https://learn.microsoft.com/dotnet/api/system.single)

The saturation, between 0 and 1.

`lightness` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value, between 0 and 1.

`alpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

The alpha, between 0 and 1.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_FromHSV_System_Single_System_Single_System_Single_System_Single_"></a> FromHSV\(float, float, float, float\)

Converts an HSV colour to a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref>. All components should be in the range 0-1.

```csharp
public static Colour4 FromHSV(float hue, float saturation, float value, float alpha = 1)
```

#### Parameters

`hue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The hue, between 0 and 1.

`saturation` [float](https://learn.microsoft.com/dotnet/api/system.single)

The saturation, between 0 and 1.

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value, between 0 and 1.

`alpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

The alpha, between 0 and 1.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_FromHex_System_String_"></a> FromHex\(string\)

Converts an RGB or RGBA-formatted hex colour code into a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref>.
Supported colour code formats:
<ul><li>RGB</li><li>#RGB</li><li>RGBA</li><li>#RGBA</li><li>RRGGBB</li><li>#RRGGBB</li><li>RRGGBBAA</li><li>#RRGGBBAA</li></ul>

```csharp
public static Colour4 FromHex(string hex)
```

#### Parameters

`hex` [string](https://learn.microsoft.com/dotnet/api/system.string)

The hex code.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

The <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> representing the colour.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

If <code class="paramref">hex</code> is not a supported colour code.

### <a id="osu_Framework_Graphics_Colour4_FromRGBA_System_UInt32_"></a> FromRGBA\(uint\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> from the passed 32-bit unsigned integer in the format RGBA.

```csharp
public static Colour4 FromRGBA(uint rgba)
```

#### Parameters

`rgba` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The source colour in Rgba32 format.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Graphics_Colour4_Lighten_System_Single_"></a> Lighten\(float\)

Returns a lightened version of the colour.

```csharp
public Colour4 Lighten(float amount)
```

#### Parameters

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

Percentage light addition

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_MultiplyAlpha_System_Single_"></a> MultiplyAlpha\(float\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with the same RGB components, but multiplying the current alpha component by a scalar value.
The final alpha is clamped to the 0-1 range.

```csharp
public Colour4 MultiplyAlpha(float scalar)
```

#### Parameters

`scalar` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value that the existing alpha will be multiplied by.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Opacity_System_Single_"></a> Opacity\(float\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with the same RGB components and a specified alpha value.
The final alpha is clamped to the 0-1 range.

```csharp
public Colour4 Opacity(float alpha)
```

#### Parameters

`alpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

The new alpha value for the returned colour, in the 0-1 range.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_Opacity_System_Byte_"></a> Opacity\(byte\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with the same RGB components and a specified alpha value.
The final alpha is clamped to the 0-1 range.

```csharp
public Colour4 Opacity(byte alpha)
```

#### Parameters

`alpha` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The new alpha value for the returned colour, in the 0-255 range.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_ToARGB"></a> ToARGB\(\)

Returns the <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> as a 32-bit unsigned integer in the format ARGB.

```csharp
public uint ToARGB()
```

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="osu_Framework_Graphics_Colour4_ToHSL"></a> ToHSL\(\)

Converts a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> to the HSL colour space, represented in the XYZ components of a <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref>.
The returned vector's W component represents the alpha channel of the colour.
The angular hue is compressed to the 0-1 range in line with the other components.

```csharp
public Vector4 ToHSL()
```

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

A <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref> representing the colour, where all four components are in the 0-1 range.

### <a id="osu_Framework_Graphics_Colour4_ToHSV"></a> ToHSV\(\)

Converts a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> to the HSV colour space, represented in the XYZ components of a <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref>.
The returned vector's W component represents the alpha channel of the colour.
The angular hue is compressed to the 0-1 range in line with the other components.

```csharp
public Vector4 ToHSV()
```

#### Returns

 [Vector4](https://learn.microsoft.com/dotnet/api/system.numerics.vector4)

A <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref> representing the colour, where all four components are in the 0-1 range.

### <a id="osu_Framework_Graphics_Colour4_ToHex_System_Boolean_"></a> ToHex\(bool\)

Converts a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> into a hex colour code.

```csharp
public string ToHex(bool alwaysOutputAlpha = false)
```

#### Parameters

`alwaysOutputAlpha` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the alpha channel should always be output. If <code>false</code>, the alpha channel is only output if this colour is translucent.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The hex code representing the colour.

### <a id="osu_Framework_Graphics_Colour4_ToLinear"></a> ToLinear\(\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with an SRGB-&gt;Linear conversion applied
to each of its chromatic components. Alpha is unchanged.

```csharp
public Colour4 ToLinear()
```

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_ToRGBA"></a> ToRGBA\(\)

Returns the <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> as a 32-bit unsigned integer in the format RGBA.

```csharp
public uint ToRGBA()
```

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="osu_Framework_Graphics_Colour4_ToSRGB"></a> ToSRGB\(\)

Returns a new <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> with a Linear-&gt;SRGB conversion applied
to each of its chromatic components. Alpha is unchanged.

```csharp
public Colour4 ToSRGB()
```

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_Colour4_TryParseHex_System_String_osu_Framework_Graphics_Colour4__"></a> TryParseHex\(string, out Colour4\)

Attempts to convert an RGB or RGBA-formatted hex colour code into a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref>.
Supported colour code formats:
<ul><li>RGB</li><li>#RGB</li><li>RGBA</li><li>#RGBA</li><li>RRGGBB</li><li>#RRGGBB</li><li>RRGGBBAA</li><li>#RRGGBBAA</li></ul>

```csharp
public static bool TryParseHex(string hex, out Colour4 colour)
```

#### Parameters

`hex` [string](https://learn.microsoft.com/dotnet/api/system.string)

The hex code.

`colour` [Colour4](osu.Framework.Graphics.Colour4.md)

The <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> representing the colour, if parsing succeeded.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the input could be parsed as a hex code.

## Operators

### <a id="osu_Framework_Graphics_Colour4_op_Addition_osu_Framework_Graphics_Colour4_osu_Framework_Graphics_Colour4_"></a> operator \+\(Colour4, Colour4\)

Adds two colours in the linear colour space. The final value is clamped to the 0-1 range.

```csharp
public static Colour4 operator +(Colour4 first, Colour4 second)
```

#### Parameters

`first` [Colour4](osu.Framework.Graphics.Colour4.md)

The left hand side of the addition.

`second` [Colour4](osu.Framework.Graphics.Colour4.md)

The right hand side of the addition.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_op_Division_osu_Framework_Graphics_Colour4_System_Single_"></a> operator /\(Colour4, float\)

Linearly divides a colour by a scalar value. The final value is clamped to the 0-1 range.

```csharp
public static Colour4 operator /(Colour4 colour, float scalar)
```

#### Parameters

`colour` [Colour4](osu.Framework.Graphics.Colour4.md)

The original colour.

`scalar` [float](https://learn.microsoft.com/dotnet/api/system.single)

The scalar value to divide by. Must be positive.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

Thrown if <code class="paramref">scalar</code> is zero or negative.

### <a id="osu_Framework_Graphics_Colour4_op_Equality_osu_Framework_Graphics_Colour4_osu_Framework_Graphics_Colour4_"></a> operator ==\(Colour4, Colour4\)

Performs a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> equality check using the <xref href="System.IEquatable%601" data-throw-if-not-resolved="false"></xref> implementation.

```csharp
public static bool operator ==(Colour4 first, Colour4 second)
```

#### Parameters

`first` [Colour4](osu.Framework.Graphics.Colour4.md)

The left hand side of the equation.

`second` [Colour4](osu.Framework.Graphics.Colour4.md)

The right hand side of the equation.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Colour4_op_Implicit_osuTK_Graphics_Color4__osu_Framework_Graphics_Colour4"></a> implicit operator Colour4\(Color4\)

Converts an osuTK <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> to an osu!framework <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator Colour4(Color4 colour)
```

#### Parameters

`colour` Color4

The osuTK <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> to convert.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_op_Implicit_osu_Framework_Graphics_Colour4__osuTK_Graphics_Color4"></a> implicit operator Color4\(Colour4\)

Converts an osu!framework <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> to an osuTK <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref>.

```csharp
public static implicit operator Color4(Colour4 colour)
```

#### Parameters

`colour` [Colour4](osu.Framework.Graphics.Colour4.md)

The osu!framework <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> to convert.

#### Returns

 Color4

### <a id="osu_Framework_Graphics_Colour4_op_Inequality_osu_Framework_Graphics_Colour4_osu_Framework_Graphics_Colour4_"></a> operator \!=\(Colour4, Colour4\)

Performs a <xref href="osu.Framework.Graphics.Colour4" data-throw-if-not-resolved="false"></xref> inequality check using the <xref href="System.IEquatable%601" data-throw-if-not-resolved="false"></xref> implementation.

```csharp
public static bool operator !=(Colour4 first, Colour4 second)
```

#### Parameters

`first` [Colour4](osu.Framework.Graphics.Colour4.md)

The left hand side of the equation.

`second` [Colour4](osu.Framework.Graphics.Colour4.md)

The right hand side of the equation.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Colour4_op_Multiply_osu_Framework_Graphics_Colour4_osu_Framework_Graphics_Colour4_"></a> operator \*\(Colour4, Colour4\)

Multiplies two colours in the linear colour space.

```csharp
public static Colour4 operator *(Colour4 first, Colour4 second)
```

#### Parameters

`first` [Colour4](osu.Framework.Graphics.Colour4.md)

The left hand side of the multiplication.

`second` [Colour4](osu.Framework.Graphics.Colour4.md)

The right hand side of the multiplication.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Graphics_Colour4_op_Multiply_osu_Framework_Graphics_Colour4_System_Single_"></a> operator \*\(Colour4, float\)

Linearly multiplies a colour by a scalar value. The final value is clamped to the 0-1 range.

```csharp
public static Colour4 operator *(Colour4 colour, float scalar)
```

#### Parameters

`colour` [Colour4](osu.Framework.Graphics.Colour4.md)

The original colour.

`scalar` [float](https://learn.microsoft.com/dotnet/api/system.single)

The scalar value to multiply by. Must not be negative.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

Thrown if <code class="paramref">scalar</code> is negative.

### <a id="osu_Framework_Graphics_Colour4_op_Subtraction_osu_Framework_Graphics_Colour4_osu_Framework_Graphics_Colour4_"></a> operator \-\(Colour4, Colour4\)

Subtracts two colours in the linear colour space. The final value is clamped to the 0-1 range.

```csharp
public static Colour4 operator -(Colour4 first, Colour4 second)
```

#### Parameters

`first` [Colour4](osu.Framework.Graphics.Colour4.md)

The left hand side of the subtraction.

`second` [Colour4](osu.Framework.Graphics.Colour4.md)

The right hand side of the subtraction.

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

