# <a id="osu_Framework_Platform_IpcChannel_2"></a> Class IpcChannel<T, TResponse\>

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Define an IPC channel which supports sending and receiving a specific well-defined type.

```csharp
public class IpcChannel<T, TResponse> : IDisposable where T : class where TResponse : class
```

#### Type Parameters

`T` 

The type to send.

`TResponse` 

The type to receive.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IpcChannel<T, TResponse\>](osu.Framework.Platform.IpcChannel\-2.md)

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

[ObjectExtensions.AsNonNull<IpcChannel<T, TResponse\>\>\(IpcChannel<T, TResponse\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IpcChannel<T, TResponse\>\>\(IpcChannel<T, TResponse\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IpcChannel<T, TResponse\>\>\(IpcChannel<T, TResponse\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IpcChannel<T, TResponse\>\>\(IpcChannel<T, TResponse\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IpcChannel<T, TResponse\>, TChild\>\(IpcChannel<T, TResponse\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IpcChannel<T, TResponse\>, TChild\>\(IpcChannel<T, TResponse\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IpcChannel<T, TResponse\>, TChild\>\(IpcChannel<T, TResponse\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IpcChannel<T, TResponse\>\>\(IpcChannel<T, TResponse\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_IpcChannel_2__ctor_osu_Framework_Platform_IIpcHost_"></a> IpcChannel\(IIpcHost\)

```csharp
public IpcChannel(IIpcHost host)
```

#### Parameters

`host` [IIpcHost](osu.Framework.Platform.IIpcHost.md)

## Methods

### <a id="osu_Framework_Platform_IpcChannel_2_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Platform_IpcChannel_2_SendMessageAsync__0_"></a> SendMessageAsync\(T\)

```csharp
public Task SendMessageAsync(T message)
```

#### Parameters

`message` T

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Platform_IpcChannel_2_SendMessageWithResponseAsync__0_"></a> SendMessageWithResponseAsync\(T\)

```csharp
public Task<TResponse?> SendMessageWithResponseAsync(T message)
```

#### Parameters

`message` T

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<TResponse?\>

### <a id="osu_Framework_Platform_IpcChannel_2_MessageReceived"></a> MessageReceived

```csharp
public event Func<T, TResponse?>? MessageReceived
```

#### Event Type

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<T, TResponse?\>?

