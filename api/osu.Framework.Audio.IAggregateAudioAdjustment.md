# <a id="osu_Framework_Audio_IAggregateAudioAdjustment"></a> Interface IAggregateAudioAdjustment

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

Provides aggregated adjustments for an audio component.

```csharp
public interface IAggregateAudioAdjustment
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IAggregateAudioAdjustment\>\(IAggregateAudioAdjustment?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[AggregateAdjustmentExtensions.GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)](osu.Framework.Audio.AggregateAdjustmentExtensions.md\#osu\_Framework\_Audio\_AggregateAdjustmentExtensions\_GetAggregate\_osu\_Framework\_Audio\_IAggregateAudioAdjustment\_osu\_Framework\_Audio\_AdjustableProperty\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IAggregateAudioAdjustment\>\(IAggregateAudioAdjustment\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IAggregateAudioAdjustment\>\(IAggregateAudioAdjustment\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IAggregateAudioAdjustment\>\(IAggregateAudioAdjustment\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IAggregateAudioAdjustment, TChild\>\(IAggregateAudioAdjustment, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IAggregateAudioAdjustment, TChild\>\(IAggregateAudioAdjustment, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IAggregateAudioAdjustment, TChild\>\(IAggregateAudioAdjustment, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IAggregateAudioAdjustment\>\(IAggregateAudioAdjustment\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_IAggregateAudioAdjustment_AggregateBalance"></a> AggregateBalance

The aggregate playback balance of this sample (-1 .. 1 where 0 is centered)

```csharp
IBindable<double> AggregateBalance { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_IAggregateAudioAdjustment_AggregateFrequency"></a> AggregateFrequency

The aggregate rate at which the component is played back (affects pitch). 1 is 100% playback speed, or default frequency.

```csharp
IBindable<double> AggregateFrequency { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_IAggregateAudioAdjustment_AggregateTempo"></a> AggregateTempo

The aggregate rate at which the component is played back (does not affect pitch). 1 is 100% playback speed.

```csharp
IBindable<double> AggregateTempo { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Audio_IAggregateAudioAdjustment_AggregateVolume"></a> AggregateVolume

The aggregate volume of this component (0..1).

```csharp
IBindable<double> AggregateVolume { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

