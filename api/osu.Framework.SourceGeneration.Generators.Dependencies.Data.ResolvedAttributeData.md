# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData"></a> Struct ResolvedAttributeData

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Data](osu.Framework.SourceGeneration.Generators.Dependencies.Data.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public readonly struct ResolvedAttributeData
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ResolvedAttributeData\>\(ResolvedAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetLocalisableDescription<ResolvedAttributeData\>\(ResolvedAttributeData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ResolvedAttributeData\>\(ResolvedAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ResolvedAttributeData\>\(ResolvedAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ResolvedAttributeData, TChild\>\(ResolvedAttributeData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ResolvedAttributeData, TChild\>\(ResolvedAttributeData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ResolvedAttributeData, TChild\>\(ResolvedAttributeData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ResolvedAttributeData\>\(ResolvedAttributeData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData__ctor_System_String_System_String_System_String_System_String_System_Boolean_"></a> ResolvedAttributeData\(string, string, string?, string?, bool\)

```csharp
public ResolvedAttributeData(string globalPrefixedTypeName, string propertyName, string? globalPrefixedParentTypeName, string? cachedName, bool canBeNull)
```

#### Parameters

`globalPrefixedTypeName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`globalPrefixedParentTypeName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`cachedName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`canBeNull` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_CachedName"></a> CachedName

```csharp
public readonly string? CachedName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_CanBeNull"></a> CanBeNull

```csharp
public readonly bool CanBeNull
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_GlobalPrefixedParentTypeName"></a> GlobalPrefixedParentTypeName

```csharp
public readonly string? GlobalPrefixedParentTypeName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_GlobalPrefixedTypeName"></a> GlobalPrefixedTypeName

```csharp
public readonly string GlobalPrefixedTypeName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_PropertyName"></a> PropertyName

```csharp
public readonly string PropertyName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_ResolvedAttributeData_FromProperty_Microsoft_CodeAnalysis_IPropertySymbol_Microsoft_CodeAnalysis_AttributeData_"></a> FromProperty\(IPropertySymbol, AttributeData\)

```csharp
public static ResolvedAttributeData FromProperty(IPropertySymbol symbol, AttributeData attributeData)
```

#### Parameters

`symbol` [IPropertySymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.ipropertysymbol)

`attributeData` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)

#### Returns

 [ResolvedAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.ResolvedAttributeData.md)

