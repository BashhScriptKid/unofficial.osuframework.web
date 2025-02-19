# <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1"></a> Class CSharpSourceGeneratorVerifier<TSourceGenerator\>

Namespace: [osu.Framework.SourceGeneration.Tests.Verifiers](osu.Framework.SourceGeneration.Tests.Verifiers.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class CSharpSourceGeneratorVerifier<TSourceGenerator> where TSourceGenerator : AbstractIncrementalGenerator, new()
```

#### Type Parameters

`TSourceGenerator` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSharpSourceGeneratorVerifier<TSourceGenerator\>](osu.Framework.SourceGeneration.Tests.Verifiers.CSharpSourceGeneratorVerifier\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CSharpSourceGeneratorVerifier<TSourceGenerator\>\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CSharpSourceGeneratorVerifier<TSourceGenerator\>\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CSharpSourceGeneratorVerifier<TSourceGenerator\>\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CSharpSourceGeneratorVerifier<TSourceGenerator\>\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CSharpSourceGeneratorVerifier<TSourceGenerator\>, TChild\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CSharpSourceGeneratorVerifier<TSourceGenerator\>, TChild\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CSharpSourceGeneratorVerifier<TSourceGenerator\>, TChild\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CSharpSourceGeneratorVerifier<TSourceGenerator\>\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1_VerifyAsync_System_ValueTuple_System_String_System_String____System_ValueTuple_System_String_System_String____System_ValueTuple_System_String_System_String____System_ValueTuple_System_String_System_String____"></a> VerifyAsync\(\(string filename, string content\)\[\], \(string filename, string content\)\[\], \(string filename, string content\)\[\], \(string filename, string content\)\[\]\)

```csharp
public static Task VerifyAsync((string filename, string content)[] commonSources, (string filename, string content)[] sources, (string filename, string content)[] commonGenerated, (string filename, string content)[] generated)
```

#### Parameters

`commonSources` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`sources` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`commonGenerated` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

`generated` \([string](https://learn.microsoft.com/dotnet/api/system.string) [filename](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.filename), [string](https://learn.microsoft.com/dotnet/api/system.string) [content](https://learn.microsoft.com/dotnet/api/system.valuetuple\-system.string,system.string\-.content)\)\[\]

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

