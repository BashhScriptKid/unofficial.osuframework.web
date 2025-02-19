# <a id="osu_Framework_Timing_FramedClock"></a> Class FramedClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

Takes a clock source and separates time reading on a per-frame level.
The CurrentTime value will only change on initial construction and whenever ProcessFrame is run.

```csharp
public class FramedClock : IFrameBasedClock, ISourceChangeableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FramedClock](osu.Framework.Timing.FramedClock.md)

#### Derived

[FramedOffsetClock](osu.Framework.Timing.FramedOffsetClock.md), 
[LaggyFramedClock](osu.Framework.Tests.Visual.Clocks.LaggyFramedClock.md), 
[ThrottledFrameClock](osu.Framework.Timing.ThrottledFrameClock.md)

#### Implements

[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md), 
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

[ObjectExtensions.AsNonNull<FramedClock\>\(FramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FramedClock\>\(FramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FramedClock\>\(FramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FramedClock\>\(FramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FramedClock, TChild\>\(FramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FramedClock, TChild\>\(FramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FramedClock, TChild\>\(FramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FramedClock\>\(FramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Timing_FramedClock__ctor_osu_Framework_Timing_IClock_System_Boolean_"></a> FramedClock\(IClock?, bool\)

Construct a new FramedClock with an optional source clock.

```csharp
public FramedClock(IClock? source = null, bool processSource = true)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)?

A source clock which will be used as the backing time source. If null, a StopwatchClock will be created. When provided, the CurrentTime of <code class="paramref">source</code> will be transferred instantly.

`processSource` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the source clock's <xref href="osu.Framework.Timing.FramedClock.ProcessFrame" data-throw-if-not-resolved="false"></xref> method should be called during this clock's process call.

## Properties

### <a id="osu_Framework_Timing_FramedClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public virtual double CurrentTime { get; protected set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedClock_ElapsedFrameTime"></a> ElapsedFrameTime

Elapsed time since last frame in milliseconds.

```csharp
public double ElapsedFrameTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedClock_FramesPerSecond"></a> FramesPerSecond

A moving average representation of the frames per second of this clock.
Do not use this for any timing purposes (use <xref href="osu.Framework.Timing.IFrameBasedClock.ElapsedFrameTime" data-throw-if-not-resolved="false"></xref> instead).

```csharp
public double FramesPerSecond { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedClock_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Timing_FramedClock_Jitter"></a> Jitter

```csharp
public double Jitter { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedClock_LastFrameTime"></a> LastFrameTime

```csharp
protected virtual double LastFrameTime { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
public double Rate { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedClock_Source"></a> Source

The source clock.

```csharp
public IClock Source { get; }
```

#### Property Value

 [IClock](osu.Framework.Timing.IClock.md)

### <a id="osu_Framework_Timing_FramedClock_SourceTime"></a> SourceTime

```csharp
protected double SourceTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Timing_FramedClock_ChangeSource_osu_Framework_Timing_IClock_"></a> ChangeSource\(IClock\)

Change the source clock.

```csharp
public void ChangeSource(IClock source)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)

The new source clock.

### <a id="osu_Framework_Timing_FramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public virtual void ProcessFrame()
```

### <a id="osu_Framework_Timing_FramedClock_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

