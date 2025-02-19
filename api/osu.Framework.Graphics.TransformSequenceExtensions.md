# <a id="osu_Framework_Graphics_TransformSequenceExtensions"></a> Class TransformSequenceExtensions

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public static class TransformSequenceExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TransformSequenceExtensions](osu.Framework.Graphics.TransformSequenceExtensions.md)

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

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_BlurTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> BlurTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IBufferedContainer.BlurSigma" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BlurTo<T>(this TransformSequence<T> t, Vector2 newBlurSigma, double duration = 0, Easing easing = Easing.None) where T : class, IBufferedContainer
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newBlurSigma` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_BlurTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> BlurTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IBufferedContainer.BlurSigma" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BlurTo<T, TEasing>(this TransformSequence<T> t, Vector2 newBlurSigma, double duration, TEasing easing) where T : class, IBufferedContainer where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newBlurSigma` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Expire__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Boolean_"></a> Expire<T\>\(TransformSequence<T\>, bool\)

```csharp
public static TransformSequence<T> Expire<T>(this TransformSequence<T> t, bool calculateLifetimeStart = false) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`calculateLifetimeStart` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeColour__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Graphics_Colour_ColourInfo_System_Double_osu_Framework_Graphics_Easing_"></a> FadeColour<T\>\(TransformSequence<T\>, ColourInfo, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeColour<T>(this TransformSequence<T> t, ColourInfo newColour, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeColour__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Graphics_Colour_ColourInfo_System_Double___1_"></a> FadeColour<T, TEasing\>\(TransformSequence<T\>, ColourInfo, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeColour<T, TEasing>(this TransformSequence<T> t, ColourInfo newColour, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeEdgeEffectTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> FadeEdgeEffectTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts the alpha channel of the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T>(this TransformSequence<T> t, float newAlpha, double duration, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeEdgeEffectTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Graphics_Color4_System_Double_osu_Framework_Graphics_Easing_"></a> FadeEdgeEffectTo<T\>\(TransformSequence<T\>, Color4, double, Easing\)

Smoothly adjusts the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T>(this TransformSequence<T> t, Color4 newColour, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newColour` Color4

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeEdgeEffectTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> FadeEdgeEffectTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts the alpha channel of the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T, TEasing>(this TransformSequence<T> t, float newAlpha, double duration, TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeEdgeEffectTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Graphics_Color4_System_Double___1_"></a> FadeEdgeEffectTo<T, TEasing\>\(TransformSequence<T\>, Color4, double, TEasing\)

Smoothly adjusts the colour of <xref href="osu.Framework.Graphics.Containers.IContainer.EdgeEffect" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeEdgeEffectTo<T, TEasing>(this TransformSequence<T> t, Color4 newColour, double duration, TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newColour` Color4

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeIn__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_osu_Framework_Graphics_Easing_"></a> FadeIn<T\>\(TransformSequence<T\>, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 1 over time.

```csharp
public static TransformSequence<T> FadeIn<T>(this TransformSequence<T> t, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeIn__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double___1_"></a> FadeIn<T, TEasing\>\(TransformSequence<T\>, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 1 over time.

```csharp
public static TransformSequence<T> FadeIn<T, TEasing>(this TransformSequence<T> t, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeInFromZero__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_osu_Framework_Graphics_Easing_"></a> FadeInFromZero<T\>\(TransformSequence<T\>, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 0 to 1 over time.

```csharp
public static TransformSequence<T> FadeInFromZero<T>(this TransformSequence<T> t, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeInFromZero__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double___1_"></a> FadeInFromZero<T, TEasing\>\(TransformSequence<T\>, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 0 to 1 over time.

```csharp
public static TransformSequence<T> FadeInFromZero<T, TEasing>(this TransformSequence<T> t, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeOut__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_osu_Framework_Graphics_Easing_"></a> FadeOut<T\>\(TransformSequence<T\>, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 0 over time.

```csharp
public static TransformSequence<T> FadeOut<T>(this TransformSequence<T> t, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeOut__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double___1_"></a> FadeOut<T, TEasing\>\(TransformSequence<T\>, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> to 0 over time.

```csharp
public static TransformSequence<T> FadeOut<T, TEasing>(this TransformSequence<T> t, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeOutFromOne__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_osu_Framework_Graphics_Easing_"></a> FadeOutFromOne<T\>\(TransformSequence<T\>, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 1 to 0 over time.

```csharp
public static TransformSequence<T> FadeOutFromOne<T>(this TransformSequence<T> t, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeOutFromOne__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double___1_"></a> FadeOutFromOne<T, TEasing\>\(TransformSequence<T\>, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> from 1 to 0 over time.

```csharp
public static TransformSequence<T> FadeOutFromOne<T, TEasing>(this TransformSequence<T> t, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> FadeTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeTo<T>(this TransformSequence<T> t, float newAlpha, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FadeTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> FadeTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FadeTo<T, TEasing>(this TransformSequence<T> t, float newAlpha, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newAlpha` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FlashColour__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Graphics_Colour_ColourInfo_System_Double_osu_Framework_Graphics_Easing_"></a> FlashColour<T\>\(TransformSequence<T\>, ColourInfo, double, Easing\)

Instantaneously flashes <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref>, then smoothly changes it back over time.

```csharp
public static TransformSequence<T> FlashColour<T>(this TransformSequence<T> t, ColourInfo flashColour, double duration, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`flashColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_FlashColour__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Graphics_Colour_ColourInfo_System_Double___1_"></a> FlashColour<T, TEasing\>\(TransformSequence<T\>, ColourInfo, double, TEasing\)

Instantaneously flashes <xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref>, then smoothly changes it back over time.

```csharp
public static TransformSequence<T> FlashColour<T, TEasing>(this TransformSequence<T> t, ColourInfo flashColour, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`flashColour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> MoveTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T>(this TransformSequence<T> t, Vector2 newPosition, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newPosition` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Graphics_Direction_System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> MoveTo<T\>\(TransformSequence<T\>, Direction, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T>(this TransformSequence<T> t, Direction direction, float destination, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`direction` [Direction](osu.Framework.Graphics.Direction.md)

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> MoveTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T, TEasing>(this TransformSequence<T> t, Vector2 newPosition, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newPosition` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Graphics_Direction_System_Single_System_Double___1_"></a> MoveTo<T, TEasing\>\(TransformSequence<T\>, Direction, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveTo<T, TEasing>(this TransformSequence<T> t, Direction direction, float destination, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

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

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveToOffset__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> MoveToOffset<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> by an offset to its final value over time.

```csharp
public static TransformSequence<T> MoveToOffset<T>(this TransformSequence<T> t, Vector2 offset, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`offset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveToOffset__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> MoveToOffset<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> by an offset to its final value over time.

```csharp
public static TransformSequence<T> MoveToOffset<T, TEasing>(this TransformSequence<T> t, Vector2 offset, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`offset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveToX__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> MoveToX<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToX<T>(this TransformSequence<T> t, float destination, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveToX__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> MoveToX<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.X" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToX<T, TEasing>(this TransformSequence<T> t, float destination, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveToY__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> MoveToY<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToY<T>(this TransformSequence<T> t, float destination, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_MoveToY__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> MoveToY<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Y" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> MoveToY<T, TEasing>(this TransformSequence<T> t, float destination, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`destination` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeHeightTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeHeightTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Height" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeHeightTo<T>(this TransformSequence<T> t, float newHeight, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newHeight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeHeightTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> ResizeHeightTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Height" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeHeightTo<T, TEasing>(this TransformSequence<T> t, float newHeight, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newHeight` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T>(this TransformSequence<T> t, float newSize, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T>(this TransformSequence<T> t, Vector2 newSize, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> ResizeTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T, TEasing>(this TransformSequence<T> t, float newSize, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> ResizeTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeTo<T, TEasing>(this TransformSequence<T> t, Vector2 newSize, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeWidthTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ResizeWidthTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Width" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeWidthTo<T>(this TransformSequence<T> t, float newWidth, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ResizeWidthTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> ResizeWidthTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Width" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ResizeWidthTo<T, TEasing>(this TransformSequence<T> t, float newWidth, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newWidth` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_RotateTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> RotateTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Rotation" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> RotateTo<T>(this TransformSequence<T> t, float newRotation, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_RotateTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> RotateTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Rotation" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> RotateTo<T, TEasing>(this TransformSequence<T> t, float newRotation, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ScaleTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double_osu_Framework_Graphics_Easing_"></a> ScaleTo<T\>\(TransformSequence<T\>, float, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T>(this TransformSequence<T> t, float newScale, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newScale` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ScaleTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> ScaleTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T>(this TransformSequence<T> t, Vector2 newScale, double duration = 0, Easing easing = Easing.None) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newScale` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ScaleTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Single_System_Double___1_"></a> ScaleTo<T, TEasing\>\(TransformSequence<T\>, float, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T, TEasing>(this TransformSequence<T> t, float newScale, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newScale` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_ScaleTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> ScaleTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Drawable.Scale" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> ScaleTo<T, TEasing>(this TransformSequence<T> t, Vector2 newScale, double duration, TEasing easing) where T : Drawable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newScale` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Schedule__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Action___1____1_"></a> Schedule<T, TData\>\(TransformSequence<T\>, Action<TData\>, TData\)

```csharp
public static TransformSequence<T> Schedule<T, TData>(this TransformSequence<T> t, Action<TData> scheduledAction, TData data) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`scheduledAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TData\>

`data` TData

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

`TData` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Schedule__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Action_"></a> Schedule<T\>\(TransformSequence<T\>, Action\)

```csharp
public static TransformSequence<T> Schedule<T>(this TransformSequence<T> t, Action scheduledAction) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`scheduledAction` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Schedule__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Action___1____1_osu_Framework_Threading_ScheduledDelegate__"></a> Schedule<T, TData\>\(TransformSequence<T\>, Action<TData\>, TData, out ScheduledDelegate\)

```csharp
public static TransformSequence<T> Schedule<T, TData>(this TransformSequence<T> t, Action<TData> scheduledAction, TData data, out ScheduledDelegate scheduledDelegate) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`scheduledAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TData\>

`data` TData

`scheduledDelegate` [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

`TData` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Schedule__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Action_osu_Framework_Threading_ScheduledDelegate__"></a> Schedule<T\>\(TransformSequence<T\>, Action, out ScheduledDelegate\)

```csharp
public static TransformSequence<T> Schedule<T>(this TransformSequence<T> t, Action scheduledAction, out ScheduledDelegate scheduledDelegate) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`scheduledAction` [Action](https://learn.microsoft.com/dotnet/api/system.action)

`scheduledDelegate` [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Spin__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_osu_Framework_Graphics_RotationDirection_System_Single_"></a> Spin<T\>\(TransformSequence<T\>, double, RotationDirection, float\)

```csharp
public static TransformSequence<T> Spin<T>(this TransformSequence<T> t, double revolutionDuration, RotationDirection direction, float startRotation = 0) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`revolutionDuration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`direction` [RotationDirection](osu.Framework.Graphics.RotationDirection.md)

`startRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_Spin__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_osu_Framework_Graphics_RotationDirection_System_Single_System_Int32_"></a> Spin<T\>\(TransformSequence<T\>, double, RotationDirection, float, int\)

```csharp
public static TransformSequence<T> Spin<T>(this TransformSequence<T> t, double revolutionDuration, RotationDirection direction, float startRotation, int numRevolutions) where T : Drawable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`revolutionDuration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`direction` [RotationDirection](osu.Framework.Graphics.RotationDirection.md)

`startRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`numRevolutions` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformBindableTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Bindables_Bindable___1____1_System_Double_osu_Framework_Graphics_Easing_"></a> TransformBindableTo<T, TValue\>\(TransformSequence<T\>, Bindable<TValue\>, TValue, double, Easing\)

Smoothly adjusts the value of a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformBindableTo<T, TValue>(this TransformSequence<T> t, Bindable<TValue> bindable, TValue newValue, double duration = 0, Easing easing = Easing.None) where T : class, ITransformable
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

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

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformBindableTo__3_osu_Framework_Graphics_Transforms_TransformSequence___0__osu_Framework_Bindables_Bindable___1____1_System_Double___2_"></a> TransformBindableTo<T, TValue, TEasing\>\(TransformSequence<T\>, Bindable<TValue\>, TValue, double, TEasing\)

Smoothly adjusts the value of a <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformBindableTo<T, TValue, TEasing>(this TransformSequence<T> t, Bindable<TValue> bindable, TValue newValue, double duration, TEasing easing) where T : class, ITransformable where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

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

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformRelativeChildOffsetTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformRelativeChildOffsetTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildOffset" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildOffsetTo<T>(this TransformSequence<T> t, Vector2 newOffset, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newOffset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformRelativeChildOffsetTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> TransformRelativeChildOffsetTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildOffset" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildOffsetTo<T, TEasing>(this TransformSequence<T> t, Vector2 newOffset, double duration, TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newOffset` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformRelativeChildSizeTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformRelativeChildSizeTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildSize" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildSizeTo<T>(this TransformSequence<T> t, Vector2 newSize, double duration = 0, Easing easing = Easing.None) where T : class, IContainer
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformRelativeChildSizeTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> TransformRelativeChildSizeTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IContainer.RelativeChildSize" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformRelativeChildSizeTo<T, TEasing>(this TransformSequence<T> t, Vector2 newSize, double duration, TEasing easing) where T : class, IContainer where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSize` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformSpacingTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double_osu_Framework_Graphics_Easing_"></a> TransformSpacingTo<T\>\(TransformSequence<T\>, Vector2, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IFillFlowContainer.Spacing" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformSpacingTo<T>(this TransformSequence<T> t, Vector2 newSpacing, double duration = 0, Easing easing = Easing.None) where T : class, IFillFlowContainer
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSpacing` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_TransformSequenceExtensions_TransformSpacingTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__osuTK_Vector2_System_Double___1_"></a> TransformSpacingTo<T, TEasing\>\(TransformSequence<T\>, Vector2, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Containers.IFillFlowContainer.Spacing" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TransformSpacingTo<T, TEasing>(this TransformSequence<T> t, Vector2 newSpacing, double duration, TEasing easing) where T : class, IFillFlowContainer where TEasing : IEasingFunction
```

#### Parameters

`t` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newSpacing` Vector2

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

