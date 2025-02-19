# <a id="osu_Framework_Graphics_TransformableExtensions"></a> Class TransformableExtensions

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public static class TransformableExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TransformableExtensions](osu.Framework.Graphics.TransformableExtensions.md)

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

### <a id="osu_Framework_Graphics_TransformableExtensions_Animate__1___0_osu_Framework_Graphics_Transforms_TransformSequence___0__Generator___"></a> Animate<T\>\(T, params Generator\[\]\)

Applies <code class="paramref">childGenerators</code> via TransformSequence.Append(IEnumerable{Generator})/&gt;.

```csharp
public static TransformSequence<T> Animate<T>(this T transformable, params TransformSequence<T>.Generator[] childGenerators) where T : class, ITransformable
```

#### Parameters

`transformable` T

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The optional Generators for <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_BlurTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> BlurTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IBufferedContainer.BlurSigma" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BlurTo<T>(this T bufferedContainer, Vector2 newBlurSigma, double duration = 0, Easing easing = Easing.None) where T : class, IBufferedContainer
```

#### Parameters

`bufferedContainer` T

`newBlurSigma` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_BlurTo__2___0_osuTK_Vector2_System_Double___1__"></a> BlurTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IBufferedContainer.BlurSigma" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BlurTo<T, TEasing>(this T bufferedContainer, Vector2 newBlurSigma, double duration, in TEasing easing) where T : class, IBufferedContainer where TEasing : IEasingFunction
```

#### Parameters

`bufferedContainer` T

`newBlurSigma` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_Delay__1___0_System_Double_osu_Framework_Graphics_Transforms_TransformSequence___0__Generator___"></a> Delay<T\>\(T, double, params Generator\[\]\)

Advances the start time of future appended <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s by <code class="paramref">delay</code> milliseconds.
Then, <code class="paramref">childGenerators</code> are appended via TransformSequence.Append(IEnumerable{Generator})/&gt;.

```csharp
public static TransformSequence<T> Delay<T>(this T transformable, double delay, params TransformSequence<T>.Generator[] childGenerators) where T : class, ITransformable
```

#### Parameters

