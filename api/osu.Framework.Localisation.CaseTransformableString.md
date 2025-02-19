# <a id="osu_Framework_Localisation_CaseTransformableString"></a> Class CaseTransformableString

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

A string which can apply case transformations to underlying localisable string.

```csharp
public class CaseTransformableString : IEquatable<CaseTransformableString>, ILocalisableStringData, IEquatable<ILocalisableStringData>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

#### Implements

[IEquatable<CaseTransformableString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md), 
[IEquatable<ILocalisableStringData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CaseTransformableString\>\(CaseTransformableString?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CaseTransformableString\>\(CaseTransformableString\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CaseTransformableString\>\(CaseTransformableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CaseTransformableString\>\(CaseTransformableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLower\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLower\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToSentence\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToSentence\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToTitle\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToTitle\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToUpper\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToUpper\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[ContainerExtensions.WithChild<CaseTransformableString, TChild\>\(CaseTransformableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CaseTransformableString, TChild\>\(CaseTransformableString, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CaseTransformableString, TChild\>\(CaseTransformableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CaseTransformableString\>\(CaseTransformableString\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_CaseTransformableString__ctor_osu_Framework_Localisation_LocalisableString_osu_Framework_Localisation_Casing_"></a> CaseTransformableString\(LocalisableString, Casing\)

Constructs a new transformable string with specified underlying localisable string and casing.

```csharp
public CaseTransformableString(LocalisableString str, Casing casing)
```

#### Parameters

`str` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

The localisable string to apply case transformations on.

`casing` [Casing](osu.Framework.Localisation.Casing.md)

The casing to use on the localisable string.

## Fields

### <a id="osu_Framework_Localisation_CaseTransformableString_Casing"></a> Casing

The case to apply to the underlying data.

```csharp
public readonly Casing Casing
```

#### Field Value

 [Casing](osu.Framework.Localisation.Casing.md)

### <a id="osu_Framework_Localisation_CaseTransformableString_String"></a> String

The underlying localisable string of this transformable string.

```csharp
public readonly LocalisableString String
```

#### Field Value

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

## Methods

### <a id="osu_Framework_Localisation_CaseTransformableString_Equals_osu_Framework_Localisation_ILocalisableStringData_"></a> Equals\(ILocalisableStringData?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(ILocalisableStringData? other)
```

#### Parameters

`other` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_CaseTransformableString_Equals_osu_Framework_Localisation_CaseTransformableString_"></a> Equals\(CaseTransformableString?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(CaseTransformableString? other)
```

#### Parameters

`other` [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_CaseTransformableString_GetLocalised_osu_Framework_Localisation_LocalisationParameters_"></a> GetLocalised\(LocalisationParameters\)

Gets a localised <xref href="System.String" data-throw-if-not-resolved="false"></xref> using the given localisation store and other required data.

```csharp
public string GetLocalised(LocalisationParameters parameters)
```

#### Parameters

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

Any parameters that control the localisation method.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_CaseTransformableString_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

