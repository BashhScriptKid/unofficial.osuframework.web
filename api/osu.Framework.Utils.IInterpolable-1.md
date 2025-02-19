# <a id="osu_Framework_Utils_IInterpolable_1"></a> Interface IInterpolable<TValue\>

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

An interface that defines the interpolation of a value.

```csharp
public interface IInterpolable<TValue>
```

#### Type Parameters

`TValue` 

The type of value to be interpolated..

#### Extension Methods

[ObjectExtensions.AsNonNull<IInterpolable<TValue\>\>\(IInterpolable<TValue\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IInterpolable<TValue\>\>\(IInterpolable<TValue\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IInterpolable<TValue\>\>\(IInterpolable<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IInterpolable<TValue\>\>\(IInterpolable<TValue\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IInterpolable<TValue\>, TChild\>\(IInterpolable<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IInterpolable<TValue\>, TChild\>\(IInterpolable<TValue\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IInterpolable<TValue\>, TChild\>\(IInterpolable<TValue\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IInterpolable<TValue\>\>\(IInterpolable<TValue\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Utils_IInterpolable_1_ValueAt__1_System_Double__0__0_System_Double_System_Double___0__"></a> ValueAt<TEasing\>\(double, TValue, TValue, double, double, in TEasing\)

Interpolates between two <code class="typeparamref">TValue</code>s.

```csharp
TValue ValueAt<TEasing>(double time, TValue startValue, TValue endValue, double startTime, double endTime, in TEasing easing) where TEasing : IEasingFunction
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The current time.

`startValue` TValue

The <code class="typeparamref">TValue</code> at <code class="paramref">time</code> = <code class="paramref">startTime</code>.

`endValue` TValue

The <code class="typeparamref">TValue</code> at <code class="paramref">time</code> = <code class="paramref">endTime</code>.

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The start time.

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The end time.

`easing` TEasing

The easing function to use.

#### Returns

 TValue

The interpolated value.

#### Type Parameters

`TEasing` 

#### Remarks

This method MUST NOT modify the current object.

