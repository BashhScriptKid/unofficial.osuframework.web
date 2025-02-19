# <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionSourceGeneratorTests"></a> Class DependencyInjectionSourceGeneratorTests

Namespace: [osu.Framework.SourceGeneration.Tests.Dependencies](osu.Framework.SourceGeneration.Tests.Dependencies.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class DependencyInjectionSourceGeneratorTests : AbstractGeneratorTests
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbstractGeneratorTests](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md) ← 
[DependencyInjectionSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.Dependencies.DependencyInjectionSourceGeneratorTests.md)

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

[ObjectExtensions.AsNonNull<DependencyInjectionSourceGeneratorTests\>\(DependencyInjectionSourceGeneratorTests?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DependencyInjectionSourceGeneratorTests\>\(DependencyInjectionSourceGeneratorTests\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DependencyInjectionSourceGeneratorTests\>\(DependencyInjectionSourceGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DependencyInjectionSourceGeneratorTests\>\(DependencyInjectionSourceGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DependencyInjectionSourceGeneratorTests, TChild\>\(DependencyInjectionSourceGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DependencyInjectionSourceGeneratorTests, TChild\>\(DependencyInjectionSourceGeneratorTests, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DependencyInjectionSourceGeneratorTests, TChild\>\(DependencyInjectionSourceGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DependencyInjectionSourceGeneratorTests\>\(DependencyInjectionSourceGeneratorTests\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionSourceGeneratorTests_ResourceNamespace"></a> ResourceNamespace

```csharp
protected override string ResourceNamespace { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_Dependencies_DependencyInjectionSourceGeneratorTests_Check_System_String_"></a> Check\(string\)

```csharp
[Theory]
[InlineData(new object[] { "EmptyFile" })]
[InlineData(new object[] { "EmptyClass" })]
[InlineData(new object[] { "EmptyDrawable" })]
[InlineData(new object[] { "CachedClass" })]
[InlineData(new object[] { "CachedDrawable" })]
[InlineData(new object[] { "DependencyInjectionCandidateWithConflictingLocal" })]
[InlineData(new object[] { "DependencyInjectionCandidateWithConflictingNestedClass" })]
[InlineData(new object[] { "EmptyPartialDrawable" })]
[InlineData(new object[] { "GenericEmptyPartialDrawable" })]
[InlineData(new object[] { "PartialCachedClass" })]
[InlineData(new object[] { "PartialCachedDrawable" })]
[InlineData(new object[] { "PartialCachedMember" })]
[InlineData(new object[] { "PartialCachedInterface" })]
[InlineData(new object[] { "PartialResolvedMember" })]
[InlineData(new object[] { "PartialResolvedBindable" })]
[InlineData(new object[] { "PartialResolvedNullableBindable" })]
[InlineData(new object[] { "PartialBackgroundDependencyLoadedDrawable" })]
[InlineData(new object[] { "PartialNestedClasses" })]
[InlineData(new object[] { "NestedCachedClass" })]
[InlineData(new object[] { "MultipleCachedMember" })]
[InlineData(new object[] { "CachedInheritedInterface" })]
[InlineData(new object[] { "CachedBaseType" })]
public Task Check(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

