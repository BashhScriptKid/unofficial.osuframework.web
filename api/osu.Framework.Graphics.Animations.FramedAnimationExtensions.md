# <a id="osu_Framework_Graphics_Animations_FramedAnimationExtensions"></a> Class FramedAnimationExtensions

Namespace: [osu.Framework.Graphics.Animations](osu.Framework.Graphics.Animations.md)  
Assembly: osu.Framework.dll  

This class holds various extension methods for the <xref href="osu.Framework.Graphics.Animations.IFramedAnimation" data-throw-if-not-resolved="false"></xref> interface.

```csharp
public static class FramedAnimationExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FramedAnimationExtensions](osu.Framework.Graphics.Animations.FramedAnimationExtensions.md)

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

### <a id="osu_Framework_Graphics_Animations_FramedAnimationExtensions_GotoAndPlay_osu_Framework_Graphics_Animations_IFramedAnimation_System_Int32_"></a> GotoAndPlay\(IFramedAnimation, int\)

Displays the frame with the given zero-based frame index and plays the animation from that frame.

```csharp
public static void GotoAndPlay(this IFramedAnimation animation, int frameIndex)
```

#### Parameters

`animation` [IFramedAnimation](osu.Framework.Graphics.Animations.IFramedAnimation.md)

The animation that should seek the frame and start playing.

`frameIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index of the frame to display.

### <a id="osu_Framework_Graphics_Animations_FramedAnimationExtensions_GotoAndStop_osu_Framework_Graphics_Animations_IFramedAnimation_System_Int32_"></a> GotoAndStop\(IFramedAnimation, int\)

Displays the frame with the given zero-based frame index and stops the animation at that frame.

```csharp
public static void GotoAndStop(this IFramedAnimation animation, int frameIndex)
```

#### Parameters

`animation` [IFramedAnimation](osu.Framework.Graphics.Animations.IFramedAnimation.md)

The animation that should seek the frame and stop playing.

`frameIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index of the frame to display.

### <a id="osu_Framework_Graphics_Animations_FramedAnimationExtensions_Play_osu_Framework_Graphics_Animations_IFramedAnimation_"></a> Play\(IFramedAnimation\)

Resumes playing the animation.

```csharp
public static void Play(this IFramedAnimation animation)
```

#### Parameters

`animation` [IFramedAnimation](osu.Framework.Graphics.Animations.IFramedAnimation.md)

The animation to play.

### <a id="osu_Framework_Graphics_Animations_FramedAnimationExtensions_Restart_osu_Framework_Graphics_Animations_IFramedAnimation_"></a> Restart\(IFramedAnimation\)

Restarts the animation.

```csharp
public static void Restart(this IFramedAnimation animation)
```

#### Parameters

`animation` [IFramedAnimation](osu.Framework.Graphics.Animations.IFramedAnimation.md)

The animation to restart.

### <a id="osu_Framework_Graphics_Animations_FramedAnimationExtensions_Stop_osu_Framework_Graphics_Animations_IFramedAnimation_"></a> Stop\(IFramedAnimation\)

Stops playing the animation.

```csharp
public static void Stop(this IFramedAnimation animation)
```

#### Parameters

`animation` [IFramedAnimation](osu.Framework.Graphics.Animations.IFramedAnimation.md)

The animation to stop playing.

