# <a id="osu_Framework_Graphics_Primitives_RectangleF"></a> Struct RectangleF

Namespace: [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)  
Assembly: osu.Framework.dll  

Stores a set of four floating-point numbers that represent the location and size of a rectangle. The code was duplicated from <xref href="System.Drawing.RectangleF" data-throw-if-not-resolved="false"></xref>.

```csharp
[Serializable]
public struct RectangleF : IEquatable<RectangleF>
```

#### Implements

[IEquatable<RectangleF\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<RectangleF\>\(RectangleF\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<RectangleF\>\(RectangleF\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<RectangleF\>\(RectangleF\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<RectangleF\>\(RectangleF\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<RectangleF, TChild\>\(RectangleF, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<RectangleF, TChild\>\(RectangleF, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<RectangleF, TChild\>\(RectangleF, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<RectangleF\>\(RectangleF\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Primitives_RectangleF__ctor_System_Single_System_Single_System_Single_System_Single_"></a> RectangleF\(float, float, float, float\)

Initializes a new instance of the <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> class with the specified location and size.

```csharp
public RectangleF(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

The x-coordinate of the upper-left corner of the rectangle.

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

The y-coordinate of the upper-left corner of the rectangle.

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

The width of the rectangle.

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

The height of the rectangle.

### <a id="osu_Framework_Graphics_Primitives_RectangleF__ctor_osuTK_Vector2_osuTK_Vector2_"></a> RectangleF\(Vector2, Vector2\)

Initializes a new instance of the <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> class with the specified location and size.

```csharp
public RectangleF(Vector2 location, Vector2 size)
```

#### Parameters

`location` Vector2

A <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref> that represents the upper-left corner of the rectangular region.

`size` Vector2

A <xref href="osuTK.Vector2" data-throw-if-not-resolved="false"></xref> that represents the width and height of the rectangular region.

## Fields

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Height"></a> Height

```csharp
public float Height
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Width"></a> Width

```csharp
public float Width
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_X"></a> X

```csharp
public float X
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Y"></a> Y

```csharp
public float Y
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="osu_Framework_Graphics_Primitives_RectangleF_AABB"></a> AABB

```csharp
public RectangleI AABB { get; }
```

#### Property Value

 [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Area"></a> Area

Gets the Area of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

```csharp
public float Area { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Bottom"></a> Bottom

Gets the y-coordinate that is the sum of <xref href="osu.Framework.Graphics.Primitives.RectangleF.Y" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public float Bottom { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_BottomLeft"></a> BottomLeft

Gets the bottom left corner of the rectangle.

```csharp
[Browsable(false)]
public Vector2 BottomLeft { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_BottomRight"></a> BottomRight

Gets the bottom right corner of the rectangle.

```csharp
[Browsable(false)]
public Vector2 BottomRight { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Centre"></a> Centre

Gets the center of the rectangle.

```csharp
[Browsable(false)]
public Vector2 Centre { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Empty"></a> Empty

Represents an instance of the <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> class with its members uninitialized.

```csharp
public static RectangleF Empty { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_IsEmpty"></a> IsEmpty

Tests whether the <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> property of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> has a value of zero.

```csharp
[Browsable(false)]
public bool IsEmpty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Left"></a> Left

Gets the y-coordinate of the top edge of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public float Left { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Location"></a> Location

Gets or sets the coordinates of the upper-left corner of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public Vector2 Location { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Right"></a> Right

Gets the x-coordinate that is the sum of <xref href="osu.Framework.Graphics.Primitives.RectangleF.X" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public float Right { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Size"></a> Size

Gets or sets the size of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

```csharp
[Browsable(false)]
public Vector2 Size { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Top"></a> Top

Gets the y-coordinate of the top edge of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
[Browsable(false)]
public float Top { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_TopLeft"></a> TopLeft

Gets the top left corner of the rectangle.

```csharp
[Browsable(false)]
public Vector2 TopLeft { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_TopRight"></a> TopRight

Gets the top right corner of the rectangle.

```csharp
[Browsable(false)]
public Vector2 TopRight { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Primitives_RectangleF_WithPositiveExtent"></a> WithPositiveExtent

Gets this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with positive width and height.
This is useful if you have a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with negative <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref>.

```csharp
public RectangleF WithPositiveExtent { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

#### Examples

var rect = new <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> { <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> = -200, <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> = -300 }

rect.<xref href="osu.Framework.Graphics.Primitives.RectangleF.WithPositiveExtent" data-throw-if-not-resolved="false"></xref> will result in
Width = 200
Height = 300
X = -200
Y = -300

## Methods

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Contains_System_Single_System_Single_"></a> Contains\(float, float\)

Determines if the specified point is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

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

This method returns true if the point defined by x and y is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Contains_osuTK_Vector2_"></a> Contains\(Vector2\)

Determines if the specified point is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public bool Contains(Vector2 pt)
```

#### Parameters

`pt` Vector2

The point to test against this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if the point defined by x and y is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Contains_osu_Framework_Graphics_Primitives_Vector2I_"></a> Contains\(Vector2I\)

Determines if the specified point is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public bool Contains(Vector2I pt)
```

#### Parameters

`pt` [Vector2I](osu.Framework.Graphics.Primitives.Vector2I.md)

The <xref href="osu.Framework.Graphics.Primitives.Vector2I" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if the point represented by the pt parameter is contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Contains_osu_Framework_Graphics_Primitives_RectangleF_"></a> Contains\(RectangleF\)

Determines if the rectangular region represented by rect is entirely contained within this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public bool Contains(RectangleF rect)
```

#### Parameters

`rect` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if the rectangular region represented by rect is entirely contained within the rectangular region represented by this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Equals_System_Object_"></a> Equals\(object\)

Tests whether obj is a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with the same location and size of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The <xref href="System.Object" data-throw-if-not-resolved="false"></xref> to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if obj is a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> and its X, Y, Width, and Height properties are equal to the corresponding properties of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>; otherwise, false.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Equals_osu_Framework_Graphics_Primitives_RectangleF_"></a> Equals\(RectangleF\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(RectangleF other)
```

#### Parameters

`other` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_FromLTRB_System_Single_System_Single_System_Single_System_Single_"></a> FromLTRB\(float, float, float, float\)

Constructs a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> from left, top, right, and bottom coordinates.

```csharp
public static RectangleF FromLTRB(float left, float top, float right, float bottom)
```

#### Parameters

`left` [float](https://learn.microsoft.com/dotnet/api/system.single)

The left coordinate.

`top` [float](https://learn.microsoft.com/dotnet/api/system.single)

The top coordinate.

`right` [float](https://learn.microsoft.com/dotnet/api/system.single)

The right coordinate.

`bottom` [float](https://learn.microsoft.com/dotnet/api/system.single)

The bottom coordinate.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_GetHashCode"></a> GetHashCode\(\)

Gets the hash code for this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure. For information about the use of hash codes, see Object.GetHashCode.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The hash code for this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Inflate_System_Single_"></a> Inflate\(float\)

Gets a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> increased.
The center of that <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> will stay at that location.

```csharp
public RectangleF Inflate(float amount)
```

#### Parameters

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> will be increased in the returned <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

This method returns a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> inflated by the given <code class="paramref">amount</code>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Inflate_osuTK_Vector2_"></a> Inflate\(Vector2\)

Gets a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> increased.
The center of that <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> will stay at that location.

```csharp
public RectangleF Inflate(Vector2 amount)
```

#### Parameters

`amount` Vector2

The amount both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> will be increased in the returned <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

This method returns a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> inflated by the given <code class="paramref">amount</code>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Inflate_osu_Framework_Graphics_MarginPadding_"></a> Inflate\(MarginPadding\)

Gets a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> increased.
The center of that <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> will stay at that location.

```csharp
public RectangleF Inflate(MarginPadding amount)
```

#### Parameters

`amount` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The amount both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> will be increased in the returned <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

This method returns a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> with both <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> inflated by the given <code class="paramref">amount</code>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Intersect_osu_Framework_Graphics_Primitives_RectangleF_"></a> Intersect\(RectangleF\)

Replaces this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure with the intersection of itself and the specified <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public void Intersect(RectangleF rect)
```

#### Parameters

`rect` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The rectangle to intersect.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Intersect_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Primitives_RectangleF_"></a> Intersect\(RectangleF, RectangleF\)

Returns a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that represents the intersection of two rectangles. If there is no intersection, and empty <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> is returned.

```csharp
public static RectangleF Intersect(RectangleF a, RectangleF b)
```

#### Parameters

`a` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A rectangle to intersect.

`b` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A rectangle to intersect.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A third <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure the size of which represents the overlapped area of the two specified rectangles.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_IntersectsWith_osu_Framework_Graphics_Primitives_RectangleF_"></a> IntersectsWith\(RectangleF\)

Determines if this rectangle intersects with rect.

```csharp
public bool IntersectsWith(RectangleF rect)
```

#### Parameters

`rect` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The rectangle to test.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This method returns true if there is any intersection.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_IntersectsWith_osu_Framework_Graphics_Primitives_RectangleI_"></a> IntersectsWith\(RectangleI\)

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

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Normalize"></a> Normalize\(\)

Create a new <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> congruent to this rectangle but with non-negative <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref>.

```csharp
public RectangleF Normalize()
```

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Offset_osuTK_Vector2_"></a> Offset\(Vector2\)

Adjusts the location of this rectangle by the specified amount.

```csharp
public RectangleF Offset(Vector2 pos)
```

#### Parameters

`pos` Vector2

The amount to offset the location.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

This method does not return a value.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Offset_System_Single_System_Single_"></a> Offset\(float, float\)

Adjusts the location of this rectangle by the specified amount.

```csharp
public RectangleF Offset(float x, float y)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount to offset the location horizontally.

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount to offset the location vertically.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

This method does not return a value.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_RelativeIn_osu_Framework_Graphics_Primitives_RectangleF_"></a> RelativeIn\(RectangleF\)

Creates a new <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> in relative coordinate space to another <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

```csharp
public RectangleF RelativeIn(RectangleF other)
```

#### Parameters

`other` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The other <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The relative coordinate space representation of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> in <code class="paramref">other</code>.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Shrink_System_Single_"></a> Shrink\(float\)

```csharp
public RectangleF Shrink(float amount)
```

#### Parameters

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Shrink_osuTK_Vector2_"></a> Shrink\(Vector2\)

```csharp
public RectangleF Shrink(Vector2 amount)
```

#### Parameters

`amount` Vector2

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Shrink_osu_Framework_Graphics_MarginPadding_"></a> Shrink\(MarginPadding\)

```csharp
public RectangleF Shrink(MarginPadding amount)
```

#### Parameters

`amount` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_ToString"></a> ToString\(\)

Converts the Location and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Size" data-throw-if-not-resolved="false"></xref> of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> to a human-readable string.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that contains the position, width, and height of this <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure¾for example, "{X=20, Y=20, Width=100, Height=50}".

### <a id="osu_Framework_Graphics_Primitives_RectangleF_Union_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Primitives_RectangleF_"></a> Union\(RectangleF, RectangleF\)

Creates the smallest possible third rectangle that can contain both of two rectangles that form a union.

```csharp
public static RectangleF Union(RectangleF a, RectangleF b)
```

#### Parameters

`a` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The first rectangle to union.

`b` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The second rectangle to union.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A third <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that contains both of the two rectangles that form the union.

## Operators

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Division_osu_Framework_Graphics_Primitives_RectangleF_System_Single_"></a> operator /\(RectangleF, float\)

```csharp
public static RectangleF operator /(RectangleF rectangle, float scale)
```

#### Parameters

`rectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

`scale` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Division_osu_Framework_Graphics_Primitives_RectangleF_osuTK_Vector2_"></a> operator /\(RectangleF, Vector2\)

```csharp
public static RectangleF operator /(RectangleF rectangle, Vector2 scale)
```

#### Parameters

`rectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

`scale` Vector2

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Equality_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Primitives_RectangleF_"></a> operator ==\(RectangleF, RectangleF\)

Tests whether two <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structures have equal location and size.

```csharp
public static bool operator ==(RectangleF left, RectangleF right)
```

#### Parameters

`left` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that is to the left of the equality operator.

`right` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that is to the right of the equality operator.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This operator returns true if the two specified <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structures have equal <xref href="osu.Framework.Graphics.Primitives.RectangleF.X" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Primitives.RectangleF.Y" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref>, and <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> properties.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Implicit_osu_Framework_Graphics_Primitives_RectangleI__osu_Framework_Graphics_Primitives_RectangleF"></a> implicit operator RectangleF\(RectangleI\)

Converts the specified <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure to a <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure.

```csharp
public static implicit operator RectangleF(RectangleI r)
```

#### Parameters

`r` [RectangleI](osu.Framework.Graphics.Primitives.RectangleI.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure to convert.

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that is converted from the specified <xref href="osu.Framework.Graphics.Primitives.RectangleI" data-throw-if-not-resolved="false"></xref> structure.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Implicit_osu_Framework_Graphics_Primitives_RectangleF__System_Drawing_RectangleF"></a> implicit operator RectangleF\(RectangleF\)

```csharp
public static implicit operator RectangleF(RectangleF r)
```

#### Parameters

`r` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

#### Returns

 [RectangleF](https://learn.microsoft.com/dotnet/api/system.drawing.rectanglef)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Inequality_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_Primitives_RectangleF_"></a> operator \!=\(RectangleF, RectangleF\)

Tests whether two <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structures differ in location or size.

```csharp
public static bool operator !=(RectangleF left, RectangleF right)
```

#### Parameters

`left` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that is to the left of the inequality operator.

`right` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structure that is to the right of the inequality operator.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

This operator returns true if any of the <xref href="osu.Framework.Graphics.Primitives.RectangleF.X" data-throw-if-not-resolved="false"></xref> , <xref href="osu.Framework.Graphics.Primitives.RectangleF.Y" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Primitives.RectangleF.Width" data-throw-if-not-resolved="false"></xref>, or <xref href="osu.Framework.Graphics.Primitives.RectangleF.Height" data-throw-if-not-resolved="false"></xref> properties of the two <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> structures are unequal; otherwise false.

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Multiply_osu_Framework_Graphics_Primitives_RectangleF_System_Single_"></a> operator \*\(RectangleF, float\)

```csharp
public static RectangleF operator *(RectangleF rectangle, float scale)
```

#### Parameters

`rectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

`scale` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Primitives_RectangleF_op_Multiply_osu_Framework_Graphics_Primitives_RectangleF_osuTK_Vector2_"></a> operator \*\(RectangleF, Vector2\)

```csharp
public static RectangleF operator *(RectangleF rectangle, Vector2 scale)
```

#### Parameters

`rectangle` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

`scale` Vector2

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

