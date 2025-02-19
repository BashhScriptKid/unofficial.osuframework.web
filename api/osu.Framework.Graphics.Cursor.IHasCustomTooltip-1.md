# <a id="osu_Framework_Graphics_Cursor_IHasCustomTooltip_1"></a> Interface IHasCustomTooltip<TContent\>

Namespace: [osu.Framework.Graphics.Cursor](osu.Framework.Graphics.Cursor.md)  
Assembly: osu.Framework.dll  

Implementing this interface allows the implementing <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to display a custom tooltip if it is the child of a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref>.
Keep in mind that tooltips can only be displayed by a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> if the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> implementing <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> has <xref href="osu.Framework.Graphics.Drawable.HandlePositionalInput" data-throw-if-not-resolved="false"></xref> set to true.

```csharp
public interface IHasCustomTooltip<TContent> : IHasCustomTooltip, ITooltipContentProvider, IDrawable, ITransformable
```

#### Type Parameters

`TContent` 

#### Implements

[IHasCustomTooltip](osu.Framework.Graphics.Cursor.IHasCustomTooltip.md), 
[ITooltipContentProvider](osu.Framework.Graphics.Cursor.ITooltipContentProvider.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, params TransformSequence<IHasCustomTooltip<TContent\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, double, params TransformSequence<IHasCustomTooltip<TContent\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, double, int, params TransformSequence<IHasCustomTooltip<TContent\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, double, params TransformSequence<IHasCustomTooltip<TContent\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, params TransformSequence<IHasCustomTooltip<TContent\>\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IHasCustomTooltip<TContent\>, TValue\>\(IHasCustomTooltip<TContent\>, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IHasCustomTooltip<TContent\>, TEasing, TValue\>\(IHasCustomTooltip<TContent\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, Transform<TValue, DefaultEasingFunction, IHasCustomTooltip<TContent\>\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, Transform<TValue, TEasing, IHasCustomTooltip<TContent\>\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IHasCustomTooltip<TContent\>, TValue\>\(IHasCustomTooltip<TContent\>, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IHasCustomTooltip<TContent\>, TValue, TEasing\>\(IHasCustomTooltip<TContent\>, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IHasCustomTooltip<TContent\>, TValue\>\(IHasCustomTooltip<TContent\>, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IHasCustomTooltip<TContent\>, TValue, TEasing\>\(IHasCustomTooltip<TContent\>, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IHasCustomTooltip<TContent\>, TChild\>\(IHasCustomTooltip<TContent\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IHasCustomTooltip<TContent\>, TChild\>\(IHasCustomTooltip<TContent\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IHasCustomTooltip<TContent\>, TChild\>\(IHasCustomTooltip<TContent\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IHasCustomTooltip<TContent\>\>\(IHasCustomTooltip<TContent\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Cursor_IHasCustomTooltip_1_TooltipContent"></a> TooltipContent

Tooltip text that shows when hovering the drawable.

```csharp
TContent? TooltipContent { get; }
```

#### Property Value

 TContent?

## Methods

### <a id="osu_Framework_Graphics_Cursor_IHasCustomTooltip_1_GetCustomTooltip"></a> GetCustomTooltip\(\)

The custom tooltip that should be displayed.

```csharp
ITooltip<TContent> GetCustomTooltip()
```

#### Returns

 [ITooltip](osu.Framework.Graphics.Cursor.ITooltip\-1.md)<TContent\>

The custom tooltip that should be displayed.

#### Remarks

A tooltip may be reused between different drawables with different content if they share the same tooltip type.
Therefore it is recommended for all displayed content in the tooltip to be provided by <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip.TooltipContent" data-throw-if-not-resolved="false"></xref> instead.

