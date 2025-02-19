# <a id="osu_Framework_Timing_IAdjustableClock"></a> Interface IAdjustableClock

Namespace: [osu.Framework.Timing](osu.Framework.Timing.md)  
Assembly: osu.Framework.dll  

A clock that can be started, stopped, reset etc.

```csharp
public interface IAdjustableClock : IClock
```

#### Implements

[IClock](osu.Framework.Timing.IClock.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IAdjustableClock\>\(IAdjustableClock?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IAdjustableClock\>\(IAdjustableClock\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IAdjustableClock\>\(IAdjustableClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IAdjustableClock\>\(IAdjustableClock\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IAdjustableClock, TChild\>\(IAdjustableClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IAdjustableClock, TChild\>\(IAdjustableClock, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IAdjustableClock, TChild\>\(IAdjustableClock, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IAdjustableClock\>\(IAdjustableClock\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Timing_IAdjustableClock_Rate"></a> Rate

The rate this clock is running at, relative to real-time.

```csharp
double Rate { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Timing_IAdjustableClock_Reset"></a> Reset\(\)

Stop and reset position.

```csharp
void Reset()
```

### <a id="osu_Framework_Timing_IAdjustableClock_ResetSpeedAdjustments"></a> ResetSpeedAdjustments\(\)

Reset the rate to a stable value.

```csharp
void ResetSpeedAdjustments()
```

### <a id="osu_Framework_Timing_IAdjustableClock_Seek_System_Double_"></a> Seek\(double\)

Seek to a specific time position.

```csharp
bool Seek(double position)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a seek was possible.

### <a id="osu_Framework_Timing_IAdjustableClock_Start"></a> Start\(\)

Start (resume) running.

```csharp
void Start()
```

### <a id="osu_Framework_Timing_IAdjustableClock_Stop"></a> Stop\(\)

Stop (pause) running.

```csharp
void Stop()
```

