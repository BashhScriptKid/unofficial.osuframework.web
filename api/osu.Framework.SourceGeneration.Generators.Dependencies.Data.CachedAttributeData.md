# <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData"></a> Struct CachedAttributeData

Namespace: [osu.Framework.SourceGeneration.Generators.Dependencies.Data](osu.Framework.SourceGeneration.Generators.Dependencies.Data.md)  
Assembly: osu.Framework.SourceGeneration.dll  

```csharp
public readonly struct CachedAttributeData : IEquatable<CachedAttributeData>
```

#### Implements

[IEquatable<CachedAttributeData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CachedAttributeData\>\(CachedAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetLocalisableDescription<CachedAttributeData\>\(CachedAttributeData\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CachedAttributeData\>\(CachedAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CachedAttributeData\>\(CachedAttributeData\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CachedAttributeData, TChild\>\(CachedAttributeData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CachedAttributeData, TChild\>\(CachedAttributeData, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CachedAttributeData, TChild\>\(CachedAttributeData, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CachedAttributeData\>\(CachedAttributeData\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData__ctor_System_String_System_String_System_String_"></a> CachedAttributeData\(string?, string?, string?\)

```csharp
public CachedAttributeData(string? globalPrefixedTypeName, string? name, string? propertyName)
```

#### Parameters

`globalPrefixedTypeName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Fields

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_GlobalPrefixedTypeName"></a> GlobalPrefixedTypeName

```csharp
public readonly string? GlobalPrefixedTypeName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_Name"></a> Name

```csharp
public readonly string? Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_PropertyName"></a> PropertyName

```csharp
public readonly string? PropertyName
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_Equals_osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_"></a> Equals\(CachedAttributeData\)

```csharp
public bool Equals(CachedAttributeData other)
```

#### Parameters

`other` [CachedAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.CachedAttributeData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_Equals_System_Object_"></a> Equals\(object?\)

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_FromInterfaceOrClass_Microsoft_CodeAnalysis_ITypeSymbol_Microsoft_CodeAnalysis_AttributeData_"></a> FromInterfaceOrClass\(ITypeSymbol, AttributeData\)

```csharp
public static CachedAttributeData FromInterfaceOrClass(ITypeSymbol typeSymbol, AttributeData attributeData)
```

#### Parameters

`typeSymbol` [ITypeSymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.itypesymbol)

`attributeData` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)

#### Returns

 [CachedAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.CachedAttributeData.md)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_FromPropertyOrField_Microsoft_CodeAnalysis_ISymbol_Microsoft_CodeAnalysis_AttributeData_"></a> FromPropertyOrField\(ISymbol, AttributeData\)

```csharp
public static CachedAttributeData FromPropertyOrField(ISymbol symbol, AttributeData attributeData)
```

#### Parameters

`symbol` [ISymbol](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.isymbol)

`attributeData` [AttributeData](https://learn.microsoft.com/dotnet/api/microsoft.codeanalysis.attributedata)

#### Returns

 [CachedAttributeData](osu.Framework.SourceGeneration.Generators.Dependencies.Data.CachedAttributeData.md)

### <a id="osu_Framework_SourceGeneration_Generators_Dependencies_Data_CachedAttributeData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

