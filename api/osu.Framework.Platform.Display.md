# <a id="osu_Framework_Platform_Display"></a> Class Display

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Represents a physical display device on the current system.

```csharp
public sealed class Display : IEquatable<Display>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Display](osu.Framework.Platform.Display.md)

#### Implements

[IEquatable<Display\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<Display\>\(Display?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Display\>\(Display\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Display\>\(Display\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Display\>\(Display\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<Display, TChild\>\(Display, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Display, TChild\>\(Display, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Display, TChild\>\(Display, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Display\>\(Display\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Platform_Display__ctor_System_Int32_System_String_System_Drawing_Rectangle_osu_Framework_Platform_DisplayMode___"></a> Display\(int, string?, Rectangle, DisplayMode\[\]\)

```csharp
public Display(int index, string? name, Rectangle bounds, DisplayMode[] displayModes)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`bounds` [Rectangle](https://learn.microsoft.com/dotnet/api/system.drawing.rectangle)

`displayModes` [DisplayMode](osu.Framework.Platform.DisplayMode.md)\[\]

## Properties

### <a id="osu_Framework_Platform_Display_Bounds"></a> Bounds

The current rectangle of the display in screen space.
Non-zero X and Y values represent a non-primary monitor, and indicate its position
relative to the primary monitor.

```csharp
public Rectangle Bounds { get; }
```

#### Property Value

 [Rectangle](https://learn.microsoft.com/dotnet/api/system.drawing.rectangle)

### <a id="osu_Framework_Platform_Display_DisplayModes"></a> DisplayModes

The available <xref href="osu.Framework.Platform.DisplayMode" data-throw-if-not-resolved="false"></xref>s on this display, or empty if the display mode cannot be configured (e.g. mobile displays).

```csharp
public DisplayMode[] DisplayModes { get; }
```

#### Property Value

 [DisplayMode](osu.Framework.Platform.DisplayMode.md)\[\]

### <a id="osu_Framework_Platform_Display_Index"></a> Index

The zero-based index of the <xref href="osu.Framework.Platform.Display" data-throw-if-not-resolved="false"></xref>.

```csharp
public int Index { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Platform_Display_Name"></a> Name

The name of the display, if available. Usually the manufacturer.

```csharp
public string? Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="osu_Framework_Platform_Display_Equals_osu_Framework_Platform_Display_"></a> Equals\(Display?\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(Display? other)
```

#### Parameters

`other` [Display](osu.Framework.Platform.Display.md)?

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Platform_Display_FindDisplayMode_System_Drawing_Size_System_Nullable_System_Int32__System_Nullable_System_Int32__"></a> FindDisplayMode\(Size, int?, int?\)

Attempts to find a <xref href="osu.Framework.Platform.DisplayMode" data-throw-if-not-resolved="false"></xref> for the given <xref href="osu.Framework.Platform.Display" data-throw-if-not-resolved="false"></xref> that
closely matches the requested parameters.

```csharp
public DisplayMode FindDisplayMode(Size size, int? bitsPerPixel = null, int? refreshRate = null)
```

#### Parameters

`size` [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

The <xref href="System.Drawing.Size" data-throw-if-not-resolved="false"></xref> to match.

`bitsPerPixel` [int](https://learn.microsoft.com/dotnet/api/system.int32)?

The bits per pixel to match. If null, the highest available bits per pixel will be used.

`refreshRate` [int](https://learn.microsoft.com/dotnet/api/system.int32)?

The refresh rate in hertz. If null, the highest available refresh rate will be used.

#### Returns

 [DisplayMode](osu.Framework.Platform.DisplayMode.md)

### <a id="osu_Framework_Platform_Display_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

