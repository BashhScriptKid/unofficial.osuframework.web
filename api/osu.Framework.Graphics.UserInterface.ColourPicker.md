# <a id="osu_Framework_Graphics_UserInterface_ColourPicker"></a> Class ColourPicker

Namespace: [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)  
Assembly: osu.Framework.dll  

A group of controls to be used for selecting a colour.
Allows both for mouse-interactive input (via <xref href="osu.Framework.Graphics.UserInterface.HSVColourPicker" data-throw-if-not-resolved="false"></xref>) and textual input (via <xref href="osu.Framework.Graphics.UserInterface.HexColourPicker" data-throw-if-not-resolved="false"></xref>).

```csharp
public abstract class ColourPicker : CompositeDrawable, IDependencyInjectionCandidate, IDisposable, IDrawable, ITransformable, IHasCurrentValue<Colour4>, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedDependencyActivator, ISourceGeneratedHandleInputCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md) ← 
[ColourPicker](osu.Framework.Graphics.UserInterface.ColourPicker.md)

#### Derived

[BasicColourPicker](osu.Framework.Graphics.UserInterface.BasicColourPicker.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[IHasCurrentValue<Colour4\>](osu.Framework.Graphics.UserInterface.IHasCurrentValue\-1.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

#### Inherited Members

[CompositeDrawable.CreateChildDependencies\(IReadOnlyDependencyContainer\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CreateChildDependencies\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[CompositeDrawable.Dependencies](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Dependencies), 
[CompositeDrawable.InjectDependencies\(IReadOnlyDependencyContainer\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InjectDependencies\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[CompositeDrawable.LoadComponentAsync<TLoadable\>\(TLoadable, Action<TLoadable\>, CancellationToken, Scheduler\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponentAsync\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_System\_Threading\_CancellationToken\_osu\_Framework\_Threading\_Scheduler\_), 
[CompositeDrawable.LoadComponent<TLoadable\>\(TLoadable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponent\_\_1\_\_\_0\_), 
[CompositeDrawable.LoadComponentsAsync<TLoadable\>\(IEnumerable<TLoadable\>, Action<IEnumerable<TLoadable\>\>, CancellationToken, Scheduler\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponentsAsync\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_System\_Threading\_CancellationToken\_osu\_Framework\_Threading\_Scheduler\_), 
[CompositeDrawable.LoadComponents<TLoadable\>\(IEnumerable<TLoadable\>\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadComponents\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[CompositeDrawable.LoadAsyncComplete\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_LoadAsyncComplete), 
[CompositeDrawable.Dispose\(bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Dispose\_System\_Boolean\_), 
[CompositeDrawable.InternalChild](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InternalChild), 
[CompositeDrawable.Compare\(Drawable, Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Compare\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.CompareReverseChildID\(Drawable, Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CompareReverseChildID\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.InternalChildren](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InternalChildren), 
[CompositeDrawable.InternalChildrenEnumerable](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_InternalChildrenEnumerable), 
[CompositeDrawable.AliveInternalChildren](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AliveInternalChildren), 
[CompositeDrawable.IndexOfInternal\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_IndexOfInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.ContainsInternal\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ContainsInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.RemoveInternal\(Drawable, bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RemoveInternal\_osu\_Framework\_Graphics\_Drawable\_System\_Boolean\_), 
[CompositeDrawable.ClearInternal\(bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ClearInternal\_System\_Boolean\_), 
[CompositeDrawable.AddInternal\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AddInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.AddRangeInternal\(IEnumerable<Drawable\>\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AddRangeInternal\_System\_Collections\_Generic\_IEnumerable\_osu\_Framework\_Graphics\_Drawable\_\_), 
[CompositeDrawable.ChangeInternalChildDepth\(Drawable, float\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChangeInternalChildDepth\_osu\_Framework\_Graphics\_Drawable\_System\_Single\_), 
[CompositeDrawable.SortInternal\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_SortInternal), 
[CompositeDrawable.SchedulerAfterChildren](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_SchedulerAfterChildren), 
[CompositeDrawable.UpdateChildrenLife\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateChildrenLife), 
[CompositeDrawable.CheckChildrenLife\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CheckChildrenLife), 
[CompositeDrawable.MakeChildAlive\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_MakeChildAlive\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.MakeChildDead\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_MakeChildDead\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.RequiresChildrenUpdate](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RequiresChildrenUpdate), 
[CompositeDrawable.UpdateSubTree\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateSubTree), 
[CompositeDrawable.UpdateSubTreeMasking\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateSubTreeMasking), 
[CompositeDrawable.ComputeIsMaskedAway\(RectangleF\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ComputeIsMaskedAway\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[CompositeDrawable.ComputeChildMaskingBounds\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ComputeChildMaskingBounds), 
[CompositeDrawable.ChildMaskingBounds](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChildMaskingBounds), 
[CompositeDrawable.UpdateAfterChildrenLife\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateAfterChildrenLife), 
[CompositeDrawable.UpdateAfterChildren\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateAfterChildren), 
[CompositeDrawable.UpdateAfterAutoSize\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_UpdateAfterAutoSize), 
[CompositeDrawable.OnInvalidate\(Invalidation, InvalidationSource\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_OnInvalidate\_osu\_Framework\_Graphics\_Invalidation\_osu\_Framework\_Layout\_InvalidationSource\_), 
[CompositeDrawable.CreateDrawNode\(\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CreateDrawNode), 
[CompositeDrawable.ForceLocalVertexBatch](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ForceLocalVertexBatch), 
[CompositeDrawable.CanBeFlattened](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CanBeFlattened), 
[CompositeDrawable.RemoveCompletedTransforms](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RemoveCompletedTransforms), 
[CompositeDrawable.ApplyTransformsAt\(double, bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ApplyTransformsAt\_System\_Double\_System\_Boolean\_), 
[CompositeDrawable.ClearTransformsAfter\(double, bool, string\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ClearTransformsAfter\_System\_Double\_System\_Boolean\_System\_String\_), 
[CompositeDrawable.ScheduleAfterChildren<T\>\(Action<T\>, T\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ScheduleAfterChildren\_\_1\_System\_Action\_\_\_0\_\_\_\_0\_), 
[CompositeDrawable.ScheduleAfterChildren\(Action\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ScheduleAfterChildren\_System\_Action\_), 
[CompositeDrawable.BeginAbsoluteSequence\(double, bool\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BeginAbsoluteSequence\_System\_Double\_System\_Boolean\_), 
[CompositeDrawable.FinishTransforms\(bool, string\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_FinishTransforms\_System\_Boolean\_System\_String\_), 
[CompositeDrawable.FadeEdgeEffectTo\(float, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_FadeEdgeEffectTo\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.FadeEdgeEffectTo\(Color4, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_FadeEdgeEffectTo\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.TweenEdgeEffectTo\(EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_TweenEdgeEffectTo\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.Contains\(Vector2\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Contains\_osuTK\_Vector2\_), 
[CompositeDrawable.ShouldBeConsideredForInput\(Drawable\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ShouldBeConsideredForInput\_osu\_Framework\_Graphics\_Drawable\_), 
[CompositeDrawable.ReceivePositionalInputAtSubTree\(Vector2\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ReceivePositionalInputAtSubTree\_osuTK\_Vector2\_), 
[CompositeDrawable.Masking](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Masking), 
[CompositeDrawable.MaskingSmoothness](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_MaskingSmoothness), 
[CompositeDrawable.CornerRadius](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CornerRadius), 
[CompositeDrawable.CornerExponent](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_CornerExponent), 
[CompositeDrawable.BorderThickness](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BorderThickness), 
[CompositeDrawable.BorderColour](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BorderColour), 
[CompositeDrawable.EdgeEffect](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_EdgeEffect), 
[CompositeDrawable.BoundingBox](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_BoundingBox), 
[CompositeDrawable.Padding](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Padding), 
[CompositeDrawable.ChildSize](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChildSize), 
[CompositeDrawable.ChildOffset](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_ChildOffset), 
[CompositeDrawable.RelativeChildSize](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeChildSize), 
[CompositeDrawable.RelativeChildOffset](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeChildOffset), 
[CompositeDrawable.RelativeToAbsoluteFactor](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeToAbsoluteFactor), 
[CompositeDrawable.TransformRelativeChildSizeTo\(Vector2, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_TransformRelativeChildSizeTo\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.TransformRelativeChildOffsetTo\(Vector2, double, Easing\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_TransformRelativeChildOffsetTo\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[CompositeDrawable.RelativeSizeAxes](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RelativeSizeAxes), 
[CompositeDrawable.AutoSizeAxes](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AutoSizeAxes), 
[CompositeDrawable.AutoSizeDuration](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AutoSizeDuration), 
[CompositeDrawable.AutoSizeEasing](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_AutoSizeEasing), 
[CompositeDrawable.Width](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Width), 
[CompositeDrawable.Height](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Height), 
[CompositeDrawable.Size](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_Size), 
[CompositeDrawable.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.CompositeDrawable.md\#osu\_Framework\_Graphics\_Containers\_CompositeDrawable\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[Drawable.Dispose\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Dispose), 
[Drawable.IsDisposed](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsDisposed), 
[Drawable.Dispose\(bool\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Dispose\_System\_Boolean\_), 
[Drawable.DisposeOnDeathRemoval](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DisposeOnDeathRemoval), 
[Drawable.IsLoaded](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsLoaded), 
[Drawable.LoadState](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LoadState), 
[Drawable.InjectDependencies\(IReadOnlyDependencyContainer\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_InjectDependencies\_osu\_Framework\_Allocation\_IReadOnlyDependencyContainer\_), 
[Drawable.LoadAsyncComplete\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LoadAsyncComplete), 
[Drawable.LoadComplete\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LoadComplete), 
[Drawable.IsAlive](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsAlive), 
[Drawable.Depth](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Depth), 
[Drawable.OnUpdate](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnUpdate), 
[Drawable.OnLoadComplete](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnLoadComplete), 
[Drawable.Scheduler](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Scheduler), 
[Drawable.UpdateSubTree\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_UpdateSubTree), 
[Drawable.ComputeMaskingBounds\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ComputeMaskingBounds), 
[Drawable.UpdateSubTreeMasking\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_UpdateSubTreeMasking), 
[Drawable.ComputeIsMaskedAway\(RectangleF\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ComputeIsMaskedAway\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[Drawable.Update\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Update), 
[Drawable.Position](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Position), 
[Drawable.X](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_X), 
[Drawable.Y](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Y), 
[Drawable.RelativePositionAxes](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativePositionAxes), 
[Drawable.DrawPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawPosition), 
[Drawable.Size](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Size), 
[Drawable.Width](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Width), 
[Drawable.Height](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Height), 
[Drawable.RelativeSizeAxes](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativeSizeAxes), 
[Drawable.DrawSize](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawSize), 
[Drawable.DrawWidth](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawWidth), 
[Drawable.DrawHeight](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawHeight), 
[Drawable.Margin](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Margin), 
[Drawable.LayoutSize](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LayoutSize), 
[Drawable.DrawRectangle](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawRectangle), 
[Drawable.LayoutRectangle](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LayoutRectangle), 
[Drawable.ApplyRelativeAxes\(Axes, Vector2, FillMode\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ApplyRelativeAxes\_osu\_Framework\_Graphics\_Axes\_osuTK\_Vector2\_osu\_Framework\_Graphics\_FillMode\_), 
[Drawable.BypassAutoSizeAxes](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_BypassAutoSizeAxes), 
[Drawable.BoundingBox](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_BoundingBox), 
[Drawable.OnSizingChanged\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnSizingChanged), 
[Drawable.Scale](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Scale), 
[Drawable.FillAspectRatio](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_FillAspectRatio), 
[Drawable.FillMode](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_FillMode), 
[Drawable.DrawScale](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawScale), 
[Drawable.Shear](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Shear), 
[Drawable.Rotation](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Rotation), 
[Drawable.Origin](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Origin), 
[Drawable.RelativeOriginPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativeOriginPosition), 
[Drawable.OriginPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OriginPosition), 
[Drawable.Anchor](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Anchor), 
[Drawable.RelativeAnchorPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RelativeAnchorPosition), 
[Drawable.AnchorPosition](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AnchorPosition), 
[Drawable.Colour](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Colour), 
[Drawable.Alpha](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Alpha), 
[Drawable.IsPresent](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsPresent), 
[Drawable.AlwaysPresent](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AlwaysPresent), 
[Drawable.Blending](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Blending), 
[Drawable.Clock](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Clock), 
[Drawable.ProcessCustomClock](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ProcessCustomClock), 
[Drawable.LifetimeStart](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LifetimeStart), 
[Drawable.LifetimeEnd](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_LifetimeEnd), 
[Drawable.ShouldBeAlive](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ShouldBeAlive), 
[Drawable.RemoveWhenNotAlive](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RemoveWhenNotAlive), 
[Drawable.GetContainingInputManager\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_GetContainingInputManager), 
[Drawable.GetContainingFocusManager\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_GetContainingFocusManager), 
[Drawable.Parent](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Parent), 
[Drawable.HasProxy](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HasProxy), 
[Drawable.IsProxy](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsProxy), 
[Drawable.CreateProxy\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_CreateProxy), 
[Drawable.ComputeScreenSpaceDrawQuad\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ComputeScreenSpaceDrawQuad), 
[Drawable.ScreenSpaceDrawQuad](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ScreenSpaceDrawQuad), 
[Drawable.DrawInfo](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawInfo), 
[Drawable.DrawColourInfo](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DrawColourInfo), 
[Drawable.AddLayout\(LayoutMember\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AddLayout\_osu\_Framework\_Layout\_LayoutMember\_), 
[Drawable.InvalidationID](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_InvalidationID), 
[Drawable.Invalidate\(Invalidation, InvalidationSource\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Invalidate\_osu\_Framework\_Graphics\_Invalidation\_osu\_Framework\_Layout\_InvalidationSource\_), 
[Drawable.OnInvalidate\(Invalidation, InvalidationSource\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnInvalidate\_osu\_Framework\_Graphics\_Invalidation\_osu\_Framework\_Layout\_InvalidationSource\_), 
[Drawable.InvalidationFromParentSize](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_InvalidationFromParentSize), 
[Drawable.CreateDrawNode\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_CreateDrawNode), 
[Drawable.ToSpaceOfOtherDrawable\(Vector2, IDrawable\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToSpaceOfOtherDrawable\_osuTK\_Vector2\_osu\_Framework\_Graphics\_IDrawable\_), 
[Drawable.ToSpaceOfOtherDrawable\(RectangleF, IDrawable\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToSpaceOfOtherDrawable\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_osu\_Framework\_Graphics\_IDrawable\_), 
[Drawable.ToParentSpace\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToParentSpace\_osuTK\_Vector2\_), 
[Drawable.ToParentSpace\(RectangleF\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToParentSpace\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[Drawable.ToScreenSpace\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToScreenSpace\_osuTK\_Vector2\_), 
[Drawable.ToScreenSpace\(RectangleF\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToScreenSpace\_osu\_Framework\_Graphics\_Primitives\_RectangleF\_), 
[Drawable.ToLocalSpace\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToLocalSpace\_osuTK\_Vector2\_), 
[Drawable.ToLocalSpace\(Quad\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToLocalSpace\_osu\_Framework\_Graphics\_Primitives\_Quad\_), 
[Drawable.Handle\(UIEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Handle\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[Drawable.TriggerEvent\(UIEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_TriggerEvent\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[Drawable.TriggerClick\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_TriggerClick), 
[Drawable.OnMouseMove\(MouseMoveEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMouseMove\_osu\_Framework\_Input\_Events\_MouseMoveEvent\_), 
[Drawable.OnHover\(HoverEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnHover\_osu\_Framework\_Input\_Events\_HoverEvent\_), 
[Drawable.OnHoverLost\(HoverLostEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnHoverLost\_osu\_Framework\_Input\_Events\_HoverLostEvent\_), 
[Drawable.OnMouseDown\(MouseDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMouseDown\_osu\_Framework\_Input\_Events\_MouseDownEvent\_), 
[Drawable.OnMouseUp\(MouseUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMouseUp\_osu\_Framework\_Input\_Events\_MouseUpEvent\_), 
[Drawable.OnClick\(ClickEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnClick\_osu\_Framework\_Input\_Events\_ClickEvent\_), 
[Drawable.OnDoubleClick\(DoubleClickEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDoubleClick\_osu\_Framework\_Input\_Events\_DoubleClickEvent\_), 
[Drawable.OnDragStart\(DragStartEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDragStart\_osu\_Framework\_Input\_Events\_DragStartEvent\_), 
[Drawable.OnDrag\(DragEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDrag\_osu\_Framework\_Input\_Events\_DragEvent\_), 
[Drawable.OnDragEnd\(DragEndEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnDragEnd\_osu\_Framework\_Input\_Events\_DragEndEvent\_), 
[Drawable.OnScroll\(ScrollEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnScroll\_osu\_Framework\_Input\_Events\_ScrollEvent\_), 
[Drawable.OnFocus\(FocusEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnFocus\_osu\_Framework\_Input\_Events\_FocusEvent\_), 
[Drawable.OnFocusLost\(FocusLostEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnFocusLost\_osu\_Framework\_Input\_Events\_FocusLostEvent\_), 
[Drawable.OnKeyDown\(KeyDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnKeyDown\_osu\_Framework\_Input\_Events\_KeyDownEvent\_), 
[Drawable.OnKeyUp\(KeyUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnKeyUp\_osu\_Framework\_Input\_Events\_KeyUpEvent\_), 
[Drawable.OnTouchDown\(TouchDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTouchDown\_osu\_Framework\_Input\_Events\_TouchDownEvent\_), 
[Drawable.OnTouchMove\(TouchMoveEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTouchMove\_osu\_Framework\_Input\_Events\_TouchMoveEvent\_), 
[Drawable.OnTouchUp\(TouchUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTouchUp\_osu\_Framework\_Input\_Events\_TouchUpEvent\_), 
[Drawable.OnJoystickPress\(JoystickPressEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnJoystickPress\_osu\_Framework\_Input\_Events\_JoystickPressEvent\_), 
[Drawable.OnJoystickRelease\(JoystickReleaseEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnJoystickRelease\_osu\_Framework\_Input\_Events\_JoystickReleaseEvent\_), 
[Drawable.OnJoystickAxisMove\(JoystickAxisMoveEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnJoystickAxisMove\_osu\_Framework\_Input\_Events\_JoystickAxisMoveEvent\_), 
[Drawable.OnMidiDown\(MidiDownEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMidiDown\_osu\_Framework\_Input\_Events\_MidiDownEvent\_), 
[Drawable.OnMidiUp\(MidiUpEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnMidiUp\_osu\_Framework\_Input\_Events\_MidiUpEvent\_), 
[Drawable.OnTabletPenButtonPress\(TabletPenButtonPressEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletPenButtonPress\_osu\_Framework\_Input\_Events\_TabletPenButtonPressEvent\_), 
[Drawable.OnTabletPenButtonRelease\(TabletPenButtonReleaseEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletPenButtonRelease\_osu\_Framework\_Input\_Events\_TabletPenButtonReleaseEvent\_), 
[Drawable.OnTabletAuxiliaryButtonPress\(TabletAuxiliaryButtonPressEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletAuxiliaryButtonPress\_osu\_Framework\_Input\_Events\_TabletAuxiliaryButtonPressEvent\_), 
[Drawable.OnTabletAuxiliaryButtonRelease\(TabletAuxiliaryButtonReleaseEvent\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_OnTabletAuxiliaryButtonRelease\_osu\_Framework\_Input\_Events\_TabletAuxiliaryButtonReleaseEvent\_), 
[Drawable.HandleNonPositionalInput](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HandleNonPositionalInput), 
[Drawable.HandlePositionalInput](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HandlePositionalInput), 
[Drawable.HasFocus](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_HasFocus), 
[Drawable.RequestsFocus](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RequestsFocus), 
[Drawable.AcceptsFocus](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_AcceptsFocus), 
[Drawable.ChangeFocusOnClick](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ChangeFocusOnClick), 
[Drawable.IsHovered](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsHovered), 
[Drawable.IsDragged](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_IsDragged), 
[Drawable.ReceivePositionalInputAt\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ReceivePositionalInputAt\_osuTK\_Vector2\_), 
[Drawable.Contains\(Vector2\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Contains\_osuTK\_Vector2\_), 
[Drawable.PropagateNonPositionalInputSubTree](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_PropagateNonPositionalInputSubTree), 
[Drawable.PropagatePositionalInputSubTree](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_PropagatePositionalInputSubTree), 
[Drawable.DragBlocksClick](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_DragBlocksClick), 
[Drawable.Schedule<T\>\(Action<T\>, T\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Schedule\_\_1\_System\_Action\_\_\_0\_\_\_\_0\_), 
[Drawable.Schedule\(Action\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Schedule\_System\_Action\_), 
[Drawable.Expire\(bool\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Expire\_System\_Boolean\_), 
[Drawable.Hide\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Hide), 
[Drawable.Show\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Show), 
[Drawable.WithEffect<T\>\(IEffect<T\>, Action<T\>\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_WithEffect\_\_1\_osu\_Framework\_Graphics\_Effects\_IEffect\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[Drawable.Name](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Name), 
[Drawable.ToString\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_ToString), 
[Drawable.Empty\(\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_Empty), 
[Drawable.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Drawable.md\#osu\_Framework\_Graphics\_Drawable\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
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

[TransformableExtensions.Animate<ColourPicker\>\(ColourPicker, params TransformSequence<ColourPicker\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<ColourPicker\>\(ColourPicker?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<ColourPicker\>\(ColourPicker, double, params TransformSequence<ColourPicker\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<ColourPicker\>\(ColourPicker\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<ColourPicker\>\(ColourPicker, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<ColourPicker, TEasing\>\(ColourPicker, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<ColourPicker\>\(ColourPicker, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<ColourPicker, TEasing\>\(ColourPicker, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<ColourPicker\>\(ColourPicker, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<ColourPicker, TEasing\>\(ColourPicker, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<ColourPicker\>\(ColourPicker, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<ColourPicker, TEasing\>\(ColourPicker, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<ColourPicker\>\(ColourPicker, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<ColourPicker, TEasing\>\(ColourPicker, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<ColourPicker\>\(ColourPicker, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<ColourPicker, TEasing\>\(ColourPicker, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ColourPicker\>\(ColourPicker\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<ColourPicker\>\(ColourPicker\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ColourPicker\>\(ColourPicker\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<ColourPicker\>\(ColourPicker, double, int, params TransformSequence<ColourPicker\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ColourPicker\>\(ColourPicker, double, params TransformSequence<ColourPicker\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ColourPicker\>\(ColourPicker, params TransformSequence<ColourPicker\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ColourPicker\>\(ColourPicker, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<ColourPicker, TValue\>\(ColourPicker, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<ColourPicker, TEasing, TValue\>\(ColourPicker, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<ColourPicker\>\(ColourPicker, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<ColourPicker\>\(ColourPicker, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<ColourPicker, TEasing\>\(ColourPicker, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<ColourPicker, TEasing\>\(ColourPicker, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<ColourPicker\>\(ColourPicker, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<ColourPicker, TEasing\>\(ColourPicker, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, ColourPicker\>\(ColourPicker, Transform<TValue, DefaultEasingFunction, ColourPicker\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, ColourPicker\>\(ColourPicker, Transform<TValue, TEasing, ColourPicker\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<ColourPicker\>\(ColourPicker, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<ColourPicker, TEasing\>\(ColourPicker, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<ColourPicker\>\(ColourPicker, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<ColourPicker\>\(ColourPicker, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<ColourPicker, TEasing\>\(ColourPicker, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<ColourPicker, TEasing\>\(ColourPicker, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<ColourPicker\>\(ColourPicker, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<ColourPicker\>\(ColourPicker, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<ColourPicker, TValue\>\(ColourPicker, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<ColourPicker, TValue, TEasing\>\(ColourPicker, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<ColourPicker, TValue\>\(ColourPicker, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<ColourPicker, TValue, TEasing\>\(ColourPicker, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<ColourPicker\>\(ColourPicker, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[DrawableExtensions.With<ColourPicker\>\(ColourPicker, Action<ColourPicker\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<ColourPicker, TChild\>\(ColourPicker, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ColourPicker, TChild\>\(ColourPicker, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ColourPicker, TChild\>\(ColourPicker, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ColourPicker\>\(ColourPicker\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker__ctor"></a> ColourPicker\(\)

```csharp
protected ColourPicker()
```

## Properties

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker_Current"></a> Current

Gets or sets the <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> that provides the current value.

```csharp
public Bindable<Colour4> Current { get; set; }
```

#### Property Value

 [Bindable](osu.Framework.Bindables.Bindable\-1.md)<[Colour4](osu.Framework.Graphics.Colour4.md)\>

#### Remarks

A provided <xref href="osu.Framework.Bindables.Bindable%601" data-throw-if-not-resolved="false"></xref> will be bound to, rather than be stored internally.

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker_IsPresent"></a> IsPresent

Determines whether this Drawable is present based on its <xref href="osu.Framework.Graphics.Drawable.Alpha" data-throw-if-not-resolved="false"></xref> value.
Can be forced always on with <xref href="osu.Framework.Graphics.Drawable.AlwaysPresent" data-throw-if-not-resolved="false"></xref>.

```csharp
public override bool IsPresent { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker_CreateHSVColourPicker"></a> CreateHSVColourPicker\(\)

Creates the control that allows for interactively specifying the target colour, using the hue-saturation-value colour model.

```csharp
protected abstract HSVColourPicker CreateHSVColourPicker()
```

#### Returns

 [HSVColourPicker](osu.Framework.Graphics.UserInterface.HSVColourPicker.md)

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker_CreateHexColourPicker"></a> CreateHexColourPicker\(\)

Creates the control that allows for specifying the target colour using a hex code.

```csharp
protected abstract HexColourPicker CreateHexColourPicker()
```

#### Returns

 [HexColourPicker](osu.Framework.Graphics.UserInterface.HexColourPicker.md)

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker_LoadComplete"></a> LoadComplete\(\)

Invoked after this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> has finished loading.

```csharp
protected override void LoadComplete()
```

#### Remarks

This method is invoked on the update thread inside this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_UserInterface_ColourPicker_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

