# <a id="osu_Framework_SourceGeneration_Analysers_DrawableCodeFixProvider"></a> Class DrawableCodeFixProvider

Namespace: [osu.Framework.SourceGeneration.Analysers](osu.Framework.SourceGeneration.Analysers.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
[ExportCodeFixProvider("C#", new string[] { })]
[Shared]
public class DrawableCodeFixProvider : CodeFixProvider
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CodeFixProvider](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.codefixes.codefixprovider) ← 
[DrawableCodeFixProvider](osu.Framework.SourceGeneration.Analysers.DrawableCodeFixProvider.md)

#### Inherited Members

[CodeFixProvider.RegisterCodeFixesAsync\(CodeFixContext\)](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.codefixes.codefixprovider.registercodefixesasync), 
[CodeFixProvider.GetFixAllProvider\(\)](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.codefixes.codefixprovider.getfixallprovider), 
[CodeFixProvider.FixableDiagnosticIds](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.codefixes.codefixprovider.fixablediagnosticids), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DrawableCodeFixProvider\>\(DrawableCodeFixProvider?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DrawableCodeFixProvider\>\(DrawableCodeFixProvider\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DrawableCodeFixProvider\>\(DrawableCodeFixProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DrawableCodeFixProvider\>\(DrawableCodeFixProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DrawableCodeFixProvider, TChild\>\(DrawableCodeFixProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DrawableCodeFixProvider, TChild\>\(DrawableCodeFixProvider, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DrawableCodeFixProvider, TChild\>\(DrawableCodeFixProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DrawableCodeFixProvider\>\(DrawableCodeFixProvider\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_SourceGeneration_Analysers_DrawableCodeFixProvider_FixableDiagnosticIds"></a> FixableDiagnosticIds

A list of diagnostic IDs that this provider can provide fixes for.

```csharp
public override ImmutableArray<string> FixableDiagnosticIds { get; }
```

#### Property Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="osu_Framework_SourceGeneration_Analysers_DrawableCodeFixProvider_GetFixAllProvider"></a> GetFixAllProvider\(\)

Gets an optional <xref href="Microsoft.CodeAnalysis.CodeFixes.FixAllProvider" data-throw-if-not-resolved="false"></xref> that can fix all/multiple occurrences of diagnostics fixed by this code fix provider.
Return null if the provider doesn't support fix all/multiple occurrences.
Otherwise, you can return any of the well known fix all providers from <xref href="Microsoft.CodeAnalysis.CodeFixes.WellKnownFixAllProviders" data-throw-if-not-resolved="false"></xref> or implement your own fix all provider.

```csharp
public override FixAllProvider GetFixAllProvider()
```

#### Returns

 [FixAllProvider](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.codefixes.fixallprovider)

### <a id="osu_Framework_SourceGeneration_Analysers_DrawableCodeFixProvider_RegisterCodeFixesAsync_Microsoft_CodeAnalysis_CodeFixes_CodeFixContext_"></a> RegisterCodeFixesAsync\(CodeFixContext\)

Computes one or more fixes for the specified <xref href="Microsoft.CodeAnalysis.CodeFixes.CodeFixContext" data-throw-if-not-resolved="false"></xref>.

```csharp
public override Task RegisterCodeFixesAsync(CodeFixContext context)
```

#### Parameters

`context` [CodeFixContext](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.codefixes.codefixcontext)

A <xref href="Microsoft.CodeAnalysis.CodeFixes.CodeFixContext" data-throw-if-not-resolved="false"></xref> containing context information about the diagnostics to fix.
The context must only contain diagnostics with a <xref href="Microsoft.CodeAnalysis.Diagnostic.Id" data-throw-if-not-resolved="false"></xref> included in the <xref href="Microsoft.CodeAnalysis.CodeFixes.CodeFixProvider.FixableDiagnosticIds" data-throw-if-not-resolved="false"></xref> for the current provider.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

