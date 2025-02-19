# <a id="osu_Framework_Input_Bindings_IKeyBindingHandler_1"></a> Interface IKeyBindingHandler<T\>

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

A drawable that handles key bindings.

```csharp
public interface IKeyBindingHandler<T> : IKeyBindingHandler, IDrawable, ITransformable where T : struct
```

#### Type Parameters

`T` 

The type of bindings, commonly an enum.

#### Implements

[IKeyBindingHandler](osu.Framework.Input.Bindings.IKeyBindingHandler.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, params TransformSequence<IKeyBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, double, params TransformSequence<IKeyBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, double, int, params TransformSequence<IKeyBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, double, params TransformSequence<IKeyBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, params TransformSequence<IKeyBindingHandler<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IKeyBindingHandler<T\>, TValue\>\(IKeyBindingHandler<T\>, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IKeyBindingHandler<T\>, TEasing, TValue\>\(IKeyBindingHandler<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, Transform<TValue, DefaultEasingFunction, IKeyBindingHandler<T\>\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, Transform<TValue, TEasing, IKeyBindingHandler<T\>\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IKeyBindingHandler<T\>, TValue\>\(IKeyBindingHandler<T\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IKeyBindingHandler<T\>, TValue, TEasing\>\(IKeyBindingHandler<T\>, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IKeyBindingHandler<T\>, TValue\>\(IKeyBindingHandler<T\>, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IKeyBindingHandler<T\>, TValue, TEasing\>\(IKeyBindingHandler<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IKeyBindingHandler<T\>, TChild\>\(IKeyBindingHandler<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IKeyBindingHandler<T\>, TChild\>\(IKeyBindingHandler<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IKeyBindingHandler<T\>, TChild\>\(IKeyBindingHandler<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IKeyBindingHandler<T\>\>\(IKeyBindingHandler<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Input_Bindings_IKeyBindingHandler_1_OnPressed_osu_Framework_Input_Events_KeyBindingPressEvent__0__"></a> OnPressed\(KeyBindingPressEvent<T\>\)

Triggered when an action is pressed.

```csharp
bool OnPressed(KeyBindingPressEvent<T> e)
```

#### Parameters

`e` [KeyBindingPressEvent](osu.Framework.Input.Events.KeyBindingPressEvent\-1.md)<T\>

The event containing information about the pressed action.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True if this Drawable handled the event. If false, then the event
    is propagated up the scene graph to the next eligible Drawable.

### <a id="osu_Framework_Input_Bindings_IKeyBindingHandler_1_OnReleased_osu_Framework_Input_Events_KeyBindingReleaseEvent__0__"></a> OnReleased\(KeyBindingReleaseEvent<T\>\)

Triggered when an action is released.

```csharp
void OnReleased(KeyBindingReleaseEvent<T> e)
```

#### Parameters

`e` [KeyBindingReleaseEvent](osu.Framework.Input.Events.KeyBindingReleaseEvent\-1.md)<T\>

The event containing information about the released action.

