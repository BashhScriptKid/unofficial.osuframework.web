# <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit"></a> Class TestStopwatchClockWithRangeLimit

Namespace: [osu.Framework.Tests.Clocks](osu.Framework.Tests.Clocks.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class TestStopwatchClockWithRangeLimit : StopwatchClock, IAdjustableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Stopwatch](https://learn.microsoft.com/dotnet/api/system.diagnostics.stopwatch) ← 
[StopwatchClock](osu.Framework.Timing.StopwatchClock.md) ← 
[TestStopwatchClockWithRangeLimit](osu.Framework.Tests.Clocks.TestStopwatchClockWithRangeLimit.md)

#### Implements

[IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md), 
[IClock](osu.Framework.Timing.IClock.md)

#### Inherited Members

[StopwatchClock.CurrentTime](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_CurrentTime), 
[StopwatchClock.Rate](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_Rate), 
[StopwatchClock.Reset\(\)](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_Reset), 
[StopwatchClock.Restart\(\)](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_Restart), 
[StopwatchClock.ResetSpeedAdjustments\(\)](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_ResetSpeedAdjustments), 
[StopwatchClock.Seek\(double\)](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_Seek\_System\_Double\_), 
[StopwatchClock.ToString\(\)](osu.Framework.Timing.StopwatchClock.md\#osu\_Framework\_Timing\_StopwatchClock\_ToString), 
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

[ObjectExtensions.AsNonNull<TestStopwatchClockWithRangeLimit\>\(TestStopwatchClockWithRangeLimit?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TestStopwatchClockWithRangeLimit\>\(TestStopwatchClockWithRangeLimit\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TestStopwatchClockWithRangeLimit\>\(TestStopwatchClockWithRangeLimit\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TestStopwatchClockWithRangeLimit\>\(TestStopwatchClockWithRangeLimit\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TestStopwatchClockWithRangeLimit, TChild\>\(TestStopwatchClockWithRangeLimit, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TestStopwatchClockWithRangeLimit, TChild\>\(TestStopwatchClockWithRangeLimit, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TestStopwatchClockWithRangeLimit, TChild\>\(TestStopwatchClockWithRangeLimit, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TestStopwatchClockWithRangeLimit\>\(TestStopwatchClockWithRangeLimit\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit__ctor"></a> TestStopwatchClockWithRangeLimit\(\)

```csharp
public TestStopwatchClockWithRangeLimit()
```

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit__ctor"></a> TestStopwatchClockWithRangeLimit\(\)

```csharp
public TestStopwatchClockWithRangeLimit()
```

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit__ctor"></a> TestStopwatchClockWithRangeLimit\(\)

```csharp
public TestStopwatchClockWithRangeLimit()
```

## Properties

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public override double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public override double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public override double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_MaxTime"></a> MaxTime

```csharp
public double MaxTime { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_MaxTime"></a> MaxTime

```csharp
public double MaxTime { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_MaxTime"></a> MaxTime

```csharp
public double MaxTime { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_MinTime"></a> MinTime

```csharp
public double MinTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_MinTime"></a> MinTime

```csharp
public double MinTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_MinTime"></a> MinTime

```csharp
public double MinTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
public override bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
public override bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

### <a id="osu_Framework_Tests_Clocks_TestStopwatchClockWithRangeLimit_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
public override bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

