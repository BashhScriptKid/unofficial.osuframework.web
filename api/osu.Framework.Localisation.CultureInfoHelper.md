# <a id="osu_Framework_Localisation_CultureInfoHelper"></a> Class CultureInfoHelper

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

```csharp
public static class CultureInfoHelper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CultureInfoHelper](osu.Framework.Localisation.CultureInfoHelper.md)

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

## Properties

### <a id="osu_Framework_Localisation_CultureInfoHelper_SystemCulture"></a> SystemCulture

The system-default <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> used for number, date, time and other string formatting.

```csharp
public static CultureInfo SystemCulture { get; }
```

#### Property Value

 [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

### <a id="osu_Framework_Localisation_CultureInfoHelper_SystemUICulture"></a> SystemUICulture

The system-default <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> used for app languages/translations.

```csharp
public static CultureInfo SystemUICulture { get; }
```

#### Property Value

 [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

## Methods

### <a id="osu_Framework_Localisation_CultureInfoHelper_EnumerateParentCultures_System_Globalization_CultureInfo_"></a> EnumerateParentCultures\(CultureInfo\)

Enumerates all <xref href="System.Globalization.CultureInfo.Parent" data-throw-if-not-resolved="false"></xref> cultures of this <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> (including itself, but excluding <xref href="System.Globalization.CultureInfo.InvariantCulture" data-throw-if-not-resolved="false"></xref>).

```csharp
public static IEnumerable<CultureInfo> EnumerateParentCultures(this CultureInfo cultureInfo)
```

#### Parameters

`cultureInfo` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)\>

### <a id="osu_Framework_Localisation_CultureInfoHelper_TryGetCultureInfo_System_String_System_Globalization_CultureInfo__"></a> TryGetCultureInfo\(string, out CultureInfo\)

Wrapper around <xref href="System.Globalization.CultureInfo.GetCultureInfo(System.String)" data-throw-if-not-resolved="false"></xref> providing common behaviour and exception handling.

```csharp
public static bool TryGetCultureInfo(string name, out CultureInfo culture)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

Name of the culture.

`culture` [CultureInfo](https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo)

The <xref href="System.Globalization.CultureInfo" data-throw-if-not-resolved="false"></xref> with the specified <code class="paramref">name</code>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the culture was successfully retrieved and a is .NET/OS predefined culture.

