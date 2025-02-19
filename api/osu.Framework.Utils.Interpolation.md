# <a id="osu_Framework_Utils_Interpolation"></a> Class Interpolation

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

```csharp
public static class Interpolation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Interpolation](osu.Framework.Utils.Interpolation.md)

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

### <a id="osu_Framework_Utils_Interpolation_ApplyEasing_osu_Framework_Graphics_Easing_System_Double_"></a> ApplyEasing\(Easing, double\)

```csharp
public static double ApplyEasing(Easing easing, double time)
```

#### Parameters

`easing` [Easing](osu.Framework.Graphics.Easing.md)

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_ApplyEasing__1___0__System_Double_"></a> ApplyEasing<TEasing\>\(in TEasing, double\)

```csharp
public static double ApplyEasing<TEasing>(in TEasing easing, double time) where TEasing : IEasingFunction
```

#### Parameters

`easing` TEasing

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Type Parameters

`TEasing` 

### <a id="osu_Framework_Utils_Interpolation_BarycentricLagrange_System_ReadOnlySpan_osuTK_Vector2__System_Double___System_Double_"></a> BarycentricLagrange\(ReadOnlySpan<Vector2\>, double\[\], double\)

Calculates the Lagrange basis polynomial for a given set of x coordinates based on previously computed barycentric weights.

```csharp
public static double BarycentricLagrange(ReadOnlySpan<Vector2> points, double[] weights, double time)
```

#### Parameters

`points` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

An array of coordinates. No two x should be the same.

`weights` [double](https://learn.microsoft.com/dotnet/api/system.double)\[\]

An array of precomputed barycentric weights.

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The x coordinate to calculate the basis polynomial for.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_BarycentricWeights_System_ReadOnlySpan_osuTK_Vector2__"></a> BarycentricWeights\(ReadOnlySpan<Vector2\>\)

Calculates the Barycentric weights for a Lagrange polynomial for a given set of coordinates. Can be used as a helper function to compute a Lagrange polynomial repeatedly.

```csharp
public static double[] BarycentricWeights(ReadOnlySpan<Vector2> points)
```

#### Parameters

`points` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

An array of coordinates. No two x should be the same.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)\[\]

### <a id="osu_Framework_Utils_Interpolation_Damp_System_Double_System_Double_System_Double_System_Double_"></a> Damp\(double, double, double, double\)

Interpolates between 2 values (start and final) using a given base and exponent.

```csharp
public static double Damp(double start, double final, double @base, double exponent)
```

#### Parameters

`start` [double](https://learn.microsoft.com/dotnet/api/system.double)

The start value.

`final` [double](https://learn.microsoft.com/dotnet/api/system.double)

The end value.

`base` [double](https://learn.microsoft.com/dotnet/api/system.double)

The base of the exponential. The valid range is [0, 1], where smaller values mean that the final value is achieved more quickly, and values closer to 1 results in slow convergence to the final value.

`exponent` [double](https://learn.microsoft.com/dotnet/api/system.double)

The exponent of the exponential. An exponent of 0 results in the start values, whereas larger exponents make the result converge to the final value.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_DampContinuously_System_Double_System_Double_System_Double_System_Double_"></a> DampContinuously\(double, double, double, double\)

Interpolate the current value towards the target value based on the elapsed time.
If the current value is updated every frame using this function, the result is approximately frame-rate independent.

```csharp
public static double DampContinuously(double current, double target, double halfTime, double elapsedTime)
```

#### Parameters

`current` [double](https://learn.microsoft.com/dotnet/api/system.double)

The current value.

`target` [double](https://learn.microsoft.com/dotnet/api/system.double)

The target value.

`halfTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time it takes to reach the middle value of the current and the target value.

`elapsedTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The elapsed time of the current frame.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Because floating-point errors can accumulate over a long time, this function shouldn't be
used for things requiring accurate values.

### <a id="osu_Framework_Utils_Interpolation_Lagrange_System_ReadOnlySpan_osuTK_Vector2__System_Double_"></a> Lagrange\(ReadOnlySpan<Vector2\>, double\)

Interpolates between a set of points using a lagrange polynomial.

```csharp
public static double Lagrange(ReadOnlySpan<Vector2> points, double time)
```

#### Parameters

`points` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

An array of coordinates. No two x should be the same.

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The x coordinate to calculate the y coordinate for.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_LagrangeBasis_System_ReadOnlySpan_osuTK_Vector2__System_Int32_System_Double_"></a> LagrangeBasis\(ReadOnlySpan<Vector2\>, int, double\)

Calculates the Lagrange basis polynomial for a given set of x coordinates. Used as a helper function to compute Lagrange polynomials.

```csharp
public static double LagrangeBasis(ReadOnlySpan<Vector2> points, int @base, double time)
```

#### Parameters

`points` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

An array of coordinates. No two x should be the same.

`base` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index inside the coordinate array which polynomial to compute.

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The x coordinate to calculate the basis polynomial for.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_Lerp_System_Double_System_Double_System_Double_"></a> Lerp\(double, double, double\)

```csharp
public static double Lerp(double start, double final, double amount)
```

#### Parameters

`start` [double](https://learn.microsoft.com/dotnet/api/system.double)

`final` [double](https://learn.microsoft.com/dotnet/api/system.double)

`amount` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osu_Framework_Graphics_Colour_ColourInfo_osu_Framework_Graphics_Colour_ColourInfo_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, ColourInfo, ColourInfo, double, double, Easing\)

```csharp
public static ColourInfo ValueAt(double time, ColourInfo startColour, ColourInfo endColour, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`endColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osu_Framework_Graphics_Effects_EdgeEffectParameters_osu_Framework_Graphics_Effects_EdgeEffectParameters_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, EdgeEffectParameters, EdgeEffectParameters, double, double, Easing\)

```csharp
public static EdgeEffectParameters ValueAt(double time, EdgeEffectParameters startParams, EdgeEffectParameters endParams, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startParams` [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

`endParams` [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osu_Framework_Graphics_Colour_SRGBColour_osu_Framework_Graphics_Colour_SRGBColour_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, SRGBColour, SRGBColour, double, double, Easing\)

```csharp
public static SRGBColour ValueAt(double time, SRGBColour startColour, SRGBColour endColour, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startColour` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

`endColour` [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osuTK_Graphics_Color4_osuTK_Graphics_Color4_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, Color4, Color4, double, double, Easing\)

```csharp
public static Color4 ValueAt(double time, Color4 startColour, Color4 endColour, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startColour` Color4

`endColour` Color4

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 Color4

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osu_Framework_Graphics_Colour4_osu_Framework_Graphics_Colour4_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, Colour4, Colour4, double, double, Easing\)

```csharp
public static Colour4 ValueAt(double time, Colour4 startColour, Colour4 endColour, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startColour` [Colour4](osu.Framework.Graphics.Colour4.md)

`endColour` [Colour4](osu.Framework.Graphics.Colour4.md)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [Colour4](osu.Framework.Graphics.Colour4.md)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Byte_System_Byte_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, byte, byte, double, double, Easing\)

```csharp
public static byte ValueAt(double time, byte val1, byte val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`val2` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_SByte_System_SByte_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, sbyte, sbyte, double, double, Easing\)

```csharp
public static sbyte ValueAt(double time, sbyte val1, sbyte val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)

`val2` [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [sbyte](https://learn.microsoft.com/dotnet/api/system.sbyte)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Int16_System_Int16_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, short, short, double, double, Easing\)

```csharp
public static short ValueAt(double time, short val1, short val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [short](https://learn.microsoft.com/dotnet/api/system.int16)

`val2` [short](https://learn.microsoft.com/dotnet/api/system.int16)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [short](https://learn.microsoft.com/dotnet/api/system.int16)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_UInt16_System_UInt16_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, ushort, ushort, double, double, Easing\)

```csharp
public static ushort ValueAt(double time, ushort val1, ushort val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

`val2` [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Int32_System_Int32_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, int, int, double, double, Easing\)

```csharp
public static int ValueAt(double time, int val1, int val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`val2` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_UInt32_System_UInt32_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, uint, uint, double, double, Easing\)

```csharp
public static uint ValueAt(double time, uint val1, uint val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`val2` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Int64_System_Int64_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, long, long, double, double, Easing\)

```csharp
public static long ValueAt(double time, long val1, long val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`val2` [long](https://learn.microsoft.com/dotnet/api/system.int64)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_UInt64_System_UInt64_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, ulong, ulong, double, double, Easing\)

```csharp
public static ulong ValueAt(double time, ulong val1, ulong val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`val2` [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Single_System_Single_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, float, float, double, double, Easing\)

```csharp
public static float ValueAt(double time, float val1, float val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [float](https://learn.microsoft.com/dotnet/api/system.single)

`val2` [float](https://learn.microsoft.com/dotnet/api/system.single)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Decimal_System_Decimal_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, decimal, decimal, double, double, Easing\)

```csharp
public static decimal ValueAt(double time, decimal val1, decimal val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`val2` [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [decimal](https://learn.microsoft.com/dotnet/api/system.decimal)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_System_Double_System_Double_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, double, double, double, double, Easing\)

```csharp
public static double ValueAt(double time, double val1, double val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val2` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osuTK_Vector2_osuTK_Vector2_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, Vector2, Vector2, double, double, Easing\)

```csharp
public static Vector2 ValueAt(double time, Vector2 val1, Vector2 val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` Vector2

`val2` Vector2

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 Vector2

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osuTK_Vector3_osuTK_Vector3_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, Vector3, Vector3, double, double, Easing\)

```csharp
public static Vector3 ValueAt(double time, Vector3 val1, Vector3 val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` Vector3

`val2` Vector3

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 Vector3

### <a id="osu_Framework_Utils_Interpolation_ValueAt_System_Double_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Primitives_RectangleF_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt\(double, RectangleF, RectangleF, double, double, Easing\)

```csharp
public static RectangleF ValueAt(double time, RectangleF val1, RectangleF val2, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`val1` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

`val2` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Utils_Interpolation_ValueAt__1_System_Double___0___0_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> ValueAt<TValue\>\(double, TValue, TValue, double, double, Easing\)

```csharp
public static TValue ValueAt<TValue>(double time, TValue startValue, TValue endValue, double startTime, double endTime, Easing easing = Easing.None)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startValue` TValue

`endValue` TValue

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 TValue

#### Type Parameters

`TValue` 

### <a id="osu_Framework_Utils_Interpolation_ValueAt__2_System_Double___0___0_System_Double_System_Double___1__"></a> ValueAt<TValue, TEasing\>\(double, TValue, TValue, double, double, in TEasing\)

```csharp
public static TValue ValueAt<TValue, TEasing>(double time, TValue startValue, TValue endValue, double startTime, double endTime, in TEasing easing) where TEasing : IEasingFunction
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startValue` TValue

`endValue` TValue

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 TValue

#### Type Parameters

`TValue` 

`TEasing` 

