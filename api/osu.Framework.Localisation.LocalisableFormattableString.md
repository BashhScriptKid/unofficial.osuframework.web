# <a id="osu_Framework_Localisation_LocalisableFormattableString"></a> Class LocalisableFormattableString

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

A localisable string with formatting support.

```csharp
public class LocalisableFormattableString : IEquatable<LocalisableFormattableString>, ILocalisableStringData, IEquatable<ILocalisableStringData>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisableFormattableString](osu.Framework.Localisation.LocalisableFormattableString.md)

#### Derived

[TranslatableString](osu.Framework.Localisation.TranslatableString.md)

#### Implements

[IEquatable<LocalisableFormattableString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
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

[ObjectExtensions.AsNonNull<LocalisableFormattableString\>\(LocalisableFormattableString?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisableFormattableString\>\(LocalisableFormattableString\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisableFormattableString\>\(LocalisableFormattableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisableFormattableString\>\(LocalisableFormattableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLower\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLower\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToSentence\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToSentence\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToTitle\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToTitle\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToUpper\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToUpper\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[ContainerExtensions.WithChild<LocalisableFormattableString, TChild\>\(LocalisableFormattableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisableFormattableString, TChild\>\(LocalisableFormattableString, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisableFormattableString, TChild\>\(LocalisableFormattableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisableFormattableString\>\(LocalisableFormattableString\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_LocalisableFormattableString__ctor_System_FormattableString_"></a> LocalisableFormattableString\(FormattableString\)

Creates a <xref href="osu.Framework.Localisation.LocalisableFormattableString" data-throw-if-not-resolved="false"></xref> with an <xref href="System.IFormattable" data-throw-if-not-resolved="false"></xref> value and a format string.

```csharp
protected LocalisableFormattableString(FormattableString interpolation)
```

#### Parameters

`interpolation` [FormattableString](https://learn.microsoft.com/dotnet/api/system.formattablestring)

The interpolated string containing format and arguments.

### <a id="osu_Framework_Localisation_LocalisableFormattableString__ctor_System_String_System_Object___"></a> LocalisableFormattableString\(string, object?\[\]\)

Creates a <xref href="osu.Framework.Localisation.LocalisableFormattableString" data-throw-if-not-resolved="false"></xref> with an <xref href="System.IFormattable" data-throw-if-not-resolved="false"></xref> value and a format string.

```csharp
protected LocalisableFormattableString(string format, object?[] args)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)

The format string.

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

The objects to format.

#### Remarks

Note that the <code class="paramref">args</code> parameter is intentionally not marked with <code>params</code> to avoid taking priority over the <xref href="osu.Framework.Localisation.LocalisableFormattableString.%23ctor(System.FormattableString)" data-throw-if-not-resolved="false"></xref> constructor.
For more information, see https://github.com/dotnet/roslyn/issues/46.

## Fields

### <a id="osu_Framework_Localisation_LocalisableFormattableString_Args"></a> Args

```csharp
public readonly object?[] Args
```

#### Field Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="osu_Framework_Localisation_LocalisableFormattableString_Format"></a> Format

```csharp
public readonly string Format
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Localisation_LocalisableFormattableString_Equals_osu_Framework_Localisation_LocalisableFormattableString_"></a> Equals\(LocalisableFormattableString?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(LocalisableFormattableString? other)
```

#### Parameters

`other` [LocalisableFormattableString](osu.Framework.Localisation.LocalisableFormattableString.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_LocalisableFormattableString_Equals_osu_Framework_Localisation_ILocalisableStringData_"></a> Equals\(ILocalisableStringData?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public virtual bool Equals(ILocalisableStringData? other)
```

#### Parameters

`other` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_LocalisableFormattableString_Equals_System_Object_"></a> Equals\(object?\)

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

### <a id="osu_Framework_Localisation_LocalisableFormattableString_FormatString_System_String_System_Object___osu_Framework_Localisation_LocalisationParameters_"></a> FormatString\(string, object?\[\], LocalisationParameters\)

```csharp
protected virtual string FormatString(string format, object?[] args, LocalisationParameters parameters)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_LocalisableFormattableString_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

### <a id="osu_Framework_Localisation_LocalisableFormattableString_GetLocalised_osu_Framework_Localisation_LocalisationParameters_"></a> GetLocalised\(LocalisationParameters\)

Gets a localised <xref href="System.String" data-throw-if-not-resolved="false"></xref> using the given localisation store and other required data.

```csharp
public string GetLocalised(LocalisationParameters parameters)
```

#### Parameters

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

Any parameters that control the localisation method.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_LocalisableFormattableString_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

