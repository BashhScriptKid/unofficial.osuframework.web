# <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1_Test"></a> Class CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test

Namespace: [osu.Framework.SourceGeneration.Tests.Verifiers](osu.Framework.SourceGeneration.Tests.Verifiers.md)  
Assembly: osu.Framework.SourceGeneration.Tests.dll  

```csharp
public class CSharpSourceGeneratorVerifier<TSourceGenerator>.Test : CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
AnalyzerTest<DefaultVerifier\> ← 
SourceGeneratorTest<DefaultVerifier\> ← 
CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier\> ← 
[CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test](osu.Framework.SourceGeneration.Tests.Verifiers.CSharpSourceGeneratorVerifier\-1.Test.md)

#### Inherited Members

CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier\>.GetSourceGenerators\(\), 
CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier\>.CreateCompilationOptions\(\), 
CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier\>.CreateParseOptions\(\), 
CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier\>.DefaultFileExt, 
CSharpSourceGeneratorTest<EmptySourceGeneratorProvider, DefaultVerifier\>.Language, 
SourceGeneratorTest<DefaultVerifier\>.GetDiagnosticAnalyzers\(\), 
SourceGeneratorTest<DefaultVerifier\>.GetSourceGenerators\(\), 
AnalyzerTest<DefaultVerifier\>.RunAsync\(CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.RunImplAsync\(CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.GetDefaultDiagnostic\(DiagnosticAnalyzer\[\]\), 
AnalyzerTest<DefaultVerifier\>.FormatVerifierMessage\(ImmutableArray<DiagnosticAnalyzer\>, Diagnostic, DiagnosticResult, string\), 
AnalyzerTest<DefaultVerifier\>.VerifySourceGeneratorAsync\(SolutionState, IVerifier, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.VerifyDiagnosticsAsync\(EvaluatedProjectState, ImmutableArray<EvaluatedProjectState\>, DiagnosticResult\[\], IVerifier, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.GetSortedDiagnosticsAsync\(Solution, ImmutableArray<DiagnosticAnalyzer\>, ImmutableArray<\(Project project, Diagnostic diagnostic\)\>, CompilerDiagnostics, IVerifier, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.GetProjectCompilationAsync\(Project, IVerifier, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.IsCompilerDiagnosticIncluded\(Diagnostic, CompilerDiagnostics\), 
AnalyzerTest<DefaultVerifier\>.GetAnalyzerOptions\(Project\), 
AnalyzerTest<DefaultVerifier\>.CreateCompilationWithAnalyzers\(Compilation, ImmutableArray<DiagnosticAnalyzer\>, AnalyzerOptions, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.CreateProjectAsync\(EvaluatedProjectState, ImmutableArray<EvaluatedProjectState\>, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.CreateProjectImplAsync\(EvaluatedProjectState, ImmutableArray<EvaluatedProjectState\>, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.GetNameAndFoldersFromPath\(string, string\), 
AnalyzerTest<DefaultVerifier\>.CreateSolutionAsync\(ProjectId, EvaluatedProjectState, CancellationToken\), 
AnalyzerTest<DefaultVerifier\>.ApplyCompilationOptions\(Project\), 
AnalyzerTest<DefaultVerifier\>.CreateWorkspaceAsync\(\), 
AnalyzerTest<DefaultVerifier\>.CreateWorkspaceImplAsync\(\), 
AnalyzerTest<DefaultVerifier\>.CreateCompilationOptions\(\), 
AnalyzerTest<DefaultVerifier\>.CreateParseOptions\(\), 
AnalyzerTest<DefaultVerifier\>.FilterDiagnostics\(ImmutableArray<\(Project project, Diagnostic diagnostic\)\>\), 
AnalyzerTest<DefaultVerifier\>.SortDistinctDiagnostics\(ImmutableArray<\(Project project, Diagnostic diagnostic\)\>\), 
AnalyzerTest<DefaultVerifier\>.GetDiagnosticAnalyzers\(\), 
AnalyzerTest<DefaultVerifier\>.GetSourceGenerators\(\), 
AnalyzerTest<DefaultVerifier\>.Verify, 
AnalyzerTest<DefaultVerifier\>.DefaultFilePathPrefix, 
AnalyzerTest<DefaultVerifier\>.DefaultTestProjectName, 
AnalyzerTest<DefaultVerifier\>.DefaultFilePath, 
AnalyzerTest<DefaultVerifier\>.DefaultFileExt, 
AnalyzerTest<DefaultVerifier\>.Language, 
AnalyzerTest<DefaultVerifier\>.TestCode, 
AnalyzerTest<DefaultVerifier\>.ExpectedDiagnostics, 
AnalyzerTest<DefaultVerifier\>.CompilerDiagnostics, 
AnalyzerTest<DefaultVerifier\>.MarkupOptions, 
AnalyzerTest<DefaultVerifier\>.TestState, 
AnalyzerTest<DefaultVerifier\>.XmlReferences, 
AnalyzerTest<DefaultVerifier\>.TestBehaviors, 
AnalyzerTest<DefaultVerifier\>.DisabledDiagnostics, 
AnalyzerTest<DefaultVerifier\>.ReferenceAssemblies, 
AnalyzerTest<DefaultVerifier\>.DiagnosticVerifier, 
AnalyzerTest<DefaultVerifier\>.OptionsTransforms, 
AnalyzerTest<DefaultVerifier\>.SolutionTransforms, 
AnalyzerTest<DefaultVerifier\>.MatchDiagnosticsTimeout, 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\>\(CSharpSourceGeneratorVerifier<TSourceGenerator\>.Test\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1_Test_LanguageVersion"></a> LanguageVersion

```csharp
public LanguageVersion LanguageVersion { get; set; }
```

#### Property Value

 [LanguageVersion](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.languageversion)

## Methods

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1_Test_CreateCompilationOptions"></a> CreateCompilationOptions\(\)

```csharp
protected override CompilationOptions CreateCompilationOptions()
```

#### Returns

 [CompilationOptions](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.compilationoptions)

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1_Test_CreateParseOptions"></a> CreateParseOptions\(\)

```csharp
protected override ParseOptions CreateParseOptions()
```

#### Returns

 [ParseOptions](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.parseoptions)

### <a id="osu_Framework_SourceGeneration_Tests_Verifiers_CSharpSourceGeneratorVerifier_1_Test_GetSourceGenerators"></a> GetSourceGenerators\(\)

Returns the source generators being tested - to be implemented in non-abstract class.

```csharp
protected override IEnumerable<Type> GetSourceGenerators()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Type](https://learn.microsoft.com/dotnet/api/system.type)\>

The <xref href="Microsoft.CodeAnalysis.ISourceGenerator" data-throw-if-not-resolved="false"></xref> and/or <xref href="Microsoft.CodeAnalysis.IIncrementalGenerator" data-throw-if-not-resolved="false"></xref> to be used.

