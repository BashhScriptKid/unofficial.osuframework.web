# <a id="osu_Framework_IO_Stores_DllResourceStore"></a> Class DllResourceStore

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

```csharp
public class DllResourceStore : IResourceStore<byte[]>, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DllResourceStore](osu.Framework.IO.Stores.DllResourceStore.md)

#### Implements

[IResourceStore<byte\[\]\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
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

[ObjectExtensions.AsNonNull<DllResourceStore\>\(DllResourceStore?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DllResourceStore\>\(DllResourceStore\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DllResourceStore\>\(DllResourceStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DllResourceStore\>\(DllResourceStore\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DllResourceStore, TChild\>\(DllResourceStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DllResourceStore, TChild\>\(DllResourceStore, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DllResourceStore, TChild\>\(DllResourceStore, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DllResourceStore\>\(DllResourceStore\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Stores_DllResourceStore__ctor_System_String_"></a> DllResourceStore\(string\)

```csharp
public DllResourceStore(string dllName)
```

#### Parameters

`dllName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Stores_DllResourceStore__ctor_System_Reflection_AssemblyName_"></a> DllResourceStore\(AssemblyName\)

```csharp
public DllResourceStore(AssemblyName name)
```

#### Parameters

`name` [AssemblyName](https://learn.microsoft.com/dotnet/api/system.reflection.assemblyname)

### <a id="osu_Framework_IO_Stores_DllResourceStore__ctor_System_Reflection_Assembly_"></a> DllResourceStore\(Assembly\)

```csharp
public DllResourceStore(Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

## Methods

### <a id="osu_Framework_IO_Stores_DllResourceStore_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_IO_Stores_DllResourceStore_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
public byte[] Get(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

The object.

### <a id="osu_Framework_IO_Stores_DllResourceStore_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public virtual Task<byte[]> GetAsync(string name, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]\>

The object.

### <a id="osu_Framework_IO_Stores_DllResourceStore_GetAvailableResources"></a> GetAvailableResources\(\)

Retrieve a list of available resources provided by this store.

```csharp
public IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_IO_Stores_DllResourceStore_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

