# <a id="osu_Framework_Audio_Track_TrackVirtual"></a> Class TrackVirtual

Namespace: [osu.Framework.Audio.Track](osu.Framework.Audio.Track.md)  
Assembly: osu.Framework.dll  

```csharp
public sealed class TrackVirtual : Track, IDisposable, IUpdateable, ITrack, IAdjustableClock, IClock, IHasAmplitudes, IAdjustableAudioComponent, IAggregateAudioAdjustment, IAudioChannel
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md) ← 
[Track](osu.Framework.Audio.Track.Track.md) ← 
[TrackVirtual](osu.Framework.Audio.Track.TrackVirtual.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md), 
[ITrack](osu.Framework.Audio.Track.ITrack.md), 
[IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md), 
[IClock](osu.Framework.Timing.IClock.md), 
[IHasAmplitudes](osu.Framework.Audio.IHasAmplitudes.md), 
[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md), 
[IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

#### Inherited Members

[Track.Completed](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Completed), 
[Track.Failed](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Failed), 
[Track.IsDummyDevice](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_IsDummyDevice), 
[Track.RestartPoint](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_RestartPoint), 
[Track.Looping](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Looping), 
[Track.Name](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Name), 
[Track.Reset\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Reset), 
[Track.Restart\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Restart), 
[Track.RestartAsync\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_RestartAsync), 
[Track.ResetSpeedAdjustments\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_ResetSpeedAdjustments), 
[Track.CurrentTime](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_CurrentTime), 
[Track.Length](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Length), 
[Track.Bitrate](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Bitrate), 
[Track.Seek\(double\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Seek\_System\_Double\_), 
[Track.SeekAsync\(double\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_SeekAsync\_System\_Double\_), 
[Track.StartAsync\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_StartAsync), 
[Track.Start\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Start), 
[Track.StopAsync\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_StopAsync), 
[Track.Stop\(\)](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Stop), 
[Track.IsRunning](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_IsRunning), 
[Track.Rate](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_Rate), 
[Track.IsReversed](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_IsReversed), 
[Track.HasCompleted](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_HasCompleted), 
[Track.CurrentAmplitudes](osu.Framework.Audio.Track.Track.md\#osu\_Framework\_Audio\_Track\_Track\_CurrentAmplitudes), 
[AdjustableAudioComponent.Volume](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Volume), 
[AdjustableAudioComponent.Balance](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Balance), 
[AdjustableAudioComponent.Frequency](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Frequency), 
[AdjustableAudioComponent.Tempo](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Tempo), 
[AdjustableAudioComponent.AddAdjustment\(AdjustableProperty, IBindable<double\>\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AddAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_osu\_Framework\_Bindables\_IBindable\_System\_Double\_\_), 
[AdjustableAudioComponent.RemoveAdjustment\(AdjustableProperty, IBindable<double\>\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_RemoveAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_osu\_Framework\_Bindables\_IBindable\_System\_Double\_\_), 
[AdjustableAudioComponent.RemoveAllAdjustments\(AdjustableProperty\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_RemoveAllAdjustments\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[AdjustableAudioComponent.BindAdjustments\(IAggregateAudioAdjustment\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_BindAdjustments\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_), 
[AdjustableAudioComponent.UnbindAdjustments\(IAggregateAudioAdjustment\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_UnbindAdjustments\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_), 
[AdjustableAudioComponent.AggregateVolume](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateVolume), 
[AdjustableAudioComponent.AggregateBalance](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateBalance), 
[AdjustableAudioComponent.AggregateFrequency](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateFrequency), 
[AdjustableAudioComponent.AggregateTempo](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateTempo), 
[AudioComponent.Update\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Update), 
[AudioComponent.HasCompleted](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_HasCompleted), 
[AudioComponent.IsAlive](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsAlive), 
[AudioComponent.IsLoaded](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsLoaded), 
[AudioComponent.Dispose\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TrackVirtual\>\(TrackVirtual?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TrackVirtual\>\(TrackVirtual\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TrackVirtual\>\(TrackVirtual\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TrackVirtual\>\(TrackVirtual\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TrackVirtual, TChild\>\(TrackVirtual, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TrackVirtual, TChild\>\(TrackVirtual, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TrackVirtual, TChild\>\(TrackVirtual, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TrackVirtual\>\(TrackVirtual\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Track_TrackVirtual__ctor_System_Double_System_String_"></a> TrackVirtual\(double, string\)

```csharp
public TrackVirtual(double length, string name = "virtual")
```

#### Parameters

`length` [double](https://learn.microsoft.com/dotnet/api/system.double)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_Audio_Track_TrackVirtual_CurrentTime"></a> CurrentTime

Current position in milliseconds.

```csharp
public override double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Track_TrackVirtual_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public override bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Audio_Track_TrackVirtual_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_TrackVirtual_Reset"></a> Reset\(\)

Reset this track to a logical default state.

```csharp
public override void Reset()
```

### <a id="osu_Framework_Audio_Track_TrackVirtual_Seek_System_Double_"></a> Seek\(double\)

Seek to a new position.

```csharp
public override bool Seek(double seek)
```

#### Parameters

`seek` [double](https://learn.microsoft.com/dotnet/api/system.double)

New position in milliseconds

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the seek was successful.

### <a id="osu_Framework_Audio_Track_TrackVirtual_SeekAsync_System_Double_"></a> SeekAsync\(double\)

```csharp
public override Task<bool> SeekAsync(double seek)
```

#### Parameters

`seek` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Audio_Track_TrackVirtual_Start"></a> Start\(\)

Start (resume) running.

```csharp
public override void Start()
```

### <a id="osu_Framework_Audio_Track_TrackVirtual_StartAsync"></a> StartAsync\(\)

```csharp
public override Task StartAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Audio_Track_TrackVirtual_Stop"></a> Stop\(\)

Stop (pause) running.

```csharp
public override void Stop()
```

### <a id="osu_Framework_Audio_Track_TrackVirtual_StopAsync"></a> StopAsync\(\)

```csharp
public override Task StopAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Audio_Track_TrackVirtual_UpdateState"></a> UpdateState\(\)

Run each loop of the audio thread's execution after queued actions are completed to allow components to perform any additional operations.

```csharp
protected override void UpdateState()
```

