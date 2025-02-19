# <a id="osu_Framework_IO_Stores_NamespacedResourceStore_1"></a> Class NamespacedResourceStore<T\>

Namespace: [osu.Framework.IO.Stores](osu.Framework.IO.Stores.md)  
Assembly: osu.Framework.dll  

```csharp
public class NamespacedResourceStore<T> : ResourceStore<T>, IResourceStore<T>, IDisposable where T : class
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ResourceStore<T\>](osu.Framework.IO.Stores.ResourceStore\-1.md) ← 
[NamespacedResourceStore<T\>](osu.Framework.IO.Stores.NamespacedResourceStore\-1.md)

#### Implements

[IResourceStore<T\>](osu.Framework.IO.Stores.IResourceStore\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[ResourceStore<T\>.NotifyChanged\(string\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_NotifyChanged\_System\_String\_), 
[ResourceStore<T\>.AddStore\(IResourceStore<T\>\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_AddStore\_osu\_Framework\_IO\_Stores\_IResourceStore\_\_0\_\_), 
[ResourceStore<T\>.RemoveStore\(IResourceStore<T\>\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_RemoveStore\_osu\_Framework\_IO\_Stores\_IResourceStore\_\_0\_\_), 
[ResourceStore<T\>.GetAsync\(string, CancellationToken\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_GetAsync\_System\_String\_System\_Threading\_CancellationToken\_), 
[ResourceStore<T\>.Get\(string\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_Get\_System\_String\_), 
[ResourceStore<T\>.GetStream\(string\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_GetStream\_System\_String\_), 
[ResourceStore<T\>.GetFilenames\(string\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_GetFilenames\_System\_String\_), 
[ResourceStore<T\>.BindReload\(string, Action\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_BindReload\_System\_String\_System\_Action\_), 
[ResourceStore<T\>.AddExtension\(string\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_AddExtension\_System\_String\_), 
[ResourceStore<T\>.GetAvailableResources\(\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_GetAvailableResources), 
[ResourceStore<T\>.Dispose\(\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_Dispose), 
[ResourceStore<T\>.Dispose\(bool\)](osu.Framework.IO.Stores.ResourceStore\-1.md\#osu\_Framework\_IO\_Stores\_ResourceStore\_1\_Dispose\_System\_Boolean\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<NamespacedResourceStore<T\>\>\(NamespacedResourceStore<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<NamespacedResourceStore<T\>\>\(NamespacedResourceStore<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<NamespacedResourceStore<T\>\>\(NamespacedResourceStore<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<NamespacedResourceStore<T\>\>\(NamespacedResourceStore<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<NamespacedResourceStore<T\>, TChild\>\(NamespacedResourceStore<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<NamespacedResourceStore<T\>, TChild\>\(NamespacedResourceStore<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<NamespacedResourceStore<T\>, TChild\>\(NamespacedResourceStore<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<NamespacedResourceStore<T\>\>\(NamespacedResourceStore<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_IO_Stores_NamespacedResourceStore_1__ctor_osu_Framework_IO_Stores_IResourceStore__0__System_String_"></a> NamespacedResourceStore\(IResourceStore<T\>, string\)

Initializes a resource store with a single store.

```csharp
public NamespacedResourceStore(IResourceStore<T> store, string ns)
```

#### Parameters

`store` [IResourceStore](osu.Framework.IO.Stores.IResourceStore\-1.md)<T\>

The store.

`ns` [string](https://learn.microsoft.com/dotnet/api/system.string)

The namespace to add.

## Fields

### <a id="osu_Framework_IO_Stores_NamespacedResourceStore_1_Namespace"></a> Namespace

```csharp
public string Namespace
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_IO_Stores_NamespacedResourceStore_1_GetAvailableResources"></a> GetAvailableResources\(\)

Gets a collection of string representations of the resources available in this store.

```csharp
public override IEnumerable<string> GetAvailableResources()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

String representations of the resources available.

### <a id="osu_Framework_IO_Stores_NamespacedResourceStore_1_GetFilenames_System_String_"></a> GetFilenames\(string\)

```csharp
protected override IEnumerable<string> GetFilenames(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

