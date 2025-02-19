# <a id="osu_Framework_Graphics_Transforms_Transform_3"></a> Class Transform<TValue, TEasing, T\>

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Transform<TValue, TEasing, T> : Transform<TValue> where TEasing : IEasingFunction where T : class, ITransformable
```

#### Type Parameters

`TValue` 

`TEasing` 

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform](osu.Framework.Graphics.Transforms.Transform.md) ← 
[Transform<TValue\>](osu.Framework.Graphics.Transforms.Transform\-1.md) ← 
[Transform<TValue, TEasing, T\>](osu.Framework.Graphics.Transforms.Transform\-3.md)

#### Inherited Members

[Transform<TValue\>.StartValue](osu.Framework.Graphics.Transforms.Transform\-1.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_1\_StartValue), 
[Transform<TValue\>.EndValue](osu.Framework.Graphics.Transforms.Transform\-1.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_1\_EndValue), 
[Transform.Rewindable](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_Rewindable), 
[Transform.TargetTransformable](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_TargetTransformable), 
[Transform.StartTime](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_StartTime), 
[Transform.EndTime](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_EndTime), 
[Transform.IsLooping](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_IsLooping), 
[Transform.LoopDelay](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_LoopDelay), 
[Transform.LoopCount](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_LoopCount), 
[Transform.TargetMember](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_TargetMember), 
[Transform.TargetGrouping](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_TargetGrouping), 
[Transform.Apply\(double\)](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_Apply\_System\_Double\_), 
[Transform.ReadIntoStartValue\(\)](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_ReadIntoStartValue), 
[Transform.Clone\(\)](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_Clone), 
[Transform.COMPARER](osu.Framework.Graphics.Transforms.Transform.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_COMPARER), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Transform<TValue, TEasing, T\>\>\(Transform<TValue, TEasing, T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Transform<TValue, TEasing, T\>\>\(Transform<TValue, TEasing, T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Transform<TValue, TEasing, T\>\>\(Transform<TValue, TEasing, T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Transform<TValue, TEasing, T\>\>\(Transform<TValue, TEasing, T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Transform<TValue, TEasing, T\>, TChild\>\(Transform<TValue, TEasing, T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Transform<TValue, TEasing, T\>, TChild\>\(Transform<TValue, TEasing, T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Transform<TValue, TEasing, T\>, TChild\>\(Transform<TValue, TEasing, T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Transform<TValue, TEasing, T\>\>\(Transform<TValue, TEasing, T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Transforms_Transform_3_Easing"></a> Easing

```csharp
public TEasing Easing { get; }
```

#### Property Value

 TEasing

### <a id="osu_Framework_Graphics_Transforms_Transform_3_Target"></a> Target

```csharp
public T Target { get; }
```

#### Property Value

 T

### <a id="osu_Framework_Graphics_Transforms_Transform_3_TargetTransformable"></a> TargetTransformable

```csharp
public override ITransformable TargetTransformable { get; }
```

#### Property Value

 [ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

## Methods

### <a id="osu_Framework_Graphics_Transforms_Transform_3_Apply_System_Double_"></a> Apply\(double\)

```csharp
public override sealed void Apply(double time)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transform_3_Apply__2_System_Double_"></a> Apply\(T, double\)

```csharp
protected abstract void Apply(T d, double time)
```

#### Parameters

`d` T

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Transforms_Transform_3_ReadIntoStartValue"></a> ReadIntoStartValue\(\)

```csharp
public override sealed void ReadIntoStartValue()
```

### <a id="osu_Framework_Graphics_Transforms_Transform_3_ReadIntoStartValue__2_"></a> ReadIntoStartValue\(T\)

```csharp
protected abstract void ReadIntoStartValue(T d)
```

#### Parameters

`d` T

### <a id="osu_Framework_Graphics_Transforms_Transform_3_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

