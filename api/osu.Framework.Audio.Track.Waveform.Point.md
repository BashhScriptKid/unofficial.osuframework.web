# <a id="osu_Framework_Audio_Track_Waveform_Point"></a> Struct Waveform.Point

Namespace: [osu.Framework.Audio.Track](osu.Framework.Audio.Track.md)  
Assembly: osu.Framework.dll  

Represents a singular point of data in a <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref>.

```csharp
public struct Waveform.Point
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Waveform.Point\>\(Waveform.Point\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Waveform.Point\>\(Waveform.Point\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Waveform.Point\>\(Waveform.Point\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Waveform.Point\>\(Waveform.Point\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Waveform.Point, TChild\>\(Waveform.Point, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Waveform.Point, TChild\>\(Waveform.Point, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Waveform.Point, TChild\>\(Waveform.Point, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Waveform.Point\>\(Waveform.Point\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Audio_Track_Waveform_Point_AmplitudeLeft"></a> AmplitudeLeft

The amplitude of the left channel.

```csharp
public float AmplitudeLeft
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Audio_Track_Waveform_Point_AmplitudeRight"></a> AmplitudeRight

The amplitude of the right channel.

```csharp
public float AmplitudeRight
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Audio_Track_Waveform_Point_HighIntensity"></a> HighIntensity

Unnormalised total intensity of the high-range (treble) frequencies.

```csharp
public float HighIntensity
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Audio_Track_Waveform_Point_LowIntensity"></a> LowIntensity

Unnormalised total intensity of the low-range (bass) frequencies.

```csharp
public float LowIntensity
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Audio_Track_Waveform_Point_MidIntensity"></a> MidIntensity

Unnormalised total intensity of the mid-range frequencies.

```csharp
public float MidIntensity
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

