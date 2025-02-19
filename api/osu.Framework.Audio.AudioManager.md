# <a id="osu_Framework_Audio_AudioManager"></a> Class AudioManager

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

```csharp
public class AudioManager : AudioCollectionManager<AudioComponent>, IDisposable, IUpdateable, IAdjustableAudioComponent, IAggregateAudioAdjustment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md) ← 
[AudioCollectionManager<AudioComponent\>](osu.Framework.Audio.AudioCollectionManager\-1.md) ← 
[AudioManager](osu.Framework.Audio.AudioManager.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md), 
[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Inherited Members

[AudioCollectionManager<AudioComponent\>.AddItem\(AudioComponent\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_AddItem\_\_0\_), 
[AudioCollectionManager<AudioComponent\>.UpdateChildren\(\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_UpdateChildren), 
[AudioCollectionManager<AudioComponent\>.ItemAdded\(AudioComponent\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_ItemAdded\_\_0\_), 
[AudioCollectionManager<AudioComponent\>.ItemRemoved\(AudioComponent\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_ItemRemoved\_\_0\_), 
[AudioCollectionManager<AudioComponent\>.Dispose\(bool\)](osu.Framework.Audio.AudioCollectionManager\-1.md\#osu\_Framework\_Audio\_AudioCollectionManager\_1\_Dispose\_System\_Boolean\_), 
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

[ObjectExtensions.AsNonNull<AudioManager\>\(AudioManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AudioManager\>\(AudioManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AudioManager\>\(AudioManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AudioManager\>\(AudioManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AudioManager, TChild\>\(AudioManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AudioManager, TChild\>\(AudioManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AudioManager, TChild\>\(AudioManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AudioManager\>\(AudioManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_AudioManager__ctor_osu_Framework_Threading_AudioThread_osu_Framework_IO_Stores_ResourceStore_System_Byte____osu_Framework_IO_Stores_ResourceStore_System_Byte____"></a> AudioManager\(AudioThread, ResourceStore<byte\[\]\>, ResourceStore<byte\[\]\>\)

Constructs an AudioStore given a track resource store, and a sample resource store.

```csharp
public AudioManager(AudioThread audioThread, ResourceStore<byte[]> trackStore, ResourceStore<byte[]> sampleStore)
```

#### Parameters

`audioThread` [AudioThread](osu.Framework.Threading.AudioThread.md)

The host's audio thread.

`trackStore` [ResourceStore](osu.Framework.IO.Stores.ResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The resource store containing all audio tracks to be used in the future.

`sampleStore` [ResourceStore](osu.Framework.IO.Stores.ResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The sample store containing all audio samples to be used in the future.

## Fields

### <a id="osu_Framework_Audio_AudioManager_AudioDevice"></a> AudioDevice

The preferred audio device we should use. A value of
<xref href="System.String.Empty" data-throw-if-not-resolved="false"></xref> denotes the OS default.

```csharp
public readonly Bindable<string> AudioDevice
```

#### Field Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Audio_AudioManager_BASS_INTERNAL_DEVICE_COUNT"></a> BASS\_INTERNAL\_DEVICE\_COUNT

The number of BASS audio devices preceding the first real audio device.
Consisting of <xref href="ManagedBass.Bass.NoSoundDevice" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Audio.AudioManager.bass_default_device" data-throw-if-not-resolved="false"></xref>.

```csharp
protected const int BASS_INTERNAL_DEVICE_COUNT = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Audio_AudioManager_EventScheduler"></a> EventScheduler

The scheduler used for invoking publicly exposed delegate events.

```csharp
public Scheduler EventScheduler
```

#### Field Value

 [Scheduler](osu.Framework.Threading.Scheduler.md)

### <a id="osu_Framework_Audio_AudioManager_SampleMixer"></a> SampleMixer

The global mixer which all samples are routed into by default.

```csharp
public readonly AudioMixer SampleMixer
```

