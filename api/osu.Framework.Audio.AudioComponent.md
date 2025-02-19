# <a id="osu_Framework_Audio_AudioComponent"></a> Class AudioComponent

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

A base class for audio components which offers audio thread deferring, disposal and basic update logic.

```csharp
public abstract class AudioComponent : IDisposable, IUpdateable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AudioComponent](osu.Framework.Audio.AudioComponent.md)

#### Derived

[AdjustableAudioComponent](osu.Framework.Audio.AdjustableAudioComponent.md), 
[AudioMixer](osu.Framework.Audio.Mixing.AudioMixer.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IUpdateable](osu.Framework.IUpdateable.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AudioComponent\>\(AudioComponent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AudioComponent\>\(AudioComponent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AudioComponent\>\(AudioComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AudioComponent\>\(AudioComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AudioComponent, TChild\>\(AudioComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AudioComponent, TChild\>\(AudioComponent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AudioComponent, TChild\>\(AudioComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AudioComponent\>\(AudioComponent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Audio_AudioComponent_IsDisposed"></a> IsDisposed

```csharp
protected volatile bool IsDisposed
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioComponent_PendingActions"></a> PendingActions

Audio operations will be run on a separate dedicated thread, so we need to schedule any audio API calls using this queue.

```csharp
protected ConcurrentQueue<Task> PendingActions
```

#### Field Value

 [ConcurrentQueue](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.concurrentqueue\-1)<[Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)\>

## Properties

### <a id="osu_Framework_Audio_AudioComponent_CanPerformInline"></a> CanPerformInline

Whether an audio thread specific action can be performed inline.

```csharp
protected bool CanPerformInline { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioComponent_HasCompleted"></a> HasCompleted

Whether this component has completed playback and is in a stopped state.

```csharp
public virtual bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioComponent_IsAlive"></a> IsAlive

When false, this component has completed all processing and is ready to be removed from its parent.

```csharp
public virtual bool IsAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioComponent_IsLoaded"></a> IsLoaded

Whether this component has finished loading its resources.

```csharp
public virtual bool IsLoaded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Audio_AudioComponent_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Audio_AudioComponent_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Audio_AudioComponent_EnqueueAction_System_Action_"></a> EnqueueAction\(Action\)

Enqueues an action to be performed on the audio thread.

```csharp
protected Task EnqueueAction(Action action)
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The action to perform.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

A task which can be used for continuation logic. May return a <xref href="System.Threading.Tasks.Task.CompletedTask" data-throw-if-not-resolved="false"></xref> if called while already on the audio thread.

### <a id="osu_Framework_Audio_AudioComponent_Update"></a> Update\(\)

Updates this audio component. Always runs on the audio thread.

```csharp
public void Update()
```

### <a id="osu_Framework_Audio_AudioComponent_UpdateChildren"></a> UpdateChildren\(\)

Run each loop of the audio thread's execution, after <xref href="osu.Framework.Audio.AudioComponent.UpdateState" data-throw-if-not-resolved="false"></xref> as a way to update any child components.

```csharp
protected virtual void UpdateChildren()
```

### <a id="osu_Framework_Audio_AudioComponent_UpdateState"></a> UpdateState\(\)

Run each loop of the audio thread's execution after queued actions are completed to allow components to perform any additional operations.

```csharp
protected virtual void UpdateState()
```

