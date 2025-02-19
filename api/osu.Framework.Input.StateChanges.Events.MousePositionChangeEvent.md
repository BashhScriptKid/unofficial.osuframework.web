# <a id="osu_Framework_Input_StateChanges_Events_MousePositionChangeEvent"></a> Class MousePositionChangeEvent

Namespace: [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class MousePositionChangeEvent : InputStateChangeEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md) ← 
[MousePositionChangeEvent](osu.Framework.Input.StateChanges.Events.MousePositionChangeEvent.md)

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

[ObjectExtensions.AsNonNull<MousePositionChangeEvent\>\(MousePositionChangeEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MousePositionChangeEvent\>\(MousePositionChangeEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MousePositionChangeEvent\>\(MousePositionChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MousePositionChangeEvent\>\(MousePositionChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MousePositionChangeEvent, TChild\>\(MousePositionChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MousePositionChangeEvent, TChild\>\(MousePositionChangeEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MousePositionChangeEvent, TChild\>\(MousePositionChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MousePositionChangeEvent\>\(MousePositionChangeEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_Events_MousePositionChangeEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInput_osuTK_Vector2_"></a> MousePositionChangeEvent\(InputState, IInput, Vector2\)

```csharp
public MousePositionChangeEvent(InputState state, IInput input, Vector2 lastPosition)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`input` [IInput](osu.Framework.Input.StateChanges.IInput.md)

`lastPosition` Vector2

## Fields

### <a id="osu_Framework_Input_StateChanges_Events_MousePositionChangeEvent_LastPosition"></a> LastPosition

The last mouse position.

```csharp
public readonly Vector2 LastPosition
```

#### Field Value

 Vector2

