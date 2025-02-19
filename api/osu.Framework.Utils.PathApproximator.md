# <a id="osu_Framework_Utils_PathApproximator"></a> Class PathApproximator

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

Helper methods to approximate a path by interpolating a sequence of control points.

```csharp
public static class PathApproximator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PathApproximator](osu.Framework.Utils.PathApproximator.md)

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

### <a id="osu_Framework_Utils_PathApproximator_BSplineToBezier_System_ReadOnlySpan_osuTK_Vector2__System_Int32_"></a> BSplineToBezier\(ReadOnlySpan<Vector2\>, int\)

Converts a B-spline with polynomial order <code class="paramref">degree</code> to a series of Bezier control points
via Boehm's algorithm.

```csharp
public static Vector2[] BSplineToBezier(ReadOnlySpan<Vector2> controlPoints, int degree)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The control points.

`degree` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The polynomial order.

#### Returns

 Vector2\[\]

An array of vectors containing control point positions for the resulting Bezier curve.

#### Remarks

Does nothing if <code class="paramref">controlPoints</code> has zero points or one point.
Algorithm unsuitable for large values of <code class="paramref">degree</code> with many knots.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">degree</code> was less than 1.

### <a id="osu_Framework_Utils_PathApproximator_BSplineToPiecewiseLinear_System_ReadOnlySpan_osuTK_Vector2__System_Int32_"></a> BSplineToPiecewiseLinear\(ReadOnlySpan<Vector2\>, int\)

Creates a piecewise-linear approximation of a clamped uniform B-spline with polynomial order <code class="paramref">degree</code>,
by dividing it into a series of bezier control points at its knots, then adaptively repeatedly
subdividing those until their approximation error vanishes below a given threshold.

