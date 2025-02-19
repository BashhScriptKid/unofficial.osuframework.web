# <a id="osu_Framework_Input_Events_JoystickButtonEvent"></a> Class JoystickButtonEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

Events of a joystick button.

```csharp
public abstract class JoystickButtonEvent : JoystickEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[JoystickEvent](osu.Framework.Input.Events.JoystickEvent.md) ← 
[JoystickButtonEvent](osu.Framework.Input.Events.JoystickButtonEvent.md)

#### Derived

[JoystickPressEvent](osu.Framework.Input.Events.JoystickPressEvent.md), 
[JoystickReleaseEvent](osu.Framework.Input.Events.JoystickReleaseEvent.md)

#### Inherited Members

[JoystickEvent.PressedButtons](osu.Framework.Input.Events.JoystickEvent.md\#osu\_Framework\_Input\_Events\_JoystickEvent\_PressedButtons), 
[JoystickEvent.Axes](osu.Framework.Input.Events.JoystickEvent.md\#osu\_Framework\_Input\_Events\_JoystickEvent\_Axes), 
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

[ObjectExtensions.AsNonNull<JoystickButtonEvent\>\(JoystickButtonEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<JoystickButtonEvent\>\(JoystickButtonEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<JoystickButtonEvent\>\(JoystickButtonEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<JoystickButtonEvent\>\(JoystickButtonEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<JoystickButtonEvent, TChild\>\(JoystickButtonEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<JoystickButtonEvent, TChild\>\(JoystickButtonEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<JoystickButtonEvent, TChild\>\(JoystickButtonEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<JoystickButtonEvent\>\(JoystickButtonEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_JoystickButtonEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_JoystickButton_"></a> JoystickButtonEvent\(InputState, JoystickButton\)

```csharp
protected JoystickButtonEvent(InputState state, JoystickButton button)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`button` [JoystickButton](osu.Framework.Input.JoystickButton.md)

## Fields

### <a id="osu_Framework_Input_Events_JoystickButtonEvent_Button"></a> Button

```csharp
public readonly JoystickButton Button
```

#### Field Value

 [JoystickButton](osu.Framework.Input.JoystickButton.md)

## Methods

### <a id="osu_Framework_Input_Events_JoystickButtonEvent_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

