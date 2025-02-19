# <a id="osu_Framework_Audio_Sample_Sample"></a> Class Sample

Namespace: [osu.Framework.Audio.Sample](osu.Framework.Audio.Sample.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class Sample : AudioCollectionManager<SampleChannel>, IDisposable, IUpdateable, ISample, IAdjustableAudioComponent, IAggregateAudioAdjustment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md) ← 
[AudioCollectionManager<SampleChannel\>](osu.Framework.Audio.AudioCollectionManager\-1.md) ← 
[Sample](osu.Framework.Audio.Sample.Sample.md)

#### Derived

[SampleVirtual](osu.Framework.Audio.Sample.SampleVirtual.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md), 
[ISample](osu.Framework.Audio.Sample.ISample.md), 
[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Inherited Members

[AudioCollectionManager<SampleChannel\>.AddItem\(SampleChannel\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_AddItem\_\_0\_), 
[AudioCollectionManager<SampleChannel\>.UpdateChildren\(\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_UpdateChildren), 
[AudioCollectionManager<SampleChannel\>.ItemAdded\(SampleChannel\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_ItemAdded\_\_0\_), 
[AudioCollectionManager<SampleChannel\>.ItemRemoved\(SampleChannel\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_ItemRemoved\_\_0\_), 
[AudioCollectionManager<SampleChannel\>.Dispose\(bool\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_Dispose\_System\_Boolean\_), 
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

[ObjectExtensions.AsNonNull<Sample\>\(Sample?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Sample\>\(Sample\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Sample\>\(Sample\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Sample\>\(Sample\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Sample, TChild\>\(Sample, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Sample, TChild\>\(Sample, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Sample, TChild\>\(Sample, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Sample\>\(Sample\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Sample_Sample__ctor_System_String_"></a> Sample\(string\)

```csharp
protected Sample(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Fields

### <a id="osu_Framework_Audio_Sample_Sample_DEFAULT_CONCURRENCY"></a> DEFAULT\_CONCURRENCY

```csharp
public const int DEFAULT_CONCURRENCY = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Audio_Sample_Sample_IsAlive"></a> IsAlive

When false, this component has completed all processing and is ready to be removed from its parent.

```csharp
public override bool IsAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Sample_Sample_Length"></a> Length

The length in milliseconds of this <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref>.

```csharp
public double Length { get; protected set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Audio_Sample_Sample_Name"></a> Name

A name identifying this sample internally.

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Audio_Sample_Sample_PlaybackConcurrency"></a> PlaybackConcurrency

The number of times this sample (as identified by name) can be played back concurrently.

```csharp
public Bindable<int> PlaybackConcurrency { get; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

#### Remarks

This affects all <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref> instances identified by the same sample name.

## Methods

### <a id="osu_Framework_Audio_Sample_Sample_CreateChannel"></a> CreateChannel\(\)

Creates a unique playback of this <xref href="osu.Framework.Audio.Sample.Sample" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract SampleChannel CreateChannel()
```

#### Returns

 [SampleChannel](osu.Framework.Audio.Sample.SampleChannel.md)

The <xref href="osu.Framework.Audio.Sample.SampleChannel" data-throw-if-not-resolved="false"></xref> for the playback.

### <a id="osu_Framework_Audio_Sample_Sample_GetChannel"></a> GetChannel\(\)

Retrieves a unique playback channel for this <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref>.

```csharp
public SampleChannel GetChannel()
```

#### Returns

 [SampleChannel](osu.Framework.Audio.Sample.SampleChannel.md)

The unique <xref href="osu.Framework.Audio.Sample.SampleChannel" data-throw-if-not-resolved="false"></xref> for the playback.

#### Remarks

Multiple channels can be retrieved and played simultaneously, but can only be heard up to <xref href="osu.Framework.Audio.Sample.ISample.PlaybackConcurrency" data-throw-if-not-resolved="false"></xref> times.

### <a id="osu_Framework_Audio_Sample_Sample_Play"></a> Play\(\)

Creates a new unique playback channel for this <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref> and immediately plays it.

```csharp
public SampleChannel Play()
```

#### Returns

 [SampleChannel](osu.Framework.Audio.Sample.SampleChannel.md)

The unique <xref href="osu.Framework.Audio.Sample.SampleChannel" data-throw-if-not-resolved="false"></xref> for the playback.

#### Remarks

Multiple channels can be played simultaneously, but can only be heard up to <xref href="osu.Framework.Audio.Sample.ISample.PlaybackConcurrency" data-throw-if-not-resolved="false"></xref> times.

