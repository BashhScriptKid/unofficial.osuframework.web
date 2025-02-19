# <a id="osu_Framework_Platform_IpcChannel_1"></a> Class IpcChannel<T\>

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Define an IPC channel which supports sending a specific well-defined type.

```csharp
public class IpcChannel<T> : IpcChannel<T, object>, IDisposable where T : class
```

#### Type Parameters

`T` 

The type to send.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IpcChannel<T, object\>](osu.Framework.Platform.IpcChannel\-2.md) ← 
[IpcChannel<T\>](osu.Framework.Platform.IpcChannel\-1.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[IpcChannel<T, object\>.MessageReceived](osu.Framework.Platform.IpcChannel\-2.md\#osu\_Framework\_Platform\_IpcChannel\_2\_MessageReceived), 
[IpcChannel<T, object\>.SendMessageAsync\(T\)](osu.Framework.Platform.IpcChannel\-2.md\#osu\_Framework\_Platform\_IpcChannel\_2\_SendMessageAsync\_\_0\_), 
[IpcChannel<T, object\>.SendMessageWithResponseAsync\(T\)](osu.Framework.Platform.IpcChannel\-2.md\#osu\_Framework\_Platform\_IpcChannel\_2\_SendMessageWithResponseAsync\_\_0\_), 
[IpcChannel<T, object\>.Dispose\(\)](osu.Framework.Platform.IpcChannel\-2.md\#osu\_Framework\_Platform\_IpcChannel\_2\_Dispose), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IpcChannel<T\>\>\(IpcChannel<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IpcChannel<T\>\>\(IpcChannel<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IpcChannel<T\>\>\(IpcChannel<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IpcChannel<T\>\>\(IpcChannel<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IpcChannel<T\>, TChild\>\(IpcChannel<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IpcChannel<T\>, TChild\>\(IpcChannel<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IpcChannel<T\>, TChild\>\(IpcChannel<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IpcChannel<T\>\>\(IpcChannel<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_IpcChannel_1__ctor_osu_Framework_Platform_IIpcHost_"></a> IpcChannel\(IIpcHost\)

```csharp
public IpcChannel(IIpcHost host)
```

#### Parameters

`host` [IIpcHost](osu.Framework.Platform.IIpcHost.md)

