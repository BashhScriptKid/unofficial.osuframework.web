# <a id="osu_Framework_Input_Events_MouseUpEvent"></a> Class MouseUpEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

An event representing a release of a mouse button.

```csharp
public class MouseUpEvent : MouseButtonEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[MouseEvent](osu.Framework.Input.Events.MouseEvent.md) ← 
[MouseButtonEvent](osu.Framework.Input.Events.MouseButtonEvent.md) ← 
[MouseUpEvent](osu.Framework.Input.Events.MouseUpEvent.md)

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

[ObjectExtensions.AsNonNull<MouseUpEvent\>\(MouseUpEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseUpEvent\>\(MouseUpEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseUpEvent\>\(MouseUpEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseUpEvent\>\(MouseUpEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseUpEvent, TChild\>\(MouseUpEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseUpEvent, TChild\>\(MouseUpEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseUpEvent, TChild\>\(MouseUpEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseUpEvent\>\(MouseUpEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_MouseUpEvent__ctor_osu_Framework_Input_States_InputState_osuTK_Input_MouseButton_System_Nullable_osuTK_Vector2__"></a> MouseUpEvent\(InputState, MouseButton, Vector2?\)

```csharp
public MouseUpEvent(InputState state, MouseButton button, Vector2? screenSpaceMouseDownPosition = null)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`button` MouseButton

`screenSpaceMouseDownPosition` Vector2?

