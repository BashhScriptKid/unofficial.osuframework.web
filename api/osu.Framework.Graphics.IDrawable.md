# <a id="osu_Framework_Graphics_IDrawable"></a> Interface IDrawable

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Exposes various properties that are part of the public interface of <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
This interface should generally NOT be implemented by other classes than <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, but only used to
specify that an object is of type <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
It is mostly useful in cases where you need to specify additional constraints on a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, but also do not want to force inheriting from
any particular subclass of <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IDrawable : ITransformable
```

#### Implements

[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IDrawable\>\(IDrawable, params TransformSequence<IDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IDrawable\>\(IDrawable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IDrawable\>\(IDrawable, double, params TransformSequence<IDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IDrawable\>\(IDrawable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IDrawable\>\(IDrawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IDrawable\>\(IDrawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IDrawable\>\(IDrawable, double, int, params TransformSequence<IDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IDrawable\>\(IDrawable, double, params TransformSequence<IDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IDrawable\>\(IDrawable, params TransformSequence<IDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IDrawable\>\(IDrawable, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IDrawable, TValue\>\(IDrawable, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IDrawable, TEasing, TValue\>\(IDrawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IDrawable\>\(IDrawable, Transform<TValue, DefaultEasingFunction, IDrawable\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IDrawable\>\(IDrawable, Transform<TValue, TEasing, IDrawable\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IDrawable, TValue\>\(IDrawable, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IDrawable, TValue, TEasing\>\(IDrawable, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IDrawable, TValue\>\(IDrawable, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IDrawable, TValue, TEasing\>\(IDrawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IDrawable\>\(IDrawable, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IDrawable, TChild\>\(IDrawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IDrawable, TChild\>\(IDrawable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IDrawable, TChild\>\(IDrawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IDrawable\>\(IDrawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_IDrawable_Alpha"></a> Alpha

Multiplicative alpha factor applied on top of <xref href="osu.Framework.Graphics.Colour.ColourInfo" data-throw-if-not-resolved="false"></xref> and its existing
alpha channel(s).

```csharp
float Alpha { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_IDrawable_Blending"></a> Blending

Determines how this Drawable is blended with other already drawn Drawables.

```csharp
BlendingParameters Blending { get; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_IDrawable_Clock"></a> Clock

The clock of this drawable. Used for keeping track of time across frames.

```csharp
IFrameBasedClock Clock { get; }
```

#### Property Value

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

### <a id="osu_Framework_Graphics_IDrawable_DrawColourInfo"></a> DrawColourInfo

Contains the colour and blending information of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that are used during draw.

```csharp
DrawColourInfo DrawColourInfo { get; }
```

#### Property Value

 [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)

### <a id="osu_Framework_Graphics_IDrawable_DrawInfo"></a> DrawInfo

Contains a linear transformation, colour information, and blending information
of this drawable.

```csharp
DrawInfo DrawInfo { get; }
```

#### Property Value

 [DrawInfo](osu.Framework.Graphics.DrawInfo.md)

### <a id="osu_Framework_Graphics_IDrawable_DrawRectangle"></a> DrawRectangle

Absolutely sized rectangle for drawing in the <xref href="osu.Framework.Graphics.IDrawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.
Based on <xref href="osu.Framework.Graphics.IDrawable.DrawSize" data-throw-if-not-resolved="false"></xref>.

```csharp
RectangleF DrawRectangle { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_IDrawable_DrawSize"></a> DrawSize

Absolute size of this Drawable in the <xref href="osu.Framework.Graphics.IDrawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.

```csharp
Vector2 DrawSize { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_IDrawable_InvalidationID"></a> InvalidationID

The current invalidation ID of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Incremented every time the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> should be re-validated.

```csharp
long InvalidationID { get; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Graphics_IDrawable_IsDragged"></a> IsDragged

Whether this Drawable is currently dragged.

```csharp
bool IsDragged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_IDrawable_IsHovered"></a> IsHovered

Whether this Drawable is currently hovered over.

```csharp
bool IsHovered { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_IDrawable_IsPresent"></a> IsPresent

Whether this drawable is present for any sort of user-interaction.
If this is false, then this drawable will not be drawn, it will not handle input,
and it will not affect layouting (e.g. autosizing and flow).

```csharp
bool IsPresent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_IDrawable_Parent"></a> Parent

The parent of this drawable in the scene graph.

```csharp
CompositeDrawable? Parent { get; }
```

#### Property Value

 [CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)?

### <a id="osu_Framework_Graphics_IDrawable_ScreenSpaceDrawQuad"></a> ScreenSpaceDrawQuad

The screen-space quad this drawable occupies.

```csharp
Quad ScreenSpaceDrawQuad { get; }
```

#### Property Value

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

## Methods

### <a id="osu_Framework_Graphics_IDrawable_Hide"></a> Hide\(\)

Hide sprite instantly.

```csharp
void Hide()
```

### <a id="osu_Framework_Graphics_IDrawable_Show"></a> Show\(\)

Show sprite instantly.

```csharp
void Show()
```

### <a id="osu_Framework_Graphics_IDrawable_ToLocalSpace_osuTK_Vector2_"></a> ToLocalSpace\(Vector2\)

Convert a position to the local coordinate system from either native or local to another drawable.
This is *not* the same space as the Position member variable (use Parent.GetLocalPosition() in this case).

```csharp
Vector2 ToLocalSpace(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

The input position.

#### Returns

 Vector2

The output position.

### <a id="osu_Framework_Graphics_IDrawable_ToSpaceOfOtherDrawable_osuTK_Vector2_osu_Framework_Graphics_IDrawable_"></a> ToSpaceOfOtherDrawable\(Vector2, IDrawable\)

Accepts a vector in local coordinates and converts it to coordinates in another Drawable's space.

```csharp
Vector2 ToSpaceOfOtherDrawable(Vector2 input, IDrawable other)
```

#### Parameters

`input` Vector2

A vector in local coordinates.

`other` [IDrawable](osu.Framework.Graphics.IDrawable.md)

The drawable in which space we want to transform the vector to.

#### Returns

 Vector2

The vector in other's coordinates.

