# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_BackgroundDependencyLoaderEmitter"></a> Class BackgroundDependencyLoaderEmitter

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Emitters](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.md)  
Assembly: osu.Framework.SourceGeneration.dll  

Emits the statement for a [BackgroundDependencyLoader] attribute.

```csharp
public class BackgroundDependencyLoaderEmitter : IStatementEmitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BackgroundDependencyLoaderEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.BackgroundDependencyLoaderEmitter.md)

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

[ObjectExtensions.AsNonNull<BackgroundDependencyLoaderEmitter\>\(BackgroundDependencyLoaderEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BackgroundDependencyLoaderEmitter\>\(BackgroundDependencyLoaderEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BackgroundDependencyLoaderEmitter\>\(BackgroundDependencyLoaderEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BackgroundDependencyLoaderEmitter\>\(BackgroundDependencyLoaderEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BackgroundDependencyLoaderEmitter, TChild\>\(BackgroundDependencyLoaderEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BackgroundDependencyLoaderEmitter, TChild\>\(BackgroundDependencyLoaderEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BackgroundDependencyLoaderEmitter, TChild\>\(BackgroundDependencyLoaderEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BackgroundDependencyLoaderEmitter\>\(BackgroundDependencyLoaderEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_BackgroundDependencyLoaderEmitter__ctor_osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData_"></a> BackgroundDependencyLoaderEmitter\(DependenciesFileEmitter, BackgroundDependencyLoaderAttributeData\)

```csharp
public BackgroundDependencyLoaderEmitter(DependenciesFileEmitter fileEmitter, BackgroundDependencyLoaderAttributeData data)
```

#### Parameters

`fileEmitter` [DependenciesFileEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.DependenciesFileEmitter.md)

`data` [BackgroundDependencyLoaderAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.BackgroundDependencyLoaderAttributeData.md)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_BackgroundDependencyLoaderEmitter_Emit"></a> Emit\(\)

```csharp
public IEnumerable<StatementSyntax> Emit()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[StatementSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)\>

