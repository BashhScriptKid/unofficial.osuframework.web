# <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock"></a> Class DecoupleableInterpolatingFramedClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

Adds the ability to keep the clock running even when the underlying source has stopped or cannot handle the current time range.
This is handled by performing seeks on the underlying source and checking whether they were successful or not.
On failure to seek, we take over with an internal clock until control can be returned to the actual source.

This clock type removes the requirement of having a source set.

If a <xref href="osu.Framework.Timing.InterpolatingFramedClock.Source" data-throw-if-not-resolved="false"></xref> is set, it is presumed that we have exclusive control over operations on it.
This is used to our advantage to allow correct <xref href="osu.Framework.Timing.DecoupleableInterpolatingFramedClock.IsRunning" data-throw-if-not-resolved="false"></xref> state tracking in the event of cross-thread communication delays (with an audio thread, for instance).

```csharp
[Obsolete("This clock implementation is too complex and no longer. Use DecouplingClock instead.")]
public class DecoupleableInterpolatingFramedClock : InterpolatingFramedClock, IFrameBasedClock, ISourceChangeableClock, IAdjustableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InterpolatingFramedClock](osu.Framework.Timing.InterpolatingFramedClock.md) ← 
[DecoupleableInterpolatingFramedClock](osu.Framework.Timing.DecoupleableInterpolatingFramedClock.md)

#### Implements

[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md), 
[IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md), 
[IClock](osu.Framework.Timing.IClock.md)

#### Inherited Members

[InterpolatingFramedClock.AllowableErrorMilliseconds](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_AllowableErrorMilliseconds), 
[InterpolatingFramedClock.IsInterpolating](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_IsInterpolating), 
[InterpolatingFramedClock.Drift](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_Drift), 
[InterpolatingFramedClock.Rate](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_Rate), 
[InterpolatingFramedClock.IsRunning](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_IsRunning), 
[InterpolatingFramedClock.ElapsedFrameTime](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_ElapsedFrameTime), 
[InterpolatingFramedClock.Source](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_Source), 
[InterpolatingFramedClock.FramedSourceClock](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_FramedSourceClock), 
[InterpolatingFramedClock.CurrentTime](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_CurrentTime), 
[InterpolatingFramedClock.ChangeSource\(IClock?\)](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_ChangeSource\_osu\_Framework\_Timing\_IClock\_), 
[InterpolatingFramedClock.ProcessFrame\(\)](osu.Framework.Timing.InterpolatingFramedClock.md\#osu\_Framework\_Timing\_InterpolatingFramedClock\_ProcessFrame), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DecoupleableInterpolatingFramedClock\>\(DecoupleableInterpolatingFramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DecoupleableInterpolatingFramedClock\>\(DecoupleableInterpolatingFramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DecoupleableInterpolatingFramedClock\>\(DecoupleableInterpolatingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DecoupleableInterpolatingFramedClock\>\(DecoupleableInterpolatingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DecoupleableInterpolatingFramedClock, TChild\>\(DecoupleableInterpolatingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DecoupleableInterpolatingFramedClock, TChild\>\(DecoupleableInterpolatingFramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DecoupleableInterpolatingFramedClock, TChild\>\(DecoupleableInterpolatingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DecoupleableInterpolatingFramedClock\>\(DecoupleableInterpolatingFramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock__ctor"></a> DecoupleableInterpolatingFramedClock\(\)

```csharp
public DecoupleableInterpolatingFramedClock()
```

## Fields

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_IsCoupled"></a> IsCoupled

Specify whether we are coupled 1:1 to SourceClock. If not, we can independently continue operation.

```csharp
public bool IsCoupled
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public override double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_ElapsedFrameTime"></a> ElapsedFrameTime

Elapsed time since last frame in milliseconds.

```csharp
public override double ElapsedFrameTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public override bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_ProposedCurrentTime"></a> ProposedCurrentTime

```csharp
public double ProposedCurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_ProposedElapsedTime"></a> ProposedElapsedTime

```csharp
public double ProposedElapsedTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
public double Rate { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_ChangeSource_osu_Framework_Timing_IClock_"></a> ChangeSource\(IClock?\)

Change the source clock.

```csharp
public override void ChangeSource(IClock? source)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)?

The new source clock.

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public override void ProcessFrame()
```

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_Reset"></a> Reset\(\)

Stop and reset position.

```csharp
public void Reset()
```

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_ResetSpeedAdjustments"></a> ResetSpeedAdjustments\(\)

Reset the rate to a stable value.

```csharp
public void ResetSpeedAdjustments()
```

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
public bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_Start"></a> Start\(\)

Start (resume) running.

```csharp
public void Start()
```

### <a id="osu_Framework_Timing_DecoupleableInterpolatingFramedClock_Stop"></a> Stop\(\)

Stop (pause) running.

```csharp
public void Stop()
```

