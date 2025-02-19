# <a id="osu_Framework_Audio_Sample_ISampleChannel"></a> Interface ISampleChannel

Namespace: [osu.Framework.Audio.Sample](osu.Framework.Audio.Sample.md)  
Assembly: osu.Framework.dll  

A unique playback of an <xref href="osu.Framework.Audio.Sample.ISample" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface ISampleChannel : IHasAmplitudes
```

#### Implements

[IHasAmplitudes](osu.Framework.Audio.IHasAmplitudes.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<ISampleChannel\>\(ISampleChannel?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ISampleChannel\>\(ISampleChannel\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ISampleChannel\>\(ISampleChannel\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ISampleChannel\>\(ISampleChannel\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ISampleChannel, TChild\>\(ISampleChannel, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ISampleChannel, TChild\>\(ISampleChannel, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ISampleChannel, TChild\>\(ISampleChannel, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ISampleChannel\>\(ISampleChannel\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_Sample_ISampleChannel_Looping"></a> Looping

Whether playback should repeat.

```csharp
bool Looping { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Sample_ISampleChannel_Name"></a> Name

A name identifying this sample internally.

```csharp
string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Audio_Sample_ISampleChannel_Played"></a> Played

Whether playback was ever started.

```csharp
bool Played { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Sample_ISampleChannel_Playing"></a> Playing

Whether playback is currently in progress.

```csharp
bool Playing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Audio_Sample_ISampleChannel_Play"></a> Play\(\)

Starts or resumes playback. Has no effect if this <xref href="osu.Framework.Audio.Sample.ISampleChannel" data-throw-if-not-resolved="false"></xref> is already playing.

```csharp
void Play()
```

### <a id="osu_Framework_Audio_Sample_ISampleChannel_Stop"></a> Stop\(\)

Stops playback.

```csharp
void Stop()
```

