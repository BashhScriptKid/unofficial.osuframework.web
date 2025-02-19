# <a id="osu_Framework_Input_States_InputState"></a> Class InputState

Namespace: [osu.Framework.Input.States](osu.Framework.Input.States.md)  
Assembly: osu.Framework.dll  

An object that stores all input states.

```csharp
public class InputState
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputState](osu.Framework.Input.States.InputState.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<InputState\>\(InputState?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InputState\>\(InputState\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InputState\>\(InputState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InputState\>\(InputState\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InputState, TChild\>\(InputState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InputState, TChild\>\(InputState, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InputState, TChild\>\(InputState, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InputState\>\(InputState\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_States_InputState__ctor_osu_Framework_Input_States_InputState_"></a> InputState\(InputState\)

Creates a new <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> using the individual input states from another <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

```csharp
public InputState(InputState other)
```

#### Parameters

`other` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> to take the individual input states from. Note that states are not cloned and will remain as references to the same objects.

### <a id="osu_Framework_Input_States_InputState__ctor_osu_Framework_Input_States_MouseState_osu_Framework_Input_States_KeyboardState_osu_Framework_Input_States_TouchState_osu_Framework_Input_States_JoystickState_osu_Framework_Input_States_MidiState_osu_Framework_Input_States_TabletState_"></a> InputState\(MouseState, KeyboardState, TouchState, JoystickState, MidiState, TabletState\)

Creates a new <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> using given individual input states.

```csharp
public InputState(MouseState mouse = null, KeyboardState keyboard = null, TouchState touch = null, JoystickState joystick = null, MidiState midi = null, TabletState tablet = null)
```

#### Parameters

`mouse` [MouseState](osu.Framework.Input.States.MouseState.md)

The mouse state.

`keyboard` [KeyboardState](osu.Framework.Input.States.KeyboardState.md)

The keyboard state.

`touch` [TouchState](osu.Framework.Input.States.TouchState.md)

The touch state.

`joystick` [JoystickState](osu.Framework.Input.States.JoystickState.md)

The joystick state.

`midi` [MidiState](osu.Framework.Input.States.MidiState.md)

The midi state.

`tablet` [TabletState](osu.Framework.Input.States.TabletState.md)

The tablet state.

## Fields

### <a id="osu_Framework_Input_States_InputState_Joystick"></a> Joystick

The joystick state.

```csharp
public readonly JoystickState Joystick
```

#### Field Value

 [JoystickState](osu.Framework.Input.States.JoystickState.md)

### <a id="osu_Framework_Input_States_InputState_Keyboard"></a> Keyboard

The keyboard state.

```csharp
public readonly KeyboardState Keyboard
```

#### Field Value

 [KeyboardState](osu.Framework.Input.States.KeyboardState.md)

### <a id="osu_Framework_Input_States_InputState_Midi"></a> Midi

The midi state.

```csharp
public readonly MidiState Midi
```

#### Field Value

 [MidiState](osu.Framework.Input.States.MidiState.md)

### <a id="osu_Framework_Input_States_InputState_Mouse"></a> Mouse

The mouse state.

```csharp
public readonly MouseState Mouse
```

#### Field Value

 [MouseState](osu.Framework.Input.States.MouseState.md)

### <a id="osu_Framework_Input_States_InputState_Tablet"></a> Tablet

The tablet state.

```csharp
public readonly TabletState Tablet
```

#### Field Value

 [TabletState](osu.Framework.Input.States.TabletState.md)

### <a id="osu_Framework_Input_States_InputState_Touch"></a> Touch

The touch state.

```csharp
public readonly TouchState Touch
```

#### Field Value

 [TouchState](osu.Framework.Input.States.TouchState.md)

