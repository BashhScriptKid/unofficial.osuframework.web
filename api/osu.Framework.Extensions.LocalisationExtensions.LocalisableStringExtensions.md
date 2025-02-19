# <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions"></a> Class LocalisableStringExtensions

Namespace: [osu.Framework.Extensions.LocalisationExtensions](osu.Framework.Extensions.LocalisationExtensions.md)  
Assembly: osu.Framework.dll  

```csharp
public static class LocalisableStringExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisableStringExtensions](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToLocalisableString_System_IFormattable_System_String_"></a> ToLocalisableString\(IFormattable, string?\)

Returns a <xref href="osu.Framework.Localisation.LocalisableFormattableString" data-throw-if-not-resolved="false"></xref> formatting the given <code class="paramref">value</code> to a string, along with an optional <code class="paramref">format</code> string.

```csharp
public static LocalisableString ToLocalisableString(this IFormattable value, string? format = null)
```

#### Parameters

`value` [IFormattable](https://learn.microsoft.com/dotnet/api/system.iformattable)

The value to format.

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The format string.

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToLower_osu_Framework_Localisation_LocalisableString_"></a> ToLower\(LocalisableString\)

Returns a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with the specified underlying localisable string lowercased.

```csharp
public static CaseTransformableString ToLower(this LocalisableString str)
```

#### Parameters

`str` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The localisable string.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its localisable string lowercased.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToLower_osu_Framework_Localisation_ILocalisableStringData_"></a> ToLower\(ILocalisableStringData\)

Returns a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with the specified underlying string data lowercased.

```csharp
public static CaseTransformableString ToLower(this ILocalisableStringData data)
```

#### Parameters

`data` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)

The string data.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its string data lowercased.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToSentence_osu_Framework_Localisation_LocalisableString_"></a> ToSentence\(LocalisableString\)

Returns a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with the specified underlying localisable string transformed to sentence case.

```csharp
public static CaseTransformableString ToSentence(this LocalisableString str)
```

#### Parameters

`str` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The localisable string.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its localisable string transformed to sentence case.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToSentence_osu_Framework_Localisation_ILocalisableStringData_"></a> ToSentence\(ILocalisableStringData\)

Returns a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with the specified underlying string data transformed to sentence case.

```csharp
public static CaseTransformableString ToSentence(this ILocalisableStringData data)
```

#### Parameters

`data` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)

The string data.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its string data transformed to sentence case.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToTitle_osu_Framework_Localisation_LocalisableString_"></a> ToTitle\(LocalisableString\)

Returns a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with the specified underlying localisable string transformed to title case.

```csharp
public static CaseTransformableString ToTitle(this LocalisableString str)
```

#### Parameters

`str` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The localisable string.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its localisable string transformed to title case.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToTitle_osu_Framework_Localisation_ILocalisableStringData_"></a> ToTitle\(ILocalisableStringData\)

Returns a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with the specified underlying string data transformed to title case.

```csharp
public static CaseTransformableString ToTitle(this ILocalisableStringData data)
```

#### Parameters

`data` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)

The string data.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its string data transformed to title case.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToUpper_osu_Framework_Localisation_LocalisableString_"></a> ToUpper\(LocalisableString\)

Returns a <xref href="osu.Framework.Localisation.CaseTransformableString" data-throw-if-not-resolved="false"></xref> with the specified underlying localisable string uppercased.

```csharp
public static CaseTransformableString ToUpper(this LocalisableString str)
```

#### Parameters

`str` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The localisable string.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its localisable string uppercased.

### <a id="osu_Framework_Extensions_LocalisationExtensions_LocalisableStringExtensions_ToUpper_osu_Framework_Localisation_ILocalisableStringData_"></a> ToUpper\(ILocalisableStringData\)

Returns a <xref href="osu.Framework.Localisation.CaseTransformableString" data-throw-if-not-resolved="false"></xref> with the specified underlying string data uppercased.

```csharp
public static CaseTransformableString ToUpper(this ILocalisableStringData data)
```

#### Parameters

`data` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)

The string data.

#### Returns

 [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

A case transformable string with its string data uppercased.

