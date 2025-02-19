# <a id="osu_Framework_Audio_IAdjustableAudioComponent"></a> Interface IAdjustableAudioComponent

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IAdjustableAudioComponent : IAggregateAudioAdjustment
```

#### Implements

[IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IAdjustableAudioComponent\>\(IAdjustableAudioComponent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IAdjustableAudioComponent\>\(IAdjustableAudioComponent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IAdjustableAudioComponent\>\(IAdjustableAudioComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IAdjustableAudioComponent\>\(IAdjustableAudioComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IAdjustableAudioComponent, TChild\>\(IAdjustableAudioComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IAdjustableAudioComponent, TChild\>\(IAdjustableAudioComponent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IAdjustableAudioComponent, TChild\>\(IAdjustableAudioComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IAdjustableAudioComponent\>\(IAdjustableAudioComponent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_Balance"></a> Balance

The playback balance of this sample (-1 .. 1 where 0 is centered)

```csharp
BindableNumber<double> Balance { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_Frequency"></a> Frequency

Rate at which the component is played back (affects pitch). 1 is 100% playback speed, or default frequency.

```csharp
BindableNumber<double> Frequency { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_Tempo"></a> Tempo

Rate at which the component is played back (does not affect pitch). 1 is 100% playback speed.

```csharp
BindableNumber<double> Tempo { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_Volume"></a> Volume

The volume of this component.

```csharp
BindableNumber<double> Volume { get; }
```

#### Property Value

 [BindableNumber](osu.Framework.Bindables.BindableNumber\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

## Methods

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_AddAdjustment_osu_Framework_Audio_AdjustableProperty_osu_Framework_Bindables_IBindable_System_Double__"></a> AddAdjustment\(AdjustableProperty, IBindable<double\>\)

Add a bindable adjustment source.

```csharp
void AddAdjustment(AdjustableProperty type, IBindable<double> adjustBindable)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type for this adjustment.

`adjustBindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The bindable adjustment.

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_BindAdjustments_osu_Framework_Audio_IAggregateAudioAdjustment_"></a> BindAdjustments\(IAggregateAudioAdjustment\)

Bind all adjustments from an <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
void BindAdjustments(IAggregateAudioAdjustment component)
```

#### Parameters

`component` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The adjustment source.

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_RemoveAdjustment_osu_Framework_Audio_AdjustableProperty_osu_Framework_Bindables_IBindable_System_Double__"></a> RemoveAdjustment\(AdjustableProperty, IBindable<double\>\)

Remove a bindable adjustment source.

```csharp
void RemoveAdjustment(AdjustableProperty type, IBindable<double> adjustBindable)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type for this adjustment.

`adjustBindable` [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The bindable adjustment.

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_RemoveAllAdjustments_osu_Framework_Audio_AdjustableProperty_"></a> RemoveAllAdjustments\(AdjustableProperty\)

Removes all adjustments of a type.

```csharp
void RemoveAllAdjustments(AdjustableProperty type)
```

#### Parameters

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The target type to remove all adjustments of.

### <a id="osu_Framework_Audio_IAdjustableAudioComponent_UnbindAdjustments_osu_Framework_Audio_IAggregateAudioAdjustment_"></a> UnbindAdjustments\(IAggregateAudioAdjustment\)

Unbind all adjustments from an <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

```csharp
void UnbindAdjustments(IAggregateAudioAdjustment component)
```

#### Parameters

`component` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The adjustment source.

