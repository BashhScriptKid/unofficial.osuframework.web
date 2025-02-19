# <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions"></a> Class AdjustableAudioComponentExtensions

Namespace: [osu.Framework.Audio](osu.Framework.Audio.md)  
Assembly: osu.Framework.dll  

```csharp
public static class AdjustableAudioComponentExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AdjustableAudioComponentExtensions](osu.Framework.Audio.AdjustableAudioComponentExtensions.md)

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

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_BalanceTo__1___0_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> BalanceTo<T\>\(T, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Balance" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BalanceTo<T>(this T component, double newBalance, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`component` T

`newBalance` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_BalanceTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> BalanceTo<T\>\(TransformSequence<T\>, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Balance" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BalanceTo<T>(this TransformSequence<T> sequence, double newBalance, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newBalance` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_BalanceTo__2___0_System_Double_System_Double___1_"></a> BalanceTo<T, TEasing\>\(T, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Balance" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BalanceTo<T, TEasing>(this T component, double newBalance, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`component` T

`newBalance` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_BalanceTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double___1_"></a> BalanceTo<T, TEasing\>\(TransformSequence<T\>, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Balance" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> BalanceTo<T, TEasing>(this TransformSequence<T> sequence, double newBalance, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newBalance` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_FrequencyTo__1___0_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> FrequencyTo<T\>\(T, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Frequency" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FrequencyTo<T>(this T component, double newFrequency, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`component` T

`newFrequency` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_FrequencyTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> FrequencyTo<T\>\(TransformSequence<T\>, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Frequency" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FrequencyTo<T>(this TransformSequence<T> sequence, double newFrequency, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newFrequency` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_FrequencyTo__2___0_System_Double_System_Double___1_"></a> FrequencyTo<T, TEasing\>\(T, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Frequency" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FrequencyTo<T, TEasing>(this T component, double newFrequency, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`component` T

`newFrequency` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_FrequencyTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double___1_"></a> FrequencyTo<T, TEasing\>\(TransformSequence<T\>, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Frequency" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> FrequencyTo<T, TEasing>(this TransformSequence<T> sequence, double newFrequency, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newFrequency` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_TempoTo__1___0_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> TempoTo<T\>\(T, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Tempo" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TempoTo<T>(this T component, double newTempo, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`component` T

`newTempo` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_TempoTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> TempoTo<T\>\(TransformSequence<T\>, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Tempo" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TempoTo<T>(this TransformSequence<T> sequence, double newTempo, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newTempo` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_TempoTo__2___0_System_Double_System_Double___1_"></a> TempoTo<T, TEasing\>\(T, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Tempo" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TempoTo<T, TEasing>(this T component, double newTempo, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`component` T

`newTempo` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_TempoTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double___1_"></a> TempoTo<T, TEasing\>\(TransformSequence<T\>, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Tempo" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> TempoTo<T, TEasing>(this TransformSequence<T> sequence, double newTempo, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newTempo` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_VolumeTo__1___0_System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> VolumeTo<T\>\(T, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Graphics.Audio.DrawableAudioWrapper.Volume" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> VolumeTo<T>(this T component, double newVolume, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`component` T

`newVolume` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_VolumeTo__1_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double_osu_Framework_Graphics_Easing_"></a> VolumeTo<T\>\(TransformSequence<T\>, double, double, Easing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Volume" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> VolumeTo<T>(this TransformSequence<T> sequence, double newVolume, double duration = 0, Easing easing = Easing.None) where T : class, IAdjustableAudioComponent, IDrawable
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newVolume` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` [Easing](osu.Framework.Graphics.Easing.md)

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_VolumeTo__2___0_System_Double_System_Double___1_"></a> VolumeTo<T, TEasing\>\(T, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Volume" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> VolumeTo<T, TEasing>(this T component, double newVolume, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`component` T

`newVolume` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

### <a id="osu_Framework_Audio_AdjustableAudioComponentExtensions_VolumeTo__2_osu_Framework_Graphics_Transforms_TransformSequence___0__System_Double_System_Double___1_"></a> VolumeTo<T, TEasing\>\(TransformSequence<T\>, double, double, TEasing\)

Smoothly adjusts <xref href="osu.Framework.Audio.IAdjustableAudioComponent.Volume" data-throw-if-not-resolved="false"></xref> over time.

```csharp
public static TransformSequence<T> VolumeTo<T, TEasing>(this TransformSequence<T> sequence, double newVolume, double duration, TEasing easing) where T : class, IAdjustableAudioComponent, IDrawable where TEasing : IEasingFunction
```

#### Parameters

`sequence` [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

`newVolume` [double](https://learn.microsoft.com/dotnet/api/system.double)

`duration` [double](https://learn.microsoft.com/dotnet/api/system.double)

`easing` TEasing

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

A <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> to which further transforms can be added.

#### Type Parameters

`T` 

`TEasing` 

