# <a id="osu_Framework_Localisation_LocalisableString"></a> Struct LocalisableString

Namespace: [osu.Framework.Localisation](osu.Framework.Localisation.md)  
Assembly: osu.Framework.dll  

A descriptor representing text that can be localised and formatted.

```csharp
public readonly struct LocalisableString : IEquatable<LocalisableString>
```

#### Implements

[IEquatable<LocalisableString\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LocalisableString\>\(LocalisableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LocalisableString\>\(LocalisableString\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LocalisableString\>\(LocalisableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LocalisableString\>\(LocalisableString\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLower\(LocalisableString\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLower\_osu\_Framework\_Localisation\_LocalisableString\_), 
[LocalisableStringExtensions.ToSentence\(LocalisableString\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToSentence\_osu\_Framework\_Localisation\_LocalisableString\_), 
[LocalisableStringExtensions.ToTitle\(LocalisableString\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToTitle\_osu\_Framework\_Localisation\_LocalisableString\_), 
[LocalisableStringExtensions.ToUpper\(LocalisableString\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToUpper\_osu\_Framework\_Localisation\_LocalisableString\_), 
[ContainerExtensions.WithChild<LocalisableString, TChild\>\(LocalisableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LocalisableString, TChild\>\(LocalisableString, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LocalisableString, TChild\>\(LocalisableString, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LocalisableString\>\(LocalisableString\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Localisation_LocalisableString__ctor_System_String_"></a> LocalisableString\(string\)

Creates a new <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with underlying string data.

```csharp
public LocalisableString(string data)
```

#### Parameters

`data` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Localisation_LocalisableString__ctor_osu_Framework_Localisation_ILocalisableStringData_"></a> LocalisableString\(ILocalisableStringData\)

Creates a new <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> with underlying localisable string data.

```csharp
public LocalisableString(ILocalisableStringData data)
```

#### Parameters

`data` [ILocalisableStringData](osu.Framework.Localisation.ILocalisableStringData.md)

## Methods

### <a id="osu_Framework_Localisation_LocalisableString_Equals_osu_Framework_Localisation_LocalisableString_"></a> Equals\(LocalisableString\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(LocalisableString other)
```

#### Parameters

`other` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_LocalisableString_Equals_System_Object_"></a> Equals\(object?\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Localisation_LocalisableString_Format_System_String_System_Object___"></a> Format\(string, params object?\[\]\)

Replaces one or more format items in a specified string with a localised string representation of a corresponding object in <code class="paramref">args</code>.

```csharp
[StringFormatMethod("format")]
public static LocalisableString Format(string format, params object?[] args)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)

The format string.

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

The objects to format.

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Localisation_LocalisableString_Interpolate_System_FormattableString_"></a> Interpolate\(FormattableString\)

Creates a <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> representation of the specified interpolated string.

```csharp
public static LocalisableString Interpolate(FormattableString interpolation)
```

#### Parameters

`interpolation` [FormattableString](https://learn.microsoft.com/dotnet/api/system.formattablestring)

The interpolated string containing format and arguments.

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_IsNullOrEmpty_System_Nullable_osu_Framework_Localisation_LocalisableString__"></a> IsNullOrEmpty\(LocalisableString?\)

Indicates whether the specified <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> or an empty <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a>.

```csharp
public static bool IsNullOrEmpty(LocalisableString? value)
```

#### Parameters

`value` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)?

The <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the <code class="paramref">value</code> parameter is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> or an empty <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a> ("");
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Remarks

Will always be false for non-<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a> data (e.g. <xref href="osu.Framework.Localisation.TranslatableString" data-throw-if-not-resolved="false"></xref>).

### <a id="osu_Framework_Localisation_LocalisableString_IsNullOrWhiteSpace_System_Nullable_osu_Framework_Localisation_LocalisableString__"></a> IsNullOrWhiteSpace\(LocalisableString?\)

Indicates whether the specified <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, an empty <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a>,
or a <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a> that consists of only white-space characters.

```csharp
public static bool IsNullOrWhiteSpace(LocalisableString? value)
```

#### Parameters

`value` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)?

The <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the <code class="paramref">value</code> parameter is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>, an empty <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a> (""),
or a <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a> that consists of only white-space characters.

#### Remarks

Will always be false for non-<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types">string</a> data (e.g. <xref href="osu.Framework.Localisation.TranslatableString" data-throw-if-not-resolved="false"></xref>).

### <a id="osu_Framework_Localisation_LocalisableString_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="osu_Framework_Localisation_LocalisableString_op_Equality_osu_Framework_Localisation_LocalisableString_osu_Framework_Localisation_LocalisableString_"></a> operator ==\(LocalisableString, LocalisableString\)

```csharp
public static bool operator ==(LocalisableString left, LocalisableString right)
```

#### Parameters

`left` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

`right` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Localisation_LocalisableString_op_Implicit_System_String__osu_Framework_Localisation_LocalisableString"></a> implicit operator LocalisableString\(string\)

```csharp
public static implicit operator LocalisableString(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_op_Implicit_osu_Framework_Localisation_TranslatableString__osu_Framework_Localisation_LocalisableString"></a> implicit operator LocalisableString\(TranslatableString\)

```csharp
public static implicit operator LocalisableString(TranslatableString translatable)
```

#### Parameters

`translatable` [TranslatableString](osu.Framework.Localisation.TranslatableString.md)

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_op_Implicit_osu_Framework_Localisation_RomanisableString__osu_Framework_Localisation_LocalisableString"></a> implicit operator LocalisableString\(RomanisableString\)

```csharp
public static implicit operator LocalisableString(RomanisableString romanisable)
```

#### Parameters

`romanisable` [RomanisableString](osu.Framework.Localisation.RomanisableString.md)

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_op_Implicit_osu_Framework_Localisation_LocalisableFormattableString__osu_Framework_Localisation_LocalisableString"></a> implicit operator LocalisableString\(LocalisableFormattableString\)

```csharp
public static implicit operator LocalisableString(LocalisableFormattableString formattable)
```

#### Parameters

`formattable` [LocalisableFormattableString](osu.Framework.Localisation.LocalisableFormattableString.md)

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_op_Implicit_osu_Framework_Localisation_CaseTransformableString__osu_Framework_Localisation_LocalisableString"></a> implicit operator LocalisableString\(CaseTransformableString\)

```csharp
public static implicit operator LocalisableString(CaseTransformableString transformable)
```

#### Parameters

`transformable` [CaseTransformableString](osu.Framework.Localisation.CaseTransformableString.md)

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

### <a id="osu_Framework_Localisation_LocalisableString_op_Inequality_osu_Framework_Localisation_LocalisableString_osu_Framework_Localisation_LocalisableString_"></a> operator \!=\(LocalisableString, LocalisableString\)

```csharp
public static bool operator !=(LocalisableString left, LocalisableString right)
```

#### Parameters

`left` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

`right` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

