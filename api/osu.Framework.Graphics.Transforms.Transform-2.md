# <a id="osu_Framework_Graphics_Transforms_Transform_2"></a> Class Transform<TValue, T\>

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Transform<TValue, T> : Transform<TValue, DefaultEasingFunction, T> where T : class, ITransformable
```

#### Type Parameters

`TValue` 

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform](osu.Framework.Graphics.Transforms.Transform.md) ← 
[Transform<TValue\>](osu.Framework.Graphics.Transforms.Transform\-1.md) ← 
[Transform<TValue, DefaultEasingFunction, T\>](osu.Framework.Graphics.Transforms.Transform\-3.md) ← 
[Transform<TValue, T\>](osu.Framework.Graphics.Transforms.Transform\-2.md)

#### Inherited Members

[Transform<TValue, DefaultEasingFunction, T\>.TargetTransformable](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_TargetTransformable), 
[Transform<TValue, DefaultEasingFunction, T\>.Target](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_Target), 
[Transform<TValue, DefaultEasingFunction, T\>.Easing](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_Easing), 
[Transform<TValue, DefaultEasingFunction, T\>.Apply\(double\)](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_Apply\_System\_Double\_), 
[Transform<TValue, DefaultEasingFunction, T\>.ReadIntoStartValue\(\)](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_ReadIntoStartValue), 
[Transform<TValue, DefaultEasingFunction, T\>.Apply\(T, double\)](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_Apply\_\_2\_System\_Double\_), 
[Transform<TValue, DefaultEasingFunction, T\>.ReadIntoStartValue\(T\)](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_ReadIntoStartValue\_\_2\_), 
[Transform<TValue, DefaultEasingFunction, T\>.ToString\(\)](osu.Framework.Graphics.Transforms.Transform\-3.md\#osu\_Framework\_Graphics\_Transforms\_Transform\_3\_ToString), 
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

[ObjectExtensions.AsNonNull<Transform<TValue, T\>\>\(Transform<TValue, T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Transform<TValue, T\>\>\(Transform<TValue, T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Transform<TValue, T\>\>\(Transform<TValue, T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Transform<TValue, T\>\>\(Transform<TValue, T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Transform<TValue, T\>, TChild\>\(Transform<TValue, T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Transform<TValue, T\>, TChild\>\(Transform<TValue, T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Transform<TValue, T\>, TChild\>\(Transform<TValue, T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Transform<TValue, T\>\>\(Transform<TValue, T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

