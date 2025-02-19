# <a id="osu_Framework_Graphics_Sprites_FontUsage"></a> Struct FontUsage

Namespace: [osu.Framework.Graphics.Sprites](osu.Framework.Graphics.Sprites.md)  
Assembly: osu.Framework.dll  

Represents a specific usage of a font.

```csharp
public readonly struct FontUsage : IEquatable<FontUsage>
```

#### Implements

[IEquatable<FontUsage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<FontUsage\>\(FontUsage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FontUsage\>\(FontUsage\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FontUsage\>\(FontUsage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FontUsage\>\(FontUsage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<FontUsage, TChild\>\(FontUsage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FontUsage, TChild\>\(FontUsage, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FontUsage, TChild\>\(FontUsage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FontUsage\>\(FontUsage\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Sprites_FontUsage__ctor_System_String_System_Single_System_String_System_Boolean_System_Boolean_"></a> FontUsage\(string, float, string, bool, bool\)

Creates an instance of <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref> using the specified font <code class="paramref">family</code>, font <code class="paramref">weight</code> and a value indicating whether the used font is italic or not.

```csharp
public FontUsage(string family = null, float size = 20, string weight = null, bool italics = false, bool fixedWidth = false)
```

#### Parameters

`family` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font family name.

`size` [float](https://learn.microsoft.com/dotnet/api/system.single)

The size of the text in local space. For a value of 16, a single line will have a height of 16px.

`weight` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font weight.

`italics` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the font is italic.

`fixedWidth` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether all characters should be spaced the same distance apart.

## Properties

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Default"></a> Default

Gets the default <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>, using the fallback font family.

```csharp
public static FontUsage Default { get; }
```

#### Property Value

 [FontUsage](osu.Framework.Graphics.Sprites.FontUsage.md)

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Family"></a> Family

The font family name.

```csharp
[CanBeNull]
public string Family { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Sprites_FontUsage_FixedWidth"></a> FixedWidth

Whether all characters should be spaced the same distance apart.

```csharp
public bool FixedWidth { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Sprites_FontUsage_FontName"></a> FontName

The font's full name to be used for lookups. This is an aggregate of all other properties of <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.
<remarks>
The format is of the form: <br />
{Family} <br />
{Family}-Italic <br />
{Family}-{Weight}Italic
</remarks>

```csharp
[NotNull]
public string FontName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Italics"></a> Italics

Whether the font is italic.

```csharp
public bool Italics { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Size"></a> Size

The size of the text in local space. For a value of 16, a single line will have a height of 16px.

```csharp
public float Size { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Weight"></a> Weight

The font weight.

```csharp
[CanBeNull]
public string Weight { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Equals_osu_Framework_Graphics_Sprites_FontUsage_"></a> Equals\(FontUsage\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(FontUsage other)
```

#### Parameters

`other` [FontUsage](osu.Framework.Graphics.Sprites.FontUsage.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Sprites_FontUsage_Equals_System_Object_"></a> Equals\(object\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Sprites_FontUsage_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Graphics_Sprites_FontUsage_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_Sprites_FontUsage_With_System_String_System_Nullable_System_Single__System_String_System_Nullable_System_Boolean__System_Nullable_System_Boolean__"></a> With\(string, float?, string, bool?, bool?\)

Creates a new <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref> by applying adjustments to this <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

```csharp
public FontUsage With(string family = null, float? size = null, string weight = null, bool? italics = null, bool? fixedWidth = null)
```

#### Parameters

`family` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font family. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

`size` [float](https://learn.microsoft.com/dotnet/api/system.single)?

The text size. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

`weight` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font weight. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

`italics` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)?

Whether the font is italic. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

`fixedWidth` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)?

Whether all characters should be spaced apart the same distance. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [FontUsage](osu.Framework.Graphics.Sprites.FontUsage.md)

The resulting <xref href="osu.Framework.Graphics.Sprites.FontUsage" data-throw-if-not-resolved="false"></xref>.

