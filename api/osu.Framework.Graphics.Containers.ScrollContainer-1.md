# <a id="osu_Framework_Graphics_Containers_ScrollContainer_1"></a> Class ScrollContainer<T\>

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

```csharp
public abstract class ScrollContainer<T> : Container<T>, IDependencyInjectionCandidate, IDisposable, IContainerEnumerable<T>, IContainerCollection<T>, ICollection<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable, IScrollContainer, IContainer, IKeyBindingHandler<PlatformAction>, IKeyBindingHandler, IDrawable, ITransformable, ISourceGeneratedHandleInputCache, ISourceGeneratedLongRunningLoadCache, ISourceGeneratedDependencyActivator where T : Drawable
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transformable](osu.Framework.Graphics.Transforms.Transformable.md) ← 
[Drawable](osu.Framework.Graphics.Drawable.md) ← 
[CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md) ← 
[Container<T\>](osu.Framework.Graphics.Containers.Container\-1.md) ← 
[ScrollContainer<T\>](osu.Framework.Graphics.Containers.ScrollContainer\-1.md)

#### Implements

[IDependencyInjectionCandidate](osu.Framework.Allocation.IDependencyInjectionCandidate.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IContainerEnumerable<T\>](osu.Framework.Graphics.Containers.IContainerEnumerable\-1.md), 
[IContainerCollection<T\>](osu.Framework.Graphics.Containers.IContainerCollection\-1.md), 
[ICollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<T\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IScrollContainer](osu.Framework.Graphics.Containers.IScrollContainer.md), 
[IContainer](osu.Framework.Graphics.Containers.IContainer.md), 
[IKeyBindingHandler<PlatformAction\>](osu.Framework.Input.Bindings.IKeyBindingHandler\-1.md), 
[IKeyBindingHandler](osu.Framework.Input.Bindings.IKeyBindingHandler.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md), 
[ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md), 
[ISourceGeneratedLongRunningLoadCache](osu.Framework.Allocation.ISourceGeneratedLongRunningLoadCache.md), 
[ISourceGeneratedDependencyActivator](osu.Framework.Allocation.ISourceGeneratedDependencyActivator.md)

#### Inherited Members

[Container<T\>.Content](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Content), 
[Container<T\>.Children](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Children), 
[Container<T\>.AliveChildren](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AliveChildren), 
[Container<T\>.this\[int\]](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Item\_System\_Int32\_), 
[Container<T\>.Count](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Count), 
[Container<T\>.IsReadOnly](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_IsReadOnly), 
[Container<T\>.CopyTo\(T\[\], int\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CopyTo\_\_0\_\_\_System\_Int32\_), 
[Container<T\>.GetEnumerator\(\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_GetEnumerator), 
[Container<T\>.ChildrenEnumerable](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ChildrenEnumerable), 
[Container<T\>.Child](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Child), 
[Container<T\>.IndexOf\(T\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_IndexOf\_\_0\_), 
[Container<T\>.Contains\(T\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Contains\_\_0\_), 
[Container<T\>.Add\(T\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Add\_\_0\_), 
[Container<T\>.AddRange\(IEnumerable<T\>\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AddRange\_System\_Collections\_Generic\_IEnumerable\_\_0\_\_), 
[Container<T\>.AddInternal\(Drawable\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AddInternal\_osu\_Framework\_Graphics\_Drawable\_), 
[Container<T\>.Remove\(T, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Remove\_\_0\_System\_Boolean\_), 
[Container<T\>.RemoveAll\(Predicate<T\>, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveAll\_System\_Predicate\_\_0\_\_System\_Boolean\_), 
[Container<T\>.RemoveRange\(IEnumerable<T\>, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveRange\_System\_Collections\_Generic\_IEnumerable\_\_0\_\_System\_Boolean\_), 
[Container<T\>.RemoveInternal\(Drawable, bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RemoveInternal\_osu\_Framework\_Graphics\_Drawable\_System\_Boolean\_), 
[Container<T\>.Clear\(\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Clear), 
[Container<T\>.Clear\(bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Clear\_System\_Boolean\_), 
[Container<T\>.ClearInternal\(bool\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ClearInternal\_System\_Boolean\_), 
[Container<T\>.ChangeChildDepth\(T, float\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ChangeChildDepth\_\_0\_System\_Single\_), 
[Container<T\>.Masking](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Masking), 
[Container<T\>.MaskingSmoothness](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_MaskingSmoothness), 
[Container<T\>.CornerRadius](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CornerRadius), 
[Container<T\>.CornerExponent](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_CornerExponent), 
[Container<T\>.BorderThickness](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_BorderThickness), 
[Container<T\>.BorderColour](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_BorderColour), 
[Container<T\>.EdgeEffect](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_EdgeEffect), 
[Container<T\>.Padding](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_Padding), 
[Container<T\>.ForceLocalVertexBatch](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_ForceLocalVertexBatch), 
[Container<T\>.RelativeChildSize](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RelativeChildSize), 
[Container<T\>.RelativeChildOffset](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RelativeChildOffset), 
[Container<T\>.AutoSizeAxes](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeAxes), 
[Container<T\>.AutoSizeDuration](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeDuration), 
[Container<T\>.AutoSizeEasing](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_AutoSizeEasing), 
[Container<T\>.RegisterForDependencyActivation\(IDependencyActivatorRegistry\)](osu.Framework.Graphics.Containers.Container\-1.md\#osu\_Framework\_Graphics\_Containers\_Container\_1\_RegisterForDependencyActivation\_osu\_Framework\_Allocation\_IDependencyActivatorRegistry\_), 
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

[TransformableExtensions.Animate<ScrollContainer<T\>\>\(ScrollContainer<T\>, params TransformSequence<ScrollContainer<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<ScrollContainer<T\>\>\(ScrollContainer<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TestingExtensions.ChildrenOfType<T\>\(Drawable?\)](osu.Framework.Testing.TestingExtensions.md\#osu\_Framework\_Testing\_TestingExtensions\_ChildrenOfType\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Delay<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, params TransformSequence<ScrollContainer<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.DelayUntilTransformsFinished<ScrollContainer<T\>\>\(ScrollContainer<T\>\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_DelayUntilTransformsFinished\_\_1\_\_\_0\_), 
[TransformableExtensions.FadeColour<ScrollContainer<T\>\>\(ScrollContainer<T\>, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeColour<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Color4, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Color4, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeIn<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeIn<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeIn\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeInFromZero<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeInFromZero<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeInFromZero\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOut<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOut<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOut\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeOutFromOne<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeOutFromOne<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeOutFromOne\_\_2\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.FindClosestParent<T\>\(Drawable?\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_FindClosestParent\_\_1\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.FlashColour<ScrollContainer<T\>\>\(ScrollContainer<T\>, ColourInfo, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FlashColour<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, ColourInfo, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FlashColour\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Colour\_ColourInfo\_System\_Double\_\_\_1\_\_), 
[EnumerableExtensions.ForEach<T\>\(IEnumerable<T\>, Action<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_ForEach\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_Action\_\_\_0\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ScrollContainer<T\>\>\(ScrollContainer<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumerableExtensions.GetNext<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetNext\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumerableExtensions.GetPrevious<T\>\(IEnumerable<T\>, T\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_GetPrevious\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_\_\_0\_), 
[EnumExtensions.GetValuesInOrder<T\>\(IEnumerable<T\>\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_GetValuesInOrder\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_), 
[PopoverExtensions.HidePopover\(Drawable\)](osu.Framework.Extensions.PopoverExtensions.md\#osu\_Framework\_Extensions\_PopoverExtensions\_HidePopover\_osu\_Framework\_Graphics\_Drawable\_), 
[ObjectExtensions.IsNotNull<ScrollContainer<T\>\>\(ScrollContainer<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ScrollContainer<T\>\>\(ScrollContainer<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[DrawableExtensions.IsRootedAt\(Drawable?, Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_IsRootedAt\_osu\_Framework\_Graphics\_Drawable\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.Loop<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, int, params TransformSequence<ScrollContainer<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, params TransformSequence<ScrollContainer<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ScrollContainer<T\>\>\(ScrollContainer<T\>, params TransformSequence<ScrollContainer<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ScrollContainer<T\>\>\(ScrollContainer<T\>, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<ScrollContainer<T\>, TValue\>\(ScrollContainer<T\>, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<ScrollContainer<T\>, TEasing, TValue\>\(ScrollContainer<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.MoveTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Direction, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Direction, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Direction\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToOffset<ScrollContainer<T\>\>\(ScrollContainer<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToOffset<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToOffset\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToX<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToX<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToX\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.MoveToY<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.MoveToY<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MoveToY\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.PopulateTransform<TValue, ScrollContainer<T\>\>\(ScrollContainer<T\>, Transform<TValue, DefaultEasingFunction, ScrollContainer<T\>\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, ScrollContainer<T\>\>\(ScrollContainer<T\>, Transform<TValue, TEasing, ScrollContainer<T\>\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.RemoveAndDisposeImmediately\(Drawable\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_RemoveAndDisposeImmediately\_osu\_Framework\_Graphics\_Drawable\_), 
[TransformableExtensions.ResizeHeightTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeHeightTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeHeightTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ResizeWidthTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ResizeWidthTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ResizeWidthTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.RotateTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.RotateTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_RotateTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.ScaleTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.ScaleTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_ScaleTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.Spin<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, RotationDirection, float\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_), 
[TransformableExtensions.Spin<ScrollContainer<T\>\>\(ScrollContainer<T\>, double, RotationDirection, float, int\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Spin\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_RotationDirection\_System\_Single\_System\_Int32\_), 
[TransformableExtensions.TransformBindableTo<ScrollContainer<T\>, TValue\>\(ScrollContainer<T\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<ScrollContainer<T\>, TValue, TEasing\>\(ScrollContainer<T\>, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformTo<ScrollContainer<T\>, TValue\>\(ScrollContainer<T\>, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<ScrollContainer<T\>, TValue, TEasing\>\(ScrollContainer<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[TransformableExtensions.TweenEdgeEffectTo<ScrollContainer<T\>\>\(ScrollContainer<T\>, EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TweenEdgeEffectTo<ScrollContainer<T\>, TEasing\>\(ScrollContainer<T\>, EdgeEffectParameters, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_\_\_1\_\_), 
[DrawableExtensions.With<ScrollContainer<T\>\>\(ScrollContainer<T\>, Action<ScrollContainer<T\>\>\)](osu.Framework.Graphics.DrawableExtensions.md\#osu\_Framework\_Graphics\_DrawableExtensions\_With\_\_1\_\_\_0\_System\_Action\_\_\_0\_\_), 
[ContainerExtensions.WithChild<ScrollContainer<T\>, TChild\>\(ScrollContainer<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ScrollContainer<T\>, TChild\>\(ScrollContainer<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ScrollContainer<T\>, TChild\>\(ScrollContainer<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ScrollContainer<T\>\>\(ScrollContainer<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1__ctor_osu_Framework_Graphics_Direction_"></a> ScrollContainer\(Direction\)

Creates a scroll container.

```csharp
protected ScrollContainer(Direction scrollDirection = Direction.Vertical)
```

#### Parameters

`scrollDirection` [Direction](osu.Framework.Graphics.Direction.md)

The direction in which should be scrolled. Can be vertical or horizontal. Default is vertical.

## Fields

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ClampExtension"></a> ClampExtension

This limits how far out of clamping bounds we allow the target position to be at most.
Effectively, larger values result in bouncier behavior as the scroll boundaries are approached
with high velocity.

```csharp
public float ClampExtension
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_DistanceDecayDrag"></a> DistanceDecayDrag

