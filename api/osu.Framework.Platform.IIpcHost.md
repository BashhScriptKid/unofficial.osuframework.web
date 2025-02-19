# <a id="osu_Framework_Platform_IIpcHost"></a> Interface IIpcHost

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IIpcHost
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IIpcHost\>\(IIpcHost?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IIpcHost\>\(IIpcHost\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IIpcHost\>\(IIpcHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IIpcHost\>\(IIpcHost\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IIpcHost, TChild\>\(IIpcHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IIpcHost, TChild\>\(IIpcHost, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IIpcHost, TChild\>\(IIpcHost, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IIpcHost\>\(IIpcHost\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Platform_IIpcHost_SendMessageAsync_osu_Framework_Platform_IpcMessage_"></a> SendMessageAsync\(IpcMessage\)

Asynchronously send a message to the IPC server.

```csharp
Task SendMessageAsync(IpcMessage ipcMessage)
```

#### Parameters

`ipcMessage` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

The message to send.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Platform_IIpcHost_SendMessageWithResponseAsync_osu_Framework_Platform_IpcMessage_"></a> SendMessageWithResponseAsync\(IpcMessage\)

Asynchronously send a message to the IPC server and receive a response.

```csharp
Task<IpcMessage?> SendMessageWithResponseAsync(IpcMessage message)
```

#### Parameters

`message` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

The message to send.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[IpcMessage](osu.Framework.Platform.IpcMessage.md)?\>

The response from the server.

### <a id="osu_Framework_Platform_IIpcHost_MessageReceived"></a> MessageReceived

Invoked when a message is received by this IPC server.
Returns either a response in the form of an <xref href="osu.Framework.Platform.IpcMessage" data-throw-if-not-resolved="false"></xref>, or <code>null</code> for no response.

```csharp
event Func<IpcMessage, IpcMessage?>? MessageReceived
```

#### Event Type

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IpcMessage](osu.Framework.Platform.IpcMessage.md), [IpcMessage](osu.Framework.Platform.IpcMessage.md)?\>?

