# <a id="osu_Framework_Input_Events_TouchUpEvent"></a> Class TouchUpEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class TouchUpEvent : TouchEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[TouchEvent](osu.Framework.Input.Events.TouchEvent.md) ← 
[TouchUpEvent](osu.Framework.Input.Events.TouchUpEvent.md)

#### Inherited Members

[TouchEvent.ScreenSpaceTouch](osu.Framework.Input.Events.TouchEvent.md\#osu\_Framework\_Input\_Events\_TouchEvent\_ScreenSpaceTouch), 
[TouchEvent.Touch](osu.Framework.Input.Events.TouchEvent.md\#osu\_Framework\_Input\_Events\_TouchEvent\_Touch), 
[TouchEvent.ScreenSpaceTouchDownPosition](osu.Framework.Input.Events.TouchEvent.md\#osu\_Framework\_Input\_Events\_TouchEvent\_ScreenSpaceTouchDownPosition), 
[TouchEvent.TouchDownPosition](osu.Framework.Input.Events.TouchEvent.md\#osu\_Framework\_Input\_Events\_TouchEvent\_TouchDownPosition), 
[TouchEvent.IsActive\(Touch\)](osu.Framework.Input.Events.TouchEvent.md\#osu\_Framework\_Input\_Events\_TouchEvent\_IsActive\_osu\_Framework\_Input\_Touch\_), 
[TouchEvent.ToString\(\)](osu.Framework.Input.Events.TouchEvent.md\#osu\_Framework\_Input\_Events\_TouchEvent\_ToString), 
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

[ObjectExtensions.AsNonNull<TouchUpEvent\>\(TouchUpEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TouchUpEvent\>\(TouchUpEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TouchUpEvent\>\(TouchUpEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TouchUpEvent\>\(TouchUpEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TouchUpEvent, TChild\>\(TouchUpEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TouchUpEvent, TChild\>\(TouchUpEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TouchUpEvent, TChild\>\(TouchUpEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TouchUpEvent\>\(TouchUpEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_TouchUpEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_Touch_System_Nullable_osuTK_Vector2__"></a> TouchUpEvent\(InputState, Touch, Vector2?\)

```csharp
public TouchUpEvent(InputState state, Touch touch, Vector2? screenSpaceTouchDownPosition)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`touch` [Touch](osu.Framework.Input.Touch.md)

`screenSpaceTouchDownPosition` Vector2?

