# <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceGenerator"></a> Class HandleInputSourceGenerator

Namespace: [osu.Framework.SourceGeneration.Generators.HandleInput](osu.Framework.SourceGeneration.Generators.HandleInput.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
[Generator]
public class HandleInputSourceGenerator : AbstractIncrementalGenerator, IIncrementalGenerator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbstractIncrementalGenerator](osu.Framework.SourceGeneration.Generators.AbstractIncrementalGenerator.md) ← 
[HandleInputSourceGenerator](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSourceGenerator.md)

#### Implements

[IIncrementalGenerator](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.iincrementalgenerator)

#### Inherited Members

[AbstractIncrementalGenerator.EventDriver](osu.Framework.SourceGeneration.Generators.AbstractIncrementalGenerator.md\#osu\_Framework\_SourceGeneration\_Generators\_AbstractIncrementalGenerator\_EventDriver), 
[AbstractIncrementalGenerator.Initialize\(IncrementalGeneratorInitializationContext\)](osu.Framework.SourceGeneration.Generators.AbstractIncrementalGenerator.md\#osu\_Framework\_SourceGeneration\_Generators\_AbstractIncrementalGenerator\_Initialize\_Microsoft\_CodeAnalysis\_IncrementalGeneratorInitializationContext\_), 
[AbstractIncrementalGenerator.CreateSemanticTarget\(ClassDeclarationSyntax, SemanticModel\)](osu.Framework.SourceGeneration.Generators.AbstractIncrementalGenerator.md\#osu\_Framework\_SourceGeneration\_Generators\_AbstractIncrementalGenerator\_CreateSemanticTarget\_Microsoft\_CodeAnalysis\_CSharp\_Syntax\_ClassDeclarationSyntax\_Microsoft\_CodeAnalysis\_SemanticModel\_), 
[AbstractIncrementalGenerator.CreateSourceEmitter\(IncrementalSemanticTarget\)](osu.Framework.SourceGeneration.Generators.AbstractIncrementalGenerator.md\#osu\_Framework\_SourceGeneration\_Generators\_AbstractIncrementalGenerator\_CreateSourceEmitter\_osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HandleInputSourceGenerator\>\(HandleInputSourceGenerator?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HandleInputSourceGenerator\>\(HandleInputSourceGenerator\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HandleInputSourceGenerator\>\(HandleInputSourceGenerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HandleInputSourceGenerator\>\(HandleInputSourceGenerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HandleInputSourceGenerator, TChild\>\(HandleInputSourceGenerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HandleInputSourceGenerator, TChild\>\(HandleInputSourceGenerator, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HandleInputSourceGenerator, TChild\>\(HandleInputSourceGenerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HandleInputSourceGenerator\>\(HandleInputSourceGenerator\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceGenerator_CreateSemanticTarget_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_SemanticModel_"></a> CreateSemanticTarget\(ClassDeclarationSyntax, SemanticModel\)

```csharp
protected override IncrementalSemanticTarget CreateSemanticTarget(ClassDeclarationSyntax node, SemanticModel semanticModel)
```

#### Parameters

`node` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

`semanticModel` [SemanticModel](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.semanticmodel)

#### Returns

 [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceGenerator_CreateSourceEmitter_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_"></a> CreateSourceEmitter\(IncrementalSemanticTarget\)

```csharp
protected override IncrementalSourceEmitter CreateSourceEmitter(IncrementalSemanticTarget target)
```

#### Parameters

`target` [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

#### Returns

 [IncrementalSourceEmitter](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md)

