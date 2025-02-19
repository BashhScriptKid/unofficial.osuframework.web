# <a id="osu_Framework_Utils_Validation"></a> Class Validation

Namespace: [osu.Framework.Utils](osu.Framework.Utils.md)  
Assembly: osu.Framework.dll  

```csharp
public static class Validation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Validation](osu.Framework.Utils.Validation.md)

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

### <a id="osu_Framework_Utils_Validation_IsFinite_osuTK_Vector2_"></a> IsFinite\(Vector2\)

Returns whether the two coordinates of a <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref> are not infinite or NaN.
<p>For further information, see <xref href="System.Single.IsFinite(System.Single)" data-throw-if-not-resolved="false"></xref>.</p>

```csharp
public static bool IsFinite(Vector2 toCheck)
```

#### Parameters

`toCheck` Vector2

The <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref> to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

False if X or Y are Infinity or NaN, true otherwise.

### <a id="osu_Framework_Utils_Validation_IsFinite_osu_Framework_Graphics_MarginPadding_"></a> IsFinite\(MarginPadding\)

Returns whether the components of a <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref> are not infinite or NaN.
<p>For further information, see <xref href="System.Single.IsFinite(System.Single)" data-throw-if-not-resolved="false"></xref>.</p>

```csharp
public static bool IsFinite(MarginPadding toCheck)
```

#### Parameters

`toCheck` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref> to check.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

False if either component of <code class="paramref">toCheck</code> are Infinity or NaN, true otherwise.

### <a id="osu_Framework_Utils_Validation_IsSupportedBindableNumberType__1"></a> IsSupportedBindableNumberType<T\>\(\)

Whether the specified type <code class="typeparamref">T</code> is a number type supported by <xref href="osu.Framework.Bindables.BindableNumber%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public static bool IsSupportedBindableNumberType<T>()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the type is supported; <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> otherwise.

#### Type Parameters

`T` 

The type to check for.

#### Remarks

Directly comparing typeof(T) to type literal is recognized pattern of JIT and very fast.
Just a pointer comparison for reference types, or constant for value types.
The check will become NOP in usages after optimization.

### <a id="osu_Framework_Utils_Validation_TryParseUri_System_String_System_Uri__"></a> TryParseUri\(string, out Uri?\)

Attempts to parse <code class="paramref">uriString</code> as an absolute or relative <xref href="System.Uri" data-throw-if-not-resolved="false"></xref> in a platform-agnostic manner.

```csharp
public static bool TryParseUri(string uriString, out Uri? result)
```

#### Parameters

`uriString` [string](https://learn.microsoft.com/dotnet/api/system.string)

The string representation of the URI to parse.

`result` [Uri](https://learn.microsoft.com/dotnet/api/system.uri)?

The resultant parsed URI, if parsing succeeded.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if parsing succeeded; <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> otherwise.

#### Remarks

This method is a workaround for inconsistencies across .NET and mono runtimes;
on mono runtimes paths starting with <code>/</code> are considered absolute as per POSIX,
and on .NET such paths are considered to be relative.
This method uses the .NET behaviour.
For more info, see <a href="https://www.mono-project.com/docs/faq/known-issues/urikind-relativeorabsolute/">Mono documentation</a>.

