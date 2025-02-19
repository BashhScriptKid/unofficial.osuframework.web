# <a id="osu_Framework_Utils_InterpolationFunc_2"></a> Delegate InterpolationFunc<TValue, TEasing\>

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

```csharp
public delegate TValue InterpolationFunc<TValue, TEasing>(double time, TValue startValue, TValue endValue, double startTime, double endTime, in TEasing easingType) where TEasing : IEasingFunction
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

`startValue` TValue

`endValue` TValue

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easingType` TEasing

#### Returns

 TValue

#### Type Parameters

`TValue` 

`TEasing` 

#### Extension Methods

[ObjectExtensions.AsNonNull<InterpolationFunc<TValue, TEasing\>\>\(InterpolationFunc<TValue, TEasing\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InterpolationFunc<TValue, TEasing\>\>\(InterpolationFunc<TValue, TEasing\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InterpolationFunc<TValue, TEasing\>\>\(InterpolationFunc<TValue, TEasing\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InterpolationFunc<TValue, TEasing\>\>\(InterpolationFunc<TValue, TEasing\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InterpolationFunc<TValue, TEasing\>, TChild\>\(InterpolationFunc<TValue, TEasing\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InterpolationFunc<TValue, TEasing\>, TChild\>\(InterpolationFunc<TValue, TEasing\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InterpolationFunc<TValue, TEasing\>, TChild\>\(InterpolationFunc<TValue, TEasing\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InterpolationFunc<TValue, TEasing\>\>\(InterpolationFunc<TValue, TEasing\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

