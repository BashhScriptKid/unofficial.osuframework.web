# <a id="osu_Framework_Allocation_IReadOnlyDependencyContainer"></a> Interface IReadOnlyDependencyContainer

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

Read-only interface into a dependency container capable of injective and retrieving dependencies based
on types.

```csharp
public interface IReadOnlyDependencyContainer
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IReadOnlyDependencyContainer\>\(IReadOnlyDependencyContainer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ReadOnlyDependencyContainerExtensions.Get<T\>\(IReadOnlyDependencyContainer\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_Get\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[ReadOnlyDependencyContainerExtensions.Get<T\>\(IReadOnlyDependencyContainer, CacheInfo\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_Get\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_osu\_Framework\_Allocation\_CacheInfo\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IReadOnlyDependencyContainer\>\(IReadOnlyDependencyContainer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IReadOnlyDependencyContainer\>\(IReadOnlyDependencyContainer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IReadOnlyDependencyContainer\>\(IReadOnlyDependencyContainer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ReadOnlyDependencyContainerExtensions.TryGet<T\>\(IReadOnlyDependencyContainer, out T\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_TryGet\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_\_\_0\_\_), 
[ReadOnlyDependencyContainerExtensions.TryGet<T\>\(IReadOnlyDependencyContainer, out T, CacheInfo\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_TryGet\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_\_\_0\_\_osu\_Framework\_Allocation\_CacheInfo\_), 
[ContainerExtensions.WithChild<IReadOnlyDependencyContainer, TChild\>\(IReadOnlyDependencyContainer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IReadOnlyDependencyContainer, TChild\>\(IReadOnlyDependencyContainer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IReadOnlyDependencyContainer, TChild\>\(IReadOnlyDependencyContainer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IReadOnlyDependencyContainer\>\(IReadOnlyDependencyContainer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Allocation_IReadOnlyDependencyContainer_Get_System_Type_"></a> Get\(Type\)

Retrieves a cached dependency of <code class="paramref">type</code> if it exists and null otherwise.

```csharp
object Get(Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The dependency type to query for.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

The requested dependency, or null if not found.

### <a id="osu_Framework_Allocation_IReadOnlyDependencyContainer_Get_System_Type_osu_Framework_Allocation_CacheInfo_"></a> Get\(Type, CacheInfo\)

Retrieves a cached dependency of <code class="paramref">type</code> if it exists and null otherwise.

```csharp
object Get(Type type, CacheInfo info)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The dependency type to query for.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information that identifies the cached dependency.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)

The requested dependency, or null if not found.

### <a id="osu_Framework_Allocation_IReadOnlyDependencyContainer_Inject__1___0_"></a> Inject<T\>\(T\)

Injects dependencies into the given instance.

```csharp
void Inject<T>(T instance) where T : class, IDependencyInjectionCandidate
```

#### Parameters

`instance` T

The instance to inject dependencies into.

#### Type Parameters

`T` 

The type of the instance to inject dependencies into.

