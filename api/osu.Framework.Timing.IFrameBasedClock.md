# <a id="osu_Framework_Timing_IFrameBasedClock"></a> Interface IFrameBasedClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A clock which will only update its current time when a frame process is triggered.
Useful for keeping a consistent time state across an individual update.

```csharp
public interface IFrameBasedClock : IClock
```

#### Implements

[IClock](osu.Framework.Timing.IClock.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IFrameBasedClock\>\(IFrameBasedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IFrameBasedClock\>\(IFrameBasedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IFrameBasedClock\>\(IFrameBasedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IFrameBasedClock\>\(IFrameBasedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IFrameBasedClock, TChild\>\(IFrameBasedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IFrameBasedClock, TChild\>\(IFrameBasedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IFrameBasedClock, TChild\>\(IFrameBasedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IFrameBasedClock\>\(IFrameBasedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Timing_IFrameBasedClock_ElapsedFrameTime"></a> ElapsedFrameTime

Elapsed time since last frame in milliseconds.

```csharp
double ElapsedFrameTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_IFrameBasedClock_FramesPerSecond"></a> FramesPerSecond

A moving average representation of the frames per second of this clock.
Do not use this for any timing purposes (use <xref href="osu.Framework.Timing.IFrameBasedClock.ElapsedFrameTime" data-throw-if-not-resolved="false"></xref> instead).

```csharp
double FramesPerSecond { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_IFrameBasedClock_TimeInfo"></a> TimeInfo

```csharp
FrameTimeInfo TimeInfo { get; }
```

#### Property Value

 [FrameTimeInfo](osu.Framework.Timing.FrameTimeInfo.md)

## Methods

### <a id="osu_Framework_Timing_IFrameBasedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
void ProcessFrame()
```

