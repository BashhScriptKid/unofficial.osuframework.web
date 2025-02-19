# <a id="osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent"></a> Class TouchStateChangeEvent

Namespace: [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class TouchStateChangeEvent : InputStateChangeEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md) ← 
[TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

#### Inherited Members

[InputStateChangeEvent.State](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md\#osu\_Framework\_Input\_StateChanges\_Events\_InputStateChangeEvent\_State), 
[InputStateChangeEvent.Input](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md\#osu\_Framework\_Input\_StateChanges\_Events\_InputStateChangeEvent\_Input), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TouchStateChangeEvent\>\(TouchStateChangeEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TouchStateChangeEvent\>\(TouchStateChangeEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TouchStateChangeEvent\>\(TouchStateChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TouchStateChangeEvent\>\(TouchStateChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TouchStateChangeEvent, TChild\>\(TouchStateChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TouchStateChangeEvent, TChild\>\(TouchStateChangeEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TouchStateChangeEvent, TChild\>\(TouchStateChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TouchStateChangeEvent\>\(TouchStateChangeEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInput_osu_Framework_Input_Touch_System_Nullable_System_Boolean__System_Nullable_osuTK_Vector2__"></a> TouchStateChangeEvent\(InputState, IInput, Touch, bool?, Vector2?\)

```csharp
public TouchStateChangeEvent(InputState state, IInput input, Touch touch, bool? active, Vector2? lastPosition)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`input` [IInput](osu.Framework.Input.StateChanges.IInput.md)

`touch` [Touch](osu.Framework.Input.Touch.md)

`active` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)?

`lastPosition` Vector2?

## Fields

### <a id="osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_IsActive"></a> IsActive

Whether the <xref href="osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.Touch" data-throw-if-not-resolved="false"></xref> became active, or null if no activity change occurred.

```csharp
public readonly bool? IsActive
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)?

### <a id="osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_LastPosition"></a> LastPosition

The last position of this <xref href="osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.Touch" data-throw-if-not-resolved="false"></xref>, or null if no position change occurred.

```csharp
public readonly Vector2? LastPosition
```

#### Field Value

 Vector2?

### <a id="osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_Touch"></a> Touch

The current <xref href="osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.Touch" data-throw-if-not-resolved="false"></xref> value.

```csharp
public readonly Touch Touch
```

#### Field Value

 [Touch](osu.Framework.Input.Touch.md)

