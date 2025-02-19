# <a id="osu_Framework_Audio_AdjustableAudioComponent"></a> Class AdjustableAudioComponent

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

An audio component which allows for basic bindable adjustments to be applied.

```csharp
public class AdjustableAudioComponent : AudioComponent, IDisposable, IUpdateable, IAdjustableAudioComponent, IAggregateAudioAdjustment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md)

#### Derived

[AudioCollectionManager<T\>](osu.Framework.Audio.AudioCollectionManager\-1.md), 
[SampleChannel](osu.Framework.Audio.Sample.SampleChannel.md), 
[Track](osu.Framework.Audio.Track.Track.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md), 
[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<AdjustableAudioComponent\>\(AdjustableAudioComponent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AdjustableAudioComponent\>\(AdjustableAudioComponent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AdjustableAudioComponent\>\(AdjustableAudioComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AdjustableAudioComponent\>\(AdjustableAudioComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AdjustableAudioComponent, TChild\>\(AdjustableAudioComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AdjustableAudioComponent, TChild\>\(AdjustableAudioComponent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AdjustableAudioComponent, TChild\>\(AdjustableAudioComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AdjustableAudioComponent\>\(AdjustableAudioComponent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_AdjustableAudioComponent_Adjustments"></a> Adjustments

```csharp
protected AudioAdjustments Adjustments { get; }
```

#### Property Value

 [AudioAdjustments](osu.Framework.Audio.AudioAdjustments.md)

### <a id="osu_Framework_Audio_AdjustableAudioComponent_AggregateBalance"></a> AggregateBalance

The aggregate playback balance of this sample (-1 .. 1 where 0 is centered)

```csharp
public IBindable<double> AggregateBalance { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_AggregateFrequency"></a> AggregateFrequency

The aggregate rate at which the component is played back (affects pitch). 1 is 100% playback speed, or default frequency.

```csharp
public IBindable<double> AggregateFrequency { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_AggregateTempo"></a> AggregateTempo

The aggregate rate at which the component is played back (does not affect pitch). 1 is 100% playback speed.

```csharp
public IBindable<double> AggregateTempo { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_AggregateVolume"></a> AggregateVolume

The aggregate volume of this component (0..1).

```csharp
public IBindable<double> AggregateVolume { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_Balance"></a> Balance

The playback balance of this sample (-1 .. 1 where 0 is centered)

```csharp
public BindableNumber<double> Balance { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_Frequency"></a> Frequency

Rate at which the component is played back (affects pitch). 1 is 100% playback speed, or default frequency.

```csharp
public BindableNumber<double> Frequency { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_Tempo"></a> Tempo

Rate at which the component is played back (does not affect pitch). 1 is 100% playback speed.

```csharp
public BindableNumber<double> Tempo { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AdjustableAudioComponent_Volume"></a> Volume

The volume of this component.

```csharp
public BindableNumber<double> Volume { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

## Methods

### <a id="osu_Framework_Audio_AdjustableAudioComponent_AddAdjustment_osu_Framework_Audio_AdjustableProperty_osu_Framework_Bindables_IBindable_System_Double__"></a> AddAdjustment\(AdjustableProperty, IBindable<double\>\)

Add a bindable adjustment source.

```csharp
public void AddAdjustment(AdjustableProperty type, IBindable<double> adjustBindable)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type for this adjustment.

`adjustBindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The bindable adjustment.

### <a id="osu_Framework_Audio_AdjustableAudioComponent_BindAdjustments_osu_Framework_Audio_IAggregateAudioAdjustment_"></a> BindAdjustments\(IAggregateAudioAdjustment\)

Bind all adjustments from an <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
public void BindAdjustments(IAggregateAudioAdjustment component)
```

#### Parameters

`component` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The adjustment source.

### <a id="osu_Framework_Audio_AdjustableAudioComponent_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AdjustableAudioComponent_RemoveAdjustment_osu_Framework_Audio_AdjustableProperty_osu_Framework_Bindables_IBindable_System_Double__"></a> RemoveAdjustment\(AdjustableProperty, IBindable<double\>\)

Remove a bindable adjustment source.

```csharp
public void RemoveAdjustment(AdjustableProperty type, IBindable<double> adjustBindable)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type for this adjustment.

`adjustBindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The bindable adjustment.

### <a id="osu_Framework_Audio_AdjustableAudioComponent_RemoveAllAdjustments_osu_Framework_Audio_AdjustableProperty_"></a> RemoveAllAdjustments\(AdjustableProperty\)

Removes all adjustments of a type.

```csharp
public void RemoveAllAdjustments(AdjustableProperty type)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type to remove all adjustments of.

### <a id="osu_Framework_Audio_AdjustableAudioComponent_UnbindAdjustments_osu_Framework_Audio_IAggregateAudioAdjustment_"></a> UnbindAdjustments\(IAggregateAudioAdjustment\)

Unbind all adjustments from an <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
public void UnbindAdjustments(IAggregateAudioAdjustment component)
```

#### Parameters

`component` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The adjustment source.

### <a id="osu_Framework_Audio_AdjustableAudioComponent_UpdateState"></a> UpdateState\(\)

Run each loop of the audio thread's execution after queued actions are completed to allow components to perform any additional operations.

```csharp
protected override void UpdateState()
```

