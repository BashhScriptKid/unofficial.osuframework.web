# <a id="osu_Framework_Graphics_Primitives_Line"></a> Struct Line

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

Represents a single line segment.

```csharp
public readonly struct Line
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Line\>\(Line\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Line\>\(Line\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Line\>\(Line\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Line\>\(Line\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Line, TChild\>\(Line, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Line, TChild\>\(Line, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Line, TChild\>\(Line, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Line\>\(Line\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_Line__ctor_osuTK_Vector2_osuTK_Vector2_"></a> Line\(Vector2, Vector2\)

```csharp
public Line(Vector2 p1, Vector2 p2)
```

#### Parameters

`p1` Vector2

`p2` Vector2

## Fields

### <a id="osu_Framework_Graphics_Primitives_Line_EndPoint"></a> EndPoint

End point of the line.

```csharp
public readonly Vector2 EndPoint
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Line_StartPoint"></a> StartPoint

Begin point of the line.

```csharp
public readonly Vector2 StartPoint
```

#### Field Value

 Vector2

## Properties

### <a id="osu_Framework_Graphics_Primitives_Line_Direction"></a> Direction

The direction of this <xref href="osu.Framework.Graphics.Primitives.Line" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 Direction { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Line_DirectionNormalized"></a> DirectionNormalized

The normalized direction of this <xref href="osu.Framework.Graphics.Primitives.Line" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 DirectionNormalized { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Line_OrthogonalDirection"></a> OrthogonalDirection

```csharp
public Vector2 OrthogonalDirection { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Line_Rho"></a> Rho

The length of the line.

```csharp
public float Rho { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_Line_Theta"></a> Theta

The direction of the second point from the first.

```csharp
public float Theta { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Primitives_Line_At_System_Single_"></a> At\(float\)

Computes a position along this line.

```csharp
public Vector2 At(float t)
```

#### Parameters

`t` [float](https://learn.microsoft.com/dotnet/api/system.single)

A parameter representing the position along the line to compute. 0 yields the start point and 1 yields the end point.

#### Returns

 Vector2

The position along the line.

### <a id="osu_Framework_Graphics_Primitives_Line_ClosestPointTo_osuTK_Vector2_"></a> ClosestPointTo\(Vector2\)

Finds the point closest to the given point on this line.

```csharp
public Vector2 ClosestPointTo(Vector2 p)
```

#### Parameters

`p` Vector2

#### Returns

 Vector2

#### Remarks

See http://geometryalgorithms.com/Archive/algorithm_0102/algorithm_0102.htm, near the bottom.

### <a id="osu_Framework_Graphics_Primitives_Line_DistanceSquaredToPoint_osuTK_Vector2_"></a> DistanceSquaredToPoint\(Vector2\)

Distance squared from an arbitrary point p to this line.

```csharp
public float DistanceSquaredToPoint(Vector2 p)
```

#### Parameters

`p` Vector2

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_Line_DistanceToPoint_osuTK_Vector2_"></a> DistanceToPoint\(Vector2\)

Distance from an arbitrary point to this line.

```csharp
public float DistanceToPoint(Vector2 p)
```

#### Parameters

`p` Vector2

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_Line_EndWorldMatrix"></a> EndWorldMatrix\(\)

It's the end of the world as we know it

```csharp
public Matrix4 EndWorldMatrix()
```

#### Returns

 Matrix4

### <a id="osu_Framework_Graphics_Primitives_Line_IntersectWith_osu_Framework_Graphics_Primitives_Line__"></a> IntersectWith\(in Line\)

Intersects this line with another.

```csharp
public (bool success, float distance) IntersectWith(in Line other)
```

#### Parameters

`other` [Line](osu.Framework.Graphics.Primitives.Line.md)

The line to intersect with.

#### Returns

 \([bool](https://learn.microsoft.com/dotnet/api/system.boolean) [success](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.boolean,system.single\-.success), [float](https://learn.microsoft.com/dotnet/api/system.single) [distance](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.boolean,system.single\-.distance)\)

Whether the two lines intersect and, if so, the distance along this line at which the intersection occurs.
    An intersection may occur even if the two lines don't touch, at which point the parameter will be outside the [0, 1] range.
    To compute the point of intersection, <xref href="osu.Framework.Graphics.Primitives.Line.At(System.Single)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Primitives_Line_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_Primitives_Line_TryIntersectWith_osu_Framework_Graphics_Primitives_Line__System_Single__"></a> TryIntersectWith\(in Line, out float\)

Intersects this line with another.

```csharp
public bool TryIntersectWith(in Line other, out float distance)
```

#### Parameters

`other` [Line](osu.Framework.Graphics.Primitives.Line.md)

The line to intersect with.

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

The distance along this line at which the intersection occurs. To compute the point of intersection, <xref href="osu.Framework.Graphics.Primitives.Line.At(System.Single)" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the two lines intersect. An intersection may occur even if the two lines don't touch, at which point the parameter will be outside the [0, 1] range.

### <a id="osu_Framework_Graphics_Primitives_Line_TryIntersectWith_osuTK_Vector2__osuTK_Vector2__System_Single__"></a> TryIntersectWith\(ref Vector2, ref Vector2, out float\)

Intersects this line with another.

```csharp
public bool TryIntersectWith(ref Vector2 otherStart, ref Vector2 otherEnd, out float distance)
```

#### Parameters

`otherStart` Vector2

The start point of the other line to intersect with.

`otherEnd` Vector2

The end point of the other line to intersect with.

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

The distance along this line at which the intersection occurs. To compute the point of intersection, <xref href="osu.Framework.Graphics.Primitives.Line.At(System.Single)" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the two lines intersect. An intersection may occur even if the two lines don't touch, at which point the parameter will be outside the [0, 1] range.

### <a id="osu_Framework_Graphics_Primitives_Line_WorldMatrix"></a> WorldMatrix\(\)

```csharp
public Matrix4 WorldMatrix()
```

#### Returns

 Matrix4

