# <a id="osu_Framework_Graphics_Primitives_IPolygon"></a> Interface IPolygon

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IPolygon
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IPolygon\>\(IPolygon?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[PolygonExtensions.GetAxes<IPolygon\>\(IPolygon, Span<Vector2\>, bool\)](osu.Framework.Extensions.PolygonExtensions.PolygonExtensions.md\#osu\_Framework\_Extensions\_PolygonExtensions\_PolygonExtensions\_GetAxes\_\_1\_\_\_0\_System\_Span\_osuTK\_Vector2\_\_System\_Boolean\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IPolygon\>\(IPolygon\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IPolygon\>\(IPolygon\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IPolygon\>\(IPolygon\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IPolygon, TChild\>\(IPolygon, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IPolygon, TChild\>\(IPolygon, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IPolygon, TChild\>\(IPolygon, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IPolygon\>\(IPolygon\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Primitives_IPolygon_GetAxisVertices"></a> GetAxisVertices\(\)

The vertices that define the axes spanned by this polygon in screen-space counter-clockwise orientation.

```csharp
ReadOnlySpan<Vector2> GetAxisVertices()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The vertices that define the axes spanned by this polygon.

#### Remarks

Counter-clockwise orientation in screen-space coordinates is equivalent to a clockwise orientation in standard coordinates.
<p>
E.g. For the set of vertices { (0, 0), (1, 0), (0, 1), (1, 1) }, a counter-clockwise orientation is { (0, 0), (0, 1), (1, 1), (1, 0) }.
</p>

### <a id="osu_Framework_Graphics_Primitives_IPolygon_GetVertices"></a> GetVertices\(\)

Retrieves the vertices of this polygon in screen-space counter-clockwise orientation.

```csharp
ReadOnlySpan<Vector2> GetVertices()
```

#### Returns

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

The vertices of this polygon.

#### Remarks

Counter-clockwise orientation in screen-space coordinates is equivalent to a clockwise orientation in standard coordinates.
<p>
E.g. For the set of vertices { (0, 0), (1, 0), (0, 1), (1, 1) }, a counter-clockwise orientation is { (0, 0), (0, 1), (1, 1), (1, 0) }.
</p>

