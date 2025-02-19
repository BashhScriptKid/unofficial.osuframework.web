# <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test"></a> Class CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test

Namespace: [osu.Framework.SourceGeneration.Tests.Verifiers](osu.Framework.SourceGeneration.Tests.Verifiers.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator>.Test
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test](osu.Framework.SourceGeneration.Tests.Verifiers.CSharpMultiPhaseSourceGeneratorVerifier\-1.Test.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpMultiPhaseSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test__ctor_System_ValueTuple_System_String_System_String____System_ValueTuple_System_String_System_String____System_Collections_Generic_List_System_Collections_Generic_List_System_ValueTuple_System_String_System_String____System_Collections_Generic_List_System_Collections_Generic_List_System_ValueTuple_System_String_System_String____"></a> Test\(\(string filename, string content\)\[\], \(string filename, string content\)\[\], List<List<\(string filename, string content\)\>\>, List<List<\(string filename, string content\)\>\>\)

```csharp
public Test((string filename, string content)[] commonSources, (string filename, string content)[] commonGenerated, List<List<(string filename, string content)>> multiPhaseSources, List<List<(string filename, string content)>> multiPhaseGenerated)
```

#### Parameters

`commonSources` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`commonGenerated` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`multiPhaseSources` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<\([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\>\>

`multiPhaseGenerated` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<\([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\>\>

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test_LanguageVersion"></a> LanguageVersion

```csharp
public LanguageVersion LanguageVersion { get; set; }
```

#### Property Value

 [LanguageVersion](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.languageversion)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test_AddStatisticsVerification_System_ValueTuple_System_Int32_System_Int32_System_Int32____"></a> AddStatisticsVerification\(\(int syntaxTargetCreated, int semanticTargetCreated, int emitHits\)\[\]\)

```csharp
public void AddStatisticsVerification((int syntaxTargetCreated, int semanticTargetCreated, int emitHits)[] expectedStatistics)
```

#### Parameters

`expectedStatistics` \([int](https://learn.microsoft.com/dotnet/api/system.int32) [syntaxTargetCreated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.syntaxtargetcreated), [int](https://learn.microsoft.com/dotnet/api/system.int32) [semanticTargetCreated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.semantictargetcreated), [int](https://learn.microsoft.com/dotnet/api/system.int32) [emitHits](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.emithits)\)\[\]

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test_Verify"></a> Verify\(\)

```csharp
public void Verify()
```

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test_PhaseChanged"></a> PhaseChanged

```csharp
public event Action<int>? PhaseChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>?

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpMultiPhaseSourceGeneratorVerifier_1_Test_PhaseCompleted"></a> PhaseCompleted

```csharp
public event Action? PhaseCompleted
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)?

