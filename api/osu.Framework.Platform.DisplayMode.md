# <a id="osu_Framework_Platform_DisplayMode"></a> Struct DisplayMode

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Represents a display mode on a given <xref href="osu.Framework.Platform.Display" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly struct DisplayMode : IEquatable<DisplayMode>
```

#### Implements

[IEquatable<DisplayMode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DisplayMode\>\(DisplayMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DisplayMode\>\(DisplayMode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DisplayMode\>\(DisplayMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DisplayMode\>\(DisplayMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DisplayMode, TChild\>\(DisplayMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DisplayMode, TChild\>\(DisplayMode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DisplayMode, TChild\>\(DisplayMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DisplayMode\>\(DisplayMode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_DisplayMode__ctor_System_String_System_Drawing_Size_System_Int32_System_Single_System_Int32_"></a> DisplayMode\(string?, Size, int, float, int\)

```csharp
public DisplayMode(string? format, Size size, int bitsPerPixel, float refreshRate, int displayIndex)
```

#### Parameters

`format` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`size` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

`bitsPerPixel` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`refreshRate` [float](https://learn.microsoft.com/dotnet/api/system.single)

`displayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="osu_Framework_Platform_DisplayMode_BitsPerPixel"></a> BitsPerPixel

The number of bits that represent the colour value for each pixel.

```csharp
public readonly int BitsPerPixel
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Platform_DisplayMode_DisplayIndex"></a> DisplayIndex

The index of the display this mode belongs to as determined by the windowing backend.

```csharp
public readonly int DisplayIndex
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Platform_DisplayMode_Format"></a> Format

The pixel format of the display mode, if available.

```csharp
public readonly string Format
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_DisplayMode_RefreshRate"></a> RefreshRate

The refresh rate in hertz.

```csharp
public readonly float RefreshRate
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Platform_DisplayMode_Size"></a> Size

The dimensions of the screen resolution in pixels.

```csharp
public readonly Size Size
```

#### Field Value

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

## Methods

### <a id="osu_Framework_Platform_DisplayMode_Equals_osu_Framework_Platform_DisplayMode_"></a> Equals\(DisplayMode\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(DisplayMode other)
```

#### Parameters

`other` [DisplayMode](osu.Framework.Platform.DisplayMode.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Platform_DisplayMode_Equals_System_Object_"></a> Equals\(object?\)

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

### <a id="osu_Framework_Platform_DisplayMode_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Platform_DisplayMode_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

## Operators

### <a id="osu_Framework_Platform_DisplayMode_op_Equality_osu_Framework_Platform_DisplayMode_osu_Framework_Platform_DisplayMode_"></a> operator ==\(DisplayMode, DisplayMode\)

```csharp
public static bool operator ==(DisplayMode left, DisplayMode right)
```

#### Parameters

`left` [DisplayMode](osu.Framework.Platform.DisplayMode.md)

`right` [DisplayMode](osu.Framework.Platform.DisplayMode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Platform_DisplayMode_op_Inequality_osu_Framework_Platform_DisplayMode_osu_Framework_Platform_DisplayMode_"></a> operator \!=\(DisplayMode, DisplayMode\)

```csharp
public static bool operator !=(DisplayMode left, DisplayMode right)
```

#### Parameters

`left` [DisplayMode](osu.Framework.Platform.DisplayMode.md)

`right` [DisplayMode](osu.Framework.Platform.DisplayMode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

