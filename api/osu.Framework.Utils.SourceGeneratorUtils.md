# <a id="osu_Framework_Utils_SourceGeneratorUtils"></a> Class SourceGeneratorUtils

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

A set of helper functions for source generators to use in order to simplify their work.

```csharp
public static class SourceGeneratorUtils
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SourceGeneratorUtils](osu.Framework.Utils.SourceGeneratorUtils.md)

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

### <a id="osu_Framework_Utils_SourceGeneratorUtils_CacheDependency_osu_Framework_Allocation_DependencyContainer_System_Type_System_Object_osu_Framework_Allocation_CacheInfo_System_Type_System_String_System_String_"></a> CacheDependency\(DependencyContainer, Type, object?, CacheInfo, Type?, string?, string?\)

Caches an object to a <xref href="osu.Framework.Allocation.DependencyContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public static void CacheDependency(DependencyContainer container, Type callerType, object? obj, CacheInfo info, Type? asType, string? cachedName, string? propertyName)
```

#### Parameters

`container` [DependencyContainer](osu.Framework.Allocation.DependencyContainer.md)

The <xref href="osu.Framework.Allocation.DependencyContainer" data-throw-if-not-resolved="false"></xref> which the object will be cached to.

`callerType` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type of object calling this method.

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to be cached.

`info` [CacheInfo](osu.Framework.Allocation.CacheInfo.md)

The parenting <xref href="osu.Framework.Allocation.CacheInfo" data-throw-if-not-resolved="false"></xref> object.

`asType` [Type](https://learn.microsoft.com/dotnet/api/system.type)?

The type which <code class="paramref">obj</code> should be cached as.

`cachedName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The name which <code class="paramref">obj</code> should be cached as.

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

A fallback name for <code class="paramref">obj</code> to be cached as.

#### Exceptions

 [NullDependencyException](osu.Framework.Allocation.NullDependencyException.md)

If <code class="paramref">obj</code> is <code>null</code>.

### <a id="osu_Framework_Utils_SourceGeneratorUtils_GetDependency__1_osu_Framework_Allocation_IReadOnlyDependencyContainer_System_Type_System_String_System_Type_System_Boolean_System_Boolean_"></a> GetDependency<T\>\(IReadOnlyDependencyContainer, Type, string?, Type?, bool, bool\)

Retrieves an object from an <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public static T GetDependency<T>(IReadOnlyDependencyContainer container, Type callerType, string? cachedName, Type? cachedParent, bool allowNulls, bool rebindBindables)
```

#### Parameters

`container` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> to retrieve the dependency from.

`callerType` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type of object calling this method.

`cachedName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The name of the object.

`cachedParent` [Type](https://learn.microsoft.com/dotnet/api/system.type)?

The parent of the object.

`allowNulls` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the returned object is allowed to be <code>null</code>.

`rebindBindables` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If the object is a <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>, whether it should be re-bound via <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.

#### Returns

 T

The object.

#### Type Parameters

`T` 

The type of the object.

#### Exceptions

 [DependencyNotRegisteredException](osu.Framework.Allocation.DependencyNotRegisteredException.md)

If the dependency is not in <code class="paramref">container</code>.

### <a id="osu_Framework_Utils_SourceGeneratorUtils_GetDependency_osu_Framework_Allocation_IReadOnlyDependencyContainer_System_Type_System_Type_System_String_System_Type_System_Boolean_System_Boolean_"></a> GetDependency\(IReadOnlyDependencyContainer, Type, Type, string?, Type?, bool, bool\)

Retrieves an object from an <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref>.

```csharp
public static object? GetDependency(IReadOnlyDependencyContainer container, Type type, Type callerType, string? cachedName, Type? cachedParent, bool allowNulls, bool rebindBindables)
```

#### Parameters

`container` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> to retrieve the dependency from.

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type of the object to retrieve.

`callerType` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type of object calling this method.

`cachedName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The name of the object.

`cachedParent` [Type](https://learn.microsoft.com/dotnet/api/system.type)?

The parent of the object.

`allowNulls` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the returned object is allowed to be <code>null</code>.

`rebindBindables` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If the object is a <xref href="osu.Framework.Bindables.IBindable" data-throw-if-not-resolved="false"></xref>, whether it should be re-bound via <xref href="osu.Framework.Bindables.IBindable.GetBoundCopy" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object.

#### Exceptions

 [DependencyNotRegisteredException](osu.Framework.Allocation.DependencyNotRegisteredException.md)

If the dependency is not in <code class="paramref">container</code>.

