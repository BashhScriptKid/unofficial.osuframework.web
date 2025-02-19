# <a id="osu_Framework_Graphics_Transforms_Transform"></a> Class Transform

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Transform
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform](osu.Framework.Graphics.Transforms.Transform.md)

#### Derived

[Transform<TValue\>](osu.Framework.Graphics.Transforms.Transform\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Transform\>\(Transform?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Transform\>\(Transform\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Transform\>\(Transform\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Transform\>\(Transform\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Transform, TChild\>\(Transform, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Transform, TChild\>\(Transform, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Transform, TChild\>\(Transform, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Transform\>\(Transform\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Transforms_Transform_COMPARER"></a> COMPARER

```csharp
public static readonly IComparer<Transform> COMPARER
```

#### Field Value

 [IComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer\-1)<[Transform](osu.Framework.Graphics.Transforms.Transform.md)\>

### <a id="osu_Framework_Graphics_Transforms_Transform_Rewindable"></a> Rewindable

Whether this <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> can be rewound.

```csharp
public bool Rewindable
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Graphics_Transforms_Transform_EndTime"></a> EndTime

```csharp
public double EndTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transform_IsLooping"></a> IsLooping

```csharp
public bool IsLooping { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Transforms_Transform_LoopCount"></a> LoopCount

The remaining number of loops, including the current loop. If -1, then this loops indefinitely.

```csharp
public int LoopCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Transforms_Transform_LoopDelay"></a> LoopDelay

```csharp
public double LoopDelay { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transform_StartTime"></a> StartTime

```csharp
public double StartTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transform_TargetGrouping"></a> TargetGrouping

The name of the grouping this <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> belongs to.
Defaults to <xref href="osu.Framework.Graphics.Transforms.Transform.TargetMember" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual string TargetGrouping { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

Transforms in a single group affect the same property (or properties) of a <xref href="osu.Framework.Graphics.Transforms.Transformable" data-throw-if-not-resolved="false"></xref>.
It is assumed that transforms in different groups are independent from each other
in that they affect different properties, and therefore they can be applied independently
in any order without affecting the end result.

### <a id="osu_Framework_Graphics_Transforms_Transform_TargetMember"></a> TargetMember

```csharp
public abstract string TargetMember { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Transforms_Transform_TargetTransformable"></a> TargetTransformable

```csharp
public abstract ITransformable TargetTransformable { get; }
```

#### Property Value

 [ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

## Methods

### <a id="osu_Framework_Graphics_Transforms_Transform_Apply_System_Double_"></a> Apply\(double\)

```csharp
public abstract void Apply(double time)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transform_Clone"></a> Clone\(\)

```csharp
public Transform Clone()
```

#### Returns

 [Transform](osu.Framework.Graphics.Transforms.Transform.md)

### <a id="osu_Framework_Graphics_Transforms_Transform_ReadIntoStartValue"></a> ReadIntoStartValue\(\)

```csharp
public abstract void ReadIntoStartValue()
```

