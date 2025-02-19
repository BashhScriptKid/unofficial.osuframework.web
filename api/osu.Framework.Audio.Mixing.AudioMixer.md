# <a id="osu_Framework_Audio_Mixing_AudioMixer"></a> Class AudioMixer

Namespace: [osu.Framework.Audio.Mixing](osu.Framework.Audio.Mixing.md)  
Assembly: osu.Framework.dll  

Mixes together multiple <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref>s into one output.

```csharp
public abstract class AudioMixer : AudioComponent, IDisposable, IUpdateable, IAudioMixer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md) ← 
[AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md), 
[IAudioMixer](osu.Framework.Audio.Mixing.IAudioMixer.md)

#### Inherited Members

[AudioComponent.PendingActions](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_PendingActions), 
[AudioComponent.CanPerformInline](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_CanPerformInline), 
[AudioComponent.EnqueueAction\(Action\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_EnqueueAction\_System\_Action\_), 
[AudioComponent.UpdateState\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_UpdateState), 
[AudioComponent.UpdateChildren\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_UpdateChildren), 
[AudioComponent.Update\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Update), 
[AudioComponent.HasCompleted](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_HasCompleted), 
[AudioComponent.IsAlive](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsAlive), 
[AudioComponent.IsLoaded](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsLoaded), 
[AudioComponent.IsDisposed](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_IsDisposed), 
[AudioComponent.Dispose\(\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Dispose), 
[AudioComponent.Dispose\(bool\)](osu.Framework.Audio.AudioComponent.md\#osu\_Framework\_Audio\_AudioComponent\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AudioMixer\>\(AudioMixer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AudioMixer\>\(AudioMixer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AudioMixer\>\(AudioMixer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AudioMixer\>\(AudioMixer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AudioMixer, TChild\>\(AudioMixer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AudioMixer, TChild\>\(AudioMixer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AudioMixer, TChild\>\(AudioMixer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AudioMixer\>\(AudioMixer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Audio_Mixing_AudioMixer__ctor_osu_Framework_Audio_Mixing_AudioMixer_System_String_"></a> AudioMixer\(AudioMixer?, string\)

Creates a new <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref>.

```csharp
protected AudioMixer(AudioMixer? fallbackMixer, string identifier)
```

#### Parameters

`fallbackMixer` [AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)?

A fallback <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref>, which <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref>s are moved to if removed from this one.
    A <code>null</code> value indicates this is the fallback <xref href="osu.Framework.Audio.Mixing.AudioMixer" data-throw-if-not-resolved="false"></xref>.

`identifier` [string](https://learn.microsoft.com/dotnet/api/system.string)

An identifier displayed on the audio mixer visualiser.

## Fields

### <a id="osu_Framework_Audio_Mixing_AudioMixer_Identifier"></a> Identifier

```csharp
public readonly string Identifier
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Audio_Mixing_AudioMixer_Add_osu_Framework_Audio_Mixing_IAudioChannel_"></a> Add\(IAudioChannel\)

Adds a channel to the mix.

```csharp
public void Add(IAudioChannel channel)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The channel to add.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_AddEffect_ManagedBass_IEffectParameter_System_Int32_"></a> AddEffect\(IEffectParameter, int\)

Applies an effect to the mixer.

```csharp
public abstract void AddEffect(IEffectParameter effect, int priority = 0)
```

#### Parameters

`effect` IEffectParameter

The effect (e.g. <xref href="ManagedBass.Fx.BQFEffect" data-throw-if-not-resolved="false"></xref>.

`priority` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The effect priority. Lower values indicate higher priority and negative values are allowed.
        When there are multiple effects with the same priority, their ordering depends on the order in which they are added to the <xref href="osu.Framework.Audio.Mixing.IAudioMixer" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_AddInternal_osu_Framework_Audio_Mixing_IAudioChannel_"></a> AddInternal\(IAudioChannel\)

Adds an <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref> to the mix.

```csharp
protected abstract void AddInternal(IAudioChannel channel)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref> to add.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_Remove_osu_Framework_Audio_Mixing_IAudioChannel_"></a> Remove\(IAudioChannel\)

Removes a channel from the mix.

```csharp
public void Remove(IAudioChannel channel)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The channel to remove.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_Remove_osu_Framework_Audio_Mixing_IAudioChannel_System_Boolean_"></a> Remove\(IAudioChannel, bool\)

Removes an <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref> from the mix.

```csharp
protected void Remove(IAudioChannel channel, bool returnToDefault)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref> to remove.

`returnToDefault` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">channel</code> should be returned to the default mixer.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_RemoveEffect_ManagedBass_IEffectParameter_"></a> RemoveEffect\(IEffectParameter\)

Removes an effect from the mixer.

```csharp
public abstract void RemoveEffect(IEffectParameter effect)
```

#### Parameters

`effect` IEffectParameter

The effect.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_RemoveInternal_osu_Framework_Audio_Mixing_IAudioChannel_"></a> RemoveInternal\(IAudioChannel\)

Removes an <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref> from the mix.

```csharp
protected abstract void RemoveInternal(IAudioChannel channel)
```

#### Parameters

`channel` [IAudioChannel](osu.Framework.Audio.Mixing.IAudioChannel.md)

The <xref href="osu.Framework.Audio.Mixing.IAudioChannel" data-throw-if-not-resolved="false"></xref> to remove.

### <a id="osu_Framework_Audio_Mixing_AudioMixer_UpdateEffect_ManagedBass_IEffectParameter_"></a> UpdateEffect\(IEffectParameter\)

Updates an effect's parameters.

```csharp
public abstract void UpdateEffect(IEffectParameter effect)
```

#### Parameters

`effect` IEffectParameter

