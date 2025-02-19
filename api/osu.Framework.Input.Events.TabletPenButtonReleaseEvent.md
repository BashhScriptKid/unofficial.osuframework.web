# <a id="osu_Framework_Input_Events_TabletPenButtonReleaseEvent"></a> Class TabletPenButtonReleaseEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

An event representing the release of a tablet pen button.

```csharp
public class TabletPenButtonReleaseEvent : TabletPenButtonEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[TabletEvent](osu.Framework.Input.Events.TabletEvent.md) ← 
[TabletPenButtonEvent](osu.Framework.Input.Events.TabletPenButtonEvent.md) ← 
[TabletPenButtonReleaseEvent](osu.Framework.Input.Events.TabletPenButtonReleaseEvent.md)

#### Inherited Members

[TabletPenButtonEvent.Button](osu.Framework.Input.Events.TabletPenButtonEvent.md\#osu\_Framework\_Input\_Events\_TabletPenButtonEvent\_Button), 
[TabletPenButtonEvent.ToString\(\)](osu.Framework.Input.Events.TabletPenButtonEvent.md\#osu\_Framework\_Input\_Events\_TabletPenButtonEvent\_ToString), 
[TabletEvent.PressedPenButtons](osu.Framework.Input.Events.TabletEvent.md\#osu\_Framework\_Input\_Events\_TabletEvent\_PressedPenButtons), 
[TabletEvent.PressedAuxiliaryButtons](osu.Framework.Input.Events.TabletEvent.md\#osu\_Framework\_Input\_Events\_TabletEvent\_PressedAuxiliaryButtons), 
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

[ObjectExtensions.AsNonNull<TabletPenButtonReleaseEvent\>\(TabletPenButtonReleaseEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletPenButtonReleaseEvent\>\(TabletPenButtonReleaseEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletPenButtonReleaseEvent\>\(TabletPenButtonReleaseEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletPenButtonReleaseEvent\>\(TabletPenButtonReleaseEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletPenButtonReleaseEvent, TChild\>\(TabletPenButtonReleaseEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletPenButtonReleaseEvent, TChild\>\(TabletPenButtonReleaseEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletPenButtonReleaseEvent, TChild\>\(TabletPenButtonReleaseEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletPenButtonReleaseEvent\>\(TabletPenButtonReleaseEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_TabletPenButtonReleaseEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_TabletPenButton_"></a> TabletPenButtonReleaseEvent\(InputState, TabletPenButton\)

```csharp
public TabletPenButtonReleaseEvent(InputState state, TabletPenButton button)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

