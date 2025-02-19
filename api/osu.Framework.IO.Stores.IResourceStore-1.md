# <a id="osu_Framework_IO_Stores_IResourceStore_1"></a> Interface IResourceStore<T\>

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IResourceStore<T> : IDisposable where T : class
```

#### Type Parameters

`T` 

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ObjectExtensions.AsNonNull<IResourceStore<T\>\>\(IResourceStore<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IResourceStore<T\>\>\(IResourceStore<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IResourceStore<T\>\>\(IResourceStore<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IResourceStore<T\>\>\(IResourceStore<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IResourceStore<T\>, TChild\>\(IResourceStore<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IResourceStore<T\>, TChild\>\(IResourceStore<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IResourceStore<T\>, TChild\>\(IResourceStore<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IResourceStore<T\>\>\(IResourceStore<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_IO_Stores_IResourceStore_1_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
T Get(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

#### Returns

 T

The object.

### <a id="osu_Framework_IO_Stores_IResourceStore_1_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
Task<T> GetAsync(string name, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<T\>

The object.

### <a id="osu_Framework_IO_Stores_IResourceStore_1_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_IO_Stores_IResourceStore_1_GetStream_System_String_"></a> GetStream\(string\)

```csharp
Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

