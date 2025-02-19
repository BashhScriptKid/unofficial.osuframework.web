# <a id="osu_Framework_Graphics_IBufferedDrawable"></a> Interface IBufferedDrawable

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Interface for <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s which can be drawn by a <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IBufferedDrawable : ITexturedShaderDrawable, IDrawable, ITransformable
```

#### Implements

[ITexturedShaderDrawable](osu.Framework.Graphics.ITexturedShaderDrawable.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IBufferedDrawable\>\(IBufferedDrawable, params TransformSequence<IBufferedDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IBufferedDrawable\>\(IBufferedDrawable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IBufferedDrawable\>\(IBufferedDrawable, double, params TransformSequence<IBufferedDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IBufferedDrawable\>\(IBufferedDrawable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IBufferedDrawable\>\(IBufferedDrawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IBufferedDrawable\>\(IBufferedDrawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IBufferedDrawable\>\(IBufferedDrawable, double, int, params TransformSequence<IBufferedDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IBufferedDrawable\>\(IBufferedDrawable, double, params TransformSequence<IBufferedDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IBufferedDrawable\>\(IBufferedDrawable, params TransformSequence<IBufferedDrawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IBufferedDrawable\>\(IBufferedDrawable, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IBufferedDrawable, TValue\>\(IBufferedDrawable, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IBufferedDrawable, TEasing, TValue\>\(IBufferedDrawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IBufferedDrawable\>\(IBufferedDrawable, Transform<TValue, DefaultEasingFunction, IBufferedDrawable\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IBufferedDrawable\>\(IBufferedDrawable, Transform<TValue, TEasing, IBufferedDrawable\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IBufferedDrawable, TValue\>\(IBufferedDrawable, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IBufferedDrawable, TValue, TEasing\>\(IBufferedDrawable, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IBufferedDrawable, TValue\>\(IBufferedDrawable, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IBufferedDrawable, TValue, TEasing\>\(IBufferedDrawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IBufferedDrawable\>\(IBufferedDrawable, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IBufferedDrawable, TChild\>\(IBufferedDrawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IBufferedDrawable, TChild\>\(IBufferedDrawable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IBufferedDrawable, TChild\>\(IBufferedDrawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IBufferedDrawable\>\(IBufferedDrawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_IBufferedDrawable_BackgroundColour"></a> BackgroundColour

The background colour of the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s.
Visually changes the colour which rendered alpha is blended against.

```csharp
Color4 BackgroundColour { get; }
```

#### Property Value

 Color4

#### Remarks

This should generally be transparent-black or transparent-white, but can also be used to
colourise the background colour of the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref> with non-transparent colours.

### <a id="osu_Framework_Graphics_IBufferedDrawable_FrameBufferDrawColour"></a> FrameBufferDrawColour

The colour with which the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s are rendered to the screen.
A null value implies the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s should be drawn as they are.

```csharp
DrawColourInfo? FrameBufferDrawColour { get; }
```

#### Property Value

 [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)?

### <a id="osu_Framework_Graphics_IBufferedDrawable_FrameBufferScale"></a> FrameBufferScale

The scale of the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s drawn relative to the size of this <xref href="osu.Framework.Graphics.IBufferedDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
Vector2 FrameBufferScale { get; }
```

#### Property Value

 Vector2

#### Remarks

The contents of the <xref href="osu.Framework.Graphics.Rendering.IFrameBuffer" data-throw-if-not-resolved="false"></xref>s are populated at this scale, however the scale of <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s remains unaffected.

