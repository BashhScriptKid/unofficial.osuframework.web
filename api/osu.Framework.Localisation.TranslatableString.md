# <a id="osu_Framework_Localisation_TranslatableString"></a> Class TranslatableString

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

A string which can be translated using a key lookup.

```csharp
public class TranslatableString : LocalisableFormattableString, IEquatable<LocalisableFormattableString>, ILocalisableStringData, IEquatable<ILocalisableStringData>, IEquatable<TranslatableString>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalisableFormattableString](osu.Framework.Localisation.LocalisableFormattableString.md) ← 
[TranslatableString](osu.Framework.Localisation.TranslatableString.md)

#### Implements

[IEquatable<LocalisableFormattableString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md), 
[IEquatable<ILocalisableStringData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<TranslatableString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[LocalisableFormattableString.Format](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_Format), 
[LocalisableFormattableString.Args](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_Args), 
[LocalisableFormattableString.GetLocalised\(LocalisationParameters\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_GetLocalised\_osu\_Framework\_Localisation\_LocalisationParameters\_), 
[LocalisableFormattableString.FormatString\(string, object?\[\], LocalisationParameters\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_FormatString\_System\_String\_System\_Object\_\_\_osu\_Framework\_Localisation\_LocalisationParameters\_), 
[LocalisableFormattableString.ToString\(\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_ToString), 
[LocalisableFormattableString.Equals\(LocalisableFormattableString?\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_Equals\_osu\_Framework\_Localisation\_LocalisableFormattableString\_), 
[LocalisableFormattableString.Equals\(ILocalisableStringData?\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_Equals\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableFormattableString.Equals\(object?\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_Equals\_System\_Object\_), 
[LocalisableFormattableString.GetHashCode\(\)](osu.Framework.Localisation.LocalisableFormattableString.md\#osu\_Framework\_Localisation\_LocalisableFormattableString\_GetHashCode), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TranslatableString\>\(TranslatableString?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TranslatableString\>\(TranslatableString\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TranslatableString\>\(TranslatableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TranslatableString\>\(TranslatableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLower\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLower\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToSentence\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToSentence\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToTitle\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToTitle\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[LocalisableStringExtensions.ToUpper\(ILocalisableStringData\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToUpper\_osu\_Framework\_Localisation\_ILocalisableStringData\_), 
[ContainerExtensions.WithChild<TranslatableString, TChild\>\(TranslatableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TranslatableString, TChild\>\(TranslatableString, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TranslatableString, TChild\>\(TranslatableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TranslatableString\>\(TranslatableString\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_TranslatableString__ctor_System_String_System_String_System_Object___"></a> TranslatableString\(string, string, params object?\[\]\)

Creates a <xref href="osu.Framework.Localisation.TranslatableString" data-throw-if-not-resolved="false"></xref> using texts.

```csharp
public TranslatableString(string key, string fallback, params object?[] args)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

The key for <xref href="osu.Framework.Localisation.LocalisationManager" data-throw-if-not-resolved="false"></xref> to look up with.

`fallback` [string](https://learn.microsoft.com/dotnet/api/system.string)

The fallback string to use when no translation can be found.

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

Optional formattable arguments.

### <a id="osu_Framework_Localisation_TranslatableString__ctor_System_String_System_FormattableString_"></a> TranslatableString\(string, FormattableString\)

Creates a <xref href="osu.Framework.Localisation.TranslatableString" data-throw-if-not-resolved="false"></xref> using interpolated string.
Example usage:
<pre><code class="lang-csharp">new TranslatableString("played_count_self", $"You have played {count:N0} times!");</code></pre>

```csharp
public TranslatableString(string key, FormattableString interpolation)
```

#### Parameters

`key` [string](https://learn.microsoft.com/dotnet/api/system.string)

The key for <xref href="osu.Framework.Localisation.LocalisationManager" data-throw-if-not-resolved="false"></xref> to look up with.

`interpolation` [FormattableString](https://learn.microsoft.com/dotnet/api/system.formattablestring)

The interpolated string containing fallback and formattable arguments.

## Fields

### <a id="osu_Framework_Localisation_TranslatableString_Key"></a> Key

```csharp
public readonly string Key
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Localisation_TranslatableString_Equals_osu_Framework_Localisation_TranslatableString_"></a> Equals\(TranslatableString?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(TranslatableString? other)
```

#### Parameters

`other` [TranslatableString](osu.Framework.Localisation.TranslatableString.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_TranslatableString_Equals_osu_Framework_Localisation_ILocalisableStringData_"></a> Equals\(ILocalisableStringData?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public override bool Equals(ILocalisableStringData? other)
```

#### Parameters

`other` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_TranslatableString_Equals_System_Object_"></a> Equals\(object?\)

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

### <a id="osu_Framework_Localisation_TranslatableString_FormatString_System_String_System_Object___osu_Framework_Localisation_LocalisationParameters_"></a> FormatString\(string, object?\[\], LocalisationParameters\)

```csharp
protected override string FormatString(string fallback, object?[] args, LocalisationParameters parameters)
```

#### Parameters

`fallback` [string](https://learn.microsoft.com/dotnet/api/system.string)

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

`parameters` [LocalisationParameters](osu.Framework.Localisation.LocalisationParameters.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_TranslatableString_GetHashCode"></a> GetHashCode\(\)

Serves as the default hash function.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A hash code for the current object.

