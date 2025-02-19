# <a id="osu_Framework_Extensions_ExtensionMethods"></a> Class ExtensionMethods

Namespace: [osu.Framework.Extensions](osu.Framework.Extensions.md)  
Assembly: osu.Framework.dll  

This class holds extension methods for various purposes and should not be used explicitly, ever.

```csharp
public static class ExtensionMethods
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ExtensionMethods](osu.Framework.Extensions.ExtensionMethods.md)

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

### <a id="osu_Framework_Extensions_ExtensionMethods_AddInPlace__1_System_Collections_Generic_List___0____0_"></a> AddInPlace<T\>\(List<T\>, T\)

Adds the given item to the list according to standard sorting rules. Do not use on unsorted lists.

```csharp
public static int AddInPlace<T>(this List<T> list, T item)
```

#### Parameters

`list` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

The list to take values

`item` T

The item that should be added.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index in the list where the item was inserted.

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ExtensionMethods_AddInPlace__1_System_Collections_Generic_List___0____0_System_Collections_Generic_IComparer___0__"></a> AddInPlace<T\>\(List<T\>, T, IComparer<T\>\)

Adds the given item to the list according to the comparers sorting rules. Do not use on unsorted lists.

```csharp
public static int AddInPlace<T>(this List<T> list, T item, IComparer<T> comparer)
```

#### Parameters

`list` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>

The list to take values

`item` T

The item that should be added.

`comparer` [IComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer\-1)<T\>

The comparer that should be used for sorting.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index in the list where the item was inserted.

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ExtensionMethods_CheckIsValidUrl_System_String_"></a> CheckIsValidUrl\(string\)

Checks whether the provided URL is a safe protocol to execute a system <xref href="System.Diagnostics.Process.Start" data-throw-if-not-resolved="false"></xref> call with.

```csharp
public static bool CheckIsValidUrl(this string url)
```

#### Parameters

`url` [string](https://learn.microsoft.com/dotnet/api/system.string)

The URL to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the URL is safe to open.

#### Remarks

For now, http://, https:// and mailto: are supported.
More protocols can be added if a use case comes up.

### <a id="osu_Framework_Extensions_ExtensionMethods_ComputeMD5Hash_System_IO_Stream_"></a> ComputeMD5Hash\(Stream\)

```csharp
public static string ComputeMD5Hash(this Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Extensions_ExtensionMethods_ComputeMD5Hash_System_String_"></a> ComputeMD5Hash\(string\)

```csharp
public static string ComputeMD5Hash(this string input)
```

#### Parameters

`input` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Extensions_ExtensionMethods_ComputeSHA2Hash_System_IO_Stream_"></a> ComputeSHA2Hash\(Stream\)

Gets a SHA-2 (256bit) hash for the given stream, seeking the stream before and after.

```csharp
public static string ComputeSHA2Hash(this Stream stream)
```

#### Parameters

`stream` [Stream](https://learn.microsoft.com/dotnet/api/system.io.stream)

The stream to create a hash from.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A lower-case hex string representation of the hash (64 characters).

### <a id="osu_Framework_Extensions_ExtensionMethods_ComputeSHA2Hash_System_String_"></a> ComputeSHA2Hash\(string\)

Gets a SHA-2 (256bit) hash for the given string.

```csharp
public static string ComputeSHA2Hash(this string str)
```

#### Parameters

`str` [string](https://learn.microsoft.com/dotnet/api/system.string)

The string to create a hash from.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A lower-case hex string representation of the hash (64 characters).

### <a id="osu_Framework_Extensions_ExtensionMethods_GetDescription_System_Object_"></a> GetDescription\(object\)

Returns the description of a given object, via (in order):
<ol><li>Any attached <xref href="System.ComponentModel.DescriptionAttribute" data-throw-if-not-resolved="false"></xref>.</li><li>The object's <xref href="System.Object.ToString" data-throw-if-not-resolved="false"></xref>.</li></ol>

```csharp
public static string GetDescription(this object value)
```

#### Parameters

`value` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

If the passed value is already of type <xref href="System.String" data-throw-if-not-resolved="false"></xref>, it will be returned.

### <a id="osu_Framework_Extensions_ExtensionMethods_GetLoadableTypes_System_Reflection_Assembly_"></a> GetLoadableTypes\(Assembly\)

```csharp
public static Type[] GetLoadableTypes(this Assembly assembly)
```

#### Parameters

`assembly` [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

#### Returns

 [Type](https://learn.microsoft.com/dotnet/api/system.type)\[\]

### <a id="osu_Framework_Extensions_ExtensionMethods_GetLocalisableDescription__1___0_"></a> GetLocalisableDescription<T\>\(T\)

Returns the localisable description of a given object, via (in order):
<ol><li>Any attached <xref href="osu.Framework.Localisation.LocalisableDescriptionAttribute" data-throw-if-not-resolved="false"></xref>.</li><li><xref href="osu.Framework.Extensions.ExtensionMethods.GetDescription(System.Object)" data-throw-if-not-resolved="false"></xref></li></ol>

```csharp
public static LocalisableString GetLocalisableDescription<T>(this T value)
```

#### Parameters

`value` T

#### Returns

 [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

#### Type Parameters

`T` 

#### Remarks

If the passed value is already of type <xref href="osu.Framework.Localisation.LocalisableString" data-throw-if-not-resolved="false"></xref>, it will be returned.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

When the <xref href="osu.Framework.Localisation.LocalisableDescriptionAttribute.Name" data-throw-if-not-resolved="false"></xref> specified in the <xref href="osu.Framework.Localisation.LocalisableDescriptionAttribute" data-throw-if-not-resolved="false"></xref>
does not match any of the existing members in <xref href="osu.Framework.Localisation.LocalisableDescriptionAttribute.DeclaringType" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Extensions_ExtensionMethods_Invert__1___0_0__0___"></a> Invert<T\>\(T\[,\]\)

Inverts the rows and columns of a rectangular array.

```csharp
public static T[,] Invert<T>(this T[,] array)
```

#### Parameters

`array` T\[,\]

The array to invert.

#### Returns

 T\[,\]

The inverted array.

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ExtensionMethods_Invert__1___0_____"></a> Invert<T\>\(T\[\]\[\]\)

Inverts the rows and columns of a jagged array.

```csharp
public static T[][] Invert<T>(this T[][] array)
```

#### Parameters

`array` T\[\]\[\]

The array to invert.

#### Returns

 T\[\]\[\]

The inverted array. This is always a square array.

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ExtensionMethods_IsAsciiDigit_System_Char_"></a> IsAsciiDigit\(char\)

Whether this character is an ASCII digit (0-9).

```csharp
[Obsolete("Use char.IsAsciiDigit.")]
public static bool IsAsciiDigit(this char character)
```

#### Parameters

`character` [char](https://learn.microsoft.com/dotnet/api/system.char)

The character to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if the character is an ASCII digit.

#### Remarks

Useful for checking if a character plays well with <code>int.TryParse()</code>.
<xref href="System.Char.IsNumber(System.Char)" data-throw-if-not-resolved="false"></xref> returns <code>true</code> for non-ASCII digits and other Unicode numbers;
we don't want that, so we explicitly check the character value.

### <a id="osu_Framework_Extensions_ExtensionMethods_ToJagged__1___0_0__0___"></a> ToJagged<T\>\(T\[,\]\)

Converts a rectangular array to a jagged array.
<p>
The jagged array will contain empty arrays if there are no columns in the rectangular array.
</p>

```csharp
public static T[][] ToJagged<T>(this T[,] rectangular)
```

#### Parameters

`rectangular` T\[,\]

The rectangular array.

#### Returns

 T\[\]\[\]

The jagged array.

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ExtensionMethods_ToRectangular__1___0_____"></a> ToRectangular<T\>\(T\[\]\[\]\)

Converts a jagged array to a rectangular array.
<p>
All elements that did not exist in the original jagged array are initialized to their default values.
</p>

```csharp
public static T[,] ToRectangular<T>(this T[][] jagged)
```

#### Parameters

`jagged` T\[\]\[\]

The jagged array.

#### Returns

 T\[,\]

The rectangular array.

#### Type Parameters

`T` 

### <a id="osu_Framework_Extensions_ExtensionMethods_ToResolutionString_System_Drawing_Size_"></a> ToResolutionString\(Size\)

```csharp
public static string ToResolutionString(this Size size)
```

#### Parameters

`size` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Extensions_ExtensionMethods_ToStandardisedPath_System_String_"></a> ToStandardisedPath\(string\)

Standardise the path string using '/' as directory separator.
Useful as output.

```csharp
public static string ToStandardisedPath(this string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path string to standardise.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The standardised path string.

### <a id="osu_Framework_Extensions_ExtensionMethods_TrimDirectorySeparator_System_String_"></a> TrimDirectorySeparator\(string\)

Trim DirectorySeparatorChar from the end of the path.

```csharp
public static string TrimDirectorySeparator(this string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path string to trim.

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The path with DirectorySeparatorChar trimmed.

#### Remarks

Trims both <xref href="System.IO.Path.DirectorySeparatorChar" data-throw-if-not-resolved="false"></xref> and <xref href="System.IO.Path.AltDirectorySeparatorChar" data-throw-if-not-resolved="false"></xref>.

