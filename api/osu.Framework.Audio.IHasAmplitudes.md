# <a id="osu_Framework_Audio_IHasAmplitudes"></a> Interface IHasAmplitudes

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IHasAmplitudes
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IHasAmplitudes\>\(IHasAmplitudes?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IHasAmplitudes\>\(IHasAmplitudes\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IHasAmplitudes\>\(IHasAmplitudes\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IHasAmplitudes\>\(IHasAmplitudes\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IHasAmplitudes, TChild\>\(IHasAmplitudes, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IHasAmplitudes, TChild\>\(IHasAmplitudes, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IHasAmplitudes, TChild\>\(IHasAmplitudes, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IHasAmplitudes\>\(IHasAmplitudes\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Audio_IHasAmplitudes_CurrentAmplitudes"></a> CurrentAmplitudes

Current amplitude of stereo channels where 1 is full volume and 0 is silent.
LeftChannel and RightChannel represent the maximum current amplitude of all of the left and right channels respectively.
The most recent values are returned. Synchronisation between channels should not be expected.

```csharp
ChannelAmplitudes CurrentAmplitudes { get; }
```

#### Property Value

 [ChannelAmplitudes](osu.Framework.Audio.Track.ChannelAmplitudes.md)