```csharp
public static List<Vector2> BSplineToPiecewiseLinear(ReadOnlySpan<Vector2> controlPoints, int degree)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The control points.

`degree` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The polynomial order.

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A list of vectors representing the piecewise-linear approximation.

#### Remarks

Does nothing if <code class="paramref">controlPoints</code> has zero points or one point.
Generalises to bezier approximation functionality when <code class="paramref">degree</code> is too large to create knots.
Algorithm unsuitable for large values of <code class="paramref">degree</code> with many knots.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

<code class="paramref">degree</code> was less than 1.

### <a id="osu_Framework_Utils_PathApproximator_BezierToPiecewiseLinear_System_ReadOnlySpan_osuTK_Vector2__"></a> BezierToPiecewiseLinear\(ReadOnlySpan<Vector2\>\)

Creates a piecewise-linear approximation of a bezier curve, by adaptively repeatedly subdividing
the control points until their approximation error vanishes below a given threshold.

```csharp
public static List<Vector2> BezierToPiecewiseLinear(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The control points.

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A list of vectors representing the piecewise-linear approximation.

### <a id="osu_Framework_Utils_PathApproximator_CatmullToPiecewiseLinear_System_ReadOnlySpan_osuTK_Vector2__"></a> CatmullToPiecewiseLinear\(ReadOnlySpan<Vector2\>\)

Creates a piecewise-linear approximation of a Catmull-Rom spline.

```csharp
public static List<Vector2> CatmullToPiecewiseLinear(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A list of vectors representing the piecewise-linear approximation.

### <a id="osu_Framework_Utils_PathApproximator_CircularArcBoundingBox_System_ReadOnlySpan_osuTK_Vector2__"></a> CircularArcBoundingBox\(ReadOnlySpan<Vector2\>\)

Computes the bounding box of a circular arc.

```csharp
public static RectangleF CircularArcBoundingBox(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

Three distinct points on the arc.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The rectangle inscribing the circular arc.

### <a id="osu_Framework_Utils_PathApproximator_CircularArcToPiecewiseLinear_System_ReadOnlySpan_osuTK_Vector2__"></a> CircularArcToPiecewiseLinear\(ReadOnlySpan<Vector2\>\)

Creates a piecewise-linear approximation of a circular arc curve.

```csharp
public static List<Vector2> CircularArcToPiecewiseLinear(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A list of vectors representing the piecewise-linear approximation.

### <a id="osu_Framework_Utils_PathApproximator_LagrangePolynomialToPiecewiseLinear_System_ReadOnlySpan_osuTK_Vector2__"></a> LagrangePolynomialToPiecewiseLinear\(ReadOnlySpan<Vector2\>\)

Creates a piecewise-linear approximation of a lagrange polynomial.

```csharp
public static List<Vector2> LagrangePolynomialToPiecewiseLinear(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A list of vectors representing the piecewise-linear approximation.

### <a id="osu_Framework_Utils_PathApproximator_LinearToPiecewiseLinear_System_ReadOnlySpan_osuTK_Vector2__"></a> LinearToPiecewiseLinear\(ReadOnlySpan<Vector2\>\)

Creates a piecewise-linear approximation of a linear curve.
Basically, returns the input.

```csharp
public static List<Vector2> LinearToPiecewiseLinear(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A list of vectors representing the piecewise-linear approximation.

### <a id="osu_Framework_Utils_PathApproximator_PiecewiseLinearToBSpline_System_ReadOnlySpan_osuTK_Vector2__System_Int32_System_Int32_System_Int32_System_Int32_System_Single_System_Single_System_Single_System_Collections_Generic_List_osuTK_Vector2__System_Single_0__0___"></a> PiecewiseLinearToBSpline\(ReadOnlySpan<Vector2\>, int, int, int, int, float, float, float, List<Vector2\>?, float\[,\]?\)

Creates a B-spline approximation from a piecewise-linear path.

```csharp
public static List<Vector2> PiecewiseLinearToBSpline(ReadOnlySpan<Vector2> inputPath, int numControlPoints, int degree, int numTestPoints = 100, int maxIterations = 100, float learningRate = 8, float b1 = 0.8, float b2 = 0.99, List<Vector2>? initialControlPoints = null, float[,]? learnableMask = null)
```

#### Parameters

`inputPath` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The piecewise-linear path to approximate.

`numControlPoints` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of control points to use in the B-spline approximation.

`degree` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The polynomial order.

`numTestPoints` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of points to evaluate the B-spline path at for optimization, basically a resolution.

`maxIterations` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of optimization steps.

`learningRate` [float](https://learn.microsoft.com/dotnet/api/system.single)

The rate of optimization. Larger values converge faster but can be unstable.

`b1` [float](https://learn.microsoft.com/dotnet/api/system.single)

The B1 parameter for the Adam optimizer. Between 0 and 1.

`b2` [float](https://learn.microsoft.com/dotnet/api/system.single)

The B2 parameter for the Adam optimizer. Between 0 and 1.

`initialControlPoints` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>?

The initial B-spline control points to use before optimization. The length of this list should be equal to <code class="paramref">numControlPoints</code>.

`learnableMask` [float](https://learn.microsoft.com/dotnet/api/system.single)\[,\]?

Mask determining which control point positions are fixed and cannot be changed by the optimiser.

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A List of vectors representing the B-spline control points.

### <a id="osu_Framework_Utils_PathApproximator_PiecewiseLinearToBezier_System_ReadOnlySpan_osuTK_Vector2__System_Int32_System_Int32_System_Int32_System_Single_System_Single_System_Single_System_Collections_Generic_List_osuTK_Vector2__System_Single_0__0___"></a> PiecewiseLinearToBezier\(ReadOnlySpan<Vector2\>, int, int, int, float, float, float, List<Vector2\>?, float\[,\]?\)

Creates a bezier curve approximation from a piecewise-linear path.

```csharp
public static List<Vector2> PiecewiseLinearToBezier(ReadOnlySpan<Vector2> inputPath, int numControlPoints, int numTestPoints = 100, int maxIterations = 100, float learningRate = 8, float b1 = 0.8, float b2 = 0.99, List<Vector2>? initialControlPoints = null, float[,]? learnableMask = null)
```

#### Parameters

`inputPath` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The piecewise-linear path to approximate.

`numControlPoints` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of control points to use in the bezier approximation.

`numTestPoints` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of points to evaluate the bezier path at for optimization, basically a resolution.

`maxIterations` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of optimization steps.

`learningRate` [float](https://learn.microsoft.com/dotnet/api/system.single)

The rate of optimization. Larger values converge faster but can be unstable.

`b1` [float](https://learn.microsoft.com/dotnet/api/system.single)

The B1 parameter for the Adam optimizer. Between 0 and 1.

`b2` [float](https://learn.microsoft.com/dotnet/api/system.single)

The B2 parameter for the Adam optimizer. Between 0 and 1.

`initialControlPoints` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>?

The initial bezier control points to use before optimization. The length of this list should be equal to <code class="paramref">numControlPoints</code>.

`learnableMask` [float](https://learn.microsoft.com/dotnet/api/system.single)\[,\]?

Mask determining which control point positions are fixed and cannot be changed by the optimiser.

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>

A List of vectors representing the bezier control points.

