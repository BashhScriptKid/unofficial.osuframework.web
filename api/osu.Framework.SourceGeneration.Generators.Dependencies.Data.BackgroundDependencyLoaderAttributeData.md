# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData"></a> Struct BackgroundDependencyLoaderAttributeData

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Data](osu.Framework.SourceGeneration.Generators.Dependencies.Data.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public readonly struct BackgroundDependencyLoaderAttributeData
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BackgroundDependencyLoaderAttributeData\>\(BackgroundDependencyLoaderAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetLocalisableDescription<BackgroundDependencyLoaderAttributeData\>\(BackgroundDependencyLoaderAttributeData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BackgroundDependencyLoaderAttributeData\>\(BackgroundDependencyLoaderAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BackgroundDependencyLoaderAttributeData\>\(BackgroundDependencyLoaderAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BackgroundDependencyLoaderAttributeData, TChild\>\(BackgroundDependencyLoaderAttributeData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BackgroundDependencyLoaderAttributeData, TChild\>\(BackgroundDependencyLoaderAttributeData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BackgroundDependencyLoaderAttributeData, TChild\>\(BackgroundDependencyLoaderAttributeData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BackgroundDependencyLoaderAttributeData\>\(BackgroundDependencyLoaderAttributeData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData__ctor_System_String_System_Boolean_System_Collections_Immutable_ImmutableArray_osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderParameterData__"></a> BackgroundDependencyLoaderAttributeData\(string, bool, ImmutableArray<BackgroundDependencyLoaderParameterData\>\)

```csharp
public BackgroundDependencyLoaderAttributeData(string methodName, bool canBeNull, ImmutableArray<BackgroundDependencyLoaderParameterData> parameters)
```

#### Parameters

`methodName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`canBeNull` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`parameters` [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[BackgroundDependencyLoaderParameterData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.BackgroundDependencyLoaderParameterData.md)\>

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData_CanBeNull"></a> CanBeNull

```csharp
public readonly bool CanBeNull
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData_MethodName"></a> MethodName

```csharp
public readonly string MethodName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData_Parameters"></a> Parameters

```csharp
public readonly ImmutableArray<BackgroundDependencyLoaderParameterData> Parameters
```

#### Field Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[BackgroundDependencyLoaderParameterData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.BackgroundDependencyLoaderParameterData.md)\>

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderAttributeData_FromMethod_Microsoft_CodeAnalysis_IMethodSymbol_Microsoft_CodeAnalysis_AttributeData_"></a> FromMethod\(IMethodSymbol, AttributeData\)

```csharp
public static BackgroundDependencyLoaderAttributeData FromMethod(IMethodSymbol method, AttributeData attributeData)
```

#### Parameters

`method` [IMethodSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.imethodsymbol)

`attributeData` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)

#### Returns

 [BackgroundDependencyLoaderAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.BackgroundDependencyLoaderAttributeData.md)

