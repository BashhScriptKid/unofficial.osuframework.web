# <a id="osu_Framework_Timing_ISourceChangeableClock"></a> Interface ISourceChangeableClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A clock which has a source that can be changed.

```csharp
public interface ISourceChangeableClock : IClock
```

#### Implements

[IClock](osu.Framework.Timing.IClock.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ISourceChangeableClock\>\(ISourceChangeableClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ISourceChangeableClock\>\(ISourceChangeableClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ISourceChangeableClock\>\(ISourceChangeableClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ISourceChangeableClock\>\(ISourceChangeableClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ISourceChangeableClock, TChild\>\(ISourceChangeableClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ISourceChangeableClock, TChild\>\(ISourceChangeableClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ISourceChangeableClock, TChild\>\(ISourceChangeableClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ISourceChangeableClock\>\(ISourceChangeableClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Timing_ISourceChangeableClock_Source"></a> Source

The source clock.

```csharp
IClock? Source { get; }
```

#### Property Value

 [IClock](osu.Framework.Timing.IClock.md)?

## Methods

### <a id="osu_Framework_Timing_ISourceChangeableClock_ChangeSource_osu_Framework_Timing_IClock_"></a> ChangeSource\(IClock\)

Change the source clock.

```csharp
void ChangeSource(IClock source)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)

The new source clock.

