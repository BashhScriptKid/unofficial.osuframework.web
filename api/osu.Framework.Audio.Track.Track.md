# <a id="osu_Framework_Audio_Track_Track"></a> Class Track

Namespace: [osu.Framework.Audio.Track](osu.Framework.Audio.Track.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Track : AdjustableAudioComponent, IDisposable, IUpdateable, ITrack, IAdjustableClock, IClock, IHasAmplitudes, IAdjustableAudioComponent, IAggregateAudioAdjustment, IAudioChannel
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md) ← 
[Track](osu.Framework.Audio.Track.Track.md)

#### Derived

[TrackBass](osu.Framework.Audio.Track.TrackBass.md), 
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

[AdjustableAudioComponent.Adjustments](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Adjustments), 
[AdjustableAudioComponent.Volume](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Volume), 
[AdjustableAudioComponent.Balance](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Balance), 
[AdjustableAudioComponent.Frequency](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Frequency), 
[AdjustableAudioComponent.Tempo](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Tempo), 
[AdjustableAudioComponent.AddAdjustment\(AdjustableProperty, IBindable<double\>\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AddAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_osu\_Framework\_Bindables\_IBindable\_System\_Double\_\_), 
[AdjustableAudioComponent.RemoveAdjustment\(AdjustableProperty, IBindable<double\>\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_RemoveAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_osu\_Framework\_Bindables\_IBindable\_System\_Double\_\_), 
[AdjustableAudioComponent.RemoveAllAdjustments\(AdjustableProperty\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_RemoveAllAdjustments\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[AdjustableAudioComponent.UpdateState\(\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_UpdateState), 
[AdjustableAudioComponent.BindAdjustments\(IAggregateAudioAdjustment\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_BindAdjustments\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_), 
[AdjustableAudioComponent.UnbindAdjustments\(IAggregateAudioAdjustment\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_UnbindAdjustments\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_), 
[AdjustableAudioComponent.AggregateVolume](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateVolume), 
[AdjustableAudioComponent.AggregateBalance](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateBalance), 
[AdjustableAudioComponent.AggregateFrequency](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateFrequency), 
[AdjustableAudioComponent.AggregateTempo](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_AggregateTempo), 
[AdjustableAudioComponent.Dispose\(bool\)](osu.Framework.Audio.AdjustableAudioComponent.md\#osu\_Framework\_Audio\_AdjustableAudioComponent\_Dispose\_System\_Boolean\_), 
[AudioComponent.PendingActions](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_PendingActions), 
[AudioComponent.CanPerformInline](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_CanPerformInline), 
[AudioComponent.EnqueueAction\(Action\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_EnqueueAction\_System\_Action\_), 
[AudioComponent.UpdateState\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_UpdateState), 
[AudioComponent.UpdateChildren\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_UpdateChildren), 
[AudioComponent.Update\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Update), 
[AudioComponent.HasCompleted](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_HasCompleted), 
[AudioComponent.IsAlive](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsAlive), 
[AudioComponent.IsLoaded](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsLoaded), 
[AudioComponent.IsDisposed](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsDisposed), 
[AudioComponent.Dispose\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Dispose), 
[AudioComponent.Dispose\(bool\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Track\>\(Track?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Track\>\(Track\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Track\>\(Track\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Track\>\(Track\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Track, TChild\>\(Track, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Track, TChild\>\(Track, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Track, TChild\>\(Track, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Track\>\(Track\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Track_Track__ctor_System_String_"></a> Track\(string\)

```csharp
protected Track(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_Audio_Track_Track_Bitrate"></a> Bitrate

The bitrate of this track.

```csharp
public virtual int? Bitrate { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="osu_Framework_Audio_Track_Track_CurrentAmplitudes"></a> CurrentAmplitudes

Current amplitude of stereo channels where 1 is full volume and 0 is silent.
LeftChannel and RightChannel represent the maximum current amplitude of all of the left and right channels respectively.
The most recent values are returned. Synchronisation between channels should not be expected.

```csharp
public virtual ChannelAmplitudes CurrentAmplitudes { get; }
```

#### Property Value

 [ChannelAmplitudes](osu.Framework.Audio.Track.ChannelAmplitudes.md)

### <a id="osu_Framework_Audio_Track_Track_CurrentTime"></a> CurrentTime

Current position in milliseconds.

```csharp
public abstract double CurrentTime { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Track_Track_HasCompleted"></a> HasCompleted

Whether this component has completed playback and is in a stopped state.

```csharp
public override bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_Track_IsDummyDevice"></a> IsDummyDevice

Is this track capable of producing audio?

```csharp
public virtual bool IsDummyDevice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_Track_IsReversed"></a> IsReversed

Whether this track is reversed.

```csharp
public bool IsReversed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_Track_IsRunning"></a> IsRunning

Whether this clock is currently running or not.

```csharp
public abstract bool IsRunning { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_Track_Length"></a> Length

Length of the track in milliseconds.

```csharp
public double Length { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Track_Track_Looping"></a> Looping

States if this track should repeat.

```csharp
public virtual bool Looping { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_Track_Mixer"></a> Mixer

```csharp
protected virtual AudioMixer? Mixer { get; set; }
```

#### Property Value

 [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)?

### <a id="osu_Framework_Audio_Track_Track_Name"></a> Name

A name identifying this sample internally.

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Audio_Track_Track_Rate"></a> Rate

Overall playback rate (1 is 100%, -1 is reversed at 100%).

```csharp
public virtual double Rate { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Track_Track_RestartPoint"></a> RestartPoint

Point in time in milliseconds to restart the track to on loop or <xref href="osu.Framework.Audio.Track.ITrack.Restart" data-throw-if-not-resolved="false"></xref>.

```csharp
public double RestartPoint { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Audio_Track_Track_RaiseCompleted"></a> RaiseCompleted\(\)

```csharp
protected void RaiseCompleted()
```

### <a id="osu_Framework_Audio_Track_Track_RaiseFailed"></a> RaiseFailed\(\)

```csharp
protected void RaiseFailed()
```

### <a id="osu_Framework_Audio_Track_Track_Reset"></a> Reset\(\)

Reset this track to a logical default state.

```csharp
public virtual void Reset()
```

### <a id="osu_Framework_Audio_Track_Track_ResetSpeedAdjustments"></a> ResetSpeedAdjustments\(\)

Reset the rate to a stable value.

```csharp
public virtual void ResetSpeedAdjustments()
```

### <a id="osu_Framework_Audio_Track_Track_Restart"></a> Restart\(\)

Restarts this track from the <xref href="osu.Framework.Audio.Track.Track.RestartPoint" data-throw-if-not-resolved="false"></xref> while retaining adjustments.

```csharp
public void Restart()
```

### <a id="osu_Framework_Audio_Track_Track_RestartAsync"></a> RestartAsync\(\)

```csharp
public Task RestartAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Audio_Track_Track_Seek_System_Double_"></a> Seek\(double\)

Seek to a new position.

```csharp
public abstract bool Seek(double seek)
```

#### Parameters

`seek` [double](https://learn.microsoft.com/dotnet/api/system.double)

New position in milliseconds

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the seek was successful.

### <a id="osu_Framework_Audio_Track_Track_SeekAsync_System_Double_"></a> SeekAsync\(double\)

```csharp
public abstract Task<bool> SeekAsync(double seek)
```

#### Parameters

`seek` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="osu_Framework_Audio_Track_Track_Start"></a> Start\(\)

Start (resume) running.

```csharp
public abstract void Start()
```

### <a id="osu_Framework_Audio_Track_Track_StartAsync"></a> StartAsync\(\)

```csharp
public abstract Task StartAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Audio_Track_Track_Stop"></a> Stop\(\)

Stop (pause) running.

```csharp
public abstract void Stop()
```

### <a id="osu_Framework_Audio_Track_Track_StopAsync"></a> StopAsync\(\)

```csharp
public abstract Task StopAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Audio_Track_Track_UpdateState"></a> UpdateState\(\)

Run each loop of the audio thread's execution after queued actions are completed to allow components to perform any additional operations.

```csharp
protected override void UpdateState()
```

### <a id="osu_Framework_Audio_Track_Track_Completed"></a> Completed

Invoked when this track has completed.

```csharp
public event Action? Completed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

### <a id="osu_Framework_Audio_Track_Track_Failed"></a> Failed

Invoked when this track has failed.

```csharp
public event Action? Failed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

