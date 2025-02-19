# <a id="osu_Framework_Utils_Precision"></a> Class Precision

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

Utility class to compare <xref href="System.Single" data-throw-if-not-resolved="false"></xref> or <xref href="System.Double" data-throw-if-not-resolved="false"></xref> values for equality.

```csharp
public static class Precision
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Precision](osu.Framework.Utils.Precision.md)

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

### <a id="osu_Framework_Utils_Precision_DOUBLE_EPSILON"></a> DOUBLE\_EPSILON

The default epsilon for all <xref href="System.Double" data-throw-if-not-resolved="false"></xref> values.

```csharp
public const double DOUBLE_EPSILON = 1E-07
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_Precision_FLOAT_EPSILON"></a> FLOAT\_EPSILON

The default epsilon for all <xref href="System.Single" data-throw-if-not-resolved="false"></xref> values.

```csharp
public const float FLOAT_EPSILON = 0.001
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Utils_Precision_AlmostBigger_System_Single_System_Single_System_Single_"></a> AlmostBigger\(float, float, float\)

Computes whether a value is almost greater than another given an acceptable difference.

```csharp
public static bool AlmostBigger(float value1, float value2, float acceptableDifference = 0.001)
```

#### Parameters

`value1` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value to compare.

`value2` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value to compare against.

`acceptableDifference` [float](https://learn.microsoft.com/dotnet/api/system.single)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.FLOAT_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> is almost greater than <code class="paramref">value2</code>.

### <a id="osu_Framework_Utils_Precision_AlmostBigger_System_Double_System_Double_System_Double_"></a> AlmostBigger\(double, double, double\)

Computes whether a value is almost greater than another given an acceptable difference.

```csharp
public static bool AlmostBigger(double value1, double value2, double acceptableDifference = 1E-07)
```

#### Parameters

`value1` [double](https://learn.microsoft.com/dotnet/api/system.double)

The value to compare.

`value2` [double](https://learn.microsoft.com/dotnet/api/system.double)

The value to compare against.

`acceptableDifference` [double](https://learn.microsoft.com/dotnet/api/system.double)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.DOUBLE_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> is almost greater than <code class="paramref">value2</code>.

### <a id="osu_Framework_Utils_Precision_AlmostEquals_System_Single_System_Single_System_Single_"></a> AlmostEquals\(float, float, float\)

Computes whether two values are equal within an acceptable difference.

```csharp
public static bool AlmostEquals(float value1, float value2, float acceptableDifference = 0.001)
```

#### Parameters

`value1` [float](https://learn.microsoft.com/dotnet/api/system.single)

The first value.

`value2` [float](https://learn.microsoft.com/dotnet/api/system.single)

The second value.

`acceptableDifference` [float](https://learn.microsoft.com/dotnet/api/system.single)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.FLOAT_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> and <code class="paramref">value2</code> are almost equal.

### <a id="osu_Framework_Utils_Precision_AlmostEquals_osuTK_Vector2_osuTK_Vector2_System_Single_"></a> AlmostEquals\(Vector2, Vector2, float\)

Computes whether two <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref>s are equal within an acceptable difference.

```csharp
public static bool AlmostEquals(Vector2 value1, Vector2 value2, float acceptableDifference = 0.001)
```

#### Parameters

`value1` Vector2

The first <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref>.

`value2` Vector2

The second <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref>.

`acceptableDifference` [float](https://learn.microsoft.com/dotnet/api/system.single)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.FLOAT_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> and <code class="paramref">value2</code> are almost equal.

### <a id="osu_Framework_Utils_Precision_AlmostEquals_System_Double_System_Double_System_Double_"></a> AlmostEquals\(double, double, double\)

Computes whether two values are equal within an acceptable difference.

```csharp
public static bool AlmostEquals(double value1, double value2, double acceptableDifference = 1E-07)
```

#### Parameters

`value1` [double](https://learn.microsoft.com/dotnet/api/system.double)

The first value.

`value2` [double](https://learn.microsoft.com/dotnet/api/system.double)

The second value.

`acceptableDifference` [double](https://learn.microsoft.com/dotnet/api/system.double)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.DOUBLE_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> and <code class="paramref">value2</code> are almost equal.

### <a id="osu_Framework_Utils_Precision_AlmostIntersects_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Primitives_RectangleF_System_Single_"></a> AlmostIntersects\(RectangleF, RectangleF, float\)

Computes whether two <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>s intersect within an acceptable difference.

```csharp
public static bool AlmostIntersects(RectangleF rect1, RectangleF rect2, float acceptableDifference = 0.001)
```

#### Parameters

`rect1` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The first <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

`rect2` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The second <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

`acceptableDifference` [float](https://learn.microsoft.com/dotnet/api/system.single)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.FLOAT_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">rect1</code> and <code class="paramref">rect2</code> intersect.

### <a id="osu_Framework_Utils_Precision_DefinitelyBigger_System_Single_System_Single_System_Single_"></a> DefinitelyBigger\(float, float, float\)

Computes whether a value is definitely greater than another given an acceptable difference.

```csharp
public static bool DefinitelyBigger(float value1, float value2, float acceptableDifference = 0.001)
```

#### Parameters

`value1` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value to compare.

`value2` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value to compare against.

`acceptableDifference` [float](https://learn.microsoft.com/dotnet/api/system.single)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.FLOAT_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> is definitely greater than <code class="paramref">value2</code>.

### <a id="osu_Framework_Utils_Precision_DefinitelyBigger_System_Double_System_Double_System_Double_"></a> DefinitelyBigger\(double, double, double\)

Computes whether a value is definitely greater than another given an acceptable difference.

```csharp
public static bool DefinitelyBigger(double value1, double value2, double acceptableDifference = 1E-07)
```

#### Parameters

`value1` [double](https://learn.microsoft.com/dotnet/api/system.double)

The value to compare.

`value2` [double](https://learn.microsoft.com/dotnet/api/system.double)

The value to compare against.

`acceptableDifference` [double](https://learn.microsoft.com/dotnet/api/system.double)

The acceptable difference. Defaults to <xref href="osu.Framework.Utils.Precision.DOUBLE_EPSILON" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">value1</code> is definitely greater than <code class="paramref">value2</code>.

