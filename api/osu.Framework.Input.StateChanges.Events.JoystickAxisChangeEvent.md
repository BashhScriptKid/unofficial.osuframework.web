# <a id="osu_Framework_Input_StateChanges_Events_JoystickAxisChangeEvent"></a> Class JoystickAxisChangeEvent

Namespace: [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class JoystickAxisChangeEvent : InputStateChangeEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md) ← 
[JoystickAxisChangeEvent](osu.Framework.Input.StateChanges.Events.JoystickAxisChangeEvent.md)

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

[ObjectExtensions.AsNonNull<JoystickAxisChangeEvent\>\(JoystickAxisChangeEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<JoystickAxisChangeEvent\>\(JoystickAxisChangeEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<JoystickAxisChangeEvent\>\(JoystickAxisChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<JoystickAxisChangeEvent\>\(JoystickAxisChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<JoystickAxisChangeEvent, TChild\>\(JoystickAxisChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<JoystickAxisChangeEvent, TChild\>\(JoystickAxisChangeEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<JoystickAxisChangeEvent, TChild\>\(JoystickAxisChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<JoystickAxisChangeEvent\>\(JoystickAxisChangeEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_Events_JoystickAxisChangeEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInput_osu_Framework_Input_JoystickAxis_System_Single_"></a> JoystickAxisChangeEvent\(InputState, IInput, JoystickAxis, float\)

```csharp
public JoystickAxisChangeEvent(InputState state, IInput input, JoystickAxis axis, float lastValue)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`input` [IInput](osu.Framework.Input.StateChanges.IInput.md)

`axis` [JoystickAxis](osu.Framework.Input.JoystickAxis.md)

`lastValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="osu_Framework_Input_StateChanges_Events_JoystickAxisChangeEvent_Axis"></a> Axis

The current joystick axis data.

```csharp
public readonly JoystickAxis Axis
```

#### Field Value

 [JoystickAxis](osu.Framework.Input.JoystickAxis.md)

### <a id="osu_Framework_Input_StateChanges_Events_JoystickAxisChangeEvent_LastValue"></a> LastValue

The last value of this joystick axis.

```csharp
public readonly float LastValue
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

