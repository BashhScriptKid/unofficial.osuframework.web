# <a id="osu_Framework_Allocation_ReadOnlyDependencyContainerExtensions"></a> Class ReadOnlyDependencyContainerExtensions

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

```csharp
public static class ReadOnlyDependencyContainerExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ReadOnlyDependencyContainerExtensions](osu.Framework.Allocation.ReadOnlyDependencyContainerExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Allocation_ReadOnlyDependencyContainerExtensions_Get__1_osu_Framework_Allocation_IReadOnlyDependencyContainer_"></a> Get<T\>\(IReadOnlyDependencyContainer\)

Retrieves a cached dependency of type <code class="typeparamref">T</code> if it exists, and null otherwise.

```csharp
public static T Get<T>(this IReadOnlyDependencyContainer container) where T : class
```

#### Parameters

`container` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> to query.

#### Returns

 T

The requested dependency, or null if not found.

#### Type Parameters

`T` 

The dependency type to query for.

### <a id="osu_Framework_Allocation_ReadOnlyDependencyContainerExtensions_Get__1_osu_Framework_Allocation_IReadOnlyDependencyContainer_osu_Framework_Allocation_CacheInfo_"></a> Get<T\>\(IReadOnlyDependencyContainer, CacheInfo\)

Retrieves a cached dependency of type <code class="typeparamref">T</code> if it exists, and null otherwise.

```csharp
public static T Get<T>(this IReadOnlyDependencyContainer container, CacheInfo info) where T : class
```

#### Parameters

`container` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> to query.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information that identifies the cached dependency.

#### Returns

 T

The requested dependency, or null if not found.

#### Type Parameters

`T` 

The dependency type to query for.

### <a id="osu_Framework_Allocation_ReadOnlyDependencyContainerExtensions_TryGet__1_osu_Framework_Allocation_IReadOnlyDependencyContainer___0__"></a> TryGet<T\>\(IReadOnlyDependencyContainer, out T\)

Tries to retrieve a cached dependency of type <code class="typeparamref">T</code>.

```csharp
public static bool TryGet<T>(this IReadOnlyDependencyContainer container, out T value) where T : class
```

#### Parameters

`container` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> to query.

`value` T

The requested dependency, or null if not found.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the requested dependency existed.

#### Type Parameters

`T` 

The dependency type to query for.

### <a id="osu_Framework_Allocation_ReadOnlyDependencyContainerExtensions_TryGet__1_osu_Framework_Allocation_IReadOnlyDependencyContainer___0__osu_Framework_Allocation_CacheInfo_"></a> TryGet<T\>\(IReadOnlyDependencyContainer, out T, CacheInfo\)

Tries to retrieve a cached dependency of type <code class="typeparamref">T</code>.

```csharp
public static bool TryGet<T>(this IReadOnlyDependencyContainer container, out T value, CacheInfo info) where T : class
```

#### Parameters

`container` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> to query.

`value` T

The requested dependency, or null if not found.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

Extra information that identifies the cached dependency.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the requested dependency existed.

#### Type Parameters

`T` 

The dependency type to query for.

