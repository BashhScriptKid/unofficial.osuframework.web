# <a id="osu_Framework_Graphics_Primitives_RectangleI"></a> Struct RectangleI

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

Stores a set of four integer numbers that represent the location and size of a rectangle. The code was duplicated from <xref href="System.Drawing.Rectangle" data-throw-if-not-resolved="false"></xref>.

```csharp
[Serializable]
public struct RectangleI : IEquatable<RectangleI>
```

#### Implements

[IEquatable<RectangleI\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RectangleI\>\(RectangleI\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RectangleI\>\(RectangleI\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RectangleI\>\(RectangleI\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RectangleI\>\(RectangleI\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[SDL3Extensions.ToSDLRect\(RectangleI\)](osu.Framework.Platform.SDL3.SDL3Extensions.md\#osu\_Framework\_Platform\_SDL3\_SDL3Extensions\_ToSDLRect\_osu\_Framework\_Graphics\_Primitives\_RectangleI\_), 
[SDL2Extensions.ToSDLRect\(RectangleI\)](osu.Framework.Platform.SDL2.SDL2Extensions.md\#osu\_Framework\_Platform\_SDL2\_SDL2Extensions\_ToSDLRect\_osu\_Framework\_Graphics\_Primitives\_RectangleI\_), 
[ContainerExtensions.WithChild<RectangleI, TChild\>\(RectangleI, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RectangleI, TChild\>\(RectangleI, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RectangleI, TChild\>\(RectangleI, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RectangleI\>\(RectangleI\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_RectangleI__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> RectangleI\(int, int, int, int\)

Initializes a new instance of the <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> class with the specified location and size.

```csharp
public RectangleI(int x, int y, int width, int height)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The x-coordinate of the upper-left corner of the rectangle.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The y-coordinate of the upper-left corner of the rectangle.

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The width of the rectangle.

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The height of the rectangle.

## Fields

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Height"></a> Height

```csharp
public int Height
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Width"></a> Width

```csharp
public int Width
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_X"></a> X

```csharp
public int X
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Y"></a> Y

```csharp
public int Y
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Area"></a> Area

```csharp
public int Area { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Bottom"></a> Bottom

Gets the y-coordinate that is the sum of <xref href="osu.Framework.Graphics.Primitives.RectangleI.Y" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleI.Height" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public int Bottom { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_BottomLeft"></a> BottomLeft

```csharp
[Browsable(false)]
public Vector2I BottomLeft { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_BottomRight"></a> BottomRight

```csharp
[Browsable(false)]
public Vector2I BottomRight { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Empty"></a> Empty

Represents an instance of the <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> class with its members uninitialized.

```csharp
public static RectangleI Empty { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_IsEmpty"></a> IsEmpty

Tests whether the <xref href="osu.Framework.Graphics.Primitives.RectangleI.Width" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Primitives.RectangleI.Height" data-throw-if-not-resolved="false"></xref> property of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> has a value of zero.

```csharp
[Browsable(false)]
public bool IsEmpty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Left"></a> Left

Gets the y-coordinate of the top edge of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public int Left { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Location"></a> Location

Gets or sets the coordinates of the upper-left corner of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public Vector2I Location { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Right"></a> Right

Gets the x-coordinate that is the sum of <xref href="osu.Framework.Graphics.Primitives.RectangleI.X" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleI.Width" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public int Right { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Size"></a> Size

Gets or sets the size of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref>.

```csharp
[Browsable(false)]
public Vector2I Size { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Top"></a> Top

Gets the y-coordinate of the top edge of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public int Top { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_TopLeft"></a> TopLeft

```csharp
[Browsable(false)]
public Vector2I TopLeft { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_TopRight"></a> TopRight

```csharp
[Browsable(false)]
public Vector2I TopRight { get; }
```

#### Property Value

 [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_WithPositiveExtent"></a> WithPositiveExtent

```csharp
public RectangleI WithPositiveExtent { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

## Methods

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Contains_System_Single_System_Single_"></a> Contains\(float, float\)

Determines if the specified point is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public bool Contains(float x, float y)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

The x-coordinate of the point to test.

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

The y-coordinate of the point to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if the point defined by x and y is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Contains_osuTK_Vector2_"></a> Contains\(Vector2\)

```csharp
public bool Contains(Vector2 pt)
```

#### Parameters

`pt` Vector2

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Contains_System_Int32_System_Int32_"></a> Contains\(int, int\)

```csharp
public bool Contains(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Contains_osu_Framework_Graphics_Primitives_Vector2I_"></a> Contains\(Vector2I\)

```csharp
public bool Contains(Vector2I pt)
```

#### Parameters

`pt` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Contains_osu_Framework_Graphics_Primitives_RectangleI_"></a> Contains\(RectangleI\)

Determines if the rectangular region represented by rect is entirely contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public bool Contains(RectangleI rect)
```

#### Parameters

`rect` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if the rectangular region represented by rect is entirely contained within the rectangular region represented by this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref>; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Equals_System_Object_"></a> Equals\(object\)

Tests whether obj is a <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> with the same location and size of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref>.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The <xref href="System.Object" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if obj is a <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> and its X, Y, Width, and Height properties are equal to the corresponding properties of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref>; otherwise, false.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Equals_osu_Framework_Graphics_Primitives_RectangleI_"></a> Equals\(RectangleI\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(RectangleI other)
```

#### Parameters

`other` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_GetHashCode"></a> GetHashCode\(\)

Gets the hash code for this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure. For information about the use of hash codes, see Object.GetHashCode.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The hash code for this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Inflate_System_Int32_"></a> Inflate\(int\)

```csharp
public RectangleI Inflate(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Inflate_osu_Framework_Graphics_Primitives_Vector2I_"></a> Inflate\(Vector2I\)

```csharp
public RectangleI Inflate(Vector2I amount)
```

#### Parameters

`amount` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Inflate_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Inflate\(int, int, int, int\)

```csharp
public RectangleI Inflate(int left, int right, int top, int bottom)
```

#### Parameters

`left` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`right` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`top` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`bottom` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Intersect_osu_Framework_Graphics_Primitives_RectangleI_"></a> Intersect\(RectangleI\)

Intersects this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure with the specified <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public RectangleI Intersect(RectangleI rect)
```

#### Parameters

`rect` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The rectangle to intersect.

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The intersected rectangle.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Intersect_osu_Framework_Graphics_Primitives_RectangleI_osu_Framework_Graphics_Primitives_RectangleI_"></a> Intersect\(RectangleI, RectangleI\)

Returns a <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure that represents the intersection of two rectangles. If there is no intersection, and empty <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> is returned.

```csharp
public static RectangleI Intersect(RectangleI a, RectangleI b)
```

#### Parameters

`a` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

A rectangle to intersect.

`b` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

A rectangle to intersect.

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

A third <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure the size of which represents the overlapped area of the two specified rectangles.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_IntersectsWith_osu_Framework_Graphics_Primitives_RectangleI_"></a> IntersectsWith\(RectangleI\)

Determines if this rectangle intersects with rect.

```csharp
public bool IntersectsWith(RectangleI rect)
```

#### Parameters

`rect` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The rectangle to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if there is any intersection.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Offset_System_Int32_System_Int32_"></a> Offset\(int, int\)

Adjusts the location of this rectangle by the specified amount.

```csharp
public RectangleI Offset(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The amount to offset the location horizontally.

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The amount to offset the location vertically.

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

This method does not return a value.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Shrink_System_Int32_"></a> Shrink\(int\)

```csharp
public RectangleI Shrink(int amount)
```

#### Parameters

`amount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Shrink_osu_Framework_Graphics_Primitives_Vector2I_"></a> Shrink\(Vector2I\)

```csharp
public RectangleI Shrink(Vector2I amount)
```

#### Parameters

`amount` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Shrink_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Shrink\(int, int, int, int\)

```csharp
public RectangleI Shrink(int left, int right, int top, int bottom)
```

#### Parameters

`left` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`right` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`top` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`bottom` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_ToString"></a> ToString\(\)

Converts the Location and <xref href="osu.Framework.Graphics.Primitives.RectangleI.Size" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> to a human-readable string.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that contains the position, width, and height of this <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure¾for example, "{X=20, Y=20, Width=100, Height=50}".

### <a id="osu_Framework_Graphics_Primitives_RectangleI_Union_osu_Framework_Graphics_Primitives_RectangleI_osu_Framework_Graphics_Primitives_RectangleI_"></a> Union\(RectangleI, RectangleI\)

Creates the smallest possible third rectangle that can contain both of two rectangles that form a union.

```csharp
public static RectangleI Union(RectangleI a, RectangleI b)
```

#### Parameters

`a` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

A rectangle to union.

`b` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

A rectangle to union.

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

A third <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure that contains both of the two rectangles that form the union.

## Operators

### <a id="osu_Framework_Graphics_Primitives_RectangleI_op_Equality_osu_Framework_Graphics_Primitives_RectangleI_osu_Framework_Graphics_Primitives_RectangleI_"></a> operator ==\(RectangleI, RectangleI\)

Tests whether two <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structures have equal location and size.

```csharp
public static bool operator ==(RectangleI left, RectangleI right)
```

#### Parameters

`left` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure that is to the left of the equality operator.

`right` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure that is to the right of the equality operator.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This operator returns true if the two specified <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structures have equal <xref href="osu.Framework.Graphics.Primitives.RectangleI.X" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Primitives.RectangleI.Y" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Primitives.RectangleI.Width" data-throw-if-not-resolved="false"></xref>, and <xref href="osu.Framework.Graphics.Primitives.RectangleI.Height" data-throw-if-not-resolved="false"></xref> properties.

### <a id="osu_Framework_Graphics_Primitives_RectangleI_op_Implicit_osu_Framework_Graphics_Primitives_RectangleF__osu_Framework_Graphics_Primitives_RectangleI"></a> implicit operator RectangleI\(RectangleF\)

```csharp
public static implicit operator RectangleI(RectangleF r)
```

#### Parameters

`r` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

#### Returns

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleI_op_Inequality_osu_Framework_Graphics_Primitives_RectangleI_osu_Framework_Graphics_Primitives_RectangleI_"></a> operator \!=\(RectangleI, RectangleI\)

Tests whether two <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structures differ in location or size.

```csharp
public static bool operator !=(RectangleI left, RectangleI right)
```

#### Parameters

`left` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure that is to the left of the inequality operator.

`right` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure that is to the right of the inequality operator.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This operator returns true if any of the <xref href="osu.Framework.Graphics.Primitives.RectangleI.X" data-throw-if-not-resolved="false"></xref> , <xref href="osu.Framework.Graphics.Primitives.RectangleI.Y" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Primitives.RectangleI.Width" data-throw-if-not-resolved="false"></xref>, or <xref href="osu.Framework.Graphics.Primitives.RectangleI.Height" data-throw-if-not-resolved="false"></xref> properties of the two <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structures are unequal; otherwise false.