#### Field Value

 [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

### <a id="osu_Framework_Audio_AudioManager_TrackMixer"></a> TrackMixer

The global mixer which all tracks are routed into by default.

```csharp
public readonly AudioMixer TrackMixer
```

#### Field Value

 [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

### <a id="osu_Framework_Audio_AudioManager_VolumeSample"></a> VolumeSample

Volume of all samples played game-wide.

```csharp
public readonly BindableDouble VolumeSample
```

#### Field Value

 [BindableDouble](osu.Framework.Bindables.BindableDouble.md)

### <a id="osu_Framework_Audio_AudioManager_VolumeTrack"></a> VolumeTrack

Volume of all tracks played game-wide.

```csharp
public readonly BindableDouble VolumeTrack
```

#### Field Value

 [BindableDouble](osu.Framework.Bindables.BindableDouble.md)

## Properties

### <a id="osu_Framework_Audio_AudioManager_AudioDeviceNames"></a> AudioDeviceNames

The names of all available audio devices.

```csharp
public IEnumerable<string> AudioDeviceNames { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

#### Remarks

This property does not contain the names of disabled audio devices.

### <a id="osu_Framework_Audio_AudioManager_IsLoaded"></a> IsLoaded

Whether this component has finished loading its resources.

```csharp
public override bool IsLoaded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioManager_Samples"></a> Samples

The manager component responsible for audio samples (e.g. sound effects).

```csharp
public ISampleStore Samples { get; }
```

#### Property Value

 [ISampleStore](osu.Framework.Audio.Sample.ISampleStore.md)

### <a id="osu_Framework_Audio_AudioManager_Tracks"></a> Tracks

The manager component responsible for audio tracks (e.g. songs).

```csharp
public ITrackStore Tracks { get; }
```

#### Property Value

 [ITrackStore](osu.Framework.Audio.Track.ITrackStore.md)

### <a id="osu_Framework_Audio_AudioManager_UsingGlobalMixer"></a> UsingGlobalMixer

Whether a global mixer is being used for audio routing.
For now, this is only the case on Windows when using shared mode WASAPI initialisation.

```csharp
public IBindable<bool> UsingGlobalMixer { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

## Methods

### <a id="osu_Framework_Audio_AudioManager_CheckForDeviceChanges_System_Collections_Immutable_ImmutableArray_ManagedBass_DeviceInfo__"></a> CheckForDeviceChanges\(ImmutableArray<DeviceInfo\>\)

Check whether any audio device changes have occurred.

Changes supported are:
- A new device is added
- An existing device is Enabled/Disabled or set as Default

```csharp
protected virtual bool CheckForDeviceChanges(ImmutableArray<DeviceInfo> previousDevices)
```

#### Parameters

`previousDevices` [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<DeviceInfo\>

The previous audio devices array.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether a change was detected.

#### Remarks

This method is optimised to incur the lowest overhead possible.

### <a id="osu_Framework_Audio_AudioManager_CreateAudioMixer_System_String_"></a> CreateAudioMixer\(string\)

Creates a new <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref>.

```csharp
public AudioMixer CreateAudioMixer(string identifier = null)
```

#### Parameters

`identifier` [string](https://learn.microsoft.com/dotnet/api/system.string)

An identifier displayed on the audio mixer visualiser.

#### Returns

 [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

#### Remarks

Channels removed from this <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref> fall back to the global <xref href="osu.Framework.Audio.AudioManager.SampleMixer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Audio_AudioManager_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected override void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioManager_GetAllDevices"></a> GetAllDevices\(\)

```csharp
protected virtual ImmutableArray<DeviceInfo> GetAllDevices()
```

#### Returns

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<DeviceInfo\>

### <a id="osu_Framework_Audio_AudioManager_GetSampleStore_osu_Framework_IO_Stores_IResourceStore_System_Byte____osu_Framework_Audio_Mixing_AudioMixer_"></a> GetSampleStore\(IResourceStore<byte\[\]\>, AudioMixer\)

Obtains the <xref href="osu.Framework.Audio.Sample.SampleStore" data-throw-if-not-resolved="false"></xref> corresponding to a given resource store.
Returns the global <xref href="osu.Framework.Audio.Sample.SampleStore" data-throw-if-not-resolved="false"></xref> if no resource store is passed.

```csharp
public ISampleStore GetSampleStore(IResourceStore<byte[]> store = null, AudioMixer mixer = null)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The <xref href="osu.Framework.IO.Stores.IResourceStore%601" data-throw-if-not-resolved="false"></xref> of which to retrieve the <xref href="osu.Framework.Audio.Sample.SampleStore" data-throw-if-not-resolved="false"></xref>.

`mixer` [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

The <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref> to use for samples created by this store. Defaults to the global <xref href="osu.Framework.Audio.AudioManager.SampleMixer" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [ISampleStore](osu.Framework.Audio.Sample.ISampleStore.md)

#### Remarks

By default, <code>.wav</code> and <code>.ogg</code> extensions will be automatically appended to lookups on the returned store
if the lookup does not correspond directly to an existing filename.
Additional extensions can be added via <xref href="osu.Framework.Audio.Sample.ISampleStore.AddExtension(System.String)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Audio_AudioManager_GetTrackStore_osu_Framework_IO_Stores_IResourceStore_System_Byte____osu_Framework_Audio_Mixing_AudioMixer_"></a> GetTrackStore\(IResourceStore<byte\[\]\>, AudioMixer\)

Obtains the <xref href="osu.Framework.Audio.Track.TrackStore" data-throw-if-not-resolved="false"></xref> corresponding to a given resource store.
Returns the global <xref href="osu.Framework.Audio.Track.TrackStore" data-throw-if-not-resolved="false"></xref> if no resource store is passed.

```csharp
public ITrackStore GetTrackStore(IResourceStore<byte[]> store = null, AudioMixer mixer = null)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The <xref href="osu.Framework.IO.Stores.IResourceStore%601" data-throw-if-not-resolved="false"></xref> of which to retrieve the <xref href="osu.Framework.Audio.Track.TrackStore" data-throw-if-not-resolved="false"></xref>.

`mixer` [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

The <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref> to use for tracks created by this store. Defaults to the global <xref href="osu.Framework.Audio.AudioManager.TrackMixer" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [ITrackStore](osu.Framework.Audio.Track.ITrackStore.md)

### <a id="osu_Framework_Audio_AudioManager_InitBass_System_Int32_"></a> InitBass\(int\)

This method calls <xref href="ManagedBass.Bass.Init(System.Int32%2cSystem.Int32%2cManagedBass.DeviceInitFlags%2cSystem.IntPtr%2cSystem.IntPtr)" data-throw-if-not-resolved="false"></xref>.
It can be overridden for unit testing.

```csharp
protected virtual bool InitBass(int device)
```

#### Parameters

`device` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioManager_IsCurrentDeviceValid"></a> IsCurrentDeviceValid\(\)

```csharp
protected virtual bool IsCurrentDeviceValid()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioManager_ItemAdded_osu_Framework_Audio_AudioComponent_"></a> ItemAdded\(AudioComponent\)

```csharp
protected override void ItemAdded(AudioComponent item)
```

#### Parameters

`item` [AudioComponent](osu.Framework.Audio.AudioComponent.md)

### <a id="osu_Framework_Audio_AudioManager_ItemRemoved_osu_Framework_Audio_AudioComponent_"></a> ItemRemoved\(AudioComponent\)

```csharp
protected override void ItemRemoved(AudioComponent item)
```

#### Parameters

`item` [AudioComponent](osu.Framework.Audio.AudioComponent.md)

### <a id="osu_Framework_Audio_AudioManager_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="osu_Framework_Audio_AudioManager_OnLostDevice"></a> OnLostDevice

Is fired whenever an audio device is lost and provides its name.

```csharp
public event Action<string> OnLostDevice
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_Audio_AudioManager_OnNewDevice"></a> OnNewDevice

Is fired whenever a new audio device is discovered and provides its name.

```csharp
public event Action<string> OnNewDevice
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

