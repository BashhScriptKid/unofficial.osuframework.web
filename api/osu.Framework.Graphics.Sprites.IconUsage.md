# <a id="osu_Framework_Graphics_Sprites_IconUsage"></a> Struct IconUsage

Namespace: [osu.Framework.Graphics.Sprites](osu.Framework.Graphics.Sprites.md)  
Assembly: osu.Framework.dll  

Represents a specific usage of an icon.

```csharp
public readonly struct IconUsage : IEquatable<IconUsage>
```

#### Implements

[IEquatable<IconUsage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<IconUsage\>\(IconUsage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IconUsage\>\(IconUsage\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IconUsage\>\(IconUsage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IconUsage\>\(IconUsage\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IconUsage, TChild\>\(IconUsage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IconUsage, TChild\>\(IconUsage, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IconUsage, TChild\>\(IconUsage, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IconUsage\>\(IconUsage\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Sprites_IconUsage__ctor_System_Char_System_String_System_String_"></a> IconUsage\(char, string, string\)

Creates an instance of <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref> using the specified font <code class="paramref">family</code>, font <code class="paramref">weight</code> and a value indicating whether the used font is italic or not.

```csharp
public IconUsage(char icon, string family = null, string weight = null)
```

#### Parameters

`icon` [char](https://learn.microsoft.com/dotnet/api/system.char)

The icon.

`family` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font family name.

`weight` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font weight.

## Properties

### <a id="osu_Framework_Graphics_Sprites_IconUsage_Family"></a> Family

The font family name.

```csharp
[CanBeNull]
public string Family { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Sprites_IconUsage_FontName"></a> FontName

The font's full name to be used for lookups. This is an aggregate of all other properties of <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref>.
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

### <a id="osu_Framework_Graphics_Sprites_IconUsage_Icon"></a> Icon

The icon character.

```csharp
public char Icon { get; }
```

#### Property Value

 [char](https://learn.microsoft.com/dotnet/api/system.char)

### <a id="osu_Framework_Graphics_Sprites_IconUsage_Weight"></a> Weight

The font weight.

```csharp
[CanBeNull]
public string Weight { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="osu_Framework_Graphics_Sprites_IconUsage_Equals_osu_Framework_Graphics_Sprites_IconUsage_"></a> Equals\(IconUsage\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(IconUsage other)
```

#### Parameters

`other` [IconUsage](osu.Framework.Graphics.Sprites.IconUsage.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Sprites_IconUsage_Equals_System_Object_"></a> Equals\(object\)

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

### <a id="osu_Framework_Graphics_Sprites_IconUsage_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Graphics_Sprites_IconUsage_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_Sprites_IconUsage_With_System_String_System_String_"></a> With\(string, string\)

Creates a new <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref> by applying adjustments to this <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref>.

```csharp
public IconUsage With(string family = null, string weight = null)
```

#### Parameters

`family` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font family. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref>.

`weight` [string](https://learn.microsoft.com/dotnet/api/system.string)

The font weight. If null, the value is copied from this <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [IconUsage](osu.Framework.Graphics.Sprites.IconUsage.md)

The resulting <xref href="osu.Framework.Graphics.Sprites.IconUsage" data-throw-if-not-resolved="false"></xref>.