`transformable` T

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`delay` [double](https://learn.microsoft.com/dotnet/api/system.double)

The delay to advance the start time by.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The optional Generators for <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be appended.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_DelayUntilTransformsFinished__1___0_"></a> DelayUntilTransformsFinished<T\>\(T\)

Returns a <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> which waits for all existing transforms to finish.

```csharp
public static TransformSequence<T> DelayUntilTransformsFinished<T>(this T transformable) where T : Transformable
```

#### Parameters

`transformable` T

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> which has a delay waiting for all transforms to be completed.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeColour__1___0_osu_Framework_Graphics_Colour_ColourInfo_System_Double_osu_Framework_Graphics_Easing_"></a> FadeColour<T\>\(T, ColourInfo, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeColour<T>(this T drawable, ColourInfo newColour, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeColour__2___0_osu_Framework_Graphics_Colour_ColourInfo_System_Double___1__"></a> FadeColour<T, TEasing\>\(T, ColourInfo, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeColour<T, TEasing>(this T drawable, ColourInfo newColour, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeEdgeEffectTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> FadeEdgeEffectTo<T\>\(T, float, double, Easing\)

Smoothly adjusts the alpha channel of the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T>(this T container, float newAlpha, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`container` T

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeEdgeEffectTo__1___0_osuTK_Graphics_Color4_System_Double_osu_Framework_Graphics_Easing_"></a> FadeEdgeEffectTo<T\>\(T, Color4, double, Easing\)

Smoothly adjusts the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T>(this T container, Color4 newColour, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`container` T

`newColour` Color4

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeEdgeEffectTo__2___0_System_Single_System_Double___1__"></a> FadeEdgeEffectTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts the alpha channel of the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T, TEasing>(this T container, float newAlpha, double duration, in TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`container` T

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeEdgeEffectTo__2___0_osuTK_Graphics_Color4_System_Double___1__"></a> FadeEdgeEffectTo<T, TEasing\>\(T, Color4, double, in TEasing\)

Smoothly adjusts the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T, TEasing>(this T container, Color4 newColour, double duration, in TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`container` T

`newColour` Color4

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeIn__1___0_System_Double_osu_Framework_Graphics_Easing_"></a> FadeIn<T\>\(T, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 1 over time.

```csharp
public static TransformSequence<T> FadeIn<T>(this T drawable, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeIn__2___0_System_Double___1__"></a> FadeIn<T, TEasing\>\(T, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 1 over time.

```csharp
public static TransformSequence<T> FadeIn<T, TEasing>(this T drawable, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeInFromZero__1___0_System_Double_osu_Framework_Graphics_Easing_"></a> FadeInFromZero<T\>\(T, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 0 to 1 over time.

```csharp
public static TransformSequence<T> FadeInFromZero<T>(this T drawable, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeInFromZero__2___0_System_Double___1__"></a> FadeInFromZero<T, TEasing\>\(T, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 0 to 1 over time.

```csharp
public static TransformSequence<T> FadeInFromZero<T, TEasing>(this T drawable, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeOut__1___0_System_Double_osu_Framework_Graphics_Easing_"></a> FadeOut<T\>\(T, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 0 over time.

```csharp
public static TransformSequence<T> FadeOut<T>(this T drawable, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeOut__2___0_System_Double___1__"></a> FadeOut<T, TEasing\>\(T, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 0 over time.

```csharp
public static TransformSequence<T> FadeOut<T, TEasing>(this T drawable, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeOutFromOne__1___0_System_Double_osu_Framework_Graphics_Easing_"></a> FadeOutFromOne<T\>\(T, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 1 to 0 over time.

```csharp
public static TransformSequence<T> FadeOutFromOne<T>(this T drawable, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeOutFromOne__2___0_System_Double___1__"></a> FadeOutFromOne<T, TEasing\>\(T, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 1 to 0 over time.

```csharp
public static TransformSequence<T> FadeOutFromOne<T, TEasing>(this T drawable, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> FadeTo<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeTo<T>(this T drawable, float newAlpha, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FadeTo__2___0_System_Single_System_Double___1__"></a> FadeTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeTo<T, TEasing>(this T drawable, float newAlpha, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FlashColour__1___0_osu_Framework_Graphics_Colour_ColourInfo_System_Double_osu_Framework_Graphics_Easing_"></a> FlashColour<T\>\(T, ColourInfo, double, Easing\)

Instantaneously flashes <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref>, then smoothly changes it back over time.

```csharp
public static TransformSequence<T> FlashColour<T>(this T drawable, ColourInfo flashColour, double duration, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`flashColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_FlashColour__2___0_osu_Framework_Graphics_Colour_ColourInfo_System_Double___1__"></a> FlashColour<T, TEasing\>\(T, ColourInfo, double, in TEasing\)

Instantaneously flashes <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref>, then smoothly changes it back over time.

```csharp
public static TransformSequence<T> FlashColour<T, TEasing>(this T drawable, ColourInfo flashColour, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`flashColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_Loop__1___0_System_Double_System_Int32_osu_Framework_Graphics_Transforms_TransformSequence___0__Generator___"></a> Loop<T\>\(T, double, int, params Generator\[\]\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
All <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s generated by <code class="paramref">childGenerators</code> are appended to
this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> and then repeated <code class="paramref">numIters</code> times
with <code class="paramref">pause</code> milliseconds between iterations.

```csharp
public static TransformSequence<T> Loop<T>(this T transformable, double pause, int numIters, params TransformSequence<T>.Generator[] childGenerators) where T : class, ITransformable
```

#### Parameters

`transformable` T

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

`numIters` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of iterations.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The functions to generate the <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be looped.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_Loop__1___0_System_Double_osu_Framework_Graphics_Transforms_TransformSequence___0__Generator___"></a> Loop<T\>\(T, double, params Generator\[\]\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
All <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s generated by <code class="paramref">childGenerators</code> are appended to
this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> and then repeated indefinitely with <code class="paramref">pause</code>
milliseconds between iterations.

```csharp
public static TransformSequence<T> Loop<T>(this T transformable, double pause, params TransformSequence<T>.Generator[] childGenerators) where T : class, ITransformable
```

#### Parameters

`transformable` T

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The functions to generate the <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be looped.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_Loop__1___0_osu_Framework_Graphics_Transforms_TransformSequence___0__Generator___"></a> Loop<T\>\(T, params Generator\[\]\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.
All <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s generated by <code class="paramref">childGenerators</code> are appended to
this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> and then repeated indefinitely.
milliseconds between iterations.

```csharp
public static TransformSequence<T> Loop<T>(this T transformable, params TransformSequence<T>.Generator[] childGenerators) where T : class, ITransformable
```

#### Parameters

`transformable` T

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`childGenerators` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>.[Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)\[\]

The functions to generate the <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>s to be looped.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_Loop__1___0_System_Double_"></a> Loop<T\>\(T, double\)

Append a looping <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to this <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to repeat indefinitely with <code class="paramref">pause</code>
milliseconds between iterations.

```csharp
public static TransformSequence<T> Loop<T>(this T transformable, double pause = 0) where T : class, ITransformable
```

#### Parameters

`transformable` T

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`pause` [double](https://learn.microsoft.com/dotnet/api/system.double)

The pause between iterations in milliseconds.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

This <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`T` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_MakeTransform__2___0_System_String___1_System_Double_osu_Framework_Graphics_Easing_System_String_"></a> MakeTransform<TThis, TValue\>\(TThis, string, TValue, double, Easing, string\)

Creates a <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> for smoothly changing <code class="paramref">propertyOrFieldName</code>
over time using the given <code class="paramref">easing</code> for tweening.
<xref href="osu.Framework.Graphics.TransformableExtensions.PopulateTransform%60%603(%60%602%2cosu.Framework.Graphics.Transforms.Transform%7b%60%600%2c%60%601%2c%60%602%7d%2c%60%600%2cSystem.Double%2c%60%601%40)" data-throw-if-not-resolved="false"></xref> is invoked as part of this method.

```csharp
public static Transform<TValue, DefaultEasingFunction, TThis> MakeTransform<TThis, TValue>(this TThis t, string propertyOrFieldName, TValue newValue, double duration = 0, Easing easing = Easing.None, string grouping = null) where TThis : class, ITransformable
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`propertyOrFieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The property or field name of the member ot <code class="typeparamref">TThis</code> to transform.

`newValue` TValue

The value to transform to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The transform duration.

`easing` [Easing](osu.Framework.Graphics.Easing.md)

The transform easing to be used for tweening.

`grouping` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional grouping specification to be used when the same property may be touched by multiple transform types.

#### Returns

 [Transform](osu.Framework.Graphics.Transforms.Transform\-3.md)<TValue, [DefaultEasingFunction](osu.Framework.Graphics.Transforms.DefaultEasingFunction.md), TThis\>

The resulting <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

`TValue` 

The value type which is being transformed.

### <a id="osu_Framework_Graphics_TransformableExtensions_MakeTransform__3___0_System_String___2_System_Double___1__System_String_"></a> MakeTransform<TThis, TEasing, TValue\>\(TThis, string, TValue, double, in TEasing, string\)

Creates a <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> for smoothly changing <code class="paramref">propertyOrFieldName</code>
over time using the given <code class="paramref">easing</code> for tweening.
<xref href="osu.Framework.Graphics.TransformableExtensions.PopulateTransform%60%603(%60%602%2cosu.Framework.Graphics.Transforms.Transform%7b%60%600%2c%60%601%2c%60%602%7d%2c%60%600%2cSystem.Double%2c%60%601%40)" data-throw-if-not-resolved="false"></xref> is invoked as part of this method.

```csharp
public static Transform<TValue, TEasing, TThis> MakeTransform<TThis, TEasing, TValue>(this TThis t, string propertyOrFieldName, TValue newValue, double duration, in TEasing easing, string grouping = null) where TThis : class, ITransformable where TEasing : IEasingFunction
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`propertyOrFieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The property or field name of the member ot <code class="typeparamref">TThis</code> to transform.

`newValue` TValue

The value to transform to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The transform duration.

`easing` TEasing

The transform easing to be used for tweening.

`grouping` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional grouping specification to be used when the same property may be touched by multiple transform types.

#### Returns

 [Transform](osu.Framework.Graphics.Transforms.Transform\-3.md)<TValue, TEasing, TThis\>

The resulting <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref>.

#### Type Parameters

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

`TEasing` 

The type of easing.

`TValue` 

The value type which is being transformed.

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> MoveTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T>(this T drawable, Vector2 newPosition, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newPosition` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveTo__1___0_osu_Framework_Graphics_Direction_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> MoveTo<T\>\(T, Direction, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T>(this T drawable, Direction direction, float destination, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`direction` [Direction](osu.Framework.Graphics.Direction.md)

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveTo__2___0_osuTK_Vector2_System_Double___1__"></a> MoveTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T, TEasing>(this T drawable, Vector2 newPosition, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newPosition` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveTo__2___0_osu_Framework_Graphics_Direction_System_Single_System_Double___1__"></a> MoveTo<T, TEasing\>\(T, Direction, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T, TEasing>(this T drawable, Direction direction, float destination, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`direction` [Direction](osu.Framework.Graphics.Direction.md)

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveToOffset__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> MoveToOffset<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> by an offset to its final value over time.

```csharp
public static TransformSequence<T> MoveToOffset<T>(this T drawable, Vector2 offset, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`offset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveToOffset__2___0_osuTK_Vector2_System_Double___1__"></a> MoveToOffset<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> by an offset to its final value over time.

```csharp
public static TransformSequence<T> MoveToOffset<T, TEasing>(this T drawable, Vector2 offset, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`offset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveToX__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> MoveToX<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToX<T>(this T drawable, float destination, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveToX__2___0_System_Single_System_Double___1__"></a> MoveToX<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToX<T, TEasing>(this T drawable, float destination, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveToY__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> MoveToY<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToY<T>(this T drawable, float destination, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_MoveToY__2___0_System_Single_System_Double___1__"></a> MoveToY<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToY<T, TEasing>(this T drawable, float destination, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_PopulateTransform__2___1_osu_Framework_Graphics_Transforms_Transform___0_osu_Framework_Graphics_Transforms_DefaultEasingFunction___1____0_System_Double_osu_Framework_Graphics_Easing_"></a> PopulateTransform<TValue, TThis\>\(TThis, Transform<TValue, DefaultEasingFunction, TThis\>, TValue, double, Easing\)

Populates a newly created <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> with necessary values.
All <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref>s must be populated by this method prior to being used.

```csharp
public static Transform<TValue, DefaultEasingFunction, TThis> PopulateTransform<TValue, TThis>(this TThis t, Transform<TValue, DefaultEasingFunction, TThis> transform, TValue newValue, double duration = 0, Easing easing = Easing.None) where TThis : class, ITransformable
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`transform` [Transform](osu.Framework.Graphics.Transforms.Transform\-3.md)<TValue, [DefaultEasingFunction](osu.Framework.Graphics.Transforms.DefaultEasingFunction.md), TThis\>

The transform to populate.

`newValue` TValue

The value to transform to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The transform duration.

`easing` [Easing](osu.Framework.Graphics.Easing.md)

The transform easing to be used for tweening.

#### Returns

 [Transform](osu.Framework.Graphics.Transforms.Transform\-3.md)<TValue, [DefaultEasingFunction](osu.Framework.Graphics.Transforms.DefaultEasingFunction.md), TThis\>

The populated <code class="paramref">transform</code>.

#### Type Parameters

`TValue` 

The value type which is being transformed.

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_PopulateTransform__3___2_osu_Framework_Graphics_Transforms_Transform___0___1___2____0_System_Double___1__"></a> PopulateTransform<TValue, TEasing, TThis\>\(TThis, Transform<TValue, TEasing, TThis\>, TValue, double, in TEasing\)

Populates a newly created <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> with necessary values.
All <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref>s must be populated by this method prior to being used.

```csharp
public static Transform<TValue, TEasing, TThis> PopulateTransform<TValue, TEasing, TThis>(this TThis t, Transform<TValue, TEasing, TThis> transform, TValue newValue, double duration, in TEasing easing) where TEasing : IEasingFunction where TThis : class, ITransformable
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> will be applied to.

`transform` [Transform](osu.Framework.Graphics.Transforms.Transform\-3.md)<TValue, TEasing, TThis\>

The transform to populate.

`newValue` TValue

The value to transform to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The transform duration.

`easing` TEasing

The transform easing to be used for tweening.

#### Returns

 [Transform](osu.Framework.Graphics.Transforms.Transform\-3.md)<TValue, TEasing, TThis\>

The populated <code class="paramref">transform</code>.

#### Type Parameters

`TValue` 

The value type which is being transformed.

`TEasing` 

The type of easing.

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> can be applied to.

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeHeightTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeHeightTo<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Height" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeHeightTo<T>(this T drawable, float newHeight, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newHeight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeHeightTo__2___0_System_Single_System_Double___1__"></a> ResizeHeightTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Height" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeHeightTo<T, TEasing>(this T drawable, float newHeight, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newHeight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeTo<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T>(this T drawable, float newSize, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T>(this T drawable, Vector2 newSize, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeTo__2___0_System_Single_System_Double___1__"></a> ResizeTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T, TEasing>(this T drawable, float newSize, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeTo__2___0_osuTK_Vector2_System_Double___1__"></a> ResizeTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T, TEasing>(this T drawable, Vector2 newSize, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeWidthTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeWidthTo<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Width" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeWidthTo<T>(this T drawable, float newWidth, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ResizeWidthTo__2___0_System_Single_System_Double___1__"></a> ResizeWidthTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Width" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeWidthTo<T, TEasing>(this T drawable, float newWidth, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_RotateTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> RotateTo<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Rotation" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> RotateTo<T>(this T drawable, float newRotation, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_RotateTo__2___0_System_Single_System_Double___1__"></a> RotateTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Rotation" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> RotateTo<T, TEasing>(this T drawable, float newRotation, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ScaleTo__1___0_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ScaleTo<T\>\(T, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T>(this T drawable, float newScale, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newScale` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ScaleTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> ScaleTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T>(this T drawable, Vector2 newScale, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`drawable` T

`newScale` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ScaleTo__2___0_System_Single_System_Double___1__"></a> ScaleTo<T, TEasing\>\(T, float, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T, TEasing>(this T drawable, float newScale, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newScale` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_ScaleTo__2___0_osuTK_Vector2_System_Double___1__"></a> ScaleTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T, TEasing>(this T drawable, Vector2 newScale, double duration, in TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`newScale` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_Spin__1___0_System_Double_osu_Framework_Graphics_RotationDirection_System_Single_"></a> Spin<T\>\(T, double, RotationDirection, float\)

Rotate over one full rotation with provided parameters.

```csharp
public static TransformSequence<T> Spin<T>(this T drawable, double revolutionDuration, RotationDirection direction, float startRotation = 0) where T : Drawable
```

#### Parameters

`drawable` T

`revolutionDuration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`direction` [RotationDirection](osu.Framework.Graphics.RotationDirection.md)

`startRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_Spin__1___0_System_Double_osu_Framework_Graphics_RotationDirection_System_Single_System_Int32_"></a> Spin<T\>\(T, double, RotationDirection, float, int\)

Rotate <code class="paramref">numRevolutions</code> times with provided parameters.

```csharp
public static TransformSequence<T> Spin<T>(this T drawable, double revolutionDuration, RotationDirection direction, float startRotation, int numRevolutions) where T : Drawable
```

#### Parameters

`drawable` T

`revolutionDuration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`direction` [RotationDirection](osu.Framework.Graphics.RotationDirection.md)

`startRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`numRevolutions` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformBindableTo__2___0_osu_Framework_Bindables_Bindable___1____1_System_Double_osu_Framework_Graphics_Easing_"></a> TransformBindableTo<T, TValue\>\(T, Bindable<TValue\>, TValue, double, Easing\)

Smoothly adjusts the value of a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformBindableTo<T, TValue>(this T drawable, Bindable<TValue> bindable, TValue newValue, double duration = 0, Easing easing = Easing.None) where T : class, ITransformable
```

#### Parameters

`drawable` T

`bindable` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TValue\>

`newValue` TValue

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TValue` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformBindableTo__3___0_osu_Framework_Bindables_Bindable___1____1_System_Double___2__"></a> TransformBindableTo<T, TValue, TEasing\>\(T, Bindable<TValue\>, TValue, double, in TEasing\)

Smoothly adjusts the value of a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformBindableTo<T, TValue, TEasing>(this T drawable, Bindable<TValue> bindable, TValue newValue, double duration, in TEasing easing) where T : class, ITransformable where TEasing : IEasingFunction
```

#### Parameters

`drawable` T

`bindable` [Bindable](osu.Framework.Bindables.Bindable\-1.md)<TValue\>

`newValue` TValue

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TValue` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformRelativeChildOffsetTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformRelativeChildOffsetTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildOffset" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildOffsetTo<T>(this T container, Vector2 newOffset, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`container` T

`newOffset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformRelativeChildOffsetTo__2___0_osuTK_Vector2_System_Double___1__"></a> TransformRelativeChildOffsetTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildOffset" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildOffsetTo<T, TEasing>(this T container, Vector2 newOffset, double duration, in TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`container` T

`newOffset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformRelativeChildSizeTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformRelativeChildSizeTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildSize" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildSizeTo<T>(this T container, Vector2 newSize, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`container` T

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformRelativeChildSizeTo__2___0_osuTK_Vector2_System_Double___1__"></a> TransformRelativeChildSizeTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildSize" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildSizeTo<T, TEasing>(this T container, Vector2 newSize, double duration, in TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`container` T

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformSpacingTo__1___0_osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformSpacingTo<T\>\(T, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IFillFlowContainer.Spacing" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformSpacingTo<T>(this T flowContainer, Vector2 newSpacing, double duration = 0, Easing easing = Easing.None) where T : class, IFillFlowContainer
```

#### Parameters

`flowContainer` T

`newSpacing` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformSpacingTo__2___0_osuTK_Vector2_System_Double___1__"></a> TransformSpacingTo<T, TEasing\>\(T, Vector2, double, in TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IFillFlowContainer.Spacing" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformSpacingTo<T, TEasing>(this T flowContainer, Vector2 newSpacing, double duration, in TEasing easing) where T : class, IFillFlowContainer where TEasing : IEasingFunction
```

#### Parameters

`flowContainer` T

`newSpacing` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformTo__2___0_System_String___1_System_Double_osu_Framework_Graphics_Easing_"></a> TransformTo<TThis, TValue\>\(TThis, string, TValue, double, Easing\)

Transforms a given property or field member of a given <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref><code class="typeparamref">TThis</code> to <code class="paramref">newValue</code>.
The value of the given member is smoothly changed over time using the given <code class="paramref">easing</code> for tweening.

```csharp
public static TransformSequence<TThis> TransformTo<TThis, TValue>(this TThis t, string propertyOrFieldName, TValue newValue, double duration = 0, Easing easing = Easing.None) where TThis : class, ITransformable
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> to apply the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> to.

`propertyOrFieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The property or field name of the member ot <code class="typeparamref">TThis</code> to transform.

`newValue` TValue

The value to transform to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The transform duration.

`easing` [Easing](osu.Framework.Graphics.Easing.md)

The transform easing to be used for tweening.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<TThis\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> to apply the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> to.

`TValue` 

The value type which is being transformed.

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformTo__3___0_System_String___1_System_Double___2__System_String_"></a> TransformTo<TThis, TValue, TEasing\>\(TThis, string, TValue, double, in TEasing, string\)

Transforms a given property or field member of a given <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref><code class="typeparamref">TThis</code> to <code class="paramref">newValue</code>.
The value of the given member is smoothly changed over time using the given <code class="paramref">easing</code> for tweening.

```csharp
public static TransformSequence<TThis> TransformTo<TThis, TValue, TEasing>(this TThis t, string propertyOrFieldName, TValue newValue, double duration, in TEasing easing, string grouping = null) where TThis : class, ITransformable where TEasing : IEasingFunction
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> to apply the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> to.

`propertyOrFieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The property or field name of the member ot <code class="typeparamref">TThis</code> to transform.

`newValue` TValue

The value to transform to.

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

The transform duration.

`easing` TEasing

The transform easing to be used for tweening.

`grouping` [string](https://learn.microsoft.com/dotnet/api/system.string)

An optional grouping specification to be used when the same property may be touched by multiple transform types.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<TThis\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> to apply the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> to.

`TValue` 

The value type which is being transformed.

`TEasing` 

The type of easing.

### <a id="osu_Framework_Graphics_TransformableExtensions_TransformTo__1___0_osu_Framework_Graphics_Transforms_Transform_"></a> TransformTo<TThis\>\(TThis, Transform\)

Applies a <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> to a given <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref>.

```csharp
public static TransformSequence<TThis> TransformTo<TThis>(this TThis t, Transform transform) where TThis : class, ITransformable
```

#### Parameters

`t` TThis

The <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> to apply the <xref href="osu.Framework.Graphics.Transforms.Transform%602" data-throw-if-not-resolved="false"></xref> to.

`transform` [Transform](osu.Framework.Graphics.Transforms.Transform.md)

The transform to use.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<TThis\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`TThis` 

The type of the <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref> to apply the <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref> to.

### <a id="osu_Framework_Graphics_TransformableExtensions_TweenEdgeEffectTo__1___0_osu_Framework_Graphics_Effects_EdgeEffectParameters_System_Double_osu_Framework_Graphics_Easing_"></a> TweenEdgeEffectTo<T\>\(T, EdgeEffectParameters, double, Easing\)

Smoothly adjusts all parameters of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TweenEdgeEffectTo<T>(this T container, EdgeEffectParameters newParameters, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`container` T

`newParameters` [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformableExtensions_TweenEdgeEffectTo__2___0_osu_Framework_Graphics_Effects_EdgeEffectParameters_System_Double___1__"></a> TweenEdgeEffectTo<T, TEasing\>\(T, EdgeEffectParameters, double, in TEasing\)

Smoothly adjusts all parameters of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TweenEdgeEffectTo<T, TEasing>(this T container, EdgeEffectParameters newParameters, double duration, in TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`container` T

`newParameters` [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

