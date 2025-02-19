# <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget"></a> Class IncrementalSemanticTarget

Namespace: [osu.Framework.SourceGeneration.Generators](osu.Framework.SourceGeneration.Generators.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public abstract class IncrementalSemanticTarget
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

#### Derived

[DependenciesClassCandidate](osu.Framework.SourceGeneration.Generators.Dependencies.DependenciesClassCandidate.md), 
[HandleInputSemanticTarget](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSemanticTarget.md), 
[LongRunningLoadSemanticTarget](osu.Framework.SourceGeneration.Generators.LongRunningLoad.LongRunningLoadSemanticTarget.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IncrementalSemanticTarget\>\(IncrementalSemanticTarget?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IncrementalSemanticTarget\>\(IncrementalSemanticTarget\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IncrementalSemanticTarget\>\(IncrementalSemanticTarget\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IncrementalSemanticTarget\>\(IncrementalSemanticTarget\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IncrementalSemanticTarget, TChild\>\(IncrementalSemanticTarget, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IncrementalSemanticTarget, TChild\>\(IncrementalSemanticTarget, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IncrementalSemanticTarget, TChild\>\(IncrementalSemanticTarget, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IncrementalSemanticTarget\>\(IncrementalSemanticTarget\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget__ctor_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_SemanticModel_"></a> IncrementalSemanticTarget\(ClassDeclarationSyntax, SemanticModel\)

```csharp
protected IncrementalSemanticTarget(ClassDeclarationSyntax classSyntax, SemanticModel semanticModel)
```

#### Parameters

`classSyntax` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

`semanticModel` [SemanticModel](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.semanticmodel)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_ClassSyntax"></a> ClassSyntax

```csharp
public readonly ClassDeclarationSyntax ClassSyntax
```

#### Field Value

 [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_ContainingNamespace"></a> ContainingNamespace

```csharp
public readonly string? ContainingNamespace
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_FullyQualifiedTypeName"></a> FullyQualifiedTypeName

```csharp
public readonly string FullyQualifiedTypeName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_GlobalPrefixedTypeName"></a> GlobalPrefixedTypeName

```csharp
public readonly string GlobalPrefixedTypeName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_IsValid"></a> IsValid

```csharp
public readonly bool IsValid
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_NeedsOverride"></a> NeedsOverride

```csharp
public readonly bool NeedsOverride
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_TypeHierarchy"></a> TypeHierarchy

```csharp
public readonly List<string> TypeHierarchy
```

#### Field Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_CheckNeedsOverride_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> CheckNeedsOverride\(INamedTypeSymbol\)

Determines whether the source generator should override any methods of the semantic target.
This can happen if the base and sub types are both valid (<xref href="osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.CheckValid(Microsoft.CodeAnalysis.INamedTypeSymbol)" data-throw-if-not-resolved="false"></xref>) semantic targets.

```csharp
protected abstract bool CheckNeedsOverride(INamedTypeSymbol symbol)
```

#### Parameters

`symbol` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

The symbol represented by this semantic target.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_CheckValid_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> CheckValid\(INamedTypeSymbol\)

Determines whether a source should be generated for this semantic target.

```csharp
protected abstract bool CheckValid(INamedTypeSymbol symbol)
```

#### Parameters

`symbol` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

The symbol represented by this semantic target.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_Process_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> Process\(INamedTypeSymbol\)

Processes the symbol to extract any data that could be used in source generation.
The extracted data <b>must not</b> reference the symbol.

```csharp
protected abstract void Process(INamedTypeSymbol symbol)
```

#### Parameters

`symbol` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

The symbol represented by this semantic target.

