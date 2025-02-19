# <a id="osu_Framework_Graphics_Primitives_Triangle"></a> Struct Triangle

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly struct Triangle : IConvexPolygon, IPolygon, IEquatable<Triangle>
```

#### Implements

[IConvexPolygon](osu.Framework.Graphics.Primitives.IConvexPolygon.md), 
[IPolygon](osu.Framework.Graphics.Primitives.IPolygon.md), 
[IEquatable<Triangle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Triangle\>\(Triangle\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[PolygonExtensions.GetAxes<Triangle\>\(Triangle, Span<Vector2\>, bool\)](osu.Framework.Extensions.PolygonExtensions.PolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_PolygonExtensions\_GetAxes\_\_1\_\_\_0\_System\_Span\_osuTK\_Vector2\_\_System\_Boolean\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Triangle\>\(Triangle\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ConvexPolygonExtensions.Intersects<Triangle, TPolygon2\>\(Triangle, TPolygon2\)](osu.Framework.Extensions.PolygonExtensions.ConvexPolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_ConvexPolygonExtensions\_Intersects\_\_2\_\_\_0\_\_\_1\_), 
[ObjectExtensions.IsNotNull<Triangle\>\(Triangle\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Triangle\>\(Triangle\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Triangle, TChild\>\(Triangle, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Triangle, TChild\>\(Triangle, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Triangle, TChild\>\(Triangle, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Triangle\>\(Triangle\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_Triangle__ctor_osuTK_Vector2_osuTK_Vector2_osuTK_Vector2_"></a> Triangle\(Vector2, Vector2, Vector2\)

```csharp
public Triangle(Vector2 p0, Vector2 p1, Vector2 p2)
```

#### Parameters

`p0` Vector2

`p1` Vector2

`p2` Vector2

## Fields

### <a id="osu_Framework_Graphics_Primitives_Triangle_P0"></a> P0

```csharp
public readonly Vector2 P0
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Triangle_P1"></a> P1

```csharp
public readonly Vector2 P1
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_Triangle_P2"></a> P2

```csharp
public readonly Vector2 P2
```

#### Field Value

 Vector2

## Properties

### <a id="osu_Framework_Graphics_Primitives_Triangle_AABBFloat"></a> AABBFloat

```csharp
public RectangleF AABBFloat { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_Triangle_Area"></a> Area

```csharp
public float Area { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Primitives_Triangle_Contains_osuTK_Vector2_"></a> Contains\(Vector2\)

Checks whether a point lies within the triangle.

```csharp
public bool Contains(Vector2 pos)
```

#### Parameters

`pos` Vector2

The point to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Outcome of the check.

### <a id="osu_Framework_Graphics_Primitives_Triangle_Equals_osu_Framework_Graphics_Primitives_Triangle_"></a> Equals\(Triangle\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Triangle other)
```

#### Parameters

`other` [Triangle](osu.Framework.Graphics.Primitives.Triangle.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Primitives_Triangle_GetAxisVertices"></a> GetAxisVertices\(\)

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

### <a id="osu_Framework_Graphics_Primitives_Triangle_GetVertices"></a> GetVertices\(\)

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

