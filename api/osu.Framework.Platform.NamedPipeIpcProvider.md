# <a id="osu_Framework_Platform_NamedPipeIpcProvider"></a> Class NamedPipeIpcProvider

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

An inter-process communication provider that runs over a specified named pipe.
This single class handles both binding as a server, or messaging another bound instance that is acting as a server.

```csharp
public class NamedPipeIpcProvider : IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[NamedPipeIpcProvider](osu.Framework.Platform.NamedPipeIpcProvider.md)

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

[ObjectExtensions.AsNonNull<NamedPipeIpcProvider\>\(NamedPipeIpcProvider?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<NamedPipeIpcProvider\>\(NamedPipeIpcProvider\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<NamedPipeIpcProvider\>\(NamedPipeIpcProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<NamedPipeIpcProvider\>\(NamedPipeIpcProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<NamedPipeIpcProvider, TChild\>\(NamedPipeIpcProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<NamedPipeIpcProvider, TChild\>\(NamedPipeIpcProvider, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<NamedPipeIpcProvider, TChild\>\(NamedPipeIpcProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<NamedPipeIpcProvider\>\(NamedPipeIpcProvider\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_NamedPipeIpcProvider__ctor_System_String_"></a> NamedPipeIpcProvider\(string\)

Create a new provider.

```csharp
public NamedPipeIpcProvider(string pipeName)
```

#### Parameters

`pipeName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The port to operate on.

## Methods

### <a id="osu_Framework_Platform_NamedPipeIpcProvider_Bind"></a> Bind\(\)

Attempt to bind to the named pipe as a server, and start listening for incoming connections if successful.

```csharp
public bool Bind()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the bind was successful.
If <code>false</code>, another instance is likely already running (and can be messaged using <xref href="osu.Framework.Platform.NamedPipeIpcProvider.SendMessageAsync(osu.Framework.Platform.IpcMessage)" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Platform.NamedPipeIpcProvider.SendMessageWithResponseAsync(osu.Framework.Platform.IpcMessage)" data-throw-if-not-resolved="false"></xref>).

### <a id="osu_Framework_Platform_NamedPipeIpcProvider_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Platform_NamedPipeIpcProvider_SendMessageAsync_osu_Framework_Platform_IpcMessage_"></a> SendMessageAsync\(IpcMessage\)

Send a message to the IPC server.

```csharp
public Task SendMessageAsync(IpcMessage message)
```

#### Parameters

`message` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

The message to send.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="osu_Framework_Platform_NamedPipeIpcProvider_SendMessageWithResponseAsync_osu_Framework_Platform_IpcMessage_"></a> SendMessageWithResponseAsync\(IpcMessage\)

Send a message to the IPC server.

```csharp
public Task<IpcMessage?> SendMessageWithResponseAsync(IpcMessage message)
```

#### Parameters

`message` [IpcMessage](osu.Framework.Platform.IpcMessage.md)

The message to send.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[IpcMessage](osu.Framework.Platform.IpcMessage.md)?\>

The response from the server.

### <a id="osu_Framework_Platform_NamedPipeIpcProvider_MessageReceived"></a> MessageReceived

Invoked when a message is received when running as a server.
Returns either a response in the form of an <xref href="osu.Framework.Platform.IpcMessage" data-throw-if-not-resolved="false"></xref>, or <code>null</code> for no response.

```csharp
public event Func<IpcMessage, IpcMessage?>? MessageReceived
```

#### Event Type

 [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IpcMessage](osu.Framework.Platform.IpcMessage.md), [IpcMessage](osu.Framework.Platform.IpcMessage.md)?\>?

