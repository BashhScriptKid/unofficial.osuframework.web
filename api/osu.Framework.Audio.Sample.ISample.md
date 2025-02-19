# <a id="osu_Framework_Audio_Sample_ISample"></a> Interface ISample

Namespace: [osu.Framework.Audio.Sample](osu.Framework.Audio.Sample.md)  
Assembly: osu.Framework.dll  

An interface for an audio sample.

```csharp
public interface ISample : IAdjustableAudioComponent, IAggregateAudioAdjustment
```

#### Implements

[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ISample\>\(ISample?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ISample\>\(ISample\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ISample\>\(ISample\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ISample\>\(ISample\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ISample, TChild\>\(ISample, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ISample, TChild\>\(ISample, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ISample, TChild\>\(ISample, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ISample\>\(ISample\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_Sample_ISample_Length"></a> Length

The length in milliseconds of this <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref>.

```csharp
double Length { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Sample_ISample_Name"></a> Name

A name identifying this sample internally.

```csharp
string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Audio_Sample_ISample_PlaybackConcurrency"></a> PlaybackConcurrency

The number of times this sample (as identified by name) can be played back concurrently.

```csharp
Bindable<int> PlaybackConcurrency { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

#### Remarks

This affects all <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref> instances identified by the same sample name.

## Methods

### <a id="osu_Framework_Audio_Sample_ISample_GetChannel"></a> GetChannel\(\)

Retrieves a unique playback channel for this <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref>.

```csharp
SampleChannel GetChannel()
```

#### Returns

 [SampleChannel](osu.Framework.Audio.Sample.SampleChannel.md)

The unique <xref href="osu.Framework.Audio.Sample.SampleChannel" data-throw-if-not-resolved="false"></xref> for the playback.

#### Remarks

Multiple channels can be retrieved and played simultaneously, but can only be heard up to <xref href="osu.Framework.Audio.Sample.ISample.PlaybackConcurrency" data-throw-if-not-resolved="false"></xref> times.

### <a id="osu_Framework_Audio_Sample_ISample_Play"></a> Play\(\)

Creates a new unique playback channel for this <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref> and immediately plays it.

```csharp
SampleChannel Play()
```

#### Returns

 [SampleChannel](osu.Framework.Audio.Sample.SampleChannel.md)

The unique <xref href="osu.Framework.Audio.Sample.SampleChannel" data-throw-if-not-resolved="false"></xref> for the playback.

#### Remarks

Multiple channels can be played simultaneously, but can only be heard up to <xref href="osu.Framework.Audio.Sample.ISample.PlaybackConcurrency" data-throw-if-not-resolved="false"></xref> times.

