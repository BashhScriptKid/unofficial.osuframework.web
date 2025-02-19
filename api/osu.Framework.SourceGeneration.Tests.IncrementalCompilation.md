# <a id="osu_Framework_SourceGeneration_Tests_IncrementalCompilation"></a> Class IncrementalCompilation

Namespace: [osu.Framework.SourceGeneration.Tests](osu.Framework.SourceGeneration.Tests.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class IncrementalCompilation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[IncrementalCompilation](osu.Framework.SourceGeneration.Tests.IncrementalCompilation.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IncrementalCompilation\>\(IncrementalCompilation?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IncrementalCompilation\>\(IncrementalCompilation\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IncrementalCompilation\>\(IncrementalCompilation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IncrementalCompilation\>\(IncrementalCompilation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IncrementalCompilation, TChild\>\(IncrementalCompilation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IncrementalCompilation, TChild\>\(IncrementalCompilation, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IncrementalCompilation, TChild\>\(IncrementalCompilation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IncrementalCompilation\>\(IncrementalCompilation\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Tests_IncrementalCompilation__ctor"></a> IncrementalCompilation\(\)

```csharp
public IncrementalCompilation()
```

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_IncrementalCompilation_Compilation"></a> Compilation

```csharp
public Compilation Compilation { get; }
```

#### Property Value

 [Compilation](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.compilation)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_IncrementalCompilation_AddOrUpdateSource_System_String_System_String_"></a> AddOrUpdateSource\(string, string\)

```csharp
public void AddOrUpdateSource(string filename, string content)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

`content` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Tests_IncrementalCompilation_RemoveSource_System_String_"></a> RemoveSource\(string\)

```csharp
public void RemoveSource(string filename)
```

#### Parameters

`filename` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Tests_IncrementalCompilation_RunGenerators_Microsoft_CodeAnalysis_GeneratorDriver__"></a> RunGenerators\(ref GeneratorDriver\)

```csharp
public GeneratorDriverRunResult RunGenerators(ref GeneratorDriver driver)
```

#### Parameters

`driver` [GeneratorDriver](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.generatordriver)

#### Returns

 [GeneratorDriverRunResult](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.generatordriverrunresult)