Controls the rate with which the target position is approached after ending a drag. Default is 0.0035.

```csharp
public double DistanceDecayDrag
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_DistanceDecayJump"></a> DistanceDecayJump

Controls the rate with which the target position is approached after jumping to a specific location. Default is 0.01.

```csharp
public double DistanceDecayJump
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_DistanceDecayScroll"></a> DistanceDecayScroll

Controls the rate with which the target position is approached after scrolling. Default is 0.01

```csharp
public double DistanceDecayScroll
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollDistance"></a> ScrollDistance

Controls the distance scrolled per unit of mouse scroll.

```csharp
public float ScrollDistance
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_Scrollbar"></a> Scrollbar

```csharp
protected readonly ScrollContainer<T>.ScrollbarContainer Scrollbar
```

#### Field Value

 [ScrollContainer](osu.Framework.Graphics.Containers.ScrollContainer\-1.md)<T\>.[ScrollbarContainer](osu.Framework.Graphics.Containers.ScrollContainer\-1.ScrollbarContainer.md)

## Properties

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_AvailableContent"></a> AvailableContent

Size of available content (i.e. everything that can be scrolled to) in the scroll direction.

```csharp
public float AvailableContent { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_Content"></a> Content

The content of this container. <xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> and all methods that mutate
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> (e.g. <xref href="osu.Framework.Graphics.Containers.Container%601.Add(%600)" data-throw-if-not-resolved="false"></xref> and <xref href="osu.Framework.Graphics.Containers.Container%601.Remove(%600%2cSystem.Boolean)" data-throw-if-not-resolved="false"></xref>) are
forwarded to the content. By default a container's content is itself, in which case
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> refers to <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
This property is useful for containers that require internal children that should
not be exposed to the outside world, e.g. <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override Container<T> Content { get; }
```

