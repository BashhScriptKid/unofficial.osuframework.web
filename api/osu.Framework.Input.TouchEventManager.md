# <a id="osu_Framework_Input_TouchEventManager"></a> Class TouchEventManager

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

A manager that manages states and events for a single touch.

```csharp
public class TouchEventManager : ButtonEventManager<TouchSource>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonEventManager<TouchSource\>](osu.Framework.Input.ButtonEventManager\-1.md) ← 
[TouchEventManager](osu.Framework.Input.TouchEventManager.md)

#### Inherited Members

[ButtonEventManager<TouchSource\>.Button](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_Button), 
[ButtonEventManager<TouchSource\>.ButtonDownInputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_ButtonDownInputQueue), 
[ButtonEventManager<TouchSource\>.InputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_InputQueue), 
[ButtonEventManager<TouchSource\>.HandleButtonStateChange\(InputState, ButtonStateChangeKind\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonStateChange\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonEventManager<TouchSource\>.HandleButtonDown\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonDown\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<TouchSource\>.HandleButtonUp\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonUp\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<TouchSource\>.PropagateButtonEvent\(IEnumerable<Drawable\>, UIEvent\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_PropagateButtonEvent\_System\_Collections\_Generic\_IEnumerable\_osu\_Framework\_Graphics\_Drawable\_\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[ButtonEventManager<TouchSource\>.SuppressLoggingEventInformation\(Drawable\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_SuppressLoggingEventInformation\_osu\_Framework\_Graphics\_Drawable\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TouchEventManager\>\(TouchEventManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TouchEventManager\>\(TouchEventManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TouchEventManager\>\(TouchEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TouchEventManager\>\(TouchEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TouchEventManager, TChild\>\(TouchEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TouchEventManager, TChild\>\(TouchEventManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TouchEventManager, TChild\>\(TouchEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TouchEventManager\>\(TouchEventManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_TouchEventManager__ctor_osu_Framework_Input_TouchSource_"></a> TouchEventManager\(TouchSource\)

```csharp
public TouchEventManager(TouchSource source)
```

#### Parameters

`source` [TouchSource](osu.Framework.Input.TouchSource.md)

## Properties

### <a id="osu_Framework_Input_TouchEventManager_HeldDrawable"></a> HeldDrawable

The drawable from the input queue that handled a <xref href="osu.Framework.Input.Events.TouchDownEvent" data-throw-if-not-resolved="false"></xref> corresponding to this touch source.

```csharp
public Drawable HeldDrawable { get; }
```

#### Property Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

### <a id="osu_Framework_Input_TouchEventManager_TouchDownPosition"></a> TouchDownPosition

```csharp
public Vector2? TouchDownPosition { get; }
```

#### Property Value

 Vector2?

## Methods

### <a id="osu_Framework_Input_TouchEventManager_HandleButtonDown_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonDown\(InputState, List<Drawable\>\)

Handles the button being pressed.

```csharp
protected override Drawable HandleButtonDown(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of possible targets that can handle the event.

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that handled the event.

### <a id="osu_Framework_Input_TouchEventManager_HandleButtonUp_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonUp\(InputState, List<Drawable\>\)

Handles the button being released.

```csharp
protected override void HandleButtonUp(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of targets that must handle the event. This will contain targets up to the target that handled the button down event.

### <a id="osu_Framework_Input_TouchEventManager_HandlePositionChange_osu_Framework_Input_States_InputState_osuTK_Vector2_"></a> HandlePositionChange\(InputState, Vector2\)

```csharp
public void HandlePositionChange(InputState state, Vector2 lastPosition)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`lastPosition` Vector2

