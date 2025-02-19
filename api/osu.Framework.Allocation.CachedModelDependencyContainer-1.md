# <a id="osu_Framework_Allocation_CachedModelDependencyContainer_1"></a> Class CachedModelDependencyContainer<TModel\>

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

A <xref href="osu.Framework.Allocation.DependencyContainer" data-throw-if-not-resolved="false"></xref> which caches a <code class="typeparamref">TModel</code> and members it contains attached with a <xref href="osu.Framework.Allocation.CachedAttribute" data-throw-if-not-resolved="false"></xref> as dependencies.

```csharp
public class CachedModelDependencyContainer<TModel> : IReadOnlyDependencyContainer where TModel : class?, IDependencyInjectionCandidate?, new()
```

#### Type Parameters

`TModel` 

The type of the model to cache. Must contain only <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> fields or auto-properties.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CachedModelDependencyContainer<TModel\>](osu.Framework.Allocation.CachedModelDependencyContainer\-1.md)

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

[ObjectExtensions.AsNonNull<CachedModelDependencyContainer<TModel\>\>\(CachedModelDependencyContainer<TModel\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ReadOnlyDependencyContainerExtensions.Get<T\>\(IReadOnlyDependencyContainer\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_Get\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[ReadOnlyDependencyContainerExtensions.Get<T\>\(IReadOnlyDependencyContainer, CacheInfo\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_Get\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_osu\_Framework\_Allocation\_CacheInfo\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CachedModelDependencyContainer<TModel\>\>\(CachedModelDependencyContainer<TModel\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CachedModelDependencyContainer<TModel\>\>\(CachedModelDependencyContainer<TModel\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CachedModelDependencyContainer<TModel\>\>\(CachedModelDependencyContainer<TModel\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ReadOnlyDependencyContainerExtensions.TryGet<T\>\(IReadOnlyDependencyContainer, out T\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_TryGet\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_\_\_0\_\_), 
[ReadOnlyDependencyContainerExtensions.TryGet<T\>\(IReadOnlyDependencyContainer, out T, CacheInfo\)](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md\#osu\_Framework\_Allocation\_ReadOnlyDependencyContainerExtensions\_TryGet\_\_1\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_\_\_0\_\_osu\_Framework\_Allocation\_CacheInfo\_), 
[ContainerExtensions.WithChild<CachedModelDependencyContainer<TModel\>, TChild\>\(CachedModelDependencyContainer<TModel\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CachedModelDependencyContainer<TModel\>, TChild\>\(CachedModelDependencyContainer<TModel\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CachedModelDependencyContainer<TModel\>, TChild\>\(CachedModelDependencyContainer<TModel\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CachedModelDependencyContainer<TModel\>\>\(CachedModelDependencyContainer<TModel\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Remarks

Users can query the model by directly querying for the <code class="typeparamref">TModel</code> type,
and query for the model's dependencies by providing the <code class="typeparamref">TModel</code> type as a parent.

## Constructors

### <a id="osu_Framework_Allocation_CachedModelDependencyContainer_1__ctor_osu_Framework_Allocation_IReadOnlyDependencyContainer_"></a> CachedModelDependencyContainer\(IReadOnlyDependencyContainer?\)

```csharp
public CachedModelDependencyContainer(IReadOnlyDependencyContainer? parent)
```

#### Parameters

`parent` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)?

## Fields

### <a id="osu_Framework_Allocation_CachedModelDependencyContainer_1_Model"></a> Model

The <code class="typeparamref">TModel</code> that provides the cached values.

```csharp
public readonly Bindable<TModel> Model
```

#### Field Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TModel\>

#### Remarks

This model is not injected directly, users of the <xref href="osu.Framework.Allocation.CachedModelDependencyContainer%601" data-throw-if-not-resolved="false"></xref> receive a shadow-bound copy of this value in all cases.

## Methods

### <a id="osu_Framework_Allocation_CachedModelDependencyContainer_1_Get_System_Type_"></a> Get\(Type\)

Retrieves a cached dependency of <code class="paramref">type</code> if it exists and null otherwise.

```csharp
public object? Get(Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The dependency type to query for.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)?

The requested dependency, or null if not found.

### <a id="osu_Framework_Allocation_CachedModelDependencyContainer_1_Get_System_Type_osu_Framework_Allocation_CacheInfo_"></a> Get\(Type, CacheInfo\)

Retrieves a cached dependency of <code class="paramref">type</code> if it exists and null otherwise.

```csharp
public object? Get(Type type, CacheInfo info)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The dependency type to query for.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information that identifies the cached dependency.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)?

The requested dependency, or null if not found.

### <a id="osu_Framework_Allocation_CachedModelDependencyContainer_1_Inject__1___0_"></a> Inject<T\>\(T\)

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

