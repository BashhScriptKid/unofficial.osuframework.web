# <a id="osu_Framework_Input_MouseButtonEventManager"></a> Class MouseButtonEventManager

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

Manages state and events (click, drag and double-click) for a single mouse button.

```csharp
public abstract class MouseButtonEventManager : ButtonEventManager<MouseButton>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonEventManager<MouseButton\>](osu.Framework.Input.ButtonEventManager\-1.md) ← 
[MouseButtonEventManager](osu.Framework.Input.MouseButtonEventManager.md)

#### Inherited Members

[ButtonEventManager<MouseButton\>.Button](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_Button), 
[ButtonEventManager<MouseButton\>.ButtonDownInputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_ButtonDownInputQueue), 
[ButtonEventManager<MouseButton\>.InputQueue](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_InputQueue), 
[ButtonEventManager<MouseButton\>.HandleButtonStateChange\(InputState, ButtonStateChangeKind\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonStateChange\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonEventManager<MouseButton\>.HandleButtonDown\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonDown\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<MouseButton\>.HandleButtonUp\(InputState, List<Drawable\>\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_HandleButtonUp\_osu\_Framework\_Input\_States\_InputState\_System\_Collections\_Generic\_List\_osu\_Framework\_Graphics\_Drawable\_\_), 
[ButtonEventManager<MouseButton\>.PropagateButtonEvent\(IEnumerable<Drawable\>, UIEvent\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_PropagateButtonEvent\_System\_Collections\_Generic\_IEnumerable\_osu\_Framework\_Graphics\_Drawable\_\_osu\_Framework\_Input\_Events\_UIEvent\_), 
[ButtonEventManager<MouseButton\>.SuppressLoggingEventInformation\(Drawable\)](osu.Framework.Input.ButtonEventManager\-1.md\#osu\_Framework\_Input\_ButtonEventManager\_1\_SuppressLoggingEventInformation\_osu\_Framework\_Graphics\_Drawable\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MouseButtonEventManager\>\(MouseButtonEventManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseButtonEventManager\>\(MouseButtonEventManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseButtonEventManager\>\(MouseButtonEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseButtonEventManager\>\(MouseButtonEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseButtonEventManager, TChild\>\(MouseButtonEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseButtonEventManager, TChild\>\(MouseButtonEventManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseButtonEventManager, TChild\>\(MouseButtonEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseButtonEventManager\>\(MouseButtonEventManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_MouseButtonEventManager__ctor_osuTK_Input_MouseButton_"></a> MouseButtonEventManager\(MouseButton\)

```csharp
protected MouseButtonEventManager(MouseButton button)
```

#### Parameters

`button` MouseButton

## Fields

### <a id="osu_Framework_Input_MouseButtonEventManager_ClickedDrawable"></a> ClickedDrawable

The drawable which is clicked by the last click.

```csharp
protected WeakReference<Drawable> ClickedDrawable
```

#### Field Value

 [WeakReference](https://learn.microsoft.com/dotnet/api/system.weakreference\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Input_MouseButtonEventManager_DragStarted"></a> DragStarted

Whether a drag operation has started and <xref href="osu.Framework.Input.MouseButtonEventManager.DraggedDrawable" data-throw-if-not-resolved="false"></xref> has been searched for.

```csharp
protected bool DragStarted
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_MouseButtonEventManager_LastClickTime"></a> LastClickTime

The time of last click.

```csharp
protected double? LastClickTime
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

## Properties

### <a id="osu_Framework_Input_MouseButtonEventManager_ChangeFocusOnClick"></a> ChangeFocusOnClick

Whether focus is changed when the button is clicked.

```csharp
public abstract bool ChangeFocusOnClick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_MouseButtonEventManager_ClickDragDistance"></a> ClickDragDistance

The distance that must be moved until a dragged click becomes invalid.

```csharp
public virtual float ClickDragDistance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Input_MouseButtonEventManager_DoubleClickTime"></a> DoubleClickTime

The maximum time between two clicks for a double-click to be considered.

```csharp
public virtual float DoubleClickTime { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Input_MouseButtonEventManager_DraggedDrawable"></a> DraggedDrawable

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which is currently being dragged. null if none is.

```csharp
public Drawable? DraggedDrawable { get; protected set; }
```

#### Property Value

 [Drawable](osu.Framework.Graphics.Drawable.md)?

### <a id="osu_Framework_Input_MouseButtonEventManager_EnableClick"></a> EnableClick

Whether click and double click are handled by the managed button.

```csharp
public abstract bool EnableClick { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_MouseButtonEventManager_EnableDrag"></a> EnableDrag

Whether dragging is handled by the managed button.

```csharp
public abstract bool EnableDrag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_MouseButtonEventManager_MouseDownPosition"></a> MouseDownPosition

The position of the mouse when the last time the button is pressed.

```csharp
public Vector2? MouseDownPosition { get; protected set; }
```

#### Property Value

 Vector2?

## Methods

### <a id="osu_Framework_Input_MouseButtonEventManager_HandleButtonDown_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonDown\(InputState, List<Drawable\>\)

Handles the button being pressed.

```csharp
protected override Drawable? HandleButtonDown(InputState state, List<Drawable> targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The list of possible targets that can handle the event.

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)?

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that handled the event.

### <a id="osu_Framework_Input_MouseButtonEventManager_HandleButtonUp_osu_Framework_Input_States_InputState_System_Collections_Generic_List_osu_Framework_Graphics_Drawable__"></a> HandleButtonUp\(InputState, List<Drawable\>?\)

Handles the button being released.

```csharp
protected override void HandleButtonUp(InputState state, List<Drawable>? targets)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`targets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>?

The list of targets that must handle the event. This will contain targets up to the target that handled the button down event.

### <a id="osu_Framework_Input_MouseButtonEventManager_HandlePositionChange_osu_Framework_Input_States_InputState_osuTK_Vector2_"></a> HandlePositionChange\(InputState, Vector2\)

```csharp
public void HandlePositionChange(InputState state, Vector2 lastPosition)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`lastPosition` Vector2

