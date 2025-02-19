# <a id="osu_Framework_Graphics_Vector2Extensions"></a> Class Vector2Extensions

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public static class Vector2Extensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Vector2Extensions](osu.Framework.Graphics.Vector2Extensions.md)

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

### <a id="osu_Framework_Graphics_Vector2Extensions_Distance_osuTK_Vector2_osuTK_Vector2_"></a> Distance\(Vector2, Vector2\)

Compute the euclidean distance between two vectors.

```csharp
public static float Distance(Vector2 vec1, Vector2 vec2)
```

#### Parameters

`vec1` Vector2

The first vector

`vec2` Vector2

The second vector

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

The distance

### <a id="osu_Framework_Graphics_Vector2Extensions_Distance_osuTK_Vector2__osuTK_Vector2__System_Single__"></a> Distance\(ref Vector2, ref Vector2, out float\)

Compute the euclidean distance between two vectors.

```csharp
public static void Distance(ref Vector2 vec1, ref Vector2 vec2, out float result)
```

#### Parameters

`vec1` Vector2

The first vector

`vec2` Vector2

The second vector

`result` [float](https://learn.microsoft.com/dotnet/api/system.single)

The distance

### <a id="osu_Framework_Graphics_Vector2Extensions_DistanceSquared_osuTK_Vector2_osuTK_Vector2_"></a> DistanceSquared\(Vector2, Vector2\)

Compute the squared euclidean distance between two vectors.

```csharp
public static float DistanceSquared(Vector2 vec1, Vector2 vec2)
```

#### Parameters

`vec1` Vector2

The first vector

`vec2` Vector2

The second vector

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

The squared distance

### <a id="osu_Framework_Graphics_Vector2Extensions_DistanceSquared_osuTK_Vector2__osuTK_Vector2__System_Single__"></a> DistanceSquared\(ref Vector2, ref Vector2, out float\)

Compute the squared euclidean distance between two vectors.

```csharp
public static void DistanceSquared(ref Vector2 vec1, ref Vector2 vec2, out float result)
```

#### Parameters

`vec1` Vector2

The first vector

`vec2` Vector2

The second vector

`result` [float](https://learn.microsoft.com/dotnet/api/system.single)

The squared distance

### <a id="osu_Framework_Graphics_Vector2Extensions_GetOrientation_System_ReadOnlySpan_osuTK_Vector2___"></a> GetOrientation\(in ReadOnlySpan<Vector2\>\)

Retrieves the orientation of a set of vertices using the Shoelace formula (https://en.wikipedia.org/wiki/Shoelace_formula)

```csharp
public static float GetOrientation(in ReadOnlySpan<Vector2> vertices)
```

#### Parameters

`vertices` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The vertices.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

Twice the area enclosed by the vertices.
    The vertices are clockwise-oriented if the value is positive.
    The vertices are counter-clockwise-oriented if the value is negative.

### <a id="osu_Framework_Graphics_Vector2Extensions_InRightHalfPlaneOf_osuTK_Vector2_osu_Framework_Graphics_Primitives_Line__"></a> InRightHalfPlaneOf\(Vector2, in Line\)

Determines whether a point is within the right half-plane of a line in the traditional cartesian coordinate system.

```csharp
public static bool InRightHalfPlaneOf(this Vector2 point, in Line line)
```

#### Parameters

`point` Vector2

The point.

`line` [Line](osu.Framework.Graphics.Primitives.Line.md)

The line.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">point</code> is in the right half-plane of <code class="paramref">line</code>. Collinear points are never in the right half-plane of the line.

### <a id="osu_Framework_Graphics_Vector2Extensions_Transform_osuTK_Vector2_osuTK_Matrix3_"></a> Transform\(Vector2, Matrix3\)

Transform a Position by the given Matrix

```csharp
public static Vector2 Transform(Vector2 pos, Matrix3 mat)
```

#### Parameters

`pos` Vector2

The position to transform

`mat` Matrix3

The desired transformation

#### Returns

 Vector2

The transformed position

### <a id="osu_Framework_Graphics_Vector2Extensions_Transform_osuTK_Vector2__osuTK_Matrix3__osuTK_Vector2__"></a> Transform\(ref Vector2, ref Matrix3, out Vector2\)

Transform a Position by the given Matrix

```csharp
public static void Transform(ref Vector2 pos, ref Matrix3 mat, out Vector2 result)
```

#### Parameters

`pos` Vector2

The position to transform

`mat` Matrix3

The desired transformation

`result` Vector2

The transformed vector

