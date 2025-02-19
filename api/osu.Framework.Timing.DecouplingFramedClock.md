# <a id="osu_Framework_Timing_DecouplingFramedClock"></a> Class DecouplingFramedClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A decoupling clock allows taking an existing clock which has seek limitations and provides
a controllable encapsulated view of that clock with the ability to seek and track time
outside of the normally seekable bounds.

Put simply, it will take a Track which can only track time from 0..trackLength and allow
both negative seeks and seeks beyond trackLength. It will also allow time to continue counting
beyond the end of the track even when not explicitly seeked.

```csharp
public sealed class DecouplingFramedClock : ISourceChangeableClock, IAdjustableClock, IFrameBasedClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DecouplingFramedClock](osu.Framework.Timing.DecouplingFramedClock.md)

#### Implements

[ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md), 
[IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md), 
[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[IClock](osu.Framework.Timing.IClock.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DecouplingFramedClock\>\(DecouplingFramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DecouplingFramedClock\>\(DecouplingFramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DecouplingFramedClock\>\(DecouplingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DecouplingFramedClock\>\(DecouplingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DecouplingFramedClock, TChild\>\(DecouplingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DecouplingFramedClock, TChild\>\(DecouplingFramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DecouplingFramedClock, TChild\>\(DecouplingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DecouplingFramedClock\>\(DecouplingFramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

There are a few things to note about this implementation:
- Changing the source clock via <xref href="osu.Framework.Timing.DecouplingFramedClock.ChangeSource(osu.Framework.Timing.IClock)" data-throw-if-not-resolved="false"></xref> will always take on the new source's running
  state and current time, regardless of decoupled state.
- It is always assumed that after a <xref href="osu.Framework.Timing.DecouplingFramedClock.Reset" data-throw-if-not-resolved="false"></xref> on the source, it will be able to track time.
- It is assumed that a source is generally able to start tracking from zero. Special handling ensures
  that when arriving at zero from negative time, the source will attempt to be started once so it can
  take over.
  Note that no such special handling is assured for when the source has a maximum allowable time,
  since it is not known what that time is.

## Constructors

### <a id="osu_Framework_Timing_DecouplingFramedClock__ctor_osu_Framework_Timing_IClock_"></a> DecouplingFramedClock\(IClock?\)

```csharp
public DecouplingFramedClock(IClock? source = null)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)?

## Properties

### <a id="osu_Framework_Timing_DecouplingFramedClock_AllowDecoupling"></a> AllowDecoupling

Whether to allow operation in decoupled mode. Defaults to <code>true</code>.

```csharp
public bool AllowDecoupling { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

When set to <code>false</code>, this clock will operate in a transparent pass-through mode.

### <a id="osu_Framework_Timing_DecouplingFramedClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecouplingFramedClock_ElapsedFrameTime"></a> ElapsedFrameTime

Elapsed time since last frame in milliseconds.

```csharp
public double ElapsedFrameTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecouplingFramedClock_FramesPerSecond"></a> FramesPerSecond

A moving average representation of the frames per second of this clock.
Do not use this for any timing purposes (use <xref href="osu.Framework.Timing.IFrameBasedClock.ElapsedFrameTime" data-throw-if-not-resolved="false"></xref> instead).

```csharp
public double FramesPerSecond { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecouplingFramedClock_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Timing_DecouplingFramedClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
public double Rate { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecouplingFramedClock_Source"></a> Source

The source clock.

```csharp
public IClock Source { get; }
```

#### Property Value

 [IClock](osu.Framework.Timing.IClock.md)

## Methods

### <a id="osu_Framework_Timing_DecouplingFramedClock_ChangeSource_osu_Framework_Timing_IClock_"></a> ChangeSource\(IClock?\)

Change the source clock.

```csharp
public void ChangeSource(IClock? source)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)?

The new source clock.

### <a id="osu_Framework_Timing_DecouplingFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public void ProcessFrame()
```

### <a id="osu_Framework_Timing_DecouplingFramedClock_Reset"></a> Reset\(\)

Stop and reset position.

```csharp
public void Reset()
```

### <a id="osu_Framework_Timing_DecouplingFramedClock_ResetSpeedAdjustments"></a> ResetSpeedAdjustments\(\)

Reset the rate to a stable value.

```csharp
public void ResetSpeedAdjustments()
```

### <a id="osu_Framework_Timing_DecouplingFramedClock_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
public bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

### <a id="osu_Framework_Timing_DecouplingFramedClock_Start"></a> Start\(\)

Start (resume) running.

```csharp
public void Start()
```

### <a id="osu_Framework_Timing_DecouplingFramedClock_Stop"></a> Stop\(\)

Stop (pause) running.

```csharp
public void Stop()
```

