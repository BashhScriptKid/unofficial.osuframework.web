# <a id="osu_Framework_Graphics_Animations_IAnimation"></a> Interface IAnimation

Namespace: [osu.Framework.Graphics.Animations](osu.Framework.Graphics.Animations.md)  
Assembly: osu.Framework.dll  

An animation / playback sequence.

```csharp
public interface IAnimation
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IAnimation\>\(IAnimation?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IAnimation\>\(IAnimation\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IAnimation\>\(IAnimation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IAnimation\>\(IAnimation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IAnimation, TChild\>\(IAnimation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IAnimation, TChild\>\(IAnimation, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IAnimation, TChild\>\(IAnimation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IAnimation\>\(IAnimation\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Animations_IAnimation_Duration"></a> Duration

The duration of the animation.

```csharp
double Duration { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Animations_IAnimation_FinishedPlaying"></a> FinishedPlaying

True if the animation has finished playing, false otherwise.

```csharp
bool FinishedPlaying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Animations_IAnimation_IsPlaying"></a> IsPlaying

True if the animation is playing, false otherwise. <code>true</code> by default.

```csharp
bool IsPlaying { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Animations_IAnimation_Loop"></a> Loop

True if the animation should start over from the first frame after finishing. False if it should stop playing and keep displaying the last frame when finishing.

```csharp
bool Loop { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Animations_IAnimation_PlaybackPosition"></a> PlaybackPosition

The current position of playback.

```csharp
double PlaybackPosition { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="osu_Framework_Graphics_Animations_IAnimation_Seek_System_Double_"></a> Seek\(double\)

Seek the animation to a specific time value.

```csharp
void Seek(double time)
```

#### Parameters

`time` [double](https://learn.microsoft.com/dotnet/api/system.double)

The time value to seek to.

