# <a id="osu_Framework_Timing_FramedOffsetClock"></a> Class FramedOffsetClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A framed clock which allows an offset to be added or subtracted from an underlying source clock's time.

```csharp
public class FramedOffsetClock : FramedClock, IFrameBasedClock, ISourceChangeableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FramedClock](osu.Framework.Timing.FramedClock.md) ← 
[FramedOffsetClock](osu.Framework.Timing.FramedOffsetClock.md)

#### Implements

[IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md), 
[ISourceChangeableClock](osu.Framework.Timing.ISourceChangeableClock.md), 
[IClock](osu.Framework.Timing.IClock.md)

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

[ObjectExtensions.AsNonNull<FramedOffsetClock\>\(FramedOffsetClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FramedOffsetClock\>\(FramedOffsetClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FramedOffsetClock\>\(FramedOffsetClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FramedOffsetClock\>\(FramedOffsetClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FramedOffsetClock, TChild\>\(FramedOffsetClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FramedOffsetClock, TChild\>\(FramedOffsetClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FramedOffsetClock, TChild\>\(FramedOffsetClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FramedOffsetClock\>\(FramedOffsetClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Timing_FramedOffsetClock__ctor_osu_Framework_Timing_IClock_System_Boolean_"></a> FramedOffsetClock\(IClock?, bool\)

```csharp
public FramedOffsetClock(IClock? source, bool processSource = true)
```

#### Parameters

`source` [IClock](osu.Framework.Timing.IClock.md)?

`processSource` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Timing_FramedOffsetClock_CurrentTime"></a> CurrentTime

The current time of this clock, in milliseconds.

```csharp
public override double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Timing_FramedOffsetClock_Offset"></a> Offset

The offset to be applied.

```csharp
public double Offset { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

A positive offset will move time forward.

