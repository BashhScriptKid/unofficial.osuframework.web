# <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions"></a> Class Color4Extensions

Namespace: [osu.Framework.Extensions.Color4Extensions](osu.Framework.Extensions.Color4Extensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class Color4Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Color4Extensions](osu.Framework.Extensions.Color4Extensions.Color4Extensions.md)

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

## Fields

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_GAMMA"></a> GAMMA

```csharp
public const double GAMMA = 2.4
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_Darken_osuTK_Graphics_Color4_System_Single_"></a> Darken\(Color4, float\)

Returns a darkened version of the colour.

```csharp
public static Color4 Darken(this Color4 colour, float amount)
```

#### Parameters

`colour` Color4

Original colour

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

Percentage light reduction

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_FromHSV_System_Single_System_Single_System_Single_"></a> FromHSV\(float, float, float\)

Converts an HSV colour to a <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref>.

```csharp
public static Color4 FromHSV(float h, float s, float v)
```

#### Parameters

`h` [float](https://learn.microsoft.com/dotnet/api/system.single)

The hue, between 0 and 360.

`s` [float](https://learn.microsoft.com/dotnet/api/system.single)

The saturation, between 0 and 1.

`v` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value, between 0 and 1.

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_FromHex_System_String_"></a> FromHex\(string\)

Converts an RGB or RGBA-formatted hex colour code into a <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref>.
Supported colour code formats:
<ul><li>RGB</li><li>#RGB</li><li>RGBA</li><li>#RGBA</li><li>RRGGBB</li><li>#RRGGBB</li><li>RRGGBBAA</li><li>#RRGGBBAA</li></ul>

```csharp
public static Color4 FromHex(string hex)
```

#### Parameters

`hex` [string](https://learn.microsoft.com/dotnet/api/system.string)

The hex code.

#### Returns

 Color4

The <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> representing the colour.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

If <code class="paramref">hex</code> is not a supported colour code.

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_Lighten_osuTK_Graphics_Color4_System_Single_"></a> Lighten\(Color4, float\)

Returns a lightened version of the colour.

```csharp
public static Color4 Lighten(this Color4 colour, float amount)
```

#### Parameters

`colour` Color4

Original colour

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

Decimal light addition

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_Multiply_osuTK_Graphics_Color4_osuTK_Graphics_Color4_"></a> Multiply\(Color4, Color4\)

```csharp
public static Color4 Multiply(Color4 first, Color4 second)
```

#### Parameters

`first` Color4

`second` Color4

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_Multiply_osuTK_Graphics_Color4_System_Single_"></a> Multiply\(Color4, float\)

Multiply the RGB coordinates by a scalar.

```csharp
public static Color4 Multiply(this Color4 colour, float scalar)
```

#### Parameters

`colour` Color4

Original colour

`scalar` [float](https://learn.microsoft.com/dotnet/api/system.single)

A scalar to multiply with

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_MultiplySRGB_osuTK_Graphics_Color4_osuTK_Graphics_Color4_"></a> MultiplySRGB\(Color4, Color4\)

```csharp
public static Color4 MultiplySRGB(Color4 first, Color4 second)
```

#### Parameters

`first` Color4

`second` Color4

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_Opacity_osuTK_Graphics_Color4_System_Single_"></a> Opacity\(Color4, float\)

```csharp
public static Color4 Opacity(this Color4 color, float a)
```

#### Parameters

`color` Color4

`a` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_Opacity_osuTK_Graphics_Color4_System_Byte_"></a> Opacity\(Color4, byte\)

```csharp
public static Color4 Opacity(this Color4 color, byte a)
```

#### Parameters

`color` Color4

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToHSV_osuTK_Graphics_Color4_"></a> ToHSV\(Color4\)

Converts a <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> to an HSV colour.

```csharp
public static (float h, float s, float v) ToHSV(this Color4 colour)
```

#### Parameters

`colour` Color4

The <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> to convert.

#### Returns

 \([float](https://learn.microsoft.com/dotnet/api/system.single) [h](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.single,system.single,system.single\-.h), [float](https://learn.microsoft.com/dotnet/api/system.single) [s](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.single,system.single,system.single\-.s), [float](https://learn.microsoft.com/dotnet/api/system.single) [v](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.single,system.single,system.single\-.v)\)

The HSV colour.

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToHex_osuTK_Graphics_Color4_System_Boolean_"></a> ToHex\(Color4, bool\)

Converts a <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> into a hex colour code.

```csharp
public static string ToHex(this Color4 colour, bool alwaysOutputAlpha = false)
```

#### Parameters

`colour` Color4

The <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> to convert.

`alwaysOutputAlpha` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the alpha channel should always be output. If <code>false</code>, the alpha channel is only output if <code class="paramref">colour</code> is translucent.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The hex code representing the colour.

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToLinear_System_Double_"></a> ToLinear\(double\)

```csharp
public static double ToLinear(double color)
```

#### Parameters

`color` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToLinear_System_Single_"></a> ToLinear\(float\)

```csharp
public static float ToLinear(float color)
```

#### Parameters

`color` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToLinear_osuTK_Graphics_Color4_"></a> ToLinear\(Color4\)

```csharp
public static Color4 ToLinear(this Color4 colour)
```

#### Parameters

`colour` Color4

#### Returns

 Color4

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToSRGB_System_Double_"></a> ToSRGB\(double\)

```csharp
public static double ToSRGB(double color)
```

#### Parameters

`color` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToSRGB_System_Single_"></a> ToSRGB\(float\)

```csharp
public static float ToSRGB(float color)
```

#### Parameters

`color` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Extensions_Color4Extensions_Color4Extensions_ToSRGB_osuTK_Graphics_Color4_"></a> ToSRGB\(Color4\)

```csharp
public static Color4 ToSRGB(this Color4 colour)
```

#### Parameters

`colour` Color4

#### Returns

 Color4

