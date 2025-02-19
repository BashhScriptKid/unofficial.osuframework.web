# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_ResolvedMemberEmitter"></a> Class ResolvedMemberEmitter

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Emitters](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.md)  
Assembly: osu.Framework.SourceGeneration.dll  

Emits the statement for a [Resolved] attribute.

```csharp
public class ResolvedMemberEmitter : IStatementEmitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ResolvedMemberEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.ResolvedMemberEmitter.md)

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

[ObjectExtensions.AsNonNull<ResolvedMemberEmitter\>\(ResolvedMemberEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ResolvedMemberEmitter\>\(ResolvedMemberEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ResolvedMemberEmitter\>\(ResolvedMemberEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ResolvedMemberEmitter\>\(ResolvedMemberEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ResolvedMemberEmitter, TChild\>\(ResolvedMemberEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ResolvedMemberEmitter, TChild\>\(ResolvedMemberEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ResolvedMemberEmitter, TChild\>\(ResolvedMemberEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ResolvedMemberEmitter\>\(ResolvedMemberEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_ResolvedMemberEmitter__ctor_osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_"></a> ResolvedMemberEmitter\(DependenciesFileEmitter, ResolvedAttributeData\)

```csharp
public ResolvedMemberEmitter(DependenciesFileEmitter fileEmitter, ResolvedAttributeData data)
```

#### Parameters

`fileEmitter` [DependenciesFileEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.DependenciesFileEmitter.md)

`data` [ResolvedAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.ResolvedAttributeData.md)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_ResolvedMemberEmitter_Emit"></a> Emit\(\)

```csharp
public IEnumerable<StatementSyntax> Emit()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[StatementSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)\>

