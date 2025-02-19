# <a id="osu_Framework_Input_Bindings_IScrollBindingHandler_1"></a> Interface IScrollBindingHandler<T\>

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

A drawable that handles scroll actions.

```csharp
public interface IScrollBindingHandler<T> : IKeyBindingHandler<T>, IKeyBindingHandler, IDrawable, ITransformable where T : struct
```

#### Type Parameters

`T` 

The type of bindings.

#### Implements

[IKeyBindingHandler<T\>](osu.Framework.Input.Bindings.IKeyBindingHandler\-1.md), 
[IKeyBindingHandler](osu.Framework.Input.Bindings.IKeyBindingHandler.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, params TransformSequence<IScrollBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, double, params TransformSequence<IScrollBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, double, int, params TransformSequence<IScrollBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, double, params TransformSequence<IScrollBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, params TransformSequence<IScrollBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IScrollBindingHandler<T\>, TValue\>\(IScrollBindingHandler<T\>, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IScrollBindingHandler<T\>, TEasing, TValue\>\(IScrollBindingHandler<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, Transform<TValue, DefaultEasingFunction, IScrollBindingHandler<T\>\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, Transform<TValue, TEasing, IScrollBindingHandler<T\>\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IScrollBindingHandler<T\>, TValue\>\(IScrollBindingHandler<T\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IScrollBindingHandler<T\>, TValue, TEasing\>\(IScrollBindingHandler<T\>, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IScrollBindingHandler<T\>, TValue\>\(IScrollBindingHandler<T\>, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IScrollBindingHandler<T\>, TValue, TEasing\>\(IScrollBindingHandler<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IScrollBindingHandler<T\>, TChild\>\(IScrollBindingHandler<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IScrollBindingHandler<T\>, TChild\>\(IScrollBindingHandler<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IScrollBindingHandler<T\>, TChild\>\(IScrollBindingHandler<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IScrollBindingHandler<T\>\>\(IScrollBindingHandler<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Input_Bindings_IScrollBindingHandler_1_OnScroll_osu_Framework_Input_Events_KeyBindingScrollEvent__0__"></a> OnScroll\(KeyBindingScrollEvent<T\>\)

Triggered when a scroll action is pressed.

```csharp
bool OnScroll(KeyBindingScrollEvent<T> e)
```

#### Parameters

`e` [KeyBindingScrollEvent](osu.Framework.Input.Events.KeyBindingScrollEvent\-1.md)<T\>

The event containing information about the scroll.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if this Drawable handled the event. If false, then the event
    is propagated up the scene graph to the next eligible Drawable.

#### Remarks

When the action is not handled by any <xref href="osu.Framework.Input.Bindings.IScrollBindingHandler%601" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Input.Bindings.IKeyBindingHandler%601.OnPressed(osu.Framework.Input.Events.KeyBindingPressEvent%7b%600%7d)" data-throw-if-not-resolved="false"></xref> is called.
In either cases, <xref href="osu.Framework.Input.Bindings.IKeyBindingHandler%601.OnReleased(osu.Framework.Input.Events.KeyBindingReleaseEvent%7b%600%7d)" data-throw-if-not-resolved="false"></xref> will be called once.

