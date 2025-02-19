# <a id="osu_Framework_Graphics_Transforms_Transform_1"></a> Class Transform<TValue\>

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Transform<TValue> : Transform
```

#### Type Parameters

`TValue` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform](osu.Framework.Graphics.Transforms.Transform.md) ← 
[Transform<TValue\>](osu.Framework.Graphics.Transforms.Transform\-1.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<Transform<TValue\>\>\(Transform<TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Transform<TValue\>\>\(Transform<TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Transform<TValue\>\>\(Transform<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Transform<TValue\>\>\(Transform<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Transform<TValue\>, TChild\>\(Transform<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Transform<TValue\>, TChild\>\(Transform<TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Transform<TValue\>, TChild\>\(Transform<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Transform<TValue\>\>\(Transform<TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Transforms_Transform_1_EndValue"></a> EndValue

```csharp
public TValue EndValue { get; protected set; }
```

#### Property Value

 TValue

### <a id="osu_Framework_Graphics_Transforms_Transform_1_StartValue"></a> StartValue

```csharp
public TValue StartValue { get; protected set; }
```

#### Property Value

 TValue

