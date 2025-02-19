# <a id="osu_Framework_Audio_Mixing_IAudioMixer"></a> Interface IAudioMixer

Namespace: [osu.Framework.Audio.Mixing](osu.Framework.Audio.Mixing.md)  
Assembly: osu.Framework.dll  

An audio mixer which one or more <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref>s can be routed into.
Supports DSP effects independent of other <xref href="osu.Framework.Audio.Mixing.IAudioMixer" data-throw-if-not-resolved="false"></xref>s.

```csharp
public interface IAudioMixer
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IAudioMixer\>\(IAudioMixer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IAudioMixer\>\(IAudioMixer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IAudioMixer\>\(IAudioMixer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IAudioMixer\>\(IAudioMixer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IAudioMixer, TChild\>\(IAudioMixer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IAudioMixer, TChild\>\(IAudioMixer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IAudioMixer, TChild\>\(IAudioMixer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IAudioMixer\>\(IAudioMixer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Audio_Mixing_IAudioMixer_Add_osu_Framework_Audio_Mixing_IAudioChannel_"></a> Add\(IAudioChannel\)

Adds a channel to the mix.

```csharp
void Add(IAudioChannel channel)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The channel to add.

### <a id="osu_Framework_Audio_Mixing_IAudioMixer_AddEffect_ManagedBass_IEffectParameter_System_Int32_"></a> AddEffect\(IEffectParameter, int\)

Applies an effect to the mixer.

```csharp
void AddEffect(IEffectParameter effect, int priority = 0)
```

#### Parameters

`effect` IEffectParameter

The effect (e.g. <xref href="ManagedBass.Fx.BQFEffect" data-throw-if-not-resolved="false"></xref>.

`priority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The effect priority. Lower values indicate higher priority and negative values are allowed.
        When there are multiple effects with the same priority, their ordering depends on the order in which they are added to the <xref href="osu.Framework.Audio.Mixing.IAudioMixer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Audio_Mixing_IAudioMixer_Remove_osu_Framework_Audio_Mixing_IAudioChannel_"></a> Remove\(IAudioChannel\)

Removes a channel from the mix.

```csharp
void Remove(IAudioChannel channel)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The channel to remove.

### <a id="osu_Framework_Audio_Mixing_IAudioMixer_RemoveEffect_ManagedBass_IEffectParameter_"></a> RemoveEffect\(IEffectParameter\)

Removes an effect from the mixer.

```csharp
void RemoveEffect(IEffectParameter effect)
```

#### Parameters

`effect` IEffectParameter

The effect.

### <a id="osu_Framework_Audio_Mixing_IAudioMixer_UpdateEffect_ManagedBass_IEffectParameter_"></a> UpdateEffect\(IEffectParameter\)

Updates an effect's parameters.

```csharp
void UpdateEffect(IEffectParameter effect)
```

#### Parameters

`effect` IEffectParameter

