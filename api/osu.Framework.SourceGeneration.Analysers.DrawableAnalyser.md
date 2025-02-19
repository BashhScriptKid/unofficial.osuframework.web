# <a id="osu_Framework_SourceGeneration_Analysers_DrawableAnalyser"></a> Class DrawableAnalyser

Namespace: [osu.Framework.SourceGeneration.Analysers](osu.Framework.SourceGeneration.Analysers.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
[DiagnosticAnalyzer("C#", new string[] { })]
public class DrawableAnalyser : DiagnosticAnalyzer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[DiagnosticAnalyzer](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.diagnosticanalyzer) ← 
[DrawableAnalyser](osu.Framework.SourceGeneration.Analysers.DrawableAnalyser.md)

#### Inherited Members

[DiagnosticAnalyzer.Initialize\(AnalysisContext\)](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.diagnosticanalyzer.initialize), 
[DiagnosticAnalyzer.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.diagnosticanalyzer.equals), 
[DiagnosticAnalyzer.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.diagnosticanalyzer.gethashcode), 
[DiagnosticAnalyzer.ToString\(\)](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.diagnosticanalyzer.tostring), 
[DiagnosticAnalyzer.SupportedDiagnostics](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.diagnosticanalyzer.supporteddiagnostics), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DrawableAnalyser\>\(DrawableAnalyser?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DrawableAnalyser\>\(DrawableAnalyser\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DrawableAnalyser\>\(DrawableAnalyser\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DrawableAnalyser\>\(DrawableAnalyser\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DrawableAnalyser, TChild\>\(DrawableAnalyser, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DrawableAnalyser, TChild\>\(DrawableAnalyser, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DrawableAnalyser, TChild\>\(DrawableAnalyser, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DrawableAnalyser\>\(DrawableAnalyser\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Analysers_DrawableAnalyser_SupportedDiagnostics"></a> SupportedDiagnostics

Returns a set of descriptors for the diagnostics that this analyzer is capable of producing.

```csharp
public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; }
```

#### Property Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[DiagnosticDescriptor](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnosticdescriptor)\>

## Methods

### <a id="osu_Framework_SourceGeneration_Analysers_DrawableAnalyser_Initialize_Microsoft_CodeAnalysis_Diagnostics_AnalysisContext_"></a> Initialize\(AnalysisContext\)

Called once at session start to register actions in the analysis context.

```csharp
public override void Initialize(AnalysisContext context)
```

#### Parameters

`context` [AnalysisContext](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.diagnostics.analysiscontext)

