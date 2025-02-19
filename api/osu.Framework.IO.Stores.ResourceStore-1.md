# <a id="osu_Framework_IO_Stores_ResourceStore_1"></a> Class ResourceStore<T\>

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

```csharp
public class ResourceStore<T> : IResourceStore<T>, IDisposable where T : class
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ResourceStore<T\>](osu.Framework.IO.Stores.ResourceStore\-1.md)

#### Implements

[IResourceStore<T\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
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

[ObjectExtensions.AsNonNull<ResourceStore<T\>\>\(ResourceStore<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ResourceStore<T\>\>\(ResourceStore<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ResourceStore<T\>\>\(ResourceStore<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ResourceStore<T\>\>\(ResourceStore<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ResourceStore<T\>, TChild\>\(ResourceStore<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ResourceStore<T\>, TChild\>\(ResourceStore<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ResourceStore<T\>, TChild\>\(ResourceStore<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ResourceStore<T\>\>\(ResourceStore<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Stores_ResourceStore_1__ctor"></a> ResourceStore\(\)

Initializes a resource store with no stores.

```csharp
public ResourceStore()
```

### <a id="osu_Framework_IO_Stores_ResourceStore_1__ctor_osu_Framework_IO_Stores_IResourceStore__0__"></a> ResourceStore\(IResourceStore<T\>\)

Initializes a resource store with a single store.

```csharp
public ResourceStore(IResourceStore<T> store = null)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<T\>

The store.

### <a id="osu_Framework_IO_Stores_ResourceStore_1__ctor_osu_Framework_IO_Stores_IResourceStore__0____"></a> ResourceStore\(IResourceStore<T\>\[\]\)

Initializes a resource store with a collection of stores.

```csharp
public ResourceStore(IResourceStore<T>[] stores)
```

#### Parameters

`stores` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<T\>\[\]

The collection of stores.

## Methods

### <a id="osu_Framework_IO_Stores_ResourceStore_1_AddExtension_System_String_"></a> AddExtension\(string\)

Add a file extension to automatically append to any lookups on this store.

```csharp
public void AddExtension(string extension)
```

#### Parameters

`extension` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_IO_Stores_ResourceStore_1_AddStore_osu_Framework_IO_Stores_IResourceStore__0__"></a> AddStore\(IResourceStore<T\>\)

Adds a nested resource store to this store.

```csharp
public virtual void AddStore(IResourceStore<T> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<T\>

The store to add.

### <a id="osu_Framework_IO_Stores_ResourceStore_1_BindReload_System_String_System_Action_"></a> BindReload\(string, Action\)

Binds a reload function to an object held by the store.

```csharp
public void BindReload(string name, Action onReload)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

`onReload` [Action](https://learn.microsoft.com/dotnet/api/system.action)

The reload function to bind.

### <a id="osu_Framework_IO_Stores_ResourceStore_1_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="osu_Framework_IO_Stores_ResourceStore_1_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_IO_Stores_ResourceStore_1_Get_System_String_"></a> Get\(string\)

Retrieves an object from the store.

```csharp
public virtual T Get(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

#### Returns

 T

The object.

### <a id="osu_Framework_IO_Stores_ResourceStore_1_GetAsync_System_String_System_Threading_CancellationToken_"></a> GetAsync\(string, CancellationToken\)

Retrieves an object from the store asynchronously.

```csharp
public virtual Task<T> GetAsync(string name, CancellationToken cancellationToken = default)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the object.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A cancellation token.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<T\>

The object.

### <a id="osu_Framework_IO_Stores_ResourceStore_1_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public virtual IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_IO_Stores_ResourceStore_1_GetFilenames_System_String_"></a> GetFilenames\(string\)

```csharp
protected virtual IEnumerable<string> GetFilenames(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="osu_Framework_IO_Stores_ResourceStore_1_GetStream_System_String_"></a> GetStream\(string\)

```csharp
public Stream GetStream(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

### <a id="osu_Framework_IO_Stores_ResourceStore_1_NotifyChanged_System_String_"></a> NotifyChanged\(string\)

Notifies a bound delegate that the resource has changed.

```csharp
protected virtual void NotifyChanged(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The resource that has changed.

### <a id="osu_Framework_IO_Stores_ResourceStore_1_RemoveStore_osu_Framework_IO_Stores_IResourceStore__0__"></a> RemoveStore\(IResourceStore<T\>\)

Removes a store from this store.

```csharp
public virtual void RemoveStore(IResourceStore<T> store)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<T\>

The store to remove.

