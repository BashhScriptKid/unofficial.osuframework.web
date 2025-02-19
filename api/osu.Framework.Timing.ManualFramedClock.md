# <a id="osu_Framework_Timing_ManualFramedClock"></a> Class ManualFramedClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A completely manual framed clock implementation. Everything is settable.

```csharp
public class ManualFramedClock : IFrameBasedClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ManualFramedClock](osu.Framework.Timing.ManualFramedClock.md)

#### Implements

[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[IClock](osu.Framework.Timing.IClock.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ManualFramedClock\>\(ManualFramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ManualFramedClock\>\(ManualFramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ManualFramedClock\>\(ManualFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ManualFramedClock\>\(ManualFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ManualFramedClock, TChild\>\(ManualFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ManualFramedClock, TChild\>\(ManualFramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ManualFramedClock, TChild\>\(ManualFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ManualFramedClock\>\(ManualFramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Timing_ManualFramedClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public double CurrentTime { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_ManualFramedClock_ElapsedFrameTime"></a> ElapsedFrameTime

Elapsed time since last frame in milliseconds.

```csharp
public double ElapsedFrameTime { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_ManualFramedClock_FramesPerSecond"></a> FramesPerSecond

A moving average representation of the frames per second of this clock.
Do not use this for any timing purposes (use <xref href="osu.Framework.Timing.IFrameBasedClock.ElapsedFrameTime" data-throw-if-not-resolved="false"></xref> instead).

```csharp
public double FramesPerSecond { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_ManualFramedClock_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public bool IsRunning { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Timing_ManualFramedClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
public double Rate { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Timing_ManualFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public void ProcessFrame()
```

