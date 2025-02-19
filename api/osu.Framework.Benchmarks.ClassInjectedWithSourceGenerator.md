# <a id="osu_Framework_Benchmarks_ClassInjectedWithSourceGenerator"></a> Class ClassInjectedWithSourceGenerator

Namespace: [osu.Framework.Benchmarks](osu.Framework.Benchmarks.md)  
Assembly: osu.Framework.Benchmarks.dll  

```csharp
public class ClassInjectedWithSourceGenerator : IDependencyInjectionCandidate, ISourceGeneratedDependencyActivator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ClassInjectedWithSourceGenerator](osu.Framework.Benchmarks.ClassInjectedWithSourceGenerator.md)

#### Implements

IDependencyInjectionCandidate, 
ISourceGeneratedDependencyActivator

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ClassInjectedWithSourceGenerator\>\(ClassInjectedWithSourceGenerator?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ClassInjectedWithSourceGenerator\>\(ClassInjectedWithSourceGenerator\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ClassInjectedWithSourceGenerator\>\(ClassInjectedWithSourceGenerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ClassInjectedWithSourceGenerator\>\(ClassInjectedWithSourceGenerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ClassInjectedWithSourceGenerator, TChild\>\(ClassInjectedWithSourceGenerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ClassInjectedWithSourceGenerator, TChild\>\(ClassInjectedWithSourceGenerator, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ClassInjectedWithSourceGenerator, TChild\>\(ClassInjectedWithSourceGenerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ClassInjectedWithSourceGenerator\>\(ClassInjectedWithSourceGenerator\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Benchmarks_ClassInjectedWithSourceGenerator_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public virtual void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` IDependencyActivatorRegistry

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

