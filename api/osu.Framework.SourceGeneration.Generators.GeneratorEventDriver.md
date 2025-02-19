# <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver"></a> Class GeneratorEventDriver

Namespace: [osu.Framework.SourceGeneration.Generators](osu.Framework.SourceGeneration.Generators.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public class GeneratorEventDriver
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GeneratorEventDriver](osu.Framework.SourceGeneration.Generators.GeneratorEventDriver.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<GeneratorEventDriver\>\(GeneratorEventDriver?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GeneratorEventDriver\>\(GeneratorEventDriver\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GeneratorEventDriver\>\(GeneratorEventDriver\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GeneratorEventDriver\>\(GeneratorEventDriver\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GeneratorEventDriver, TChild\>\(GeneratorEventDriver, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GeneratorEventDriver, TChild\>\(GeneratorEventDriver, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GeneratorEventDriver, TChild\>\(GeneratorEventDriver, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GeneratorEventDriver\>\(GeneratorEventDriver\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_OnEmit_osu_Framework_SourceGeneration_Generators_IncrementalSemanticTarget_"></a> OnEmit\(IncrementalSemanticTarget\)

```csharp
public void OnEmit(IncrementalSemanticTarget candidate)
```

#### Parameters

`candidate` [IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_OnSemanticTargetCreated_osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_"></a> OnSemanticTargetCreated\(IncrementalSyntaxTarget\)

```csharp
public void OnSemanticTargetCreated(IncrementalSyntaxTarget target)
```

#### Parameters

`target` [IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_OnStage2Entry_System_Collections_Immutable_ImmutableArray_osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget__"></a> OnStage2Entry\(ImmutableArray<IncrementalSyntaxTarget\>\)

```csharp
public void OnStage2Entry(ImmutableArray<IncrementalSyntaxTarget> target)
```

#### Parameters

`target` [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_OnStage2Exit_System_Collections_Generic_HashSet_osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget__"></a> OnStage2Exit\(HashSet<IncrementalSyntaxTarget\>\)

```csharp
public void OnStage2Exit(HashSet<IncrementalSyntaxTarget> target)
```

#### Parameters

`target` [HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_OnStage2GenerationIdAssigned_System_Collections_Immutable_ImmutableArray_osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget__"></a> OnStage2GenerationIdAssigned\(ImmutableArray<IncrementalSyntaxTarget\>\)

```csharp
public void OnStage2GenerationIdAssigned(ImmutableArray<IncrementalSyntaxTarget> target)
```

#### Parameters

`target` [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_OnSyntaxTargetCreated_osu_Framework_SourceGeneration_Generators_IncrementalSyntaxTarget_"></a> OnSyntaxTargetCreated\(IncrementalSyntaxTarget\)

```csharp
public void OnSyntaxTargetCreated(IncrementalSyntaxTarget target)
```

#### Parameters

`target` [IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_Emit"></a> Emit

```csharp
public event Action<IncrementalSemanticTarget>? Emit
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IncrementalSemanticTarget](osu.Framework.SourceGeneration.Generators.IncrementalSemanticTarget.md)\>?

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_SemanticTargetCreated"></a> SemanticTargetCreated

```csharp
public event Action<IncrementalSyntaxTarget>? SemanticTargetCreated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>?

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_Stage2Entry"></a> Stage2Entry

```csharp
public event Action<ImmutableArray<IncrementalSyntaxTarget>>? Stage2Entry
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>\>?

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_Stage2Exit"></a> Stage2Exit

```csharp
public event Action<HashSet<IncrementalSyntaxTarget>>? Stage2Exit
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[HashSet](https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>\>?

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_Stage2GenerationIdAssigned"></a> Stage2GenerationIdAssigned

```csharp
public event Action<ImmutableArray<IncrementalSyntaxTarget>>? Stage2GenerationIdAssigned
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>\>?

### <a id="osu_Framework_SourceGeneration_Generators_GeneratorEventDriver_SyntaxTargetCreated"></a> SyntaxTargetCreated

```csharp
public event Action<IncrementalSyntaxTarget>? SyntaxTargetCreated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IncrementalSyntaxTarget](osu.Framework.SourceGeneration.Generators.IncrementalSyntaxTarget.md)\>?

