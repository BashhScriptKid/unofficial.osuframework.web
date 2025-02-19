# <a id="osu_Framework_Audio_Track_Waveform"></a> Class Waveform

Namespace: [osu.Framework.Audio.Track](osu.Framework.Audio.Track.md)  
Assembly: osu.Framework.dll  

Processes audio sample data such that it can then be consumed to generate waveform plots of the audio.

```csharp
public class Waveform : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Waveform](osu.Framework.Audio.Track.Waveform.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Waveform\>\(Waveform?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Waveform\>\(Waveform\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Waveform\>\(Waveform\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Waveform\>\(Waveform\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Waveform, TChild\>\(Waveform, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Waveform, TChild\>\(Waveform, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Waveform, TChild\>\(Waveform, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Waveform\>\(Waveform\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Track_Waveform__ctor_System_IO_Stream_"></a> Waveform\(Stream?\)

Constructs a new <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref> from provided audio data.

```csharp
public Waveform(Stream? data)
```

#### Parameters

`data` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)?

The sample data stream.
The <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref> will take ownership of this stream and dispose it when done reading track data.
If null, an empty waveform is constructed.

## Methods

### <a id="osu_Framework_Audio_Track_Waveform_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Audio_Track_Waveform_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_Track_Waveform_GenerateResampledAsync_System_Int32_System_Threading_CancellationToken_"></a> GenerateResampledAsync\(int, CancellationToken\)

Creates a new <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref> containing a specific number of data points by selecting the average value of each sampled group.

```csharp
public Task<Waveform> GenerateResampledAsync(int pointCount, CancellationToken cancellationToken = default)
```

#### Parameters

`pointCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of points the resulting <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref> should contain.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

The token to cancel the task.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Waveform](osu.Framework.Audio.Track.Waveform.md)\>

An async task for the generation of the <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Audio_Track_Waveform_GetChannels"></a> GetChannels\(\)

Gets the number of channels represented by each <xref href="osu.Framework.Audio.Track.Waveform.Point" data-throw-if-not-resolved="false"></xref>.

```csharp
public int GetChannels()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Audio_Track_Waveform_GetChannelsAsync"></a> GetChannelsAsync\(\)

Gets the number of channels represented by each <xref href="osu.Framework.Audio.Track.Waveform.Point" data-throw-if-not-resolved="false"></xref>.

```csharp
public Task<int> GetChannelsAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="osu_Framework_Audio_Track_Waveform_GetPoints"></a> GetPoints\(\)

Gets all the points represented by this <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref>.

```csharp
public Waveform.Point[] GetPoints()
```

#### Returns

 [Waveform](osu.Framework.Audio.Track.Waveform.md).[Point](osu.Framework.Audio.Track.Waveform.Point.md)\[\]

### <a id="osu_Framework_Audio_Track_Waveform_GetPointsAsync"></a> GetPointsAsync\(\)

Gets all the points represented by this <xref href="osu.Framework.Audio.Track.Waveform" data-throw-if-not-resolved="false"></xref>.

```csharp
public Task<Waveform.Point[]> GetPointsAsync()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[Waveform](osu.Framework.Audio.Track.Waveform.md).[Point](osu.Framework.Audio.Track.Waveform.Point.md)\[\]\>

