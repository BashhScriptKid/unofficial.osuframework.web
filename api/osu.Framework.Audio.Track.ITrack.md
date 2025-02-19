# <a id="osu_Framework_Audio_Track_ITrack"></a> Interface ITrack

Namespace: [osu.Framework.Audio.Track](osu.Framework.Audio.Track.md)  
Assembly: osu.Framework.dll  

An audio track.

```csharp
public interface ITrack : IAdjustableClock, IClock, IHasAmplitudes, IAdjustableAudioComponent, IAggregateAudioAdjustment
```

#### Implements

[IAdjustableClock](osu.Framework.Timing.IAdjustableClock.md), 
[IClock](osu.Framework.Timing.IClock.md), 
[IHasAmplitudes](osu.Framework.Audio.IHasAmplitudes.md), 
[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ITrack\>\(ITrack?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITrack\>\(ITrack\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITrack\>\(ITrack\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITrack\>\(ITrack\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITrack, TChild\>\(ITrack, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITrack, TChild\>\(ITrack, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITrack, TChild\>\(ITrack, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITrack\>\(ITrack\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_Track_ITrack_Bitrate"></a> Bitrate

The bitrate of this track.

```csharp
int? Bitrate { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="osu_Framework_Audio_Track_ITrack_HasCompleted"></a> HasCompleted

Whether this track has finished playing back.

```csharp
bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_ITrack_IsDummyDevice"></a> IsDummyDevice

Is this track capable of producing audio?

```csharp
bool IsDummyDevice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_ITrack_IsReversed"></a> IsReversed

Whether this track is reversed.

```csharp
bool IsReversed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_ITrack_Length"></a> Length

Length of the track in milliseconds.

```csharp
double Length { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Track_ITrack_Looping"></a> Looping

States if this track should repeat.

```csharp
bool Looping { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_ITrack_RestartPoint"></a> RestartPoint

Point in time in milliseconds to restart the track to on loop or <xref href="osu.Framework.Audio.Track.ITrack.Restart" data-throw-if-not-resolved="false"></xref>.

```csharp
double RestartPoint { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Audio_Track_ITrack_Restart"></a> Restart\(\)

Restarts this track from the <xref href="osu.Framework.Audio.Track.Track.RestartPoint" data-throw-if-not-resolved="false"></xref> while retaining adjustments.

```csharp
void Restart()
```

### <a id="osu_Framework_Audio_Track_ITrack_Completed"></a> Completed

Invoked when this track has completed.

```csharp
event Action Completed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

### <a id="osu_Framework_Audio_Track_ITrack_Failed"></a> Failed

Invoked when this track has failed.

```csharp
event Action Failed
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

