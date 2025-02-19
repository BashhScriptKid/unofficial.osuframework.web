# <a id="osu_Framework_Audio_AggregateAdjustmentExtensions"></a> Class AggregateAdjustmentExtensions

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

```csharp
public static class AggregateAdjustmentExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AggregateAdjustmentExtensions](osu.Framework.Audio.AggregateAdjustmentExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Audio_AggregateAdjustmentExtensions_GetAggregate_osu_Framework_Audio_IAggregateAudioAdjustment_osu_Framework_Audio_AdjustableProperty_"></a> GetAggregate\(IAggregateAudioAdjustment, AdjustableProperty\)

Get the aggregate result for a specific adjustment type.

```csharp
public static IBindable<double> GetAggregate(this IAggregateAudioAdjustment adjustment, AdjustableProperty type)
```

#### Parameters

`adjustment` [IAggregateAudioAdjustment](osu.Framework.Audio.IAggregateAudioAdjustment.md)

The audio adjustments to return from.

`type` [AdjustableProperty](osu.Framework.Audio.AdjustableProperty.md)

The adjustment type.

#### Returns

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[double](https://learn.microsoft.com/dotnet/api/system.double)\>

The aggregate result.

