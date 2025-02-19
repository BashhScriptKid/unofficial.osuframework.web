# <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock"></a> Class LaggyFramedClock

Namespace: [osu.Framework.Tests.Visual.Clocks](osu.Framework.Tests.Visual.Clocks.md)  
Assembly: osu.Framework.Tests.dll, osu.Framework.Tests.Android.dll  

```csharp
public class LaggyFramedClock : FramedClock, IFrameBasedClock, ISourceChangeableClock, IClock
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FramedClock](osu.Framework.Timing.FramedClock.md) ← 
[LaggyFramedClock](osu.Framework.Tests.Visual.Clocks.LaggyFramedClock.md)

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

[ObjectExtensions.AsNonNull<LaggyFramedClock\>\(LaggyFramedClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LaggyFramedClock\>\(LaggyFramedClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LaggyFramedClock\>\(LaggyFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LaggyFramedClock\>\(LaggyFramedClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LaggyFramedClock, TChild\>\(LaggyFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LaggyFramedClock, TChild\>\(LaggyFramedClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LaggyFramedClock, TChild\>\(LaggyFramedClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LaggyFramedClock\>\(LaggyFramedClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock__ctor_System_Int32_osu_Framework_Timing_IClock_"></a> LaggyFramedClock\(int, IClock?\)

```csharp
public LaggyFramedClock(int frameSkip, IClock? source = null)
```

#### Parameters

`frameSkip` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`source` [IClock](osu.Framework.Timing.IClock.md)?

### <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock__ctor_System_Int32_osu_Framework_Timing_IClock_"></a> LaggyFramedClock\(int, IClock?\)

```csharp
public LaggyFramedClock(int frameSkip, IClock? source = null)
```

#### Parameters

`frameSkip` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`source` IClock?

### <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock__ctor_System_Int32_osu_Framework_Timing_IClock_"></a> LaggyFramedClock\(int, IClock?\)

```csharp
public LaggyFramedClock(int frameSkip, IClock? source = null)
```

#### Parameters

`frameSkip` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`source` IClock?

## Methods

### <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public override void ProcessFrame()
```

### <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public override void ProcessFrame()
```

### <a id="osu_Framework_Tests_Visual_Clocks_LaggyFramedClock_ProcessFrame"></a> ProcessFrame\(\)

Processes one frame. Generally should be run once per update loop.

```csharp
public override void ProcessFrame()
```

