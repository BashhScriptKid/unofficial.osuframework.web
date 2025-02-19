# <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionMultiPhaseSourceGeneratorTests"></a> Class DependencyInjectionMultiPhaseSourceGeneratorTests

Namespace: [osu.Framework.SourceGeneration.Tests.Dependencies](osu.Framework.SourceGeneration.Tests.Dependencies.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class DependencyInjectionMultiPhaseSourceGeneratorTests : AbstractGeneratorTests
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbstractGeneratorTests](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md) ← 
[DependencyInjectionMultiPhaseSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.Dependencies.DependencyInjectionMultiPhaseSourceGeneratorTests.md)

#### Inherited Members

[AbstractGeneratorTests.ResourceNamespace](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md\#osu\_Framework\_SourceGeneration\_Tests\_AbstractGeneratorTests\_ResourceNamespace), 
[AbstractGeneratorTests.GetTestSources\(string, out \(string filename, string content\)\[\], out \(string filename, string content\)\[\], out \(string filename, string content\)\[\], out \(string filename, string content\)\[\]\)](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md\#osu\_Framework\_SourceGeneration\_Tests\_AbstractGeneratorTests\_GetTestSources\_System\_String\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_System\_ValueTuple\_System\_String\_System\_String\_\_\_\_\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DependencyInjectionMultiPhaseSourceGeneratorTests\>\(DependencyInjectionMultiPhaseSourceGeneratorTests?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DependencyInjectionMultiPhaseSourceGeneratorTests\>\(DependencyInjectionMultiPhaseSourceGeneratorTests\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DependencyInjectionMultiPhaseSourceGeneratorTests\>\(DependencyInjectionMultiPhaseSourceGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DependencyInjectionMultiPhaseSourceGeneratorTests\>\(DependencyInjectionMultiPhaseSourceGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DependencyInjectionMultiPhaseSourceGeneratorTests, TChild\>\(DependencyInjectionMultiPhaseSourceGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DependencyInjectionMultiPhaseSourceGeneratorTests, TChild\>\(DependencyInjectionMultiPhaseSourceGeneratorTests, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DependencyInjectionMultiPhaseSourceGeneratorTests, TChild\>\(DependencyInjectionMultiPhaseSourceGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DependencyInjectionMultiPhaseSourceGeneratorTests\>\(DependencyInjectionMultiPhaseSourceGeneratorTests\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionMultiPhaseSourceGeneratorTests_CheckWithStatisticsData"></a> CheckWithStatisticsData

```csharp
public static TheoryData<string, (int syntaxTargetCreated, int semanticTargetCreated, int emitHits)[]> CheckWithStatisticsData { get; }
```

#### Property Value

 TheoryData<[string](https://learn.microsoft.com/dotnet/api/system.string), \([int](https://learn.microsoft.com/dotnet/api/system.int32) [syntaxTargetCreated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.syntaxtargetcreated), [int](https://learn.microsoft.com/dotnet/api/system.int32) [semanticTargetCreated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.semantictargetcreated), [int](https://learn.microsoft.com/dotnet/api/system.int32) [emitHits](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.emithits)\)\[\]\>

### <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionMultiPhaseSourceGeneratorTests_ResourceNamespace"></a> ResourceNamespace

```csharp
protected override string ResourceNamespace { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionMultiPhaseSourceGeneratorTests_Check_System_String_"></a> Check\(string\)

```csharp
[Theory]
[InlineData(new object[] { "MultiPartialResolvedMember" })]
public void Check(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionMultiPhaseSourceGeneratorTests_CheckWithStatistics_System_String_System_ValueTuple_System_Int32_System_Int32_System_Int32____"></a> CheckWithStatistics\(string, \(int syntaxTargetCreated, int semanticTargetCreated, int emitHits\)\[\]\)

```csharp
[Theory]
[MemberData("CheckWithStatisticsData", new object[] { })]
public void CheckWithStatistics(string name, (int syntaxTargetCreated, int semanticTargetCreated, int emitHits)[] expectedStatistics)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`expectedStatistics` \([int](https://learn.microsoft.com/dotnet/api/system.int32) [syntaxTargetCreated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.syntaxtargetcreated), [int](https://learn.microsoft.com/dotnet/api/system.int32) [semanticTargetCreated](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.semantictargetcreated), [int](https://learn.microsoft.com/dotnet/api/system.int32) [emitHits](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.int32,system.int32,system.int32\-.emithits)\)\[\]

