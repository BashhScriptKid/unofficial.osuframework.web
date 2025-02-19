# <a id="osu_Framework_Graphics_Drawable"></a> Class Drawable

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Drawables are the basic building blocks of a scene graph in this framework.
Anything that is visible or that the user interacts with has to be a Drawable.

For example:
 - Boxes
 - Sprites
 - Collections of Drawables

Drawables are always rectangular in shape in their local coordinate system,
which makes them quad-shaped in arbitrary (linearly transformed) coordinate systems.

```csharp
public abstract class Drawable : Transformable, IDependencyInjectionCandidate, IDisposable, IDrawable, ITransformable, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedDependencyActivator, ISourceGeneratedHandleInputCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md)

#### Derived

[BufferedContainerView<T\>](osu.Framework.Graphics.Sprites.BufferedContainerView\-1.md), 
[Component](osu.Framework.Graphics.Component.md), 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md), 
[FastCircle](osu.Framework.Graphics.Shapes.FastCircle.md), 
[TestSceneInputPropagationForLoadStates.InputReceiver](osu.Framework.Tests.Visual.Input.TestSceneInputPropagationForLoadStates.InputReceiver.md), 
[TestSceneInputPropagationForLoadStates.InputSender](osu.Framework.Tests.Visual.Input.TestSceneInputPropagationForLoadStates.InputSender.md), 
[Path](osu.Framework.Graphics.Lines.Path.md), 
[Sprite](osu.Framework.Graphics.Sprites.Sprite.md), 
[SpriteIcon](osu.Framework.Graphics.Sprites.SpriteIcon.md), 
[SpriteText](osu.Framework.Graphics.Sprites.SpriteText.md), 
[WaveformGraph](osu.Framework.Graphics.Audio.WaveformGraph.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

#### Inherited Members

[Transformable.Clock](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_Clock), 
[Transformable.Time](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_Time), 
[Transformable.TransformStartTime](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_TransformStartTime), 
[Transformable.TransformDelay](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_TransformDelay), 
[Transformable.Transforms](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_Transforms), 
[Transformable.TransformsForTargetMember\(string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_TransformsForTargetMember\_System\_String\_), 
[Transformable.LatestTransformEndTime](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_LatestTransformEndTime), 
[Transformable.RemoveCompletedTransforms](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_RemoveCompletedTransforms), 
[Transformable.UpdateTransforms\(\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_UpdateTransforms), 
[Transformable.RemoveTransform\(Transform\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_RemoveTransform\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[Transformable.ClearTransforms\(bool, string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_ClearTransforms\_System\_Boolean\_System\_String\_), 
[Transformable.ClearTransformsAfter\(double, bool, string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_ClearTransformsAfter\_System\_Double\_System\_Boolean\_System\_String\_), 
[Transformable.ApplyTransformsAt\(double, bool\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_ApplyTransformsAt\_System\_Double\_System\_Boolean\_), 
[Transformable.FinishTransforms\(bool, string\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_FinishTransforms\_System\_Boolean\_System\_String\_), 
[Transformable.BeginDelayedSequence\(double, bool\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_BeginDelayedSequence\_System\_Double\_System\_Boolean\_), 
[Transformable.BeginAbsoluteSequence\(double, bool\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_BeginAbsoluteSequence\_System\_Double\_System\_Boolean\_), 
[Transformable.AddTransform\(Transform, ulong?\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_AddTransform\_osu\_Framework\_Graphics\_Transforms\_Transform\_System\_Nullable\_System\_UInt64\_\_), 
[Transformable.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Transforms.Transformable.md\#osu\_Framework\_Graphics\_Transforms\_Transformable\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[TransformableExtensions.Animate<Drawable\>\(Drawable, params TransformSequence<Drawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<Drawable\>\(Drawable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<Drawable\>\(Drawable, double, params TransformSequence<Drawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<Drawable\>\(Drawable\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<Drawable\>\(Drawable, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<Drawable, TEasing\>\(Drawable, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<Drawable\>\(Drawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<Drawable, TEasing\>\(Drawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<Drawable\>\(Drawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<Drawable, TEasing\>\(Drawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<Drawable\>\(Drawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<Drawable, TEasing\>\(Drawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<Drawable\>\(Drawable, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<Drawable, TEasing\>\(Drawable, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<Drawable\>\(Drawable, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<Drawable, TEasing\>\(Drawable, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Drawable\>\(Drawable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<Drawable\>\(Drawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Drawable\>\(Drawable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<Drawable\>\(Drawable, double, int, params TransformSequence<Drawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<Drawable\>\(Drawable, double, params TransformSequence<Drawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<Drawable\>\(Drawable, params TransformSequence<Drawable\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<Drawable\>\(Drawable, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<Drawable, TValue\>\(Drawable, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<Drawable, TEasing, TValue\>\(Drawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<Drawable\>\(Drawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<Drawable\>\(Drawable, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<Drawable, TEasing\>\(Drawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<Drawable, TEasing\>\(Drawable, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<Drawable\>\(Drawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<Drawable, TEasing\>\(Drawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, Drawable\>\(Drawable, Transform<TValue, DefaultEasingFunction, Drawable\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, Drawable\>\(Drawable, Transform<TValue, TEasing, Drawable\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<Drawable\>\(Drawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<Drawable, TEasing\>\(Drawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<Drawable\>\(Drawable, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<Drawable\>\(Drawable, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<Drawable, TEasing\>\(Drawable, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<Drawable, TEasing\>\(Drawable, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<Drawable\>\(Drawable, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<Drawable\>\(Drawable, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<Drawable, TValue\>\(Drawable, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<Drawable, TValue, TEasing\>\(Drawable, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<Drawable, TValue\>\(Drawable, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<Drawable, TValue, TEasing\>\(Drawable, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<Drawable\>\(Drawable, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[DrawableExtensions.With<Drawable\>\(Drawable, Action<Drawable\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<Drawable, TChild\>\(Drawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Drawable, TChild\>\(Drawable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Drawable, TChild\>\(Drawable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Drawable\>\(Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Drawable__ctor"></a> Drawable\(\)

```csharp
protected Drawable()
```

## Fields

### <a id="osu_Framework_Graphics_Drawable_Name"></a> Name

A name used to identify this Drawable internally.

```csharp
public string Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Graphics_Drawable_ProcessCustomClock"></a> ProcessCustomClock

Whether <xref href="osu.Framework.Timing.IFrameBasedClock.ProcessFrame" data-throw-if-not-resolved="false"></xref> should be automatically invoked on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.Clock" data-throw-if-not-resolved="false"></xref>
in <xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref>. This should only be set to false in scenarios where the clock is updated elsewhere.

