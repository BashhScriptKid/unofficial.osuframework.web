# <a id="osu_Framework_Utils_IncrementalBSplineBuilder"></a> Class IncrementalBSplineBuilder

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

A class for incrementally building B-Spline paths from a series of linear points.
This can be used to obtain a B-Spline with a minimal number of control points for any
given set of linear input points, for example, a hand-drawn path.

```csharp
public class IncrementalBSplineBuilder
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalBSplineBuilder](osu.Framework.Utils.IncrementalBSplineBuilder.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IncrementalBSplineBuilder\>\(IncrementalBSplineBuilder?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IncrementalBSplineBuilder\>\(IncrementalBSplineBuilder\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IncrementalBSplineBuilder\>\(IncrementalBSplineBuilder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IncrementalBSplineBuilder\>\(IncrementalBSplineBuilder\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IncrementalBSplineBuilder, TChild\>\(IncrementalBSplineBuilder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IncrementalBSplineBuilder, TChild\>\(IncrementalBSplineBuilder, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IncrementalBSplineBuilder, TChild\>\(IncrementalBSplineBuilder, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IncrementalBSplineBuilder\>\(IncrementalBSplineBuilder\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder__ctor_System_Int32_System_Single_System_Single_"></a> IncrementalBSplineBuilder\(int, float, float\)

Initializes a new instance of the <xref href="osu.Framework.Utils.IncrementalBSplineBuilder" data-throw-if-not-resolved="false"></xref> class with specified degree and tolerance.

```csharp
public IncrementalBSplineBuilder(int degree = 3, float tolerance = 1.5, float cornerThreshold = 0.4)
```

#### Parameters

`degree` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The degree of the B-Spline.

`tolerance` [float](https://learn.microsoft.com/dotnet/api/system.single)

The tolerance for control point addition.

`cornerThreshold` [float](https://learn.microsoft.com/dotnet/api/system.single)

The threshold to use for inserting sharp control points at corners.

## Properties

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_ControlPoints"></a> ControlPoints

The list of control points of the B-Spline. This is inferred from the input path.

```csharp
public IReadOnlyList<List<Vector2>> ControlPoints { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<Vector2\>\>

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_CornerThreshold"></a> CornerThreshold

Gets or sets the corner threshold for determining when to add a new control point. Must not be negative. Default is 0.4.

```csharp
public float CornerThreshold { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

Thrown when the value is negative.

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_Degree"></a> Degree

Gets or sets the degree of the B-Spline. Must not be negative. Default is 3.

```csharp
public int Degree { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

Thrown when the value is negative.

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_OutputPath"></a> OutputPath

The piecewise linear approximation of the B-spline created from the input path.

```csharp
public IReadOnlyList<Vector2> OutputPath { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<Vector2\>

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_Tolerance"></a> Tolerance

Gets or sets the tolerance for determining when to add a new control point. Must not be negative. Default is 1.5.

```csharp
public float Tolerance { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

Thrown when the value is negative.

## Methods

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_AddLinearPoint_osuTK_Vector2_"></a> AddLinearPoint\(Vector2\)

Adds a linear point to the path and updates the B-Spline accordingly.

```csharp
public void AddLinearPoint(Vector2 v)
```

#### Parameters

`v` Vector2

The vector representing the point to add.

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_Clear"></a> Clear\(\)

Clears the input path and the B-Spline.

```csharp
public void Clear()
```

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_Finish"></a> Finish\(\)

Call this when you are done building the path.
This method applies the final step of post-processing.

```csharp
public void Finish()
```

### <a id="osu_Framework_Utils_IncrementalBSplineBuilder_GetInputPath"></a> GetInputPath\(\)

The list of input points.

```csharp
public IReadOnlyList<Vector2> GetInputPath()
```

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<Vector2\>

