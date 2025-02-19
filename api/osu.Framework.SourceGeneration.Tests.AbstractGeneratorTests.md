# <a id="osu_Framework_SourceGeneration_Tests_AbstractGeneratorTests"></a> Class AbstractGeneratorTests

Namespace: [osu.Framework.SourceGeneration.Tests](osu.Framework.SourceGeneration.Tests.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public abstract class AbstractGeneratorTests
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AbstractGeneratorTests](osu.Framework.SourceGeneration.Tests.AbstractGeneratorTests.md)

#### Derived

[DependencyInjectionMultiPhaseSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.Dependencies.DependencyInjectionMultiPhaseSourceGeneratorTests.md), 
[DependencyInjectionSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.Dependencies.DependencyInjectionSourceGeneratorTests.md), 
[HandleInputSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.HandleInput.HandleInputSourceGeneratorTests.md), 
[LongRunningLoadSourceGeneratorTests](osu.Framework.SourceGeneration.Tests.LongRunningLoad.LongRunningLoadSourceGeneratorTests.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<AbstractGeneratorTests\>\(AbstractGeneratorTests?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<AbstractGeneratorTests\>\(AbstractGeneratorTests\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<AbstractGeneratorTests\>\(AbstractGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<AbstractGeneratorTests\>\(AbstractGeneratorTests\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<AbstractGeneratorTests, TChild\>\(AbstractGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<AbstractGeneratorTests, TChild\>\(AbstractGeneratorTests, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<AbstractGeneratorTests, TChild\>\(AbstractGeneratorTests, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<AbstractGeneratorTests\>\(AbstractGeneratorTests\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_AbstractGeneratorTests_ResourceNamespace"></a> ResourceNamespace

```csharp
protected virtual string ResourceNamespace { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_AbstractGeneratorTests_GetTestSources_System_String_System_ValueTuple_System_String_System_String_____System_ValueTuple_System_String_System_String_____System_ValueTuple_System_String_System_String_____System_ValueTuple_System_String_System_String_____"></a> GetTestSources\(string, out \(string filename, string content\)\[\], out \(string filename, string content\)\[\], out \(string filename, string content\)\[\], out \(string filename, string content\)\[\]\)

```csharp
protected void GetTestSources(string name, out (string filename, string content)[] commonSources, out (string filename, string content)[] sources, out (string filename, string content)[] commonGenerated, out (string filename, string content)[] generated)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`commonSources` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`sources` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`commonGenerated` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`generated` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

