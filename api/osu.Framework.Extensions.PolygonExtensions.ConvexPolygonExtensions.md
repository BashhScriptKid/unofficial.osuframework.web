# <a id="osu_Framework_Extensions_PolygonExtensions_ConvexPolygonExtensions"></a> Class ConvexPolygonExtensions

Namespace: [osu.Framework.Extensions.PolygonExtensions](osu.Framework.Extensions.PolygonExtensions.md)  
Assembly: osu.Framework.dll  

Todo: Support segment containment and circles.
Todo: Might be overkill, but possibly support convex decomposition?

```csharp
public static class ConvexPolygonExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConvexPolygonExtensions](osu.Framework.Extensions.PolygonExtensions.ConvexPolygonExtensions.md)

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

### <a id="osu_Framework_Extensions_PolygonExtensions_ConvexPolygonExtensions_Intersects__2___0___1_"></a> Intersects<TPolygon1, TPolygon2\>\(TPolygon1, TPolygon2\)

Determines whether two convex polygons intersect.

```csharp
public static bool Intersects<TPolygon1, TPolygon2>(this TPolygon1 first, TPolygon2 second) where TPolygon1 : IConvexPolygon where TPolygon2 : IConvexPolygon
```

#### Parameters

`first` TPolygon1

The first polygon.

`second` TPolygon2

The second polygon.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the two polygons intersect.

#### Type Parameters

`TPolygon1` 

`TPolygon2` 

