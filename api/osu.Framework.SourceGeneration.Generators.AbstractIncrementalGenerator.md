# <a id="osu_Framework_SourceGeneration_Generators_AbstractIncrementalGenerator"></a> Class AbstractIncrementalGenerator

Namespace: [osu.Framework.SourceGeneration.Generators](osu.Framework.SourceGeneration.Generators.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public abstract class AbstractIncrementalGenerator : IIncrementalGenerator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbstractIncrementalGenerator](osu.Framework.SourceGeneration.Generators.AbstractIncrementalGenerator.md)

#### Derived

[DependencyInjectionSourceGenerator](osu.Framework.SourceGeneration.Generators.Dependencies.DependencyInjectionSourceGenerator.md), 
[HandleInputSourceGenerator](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSourceGenerator.md), 
[LongRunningLoadSourceGenerator](osu.Framework.SourceGeneration.Generators.LongRunningLoad.LongRunningLoadSourceGenerator.md)

#### Implements

[IIncrementalGenerator](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.iincrementalgenerator)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AbstractIncrementalGenerator\>\(AbstractIncrementalGenerator?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AbstractIncrementalGenerator\>\(AbstractIncrementalGenerator\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AbstractIncrementalGenerator\>\(AbstractIncrementalGenerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AbstractIncrementalGenerator\>\(AbstractIncrementalGenerator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AbstractIncrementalGenerator, TChild\>\(AbstractIncrementalGenerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AbstractIncrementalGenerator, TChild\>\(AbstractIncrementalGenerator, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AbstractIncrementalGenerator, TChild\>\(AbstractIncrementalGenerator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AbstractIncrementalGenerator\>\(AbstractIncrementalGenerator\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_AbstractIncrementalGenerator_EventDriver"></a> EventDriver

```csharp
public readonly GeneratorEventDriver EventDriver
```

#### Field Value

 [GeneratorEventDriver](osu.Framework.SourceGeneration.Generators.GeneratorEventDriver.md)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_AbstractIncrementalGenerator_CreateSemanticTarget_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_SemanticModel_"></a> CreateSemanticTarget\(ClassDeclarationSyntax, SemanticModel\)

```csharp
protected abstract IncrementalSemanticTarget CreateSemanticTarget(ClassDeclarationSyntax node, SemanticModel semanticModel)
```

#### Parameters

`node` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

`semanticModel` [SemanticModel](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.semanticmodel)

#### Returns

 [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

### <a id="osu_Framework_SourceGeneration_Generators_AbstractIncrementalGenerator_CreateSourceEmitter_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_"></a> CreateSourceEmitter\(IncrementalSemanticTarget\)

```csharp
protected abstract IncrementalSourceEmitter CreateSourceEmitter(IncrementalSemanticTarget target)
```

#### Parameters

`target` [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

#### Returns

 [IncrementalSourceEmitter](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md)

### <a id="osu_Framework_SourceGeneration_Generators_AbstractIncrementalGenerator_Initialize_Microsoft_CodeAnalysis_IncrementalGeneratorInitializationContext_"></a> Initialize\(IncrementalGeneratorInitializationContext\)

Called to initialize the generator and register generation steps via callbacks
on the <code class="paramref">context</code>

```csharp
public void Initialize(IncrementalGeneratorInitializationContext context)
```

#### Parameters

`context` [IncrementalGeneratorInitializationContext](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.incrementalgeneratorinitializationcontext)

The <xref href="Microsoft.CodeAnalysis.IncrementalGeneratorInitializationContext" data-throw-if-not-resolved="false"></xref> to register callbacks on