```csharp
public bool ProcessCustomClock
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Graphics_Drawable_AcceptsFocus"></a> AcceptsFocus

If true, we will gain focus (receiving priority on keyboard input) (and receive an <xref href="osu.Framework.Graphics.Drawable.OnFocus(osu.Framework.Input.Events.FocusEvent)" data-throw-if-not-resolved="false"></xref> event) on returning true in <xref href="osu.Framework.Graphics.Drawable.OnClick(osu.Framework.Input.Events.ClickEvent)" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual bool AcceptsFocus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_Alpha"></a> Alpha

Multiplicative alpha factor applied on top of <xref href="osu.Framework.Graphics.Colour.ColourInfo" data-throw-if-not-resolved="false"></xref> and its existing
alpha channel(s).

```csharp
public float Alpha { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_AlwaysPresent"></a> AlwaysPresent

If true, forces <xref href="osu.Framework.Graphics.Drawable.IsPresent" data-throw-if-not-resolved="false"></xref> to always be true. In other words,
this drawable is always considered for layout, input, and drawing, regardless
of alpha value.

```csharp
public bool AlwaysPresent { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_Anchor"></a> Anchor

Specifies where <xref href="osu.Framework.Graphics.Drawable.Origin" data-throw-if-not-resolved="false"></xref> is attached to the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>
in the coordinate system with origin at the top left corner of the
<xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.DrawRectangle" data-throw-if-not-resolved="false"></xref>.
Can either be one of 9 relative positions (0, 0.5, and 1 in x and y)
or a fixed absolute position via <xref href="osu.Framework.Graphics.Drawable.RelativeAnchorPosition" data-throw-if-not-resolved="false"></xref>.

```csharp
public Anchor Anchor { get; set; }
```

#### Property Value

 [Anchor](osu.Framework.Graphics.Anchor.md)

### <a id="osu_Framework_Graphics_Drawable_AnchorPosition"></a> AnchorPosition

Specifies in absolute coordinates where <xref href="osu.Framework.Graphics.Drawable.Origin" data-throw-if-not-resolved="false"></xref> is attached
to the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref> in the coordinate system with origin at the top
left corner of the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.DrawRectangle" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 AnchorPosition { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_Blending"></a> Blending

Determines how this Drawable is blended with other already drawn Drawables.
Inherits the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.Blending" data-throw-if-not-resolved="false"></xref> by default.

```csharp
public BlendingParameters Blending { get; set; }
```

#### Property Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_Drawable_BoundingBox"></a> BoundingBox

Computes the bounding box of this drawable in its parent's space.

```csharp
public virtual RectangleF BoundingBox { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Drawable_BypassAutoSizeAxes"></a> BypassAutoSizeAxes

Controls which <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> are ignored by parent <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref> automatic sizing.
Most notably, <xref href="osu.Framework.Graphics.Drawable.RelativePositionAxes" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> do not affect
automatic sizing to avoid circular size dependencies.

```csharp
public Axes BypassAutoSizeAxes { get; set; }
```

#### Property Value

 [Axes](osu.Framework.Graphics.Axes.md)

### <a id="osu_Framework_Graphics_Drawable_ChangeFocusOnClick"></a> ChangeFocusOnClick

If true, returning true in <xref href="osu.Framework.Graphics.Drawable.OnClick(osu.Framework.Input.Events.ClickEvent)" data-throw-if-not-resolved="false"></xref> causes the current focus target to be unfocused.

```csharp
public virtual bool ChangeFocusOnClick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_Clock"></a> Clock

The clock of this drawable. Used for keeping track of time across
frames. By default is inherited from <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>.
If set, then the provided value is used as a custom clock and the
<xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s clock is ignored.

```csharp
public override IFrameBasedClock Clock { get; set; }
```

#### Property Value

 [IFrameBasedClock](osu.Framework.Timing.IFrameBasedClock.md)

### <a id="osu_Framework_Graphics_Drawable_Colour"></a> Colour

Colour of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> in sRGB space. Can contain individual colours for all four
corners of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, which are then interpolated, but can also be assigned
just a single colour. Implicit casts from <xref href="osu.Framework.Graphics.Colour.SRGBColour" data-throw-if-not-resolved="false"></xref> and from <xref href="osuTK.Graphics.Color4" data-throw-if-not-resolved="false"></xref> exist.

```csharp
public ColourInfo Colour { get; set; }
```

#### Property Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Drawable_Depth"></a> Depth

Controls which Drawables are behind or in front of other Drawables.
This amounts to sorting Drawables by their <xref href="osu.Framework.Graphics.Drawable.Depth" data-throw-if-not-resolved="false"></xref>.
A Drawable with higher <xref href="osu.Framework.Graphics.Drawable.Depth" data-throw-if-not-resolved="false"></xref> than another Drawable is
drawn behind the other Drawable.

```csharp
public float Depth { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_DisposeOnDeathRemoval"></a> DisposeOnDeathRemoval

Whether this Drawable should be disposed when it is automatically removed from
its <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref> due to <xref href="osu.Framework.Graphics.Drawable.ShouldBeAlive" data-throw-if-not-resolved="false"></xref> being false.

```csharp
public virtual bool DisposeOnDeathRemoval { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_DragBlocksClick"></a> DragBlocksClick

Whether clicks should be blocked when this drawable is in a dragged state.

```csharp
public virtual bool DragBlocksClick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This is queried when a click is to be actuated.

### <a id="osu_Framework_Graphics_Drawable_DrawColourInfo"></a> DrawColourInfo

Contains the colour and blending information of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that are used during draw.

```csharp
public virtual DrawColourInfo DrawColourInfo { get; }
```

#### Property Value

 [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)

### <a id="osu_Framework_Graphics_Drawable_DrawHeight"></a> DrawHeight

Y component of <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref>.

```csharp
public float DrawHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_DrawInfo"></a> DrawInfo

Contains the linear transformation of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that is used during draw.

```csharp
public virtual DrawInfo DrawInfo { get; }
```

#### Property Value

 [DrawInfo](osu.Framework.Graphics.DrawInfo.md)

### <a id="osu_Framework_Graphics_Drawable_DrawPosition"></a> DrawPosition

Absolute positional offset of <xref href="osu.Framework.Graphics.Drawable.Origin" data-throw-if-not-resolved="false"></xref> to <xref href="osu.Framework.Graphics.Drawable.RelativeAnchorPosition" data-throw-if-not-resolved="false"></xref>
in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.

```csharp
public Vector2 DrawPosition { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_DrawRectangle"></a> DrawRectangle

Absolutely sized rectangle for drawing in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.
Based on <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref>.

```csharp
public RectangleF DrawRectangle { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Drawable_DrawScale"></a> DrawScale

Relative scaling factor around <xref href="osu.Framework.Graphics.Drawable.OriginPosition" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual Vector2 DrawScale { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_DrawSize"></a> DrawSize

Absolute size of this Drawable in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.

```csharp
public Vector2 DrawSize { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_DrawWidth"></a> DrawWidth

X component of <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref>.

```csharp
public float DrawWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_FillAspectRatio"></a> FillAspectRatio

The desired ratio of width to height when under the effect of a non-stretching <xref href="osu.Framework.Graphics.Drawable.FillMode" data-throw-if-not-resolved="false"></xref>
and <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> being <xref href="osu.Framework.Graphics.Axes.Both" data-throw-if-not-resolved="false"></xref>.

```csharp
public float FillAspectRatio { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_FillMode"></a> FillMode

Controls the behavior of <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> when it is set to <xref href="osu.Framework.Graphics.Axes.Both" data-throw-if-not-resolved="false"></xref>.
Otherwise, this member has no effect. By default, stretching is used, which simply scales
this drawable's <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> according to <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.RelativeToAbsoluteFactor" data-throw-if-not-resolved="false"></xref>
disregarding this drawable's <xref href="osu.Framework.Graphics.Drawable.FillAspectRatio" data-throw-if-not-resolved="false"></xref>. Other values of <xref href="osu.Framework.Graphics.Drawable.FillMode" data-throw-if-not-resolved="false"></xref> preserve <xref href="osu.Framework.Graphics.Drawable.FillAspectRatio" data-throw-if-not-resolved="false"></xref>.

```csharp
public FillMode FillMode { get; set; }
```

#### Property Value

 [FillMode](osu.Framework.Graphics.FillMode.md)

### <a id="osu_Framework_Graphics_Drawable_HandleNonPositionalInput"></a> HandleNonPositionalInput

Whether this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> handles non-positional input.
This value is true by default if <xref href="osu.Framework.Graphics.Drawable.Handle(osu.Framework.Input.Events.UIEvent)" data-throw-if-not-resolved="false"></xref> or any non-positional (e.g. keyboard related) "On-" input methods are overridden.

```csharp
public virtual bool HandleNonPositionalInput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_HandlePositionalInput"></a> HandlePositionalInput

Whether this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> handles positional input.
This value is true by default if <xref href="osu.Framework.Graphics.Drawable.Handle(osu.Framework.Input.Events.UIEvent)" data-throw-if-not-resolved="false"></xref> or any positional (i.e. mouse related) "On-" input methods are overridden.

```csharp
public virtual bool HandlePositionalInput { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_HasFocus"></a> HasFocus

Check whether we have active focus.

```csharp
public bool HasFocus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_HasProxy"></a> HasProxy

True iff <xref href="osu.Framework.Graphics.Drawable.CreateProxy" data-throw-if-not-resolved="false"></xref> has been called before.

```csharp
public bool HasProxy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_Height"></a> Height

Y component of <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual float Height { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_InvalidationFromParentSize"></a> InvalidationFromParentSize

```csharp
public Invalidation InvalidationFromParentSize { get; }
```

#### Property Value

 [Invalidation](osu.Framework.Graphics.Invalidation.md)

### <a id="osu_Framework_Graphics_Drawable_InvalidationID"></a> InvalidationID

The current invalidation ID of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Incremented every time the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> should be re-validated.

```csharp
public long InvalidationID { get; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="osu_Framework_Graphics_Drawable_IsAlive"></a> IsAlive

Whether this drawable is part of its parent's <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.AliveInternalChildren" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool IsAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_IsDisposed"></a> IsDisposed

```csharp
protected bool IsDisposed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_IsDragged"></a> IsDragged

Whether this Drawable is currently being dragged.

```csharp
public bool IsDragged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_IsHovered"></a> IsHovered

Whether this Drawable is currently hovered over.

```csharp
public bool IsHovered { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This is updated only if <xref href="osu.Framework.Graphics.Drawable.HandlePositionalInput" data-throw-if-not-resolved="false"></xref> is true.

### <a id="osu_Framework_Graphics_Drawable_IsLoaded"></a> IsLoaded

Whether this Drawable is fully loaded.
This is true iff <xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref> has run once on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool IsLoaded { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_IsPresent"></a> IsPresent

Determines whether this Drawable is present based on its <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> value.
Can be forced always on with <xref href="osu.Framework.Graphics.Drawable.AlwaysPresent" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual bool IsPresent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_IsProxy"></a> IsProxy

True iff this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is a proxy of any <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool IsProxy { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_LayoutRectangle"></a> LayoutRectangle

Absolutely sized rectangle for layout in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.
Based on <xref href="osu.Framework.Graphics.Drawable.LayoutSize" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Drawable.margin" data-throw-if-not-resolved="false"></xref>.

```csharp
public RectangleF LayoutRectangle { get; }
```

#### Property Value

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

### <a id="osu_Framework_Graphics_Drawable_LayoutSize"></a> LayoutSize

Absolute size of this Drawable's layout rectangle in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s
coordinate system; i.e. <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref> with the addition of <xref href="osu.Framework.Graphics.Drawable.Margin" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 LayoutSize { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_LifetimeEnd"></a> LifetimeEnd

The time at which this drawable is no longer valid (and is considered for disposal).

```csharp
public virtual double LifetimeEnd { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Drawable_LifetimeStart"></a> LifetimeStart

The time at which this drawable becomes valid (and is considered for drawing).

```csharp
public virtual double LifetimeStart { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Drawable_LoadState"></a> LoadState

Describes the current state of this Drawable within the loading pipeline.

```csharp
public LoadState LoadState { get; }
```

#### Property Value

 [LoadState](osu.Framework.Graphics.LoadState.md)

### <a id="osu_Framework_Graphics_Drawable_Margin"></a> Margin

Size of an empty region around this Drawable used to manipulate
layout. Does not affect <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref> or the region of accepted input,
but does affect <xref href="osu.Framework.Graphics.Drawable.LayoutSize" data-throw-if-not-resolved="false"></xref>.

```csharp
public MarginPadding Margin { get; set; }
```

#### Property Value

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

### <a id="osu_Framework_Graphics_Drawable_Origin"></a> Origin

The origin of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual Anchor Origin { get; set; }
```

#### Property Value

 [Anchor](osu.Framework.Graphics.Anchor.md)

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

If the provided value does not exist in the <xref href="osu.Framework.Graphics.Anchor" data-throw-if-not-resolved="false"></xref> enumeration.

### <a id="osu_Framework_Graphics_Drawable_OriginPosition"></a> OriginPosition

The origin of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> expressed in absolute coordinates from the top-left corner of <xref href="osu.Framework.Graphics.Drawable.DrawRectangle" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual Vector2 OriginPosition { get; set; }
```

#### Property Value

 Vector2

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

If the provided value is not finite.

### <a id="osu_Framework_Graphics_Drawable_Parent"></a> Parent

The parent of this drawable in the scene graph.

```csharp
public CompositeDrawable Parent { get; }
```

#### Property Value

 [CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)

### <a id="osu_Framework_Graphics_Drawable_Position"></a> Position

Positional offset of <xref href="osu.Framework.Graphics.Drawable.Origin" data-throw-if-not-resolved="false"></xref> to <xref href="osu.Framework.Graphics.Drawable.RelativeAnchorPosition" data-throw-if-not-resolved="false"></xref> in the
<xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system. May be in absolute or relative units
(controlled by <xref href="osu.Framework.Graphics.Drawable.RelativePositionAxes" data-throw-if-not-resolved="false"></xref>).

```csharp
public Vector2 Position { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_PropagateNonPositionalInputSubTree"></a> PropagateNonPositionalInputSubTree

Whether non-positional input should be propagated to the sub-tree rooted at this drawable.

```csharp
public virtual bool PropagateNonPositionalInputSubTree { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_PropagatePositionalInputSubTree"></a> PropagatePositionalInputSubTree

Whether positional input should be propagated to the sub-tree rooted at this drawable.

```csharp
public virtual bool PropagatePositionalInputSubTree { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_RelativeAnchorPosition"></a> RelativeAnchorPosition

Specifies in relative coordinates where <xref href="osu.Framework.Graphics.Drawable.Origin" data-throw-if-not-resolved="false"></xref> is attached
to the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref> in the coordinate system with origin at the top
left corner of the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.DrawRectangle" data-throw-if-not-resolved="false"></xref>, and
a value of <xref href="osuTK.Vector2.One" data-throw-if-not-resolved="false"></xref> referring to the bottom right corner of
the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.DrawRectangle" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 RelativeAnchorPosition { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_RelativeOriginPosition"></a> RelativeOriginPosition

The origin of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> expressed in relative coordinates from the top-left corner of <xref href="osu.Framework.Graphics.Drawable.DrawRectangle" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 RelativeOriginPosition { get; }
```

#### Property Value

 Vector2

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

If <xref href="osu.Framework.Graphics.Drawable.Origin" data-throw-if-not-resolved="false"></xref> is <xref href="osu.Framework.Graphics.Anchor.Custom" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Drawable_RelativePositionAxes"></a> RelativePositionAxes

Controls which <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> of <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> are relative w.r.t.
<xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s size (from 0 to 1) rather than absolute.
The <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> set in this property are ignored by automatically sizing
parents.

```csharp
public Axes RelativePositionAxes { get; set; }
```

#### Property Value

 [Axes](osu.Framework.Graphics.Axes.md)

#### Remarks

When setting this property, the <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref> is converted such that
<xref href="osu.Framework.Graphics.Drawable.DrawPosition" data-throw-if-not-resolved="false"></xref> remains invariant.

### <a id="osu_Framework_Graphics_Drawable_RelativeSizeAxes"></a> RelativeSizeAxes

Controls which <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> are relative sizes w.r.t. <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s size
(from 0 to 1) in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system, rather than absolute sizes.
The <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref> set in this property are ignored by automatically sizing
parents.

```csharp
public virtual Axes RelativeSizeAxes { get; set; }
```

#### Property Value

 [Axes](osu.Framework.Graphics.Axes.md)

#### Remarks

If an axis becomes relatively sized and its component of <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> was previously 0,
then it automatically becomes 1. In all other cases <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref> is converted such that
<xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref> remains invariant across changes of this property.

### <a id="osu_Framework_Graphics_Drawable_RemoveWhenNotAlive"></a> RemoveWhenNotAlive

Whether to remove the drawable from its parent's children when it's not alive.

```csharp
public virtual bool RemoveWhenNotAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_RequestsFocus"></a> RequestsFocus

If true, we are eagerly requesting focus. If nothing else above us has (or is requesting focus) we will get it.

```csharp
public virtual bool RequestsFocus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

In order to get focused, <xref href="osu.Framework.Graphics.Drawable.HandleNonPositionalInput" data-throw-if-not-resolved="false"></xref> must be true.

### <a id="osu_Framework_Graphics_Drawable_Rotation"></a> Rotation

Rotation in degrees around <xref href="osu.Framework.Graphics.Drawable.OriginPosition" data-throw-if-not-resolved="false"></xref>.

```csharp
public float Rotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_Scale"></a> Scale

Base relative scaling factor around <xref href="osu.Framework.Graphics.Drawable.OriginPosition" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 Scale { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_Scheduler"></a> Scheduler

A lazily-initialized scheduler used to schedule tasks to be invoked in future <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref>s calls.
The tasks are invoked at the beginning of the <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref> method before anything else.

```csharp
protected Scheduler Scheduler { get; }
```

#### Property Value

 [Scheduler](osu.Framework.Threading.Scheduler.md)

### <a id="osu_Framework_Graphics_Drawable_ScreenSpaceDrawQuad"></a> ScreenSpaceDrawQuad

The screen-space quad this drawable occupies.

```csharp
public virtual Quad ScreenSpaceDrawQuad { get; }
```

#### Property Value

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Drawable_Shear"></a> Shear

Relative shearing factor. The X dimension is relative w.r.t. <xref href="osu.Framework.Graphics.Drawable.Height" data-throw-if-not-resolved="false"></xref>
and the Y dimension relative w.r.t. <xref href="osu.Framework.Graphics.Drawable.Width" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 Shear { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_ShouldBeAlive"></a> ShouldBeAlive

Whether this drawable should currently be alive.
This is queried by the framework to decide the <xref href="osu.Framework.Graphics.Drawable.IsAlive" data-throw-if-not-resolved="false"></xref> state of this drawable for the next frame.

```csharp
protected virtual bool ShouldBeAlive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_Size"></a> Size

Size of this Drawable in the <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s coordinate system.
May be in absolute or relative units (controlled by <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref>).

```csharp
public virtual Vector2 Size { get; set; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Graphics_Drawable_Width"></a> Width

X component of <xref href="osu.Framework.Graphics.Drawable.Size" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual float Width { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_X"></a> X

X component of <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref>.

```csharp
public float X { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Drawable_Y"></a> Y

Y component of <xref href="osu.Framework.Graphics.Drawable.Position" data-throw-if-not-resolved="false"></xref>.

```csharp
public float Y { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Drawable_AddLayout_osu_Framework_Layout_LayoutMember_"></a> AddLayout\(LayoutMember\)

Adds a layout member that will be invalidated when its <xref href="osu.Framework.Layout.LayoutMember.Invalidation" data-throw-if-not-resolved="false"></xref> is invalidated.

```csharp
protected void AddLayout(LayoutMember member)
```

#### Parameters

`member` [LayoutMember](osu.Framework.Layout.LayoutMember.md)

The layout member to add.

### <a id="osu_Framework_Graphics_Drawable_ApplyRelativeAxes_osu_Framework_Graphics_Axes_osuTK_Vector2_osu_Framework_Graphics_FillMode_"></a> ApplyRelativeAxes\(Axes, Vector2, FillMode\)

Helper function for converting potentially relative coordinates in the
<xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s space to absolute coordinates based on which
axes are relative. <xref href="osu.Framework.Graphics.Axes" data-throw-if-not-resolved="false"></xref>

```csharp
protected Vector2 ApplyRelativeAxes(Axes relativeAxes, Vector2 v, FillMode fillMode)
```

#### Parameters

`relativeAxes` [Axes](osu.Framework.Graphics.Axes.md)

Describes which axes are relative.

`v` Vector2

The coordinates to convert.

`fillMode` [FillMode](osu.Framework.Graphics.FillMode.md)

The <xref href="osu.Framework.Graphics.Drawable.FillMode" data-throw-if-not-resolved="false"></xref> to be used.

#### Returns

 Vector2

Absolute coordinates in <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref>'s space.

### <a id="osu_Framework_Graphics_Drawable_ComputeIsMaskedAway_osu_Framework_Graphics_Primitives_RectangleF_"></a> ComputeIsMaskedAway\(RectangleF\)

Computes whether this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is masked away.

```csharp
protected virtual bool ComputeIsMaskedAway(RectangleF maskingBounds)
```

#### Parameters

`maskingBounds` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> that defines the masking bounds.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is currently masked away.

### <a id="osu_Framework_Graphics_Drawable_ComputeMaskingBounds"></a> ComputeMaskingBounds\(\)

Computes the masking bounds of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual RectangleF ComputeMaskingBounds()
```

#### Returns

 [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

The <xref href="osu.Framework.Graphics.Primitives.RectangleF" data-throw-if-not-resolved="false"></xref> that defines the masking bounds.

### <a id="osu_Framework_Graphics_Drawable_ComputeScreenSpaceDrawQuad"></a> ComputeScreenSpaceDrawQuad\(\)

```csharp
protected virtual Quad ComputeScreenSpaceDrawQuad()
```

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

### <a id="osu_Framework_Graphics_Drawable_Contains_osuTK_Vector2_"></a> Contains\(Vector2\)

Computes whether a given screen-space position is contained within this drawable.
Mouse input events are only received when this function is true, or when the drawable
is in focus.

```csharp
public virtual bool Contains(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

The screen space position to be checked against this drawable.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_CreateDrawNode"></a> CreateDrawNode\(\)

Creates a draw node capable of containing all information required to draw this drawable.

```csharp
protected virtual DrawNode CreateDrawNode()
```

#### Returns

 [DrawNode](osu.Framework.Graphics.DrawNode.md)

The created draw node.

### <a id="osu_Framework_Graphics_Drawable_CreateProxy"></a> CreateProxy\(\)

Creates a proxy drawable which can be inserted elsewhere in the scene graph.
Will cause the original instance to not render itself.
Creating multiple proxies is not supported and will result in an
<xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref>.

```csharp
public Drawable CreateProxy()
```

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Graphics_Drawable_Dispose"></a> Dispose\(\)

Disposes this drawable.

```csharp
public void Dispose()
```

### <a id="osu_Framework_Graphics_Drawable_Dispose_System_Boolean_"></a> Dispose\(bool\)

Disposes this drawable.

```csharp
protected virtual void Dispose(bool isDisposing)
```

#### Parameters

`isDisposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_Empty"></a> Empty\(\)

Creates a new instance of an empty <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public static Drawable Empty()
```

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Graphics_Drawable_Expire_System_Boolean_"></a> Expire\(bool\)

Make this drawable automatically clean itself up after all transforms have finished playing.
Can be delayed using Delay().

```csharp
public void Expire(bool calculateLifetimeStart = false)
```

#### Parameters

`calculateLifetimeStart` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Drawable_GetContainingFocusManager"></a> GetContainingFocusManager\(\)

Retrieve the first parent in the tree which implements <xref href="osu.Framework.Input.IFocusManager" data-throw-if-not-resolved="false"></xref>.
As this is performing an upward tree traversal, avoid calling every frame.

```csharp
[CanBeNull]
protected IFocusManager GetContainingFocusManager()
```

#### Returns

 [IFocusManager](osu.Framework.Input.IFocusManager.md)

The first parent <xref href="osu.Framework.Input.IFocusManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Drawable_GetContainingInputManager"></a> GetContainingInputManager\(\)

Retrieve the first parent in the tree which derives from <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref>.
As this is performing an upward tree traversal, avoid calling every frame.

```csharp
[CanBeNull]
protected InputManager GetContainingInputManager()
```

#### Returns

 [InputManager](osu.Framework.Input.InputManager.md)

The first parent <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Drawable_Handle_osu_Framework_Input_Events_UIEvent_"></a> Handle\(UIEvent\)

Handle a UI event.

```csharp
protected virtual bool Handle(UIEvent e)
```

#### Parameters

`e` [UIEvent](osu.Framework.Input.Events.UIEvent.md)

The event to be handled.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If the event supports blocking, returning true will make the event to not propagating further.

### <a id="osu_Framework_Graphics_Drawable_Hide"></a> Hide\(\)

Hide sprite instantly.

```csharp
public virtual void Hide()
```

### <a id="osu_Framework_Graphics_Drawable_InjectDependencies_osu_Framework_Allocation_IReadOnlyDependencyContainer_"></a> InjectDependencies\(IReadOnlyDependencyContainer\)

Injects dependencies from an <xref href="osu.Framework.Allocation.IReadOnlyDependencyContainer" data-throw-if-not-resolved="false"></xref> into this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void InjectDependencies(IReadOnlyDependencyContainer dependencies)
```

#### Parameters

`dependencies` [IReadOnlyDependencyContainer](osu.Framework.Allocation.IReadOnlyDependencyContainer.md)

The dependencies to inject.

### <a id="osu_Framework_Graphics_Drawable_Invalidate_osu_Framework_Graphics_Invalidation_osu_Framework_Layout_InvalidationSource_"></a> Invalidate\(Invalidation, InvalidationSource\)

Invalidates the layout of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Invalidate(Invalidation invalidation = Invalidation.All, InvalidationSource source = InvalidationSource.Self)
```

#### Parameters

`invalidation` [Invalidation](osu.Framework.Graphics.Invalidation.md)

The flags to invalidate with.

`source` [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

The source that triggered the invalidation.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

If any layout was invalidated.

### <a id="osu_Framework_Graphics_Drawable_LoadAsyncComplete"></a> LoadAsyncComplete\(\)

Invoked after dependency injection has completed for this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> and all
children if this is a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void LoadAsyncComplete()
```

#### Remarks

This method is invoked in the potentially asynchronous context of <xref href="osu.Framework.Graphics.Drawable.Load(osu.Framework.Timing.IFrameBasedClock%2cosu.Framework.Allocation.IReadOnlyDependencyContainer%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref> prior to
this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> becoming <xref href="osu.Framework.Graphics.Drawable.IsLoaded" data-throw-if-not-resolved="false"></xref> = true.

### <a id="osu_Framework_Graphics_Drawable_LoadComplete"></a> LoadComplete\(\)

Invoked after this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> has finished loading.

```csharp
protected virtual void LoadComplete()
```

#### Remarks

This method is invoked on the update thread inside this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Drawable_OnClick_osu_Framework_Input_Events_ClickEvent_"></a> OnClick\(ClickEvent\)

An event that occurs when a <xref href="osuTK.Input.MouseButton" data-throw-if-not-resolved="false"></xref> is clicked on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnClick(ClickEvent e)
```

#### Parameters

`e` [ClickEvent](osu.Framework.Input.Events.ClickEvent.md)

The <xref href="osu.Framework.Input.Events.ClickEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s that received a previous <xref href="osu.Framework.Graphics.Drawable.OnMouseDown(osu.Framework.Input.Events.MouseDownEvent)" data-throw-if-not-resolved="false"></xref> invocation
which are still present in the input queue (via <xref href="osu.Framework.Graphics.Drawable.BuildPositionalInputQueue(osuTK.Vector2%2cSystem.Collections.Generic.List%7bosu.Framework.Graphics.Drawable%7d)" data-throw-if-not-resolved="false"></xref>) when the click occurs.<br />
This will not occur if a drag was started (<xref href="osu.Framework.Graphics.Drawable.OnDragStart(osu.Framework.Input.Events.DragStartEvent)" data-throw-if-not-resolved="false"></xref> was invoked) or a double-click occurred (<xref href="osu.Framework.Graphics.Drawable.OnDoubleClick(osu.Framework.Input.Events.DoubleClickEvent)" data-throw-if-not-resolved="false"></xref> was invoked).

### <a id="osu_Framework_Graphics_Drawable_OnDoubleClick_osu_Framework_Input_Events_DoubleClickEvent_"></a> OnDoubleClick\(DoubleClickEvent\)

An event that occurs when a <xref href="osuTK.Input.MouseButton" data-throw-if-not-resolved="false"></xref> is double-clicked on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnDoubleClick(DoubleClickEvent e)
```

#### Parameters

`e` [DoubleClickEvent](osu.Framework.Input.Events.DoubleClickEvent.md)

The <xref href="osu.Framework.Input.Events.DoubleClickEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the next <xref href="osu.Framework.Graphics.Drawable.OnClick(osu.Framework.Input.Events.ClickEvent)" data-throw-if-not-resolved="false"></xref> event from occurring.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that returned <pre><code class="lang-csharp">true</code></pre> from a previous <xref href="osu.Framework.Graphics.Drawable.OnClick(osu.Framework.Input.Events.ClickEvent)" data-throw-if-not-resolved="false"></xref> invocation.

### <a id="osu_Framework_Graphics_Drawable_OnDrag_osu_Framework_Input_Events_DragEvent_"></a> OnDrag\(DragEvent\)

An event that occurs every time the mouse moves while dragging this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void OnDrag(DragEvent e)
```

#### Parameters

`e` [DragEvent](osu.Framework.Input.Events.DragEvent.md)

The <xref href="osu.Framework.Input.Events.DragEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that returned <pre><code class="lang-csharp">true</code></pre> from a previous <xref href="osu.Framework.Graphics.Drawable.OnDragStart(osu.Framework.Input.Events.DragStartEvent)" data-throw-if-not-resolved="false"></xref> invocation.

### <a id="osu_Framework_Graphics_Drawable_OnDragEnd_osu_Framework_Input_Events_DragEndEvent_"></a> OnDragEnd\(DragEndEvent\)

An event that occurs when the mouse stops dragging this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void OnDragEnd(DragEndEvent e)
```

#### Parameters

`e` [DragEndEvent](osu.Framework.Input.Events.DragEndEvent.md)

The <xref href="osu.Framework.Input.Events.DragEndEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that returned <pre><code class="lang-csharp">true</code></pre> from a previous <xref href="osu.Framework.Graphics.Drawable.OnDragStart(osu.Framework.Input.Events.DragStartEvent)" data-throw-if-not-resolved="false"></xref> invocation.

### <a id="osu_Framework_Graphics_Drawable_OnDragStart_osu_Framework_Input_Events_DragStartEvent_"></a> OnDragStart\(DragStartEvent\)

An event that occurs when the mouse starts dragging on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnDragStart(DragStartEvent e)
```

#### Parameters

`e` [DragStartEvent](osu.Framework.Input.Events.DragStartEvent.md)

The <xref href="osu.Framework.Input.Events.DragEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnFocus_osu_Framework_Input_Events_FocusEvent_"></a> OnFocus\(FocusEvent\)

An event that occurs when this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> gains focus.

```csharp
protected virtual void OnFocus(FocusEvent e)
```

#### Parameters

`e` [FocusEvent](osu.Framework.Input.Events.FocusEvent.md)

The <xref href="osu.Framework.Input.Events.FocusEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that returned <pre><code class="lang-csharp">true</code></pre> from both <xref href="osu.Framework.Graphics.Drawable.AcceptsFocus" data-throw-if-not-resolved="false"></xref> and a previous <xref href="osu.Framework.Graphics.Drawable.OnClick(osu.Framework.Input.Events.ClickEvent)" data-throw-if-not-resolved="false"></xref> invocation.

### <a id="osu_Framework_Graphics_Drawable_OnFocusLost_osu_Framework_Input_Events_FocusLostEvent_"></a> OnFocusLost\(FocusLostEvent\)

An event that occurs when this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> loses focus.

```csharp
protected virtual void OnFocusLost(FocusLostEvent e)
```

#### Parameters

`e` [FocusLostEvent](osu.Framework.Input.Events.FocusLostEvent.md)

The <xref href="osu.Framework.Input.Events.FocusLostEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that previously had focus (<xref href="osu.Framework.Graphics.Drawable.OnFocus(osu.Framework.Input.Events.FocusEvent)" data-throw-if-not-resolved="false"></xref> was invoked).

### <a id="osu_Framework_Graphics_Drawable_OnHover_osu_Framework_Input_Events_HoverEvent_"></a> OnHover\(HoverEvent\)

An event that occurs when the mouse starts hovering this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnHover(HoverEvent e)
```

#### Parameters

`e` [HoverEvent](osu.Framework.Input.Events.HoverEvent.md)

The <xref href="osu.Framework.Input.Events.HoverEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnHoverLost_osu_Framework_Input_Events_HoverLostEvent_"></a> OnHoverLost\(HoverLostEvent\)

An event that occurs when the mouse stops hovering this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void OnHoverLost(HoverLostEvent e)
```

#### Parameters

`e` [HoverLostEvent](osu.Framework.Input.Events.HoverLostEvent.md)

The <xref href="osu.Framework.Input.Events.HoverLostEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnHover(osu.Framework.Input.Events.HoverEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnInvalidate_osu_Framework_Graphics_Invalidation_osu_Framework_Layout_InvalidationSource_"></a> OnInvalidate\(Invalidation, InvalidationSource\)

Invoked when the layout of this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> was invalidated.

```csharp
protected virtual bool OnInvalidate(Invalidation invalidation, InvalidationSource source)
```

#### Parameters

`invalidation` [Invalidation](osu.Framework.Graphics.Invalidation.md)

The flags that the this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> was invalidated with.

`source` [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

The source that triggered the invalidation.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether any custom invalidation was performed. Must be true if the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref> for this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is to be invalidated.

#### Remarks

This should be used to perform any custom invalidation logic that cannot be described as a layout.

### <a id="osu_Framework_Graphics_Drawable_OnJoystickAxisMove_osu_Framework_Input_Events_JoystickAxisMoveEvent_"></a> OnJoystickAxisMove\(JoystickAxisMoveEvent\)

An event that occurs when a <xref href="osu.Framework.Input.JoystickAxis" data-throw-if-not-resolved="false"></xref> is moved.

```csharp
protected virtual bool OnJoystickAxisMove(JoystickAxisMoveEvent e)
```

#### Parameters

`e` [JoystickAxisMoveEvent](osu.Framework.Input.Events.JoystickAxisMoveEvent.md)

The <xref href="osu.Framework.Input.Events.JoystickAxisMoveEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnJoystickPress_osu_Framework_Input_Events_JoystickPressEvent_"></a> OnJoystickPress\(JoystickPressEvent\)

An event that occurs when a <xref href="osu.Framework.Input.JoystickButton" data-throw-if-not-resolved="false"></xref> is pressed.

```csharp
protected virtual bool OnJoystickPress(JoystickPressEvent e)
```

#### Parameters

`e` [JoystickPressEvent](osu.Framework.Input.Events.JoystickPressEvent.md)

The <xref href="osu.Framework.Input.Events.JoystickPressEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnJoystickRelease_osu_Framework_Input_Events_JoystickReleaseEvent_"></a> OnJoystickRelease\(JoystickReleaseEvent\)

An event that occurs when a <xref href="osu.Framework.Input.JoystickButton" data-throw-if-not-resolved="false"></xref> is released.

```csharp
protected virtual void OnJoystickRelease(JoystickReleaseEvent e)
```

#### Parameters

`e` [JoystickReleaseEvent](osu.Framework.Input.Events.JoystickReleaseEvent.md)

The <xref href="osu.Framework.Input.Events.JoystickReleaseEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnJoystickPress(osu.Framework.Input.Events.JoystickPressEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnKeyDown_osu_Framework_Input_Events_KeyDownEvent_"></a> OnKeyDown\(KeyDownEvent\)

An event that occurs when a <xref href="osuTK.Input.Key" data-throw-if-not-resolved="false"></xref> is pressed.

```csharp
protected virtual bool OnKeyDown(KeyDownEvent e)
```

#### Parameters

`e` [KeyDownEvent](osu.Framework.Input.Events.KeyDownEvent.md)

The <xref href="osu.Framework.Input.Events.KeyDownEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

#### Remarks

Repeat events can only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s that received a previous non-repeat <xref href="osu.Framework.Graphics.Drawable.OnKeyDown(osu.Framework.Input.Events.KeyDownEvent)" data-throw-if-not-resolved="false"></xref> invocation
which are still present in the input queue (via <xref href="osu.Framework.Graphics.Drawable.BuildNonPositionalInputQueue(System.Collections.Generic.List%7bosu.Framework.Graphics.Drawable%7d%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>) when the repeat occurs.

### <a id="osu_Framework_Graphics_Drawable_OnKeyUp_osu_Framework_Input_Events_KeyUpEvent_"></a> OnKeyUp\(KeyUpEvent\)

An event that occurs when a <xref href="osuTK.Input.Key" data-throw-if-not-resolved="false"></xref> is released.

```csharp
protected virtual void OnKeyUp(KeyUpEvent e)
```

#### Parameters

`e` [KeyUpEvent](osu.Framework.Input.Events.KeyUpEvent.md)

The <xref href="osu.Framework.Input.Events.KeyUpEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnKeyDown(osu.Framework.Input.Events.KeyDownEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnMidiDown_osu_Framework_Input_Events_MidiDownEvent_"></a> OnMidiDown\(MidiDownEvent\)

An event that occurs when a <xref href="osu.Framework.Input.MidiKey" data-throw-if-not-resolved="false"></xref> is pressed.

```csharp
protected virtual bool OnMidiDown(MidiDownEvent e)
```

#### Parameters

`e` [MidiDownEvent](osu.Framework.Input.Events.MidiDownEvent.md)

The <xref href="osu.Framework.Input.Events.MidiDownEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnMidiUp_osu_Framework_Input_Events_MidiUpEvent_"></a> OnMidiUp\(MidiUpEvent\)

An event that occurs when a <xref href="osu.Framework.Input.MidiKey" data-throw-if-not-resolved="false"></xref> is released.

```csharp
protected virtual void OnMidiUp(MidiUpEvent e)
```

#### Parameters

`e` [MidiUpEvent](osu.Framework.Input.Events.MidiUpEvent.md)

The <xref href="osu.Framework.Input.Events.MidiUpEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Input.Events.MidiDownEvent" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnMouseDown_osu_Framework_Input_Events_MouseDownEvent_"></a> OnMouseDown\(MouseDownEvent\)

An event that occurs when a <xref href="osuTK.Input.MouseButton" data-throw-if-not-resolved="false"></xref> is pressed on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnMouseDown(MouseDownEvent e)
```

#### Parameters

`e` [MouseDownEvent](osu.Framework.Input.Events.MouseDownEvent.md)

The <xref href="osu.Framework.Input.Events.MouseDownEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnMouseMove_osu_Framework_Input_Events_MouseMoveEvent_"></a> OnMouseMove\(MouseMoveEvent\)

An event that occurs every time the mouse is moved while hovering this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnMouseMove(MouseMoveEvent e)
```

#### Parameters

`e` [MouseMoveEvent](osu.Framework.Input.Events.MouseMoveEvent.md)

The <xref href="osu.Framework.Input.Events.MouseMoveEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnMouseUp_osu_Framework_Input_Events_MouseUpEvent_"></a> OnMouseUp\(MouseUpEvent\)

An event that occurs when a <xref href="osuTK.Input.MouseButton" data-throw-if-not-resolved="false"></xref> that was pressed on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> is released.

```csharp
protected virtual void OnMouseUp(MouseUpEvent e)
```

#### Parameters

`e` [MouseUpEvent](osu.Framework.Input.Events.MouseUpEvent.md)

The <xref href="osu.Framework.Input.Events.MouseUpEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnMouseDown(osu.Framework.Input.Events.MouseDownEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnScroll_osu_Framework_Input_Events_ScrollEvent_"></a> OnScroll\(ScrollEvent\)

An event that occurs when the mouse wheel is scrolled on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual bool OnScroll(ScrollEvent e)
```

#### Parameters

`e` [ScrollEvent](osu.Framework.Input.Events.ScrollEvent.md)

The <xref href="osu.Framework.Input.Events.ScrollEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnSizingChanged"></a> OnSizingChanged\(\)

Called whenever the <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> of this drawable is changed, or when the <xref href="osu.Framework.Graphics.Containers.Container%601.AutoSizeAxes" data-throw-if-not-resolved="false"></xref> are changed if this drawable is a <xref href="osu.Framework.Graphics.Containers.Container%601" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void OnSizingChanged()
```

### <a id="osu_Framework_Graphics_Drawable_OnTabletAuxiliaryButtonPress_osu_Framework_Input_Events_TabletAuxiliaryButtonPressEvent_"></a> OnTabletAuxiliaryButtonPress\(TabletAuxiliaryButtonPressEvent\)

An event that occurs when a <xref href="osu.Framework.Input.TabletAuxiliaryButton" data-throw-if-not-resolved="false"></xref> is pressed.

```csharp
protected virtual bool OnTabletAuxiliaryButtonPress(TabletAuxiliaryButtonPressEvent e)
```

#### Parameters

`e` [TabletAuxiliaryButtonPressEvent](osu.Framework.Input.Events.TabletAuxiliaryButtonPressEvent.md)

The <xref href="osu.Framework.Input.Events.TabletAuxiliaryButtonPressEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnTabletAuxiliaryButtonRelease_osu_Framework_Input_Events_TabletAuxiliaryButtonReleaseEvent_"></a> OnTabletAuxiliaryButtonRelease\(TabletAuxiliaryButtonReleaseEvent\)

An event that occurs when a <xref href="osu.Framework.Input.TabletAuxiliaryButton" data-throw-if-not-resolved="false"></xref> is released.

```csharp
protected virtual void OnTabletAuxiliaryButtonRelease(TabletAuxiliaryButtonReleaseEvent e)
```

#### Parameters

`e` [TabletAuxiliaryButtonReleaseEvent](osu.Framework.Input.Events.TabletAuxiliaryButtonReleaseEvent.md)

The <xref href="osu.Framework.Input.Events.TabletAuxiliaryButtonReleaseEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnTabletAuxiliaryButtonPress(osu.Framework.Input.Events.TabletAuxiliaryButtonPressEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnTabletPenButtonPress_osu_Framework_Input_Events_TabletPenButtonPressEvent_"></a> OnTabletPenButtonPress\(TabletPenButtonPressEvent\)

An event that occurs when a <xref href="osu.Framework.Input.TabletPenButton" data-throw-if-not-resolved="false"></xref> is pressed.

```csharp
protected virtual bool OnTabletPenButtonPress(TabletPenButtonPressEvent e)
```

#### Parameters

`e` [TabletPenButtonPressEvent](osu.Framework.Input.Events.TabletPenButtonPressEvent.md)

The <xref href="osu.Framework.Input.Events.TabletPenButtonPressEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnTabletPenButtonRelease_osu_Framework_Input_Events_TabletPenButtonReleaseEvent_"></a> OnTabletPenButtonRelease\(TabletPenButtonReleaseEvent\)

An event that occurs when a <xref href="osu.Framework.Input.TabletPenButton" data-throw-if-not-resolved="false"></xref> is released.

```csharp
protected virtual void OnTabletPenButtonRelease(TabletPenButtonReleaseEvent e)
```

#### Parameters

`e` [TabletPenButtonReleaseEvent](osu.Framework.Input.Events.TabletPenButtonReleaseEvent.md)

The <xref href="osu.Framework.Input.Events.TabletPenButtonReleaseEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnTabletPenButtonPress(osu.Framework.Input.Events.TabletPenButtonPressEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_OnTouchDown_osu_Framework_Input_Events_TouchDownEvent_"></a> OnTouchDown\(TouchDownEvent\)

An event that occurs when a <xref href="osu.Framework.Input.Touch" data-throw-if-not-resolved="false"></xref> is active.

```csharp
protected virtual bool OnTouchDown(TouchDownEvent e)
```

#### Parameters

`e` [TouchDownEvent](osu.Framework.Input.Events.TouchDownEvent.md)

The <xref href="osu.Framework.Input.Events.TouchDownEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Drawable_OnTouchMove_osu_Framework_Input_Events_TouchMoveEvent_"></a> OnTouchMove\(TouchMoveEvent\)

An event that occurs every time an active <xref href="osu.Framework.Input.Touch" data-throw-if-not-resolved="false"></xref> has moved while hovering this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected virtual void OnTouchMove(TouchMoveEvent e)
```

#### Parameters

`e` [TouchMoveEvent](osu.Framework.Input.Events.TouchMoveEvent.md)

The <xref href="osu.Framework.Input.Events.TouchMoveEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s that received a previous <xref href="osu.Framework.Graphics.Drawable.OnTouchDown(osu.Framework.Input.Events.TouchDownEvent)" data-throw-if-not-resolved="false"></xref> invocation from the source of this touch.
This will not occur if the touch has been activated then deactivated without moving from its initial position.

### <a id="osu_Framework_Graphics_Drawable_OnTouchUp_osu_Framework_Input_Events_TouchUpEvent_"></a> OnTouchUp\(TouchUpEvent\)

An event that occurs when a <xref href="osu.Framework.Input.Touch" data-throw-if-not-resolved="false"></xref> is not active.

```csharp
protected virtual void OnTouchUp(TouchUpEvent e)
```

#### Parameters

`e` [TouchUpEvent](osu.Framework.Input.Events.TouchUpEvent.md)

The <xref href="osu.Framework.Input.Events.TouchUpEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This is guaranteed to be invoked if <xref href="osu.Framework.Graphics.Drawable.OnTouchDown(osu.Framework.Input.Events.TouchDownEvent)" data-throw-if-not-resolved="false"></xref> was invoked.

### <a id="osu_Framework_Graphics_Drawable_ReceivePositionalInputAt_osuTK_Vector2_"></a> ReceivePositionalInputAt\(Vector2\)

Determines whether this drawable receives positional input when the mouse is at the
given screen-space position.

```csharp
public virtual bool ReceivePositionalInputAt(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

The screen-space position where input could be received.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if input is received at the given screen-space position.

### <a id="osu_Framework_Graphics_Drawable_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Graphics_Drawable_Schedule__1_System_Action___0____0_"></a> Schedule<T\>\(Action<T\>, T\)

```csharp
protected ScheduledDelegate Schedule<T>(Action<T> action, T data)
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

`data` T

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

#### Type Parameters

`T` 

### <a id="osu_Framework_Graphics_Drawable_Schedule_System_Action_"></a> Schedule\(Action\)

```csharp
protected ScheduledDelegate Schedule(Action action)
```

#### Parameters

`action` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [ScheduledDelegate](osu.Framework.Threading.ScheduledDelegate.md)

### <a id="osu_Framework_Graphics_Drawable_Show"></a> Show\(\)

Show sprite instantly.

```csharp
public virtual void Show()
```

### <a id="osu_Framework_Graphics_Drawable_ToLocalSpace_osuTK_Vector2_"></a> ToLocalSpace\(Vector2\)

Accepts a vector in screen coordinates and converts it to coordinates in local space.

```csharp
public Vector2 ToLocalSpace(Vector2 screenSpacePos)
```

#### Parameters

`screenSpacePos` Vector2

A vector in screen coordinates.

#### Returns

 Vector2

The vector in local coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToLocalSpace_osu_Framework_Graphics_Primitives_Quad_"></a> ToLocalSpace\(Quad\)

Accepts a quad in screen coordinates and converts it to coordinates in local space.

```csharp
public Quad ToLocalSpace(Quad screenSpaceQuad)
```

#### Parameters

`screenSpaceQuad` [Quad](osu.Framework.Graphics.Primitives.Quad.md)

A quad in screen coordinates.

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

The quad in local coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToParentSpace_osuTK_Vector2_"></a> ToParentSpace\(Vector2\)

Accepts a vector in local coordinates and converts it to coordinates in Parent's space.

```csharp
public Vector2 ToParentSpace(Vector2 input)
```

#### Parameters

`input` Vector2

A vector in local coordinates.

#### Returns

 Vector2

The vector in Parent's coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToParentSpace_osu_Framework_Graphics_Primitives_RectangleF_"></a> ToParentSpace\(RectangleF\)

Accepts a rectangle in local coordinates and converts it to a quad in Parent's space.

```csharp
public Quad ToParentSpace(RectangleF input)
```

#### Parameters

`input` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A rectangle in local coordinates.

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

The quad in Parent's coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToScreenSpace_osuTK_Vector2_"></a> ToScreenSpace\(Vector2\)

Accepts a vector in local coordinates and converts it to coordinates in screen space.

```csharp
public Vector2 ToScreenSpace(Vector2 input)
```

#### Parameters

`input` Vector2

A vector in local coordinates.

#### Returns

 Vector2

The vector in screen coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToScreenSpace_osu_Framework_Graphics_Primitives_RectangleF_"></a> ToScreenSpace\(RectangleF\)

Accepts a rectangle in local coordinates and converts it to a quad in screen space.

```csharp
public Quad ToScreenSpace(RectangleF input)
```

#### Parameters

`input` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A rectangle in local coordinates.

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

The quad in screen coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToSpaceOfOtherDrawable_osuTK_Vector2_osu_Framework_Graphics_IDrawable_"></a> ToSpaceOfOtherDrawable\(Vector2, IDrawable\)

Accepts a vector in local coordinates and converts it to coordinates in another Drawable's space.

```csharp
public Vector2 ToSpaceOfOtherDrawable(Vector2 input, IDrawable other)
```

#### Parameters

`input` Vector2

A vector in local coordinates.

`other` [IDrawable](osu.Framework.Graphics.IDrawable.md)

The drawable in which space we want to transform the vector to.

#### Returns

 Vector2

The vector in other's coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToSpaceOfOtherDrawable_osu_Framework_Graphics_Primitives_RectangleF_osu_Framework_Graphics_IDrawable_"></a> ToSpaceOfOtherDrawable\(RectangleF, IDrawable\)

Accepts a rectangle in local coordinates and converts it to coordinates in another Drawable's space.

```csharp
public Quad ToSpaceOfOtherDrawable(RectangleF input, IDrawable other)
```

#### Parameters

`input` [RectangleF](osu.Framework.Graphics.Primitives.RectangleF.md)

A rectangle in local coordinates.

`other` [IDrawable](osu.Framework.Graphics.IDrawable.md)

The drawable in which space we want to transform the rectangle to.

#### Returns

 [Quad](osu.Framework.Graphics.Primitives.Quad.md)

The rectangle in other's coordinates.

### <a id="osu_Framework_Graphics_Drawable_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

### <a id="osu_Framework_Graphics_Drawable_TriggerClick"></a> TriggerClick\(\)

Triggers a left click event for this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool TriggerClick()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the click event is handled.

### <a id="osu_Framework_Graphics_Drawable_TriggerEvent_osu_Framework_Input_Events_UIEvent_"></a> TriggerEvent\(UIEvent\)

Trigger a UI event with <xref href="osu.Framework.Input.Events.UIEvent.Target" data-throw-if-not-resolved="false"></xref> set to this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool TriggerEvent(UIEvent e)
```

#### Parameters

`e` [UIEvent](osu.Framework.Input.Events.UIEvent.md)

The event. Its <xref href="osu.Framework.Input.Events.UIEvent.Target" data-throw-if-not-resolved="false"></xref> will be modified.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

The result of event handler.

### <a id="osu_Framework_Graphics_Drawable_Update"></a> Update\(\)

Performs a once-per-frame update specific to this Drawable. A more elegant alternative to
<xref href="osu.Framework.Graphics.Drawable.OnUpdate" data-throw-if-not-resolved="false"></xref> when deriving from <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Note, that this
method is always called before Drawables further down the scene graph are updated.

```csharp
protected virtual void Update()
```

### <a id="osu_Framework_Graphics_Drawable_UpdateSubTree"></a> UpdateSubTree\(\)

Updates this Drawable and all Drawables further down the scene graph.
Called once every frame.

```csharp
public virtual bool UpdateSubTree()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

False if the drawable should not be updated.

### <a id="osu_Framework_Graphics_Drawable_UpdateSubTreeMasking"></a> UpdateSubTreeMasking\(\)

Updates all masking calculations for this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
This occurs post-<xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref> to ensure that all <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> updates have taken place.

```csharp
public virtual bool UpdateSubTreeMasking()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether masking calculations have taken place.

### <a id="osu_Framework_Graphics_Drawable_WithEffect__1_osu_Framework_Graphics_Effects_IEffect___0__System_Action___0__"></a> WithEffect<T\>\(IEffect<T\>, Action<T\>\)

Returns the drawable created by applying the given effect to this drawable. This method may add this drawable to a container.
If this drawable should be the child of another container, make sure to add the created drawable to the container instead of this drawable.

```csharp
public T WithEffect<T>(IEffect<T> effect, Action<T> initializationAction = null) where T : Drawable
```

#### Parameters

`effect` [IEffect](osu.Framework.Graphics.Effects.IEffect\-1.md)<T\>

The effect to apply to this drawable.

`initializationAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The action that should get called to initialize the created drawable before it is returned.

#### Returns

 T

The drawable created by applying the given effect to this drawable.

#### Type Parameters

`T` 

The type of the drawable that results from applying the given effect.

### <a id="osu_Framework_Graphics_Drawable_OnLoadComplete"></a> OnLoadComplete

This event is fired after the <xref href="osu.Framework.Graphics.Drawable.LoadComplete" data-throw-if-not-resolved="false"></xref> method is called.
It should be used when a simple action should be performed
when the Drawable is loaded which does not warrant overriding the Drawable.
This event is automatically cleared after being invoked.

```csharp
public event Action<Drawable> OnLoadComplete
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Drawable_OnUpdate"></a> OnUpdate

This event is fired after the <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref> method is called at the end of
<xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref>. It should be used when a simple action should be performed
at the end of every update call which does not warrant overriding the Drawable.

```csharp
public event Action<Drawable> OnUpdate
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

