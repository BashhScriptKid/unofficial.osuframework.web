# <a id="osu_Framework_Screens_IScreen"></a> Interface IScreen

Namespace: [osu.Framework.Screens](osu.Framework.Screens.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IScreen : IDrawable, ITransformable
```

#### Implements

[IDrawable](osu.Framework.Graphics.IDrawable.md), 
[ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

#### Extension Methods

[TransformableExtensions.Animate<IScreen\>\(IScreen, params TransformSequence<IScreen\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Animate\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ObjectExtensions.AsNonNull<IScreen\>\(IScreen?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Delay<IScreen\>\(IScreen, double, params TransformSequence<IScreen\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Delay\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[ScreenExtensions.Exit\(IScreen\)](osu.Framework.Screens.ScreenExtensions.md\#osu\_Framework\_Screens\_ScreenExtensions\_Exit\_osu\_Framework\_Screens\_IScreen\_), 
[ScreenExtensions.GetChildScreen\(IScreen\)](osu.Framework.Screens.ScreenExtensions.md\#osu\_Framework\_Screens\_ScreenExtensions\_GetChildScreen\_osu\_Framework\_Screens\_IScreen\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IScreen\>\(IScreen\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ScreenExtensions.GetParentScreen\(IScreen\)](osu.Framework.Screens.ScreenExtensions.md\#osu\_Framework\_Screens\_ScreenExtensions\_GetParentScreen\_osu\_Framework\_Screens\_IScreen\_), 
[ScreenExtensions.IsCurrentScreen\(IScreen\)](osu.Framework.Screens.ScreenExtensions.md\#osu\_Framework\_Screens\_ScreenExtensions\_IsCurrentScreen\_osu\_Framework\_Screens\_IScreen\_), 
[ObjectExtensions.IsNotNull<IScreen\>\(IScreen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IScreen\>\(IScreen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[TransformableExtensions.Loop<IScreen\>\(IScreen, double, int, params TransformSequence<IScreen\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_System\_Int32\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IScreen\>\(IScreen, double, params TransformSequence<IScreen\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IScreen\>\(IScreen, params TransformSequence<IScreen\>.Generator\[\]\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_TransformSequence\_\_\_0\_\_Generator\_\_\_), 
[TransformableExtensions.Loop<IScreen\>\(IScreen, double\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_Loop\_\_1\_\_\_0\_System\_Double\_), 
[ScreenExtensions.MakeCurrent\(IScreen\)](osu.Framework.Screens.ScreenExtensions.md\#osu\_Framework\_Screens\_ScreenExtensions\_MakeCurrent\_osu\_Framework\_Screens\_IScreen\_), 
[TransformableExtensions.MakeTransform<IScreen, TValue\>\(IScreen, string, TValue, double, Easing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_System\_String\_), 
[TransformableExtensions.MakeTransform<IScreen, TEasing, TValue\>\(IScreen, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_MakeTransform\_\_3\_\_\_0\_System\_String\_\_\_2\_System\_Double\_\_\_1\_\_System\_String\_), 
[TransformableExtensions.PopulateTransform<TValue, IScreen\>\(IScreen, Transform<TValue, DefaultEasingFunction, IScreen\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_2\_\_\_1\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_DefaultEasingFunction\_\_\_1\_\_\_\_0\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.PopulateTransform<TValue, TEasing, IScreen\>\(IScreen, Transform<TValue, TEasing, IScreen\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_PopulateTransform\_\_3\_\_\_2\_osu\_Framework\_Graphics\_Transforms\_Transform\_\_\_0\_\_\_1\_\_\_2\_\_\_\_0\_System\_Double\_\_\_1\_\_), 
[ScreenExtensions.Push\(IScreen, IScreen\)](osu.Framework.Screens.ScreenExtensions.md\#osu\_Framework\_Screens\_ScreenExtensions\_Push\_osu\_Framework\_Screens\_IScreen\_osu\_Framework\_Screens\_IScreen\_), 
[TransformableExtensions.TransformBindableTo<IScreen, TValue\>\(IScreen, Bindable<TValue\>, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_2\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformBindableTo<IScreen, TValue, TEasing\>\(IScreen, Bindable<TValue\>, TValue, double, in TEasing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformBindableTo\_\_3\_\_\_0\_osu\_Framework\_Bindables\_Bindable\_\_\_1\_\_\_\_1\_System\_Double\_\_\_2\_\_), 
[TransformableExtensions.TransformTo<IScreen, TValue\>\(IScreen, string, TValue, double, Easing\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_2\_\_\_0\_System\_String\_\_\_1\_System\_Double\_osu\_Framework\_Graphics\_Easing\_), 
[TransformableExtensions.TransformTo<IScreen, TValue, TEasing\>\(IScreen, string, TValue, double, in TEasing, string\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_3\_\_\_0\_System\_String\_\_\_1\_System\_Double\_\_\_2\_\_System\_String\_), 
[TransformableExtensions.TransformTo<IScreen\>\(IScreen, Transform\)](osu.Framework.Graphics.TransformableExtensions.md\#osu\_Framework\_Graphics\_TransformableExtensions\_TransformTo\_\_1\_\_\_0\_osu\_Framework\_Graphics\_Transforms\_Transform\_), 
[ContainerExtensions.WithChild<IScreen, TChild\>\(IScreen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IScreen, TChild\>\(IScreen, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IScreen, TChild\>\(IScreen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IScreen\>\(IScreen\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Screens_IScreen_ValidForPush"></a> ValidForPush

Whether this <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> can be pushed.

```csharp
bool ValidForPush { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Screens_IScreen_ValidForResume"></a> ValidForResume

Whether this <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> can be resumed.

```csharp
bool ValidForResume { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Screens_IScreen_OnEntering_osu_Framework_Screens_ScreenTransitionEvent_"></a> OnEntering\(ScreenTransitionEvent\)

Invoked when this <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> is entering from a parent <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
void OnEntering(ScreenTransitionEvent e)
```

#### Parameters

`e` [ScreenTransitionEvent](osu.Framework.Screens.ScreenTransitionEvent.md)

The <xref href="osu.Framework.Screens.ScreenTransitionEvent" data-throw-if-not-resolved="false"></xref> containing information about the screen event.

### <a id="osu_Framework_Screens_IScreen_OnExiting_osu_Framework_Screens_ScreenExitEvent_"></a> OnExiting\(ScreenExitEvent\)

Invoked when this <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> is exiting to a parent <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
bool OnExiting(ScreenExitEvent e)
```

#### Parameters

`e` [ScreenExitEvent](osu.Framework.Screens.ScreenExitEvent.md)

The <xref href="osu.Framework.Screens.ScreenExitEvent" data-throw-if-not-resolved="false"></xref> containing information about the screen event.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

True to cancel the exit process.

### <a id="osu_Framework_Screens_IScreen_OnResuming_osu_Framework_Screens_ScreenTransitionEvent_"></a> OnResuming\(ScreenTransitionEvent\)

Invoked when this <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> is entered from a child <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
void OnResuming(ScreenTransitionEvent e)
```

#### Parameters

`e` [ScreenTransitionEvent](osu.Framework.Screens.ScreenTransitionEvent.md)

The <xref href="osu.Framework.Screens.ScreenTransitionEvent" data-throw-if-not-resolved="false"></xref> containing information about the screen event.

### <a id="osu_Framework_Screens_IScreen_OnSuspending_osu_Framework_Screens_ScreenTransitionEvent_"></a> OnSuspending\(ScreenTransitionEvent\)

Invoked when this <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref> is exited to a child <xref href="osu.Framework.Screens.IScreen" data-throw-if-not-resolved="false"></xref>.

```csharp
void OnSuspending(ScreenTransitionEvent e)
```

#### Parameters

`e` [ScreenTransitionEvent](osu.Framework.Screens.ScreenTransitionEvent.md)

The <xref href="osu.Framework.Screens.ScreenTransitionEvent" data-throw-if-not-resolved="false"></xref> containing information about the screen event.

