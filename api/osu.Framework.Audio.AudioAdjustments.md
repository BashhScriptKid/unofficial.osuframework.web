# <a id="osu_Framework_Audio_AudioAdjustments"></a> Class AudioAdjustments

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

Provides adjustable and bindable attributes for an audio component.
Aggregates results as a <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
public class AudioAdjustments : IAdjustableAudioComponent, IAggregateAudioAdjustment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioAdjustments](osu.Framework.Audio.AudioAdjustments.md)

#### Implements

[IAdjustableAudioComponent](osu.Framework.Audio.IAdjustableAudioComponent.md), 
[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AudioAdjustments\>\(AudioAdjustments?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AudioAdjustments\>\(AudioAdjustments\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AudioAdjustments\>\(AudioAdjustments\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AudioAdjustments\>\(AudioAdjustments\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AudioAdjustments, TChild\>\(AudioAdjustments, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AudioAdjustments, TChild\>\(AudioAdjustments, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AudioAdjustments, TChild\>\(AudioAdjustments, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AudioAdjustments\>\(AudioAdjustments\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_AudioAdjustments__ctor"></a> AudioAdjustments\(\)

```csharp
public AudioAdjustments()
```

## Properties

### <a id="osu_Framework_Audio_AudioAdjustments_AggregateBalance"></a> AggregateBalance

The aggregate playback balance of this sample (-1 .. 1 where 0 is centered)

```csharp
public IBindable<double> AggregateBalance { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_AggregateFrequency"></a> AggregateFrequency

The aggregate rate at which the component is played back (affects pitch). 1 is 100% playback speed, or default frequency.

```csharp
public IBindable<double> AggregateFrequency { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_AggregateTempo"></a> AggregateTempo

The aggregate rate at which the component is played back (does not affect pitch). 1 is 100% playback speed.

```csharp
public IBindable<double> AggregateTempo { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_AggregateVolume"></a> AggregateVolume

The aggregate volume of this component (0..1).

```csharp
public IBindable<double> AggregateVolume { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_Balance"></a> Balance

The playback balance of this sample (-1 .. 1 where 0 is centered)

```csharp
public BindableNumber<double> Balance { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_Frequency"></a> Frequency

Rate at which the component is played back (affects pitch). 1 is 100% playback speed, or default frequency.

```csharp
public BindableNumber<double> Frequency { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_Tempo"></a> Tempo

Rate at which the component is played back (does not affect pitch). 1 is 100% playback speed.

```csharp
public BindableNumber<double> Tempo { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_AudioAdjustments_Volume"></a> Volume

The volume of this component.

```csharp
public BindableNumber<double> Volume { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

## Methods

### <a id="osu_Framework_Audio_AudioAdjustments_AddAdjustment_osu_Framework_Audio_AdjustableProperty_osu_Framework_Bindables_IBindable_System_Double__"></a> AddAdjustment\(AdjustableProperty, IBindable<double\>\)

Add a bindable adjustment source.

```csharp
public void AddAdjustment(AdjustableProperty type, IBindable<double> adjustBindable)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type for this adjustment.

`adjustBindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The bindable adjustment.

### <a id="osu_Framework_Audio_AudioAdjustments_BindAdjustments_osu_Framework_Audio_IAggregateAudioAdjustment_"></a> BindAdjustments\(IAggregateAudioAdjustment\)

Bind all adjustments from an <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
public void BindAdjustments(IAggregateAudioAdjustment component)
```

#### Parameters

`component` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The adjustment source.

### <a id="osu_Framework_Audio_AudioAdjustments_RemoveAdjustment_osu_Framework_Audio_AdjustableProperty_osu_Framework_Bindables_IBindable_System_Double__"></a> RemoveAdjustment\(AdjustableProperty, IBindable<double\>\)

Remove a bindable adjustment source.

```csharp
public void RemoveAdjustment(AdjustableProperty type, IBindable<double> adjustBindable)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type for this adjustment.

`adjustBindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The bindable adjustment.

### <a id="osu_Framework_Audio_AudioAdjustments_RemoveAllAdjustments_osu_Framework_Audio_AdjustableProperty_"></a> RemoveAllAdjustments\(AdjustableProperty\)

Removes all adjustments of a type.

```csharp
public void RemoveAllAdjustments(AdjustableProperty type)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type to remove all adjustments of.

### <a id="osu_Framework_Audio_AudioAdjustments_UnbindAdjustments_osu_Framework_Audio_IAggregateAudioAdjustment_"></a> UnbindAdjustments\(IAggregateAudioAdjustment\)

Unbind all adjustments from an <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
public void UnbindAdjustments(IAggregateAudioAdjustment component)
```

#### Parameters

`component` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The adjustment source.

