# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderParameterData"></a> Struct BackgroundDependencyLoaderParameterData

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Data](osu.Framework.SourceGeneration.Generators.Dependencies.Data.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public readonly struct BackgroundDependencyLoaderParameterData
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<BackgroundDependencyLoaderParameterData\>\(BackgroundDependencyLoaderParameterData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetLocalisableDescription<BackgroundDependencyLoaderParameterData\>\(BackgroundDependencyLoaderParameterData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BackgroundDependencyLoaderParameterData\>\(BackgroundDependencyLoaderParameterData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BackgroundDependencyLoaderParameterData\>\(BackgroundDependencyLoaderParameterData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BackgroundDependencyLoaderParameterData, TChild\>\(BackgroundDependencyLoaderParameterData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BackgroundDependencyLoaderParameterData, TChild\>\(BackgroundDependencyLoaderParameterData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BackgroundDependencyLoaderParameterData, TChild\>\(BackgroundDependencyLoaderParameterData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BackgroundDependencyLoaderParameterData\>\(BackgroundDependencyLoaderParameterData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderParameterData__ctor_System_String_System_Boolean_"></a> BackgroundDependencyLoaderParameterData\(string, bool\)

```csharp
public BackgroundDependencyLoaderParameterData(string globalPrefixedTypeName, bool canBeNull)
```

#### Parameters

`globalPrefixedTypeName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`canBeNull` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderParameterData_CanBeNull"></a> CanBeNull

```csharp
public readonly bool CanBeNull
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderParameterData_GlobalPrefixedTypeName"></a> GlobalPrefixedTypeName

```csharp
public readonly string GlobalPrefixedTypeName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_BackgroundDependencyLoaderParameterData_FromParameter_Microsoft_CodeAnalysis_IParameterSymbol_"></a> FromParameter\(IParameterSymbol\)

```csharp
public static BackgroundDependencyLoaderParameterData FromParameter(IParameterSymbol parameter)
```

#### Parameters

`parameter` [IParameterSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.iparametersymbol)

#### Returns

 [BackgroundDependencyLoaderParameterData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.BackgroundDependencyLoaderParameterData.md)