#### Property Value

 [Container](osu.Framework.Graphics.Containers.Container\-1.md)<T\>

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_Current"></a> Current

The current scroll position.

```csharp
public double Current { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_DisplayableContent"></a> DisplayableContent

Size of the viewport in the scroll direction.

```csharp
public float DisplayableContent { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_DragBlocksClick"></a> DragBlocksClick

Whether clicks should be blocked when this drawable is in a dragged state.

```csharp
public override bool DragBlocksClick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This is queried when a click is to be actuated.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_IsDragging"></a> IsDragging

```csharp
protected virtual bool IsDragging { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_IsHandlingKeyboardScrolling"></a> IsHandlingKeyboardScrolling

```csharp
public bool IsHandlingKeyboardScrolling { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollContent"></a> ScrollContent

The container holding all children which are getting scrolled around.

```csharp
public Container<T> ScrollContent { get; }
```

#### Property Value

 [Container](osu.Framework.Graphics.Containers.Container\-1.md)<T\>

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollDim"></a> ScrollDim

The direction in which scrolling is supported, converted to an int for array index lookups.

```csharp
protected int ScrollDim { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollDirection"></a> ScrollDirection

The direction in which scrolling is supported.

```csharp
public Direction ScrollDirection { get; }
```

#### Property Value

 [Direction](osu.Framework.Graphics.Direction.md)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollableExtent"></a> ScrollableExtent

The maximum distance that can be scrolled in the scroll direction.

```csharp
public double ScrollableExtent { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollbarAnchor"></a> ScrollbarAnchor

Determines whether the scroll dragger appears on the left side. If not, then it always appears on the right side.

```csharp
public Anchor ScrollbarAnchor { get; set; }
```

#### Property Value

 [Anchor](osu.Framework.Graphics.Anchor.md)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollbarMovementExtent"></a> ScrollbarMovementExtent

The maximum distance that the scrollbar can move in the scroll direction.

```csharp
protected double ScrollbarMovementExtent { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

May not be accurate to actual display of scrollbar if <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.ToScrollbarPosition(System.Double)" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.FromScrollbarPosition(System.Single)" data-throw-if-not-resolved="false"></xref> are overridden.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollbarOverlapsContent"></a> ScrollbarOverlapsContent

Whether the scrollbar overlaps the content or resides in its own padded space.

```csharp
public bool ScrollbarOverlapsContent { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollbarVisible"></a> ScrollbarVisible

Whether the scrollbar is visible.

```csharp
public bool ScrollbarVisible { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_Target"></a> Target

The target scroll position which is exponentially approached by current via a rate of distance decay.

```csharp
public double Target { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

When not animating scroll position, this will always be equal to <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.Current" data-throw-if-not-resolved="false"></xref>.

## Methods

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ApplyCurrentToContent"></a> ApplyCurrentToContent\(\)

This is the final internal step of updating the scroll container, which takes
<xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.Current" data-throw-if-not-resolved="false"></xref> and applies it to <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.ScrollContent" data-throw-if-not-resolved="false"></xref> in order to
correctly offset children.

Overriding this method can be used to inhibit this default behaviour, to for instance
redirect the positioning to another container or change the way it is applied.

```csharp
protected virtual void ApplyCurrentToContent()
```

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_Clamp_System_Double_System_Double_"></a> Clamp\(double, double\)

Clamp a value to the available scroll range.

```csharp
protected double Clamp(double position, double extension = 0)
```

#### Parameters

`position` [double](https://learn.microsoft.com/dotnet/api/system.double)

The value to clamp.

`extension` [double](https://learn.microsoft.com/dotnet/api/system.double)

An extension value beyond the normal extent.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_CreateScrollbar_osu_Framework_Graphics_Direction_"></a> CreateScrollbar\(Direction\)

Creates the scrollbar for this <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract ScrollContainer<T>.ScrollbarContainer CreateScrollbar(Direction direction)
```

#### Parameters

`direction` [Direction](osu.Framework.Graphics.Direction.md)

The scrolling direction.

#### Returns

 [ScrollContainer](osu.Framework.Graphics.Containers.ScrollContainer\-1.md)<T\>.[ScrollbarContainer](osu.Framework.Graphics.Containers.ScrollContainer\-1.ScrollbarContainer.md)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_FromScrollbarPosition_System_Single_"></a> FromScrollbarPosition\(float\)

Converts a scrollbar position to a scroll position.

```csharp
protected virtual float FromScrollbarPosition(float scrollbarPosition)
```

#### Parameters

`scrollbarPosition` [float](https://learn.microsoft.com/dotnet/api/system.single)

The scrollbar position.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

The absolute scroll position.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_GetChildPosInContent_osu_Framework_Graphics_Drawable_osuTK_Vector2_"></a> GetChildPosInContent\(Drawable, Vector2\)

Determines the position of a child in the content.

```csharp
public virtual double GetChildPosInContent(Drawable d, Vector2 offset)
```

#### Parameters

`d` [Drawable](osu.Framework.Graphics.Drawable.md)

The child to get the position from.

`offset` Vector2

Positional offset in the child's space.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The position of the child.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_GetChildPosInContent_osu_Framework_Graphics_Drawable_"></a> GetChildPosInContent\(Drawable\)

Determines the position of a child in the content.

```csharp
public double GetChildPosInContent(Drawable d)
```

#### Parameters

`d` [Drawable](osu.Framework.Graphics.Drawable.md)

The child to get the position from.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The position of the child.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_IsScrolledToEnd_System_Single_"></a> IsScrolledToEnd\(float\)

Whether we are currently scrolled as far as possible into the scroll direction.

```csharp
public bool IsScrolledToEnd(float lenience = 0.001)
```

#### Parameters

`lenience` [float](https://learn.microsoft.com/dotnet/api/system.single)

How close to the extent we need to be.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_IsScrolledToStart_System_Single_"></a> IsScrolledToStart\(float\)

Whether we are currently scrolled to the beginning of content.

```csharp
public bool IsScrolledToStart(float lenience = 0.001)
```

#### Parameters

`lenience` [float](https://learn.microsoft.com/dotnet/api/system.single)

How close to the extent we need to be.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OffsetScrollPosition_System_Double_"></a> OffsetScrollPosition\(double\)

Immediately offsets the current and target scroll position.

```csharp
public virtual void OffsetScrollPosition(double offset)
```

#### Parameters

`offset` [double](https://learn.microsoft.com/dotnet/api/system.double)

The scroll offset.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnDrag_osu_Framework_Input_Events_DragEvent_"></a> OnDrag\(DragEvent\)

An event that occurs every time the mouse moves while dragging this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnDrag(DragEvent e)
```

#### Parameters

`e` [DragEvent](osu.Framework.Input.Events.DragEvent.md)

The <xref href="osu.Framework.Input.Events.DragEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that returned <pre><code class="lang-csharp">true</code></pre> from a previous <xref href="osu.Framework.Graphics.Drawable.OnDragStart(osu.Framework.Input.Events.DragStartEvent)" data-throw-if-not-resolved="false"></xref> invocation.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnDragEnd_osu_Framework_Input_Events_DragEndEvent_"></a> OnDragEnd\(DragEndEvent\)

An event that occurs when the mouse stops dragging this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void OnDragEnd(DragEndEvent e)
```

#### Parameters

`e` [DragEndEvent](osu.Framework.Input.Events.DragEndEvent.md)

The <xref href="osu.Framework.Input.Events.DragEndEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Remarks

This will only be invoked on the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that returned <pre><code class="lang-csharp">true</code></pre> from a previous <xref href="osu.Framework.Graphics.Drawable.OnDragStart(osu.Framework.Input.Events.DragStartEvent)" data-throw-if-not-resolved="false"></xref> invocation.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnDragStart_osu_Framework_Input_Events_DragStartEvent_"></a> OnDragStart\(DragStartEvent\)

An event that occurs when the mouse starts dragging on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override bool OnDragStart(DragStartEvent e)
```

#### Parameters

`e` [DragStartEvent](osu.Framework.Input.Events.DragStartEvent.md)

The <xref href="osu.Framework.Input.Events.DragEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnKeyDown_osu_Framework_Input_Events_KeyDownEvent_"></a> OnKeyDown\(KeyDownEvent\)

An event that occurs when a <xref href="osuTK.Input.Key" data-throw-if-not-resolved="false"></xref> is pressed.

```csharp
protected override bool OnKeyDown(KeyDownEvent e)
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

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnMouseDown_osu_Framework_Input_Events_MouseDownEvent_"></a> OnMouseDown\(MouseDownEvent\)

An event that occurs when a <xref href="osuTK.Input.MouseButton" data-throw-if-not-resolved="false"></xref> is pressed on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override bool OnMouseDown(MouseDownEvent e)
```

#### Parameters

`e` [MouseDownEvent](osu.Framework.Input.Events.MouseDownEvent.md)

The <xref href="osu.Framework.Input.Events.MouseDownEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnPressed_osu_Framework_Input_Events_KeyBindingPressEvent_osu_Framework_Input_PlatformAction__"></a> OnPressed\(KeyBindingPressEvent<PlatformAction\>\)

Triggered when an action is pressed.

```csharp
public bool OnPressed(KeyBindingPressEvent<PlatformAction> e)
```

#### Parameters

`e` [KeyBindingPressEvent](osu.Framework.Input.Events.KeyBindingPressEvent\-1.md)<[PlatformAction](osu.Framework.Input.PlatformAction.md)\>

The event containing information about the pressed action.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if this Drawable handled the event. If false, then the event
    is propagated up the scene graph to the next eligible Drawable.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnReleased_osu_Framework_Input_Events_KeyBindingReleaseEvent_osu_Framework_Input_PlatformAction__"></a> OnReleased\(KeyBindingReleaseEvent<PlatformAction\>\)

Triggered when an action is released.

```csharp
public void OnReleased(KeyBindingReleaseEvent<PlatformAction> e)
```

#### Parameters

`e` [KeyBindingReleaseEvent](osu.Framework.Input.Events.KeyBindingReleaseEvent\-1.md)<[PlatformAction](osu.Framework.Input.PlatformAction.md)\>

The event containing information about the released action.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnScroll_osu_Framework_Input_Events_ScrollEvent_"></a> OnScroll\(ScrollEvent\)

An event that occurs when the mouse wheel is scrolled on this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override bool OnScroll(ScrollEvent e)
```

#### Parameters

`e` [ScrollEvent](osu.Framework.Input.Events.ScrollEvent.md)

The <xref href="osu.Framework.Input.Events.ScrollEvent" data-throw-if-not-resolved="false"></xref> containing information about the input event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to block the event from propagating to other <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in the hierarchy.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_OnUserScroll_System_Double_System_Boolean_System_Nullable_System_Double__"></a> OnUserScroll\(double, bool, double?\)

Handle a scroll to an absolute position from a user input.

```csharp
protected virtual void OnUserScroll(double value, bool animated = true, double? distanceDecay = null)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

The position to scroll to.

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

`distanceDecay` [double](https://learn.microsoft.com/dotnet/api/system.double)?

Controls the rate with which the target position is approached after jumping to a specific location. Default is <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.DistanceDecayJump" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_RegisterForDependencyActivation_osu_Framework_Allocation_IDependencyActivatorRegistry_"></a> RegisterForDependencyActivation\(IDependencyActivatorRegistry\)

Invoked to register dependency activation functions for this object.

```csharp
public override void RegisterForDependencyActivation(IDependencyActivatorRegistry registry)
```

#### Parameters

`registry` [IDependencyActivatorRegistry](osu.Framework.Allocation.IDependencyActivatorRegistry.md)

The <xref href="osu.Framework.Allocation.IDependencyActivatorRegistry" data-throw-if-not-resolved="false"></xref> to register activation functions with.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollBy_System_Double_System_Boolean_"></a> ScrollBy\(double, bool\)

Scrolls to a new position relative to the current scroll offset.

```csharp
public void ScrollBy(double offset, bool animated = true)
```

#### Parameters

`offset` [double](https://learn.microsoft.com/dotnet/api/system.double)

The amount by which we should scroll.

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollIntoView_osu_Framework_Graphics_Drawable_System_Boolean_"></a> ScrollIntoView\(Drawable, bool\)

Scrolls a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> into view.

```csharp
public void ScrollIntoView(Drawable d, bool animated = true)
```

#### Parameters

`d` [Drawable](osu.Framework.Graphics.Drawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to scroll into view.

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollTo_System_Double_System_Boolean_System_Nullable_System_Double__"></a> ScrollTo\(double, bool, double?\)

Scrolls to an absolute position.

```csharp
public void ScrollTo(double value, bool animated = true, double? distanceDecay = null)
```

#### Parameters

`value` [double](https://learn.microsoft.com/dotnet/api/system.double)

The position to scroll to.

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

`distanceDecay` [double](https://learn.microsoft.com/dotnet/api/system.double)?

Controls the rate with which the target position is approached after jumping to a specific location. Default is <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.DistanceDecayJump" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollTo_osu_Framework_Graphics_Drawable_System_Boolean_"></a> ScrollTo\(Drawable, bool\)

Scrolls a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to the top.

```csharp
public void ScrollTo(Drawable d, bool animated = true)
```

#### Parameters

`d` [Drawable](osu.Framework.Graphics.Drawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to scroll to.

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollToEnd_System_Boolean_System_Boolean_"></a> ScrollToEnd\(bool, bool\)

Scroll to the end of available content.

```csharp
public void ScrollToEnd(bool animated = true, bool allowDuringDrag = false)
```

#### Parameters

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

`allowDuringDrag` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether we should interrupt a user's active drag.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ScrollToStart_System_Boolean_System_Boolean_"></a> ScrollToStart\(bool, bool\)

Scroll to the start of available content.

```csharp
public void ScrollToStart(bool animated = true, bool allowDuringDrag = false)
```

#### Parameters

`animated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether to animate the movement.

`allowDuringDrag` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether we should interrupt a user's active drag.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_ToScrollbarPosition_System_Double_"></a> ToScrollbarPosition\(double\)

Converts a scroll position to a scrollbar position.

```csharp
protected virtual float ToScrollbarPosition(double scrollPosition)
```

#### Parameters

`scrollPosition` [double](https://learn.microsoft.com/dotnet/api/system.double)

The absolute scroll position (e.g. <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601.Current" data-throw-if-not-resolved="false"></xref>).

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

The scrollbar position.

### <a id="osu_Framework_Graphics_Containers_ScrollContainer_1_UpdateAfterChildren"></a> UpdateAfterChildren\(\)

An opportunity to update state once-per-frame after <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref> has been called
for all <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.InternalChildren" data-throw-if-not-resolved="false"></xref>.
This is invoked prior to any autosize calculations of this <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override void UpdateAfterChildren()
```

