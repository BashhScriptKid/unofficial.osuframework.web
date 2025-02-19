# <a id="osu_Framework_Input_Events_TouchEvent"></a> Class TouchEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

Represents a touch event.

```csharp
public class TouchEvent : UIEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[TouchEvent](osu.Framework.Input.Events.TouchEvent.md)

#### Derived

[TouchDownEvent](osu.Framework.Input.Events.TouchDownEvent.md), 
[TouchMoveEvent](osu.Framework.Input.Events.TouchMoveEvent.md), 
[TouchUpEvent](osu.Framework.Input.Events.TouchUpEvent.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<TouchEvent\>\(TouchEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TouchEvent\>\(TouchEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TouchEvent\>\(TouchEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TouchEvent\>\(TouchEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TouchEvent, TChild\>\(TouchEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TouchEvent, TChild\>\(TouchEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TouchEvent, TChild\>\(TouchEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TouchEvent\>\(TouchEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_TouchEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_Touch_System_Nullable_osuTK_Vector2__"></a> TouchEvent\(InputState, Touch, Vector2?\)

```csharp
public TouchEvent(InputState state, Touch touch, Vector2? screenSpaceTouchDownPosition = null)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`touch` [Touch](osu.Framework.Input.Touch.md)

`screenSpaceTouchDownPosition` Vector2?

## Fields

### <a id="osu_Framework_Input_Events_TouchEvent_ScreenSpaceTouch"></a> ScreenSpaceTouch

The touch of this event with the screen space position.

```csharp
public readonly Touch ScreenSpaceTouch
```

#### Field Value

 [Touch](osu.Framework.Input.Touch.md)

### <a id="osu_Framework_Input_Events_TouchEvent_ScreenSpaceTouchDownPosition"></a> ScreenSpaceTouchDownPosition

The touch position at the <xref href="osu.Framework.Input.Events.TouchDownEvent" data-throw-if-not-resolved="false"></xref> for this touch source in the screen space.

```csharp
public readonly Vector2 ScreenSpaceTouchDownPosition
```

#### Field Value

 Vector2

## Properties

### <a id="osu_Framework_Input_Events_TouchEvent_Touch"></a> Touch

The touch of this event with local space position.

```csharp
public Touch Touch { get; }
```

#### Property Value

 [Touch](osu.Framework.Input.Touch.md)

### <a id="osu_Framework_Input_Events_TouchEvent_TouchDownPosition"></a> TouchDownPosition

The touch position at the <xref href="osu.Framework.Input.Events.TouchDownEvent" data-throw-if-not-resolved="false"></xref> for this touch source in local space.

```csharp
public Vector2 TouchDownPosition { get; }
```

#### Property Value

 Vector2

## Methods

### <a id="osu_Framework_Input_Events_TouchEvent_IsActive_osu_Framework_Input_Touch_"></a> IsActive\(Touch\)

Whether a touch is active.

```csharp
public bool IsActive(Touch touch)
```

#### Parameters

`touch` [Touch](osu.Framework.Input.Touch.md)

The touch to check for.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Events_TouchEvent_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

