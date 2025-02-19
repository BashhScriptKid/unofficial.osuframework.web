# <a id="osu_Framework_Graphics_MarginPadding"></a> Struct MarginPadding

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Holds data about the margin or padding of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
The margin describes the size of an empty area around its <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, while the padding describes the size of an empty area inside its container.

```csharp
public struct MarginPadding : IInterpolable<MarginPadding>, IEquatable<MarginPadding>
```

#### Implements

[IInterpolable<MarginPadding\>](osu.Framework.Utils.IInterpolable\-1.md), 
[IEquatable<MarginPadding\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MarginPadding\>\(MarginPadding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MarginPadding\>\(MarginPadding\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MarginPadding\>\(MarginPadding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MarginPadding\>\(MarginPadding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MarginPadding, TChild\>\(MarginPadding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MarginPadding, TChild\>\(MarginPadding, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MarginPadding, TChild\>\(MarginPadding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MarginPadding\>\(MarginPadding\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_MarginPadding__ctor_System_Single_"></a> MarginPadding\(float\)

Initializes all four sides (<xref href="osu.Framework.Graphics.MarginPadding.Left" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.MarginPadding.Right" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.MarginPadding.Top" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.MarginPadding.Bottom" data-throw-if-not-resolved="false"></xref>) to the given value.

```csharp
public MarginPadding(float allSides)
```

#### Parameters

`allSides` [float](https://learn.microsoft.com/dotnet/api/system.single)

The absolute size of the space that should be left around every side of the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

## Fields

### <a id="osu_Framework_Graphics_MarginPadding_Bottom"></a> Bottom

The absolute size of the space that should be left empty below the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> if used as margin, or
the absolute size of the space that should be left empty from the bottom of the container if used as padding.

```csharp
public float Bottom
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_MarginPadding_Left"></a> Left

The absolute size of the space that should be left empty to the left of the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> if used as margin, or
the absolute size of the space that should be left empty from the left of the container if used as padding.

```csharp
public float Left
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_MarginPadding_Right"></a> Right

The absolute size of the space that should be left empty to the right of the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> if used as margin, or
the absolute size of the space that should be left empty from the right of the container if used as padding.

```csharp
public float Right
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_MarginPadding_Top"></a> Top

The absolute size of the space that should be left empty above the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> if used as margin, or
the absolute size of the space that should be left empty from the top of the container if used as padding.

```csharp
public float Top
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="osu_Framework_Graphics_MarginPadding_Horizontal"></a> Horizontal

Sets the values of both <xref href="osu.Framework.Graphics.MarginPadding.Left" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.MarginPadding.Right" data-throw-if-not-resolved="false"></xref> to the assigned value.

```csharp
public float Horizontal { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_MarginPadding_Total"></a> Total

Gets the total absolute size of the empty space horizontally (x coordinate) and vertically (y coordinate) around the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> or inside the container if used as padding.

```csharp
public readonly Vector2 Total { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_MarginPadding_TotalHorizontal"></a> TotalHorizontal

Gets the total absolute size of the empty space horizontally around the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> if used as margin, or
the absolute size of the space left empty from the right and left of the container if used as padding.
Effectively <xref href="osu.Framework.Graphics.MarginPadding.Right" data-throw-if-not-resolved="false"></xref> + <xref href="osu.Framework.Graphics.MarginPadding.Left" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly float TotalHorizontal { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_MarginPadding_TotalVertical"></a> TotalVertical

Gets the total absolute size of the empty space vertically around the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> or
the absolute size of the space left empty from the top and bottom of the container if used as padding.
Effectively <xref href="osu.Framework.Graphics.MarginPadding.Top" data-throw-if-not-resolved="false"></xref> + <xref href="osu.Framework.Graphics.MarginPadding.Bottom" data-throw-if-not-resolved="false"></xref>.

```csharp
public readonly float TotalVertical { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_MarginPadding_Vertical"></a> Vertical

Sets the values of both <xref href="osu.Framework.Graphics.MarginPadding.Top" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.MarginPadding.Bottom" data-throw-if-not-resolved="false"></xref> to the assigned value.

```csharp
public float Vertical { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_MarginPadding_Equals_osu_Framework_Graphics_MarginPadding_"></a> Equals\(MarginPadding\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(MarginPadding other)
```

#### Parameters

`other` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_MarginPadding_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

### <a id="osu_Framework_Graphics_MarginPadding_ValueAt__1_System_Double_osu_Framework_Graphics_MarginPadding_osu_Framework_Graphics_MarginPadding_System_Double_System_Double___0__"></a> ValueAt<TEasing\>\(double, MarginPadding, MarginPadding, double, double, in TEasing\)

Interpolates between two <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref>s.

```csharp
public MarginPadding ValueAt<TEasing>(double time, MarginPadding startValue, MarginPadding endValue, double startTime, double endTime, in TEasing easing) where TEasing : IEasingFunction
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The current time.

`startValue` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref> at <code class="paramref">time</code> = <code class="paramref">startTime</code>.

`endValue` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The <xref href="osu.Framework.Graphics.MarginPadding" data-throw-if-not-resolved="false"></xref> at <code class="paramref">time</code> = <code class="paramref">endTime</code>.

`startTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The start time.

`endTime` [double](https://learn.microsoft.com/dotnet/api/system.double)

The end time.

`easing` TEasing

The easing function to use.

#### Returns

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

The interpolated value.

#### Type Parameters

`TEasing` 

#### Remarks

This method MUST NOT modify the current object.

## Operators

### <a id="osu_Framework_Graphics_MarginPadding_op_Multiply_osu_Framework_Graphics_MarginPadding_osuTK_Vector2_"></a> operator \*\(MarginPadding, Vector2\)

```csharp
public static MarginPadding operator *(MarginPadding mp, Vector2 v)
```

#### Parameters

`mp` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

`v` Vector2

#### Returns

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

### <a id="osu_Framework_Graphics_MarginPadding_op_UnaryNegation_osu_Framework_Graphics_MarginPadding_"></a> operator \-\(MarginPadding\)

```csharp
public static MarginPadding operator -(MarginPadding mp)
```

#### Parameters

`mp` [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

#### Returns

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

