# <a id="osu_Framework_Graphics_Containers_IContainerCollection_1"></a> Interface IContainerCollection<T\>

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IContainerCollection<in T> : IContainer, IDrawable, ITransformable where T : class, IDrawable
```

#### Type Parameters

`T` 

#### Implements

[IContainer](osu.Framework.Graphics.Containers.IContainer.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IContainerCollection<T\>\>\(IContainerCollection<T\>, params TransformSequence<IContainerCollection<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IContainerCollection<T\>\>\(IContainerCollection<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IContainerCollection<T\>\>\(IContainerCollection<T\>, double, params TransformSequence<IContainerCollection<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<IContainerCollection<T\>\>\(IContainerCollection<T\>, float, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_System\_Single\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<IContainerCollection<T\>\>\(IContainerCollection<T\>, Color4, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_1\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.FadeEdgeEffectTo<IContainerCollection<T\>, TEasing\>\(IContainerCollection<T\>, float, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_System\_Single\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.FadeEdgeEffectTo<IContainerCollection<T\>, TEasing\>\(IContainerCollection<T\>, Color4, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_FadeEdgeEffectTo\_\_2\_\_\_0\_osuTK\_Graphics\_Color4\_System\_Double\_\_\_1\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IContainerCollection<T\>\>\(IContainerCollection<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IContainerCollection<T\>\>\(IContainerCollection<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IContainerCollection<T\>\>\(IContainerCollection<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IContainerCollection<T\>\>\(IContainerCollection<T\>, double, int, params TransformSequence<IContainerCollection<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IContainerCollection<T\>\>\(IContainerCollection<T\>, double, params TransformSequence<IContainerCollection<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IContainerCollection<T\>\>\(IContainerCollection<T\>, params TransformSequence<IContainerCollection<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IContainerCollection<T\>\>\(IContainerCollection<T\>, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IContainerCollection<T\>, TValue\>\(IContainerCollection<T\>, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IContainerCollection<T\>, TEasing, TValue\>\(IContainerCollection<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IContainerCollection<T\>\>\(IContainerCollection<T\>, Transform<TValue, DefaultEasingFunction, IContainerCollection<T\>\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IContainerCollection<T\>\>\(IContainerCollection<T\>, Transform<TValue, TEasing, IContainerCollection<T\>\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IContainerCollection<T\>, TValue\>\(IContainerCollection<T\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IContainerCollection<T\>, TValue, TEasing\>\(IContainerCollection<T\>, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<IContainerCollection<T\>\>\(IContainerCollection<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildOffsetTo<IContainerCollection<T\>, TEasing\>\(IContainerCollection<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildOffsetTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<IContainerCollection<T\>\>\(IContainerCollection<T\>, Vector2, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_1\_\_\_0\_osuTK\_Vector2\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformRelativeChildSizeTo<IContainerCollection<T\>, TEasing\>\(IContainerCollection<T\>, Vector2, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformRelativeChildSizeTo\_\_2\_\_\_0\_osuTK\_Vector2\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformTo<IContainerCollection<T\>, TValue\>\(IContainerCollection<T\>, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IContainerCollection<T\>, TValue, TEasing\>\(IContainerCollection<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IContainerCollection<T\>\>\(IContainerCollection<T\>, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[TransformableExtensions.TweenEdgeEffectTo<IContainerCollection<T\>\>\(IContainerCollection<T\>, EdgeEffectParameters, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TweenEdgeEffectTo<IContainerCollection<T\>, TEasing\>\(IContainerCollection<T\>, EdgeEffectParameters, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TweenEdgeEffectTo\_\_2\_\_\_0\_osu\_Framework\_Graphics\_Effects\_EdgeEffectParameters\_System\_Double\_\_\_1\_\_), 
[ContainerExtensions.WithChild<IContainerCollection<T\>, TChild\>\(IContainerCollection<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IContainerCollection<T\>, TChild\>\(IContainerCollection<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IContainerCollection<T\>, TChild\>\(IContainerCollection<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IContainerCollection<T\>\>\(IContainerCollection<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_Child"></a> Child

```csharp
T Child { set; }
```

#### Property Value

 T

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_Children"></a> Children

```csharp
IReadOnlyList<in T> Children { set; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<T\>

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_ChildrenEnumerable"></a> ChildrenEnumerable

```csharp
IEnumerable<in T> ChildrenEnumerable { set; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

## Methods

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_Add__0_"></a> Add\(T\)

```csharp
void Add(T drawable)
```

#### Parameters

`drawable` T

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_AddRange_System_Collections_Generic_IEnumerable__0__"></a> AddRange\(IEnumerable<T\>\)

```csharp
void AddRange(IEnumerable<in T> collection)
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_Remove__0_System_Boolean_"></a> Remove\(T, bool\)

Remove the provided drawable from this container's children.

```csharp
bool Remove(T drawable, bool disposeImmediately)
```

#### Parameters

`drawable` T

The drawable to be removed.

`disposeImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether removed item should be immediately disposed.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the drawable was removed.

#### Remarks

<code class="paramref">disposeImmediately</code> should be <code>true</code> unless the removed item is to be re-used in the future.
If <code>false</code>, ensure the removed item is manually disposed (or added back to another part of the hierarchy) else
object leakage may occur.

### <a id="osu_Framework_Graphics_Containers_IContainerCollection_1_RemoveRange_System_Collections_Generic_IEnumerable__0__System_Boolean_"></a> RemoveRange\(IEnumerable<T\>, bool\)

Remove all matching children from this container.

```csharp
void RemoveRange(IEnumerable<in T> range, bool disposeImmediately)
```

#### Parameters

`range` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

The drawables to be removed.

`disposeImmediately` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether removed items should be immediately disposed.

#### Remarks

<code class="paramref">disposeImmediately</code> should be <code>true</code> unless the removed items are to be re-used in the future.
If <code>false</code>, ensure removed items are manually disposed else object leakage may occur.

