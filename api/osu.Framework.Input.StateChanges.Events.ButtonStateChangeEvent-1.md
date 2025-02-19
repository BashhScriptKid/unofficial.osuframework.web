# <a id="osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_1"></a> Class ButtonStateChangeEvent<TButton\>

Namespace: [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class ButtonStateChangeEvent<TButton> : InputStateChangeEvent where TButton : struct
```

#### Type Parameters

`TButton` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md) ← 
[ButtonStateChangeEvent<TButton\>](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)

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

[ObjectExtensions.AsNonNull<ButtonStateChangeEvent<TButton\>\>\(ButtonStateChangeEvent<TButton\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ButtonStateChangeEvent<TButton\>\>\(ButtonStateChangeEvent<TButton\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ButtonStateChangeEvent<TButton\>\>\(ButtonStateChangeEvent<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ButtonStateChangeEvent<TButton\>\>\(ButtonStateChangeEvent<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ButtonStateChangeEvent<TButton\>, TChild\>\(ButtonStateChangeEvent<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ButtonStateChangeEvent<TButton\>, TChild\>\(ButtonStateChangeEvent<TButton\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ButtonStateChangeEvent<TButton\>, TChild\>\(ButtonStateChangeEvent<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ButtonStateChangeEvent<TButton\>\>\(ButtonStateChangeEvent<TButton\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_1__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInput__0_osu_Framework_Input_StateChanges_ButtonStateChangeKind_"></a> ButtonStateChangeEvent\(InputState, IInput, TButton, ButtonStateChangeKind\)

```csharp
public ButtonStateChangeEvent(InputState state, IInput input, TButton button, ButtonStateChangeKind kind)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`input` [IInput](osu.Framework.Input.StateChanges.IInput.md)

`button` TButton

`kind` [ButtonStateChangeKind](osu.Framework.Input.StateChanges.ButtonStateChangeKind.md)

## Fields

### <a id="osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_1_Button"></a> Button

The button which changed state.

```csharp
public readonly TButton Button
```

#### Field Value

 TButton

### <a id="osu_Framework_Input_StateChanges_Events_ButtonStateChangeEvent_1_Kind"></a> Kind

The kind of button state change. Either pressed or released.

```csharp
public readonly ButtonStateChangeKind Kind
```

#### Field Value

 [ButtonStateChangeKind](osu.Framework.Input.StateChanges.ButtonStateChangeKind.md)

