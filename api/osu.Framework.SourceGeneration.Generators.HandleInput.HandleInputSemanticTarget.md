# <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget"></a> Class HandleInputSemanticTarget

Namespace: [osu.Framework.SourceGeneration.Generators.HandleInput](osu.Framework.SourceGeneration.Generators.HandleInput.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public class HandleInputSemanticTarget : IncrementalSemanticTarget
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md) ← 
[HandleInputSemanticTarget](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSemanticTarget.md)

#### Inherited Members

[IncrementalSemanticTarget.ClassSyntax](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_ClassSyntax), 
[IncrementalSemanticTarget.FullyQualifiedTypeName](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_FullyQualifiedTypeName), 
[IncrementalSemanticTarget.GlobalPrefixedTypeName](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_GlobalPrefixedTypeName), 
[IncrementalSemanticTarget.NeedsOverride](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_NeedsOverride), 
[IncrementalSemanticTarget.ContainingNamespace](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_ContainingNamespace), 
[IncrementalSemanticTarget.IsValid](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_IsValid), 
[IncrementalSemanticTarget.TypeHierarchy](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_TypeHierarchy), 
[IncrementalSemanticTarget.CheckValid\(INamedTypeSymbol\)](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_CheckValid\_Microsoft\_CodeAnalysis\_INamedTypeSymbol\_), 
[IncrementalSemanticTarget.CheckNeedsOverride\(INamedTypeSymbol\)](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_CheckNeedsOverride\_Microsoft\_CodeAnalysis\_INamedTypeSymbol\_), 
[IncrementalSemanticTarget.Process\(INamedTypeSymbol\)](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSemanticTarget\_Process\_Microsoft\_CodeAnalysis\_INamedTypeSymbol\_), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HandleInputSemanticTarget\>\(HandleInputSemanticTarget?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HandleInputSemanticTarget\>\(HandleInputSemanticTarget\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HandleInputSemanticTarget\>\(HandleInputSemanticTarget\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HandleInputSemanticTarget\>\(HandleInputSemanticTarget\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HandleInputSemanticTarget, TChild\>\(HandleInputSemanticTarget, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HandleInputSemanticTarget, TChild\>\(HandleInputSemanticTarget, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HandleInputSemanticTarget, TChild\>\(HandleInputSemanticTarget, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HandleInputSemanticTarget\>\(HandleInputSemanticTarget\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget__ctor_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_SemanticModel_"></a> HandleInputSemanticTarget\(ClassDeclarationSyntax, SemanticModel\)

```csharp
public HandleInputSemanticTarget(ClassDeclarationSyntax classSyntax, SemanticModel semanticModel)
```

#### Parameters

`classSyntax` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

`semanticModel` [SemanticModel](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.semanticmodel)

## Properties

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget_RequestsNonPositionalInput"></a> RequestsNonPositionalInput

```csharp
public bool RequestsNonPositionalInput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget_RequestsPositionalInput"></a> RequestsPositionalInput

```csharp
public bool RequestsPositionalInput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget_CheckNeedsOverride_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> CheckNeedsOverride\(INamedTypeSymbol\)

Determines whether the source generator should override any methods of the semantic target.
This can happen if the base and sub types are both valid (<xref href="osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.CheckValid(Microsoft.CodeAnalysis.INamedTypeSymbol)" data-throw-if-not-resolved="false"></xref>) semantic targets.

```csharp
protected override bool CheckNeedsOverride(INamedTypeSymbol symbol)
```

#### Parameters

`symbol` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

The symbol represented by this semantic target.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget_CheckValid_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> CheckValid\(INamedTypeSymbol\)

Determines whether a source should be generated for this semantic target.

```csharp
protected override bool CheckValid(INamedTypeSymbol symbol)
```

#### Parameters

`symbol` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

The symbol represented by this semantic target.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSemanticTarget_Process_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> Process\(INamedTypeSymbol\)

Processes the symbol to extract any data that could be used in source generation.
The extracted data <b>must not</b> reference the symbol.

```csharp
protected override void Process(INamedTypeSymbol symbol)
```

#### Parameters

`symbol` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

The symbol represented by this semantic target.

