# <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget"></a> Class IncrementalSyntaxTarget

Namespace: [osu.Framework.SourceGeneration.Generators](osu.Framework.SourceGeneration.Generators.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public class IncrementalSyntaxTarget : IEquatable<IncrementalSyntaxTarget>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)

#### Implements

[IEquatable<IncrementalSyntaxTarget\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IncrementalSyntaxTarget\>\(IncrementalSyntaxTarget?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IncrementalSyntaxTarget\>\(IncrementalSyntaxTarget\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IncrementalSyntaxTarget\>\(IncrementalSyntaxTarget\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IncrementalSyntaxTarget\>\(IncrementalSyntaxTarget\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IncrementalSyntaxTarget, TChild\>\(IncrementalSyntaxTarget, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IncrementalSyntaxTarget, TChild\>\(IncrementalSyntaxTarget, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IncrementalSyntaxTarget, TChild\>\(IncrementalSyntaxTarget, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IncrementalSyntaxTarget\>\(IncrementalSyntaxTarget\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget__ctor_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_SemanticModel_"></a> IncrementalSyntaxTarget\(ClassDeclarationSyntax, SemanticModel\)

```csharp
public IncrementalSyntaxTarget(ClassDeclarationSyntax syntax, SemanticModel semanticModel)
```

#### Parameters

`syntax` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

`semanticModel` [SemanticModel](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.semanticmodel)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_GenerationId"></a> GenerationId

```csharp
public long? GenerationId
```

#### Field Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)?

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_Syntax"></a> Syntax

```csharp
public readonly ClassDeclarationSyntax Syntax
```

#### Field Value

 [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

## Properties

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_SemanticTarget"></a> SemanticTarget

```csharp
public IncrementalSemanticTarget? SemanticTarget { get; }
```

#### Property Value

 [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)?

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_SyntaxName"></a> SyntaxName

```csharp
public string? SyntaxName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_Equals_osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_"></a> Equals\(IncrementalSyntaxTarget?\)

```csharp
public bool Equals(IncrementalSyntaxTarget? other)
```

#### Parameters

`other` [IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_WithName"></a> WithName\(\)

```csharp
public IncrementalSyntaxTarget WithName()
```

#### Returns

 [IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_WithSemanticTarget_System_Func_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_Microsoft_CodeAnalysis_SemanticModel_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget__"></a> WithSemanticTarget\(Func<ClassDeclarationSyntax, SemanticModel, IncrementalSemanticTarget\>\)

```csharp
public IncrementalSyntaxTarget WithSemanticTarget(Func<ClassDeclarationSyntax, SemanticModel, IncrementalSemanticTarget> createTarget)
```

#### Parameters

`createTarget` [Func](https://learn.microsoft.com/dotnet/api/system.func\-3)<[ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax), [SemanticModel](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.semanticmodel), [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)\>

#### Returns

 [IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)

