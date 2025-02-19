# <a id="osu_Framework_Localisation_LocalisationParameters"></a> Class LocalisationParameters

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

A set of parameters that control the way strings are localised.

```csharp
public class LocalisationParameters
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LocalisationParameters\>\(LocalisationParameters?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisationParameters\>\(LocalisationParameters\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisationParameters\>\(LocalisationParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisationParameters\>\(LocalisationParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LocalisationParameters, TChild\>\(LocalisationParameters, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisationParameters, TChild\>\(LocalisationParameters, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisationParameters, TChild\>\(LocalisationParameters, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisationParameters\>\(LocalisationParameters\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_LocalisationParameters__ctor_osu_Framework_Localisation_LocalisationParameters_"></a> LocalisationParameters\(LocalisationParameters\)

Creates a new instance of <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref> based off another <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref>.

```csharp
protected LocalisationParameters(LocalisationParameters parameters)
```

#### Parameters

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

The <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref> to copy values from.

### <a id="osu_Framework_Localisation_LocalisationParameters__ctor_osu_Framework_Localisation_ILocalisationStore_System_Boolean_"></a> LocalisationParameters\(ILocalisationStore?, bool\)

Creates a new instance of <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref>.

```csharp
public LocalisationParameters(ILocalisationStore? store, bool preferOriginalScript)
```

#### Parameters

`store` [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)?

The <xref href="osu.Framework.Localisation.ILocalisationStore" data-throw-if-not-resolved="false"></xref> to be used for string lookups and culture-specific formatting.

`preferOriginalScript` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to prefer the "original" script of <xref href="osu.Framework.Localisation.RomanisableString" data-throw-if-not-resolved="false"></xref>s.

## Fields

### <a id="osu_Framework_Localisation_LocalisationParameters_DEFAULT"></a> DEFAULT

```csharp
public static readonly LocalisationParameters DEFAULT
```

#### Field Value

 [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

### <a id="osu_Framework_Localisation_LocalisationParameters_PreferOriginalScript"></a> PreferOriginalScript

Whether to prefer the "original" script of <xref href="osu.Framework.Localisation.RomanisableString" data-throw-if-not-resolved="false"></xref>s.

```csharp
public readonly bool PreferOriginalScript
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Localisation_LocalisationParameters_Store"></a> Store

The <xref href="osu.Framework.Localisation.ILocalisationStore" data-throw-if-not-resolved="false"></xref> to be used for string lookups and culture-specific formatting.

```csharp
public readonly ILocalisationStore? Store
```

#### Field Value

 [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)?

## Methods

### <a id="osu_Framework_Localisation_LocalisationParameters_With_osu_Framework_Localisation_ILocalisationStore_System_Nullable_System_Boolean__"></a> With\(ILocalisationStore?, bool?\)

Creates new <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref> from this <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref> with the provided fields changed.

```csharp
public LocalisationParameters With(ILocalisationStore? store = null, bool? preferOriginalScript = null)
```

#### Parameters

`store` [ILocalisationStore](osu.Framework.Localisation.ILocalisationStore.md)?

`preferOriginalScript` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)?

#### Returns

 [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

New <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref> based on this <xref href="osu.Framework.Localisation.LocalisationParameters" data-throw-if-not-resolved="false"></xref>.

