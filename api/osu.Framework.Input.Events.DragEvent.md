# <a id="osu_Framework_Input_Events_DragEvent"></a> Class DragEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

An event representing a mouse drag.
Triggered when mouse is moved while dragging.

```csharp
public class DragEvent : MouseButtonEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[MouseEvent](osu.Framework.Input.Events.MouseEvent.md) ← 
[MouseButtonEvent](osu.Framework.Input.Events.MouseButtonEvent.md) ← 
[DragEvent](osu.Framework.Input.Events.DragEvent.md)

#### Inherited Members

[MouseButtonEvent.Button](osu.Framework.Input.Events.MouseButtonEvent.md\#osu\_Framework\_Input\_Events\_MouseButtonEvent\_Button), 
[MouseButtonEvent.ScreenSpaceMouseDownPosition](osu.Framework.Input.Events.MouseButtonEvent.md\#osu\_Framework\_Input\_Events\_MouseButtonEvent\_ScreenSpaceMouseDownPosition), 
[MouseButtonEvent.MouseDownPosition](osu.Framework.Input.Events.MouseButtonEvent.md\#osu\_Framework\_Input\_Events\_MouseButtonEvent\_MouseDownPosition), 
[MouseButtonEvent.ToString\(\)](osu.Framework.Input.Events.MouseButtonEvent.md\#osu\_Framework\_Input\_Events\_MouseButtonEvent\_ToString), 
[MouseEvent.IsPressed\(MouseButton\)](osu.Framework.Input.Events.MouseEvent.md\#osu\_Framework\_Input\_Events\_MouseEvent\_IsPressed\_osuTK\_Input\_MouseButton\_), 
[MouseEvent.HasAnyButtonPressed](osu.Framework.Input.Events.MouseEvent.md\#osu\_Framework\_Input\_Events\_MouseEvent\_HasAnyButtonPressed), 
[MouseEvent.PressedButtons](osu.Framework.Input.Events.MouseEvent.md\#osu\_Framework\_Input\_Events\_MouseEvent\_PressedButtons), 
[UIEvent.CurrentState](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_CurrentState), 
[UIEvent.Target](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_Target), 
[UIEvent.ToLocalSpace\(Vector2\)](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ToLocalSpace\_osuTK\_Vector2\_), 
[UIEvent.ScreenSpaceMousePosition](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ScreenSpaceMousePosition), 
[UIEvent.MousePosition](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_MousePosition), 
[UIEvent.ControlPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ControlPressed), 
[UIEvent.AltPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_AltPressed), 
[UIEvent.ShiftPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ShiftPressed), 
[UIEvent.SuperPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_SuperPressed), 
[UIEvent.ToString\(\)](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DragEvent\>\(DragEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DragEvent\>\(DragEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DragEvent\>\(DragEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DragEvent\>\(DragEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DragEvent, TChild\>\(DragEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DragEvent, TChild\>\(DragEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DragEvent, TChild\>\(DragEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DragEvent\>\(DragEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_DragEvent__ctor_osu_Framework_Input_States_InputState_osuTK_Input_MouseButton_System_Nullable_osuTK_Vector2__System_Nullable_osuTK_Vector2__"></a> DragEvent\(InputState, MouseButton, Vector2?, Vector2?\)

```csharp
public DragEvent(InputState state, MouseButton button, Vector2? screenSpaceMousePosition = null, Vector2? screenSpaceLastMousePosition = null)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`button` MouseButton

`screenSpaceMousePosition` Vector2?

`screenSpaceLastMousePosition` Vector2?

## Fields

### <a id="osu_Framework_Input_Events_DragEvent_ScreenSpaceLastMousePosition"></a> ScreenSpaceLastMousePosition

The last mouse position before this mouse move in the screen space.

```csharp
public readonly Vector2 ScreenSpaceLastMousePosition
```

#### Field Value

 Vector2

## Properties

### <a id="osu_Framework_Input_Events_DragEvent_Delta"></a> Delta

The difference of mouse position from last position to current position in local space.

```csharp
public Vector2 Delta { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Input_Events_DragEvent_LastMousePosition"></a> LastMousePosition

The last mouse position before this mouse move in local space.

```csharp
public Vector2 LastMousePosition { get; }
```

#### Property Value

 Vector2

