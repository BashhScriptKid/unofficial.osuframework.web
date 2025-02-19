# <a id="osu_Framework_Input_InputManager"></a> Class InputManager

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class InputManager : Container, IDependencyInjectionCandidate, IDisposable, IContainerEnumerable<Drawable>, IContainerCollection<Drawable>, IContainer, ICollection<Drawable>, IReadOnlyList<Drawable>, IReadOnlyCollection<Drawable>, IEnumerable<Drawable>, IEnumerable, IInputStateChangeHandler, IFocusManager, IDrawable, ITransformable, ISourceGeneratedDependencyActivator, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedHandleInputCache
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md) ← 
[Container<Drawable\>](osu.Framework.Graphics.Containers.Container\-1.md) ← 
[Container](osu.Framework.Graphics.Containers.Container.md) ← 
[InputManager](osu.Framework.Input.InputManager.md)

#### Derived

[CustomInputManager](osu.Framework.Input.CustomInputManager.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IContainerEnumerable<Drawable\>](osu.Framework.Graphics.Containers.IContainerEnumerable\-1.md), 
[IContainerCollection<Drawable\>](osu.Framework.Graphics.Containers.IContainerCollection\-1.md), 
[IContainer](osu.Framework.Graphics.Containers.IContainer.md), 
[ICollection<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md), 
[IFocusManager](osu.Framework.Input.IFocusManager.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

#### Inherited Members

[Container.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.Container.md\#osu\_Framework\_Graphics\_Containers\_Container\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
[Container<Drawable\>.Content](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Content), 
[Container<Drawable\>.Children](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Children), 
[Container<Drawable\>.AliveChildren](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AliveChildren), 
[Container<Drawable\>.this\[int\]](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Item\_System\_Int32\_), 
[Container<Drawable\>.Count](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Count), 
[Container<Drawable\>.IsReadOnly](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_IsReadOnly), 
[Container<Drawable\>.CopyTo\(Drawable\[\], int\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CopyTo\_\_0\_\_\_System\_Int32\_), 
[Container<Drawable\>.GetEnumerator\(\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_GetEnumerator), 
[Container<Drawable\>.ChildrenEnumerable](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ChildrenEnumerable), 
[Container<Drawable\>.Child](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Child), 
[Container<Drawable\>.IndexOf\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_IndexOf\_\_0\_), 
[Container<Drawable\>.Contains\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Contains\_\_0\_), 
[Container<Drawable\>.Add\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Add\_\_0\_), 
[Container<Drawable\>.AddRange\(IEnumerable<Drawable\>\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AddRange\_System\_Collections\_Generic\_IEnumerable\_\_0\_\_), 
[Container<Drawable\>.AddInternal\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AddInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[Container<Drawable\>.Remove\(Drawable, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Remove\_\_0\_System\_Boolean\_), 
[Container<Drawable\>.RemoveAll\(Predicate<Drawable\>, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveAll\_System\_Predicate\_\_0\_\_System\_Boolean\_), 
[Container<Drawable\>.RemoveRange\(IEnumerable<Drawable\>, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveRange\_System\_Collections\_Generic\_IEnumerable\_\_0\_\_System\_Boolean\_), 
[Container<Drawable\>.RemoveInternal\(Drawable, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveInternal\_osu\_Framework\_Graphics\_Drawable\_System\_Boolean\_), 
[Container<Drawable\>.Clear\(\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Clear), 
[Container<Drawable\>.Clear\(bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Clear\_System\_Boolean\_), 
[Container<Drawable\>.ClearInternal\(bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ClearInternal\_System\_Boolean\_), 
[Container<Drawable\>.ChangeChildDepth\(Drawable, float\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ChangeChildDepth\_\_0\_System\_Single\_), 
[Container<Drawable\>.Masking](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Masking), 
[Container<Drawable\>.MaskingSmoothness](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_MaskingSmoothness), 
[Container<Drawable\>.CornerRadius](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CornerRadius), 
[Container<Drawable\>.CornerExponent](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CornerExponent), 
[Container<Drawable\>.BorderThickness](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_BorderThickness), 
[Container<Drawable\>.BorderColour](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_BorderColour), 
[Container<Drawable\>.EdgeEffect](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_EdgeEffect), 
[Container<Drawable\>.Padding](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Padding), 
[Container<Drawable\>.ForceLocalVertexBatch](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ForceLocalVertexBatch), 
[Container<Drawable\>.RelativeChildSize](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RelativeChildSize), 
[Container<Drawable\>.RelativeChildOffset](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RelativeChildOffset), 
[Container<Drawable\>.AutoSizeAxes](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeAxes), 
[Container<Drawable\>.AutoSizeDuration](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeDuration), 
[Container<Drawable\>.AutoSizeEasing](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeEasing), 
[Container<Drawable\>.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
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

[TransformableExtensions.Animate<InputManager\>\(InputManager, params TransformSequence<InputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<InputManager\>\(InputManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<InputManager\>\(InputManager, double, params TransformSequence<InputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<InputManager\>\(InputManager\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<InputManager\>\(InputManager, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<InputManager, TEasing\>\(InputManager, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<InputManager\>\(InputManager, Color4, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<InputManager, TEasing\>\(InputManager, Color4, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<InputManager\>\(InputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<InputManager, TEasing\>\(InputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<InputManager\>\(InputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<InputManager, TEasing\>\(InputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<InputManager\>\(InputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<InputManager, TEasing\>\(InputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<InputManager\>\(InputManager, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<InputManager, TEasing\>\(InputManager, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<InputManager\>\(InputManager, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<InputManager, TEasing\>\(InputManager, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[EnumerableExtensions.ForEach<Drawable\>\(IEnumerable<Drawable\>, Action<Drawable\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InputManager\>\(InputManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<Drawable\>\(IEnumerable<Drawable\>, Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<Drawable\>\(IEnumerable<Drawable\>, Drawable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<Drawable\>\(IEnumerable<Drawable\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<InputManager\>\(InputManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InputManager\>\(InputManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<InputManager\>\(InputManager, double, int, params TransformSequence<InputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<InputManager\>\(InputManager, double, params TransformSequence<InputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<InputManager\>\(InputManager, params TransformSequence<InputManager\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<InputManager\>\(InputManager, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<InputManager, TValue\>\(InputManager, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<InputManager, TEasing, TValue\>\(InputManager, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<InputManager\>\(InputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<InputManager\>\(InputManager, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<InputManager, TEasing\>\(InputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<InputManager, TEasing\>\(InputManager, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<InputManager\>\(InputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<InputManager, TEasing\>\(InputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, InputManager\>\(InputManager, Transform<TValue, DefaultEasingFunction, InputManager\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, InputManager\>\(InputManager, Transform<TValue, TEasing, InputManager\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<InputManager\>\(InputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<InputManager, TEasing\>\(InputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<InputManager\>\(InputManager, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<InputManager\>\(InputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<InputManager, TEasing\>\(InputManager, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<InputManager, TEasing\>\(InputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<InputManager\>\(InputManager, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<InputManager\>\(InputManager, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<InputManager, TValue\>\(InputManager, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<InputManager, TValue, TEasing\>\(InputManager, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<InputManager\>\(InputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<InputManager, TEasing\>\(InputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<InputManager\>\(InputManager, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<InputManager, TEasing\>\(InputManager, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformTo<InputManager, TValue\>\(InputManager, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<InputManager, TValue, TEasing\>\(InputManager, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<InputManager\>\(InputManager, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[TransformableExtensions.TweenEdgeEffectTo<InputManager\>\(InputManager, EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TweenEdgeEffectTo<InputManager, TEasing\>\(InputManager, EdgeEffectParameters, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.With<InputManager\>\(InputManager, Action<InputManager\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<InputManager, TChild\>\(InputManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InputManager, TChild\>\(InputManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InputManager, TChild\>\(InputManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InputManager\>\(InputManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_InputManager__ctor"></a> InputManager\(\)

```csharp
protected InputManager()
```

## Fields

### <a id="osu_Framework_Input_InputManager_CurrentState"></a> CurrentState

The last processed state.

```csharp
public readonly InputState CurrentState
```

#### Field Value

 [InputState](osu.Framework.Input.States.InputState.md)

## Properties

### <a id="osu_Framework_Input_InputManager_AllowRightClickFromLongTouch"></a> AllowRightClickFromLongTouch

Whether long touches should produce right mouse click, if mouse is mapped to touch.

```csharp
protected virtual bool AllowRightClickFromLongTouch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_InputManager_DraggedDrawable"></a> DraggedDrawable

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which is currently being dragged. null if none is.

```csharp
public Drawable DraggedDrawable { get; }
```

#### Property Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Input_InputManager_FocusedDrawable"></a> FocusedDrawable

The currently focused <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Null if there is no current focus.

```csharp
public Drawable FocusedDrawable { get; }
```

#### Property Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Input_InputManager_HandleHoverEvents"></a> HandleHoverEvents

Whether this input manager is in a state it should handle hover events.
This could for instance be set to false when the window/target does not have input focus.

```csharp
public virtual bool HandleHoverEvents { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_InputManager_Host"></a> Host

```csharp
[Resolved(CanBeNull = true)]
protected GameHost Host { get; }
```

#### Property Value

 [GameHost](osu.Framework.Platform.GameHost.md)

### <a id="osu_Framework_Input_InputManager_HoveredDrawables"></a> HoveredDrawables

Contains all hovered <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in top-down order up to the first
which returned true in its <xref href="osu.Framework.Graphics.Drawable.OnHover(osu.Framework.Input.Events.HoverEvent)" data-throw-if-not-resolved="false"></xref> method.
Top-down in this case means reverse draw order, i.e. the front-most visible
<xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> first, and <xref href="osu.Framework.Graphics.Containers.Container" data-throw-if-not-resolved="false"></xref>s after their children.

```csharp
public SlimReadOnlyListWrapper<Drawable> HoveredDrawables { get; }
```

#### Property Value

 [SlimReadOnlyListWrapper](osu.Framework.Lists.SlimReadOnlyListWrapper\-1.md)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Input_InputManager_InputHandlers"></a> InputHandlers

```csharp
protected abstract ImmutableArray<InputHandler> InputHandlers { get; }
```

#### Property Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[InputHandler](osu.Framework.Input.Handlers.InputHandler.md)\>

### <a id="osu_Framework_Input_InputManager_MapMouseToLatestTouch"></a> MapMouseToLatestTouch

Whether to produce mouse input on any touch input from latest source.

```csharp
protected virtual bool MapMouseToLatestTouch { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_InputManager_NonPositionalInputQueue"></a> NonPositionalInputQueue

Contains all <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in top-down order which are considered
for non-positional input.

```csharp
public SlimReadOnlyListWrapper<Drawable> NonPositionalInputQueue { get; }
```

#### Property Value

 [SlimReadOnlyListWrapper](osu.Framework.Lists.SlimReadOnlyListWrapper\-1.md)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

#### Remarks

This collection should not be retained as a reference. The contents is not stable outside of local usage.

### <a id="osu_Framework_Input_InputManager_PositionalInputQueue"></a> PositionalInputQueue

Contains all <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in top-down order which are considered
for positional input. This list is the same as <xref href="osu.Framework.Input.InputManager.HoveredDrawables" data-throw-if-not-resolved="false"></xref>, only
that the return value of <xref href="osu.Framework.Graphics.Drawable.OnHover(osu.Framework.Input.Events.HoverEvent)" data-throw-if-not-resolved="false"></xref> is not taken
into account.

```csharp
public SlimReadOnlyListWrapper<Drawable> PositionalInputQueue { get; }
```

#### Property Value

 [SlimReadOnlyListWrapper](osu.Framework.Lists.SlimReadOnlyListWrapper\-1.md)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

#### Remarks

This collection should not be retained as a reference. The contents is not stable outside of local usage.

## Methods

### <a id="osu_Framework_Input_InputManager_ChangeFocus_osu_Framework_Graphics_Drawable_"></a> ChangeFocus\(Drawable\)

Changes the currently-focused drawable. First checks that <code class="paramref">potentialFocusTarget</code> is in a valid state to receive focus,
then unfocuses the current <xref href="osu.Framework.Input.InputManager.FocusedDrawable" data-throw-if-not-resolved="false"></xref> and focuses <code class="paramref">potentialFocusTarget</code>.
<code class="paramref">potentialFocusTarget</code> can be null to reset focus.
If the given drawable is already focused, nothing happens and no events are fired.

```csharp
[Obsolete("This method does not allow trapping focus. Use GetContainingFocusManager().ChangeFocus() instead.")]
public bool ChangeFocus(Drawable potentialFocusTarget)
```

#### Parameters

`potentialFocusTarget` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to become focused.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if the given drawable is now focused (or focus is dropped in the case of a null target).

### <a id="osu_Framework_Input_InputManager_ChangeFocus_osu_Framework_Graphics_Drawable_osu_Framework_Input_States_InputState_"></a> ChangeFocus\(Drawable, InputState\)

Changes the currently-focused drawable. First checks that <code class="paramref">potentialFocusTarget</code> is in a valid state to receive focus,
then unfocuses the current <xref href="osu.Framework.Input.InputManager.FocusedDrawable" data-throw-if-not-resolved="false"></xref> and focuses <code class="paramref">potentialFocusTarget</code>.
<code class="paramref">potentialFocusTarget</code> can be null to reset focus.
If the given drawable is already focused, nothing happens and no events are fired.

```csharp
protected bool ChangeFocus(Drawable potentialFocusTarget, InputState state)
```

#### Parameters

`potentialFocusTarget` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to become focused.

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> associated with the focusing event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if the given drawable is now focused (or focus is dropped in the case of a null target).

### <a id="osu_Framework_Input_InputManager_ChangeFocusFromClick_osu_Framework_Graphics_Drawable_"></a> ChangeFocusFromClick\(Drawable\)

```csharp
protected virtual void ChangeFocusFromClick(Drawable clickedDrawable)
```

#### Parameters

`clickedDrawable` [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osuTK_Input_MouseButton_"></a> CreateButtonEventManagerFor\(MouseButton\)

Create a <xref href="osu.Framework.Input.MouseButtonEventManager" data-throw-if-not-resolved="false"></xref> for a specified mouse button.

```csharp
protected virtual MouseButtonEventManager CreateButtonEventManagerFor(MouseButton button)
```

#### Parameters

`button` MouseButton

The button to be handled by the returned manager.

#### Returns

 [MouseButtonEventManager](osu.Framework.Input.MouseButtonEventManager.md)

The <xref href="osu.Framework.Input.MouseButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osuTK_Input_Key_"></a> CreateButtonEventManagerFor\(Key\)

Create a <xref href="osu.Framework.Input.KeyEventManager" data-throw-if-not-resolved="false"></xref> for a specified key.

```csharp
protected virtual KeyEventManager CreateButtonEventManagerFor(Key key)
```

#### Parameters

`key` Key

The key to be handled by the returned manager.

#### Returns

 [KeyEventManager](osu.Framework.Input.KeyEventManager.md)

The <xref href="osu.Framework.Input.KeyEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osu_Framework_Input_TouchSource_"></a> CreateButtonEventManagerFor\(TouchSource\)

Create a <xref href="osu.Framework.Input.TouchEventManager" data-throw-if-not-resolved="false"></xref> for a specified touch source.

```csharp
protected virtual TouchEventManager CreateButtonEventManagerFor(TouchSource source)
```

#### Parameters

`source` [TouchSource](osu.Framework.Input.TouchSource.md)

The touch source to be handled by the returned manager.

#### Returns

 [TouchEventManager](osu.Framework.Input.TouchEventManager.md)

The <xref href="osu.Framework.Input.TouchEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osu_Framework_Input_TabletPenButton_"></a> CreateButtonEventManagerFor\(TabletPenButton\)

Create a <xref href="osu.Framework.Input.TabletPenButtonEventManager" data-throw-if-not-resolved="false"></xref> for a specified tablet pen button.

```csharp
protected virtual TabletPenButtonEventManager CreateButtonEventManagerFor(TabletPenButton button)
```

#### Parameters

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

The button to be handled by the returned manager.

#### Returns

 [TabletPenButtonEventManager](osu.Framework.Input.TabletPenButtonEventManager.md)

The <xref href="osu.Framework.Input.TabletPenButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osu_Framework_Input_TabletAuxiliaryButton_"></a> CreateButtonEventManagerFor\(TabletAuxiliaryButton\)

Create a <xref href="osu.Framework.Input.TabletAuxiliaryButtonEventManager" data-throw-if-not-resolved="false"></xref> for a specified tablet auxiliary button.

```csharp
protected virtual TabletAuxiliaryButtonEventManager CreateButtonEventManagerFor(TabletAuxiliaryButton button)
```

#### Parameters

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

The button to be handled by the returned manager.

#### Returns

 [TabletAuxiliaryButtonEventManager](osu.Framework.Input.TabletAuxiliaryButtonEventManager.md)

The <xref href="osu.Framework.Input.TabletAuxiliaryButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osu_Framework_Input_JoystickButton_"></a> CreateButtonEventManagerFor\(JoystickButton\)

Create a <xref href="osu.Framework.Input.JoystickButtonEventManager" data-throw-if-not-resolved="false"></xref> for a specified joystick button.

```csharp
protected virtual JoystickButtonEventManager CreateButtonEventManagerFor(JoystickButton button)
```

#### Parameters

`button` [JoystickButton](osu.Framework.Input.JoystickButton.md)

The button to be handled by the returned manager.

#### Returns

 [JoystickButtonEventManager](osu.Framework.Input.JoystickButtonEventManager.md)

The <xref href="osu.Framework.Input.JoystickButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateButtonEventManagerFor_osu_Framework_Input_MidiKey_"></a> CreateButtonEventManagerFor\(MidiKey\)

Create a <xref href="osu.Framework.Input.MidiKeyEventManager" data-throw-if-not-resolved="false"></xref> for a specified midi key.

```csharp
protected virtual MidiKeyEventManager CreateButtonEventManagerFor(MidiKey key)
```

#### Parameters

`key` [MidiKey](osu.Framework.Input.MidiKey.md)

The key to be handled by the returned manager.

#### Returns

 [MidiKeyEventManager](osu.Framework.Input.MidiKeyEventManager.md)

The <xref href="osu.Framework.Input.MidiKeyEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_CreateInitialState"></a> CreateInitialState\(\)

The initial input state. <xref href="osu.Framework.Input.InputManager.CurrentState" data-throw-if-not-resolved="false"></xref> is always equal (as a reference) to the value returned from this.

```csharp
protected virtual InputState CreateInitialState()
```

#### Returns

 [InputState](osu.Framework.Input.States.InputState.md)

### <a id="osu_Framework_Input_InputManager_CreateJoystickAxisEventManagerFor_osu_Framework_Input_JoystickAxisSource_"></a> CreateJoystickAxisEventManagerFor\(JoystickAxisSource\)

Create a <xref href="osu.Framework.Input.JoystickAxisEventManager" data-throw-if-not-resolved="false"></xref> for a specified joystick axis.

```csharp
protected virtual JoystickAxisEventManager CreateJoystickAxisEventManagerFor(JoystickAxisSource source)
```

#### Parameters

`source` [JoystickAxisSource](osu.Framework.Input.JoystickAxisSource.md)

The axis to be handled by the returned manager.

#### Returns

 [JoystickAxisEventManager](osu.Framework.Input.JoystickAxisEventManager.md)

The <xref href="osu.Framework.Input.JoystickAxisEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osuTK_Input_MouseButton_"></a> GetButtonEventManagerFor\(MouseButton\)

Get the <xref href="osu.Framework.Input.MouseButtonEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified mouse button.

```csharp
public MouseButtonEventManager GetButtonEventManagerFor(MouseButton button)
```

#### Parameters

`button` MouseButton

The button to find the manager for.

#### Returns

 [MouseButtonEventManager](osu.Framework.Input.MouseButtonEventManager.md)

The <xref href="osu.Framework.Input.MouseButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osuTK_Input_Key_"></a> GetButtonEventManagerFor\(Key\)

Get the <xref href="osu.Framework.Input.KeyEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified key.

```csharp
public KeyEventManager GetButtonEventManagerFor(Key key)
```

#### Parameters

`key` Key

The key to find the manager for.

#### Returns

 [KeyEventManager](osu.Framework.Input.KeyEventManager.md)

The <xref href="osu.Framework.Input.KeyEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osu_Framework_Input_TouchSource_"></a> GetButtonEventManagerFor\(TouchSource\)

Get the <xref href="osu.Framework.Input.TouchEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified touch source.

```csharp
public TouchEventManager GetButtonEventManagerFor(TouchSource source)
```

#### Parameters

`source` [TouchSource](osu.Framework.Input.TouchSource.md)

The touch source to find the manager for.

#### Returns

 [TouchEventManager](osu.Framework.Input.TouchEventManager.md)

The <xref href="osu.Framework.Input.TouchEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osu_Framework_Input_TabletPenButton_"></a> GetButtonEventManagerFor\(TabletPenButton\)

Get the <xref href="osu.Framework.Input.TabletPenButtonEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified tablet pen button.

```csharp
public TabletPenButtonEventManager GetButtonEventManagerFor(TabletPenButton button)
```

#### Parameters

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

The button to find the manager for.

#### Returns

 [TabletPenButtonEventManager](osu.Framework.Input.TabletPenButtonEventManager.md)

The <xref href="osu.Framework.Input.TabletPenButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osu_Framework_Input_TabletAuxiliaryButton_"></a> GetButtonEventManagerFor\(TabletAuxiliaryButton\)

Get the <xref href="osu.Framework.Input.TabletAuxiliaryButtonEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified tablet auxiliary button.

```csharp
public TabletAuxiliaryButtonEventManager GetButtonEventManagerFor(TabletAuxiliaryButton button)
```

#### Parameters

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

The button to find the manager for.

#### Returns

 [TabletAuxiliaryButtonEventManager](osu.Framework.Input.TabletAuxiliaryButtonEventManager.md)

The <xref href="osu.Framework.Input.TabletAuxiliaryButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osu_Framework_Input_JoystickButton_"></a> GetButtonEventManagerFor\(JoystickButton\)

Get the <xref href="osu.Framework.Input.JoystickButtonEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified joystick button.

```csharp
public JoystickButtonEventManager GetButtonEventManagerFor(JoystickButton button)
```

#### Parameters

`button` [JoystickButton](osu.Framework.Input.JoystickButton.md)

The button to find the manager for.

#### Returns

 [JoystickButtonEventManager](osu.Framework.Input.JoystickButtonEventManager.md)

The <xref href="osu.Framework.Input.JoystickButtonEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetButtonEventManagerFor_osu_Framework_Input_MidiKey_"></a> GetButtonEventManagerFor\(MidiKey\)

Get the <xref href="osu.Framework.Input.MidiKeyEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified midi key.

```csharp
public MidiKeyEventManager GetButtonEventManagerFor(MidiKey key)
```

#### Parameters

`key` [MidiKey](osu.Framework.Input.MidiKey.md)

The key to find the manager for.

#### Returns

 [MidiKeyEventManager](osu.Framework.Input.MidiKeyEventManager.md)

The <xref href="osu.Framework.Input.MidiKeyEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetJoystickAxisEventManagerFor_osu_Framework_Input_JoystickAxisSource_"></a> GetJoystickAxisEventManagerFor\(JoystickAxisSource\)

Get the <xref href="osu.Framework.Input.JoystickAxisEventManager" data-throw-if-not-resolved="false"></xref> responsible for a specified joystick axis.

```csharp
public JoystickAxisEventManager GetJoystickAxisEventManagerFor(JoystickAxisSource source)
```

#### Parameters

`source` [JoystickAxisSource](osu.Framework.Input.JoystickAxisSource.md)

The axis to find the manager for.

#### Returns

 [JoystickAxisEventManager](osu.Framework.Input.JoystickAxisEventManager.md)

The <xref href="osu.Framework.Input.JoystickAxisEventManager" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_GetPendingInputs"></a> GetPendingInputs\(\)

```csharp
protected virtual List<IInput> GetPendingInputs()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[IInput](osu.Framework.Input.StateChanges.IInput.md)\>

### <a id="osu_Framework_Input_InputManager_HandleInputStateChange_osu_Framework_Input_StateChanges_Events_InputStateChangeEvent_"></a> HandleInputStateChange\(InputStateChangeEvent\)

Handles an input state change event.

```csharp
public virtual void HandleInputStateChange(InputStateChangeEvent inputStateChange)
```

#### Parameters

`inputStateChange` [InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md)

### <a id="osu_Framework_Input_InputManager_HandleJoystickAxisChange_osu_Framework_Input_StateChanges_Events_JoystickAxisChangeEvent_"></a> HandleJoystickAxisChange\(JoystickAxisChangeEvent\)

```csharp
protected virtual void HandleJoystickAxisChange(JoystickAxisChangeEvent e)
```

#### Parameters

`e` [JoystickAxisChangeEvent](osu.Framework.Input.StateChanges.Events.JoystickAxisChangeEvent.md)

### <a id="osu_Framework_Input_InputManager_HandleJoystickButtonStateChange_osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_osu_Framework_Input_JoystickButton__"></a> HandleJoystickButtonStateChange\(ButtonStateChangeEvent<JoystickButton\>\)

```csharp
protected virtual void HandleJoystickButtonStateChange(ButtonStateChangeEvent<JoystickButton> joystickButtonStateChange)
```

#### Parameters

`joystickButtonStateChange` [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<[JoystickButton](osu.Framework.Input.JoystickButton.md)\>

### <a id="osu_Framework_Input_InputManager_HandleKeyboardKeyStateChange_osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_osuTK_Input_Key__"></a> HandleKeyboardKeyStateChange\(ButtonStateChangeEvent<Key\>\)

```csharp
protected virtual void HandleKeyboardKeyStateChange(ButtonStateChangeEvent<Key> keyboardKeyStateChange)
```

#### Parameters

`keyboardKeyStateChange` [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<Key\>

### <a id="osu_Framework_Input_InputManager_HandleMidiKeyStateChange_osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_osu_Framework_Input_MidiKey__"></a> HandleMidiKeyStateChange\(ButtonStateChangeEvent<MidiKey\>\)

```csharp
protected virtual void HandleMidiKeyStateChange(ButtonStateChangeEvent<MidiKey> midiKeyStateChange)
```

#### Parameters

`midiKeyStateChange` [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<[MidiKey](osu.Framework.Input.MidiKey.md)\>

### <a id="osu_Framework_Input_InputManager_HandleMouseButtonStateChange_osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_osuTK_Input_MouseButton__"></a> HandleMouseButtonStateChange\(ButtonStateChangeEvent<MouseButton\>\)

```csharp
protected virtual void HandleMouseButtonStateChange(ButtonStateChangeEvent<MouseButton> e)
```

#### Parameters

`e` [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<MouseButton\>

### <a id="osu_Framework_Input_InputManager_HandleMousePositionChange_osu_Framework_Input_StateChanges_Events_MousePositionChangeEvent_"></a> HandleMousePositionChange\(MousePositionChangeEvent\)

```csharp
protected virtual void HandleMousePositionChange(MousePositionChangeEvent e)
```

#### Parameters

`e` [MousePositionChangeEvent](osu.Framework.Input.StateChanges.Events.MousePositionChangeEvent.md)

### <a id="osu_Framework_Input_InputManager_HandleMouseScrollChange_osu_Framework_Input_StateChanges_Events_MouseScrollChangeEvent_"></a> HandleMouseScrollChange\(MouseScrollChangeEvent\)

```csharp
protected virtual void HandleMouseScrollChange(MouseScrollChangeEvent e)
```

#### Parameters

`e` [MouseScrollChangeEvent](osu.Framework.Input.StateChanges.Events.MouseScrollChangeEvent.md)

### <a id="osu_Framework_Input_InputManager_HandleMouseTouchStateChange_osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_"></a> HandleMouseTouchStateChange\(TouchStateChangeEvent\)

Handles latest activated touch state change event to produce mouse input from.

```csharp
protected virtual bool HandleMouseTouchStateChange(TouchStateChangeEvent e)
```

#### Parameters

`e` [TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

The latest activated touch state change event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether mouse input has been performed accordingly.

### <a id="osu_Framework_Input_InputManager_HandleTabletAuxiliaryButtonStateChange_osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_osu_Framework_Input_TabletAuxiliaryButton__"></a> HandleTabletAuxiliaryButtonStateChange\(ButtonStateChangeEvent<TabletAuxiliaryButton\>\)

```csharp
protected virtual void HandleTabletAuxiliaryButtonStateChange(ButtonStateChangeEvent<TabletAuxiliaryButton> tabletAuxiliaryButtonStateChange)
```

#### Parameters

`tabletAuxiliaryButtonStateChange` [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<[TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)\>

### <a id="osu_Framework_Input_InputManager_HandleTabletPenButtonStateChange_osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_osu_Framework_Input_TabletPenButton__"></a> HandleTabletPenButtonStateChange\(ButtonStateChangeEvent<TabletPenButton\>\)

```csharp
protected virtual void HandleTabletPenButtonStateChange(ButtonStateChangeEvent<TabletPenButton> tabletPenButtonStateChange)
```

#### Parameters

`tabletPenButtonStateChange` [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<[TabletPenButton](osu.Framework.Input.TabletPenButton.md)\>

### <a id="osu_Framework_Input_InputManager_HandleTouchStateChange_osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_"></a> HandleTouchStateChange\(TouchStateChangeEvent\)

```csharp
protected virtual void HandleTouchStateChange(TouchStateChangeEvent e)
```

#### Parameters

`e` [TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

### <a id="osu_Framework_Input_InputManager_LoadComplete"></a> LoadComplete\(\)

Invoked after this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> has finished loading.

```csharp
protected override void LoadComplete()
```

#### Remarks

This method is invoked on the update thread inside this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Graphics.Drawable.UpdateSubTree" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_InputManager_PropagateBlockableEvent_osu_Framework_Lists_SlimReadOnlyListWrapper_osu_Framework_Graphics_Drawable__osu_Framework_Input_Events_UIEvent_"></a> PropagateBlockableEvent\(SlimReadOnlyListWrapper<Drawable\>, UIEvent\)

Triggers events on drawables in <code class="paramref">drawables</code> until it is handled.

```csharp
protected virtual bool PropagateBlockableEvent(SlimReadOnlyListWrapper<Drawable> drawables, UIEvent e)
```

#### Parameters

`drawables` [SlimReadOnlyListWrapper](osu.Framework.Lists.SlimReadOnlyListWrapper\-1.md)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The drawables in the queue.

`e` [UIEvent](osu.Framework.Input.Events.UIEvent.md)

The event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the event was handled.

### <a id="osu_Framework_Input_InputManager_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Input_InputManager_TriggerFocusContention_osu_Framework_Graphics_Drawable_"></a> TriggerFocusContention\(Drawable\)

Reset current focused drawable to the top-most drawable which is <xref href="osu.Framework.Graphics.Drawable.RequestsFocus" data-throw-if-not-resolved="false"></xref>.

```csharp
[Obsolete("This method does not allow trapping focus. Use GetContainingFocusManager().TriggerFocusContention instead.")]
public void TriggerFocusContention(Drawable triggerSource)
```

#### Parameters

`triggerSource` [Drawable](osu.Framework.Graphics.Drawable.md)

The source which triggered this event.

### <a id="osu_Framework_Input_InputManager_Update"></a> Update\(\)

Performs a once-per-frame update specific to this Drawable. A more elegant alternative to
<xref href="osu.Framework.Graphics.Drawable.OnUpdate" data-throw-if-not-resolved="false"></xref> when deriving from <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Note, that this
method is always called before Drawables further down the scene graph are updated.

```csharp
protected override void Update()
```

### <a id="osu_Framework_Input_InputManager_TouchLongPressBegan"></a> TouchLongPressBegan

Invoked when a touch long-press gesture has scheduled for triggering after the specified delay.

```csharp
public event Action<Vector2, double> TouchLongPressBegan
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-2)<Vector2, [double](https://learn.microsoft.com/dotnet/api/system.double)\>

### <a id="osu_Framework_Input_InputManager_TouchLongPressCancelled"></a> TouchLongPressCancelled

Invoked when an ongoing touch long-press gesture has been cancelled.

```csharp
public event Action TouchLongPressCancelled
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

