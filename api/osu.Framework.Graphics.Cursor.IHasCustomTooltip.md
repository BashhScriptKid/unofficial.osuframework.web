# <a id="osu_Framework_Graphics_Cursor_IHasCustomTooltip"></a> Interface IHasCustomTooltip

Namespace: [osu.Framework.Graphics.Cursor](osu.Framework.Graphics.Cursor.md)  
Assembly: osu.Framework.dll  

Implementing this interface allows the implementing <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to display a custom tooltip if it is the child of a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref>.
Keep in mind that tooltips can only be displayed by a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> if the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> implementing <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> has <xref href="osu.Framework.Graphics.Drawable.HandlePositionalInput" data-throw-if-not-resolved="false"></xref> set to true.

```csharp
public interface IHasCustomTooltip : ITooltipContentProvider, IDrawable, ITransformable
```

#### Implements

[ITooltipContentProvider](osu.Framework.Graphics.Cursor.ITooltipContentProvider.md), 
[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IHasCustomTooltip\>\(IHasCustomTooltip, params TransformSequence<IHasCustomTooltip\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IHasCustomTooltip\>\(IHasCustomTooltip?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IHasCustomTooltip\>\(IHasCustomTooltip, double, params TransformSequence<IHasCustomTooltip\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IHasCustomTooltip\>\(IHasCustomTooltip\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IHasCustomTooltip\>\(IHasCustomTooltip\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IHasCustomTooltip\>\(IHasCustomTooltip\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IHasCustomTooltip\>\(IHasCustomTooltip, double, int, params TransformSequence<IHasCustomTooltip\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IHasCustomTooltip\>\(IHasCustomTooltip, double, params TransformSequence<IHasCustomTooltip\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IHasCustomTooltip\>\(IHasCustomTooltip, params TransformSequence<IHasCustomTooltip\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IHasCustomTooltip\>\(IHasCustomTooltip, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[TransformableExtensions.MakeTransform<IHasCustomTooltip, TValue\>\(IHasCustomTooltip, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IHasCustomTooltip, TEasing, TValue\>\(IHasCustomTooltip, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IHasCustomTooltip\>\(IHasCustomTooltip, Transform<TValue, DefaultEasingFunction, IHasCustomTooltip\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IHasCustomTooltip\>\(IHasCustomTooltip, Transform<TValue, TEasing, IHasCustomTooltip\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[TransformableExtensions.TransformBindableTo<IHasCustomTooltip, TValue\>\(IHasCustomTooltip, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IHasCustomTooltip, TValue, TEasing\>\(IHasCustomTooltip, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IHasCustomTooltip, TValue\>\(IHasCustomTooltip, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IHasCustomTooltip, TValue, TEasing\>\(IHasCustomTooltip, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IHasCustomTooltip\>\(IHasCustomTooltip, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IHasCustomTooltip, TChild\>\(IHasCustomTooltip, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IHasCustomTooltip, TChild\>\(IHasCustomTooltip, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IHasCustomTooltip, TChild\>\(IHasCustomTooltip, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IHasCustomTooltip\>\(IHasCustomTooltip\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Cursor_IHasCustomTooltip_TooltipContent"></a> TooltipContent

Tooltip text that shows when hovering the drawable.

```csharp
object? TooltipContent { get; }
```

#### Property Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)?

## Methods

### <a id="osu_Framework_Graphics_Cursor_IHasCustomTooltip_GetCustomTooltip"></a> GetCustomTooltip\(\)

The custom tooltip that should be displayed.

```csharp
ITooltip GetCustomTooltip()
```

#### Returns

 [ITooltip](osu.Framework.Graphics.Cursor.ITooltip.md)

The custom tooltip that should be displayed.

#### Remarks

A tooltip may be reused between different drawables with different content if they share the same tooltip type.
Therefore it is recommended for all displayed content in the tooltip to be provided by <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip.TooltipContent" data-throw-if-not-resolved="false"></xref> instead.

