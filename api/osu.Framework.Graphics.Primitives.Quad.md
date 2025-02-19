# <a id="osu_Framework_Graphics_Primitives_Quad"></a> Struct Quad

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly struct Quad : IConvexPolygon, IPolygon, IEquatable<Quad>
```

#### Implements

[IConvexPolygon](osu.Framework.Graphics.Primitives.IConvexPolygon.md), 
[IPolygon](osu.Framework.Graphics.Primitives.IPolygon.md), 
[IEquatable<Quad\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Quad\>\(Quad\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[PolygonExtensions.GetAxes<Quad\>\(Quad, Span<Vector2\>, bool\)](osu.Framework.Extensions.PolygonExtensions.PolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_PolygonExtensions\_GetAxes\_\_1\_\_\_0\_System\_Span\_osuTK\_Vector2\_\_System\_Boolean\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Quad\>\(Quad\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ConvexPolygonExtensions.Intersects<Quad, TPolygon2\>\(Quad, TPolygon2\)](osu.Framework.Extensions.PolygonExtensions.ConvexPolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_ConvexPolygonExtensions\_Intersects\_\_2\_\_\_0\_\_\_1\_), 
[ObjectExtensions.IsNotNull<Quad\>\(Quad\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Quad\>\(Quad\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Quad, TChild\>\(Quad, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Quad, TChild\>\(Quad, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Quad, TChild\>\(Quad, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Quad\>\(Quad\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_Quad__ctor_osuTK_Vector2_osuTK_Vector2_osuTK_Vector2_osuTK_Vector2_"></a> Quad\(Vector2, Vector2, Vector2, Vector2\)

```csharp
public Quad(Vector2 topLeft, Vector2 topRight, Vector2 bottomLeft, Vector2 bottomRight)
```

#### Parameters

`topLeft` Vector2

`topRight` Vector2

`bottomLeft` Vector2

`bottomRight` Vector2

### <a id="osu_Framework_Graphics_Primitives_Quad__ctor_System_Single_System_Single_System_Single_System_Single_"></a> Quad\(float, float, float, float\)

```csharp
public Quad(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="osu_Framework_Graphics_Primitives_Quad_BottomLeft"></a> BottomLeft

```csharp
public readonly Vector2 BottomLeft
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Quad_BottomRight"></a> BottomRight

```csharp
public readonly Vector2 BottomRight
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Quad_TopLeft"></a> TopLeft

```csharp
public readonly Vector2 TopLeft
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Quad_TopRight"></a> TopRight

```csharp
public readonly Vector2 TopRight
```

#### Field Value

 Vector2

## Properties

### <a id="osu_Framework_Graphics_Primitives_Quad_AABB"></a> AABB

```csharp
public RectangleI AABB { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_Quad_AABBFloat"></a> AABBFloat

```csharp
public RectangleF AABBFloat { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_Quad_Area"></a> Area

Computes the area of this <xref href="osu.Framework.Graphics.Primitives.Quad" data-throw-if-not-resolved="false"></xref>.

```csharp
public float Area { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Remarks

If the quad is self-intersecting the area is interpreted as the sum of all positive and negative areas and not the "visible area" enclosed by the <xref href="osu.Framework.Graphics.Primitives.Quad" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Primitives_Quad_BasisTransform"></a> BasisTransform

```csharp
public Matrix2 BasisTransform { get; }
```

#### Property Value

 Matrix2

### <a id="osu_Framework_Graphics_Primitives_Quad_Centre"></a> Centre

```csharp
public Vector2 Centre { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Quad_Height"></a> Height

```csharp
public float Height { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_Quad_Size"></a> Size

```csharp
public Vector2 Size { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Quad_Width"></a> Width

```csharp
public float Width { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Primitives_Quad_AlmostEquals_osu_Framework_Graphics_Primitives_Quad_"></a> AlmostEquals\(Quad\)

```csharp
public bool AlmostEquals(Quad other)
```

#### Parameters

`other` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_Quad_Contains_osuTK_Vector2_"></a> Contains\(Vector2\)

Checks whether <code class="paramref">pos</code> is inside of this quad.

```csharp
public bool Contains(Vector2 pos)
```

#### Parameters

`pos` Vector2

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

<p>
This method assumes a convex quad. The convexity of the quad is not checked.
Vertices of the quad as returned by <xref href="osu.Framework.Graphics.Primitives.Quad.GetVertices" data-throw-if-not-resolved="false"></xref> must be arranged either in clockwise or counter-clockwise order.
</p>
<p>
The method works by checking whether the point lies on the same side of all four sides of the quad.
Note that the quad vertices are *not* using the standard Cartesian coordinates, but rather a Y-inverted version of them
(as in higher Y is *down*),
which is why the sign of the perpendicular dot product is opposite to what would be normally expected on the Cartesian plane.
</p>

### <a id="osu_Framework_Graphics_Primitives_Quad_Equals_osu_Framework_Graphics_Primitives_Quad_"></a> Equals\(Quad\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Quad other)
```

#### Parameters

`other` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Primitives_Quad_FromRectangle_osu_Framework_Graphics_Primitives_RectangleF_"></a> FromRectangle\(RectangleF\)

```csharp
public static Quad FromRectangle(RectangleF rectangle)
```

#### Parameters

`rectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Primitives_Quad_GetAxisVertices"></a> GetAxisVertices\(\)

The vertices that define the axes spanned by this polygon in screen-space counter-clockwise orientation.

```csharp
public ReadOnlySpan<Vector2> GetAxisVertices()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The vertices that define the axes spanned by this polygon.

#### Remarks

Counter-clockwise orientation in screen-space coordinates is equivalent to a clockwise orientation in standard coordinates.
<p>
E.g. For the set of vertices { (0, 0), (1, 0), (0, 1), (1, 1) }, a counter-clockwise orientation is { (0, 0), (0, 1), (1, 1), (1, 0) }.
</p>

### <a id="osu_Framework_Graphics_Primitives_Quad_GetVertices"></a> GetVertices\(\)

Retrieves the vertices of this polygon in screen-space counter-clockwise orientation.

```csharp
public ReadOnlySpan<Vector2> GetVertices()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The vertices of this polygon.

#### Remarks

Counter-clockwise orientation in screen-space coordinates is equivalent to a clockwise orientation in standard coordinates.
<p>
E.g. For the set of vertices { (0, 0), (1, 0), (0, 1), (1, 1) }, a counter-clockwise orientation is { (0, 0), (0, 1), (1, 1), (1, 0) }.
</p>

### <a id="osu_Framework_Graphics_Primitives_Quad_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="osu_Framework_Graphics_Primitives_Quad_op_Implicit_osu_Framework_Graphics_Primitives_RectangleI__osu_Framework_Graphics_Primitives_Quad"></a> implicit operator Quad\(RectangleI\)

```csharp
public static implicit operator Quad(RectangleI r)
```

#### Parameters

`r` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Primitives_Quad_op_Implicit_osu_Framework_Graphics_Primitives_RectangleF__osu_Framework_Graphics_Primitives_Quad"></a> implicit operator Quad\(RectangleF\)

```csharp
public static implicit operator Quad(RectangleF r)
```

#### Parameters

`r` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Primitives_Quad_op_Multiply_osu_Framework_Graphics_Primitives_Quad_osuTK_Matrix3_"></a> operator \*\(Quad, Matrix3\)

```csharp
public static Quad operator *(Quad r, Matrix3 m)
```

#### Parameters

`r` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

`m` Matrix3

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

