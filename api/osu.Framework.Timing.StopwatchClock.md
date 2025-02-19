# <a id="osu_Framework_Timing_StopwatchClock"></a> Class StopwatchClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

```csharp
public class StopwatchClock : Stopwatch, IAdjustableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Stopwatch](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch) ← 
[StopwatchClock](osu.Framework.Timing.StopwatchClock.md)

#### Derived

[TestStopwatchClockWithRangeLimit](osu.Framework.Tests.Clocks.TestStopwatchClockWithRangeLimit.md)

#### Implements

[IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md), 
[IClock](osu.Framework.Timing.IClock.md)

#### Inherited Members

[Stopwatch.Frequency](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.frequency), 
[Stopwatch.IsHighResolution](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.ishighresolution), 
[Stopwatch.GetTimestamp\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.gettimestamp), 
[Stopwatch.GetElapsedTime\(long\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.getelapsedtime\#system\-diagnostics\-stopwatch\-getelapsedtime\(system\-int64\)), 
[Stopwatch.GetElapsedTime\(long, long\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.getelapsedtime\#system\-diagnostics\-stopwatch\-getelapsedtime\(system\-int64\-system\-int64\)), 
[Stopwatch.Reset\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.reset), 
[Stopwatch.Restart\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.restart), 
[Stopwatch.Start\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.start), 
[Stopwatch.StartNew\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.startnew), 
[Stopwatch.Stop\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.stop), 
[Stopwatch.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.tostring), 
[Stopwatch.Elapsed](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.elapsed), 
[Stopwatch.ElapsedMilliseconds](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.elapsedmilliseconds), 
[Stopwatch.ElapsedTicks](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.elapsedticks), 
[Stopwatch.IsRunning](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch.isrunning), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<StopwatchClock\>\(StopwatchClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<StopwatchClock\>\(StopwatchClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<StopwatchClock\>\(StopwatchClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<StopwatchClock\>\(StopwatchClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<StopwatchClock, TChild\>\(StopwatchClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<StopwatchClock, TChild\>\(StopwatchClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<StopwatchClock, TChild\>\(StopwatchClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<StopwatchClock\>\(StopwatchClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Timing_StopwatchClock__ctor_System_Boolean_"></a> StopwatchClock\(bool\)

```csharp
public StopwatchClock(bool start = false)
```

#### Parameters

`start` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Timing_StopwatchClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public virtual double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_StopwatchClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
public double Rate { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Timing_StopwatchClock_Reset"></a> Reset\(\)

Stop and reset position.

```csharp
public void Reset()
```

### <a id="osu_Framework_Timing_StopwatchClock_ResetSpeedAdjustments"></a> ResetSpeedAdjustments\(\)

Reset the rate to a stable value.

```csharp
public void ResetSpeedAdjustments()
```

### <a id="osu_Framework_Timing_StopwatchClock_Restart"></a> Restart\(\)

```csharp
public void Restart()
```

### <a id="osu_Framework_Timing_StopwatchClock_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
public virtual bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

### <a id="osu_Framework_Timing_StopwatchClock_ToString"></a> ToString\(\)

Returns the <xref href="System.Diagnostics.Stopwatch.Elapsed" data-throw-if-not-resolved="false"></xref> time as a string.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The elapsed time string in the same format used by <xref href="System.TimeSpan.ToString" data-throw-if-not-resolved="false"></xref>.

