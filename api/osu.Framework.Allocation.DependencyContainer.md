# <a id="osu_Framework_Allocation_DependencyContainer"></a> Class DependencyContainer

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

Hierarchically caches dependencies and can inject those automatically into types registered for dependency injection.

```csharp
public class DependencyContainer : IReadOnlyDependencyContainer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DependencyContainer](osu.Framework.Allocation.DependencyContainer.md)

#### Implements

[IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DependencyContainer\>\(DependencyContainer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ReadOnlyDependencyContainerExtensions.Get<T\>\(IReadOnlyDependencyContainer\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_Get\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[ReadOnlyDependencyContainerExtensions.Get<T\>\(IReadOnlyDependencyContainer, CacheInfo\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_Get\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_osu\_Framework\_Allocation\_CacheInfo\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DependencyContainer\>\(DependencyContainer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DependencyContainer\>\(DependencyContainer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DependencyContainer\>\(DependencyContainer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ReadOnlyDependencyContainerExtensions.TryGet<T\>\(IReadOnlyDependencyContainer, out T\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_TryGet\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_\_\_0\_\_), 
[ReadOnlyDependencyContainerExtensions.TryGet<T\>\(IReadOnlyDependencyContainer, out T, CacheInfo\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_TryGet\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_\_\_0\_\_osu\_Framework\_Allocation\_CacheInfo\_), 
[ContainerExtensions.WithChild<DependencyContainer, TChild\>\(DependencyContainer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DependencyContainer, TChild\>\(DependencyContainer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DependencyContainer, TChild\>\(DependencyContainer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DependencyContainer\>\(DependencyContainer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Allocation_DependencyContainer__ctor_osu_Framework_Allocation_IReadOnlyDependencyContainer_"></a> DependencyContainer\(IReadOnlyDependencyContainer\)

Create a new DependencyContainer instance.

```csharp
public DependencyContainer(IReadOnlyDependencyContainer parent = null)
```

#### Parameters

`parent` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

An optional parent container which we should use as a fallback for cache lookups.

## Methods

### <a id="osu_Framework_Allocation_DependencyContainer_Cache_System_Object_"></a> Cache\(object\)

Caches an instance of a type as its most derived type. This instance will be returned each time you <xref href="osu.Framework.Allocation.DependencyContainer.Get(System.Type)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Cache(object instance)
```

#### Parameters

`instance` [object](https://learn.microsoft.com/dotnet/api/system.object)

The instance to cache.

### <a id="osu_Framework_Allocation_DependencyContainer_Cache_System_Object_osu_Framework_Allocation_CacheInfo_"></a> Cache\(object, CacheInfo\)

Caches an instance of a type as its most derived type. This instance will be returned each time you <xref href="osu.Framework.Allocation.DependencyContainer.Get(System.Type)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Cache(object instance, CacheInfo info)
```

#### Parameters

`instance` [object](https://learn.microsoft.com/dotnet/api/system.object)

The instance to cache.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information to identify <code class="paramref">instance</code> in the cache.

### <a id="osu_Framework_Allocation_DependencyContainer_CacheAs__1___0_"></a> CacheAs<T\>\(T\)

Caches an instance of a type as a type of <code class="typeparamref">T</code>. This instance will be returned each time you <xref href="osu.Framework.Allocation.DependencyContainer.Get(System.Type)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void CacheAs<T>(T instance) where T : class
```

#### Parameters

`instance` T

The instance to cache. Must be or derive from <code class="typeparamref">T</code>.

#### Type Parameters

`T` 

### <a id="osu_Framework_Allocation_DependencyContainer_CacheAs__1___0_osu_Framework_Allocation_CacheInfo_"></a> CacheAs<T\>\(T, CacheInfo\)

Caches an instance of a type as a type of <code class="typeparamref">T</code>. This instance will be returned each time you <xref href="osu.Framework.Allocation.DependencyContainer.Get(System.Type)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void CacheAs<T>(T instance, CacheInfo info) where T : class
```

#### Parameters

`instance` T

The instance to cache. Must be or derive from <code class="typeparamref">T</code>.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information to identify <code class="paramref">instance</code> in the cache.

#### Type Parameters

`T` 

### <a id="osu_Framework_Allocation_DependencyContainer_CacheAs__1_System_Type___0_"></a> CacheAs<T\>\(Type, T\)

Caches an instance of a type as a type of <code class="paramref">type</code>. This instance will be returned each time you <xref href="osu.Framework.Allocation.DependencyContainer.Get(System.Type)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void CacheAs<T>(Type type, T instance) where T : class
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type to cache <code class="paramref">instance</code> as.

`instance` T

The instance to cache. Must be or derive from <code class="paramref">type</code>.

#### Type Parameters

`T` 

### <a id="osu_Framework_Allocation_DependencyContainer_CacheAs__1_System_Type___0_osu_Framework_Allocation_CacheInfo_"></a> CacheAs<T\>\(Type, T, CacheInfo\)

Caches an instance of a type as a type of <code class="paramref">type</code>. This instance will be returned each time you <xref href="osu.Framework.Allocation.DependencyContainer.Get(System.Type)" data-throw-if-not-resolved="false"></xref>.

```csharp
public void CacheAs<T>(Type type, T instance, CacheInfo info) where T : class
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type to cache <code class="paramref">instance</code> as.

`instance` T

The instance to cache. Must be or derive from <code class="paramref">type</code>.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information to identify <code class="paramref">instance</code> in the cache.

#### Type Parameters

`T` 

### <a id="osu_Framework_Allocation_DependencyContainer_Get_System_Type_"></a> Get\(Type\)

Retrieves a cached dependency of <code class="paramref">type</code> if it exists and null otherwise.

```csharp
public object Get(Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The dependency type to query for.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

The requested dependency, or null if not found.

### <a id="osu_Framework_Allocation_DependencyContainer_Get_System_Type_osu_Framework_Allocation_CacheInfo_"></a> Get\(Type, CacheInfo\)

Retrieves a cached dependency of <code class="paramref">type</code> if it exists and null otherwise.

```csharp
public object Get(Type type, CacheInfo info)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The dependency type to query for.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information that identifies the cached dependency.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

The requested dependency, or null if not found.

### <a id="osu_Framework_Allocation_DependencyContainer_Inject__1___0_"></a> Inject<T\>\(T\)

Injects dependencies into the given instance.

```csharp
public void Inject<T>(T instance) where T : class, IDependencyInjectionCandidate
```

#### Parameters

`instance` T

The instance to inject dependencies into.

#### Type Parameters

`T` 

The type of the instance to inject dependencies into.

#### Exceptions

 [OperationCanceledException](https://learn.microsoft.com/dotnet/api/system.operationcanceledexception)

When the injection process was cancelled.

