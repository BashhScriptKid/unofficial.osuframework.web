# <a id="osu_Framework_Extensions_PolygonExtensions_PolygonExtensions"></a> Class PolygonExtensions

Namespace: [osu.Framework.Extensions.PolygonExtensions](osu.Framework.Extensions.PolygonExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class PolygonExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PolygonExtensions](osu.Framework.Extensions.PolygonExtensions.PolygonExtensions.md)

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

### <a id="osu_Framework_Extensions_PolygonExtensions_PolygonExtensions_GetAxes__1___0_System_Boolean_"></a> GetAxes<TPolygon\>\(TPolygon, bool\)

Computes the axes for each edge in a polygon.

```csharp
public static Span<Vector2> GetAxes<TPolygon>(TPolygon polygon, bool normalize = false) where TPolygon : IPolygon
```

#### Parameters

`polygon` TPolygon

The polygon to compute the axes of.

`normalize` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the normals should be normalized. Allows computation of the exact intersection point.

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Vector2\>

The axes of the polygon.

#### Type Parameters

`TPolygon` 

### <a id="osu_Framework_Extensions_PolygonExtensions_PolygonExtensions_GetAxes__1___0_System_Span_osuTK_Vector2__System_Boolean_"></a> GetAxes<TPolygon\>\(TPolygon, Span<Vector2\>, bool\)

Computes the axes for each edge in a polygon.

```csharp
public static Span<Vector2> GetAxes<TPolygon>(this TPolygon polygon, Span<Vector2> buffer, bool normalize = false) where TPolygon : IPolygon
```

#### Parameters

`polygon` TPolygon

The polygon to compute the axes of.

`buffer` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Vector2\>

A buffer to be used as storage for the axes. Must have a length of at least the count of vertices in <code class="paramref">polygon</code>.

`normalize` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the normals should be normalized. Allows computation of the exact intersection point.

#### Returns

 [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<Vector2\>

The axes of the polygon. Returned as a slice of <code class="paramref">buffer</code>.

#### Type Parameters

`TPolygon` 

