# <a id="osu_Framework_Input_StateChanges_Events_InputStateChangeEvent"></a> Class InputStateChangeEvent

Namespace: [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)  
Assembly: osu.Framework.dll  

An event which represents a change of an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.
An <xref href="osu.Framework.Input.StateChanges.IInput" data-throw-if-not-resolved="false"></xref> produces this type of event after it changes <xref href="osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.State" data-throw-if-not-resolved="false"></xref>.

```csharp
public abstract class InputStateChangeEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md)

#### Derived

[ButtonStateChangeEvent<TButton\>](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md), 
[JoystickAxisChangeEvent](osu.Framework.Input.StateChanges.Events.JoystickAxisChangeEvent.md), 
[MousePositionChangeEvent](osu.Framework.Input.StateChanges.Events.MousePositionChangeEvent.md), 
[MouseScrollChangeEvent](osu.Framework.Input.StateChanges.Events.MouseScrollChangeEvent.md), 
[TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<InputStateChangeEvent\>\(InputStateChangeEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InputStateChangeEvent\>\(InputStateChangeEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InputStateChangeEvent\>\(InputStateChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InputStateChangeEvent\>\(InputStateChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InputStateChangeEvent, TChild\>\(InputStateChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InputStateChangeEvent, TChild\>\(InputStateChangeEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InputStateChangeEvent, TChild\>\(InputStateChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InputStateChangeEvent\>\(InputStateChangeEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_Events_InputStateChangeEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInput_"></a> InputStateChangeEvent\(InputState, IInput\)

```csharp
protected InputStateChangeEvent(InputState state, IInput input)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`input` [IInput](osu.Framework.Input.StateChanges.IInput.md)

## Fields

### <a id="osu_Framework_Input_StateChanges_Events_InputStateChangeEvent_Input"></a> Input

The <xref href="osu.Framework.Input.StateChanges.IInput" data-throw-if-not-resolved="false"></xref> that caused this input state change.

```csharp
public readonly IInput Input
```

#### Field Value

 [IInput](osu.Framework.Input.StateChanges.IInput.md)

### <a id="osu_Framework_Input_StateChanges_Events_InputStateChangeEvent_State"></a> State

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> changed by this event.

```csharp
public readonly InputState State
```

#### Field Value

 [InputState](osu.Framework.Input.States.InputState.md)

