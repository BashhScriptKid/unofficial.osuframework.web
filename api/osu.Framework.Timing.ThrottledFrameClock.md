# <a id="osu_Framework_Timing_ThrottledFrameClock"></a> Class ThrottledFrameClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A FrameClock which will limit the number of frames processed by adding Thread.Sleep calls on each ProcessFrame.

```csharp
public class ThrottledFrameClock : FramedClock, IFrameBasedClock, ISourceChangeableClock, IClock, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FramedClock](osu.Framework.Timing.FramedClock.md) ← 
[ThrottledFrameClock](osu.Framework.Timing.ThrottledFrameClock.md)

#### Implements

[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md), 
[IClock](osu.Framework.Timing.IClock.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[FramedClock.Source](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_Source), 
[FramedClock.FramesPerSecond](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_FramesPerSecond), 
[FramedClock.Jitter](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_Jitter), 
[FramedClock.CurrentTime](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_CurrentTime), 
[FramedClock.LastFrameTime](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_LastFrameTime), 
[FramedClock.Rate](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_Rate), 
[FramedClock.SourceTime](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_SourceTime), 
[FramedClock.ElapsedFrameTime](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_ElapsedFrameTime), 
[FramedClock.IsRunning](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_IsRunning), 
[FramedClock.ChangeSource\(IClock\)](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_ChangeSource\_osu\_Framework\_Timing\_IClock\_), 
[FramedClock.ProcessFrame\(\)](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_ProcessFrame), 
[FramedClock.ToString\(\)](osu.Framework.Timing.FramedClock.md\#osu\_Framework\_Timing\_FramedClock\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ThrottledFrameClock\>\(ThrottledFrameClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ThrottledFrameClock\>\(ThrottledFrameClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ThrottledFrameClock\>\(ThrottledFrameClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ThrottledFrameClock\>\(ThrottledFrameClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ThrottledFrameClock, TChild\>\(ThrottledFrameClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ThrottledFrameClock, TChild\>\(ThrottledFrameClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ThrottledFrameClock, TChild\>\(ThrottledFrameClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ThrottledFrameClock\>\(ThrottledFrameClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Timing_ThrottledFrameClock_MaximumUpdateHz"></a> MaximumUpdateHz

The target number of updates per second. Only used when <xref href="osu.Framework.Timing.ThrottledFrameClock.Throttling" data-throw-if-not-resolved="false"></xref> is <code>true</code>.

```csharp
public double MaximumUpdateHz
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A value of 0 is treated the same as "unlimited" or <xref href="System.Double.MaxValue" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Timing_ThrottledFrameClock_Throttling"></a> Throttling

Whether throttling should be enabled. Defaults to <code>true</code>.

```csharp
public bool Throttling
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Timing_ThrottledFrameClock_TimeSlept"></a> TimeSlept

The time spent in a Thread.Sleep state during the last frame.

```csharp
public double TimeSlept { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Timing_ThrottledFrameClock_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Timing_ThrottledFrameClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public override void ProcessFrame()
```

