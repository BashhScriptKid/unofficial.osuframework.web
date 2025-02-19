# <a id="osu_Framework_Input_Events_TabletAuxiliaryButtonEvent"></a> Class TabletAuxiliaryButtonEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

Events of a tablet auxiliary button.

```csharp
public abstract class TabletAuxiliaryButtonEvent : TabletEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[TabletEvent](osu.Framework.Input.Events.TabletEvent.md) ← 
[TabletAuxiliaryButtonEvent](osu.Framework.Input.Events.TabletAuxiliaryButtonEvent.md)

#### Derived

[TabletAuxiliaryButtonPressEvent](osu.Framework.Input.Events.TabletAuxiliaryButtonPressEvent.md), 
[TabletAuxiliaryButtonReleaseEvent](osu.Framework.Input.Events.TabletAuxiliaryButtonReleaseEvent.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<TabletAuxiliaryButtonEvent\>\(TabletAuxiliaryButtonEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletAuxiliaryButtonEvent\>\(TabletAuxiliaryButtonEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletAuxiliaryButtonEvent\>\(TabletAuxiliaryButtonEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletAuxiliaryButtonEvent\>\(TabletAuxiliaryButtonEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletAuxiliaryButtonEvent, TChild\>\(TabletAuxiliaryButtonEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletAuxiliaryButtonEvent, TChild\>\(TabletAuxiliaryButtonEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletAuxiliaryButtonEvent, TChild\>\(TabletAuxiliaryButtonEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletAuxiliaryButtonEvent\>\(TabletAuxiliaryButtonEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_TabletAuxiliaryButtonEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_TabletAuxiliaryButton_"></a> TabletAuxiliaryButtonEvent\(InputState, TabletAuxiliaryButton\)

```csharp
protected TabletAuxiliaryButtonEvent(InputState state, TabletAuxiliaryButton button)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

## Fields

### <a id="osu_Framework_Input_Events_TabletAuxiliaryButtonEvent_Button"></a> Button

```csharp
public readonly TabletAuxiliaryButton Button
```

#### Field Value

 [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

## Methods

### <a id="osu_Framework_Input_Events_TabletAuxiliaryButtonEvent_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

