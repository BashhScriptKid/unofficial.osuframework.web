# <a id="osu_Framework_Localisation_RomanisableString"></a> Class RomanisableString

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

A string that has a romanised fallback to allow a better experience for users that potentially can't read the original script.
See <xref href="osu.Framework.Configuration.FrameworkSetting.ShowUnicode" data-throw-if-not-resolved="false"></xref>, which can toggle the display of romanised variants.

```csharp
public class RomanisableString : IEquatable<RomanisableString>, ILocalisableStringData, IEquatable<ILocalisableStringData>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[RomanisableString](osu.Framework.Localisation.RomanisableString.md)

#### Implements

[IEquatable<RomanisableString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
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

[ObjectExtensions.AsNonNull<RomanisableString\>\(RomanisableString?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RomanisableString\>\(RomanisableString\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RomanisableString\>\(RomanisableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RomanisableString\>\(RomanisableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLower\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLower\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToSentence\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToSentence\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToTitle\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToTitle\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToUpper\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToUpper\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[ContainerExtensions.WithChild<RomanisableString, TChild\>\(RomanisableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RomanisableString, TChild\>\(RomanisableString, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RomanisableString, TChild\>\(RomanisableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RomanisableString\>\(RomanisableString\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_RomanisableString__ctor_System_String_System_String_"></a> RomanisableString\(string?, string?\)

Construct a new romanisable string.

```csharp
public RomanisableString(string? original, string? romanised)
```

#### Parameters

`original` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The string in its original script. If null, the <code class="paramref">romanised</code> version will always be used.

`romanised` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The romanised version of the string. If null, the <code class="paramref">original</code> version will always be used.

#### Remarks

For flexibility, both of the provided strings are allowed to be null. If both are null, the returned string value from <xref href="osu.Framework.Localisation.RomanisableString.GetLocalised(osu.Framework.Localisation.LocalisationParameters)" data-throw-if-not-resolved="false"></xref> will be <xref href="System.String.Empty" data-throw-if-not-resolved="false"></xref>.

## Fields

### <a id="osu_Framework_Localisation_RomanisableString_Original"></a> Original

The string in its original script. May be null.

```csharp
public readonly string? Original
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_Localisation_RomanisableString_Romanised"></a> Romanised

The romanised version of the string. May be null.

```csharp
public readonly string? Romanised
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="osu_Framework_Localisation_RomanisableString_Equals_osu_Framework_Localisation_RomanisableString_"></a> Equals\(RomanisableString?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(RomanisableString? other)
```

#### Parameters

`other` [RomanisableString](osu.Framework.Localisation.RomanisableString.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_RomanisableString_Equals_osu_Framework_Localisation_ILocalisableStringData_"></a> Equals\(ILocalisableStringData?\)

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

### <a id="osu_Framework_Localisation_RomanisableString_Equals_System_Object_"></a> Equals\(object?\)

Determines whether the specified object is equal to the current object.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified object  is equal to the current object; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_RomanisableString_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="osu_Framework_Localisation_RomanisableString_GetLocalised_osu_Framework_Localisation_LocalisationParameters_"></a> GetLocalised\(LocalisationParameters\)

Gets a localised <xref href="System.String" data-throw-if-not-resolved="false"></xref> using the given localisation store and other required data.

```csharp
public string GetLocalised(LocalisationParameters parameters)
```

#### Parameters

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

Any parameters that control the localisation method.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_RomanisableString_GetPreferred_System_Boolean_"></a> GetPreferred\(bool\)

Get the best match for this string based on a user preference for which should be displayed.

```csharp
public string GetPreferred(bool preferUnicode)
```

#### Parameters

`preferUnicode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to prefer the unicode (aka original) version where available.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The best match for the provided criteria.

### <a id="osu_Framework_Localisation_RomanisableString_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

