# <a id="osu_Framework_SourceGeneration_Generators_IncrementalSourceEmitter"></a> Class IncrementalSourceEmitter

Namespace: [osu.Framework.SourceGeneration.Generators](osu.Framework.SourceGeneration.Generators.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public abstract class IncrementalSourceEmitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalSourceEmitter](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md)

#### Derived

[DependenciesFileEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.DependenciesFileEmitter.md), 
[HandleInputSourceEmitter](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSourceEmitter.md), 
[LongRunningLoadSourceEmitter](osu.Framework.SourceGeneration.Generators.LongRunningLoad.LongRunningLoadSourceEmitter.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IncrementalSourceEmitter\>\(IncrementalSourceEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IncrementalSourceEmitter\>\(IncrementalSourceEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IncrementalSourceEmitter\>\(IncrementalSourceEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IncrementalSourceEmitter\>\(IncrementalSourceEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IncrementalSourceEmitter, TChild\>\(IncrementalSourceEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IncrementalSourceEmitter, TChild\>\(IncrementalSourceEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IncrementalSourceEmitter, TChild\>\(IncrementalSourceEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IncrementalSourceEmitter\>\(IncrementalSourceEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSourceEmitter__ctor_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_"></a> IncrementalSourceEmitter\(IncrementalSemanticTarget\)

```csharp
protected IncrementalSourceEmitter(IncrementalSemanticTarget target)
```

#### Parameters

`target` [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSourceEmitter_Target"></a> Target

```csharp
public readonly IncrementalSemanticTarget Target
```

#### Field Value

 [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

## Properties

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSourceEmitter_FileSuffix"></a> FileSuffix

```csharp
protected abstract string FileSuffix { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSourceEmitter_ConstructClass_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_"></a> ConstructClass\(ClassDeclarationSyntax\)

```csharp
protected abstract ClassDeclarationSyntax ConstructClass(ClassDeclarationSyntax initialClass)
```

#### Parameters

`initialClass` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

#### Returns

 [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

### <a id="osu_Framework_SourceGeneration_Generators_IncrementalSourceEmitter_Emit_osu_Framework_SourceGeneration_Generators_AddSourceDelegate_"></a> Emit\(AddSourceDelegate\)

```csharp
public void Emit(AddSourceDelegate addSource)
```

#### Parameters

`addSource` [AddSourceDelegate](osu.Framework.SourceGeneration.Generators.AddSourceDelegate.md)

