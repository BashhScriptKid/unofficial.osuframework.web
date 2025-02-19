# <a id="osu_Framework_Graphics_Animations_IFramedAnimation"></a> Interface IFramedAnimation

Namespace: [osu.Framework.Graphics.Animations](osu.Framework.Graphics.Animations.md)  
Assembly: osu.Framework.dll  

An animation with well-defined frames.

```csharp
public interface IFramedAnimation : IAnimation
```

#### Implements

[IAnimation](osu.Framework.Graphics.Animations.IAnimation.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IFramedAnimation\>\(IFramedAnimation?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IFramedAnimation\>\(IFramedAnimation\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[FramedAnimationExtensions.GotoAndPlay\(IFramedAnimation, int\)](osu.Framework.Graphics.Animations.FramedAnimationExtensions.md\#osu\_Framework\_Graphics\_Animations\_FramedAnimationExtensions\_GotoAndPlay\_osu\_Framework\_Graphics\_Animations\_IFramedAnimation\_System\_Int32\_), 
[FramedAnimationExtensions.GotoAndStop\(IFramedAnimation, int\)](osu.Framework.Graphics.Animations.FramedAnimationExtensions.md\#osu\_Framework\_Graphics\_Animations\_FramedAnimationExtensions\_GotoAndStop\_osu\_Framework\_Graphics\_Animations\_IFramedAnimation\_System\_Int32\_), 
[ObjectExtensions.IsNotNull<IFramedAnimation\>\(IFramedAnimation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IFramedAnimation\>\(IFramedAnimation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[FramedAnimationExtensions.Play\(IFramedAnimation\)](osu.Framework.Graphics.Animations.FramedAnimationExtensions.md\#osu\_Framework\_Graphics\_Animations\_FramedAnimationExtensions\_Play\_osu\_Framework\_Graphics\_Animations\_IFramedAnimation\_), 
[FramedAnimationExtensions.Restart\(IFramedAnimation\)](osu.Framework.Graphics.Animations.FramedAnimationExtensions.md\#osu\_Framework\_Graphics\_Animations\_FramedAnimationExtensions\_Restart\_osu\_Framework\_Graphics\_Animations\_IFramedAnimation\_), 
[FramedAnimationExtensions.Stop\(IFramedAnimation\)](osu.Framework.Graphics.Animations.FramedAnimationExtensions.md\#osu\_Framework\_Graphics\_Animations\_FramedAnimationExtensions\_Stop\_osu\_Framework\_Graphics\_Animations\_IFramedAnimation\_), 
[ContainerExtensions.WithChild<IFramedAnimation, TChild\>\(IFramedAnimation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IFramedAnimation, TChild\>\(IFramedAnimation, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IFramedAnimation, TChild\>\(IFramedAnimation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IFramedAnimation\>\(IFramedAnimation\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Animations_IFramedAnimation_CurrentFrameIndex"></a> CurrentFrameIndex

The currently visible frame's index.

```csharp
int CurrentFrameIndex { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Animations_IFramedAnimation_FrameCount"></a> FrameCount

The number of frames this animation has.

```csharp
int FrameCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="osu_Framework_Graphics_Animations_IFramedAnimation_GotoFrame_System_Int32_"></a> GotoFrame\(int\)

Displays the frame with the given zero-based frame index.

```csharp
void GotoFrame(int frameIndex)
```

#### Parameters

`frameIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The zero-based index of the frame to display.

