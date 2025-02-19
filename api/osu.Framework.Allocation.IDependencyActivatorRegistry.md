# <a id="osu_Framework_Allocation_IDependencyActivatorRegistry"></a> Interface IDependencyActivatorRegistry

Namespace: [osu.Framework.Allocation](osu.Framework.Allocation.md)  
Assembly: osu.Framework.dll  

An interface for objects to register dependency activation functions with.

```csharp
public interface IDependencyActivatorRegistry
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IDependencyActivatorRegistry\>\(IDependencyActivatorRegistry?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IDependencyActivatorRegistry\>\(IDependencyActivatorRegistry\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IDependencyActivatorRegistry\>\(IDependencyActivatorRegistry\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IDependencyActivatorRegistry\>\(IDependencyActivatorRegistry\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IDependencyActivatorRegistry, TChild\>\(IDependencyActivatorRegistry, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IDependencyActivatorRegistry, TChild\>\(IDependencyActivatorRegistry, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IDependencyActivatorRegistry, TChild\>\(IDependencyActivatorRegistry, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IDependencyActivatorRegistry\>\(IDependencyActivatorRegistry\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Allocation_IDependencyActivatorRegistry_IsRegistered_System_Type_"></a> IsRegistered\(Type\)

Whether dependency activation functions have already been registered for the given type.

```csharp
bool IsRegistered(Type type)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Allocation_IDependencyActivatorRegistry_Register_System_Type_osu_Framework_Allocation_InjectDependencyDelegate_osu_Framework_Allocation_CacheDependencyDelegate_"></a> Register\(Type, InjectDependencyDelegate?, CacheDependencyDelegate?\)

Registers dependency activation functions for the given type.

```csharp
void Register(Type type, InjectDependencyDelegate? injectDel, CacheDependencyDelegate? cacheDel)
```

#### Parameters

`type` [Type](https://learn.microsoft.com/dotnet/api/system.type)

The type.

`injectDel` [InjectDependencyDelegate](osu.Framework.Allocation.InjectDependencyDelegate.md)?

A function to inject dependencies into the object.

`cacheDel` [CacheDependencyDelegate](osu.Framework.Allocation.CacheDependencyDelegate.md)?

A function to cache the dependencies of the object.

