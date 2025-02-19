# <a id="osu_Framework_Audio_AudioCollectionManager_1"></a> Class AudioCollectionManager<T\>

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

A collection of audio components which need central property control.

```csharp
public class AudioCollectionManager<T> : AdjustableAudioComponent, IDisposable, IUpdateable, IAdjustableAudioComponent, IAggregateAudioAdjustment where T : AudioComponent
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md) ← 
[AudioCollectionManager<T\>](osu.Framework.Audio.AudioCollectionManager\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md), 
[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

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

[ObjectExtensions.AsNonNull<AudioCollectionManager<T\>\>\(AudioCollectionManager<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AudioCollectionManager<T\>\>\(AudioCollectionManager<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AudioCollectionManager<T\>\>\(AudioCollectionManager<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AudioCollectionManager<T\>\>\(AudioCollectionManager<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AudioCollectionManager<T\>, TChild\>\(AudioCollectionManager<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AudioCollectionManager<T\>, TChild\>\(AudioCollectionManager<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AudioCollectionManager<T\>, TChild\>\(AudioCollectionManager<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AudioCollectionManager<T\>\>\(AudioCollectionManager<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Audio_AudioCollectionManager_1_AddItem__0_"></a> AddItem\(T\)

```csharp
public void AddItem(T item)
```

#### Parameters

`item` T

### <a id="osu_Framework_Audio_AudioCollectionManager_1_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioCollectionManager_1_ItemAdded__0_"></a> ItemAdded\(T\)

```csharp
protected virtual void ItemAdded(T item)
```

#### Parameters

`item` T

### <a id="osu_Framework_Audio_AudioCollectionManager_1_ItemRemoved__0_"></a> ItemRemoved\(T\)

```csharp
protected virtual void ItemRemoved(T item)
```

#### Parameters

`item` T

### <a id="osu_Framework_Audio_AudioCollectionManager_1_UpdateChildren"></a> UpdateChildren\(\)

Run each loop of the audio thread's execution, after <xref href="osu.Framework.Audio.AudioComponent.UpdateState" data-throw-if-not-resolved="false"></xref> as a way to update any child components.

```csharp
protected override void UpdateChildren()
```

