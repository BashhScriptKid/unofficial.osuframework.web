# <a id="osu_Framework_Graphics_Primitives_SimpleConvexPolygon"></a> Class SimpleConvexPolygon

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

```csharp
public class SimpleConvexPolygon : IConvexPolygon, IPolygon
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SimpleConvexPolygon](osu.Framework.Graphics.Primitives.SimpleConvexPolygon.md)

#### Implements

[IConvexPolygon](osu.Framework.Graphics.Primitives.IConvexPolygon.md), 
[IPolygon](osu.Framework.Graphics.Primitives.IPolygon.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<SimpleConvexPolygon\>\(SimpleConvexPolygon?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[PolygonExtensions.GetAxes<SimpleConvexPolygon\>\(SimpleConvexPolygon, Span<Vector2\>, bool\)](osu.Framework.Extensions.PolygonExtensions.PolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_PolygonExtensions\_GetAxes\_\_1\_\_\_0\_System\_Span\_osuTK\_Vector2\_\_System\_Boolean\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<SimpleConvexPolygon\>\(SimpleConvexPolygon\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ConvexPolygonExtensions.Intersects<SimpleConvexPolygon, TPolygon2\>\(SimpleConvexPolygon, TPolygon2\)](osu.Framework.Extensions.PolygonExtensions.ConvexPolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_ConvexPolygonExtensions\_Intersects\_\_2\_\_\_0\_\_\_1\_), 
[ObjectExtensions.IsNotNull<SimpleConvexPolygon\>\(SimpleConvexPolygon\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<SimpleConvexPolygon\>\(SimpleConvexPolygon\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<SimpleConvexPolygon, TChild\>\(SimpleConvexPolygon, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<SimpleConvexPolygon, TChild\>\(SimpleConvexPolygon, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<SimpleConvexPolygon, TChild\>\(SimpleConvexPolygon, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<SimpleConvexPolygon\>\(SimpleConvexPolygon\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_SimpleConvexPolygon__ctor_osuTK_Vector2___"></a> SimpleConvexPolygon\(Vector2\[\]\)

```csharp
public SimpleConvexPolygon(Vector2[] vertices)
```

#### Parameters

`vertices` Vector2\[\]

## Properties

### <a id="osu_Framework_Graphics_Primitives_SimpleConvexPolygon_MaxClipVertices"></a> MaxClipVertices

```csharp
public int MaxClipVertices { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Primitives_SimpleConvexPolygon_GetAxisVertices"></a> GetAxisVertices\(\)

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

### <a id="osu_Framework_Graphics_Primitives_SimpleConvexPolygon_GetVertices"></a> GetVertices\(\)

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

### <a id="osu_Framework_Graphics_Primitives_SimpleConvexPolygon_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

