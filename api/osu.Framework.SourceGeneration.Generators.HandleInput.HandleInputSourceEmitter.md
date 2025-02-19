# <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceEmitter"></a> Class HandleInputSourceEmitter

Namespace: [osu.Framework.SourceGeneration.Generators.HandleInput](osu.Framework.SourceGeneration.Generators.HandleInput.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public class HandleInputSourceEmitter : IncrementalSourceEmitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalSourceEmitter](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md) ← 
[HandleInputSourceEmitter](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSourceEmitter.md)

#### Inherited Members

[IncrementalSourceEmitter.FileSuffix](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSourceEmitter\_FileSuffix), 
[IncrementalSourceEmitter.Target](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSourceEmitter\_Target), 
[IncrementalSourceEmitter.Emit\(AddSourceDelegate\)](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSourceEmitter\_Emit\_osu\_Framework\_SourceGeneration\_Generators\_AddSourceDelegate\_), 
[IncrementalSourceEmitter.ConstructClass\(ClassDeclarationSyntax\)](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md\#osu\_Framework\_SourceGeneration\_Generators\_IncrementalSourceEmitter\_ConstructClass\_Microsoft\_CodeAnalysis\_CSharp\_Syntax\_ClassDeclarationSyntax\_), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HandleInputSourceEmitter\>\(HandleInputSourceEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HandleInputSourceEmitter\>\(HandleInputSourceEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HandleInputSourceEmitter\>\(HandleInputSourceEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HandleInputSourceEmitter\>\(HandleInputSourceEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HandleInputSourceEmitter, TChild\>\(HandleInputSourceEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HandleInputSourceEmitter, TChild\>\(HandleInputSourceEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HandleInputSourceEmitter, TChild\>\(HandleInputSourceEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HandleInputSourceEmitter\>\(HandleInputSourceEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceEmitter__ctor_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_"></a> HandleInputSourceEmitter\(IncrementalSemanticTarget\)

```csharp
public HandleInputSourceEmitter(IncrementalSemanticTarget target)
```

#### Parameters

`target` [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

## Properties

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceEmitter_FileSuffix"></a> FileSuffix

```csharp
protected override string FileSuffix { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceEmitter_Target"></a> Target

```csharp
public HandleInputSemanticTarget Target { get; }
```

#### Property Value

 [HandleInputSemanticTarget](osu.Framework.SourceGeneration.Generators.HandleInput.HandleInputSemanticTarget.md)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_HandleInput_HandleInputSourceEmitter_ConstructClass_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_"></a> ConstructClass\(ClassDeclarationSyntax\)

```csharp
protected override ClassDeclarationSyntax ConstructClass(ClassDeclarationSyntax initialClass)
```

#### Parameters

`initialClass` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

#### Returns

 [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

