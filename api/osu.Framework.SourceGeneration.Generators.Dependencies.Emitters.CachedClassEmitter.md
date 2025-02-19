# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_CachedClassEmitter"></a> Class CachedClassEmitter

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Emitters](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.md)  
Assembly: osu.Framework.SourceGeneration.dll  

Emits the statement for a [Cached] attribute on the class itself.

```csharp
public class CachedClassEmitter : IStatementEmitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CachedClassEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.CachedClassEmitter.md)

#### Implements

[IStatementEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.IStatementEmitter.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CachedClassEmitter\>\(CachedClassEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CachedClassEmitter\>\(CachedClassEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CachedClassEmitter\>\(CachedClassEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CachedClassEmitter\>\(CachedClassEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CachedClassEmitter, TChild\>\(CachedClassEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CachedClassEmitter, TChild\>\(CachedClassEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CachedClassEmitter, TChild\>\(CachedClassEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CachedClassEmitter\>\(CachedClassEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_CachedClassEmitter__ctor_osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_"></a> CachedClassEmitter\(DependenciesFileEmitter, CachedAttributeData\)

```csharp
public CachedClassEmitter(DependenciesFileEmitter fileEmitter, CachedAttributeData data)
```

#### Parameters

`fileEmitter` [DependenciesFileEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.DependenciesFileEmitter.md)

`data` [CachedAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.CachedAttributeData.md)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_CachedClassEmitter_Emit"></a> Emit\(\)

```csharp
public IEnumerable<StatementSyntax> Emit()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[StatementSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)\>

