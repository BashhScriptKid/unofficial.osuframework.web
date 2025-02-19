# <a id="osu_Framework_Graphics_Cursor_ITooltip_1"></a> Interface ITooltip<T\>

Namespace: [osu.Framework.Graphics.Cursor](osu.Framework.Graphics.Cursor.md)  
Assembly: osu.Framework.dll  

A tooltip that can be used in conjunction with a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> and/or <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> implementation.

```csharp
public interface ITooltip<in T> : ITooltip, IDrawable, ITransformable
```

#### Type Parameters

`T` 

#### Implements

[ITooltip](osu.Framework.Graphics.Cursor.ITooltip.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<ITooltip<T\>\>\(ITooltip<T\>, params TransformSequence<ITooltip<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<ITooltip<T\>\>\(ITooltip<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<ITooltip<T\>\>\(ITooltip<T\>, double, params TransformSequence<ITooltip<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITooltip<T\>\>\(ITooltip<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITooltip<T\>\>\(ITooltip<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITooltip<T\>\>\(ITooltip<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<ITooltip<T\>\>\(ITooltip<T\>, double, int, params TransformSequence<ITooltip<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ITooltip<T\>\>\(ITooltip<T\>, double, params TransformSequence<ITooltip<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ITooltip<T\>\>\(ITooltip<T\>, params TransformSequence<ITooltip<T\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<ITooltip<T\>\>\(ITooltip<T\>, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<ITooltip<T\>, TValue\>\(ITooltip<T\>, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<ITooltip<T\>, TEasing, TValue\>\(ITooltip<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, ITooltip<T\>\>\(ITooltip<T\>, Transform<TValue, DefaultEasingFunction, ITooltip<T\>\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, ITooltip<T\>\>\(ITooltip<T\>, Transform<TValue, TEasing, ITooltip<T\>\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<ITooltip<T\>, TValue\>\(ITooltip<T\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<ITooltip<T\>, TValue, TEasing\>\(ITooltip<T\>, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<ITooltip<T\>, TValue\>\(ITooltip<T\>, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<ITooltip<T\>, TValue, TEasing\>\(ITooltip<T\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<ITooltip<T\>\>\(ITooltip<T\>, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<ITooltip<T\>, TChild\>\(ITooltip<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITooltip<T\>, TChild\>\(ITooltip<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITooltip<T\>, TChild\>\(ITooltip<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITooltip<T\>\>\(ITooltip<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Cursor_ITooltip_1_SetContent__0_"></a> SetContent\(T\)

Set new content be displayed on this tooltip.

```csharp
void SetContent(T content)
```

#### Parameters

`content` T

The content to be displayed.

