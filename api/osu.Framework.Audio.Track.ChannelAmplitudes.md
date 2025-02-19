# <a id="osu_Framework_Audio_Track_ChannelAmplitudes"></a> Struct ChannelAmplitudes

Namespace: [osu.Framework.Audio.Track](osu.Framework.Audio.Track.md)  
Assembly: osu.Framework.dll  

A collection of information providing per-channel and per-frequency amplitudes of an audio channel.

```csharp
public readonly struct ChannelAmplitudes
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ChannelAmplitudes\>\(ChannelAmplitudes\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ChannelAmplitudes\>\(ChannelAmplitudes\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ChannelAmplitudes\>\(ChannelAmplitudes\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ChannelAmplitudes\>\(ChannelAmplitudes\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ChannelAmplitudes, TChild\>\(ChannelAmplitudes, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ChannelAmplitudes, TChild\>\(ChannelAmplitudes, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ChannelAmplitudes, TChild\>\(ChannelAmplitudes, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ChannelAmplitudes\>\(ChannelAmplitudes\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes__ctor_System_Single_System_Single_System_Single___"></a> ChannelAmplitudes\(float, float, float\[\]\)

```csharp
public ChannelAmplitudes(float leftChannel = 0, float rightChannel = 0, float[] amplitudes = null)
```

#### Parameters

`leftChannel` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rightChannel` [float](https://learn.microsoft.com/dotnet/api/system.single)

`amplitudes` [float](https://learn.microsoft.com/dotnet/api/system.single)\[\]

## Fields

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_AMPLITUDES_SIZE"></a> AMPLITUDES\_SIZE

The length of the <xref href="osu.Framework.Audio.Track.ChannelAmplitudes.FrequencyAmplitudes" data-throw-if-not-resolved="false"></xref> data.

```csharp
public const int AMPLITUDES_SIZE = 256
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_FrequencyAmplitudes"></a> FrequencyAmplitudes

256 length array of bins containing the average frequency of both channels at every ~78Hz step of the audible spectrum (0Hz - 20,000Hz).

```csharp
public readonly ReadOnlyMemory<float> FrequencyAmplitudes
```

#### Field Value

 [ReadOnlyMemory](https://learn.microsoft.com/dotnet/api/system.readonlymemory\-1)<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_LeftChannel"></a> LeftChannel

The amplitude of the left channel (0..1).

```csharp
public readonly float LeftChannel
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_RightChannel"></a> RightChannel

The amplitude of the right channel (0..1).

```csharp
public readonly float RightChannel
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_Average"></a> Average

The average amplitude of the left and right channels (0..1).

```csharp
public float Average { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_Empty"></a> Empty

```csharp
public static ChannelAmplitudes Empty { get; }
```

#### Property Value

 [ChannelAmplitudes](osu.Framework.Audio.Track.ChannelAmplitudes.md)

### <a id="osu_Framework_Audio_Track_ChannelAmplitudes_Maximum"></a> Maximum

The maximum amplitude of the left and right channels (0..1).

```csharp
public float Maximum { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

