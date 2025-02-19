# <a id="osu_Framework_SourceGeneration_SyntaxHelpers"></a> Class SyntaxHelpers

Namespace: [osu.Framework.SourceGeneration](osu.Framework.SourceGeneration.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public static class SyntaxHelpers
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SyntaxHelpers](osu.Framework.SourceGeneration.SyntaxHelpers.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_CacheDependencyInvocation_System_String_Microsoft_CodeAnalysis_CSharp_Syntax_ExpressionSyntax_System_String_System_String_System_String_"></a> CacheDependencyInvocation\(string, ExpressionSyntax, string?, string?, string?\)

```csharp
public static InvocationExpressionSyntax CacheDependencyInvocation(string callerType, ExpressionSyntax objSyntax, string? asType, string? cachedName, string? propertyName)
```

#### Parameters

`callerType` [string](https://learn.microsoft.com/dotnet/api/system.string)

`objSyntax` [ExpressionSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.expressionsyntax)

`asType` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`cachedName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [InvocationExpressionSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.invocationexpressionsyntax)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_GetDeclaredInterfacesOnType_Microsoft_CodeAnalysis_INamedTypeSymbol_"></a> GetDeclaredInterfacesOnType\(INamedTypeSymbol\)

```csharp
public static IEnumerable<ITypeSymbol> GetDeclaredInterfacesOnType(INamedTypeSymbol type)
```

#### Parameters

`type` [INamedTypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.inamedtypesymbol)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)\>

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_GetDependencyInvocation_System_String_System_String_System_String_System_String_System_Boolean_System_Boolean_"></a> GetDependencyInvocation\(string, string, string?, string?, bool, bool\)

```csharp
public static InvocationExpressionSyntax GetDependencyInvocation(string callerType, string requestedType, string? name, string? parent, bool canBeNull, bool rebindBindables)
```

#### Parameters

`callerType` [string](https://learn.microsoft.com/dotnet/api/system.string)

`requestedType` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`parent` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`canBeNull` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`rebindBindables` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [InvocationExpressionSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.invocationexpressionsyntax)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_GetFullyQualifiedSyntaxName_Microsoft_CodeAnalysis_CSharp_Syntax_TypeDeclarationSyntax_"></a> GetFullyQualifiedSyntaxName\(TypeDeclarationSyntax\)

```csharp
public static string GetFullyQualifiedSyntaxName(TypeDeclarationSyntax syntax)
```

#### Parameters

`syntax` [TypeDeclarationSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.typedeclarationsyntax)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_GetFullyQualifiedTypeName_Microsoft_CodeAnalysis_ITypeSymbol_"></a> GetFullyQualifiedTypeName\(ITypeSymbol\)

```csharp
public static string GetFullyQualifiedTypeName(ITypeSymbol type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_GetGlobalPrefixedTypeName_Microsoft_CodeAnalysis_ITypeSymbol_"></a> GetGlobalPrefixedTypeName\(ITypeSymbol?\)

Returns a fully-qualified name for the supplied <code class="paramref">type</code>, with the <code>global::</code> prefix included.

```csharp
public static string? GetGlobalPrefixedTypeName(ITypeSymbol? type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)?

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Remarks

<p>
Type keywords are not changed by this method, i.e. an <code>object</code> type symbol will be formatted to string as <code>object</code> rather than <code>System.Object</code>.
</p>
<p>
This method does not return <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if <code class="paramref">type</code> is not <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.
This cannot be expressed via <code>NotNullWhenNotNullAttribute</code> due to targeting .NET Standard 2.0.
</p>

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsBackgroundDependencyLoaderAttribute_Microsoft_CodeAnalysis_AttributeData_"></a> IsBackgroundDependencyLoaderAttribute\(AttributeData?\)

```csharp
public static bool IsBackgroundDependencyLoaderAttribute(AttributeData? attribute)
```

#### Parameters

`attribute` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsBackgroundDependencyLoaderAttribute_Microsoft_CodeAnalysis_ITypeSymbol_"></a> IsBackgroundDependencyLoaderAttribute\(ITypeSymbol?\)

```csharp
public static bool IsBackgroundDependencyLoaderAttribute(ITypeSymbol? type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsCachedAttribute_Microsoft_CodeAnalysis_AttributeData_"></a> IsCachedAttribute\(AttributeData?\)

```csharp
public static bool IsCachedAttribute(AttributeData? attribute)
```

#### Parameters

`attribute` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsCachedAttribute_Microsoft_CodeAnalysis_ITypeSymbol_"></a> IsCachedAttribute\(ITypeSymbol?\)

```csharp
public static bool IsCachedAttribute(ITypeSymbol? type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsIDependencyInjectionCandidateInterface_Microsoft_CodeAnalysis_ITypeSymbol_"></a> IsIDependencyInjectionCandidateInterface\(ITypeSymbol?\)

```csharp
public static bool IsIDependencyInjectionCandidateInterface(ITypeSymbol? type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsLongRunningLoadAttribute_Microsoft_CodeAnalysis_AttributeData_"></a> IsLongRunningLoadAttribute\(AttributeData?\)

```csharp
public static bool IsLongRunningLoadAttribute(AttributeData? attribute)
```

#### Parameters

`attribute` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsLongRunningLoadAttribute_Microsoft_CodeAnalysis_ITypeSymbol_"></a> IsLongRunningLoadAttribute\(ITypeSymbol?\)

```csharp
public static bool IsLongRunningLoadAttribute(ITypeSymbol? type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsResolvedAttribute_Microsoft_CodeAnalysis_AttributeData_"></a> IsResolvedAttribute\(AttributeData?\)

```csharp
public static bool IsResolvedAttribute(AttributeData? attribute)
```

#### Parameters

`attribute` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_IsResolvedAttribute_Microsoft_CodeAnalysis_ITypeSymbol_"></a> IsResolvedAttribute\(ITypeSymbol?\)

```csharp
public static bool IsResolvedAttribute(ITypeSymbol? type)
```

#### Parameters

`type` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_SyntaxHelpers_TypeOf_System_String_"></a> TypeOf\(string\)

```csharp
public static TypeOfExpressionSyntax TypeOf(string typeName)
```

#### Parameters

`typeName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [TypeOfExpressionSyntax](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.csharp.syntax.typeofexpressionsyntax)

