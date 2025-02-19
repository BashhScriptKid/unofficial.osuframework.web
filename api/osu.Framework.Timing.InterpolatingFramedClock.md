# <a id="osu_Framework_Timing_InterpolatingFramedClock"></a> Class InterpolatingFramedClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A clock which uses an internal stopwatch to interpolate (smooth out) a source.

```csharp
public class InterpolatingFramedClock : IFrameBasedClock, ISourceChangeableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InterpolatingFramedClock](osu.Framework.Timing.InterpolatingFramedClock.md)

#### Derived

[DecoupleableInterpolatingFramedClock](osu.Framework.Timing.DecoupleableInterpolatingFramedClock.md), 
[InterpolatingFramedClockTest.TestInterpolatingFramedClock](osu.Framework.Tests.Clocks.InterpolatingFramedClockTest.TestInterpolatingFramedClock.md)

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

[ObjectExtensions.AsNonNull<InterpolatingFramedClock\>\(InterpolatingFramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InterpolatingFramedClock\>\(InterpolatingFramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InterpolatingFramedClock\>\(InterpolatingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InterpolatingFramedClock\>\(InterpolatingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InterpolatingFramedClock, TChild\>\(InterpolatingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InterpolatingFramedClock, TChild\>\(InterpolatingFramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InterpolatingFramedClock, TChild\>\(InterpolatingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InterpolatingFramedClock\>\(InterpolatingFramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Timing_InterpolatingFramedClock__ctor_osu_Framework_Timing_IFrameBasedClock_"></a> InterpolatingFramedClock\(IFrameBasedClock?\)

```csharp
public InterpolatingFramedClock(IFrameBasedClock? source = null)
```

#### Parameters

`source` [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)?

## Fields

### <a id="osu_Framework_Timing_InterpolatingFramedClock_FramedSourceClock"></a> FramedSourceClock

```csharp
protected IFrameBasedClock FramedSourceClock
```

#### Field Value

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

## Properties

### <a id="osu_Framework_Timing_InterpolatingFramedClock_AllowableErrorMilliseconds"></a> AllowableErrorMilliseconds

The amount of error that is allowed between the source and interpolated time before the interpolated time is ignored and the source time is used.

```csharp
public virtual double AllowableErrorMilliseconds { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_InterpolatingFramedClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public virtual double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_InterpolatingFramedClock_Drift"></a> Drift

The drift in milliseconds between the source and interpolation at the last processed frame.

```csharp
public double Drift { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_InterpolatingFramedClock_ElapsedFrameTime"></a> ElapsedFrameTime

Elapsed time since last frame in milliseconds.

```csharp
public virtual double ElapsedFrameTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_InterpolatingFramedClock_IsInterpolating"></a> IsInterpolating

Whether interpolation was applied at the last processed frame.

```csharp
public bool IsInterpolating { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

If <xref href="osu.Framework.Timing.InterpolatingFramedClock.Drift" data-throw-if-not-resolved="false"></xref> becomes too high (as defined by <xref href="osu.Framework.Timing.InterpolatingFramedClock.AllowableErrorMilliseconds" data-throw-if-not-resolved="false"></xref>),
interpolation will be bypassed in order to provide a more correct time value.

### <a id="osu_Framework_Timing_InterpolatingFramedClock_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public virtual bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Timing_InterpolatingFramedClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
public virtual double Rate { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_InterpolatingFramedClock_Source"></a> Source

The source clock.

```csharp
public IClock Source { get; }
```

#### Property Value

 [IClock](osu.Framework.Timing.IClock.md)

## Methods

### <a id="osu_Framework_Timing_InterpolatingFramedClock_ChangeSource_osu_Framework_Timing_IClock_"></a> ChangeSource\(IClock?\)

Change the source clock.

```csharp
public virtual void ChangeSource(IClock? source)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)?

The new source clock.

### <a id="osu_Framework_Timing_InterpolatingFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public virtual void ProcessFrame()
```

