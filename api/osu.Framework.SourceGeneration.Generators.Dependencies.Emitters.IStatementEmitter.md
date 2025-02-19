# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_IStatementEmitter"></a> Interface IStatementEmitter

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Emitters](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public interface IStatementEmitter
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IStatementEmitter\>\(IStatementEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IStatementEmitter\>\(IStatementEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IStatementEmitter\>\(IStatementEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IStatementEmitter\>\(IStatementEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IStatementEmitter, TChild\>\(IStatementEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IStatementEmitter, TChild\>\(IStatementEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IStatementEmitter, TChild\>\(IStatementEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IStatementEmitter\>\(IStatementEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_IStatementEmitter_Emit"></a> Emit\(\)

```csharp
IEnumerable<StatementSyntax> Emit()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[StatementSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.statementsyntax)\>

