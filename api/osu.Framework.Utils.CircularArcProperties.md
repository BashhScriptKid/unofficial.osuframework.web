# <a id="osu_Framework_Utils_CircularArcProperties"></a> Struct CircularArcProperties

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

```csharp
public readonly struct CircularArcProperties
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CircularArcProperties\>\(CircularArcProperties\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CircularArcProperties\>\(CircularArcProperties\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CircularArcProperties\>\(CircularArcProperties\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CircularArcProperties\>\(CircularArcProperties\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CircularArcProperties, TChild\>\(CircularArcProperties, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CircularArcProperties, TChild\>\(CircularArcProperties, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CircularArcProperties, TChild\>\(CircularArcProperties, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CircularArcProperties\>\(CircularArcProperties\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Utils_CircularArcProperties__ctor_System_Double_System_Double_System_Double_System_Single_osuTK_Vector2_"></a> CircularArcProperties\(double, double, double, float, Vector2\)

```csharp
public CircularArcProperties(double thetaStart, double thetaRange, double direction, float radius, Vector2 centre)
```

#### Parameters

`thetaStart` [double](https://learn.microsoft.com/dotnet/api/system.double)

`thetaRange` [double](https://learn.microsoft.com/dotnet/api/system.double)

`direction` [double](https://learn.microsoft.com/dotnet/api/system.double)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`centre` Vector2

### <a id="osu_Framework_Utils_CircularArcProperties__ctor_System_ReadOnlySpan_osuTK_Vector2__"></a> CircularArcProperties\(ReadOnlySpan<Vector2\>\)

Computes various properties that can be used to approximate the circular arc.

```csharp
public CircularArcProperties(ReadOnlySpan<Vector2> controlPoints)
```

#### Parameters

`controlPoints` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<Vector2\>

Three distinct points on the arc.

## Fields

### <a id="osu_Framework_Utils_CircularArcProperties_Centre"></a> Centre

```csharp
public readonly Vector2 Centre
```

#### Field Value

 Vector2

### <a id="osu_Framework_Utils_CircularArcProperties_Direction"></a> Direction

```csharp
public readonly double Direction
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_CircularArcProperties_IsValid"></a> IsValid

```csharp
public readonly bool IsValid
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Utils_CircularArcProperties_Radius"></a> Radius

```csharp
public readonly float Radius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Utils_CircularArcProperties_ThetaRange"></a> ThetaRange

```csharp
public readonly double ThetaRange
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Utils_CircularArcProperties_ThetaStart"></a> ThetaStart

```csharp
public readonly double ThetaStart
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Properties

### <a id="osu_Framework_Utils_CircularArcProperties_ThetaEnd"></a> ThetaEnd

```csharp
public double ThetaEnd { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

