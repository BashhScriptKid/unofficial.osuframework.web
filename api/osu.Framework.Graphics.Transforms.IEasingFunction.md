# <a id="osu_Framework_Graphics_Transforms_IEasingFunction"></a> Interface IEasingFunction

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

An interface for an easing function that is applied to <xref href="osu.Framework.Graphics.Transforms.Transform%601" data-throw-if-not-resolved="false"></xref>s.

```csharp
public interface IEasingFunction
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IEasingFunction\>\(IEasingFunction?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IEasingFunction\>\(IEasingFunction\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IEasingFunction\>\(IEasingFunction\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IEasingFunction\>\(IEasingFunction\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IEasingFunction, TChild\>\(IEasingFunction, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IEasingFunction, TChild\>\(IEasingFunction, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IEasingFunction, TChild\>\(IEasingFunction, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IEasingFunction\>\(IEasingFunction\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Transforms_IEasingFunction_ApplyEasing_System_Double_"></a> ApplyEasing\(double\)

Applies the easing function to a time value.

```csharp
double ApplyEasing(double time)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time value to apply the easing to.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The eased time value.

