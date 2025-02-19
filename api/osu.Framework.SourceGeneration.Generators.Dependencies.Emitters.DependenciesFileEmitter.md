# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter"></a> Class DependenciesFileEmitter

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Emitters](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public class DependenciesFileEmitter : IncrementalSourceEmitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalSourceEmitter](osu.Framework.SourceGeneration.Generators.IncrementalSourceEmitter.md) ← 
[DependenciesFileEmitter](osu.Framework.SourceGeneration.Generators.Dependencies.Emitters.DependenciesFileEmitter.md)

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

[ObjectExtensions.AsNonNull<DependenciesFileEmitter\>\(DependenciesFileEmitter?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DependenciesFileEmitter\>\(DependenciesFileEmitter\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DependenciesFileEmitter\>\(DependenciesFileEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DependenciesFileEmitter\>\(DependenciesFileEmitter\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DependenciesFileEmitter, TChild\>\(DependenciesFileEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DependenciesFileEmitter, TChild\>\(DependenciesFileEmitter, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DependenciesFileEmitter, TChild\>\(DependenciesFileEmitter, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DependenciesFileEmitter\>\(DependenciesFileEmitter\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter__ctor_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_"></a> DependenciesFileEmitter\(IncrementalSemanticTarget\)

```csharp
public DependenciesFileEmitter(IncrementalSemanticTarget target)
```

#### Parameters

`target` [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_CACHE_INFO_PARAMETER_NAME"></a> CACHE\_INFO\_PARAMETER\_NAME

```csharp
public const string CACHE_INFO_PARAMETER_NAME = "i"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_DEPENDENCIES_PARAMETER_NAME"></a> DEPENDENCIES\_PARAMETER\_NAME

```csharp
public const string DEPENDENCIES_PARAMETER_NAME = "d"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_IS_REGISTERED_METHOD_NAME"></a> IS\_REGISTERED\_METHOD\_NAME

```csharp
public const string IS_REGISTERED_METHOD_NAME = "IsRegistered"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_LOCAL_DEPENDENCIES_VAR_NAME"></a> LOCAL\_DEPENDENCIES\_VAR\_NAME

```csharp
public const string LOCAL_DEPENDENCIES_VAR_NAME = "dependencies"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_REGISTER_FOR_DEPENDENCY_ACTIVATION_METHOD_NAME"></a> REGISTER\_FOR\_DEPENDENCY\_ACTIVATION\_METHOD\_NAME

```csharp
public const string REGISTER_FOR_DEPENDENCY_ACTIVATION_METHOD_NAME = "RegisterForDependencyActivation"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_REGISTER_METHOD_NAME"></a> REGISTER\_METHOD\_NAME

```csharp
public const string REGISTER_METHOD_NAME = "Register"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_REGISTRY_PARAMETER_NAME"></a> REGISTRY\_PARAMETER\_NAME

```csharp
public const string REGISTRY_PARAMETER_NAME = "registry"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_TARGET_PARAMETER_NAME"></a> TARGET\_PARAMETER\_NAME

```csharp
public const string TARGET_PARAMETER_NAME = "t"
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_FileSuffix"></a> FileSuffix

```csharp
protected override string FileSuffix { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_Target"></a> Target

```csharp
public DependenciesClassCandidate Target { get; }
```

#### Property Value

 [DependenciesClassCandidate](osu.Framework.SourceGeneration.Generators.Dependencies.DependenciesClassCandidate.md)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Emitters_DependenciesFileEmitter_ConstructClass_Microsoft_CodeAnalysis_CSharp_Syntax_ClassDeclarationSyntax_"></a> ConstructClass\(ClassDeclarationSyntax\)

```csharp
protected override ClassDeclarationSyntax ConstructClass(ClassDeclarationSyntax initialClass)
```

#### Parameters

`initialClass` [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

#### Returns

 [ClassDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.classdeclarationsyntax)

