# <a id="osu_Framework_Extensions_BridgingExtensions"></a> Class BridgingExtensions

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

Temporary extension functions for bridging between osuTK, System.Drawing, and System.Numerics
Can be removed when the SDL3 migration is complete.

```csharp
public static class BridgingExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BridgingExtensions](osu.Framework.Extensions.BridgingExtensions.md)

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

### <a id="osu_Framework_Extensions_BridgingExtensions_ToOsuTK_System_Numerics_Vector2_"></a> ToOsuTK\(Vector2\)

```csharp
public static Vector2 ToOsuTK(this Vector2 vec)
```

#### Parameters

`vec` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 Vector2

### <a id="osu_Framework_Extensions_BridgingExtensions_ToSystemDrawingPoint_System_Numerics_Vector2_"></a> ToSystemDrawingPoint\(Vector2\)

```csharp
public static Point ToSystemDrawingPoint(this Vector2 vec)
```

#### Parameters

`vec` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

### <a id="osu_Framework_Extensions_BridgingExtensions_ToSystemDrawingSize_System_Numerics_Vector2_"></a> ToSystemDrawingSize\(Vector2\)

```csharp
public static Size ToSystemDrawingSize(this Vector2 vec)
```

#### Parameters

`vec` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

### <a id="osu_Framework_Extensions_BridgingExtensions_ToSystemNumerics_osuTK_Vector2_"></a> ToSystemNumerics\(Vector2\)

```csharp
public static Vector2 ToSystemNumerics(this Vector2 vec)
```

#### Parameters

`vec` Vector2

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="osu_Framework_Extensions_BridgingExtensions_ToSystemNumerics_System_Drawing_Size_"></a> ToSystemNumerics\(Size\)

```csharp
public static Vector2 ToSystemNumerics(this Size size)
```

#### Parameters

`size` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="osu_Framework_Extensions_BridgingExtensions_ToSystemNumerics_System_Drawing_Point_"></a> ToSystemNumerics\(Point\)

```csharp
public static Vector2 ToSystemNumerics(this Point point)
```

#### Parameters

`point` [Point](https://learn.microsoft.com/dotnet/api/system.drawing.point)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

