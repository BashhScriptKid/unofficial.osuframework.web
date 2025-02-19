# <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock"></a> Class InterpolatingFramedClockTest.TestInterpolatingFramedClock

Namespace: [osu.Framework.Tests.Clocks](osu.Framework.Tests.Clocks.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class InterpolatingFramedClockTest.TestInterpolatingFramedClock : InterpolatingFramedClock, IFrameBasedClock, ISourceChangeableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InterpolatingFramedClock](osu.Framework.Timing.InterpolatingFramedClock.md) ← 
[InterpolatingFramedClockTest.TestInterpolatingFramedClock](osu.Framework.Tests.Clocks.InterpolatingFramedClockTest.TestInterpolatingFramedClock.md)

#### Implements

[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md), 
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

[ObjectExtensions.AsNonNull<InterpolatingFramedClockTest.TestInterpolatingFramedClock\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InterpolatingFramedClockTest.TestInterpolatingFramedClock\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InterpolatingFramedClockTest.TestInterpolatingFramedClock\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InterpolatingFramedClockTest.TestInterpolatingFramedClock\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InterpolatingFramedClockTest.TestInterpolatingFramedClock, TChild\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InterpolatingFramedClockTest.TestInterpolatingFramedClock, TChild\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InterpolatingFramedClockTest.TestInterpolatingFramedClock, TChild\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InterpolatingFramedClockTest.TestInterpolatingFramedClock\>\(InterpolatingFramedClockTest.TestInterpolatingFramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock_AllowableErrorMilliseconds"></a> AllowableErrorMilliseconds

The amount of error that is allowed between the source and interpolated time before the interpolated time is ignored and the source time is used.

```csharp
public override double AllowableErrorMilliseconds { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock_AllowableErrorMilliseconds"></a> AllowableErrorMilliseconds

The amount of error that is allowed between the source and interpolated time before the interpolated time is ignored and the source time is used.

```csharp
public override double AllowableErrorMilliseconds { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock_AllowableErrorMilliseconds"></a> AllowableErrorMilliseconds

The amount of error that is allowed between the source and interpolated time before the interpolated time is ignored and the source time is used.

```csharp
public override double AllowableErrorMilliseconds { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock_CustomErrorMilliseconds"></a> CustomErrorMilliseconds

```csharp
public double? CustomErrorMilliseconds { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock_CustomErrorMilliseconds"></a> CustomErrorMilliseconds

```csharp
public double? CustomErrorMilliseconds { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="osu_Framework_Tests_Clocks_InterpolatingFramedClockTest_TestInterpolatingFramedClock_CustomErrorMilliseconds"></a> CustomErrorMilliseconds

```csharp
public double? CustomErrorMilliseconds { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

