# <a id="osu_Framework_Input_StateChanges_MidiKeyInput"></a> Class MidiKeyInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

Represents an input from a MIDI device.

```csharp
public class MidiKeyInput : ButtonInput<MidiKey>, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<MidiKey\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[MidiKeyInput](osu.Framework.Input.StateChanges.MidiKeyInput.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[ButtonInput<MidiKey\>.Entries](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Entries), 
[ButtonInput<MidiKey\>.GetButtonStates\(InputState\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_GetButtonStates\_osu\_Framework\_Input\_States\_InputState\_), 
[ButtonInput<MidiKey\>.CreateEvent\(InputState, MidiKey, ButtonStateChangeKind\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_CreateEvent\_osu\_Framework\_Input\_States\_InputState\_\_0\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonInput<MidiKey\>.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MidiKeyInput\>\(MidiKeyInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MidiKeyInput\>\(MidiKeyInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MidiKeyInput\>\(MidiKeyInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MidiKeyInput\>\(MidiKeyInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MidiKeyInput, TChild\>\(MidiKeyInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MidiKeyInput, TChild\>\(MidiKeyInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MidiKeyInput, TChild\>\(MidiKeyInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MidiKeyInput\>\(MidiKeyInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_MidiKeyInput__ctor_osu_Framework_Input_MidiKey_System_Byte_System_Boolean_"></a> MidiKeyInput\(MidiKey, byte, bool\)

Creates a <xref href="osu.Framework.Input.StateChanges.MidiKeyInput" data-throw-if-not-resolved="false"></xref> for a single key state.

```csharp
public MidiKeyInput(MidiKey button, byte velocity, bool isPressed)
```

#### Parameters

`button` [MidiKey](osu.Framework.Input.MidiKey.md)

The <xref href="osu.Framework.Input.MidiKey" data-throw-if-not-resolved="false"></xref> whose state changed.

`velocity` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The velocity with which with the input was performed.

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether <code class="paramref">button</code> was pressed or released.

### <a id="osu_Framework_Input_StateChanges_MidiKeyInput__ctor_osu_Framework_Input_States_MidiState_osu_Framework_Input_States_MidiState_"></a> MidiKeyInput\(MidiState, MidiState\)

Creates a <xref href="osu.Framework.Input.StateChanges.MidiKeyInput" data-throw-if-not-resolved="false"></xref> from the difference of two <xref href="osu.Framework.Input.States.MidiState" data-throw-if-not-resolved="false"></xref>s.

```csharp
public MidiKeyInput(MidiState currentState, MidiState previousState)
```

#### Parameters

`currentState` [MidiState](osu.Framework.Input.States.MidiState.md)

The newer <xref href="osu.Framework.Input.States.MidiState" data-throw-if-not-resolved="false"></xref>.

`previousState` [MidiState](osu.Framework.Input.States.MidiState.md)

The older <xref href="osu.Framework.Input.States.MidiState" data-throw-if-not-resolved="false"></xref>.

#### Remarks

Buttons that are pressed in <code class="paramref">previousState</code> and not pressed in <code class="paramref">currentState</code> will be listed as <xref href="osu.Framework.Input.StateChanges.ButtonStateChangeKind.Released" data-throw-if-not-resolved="false"></xref>.
Buttons that are not pressed in <code class="paramref">previousState</code> and pressed in <code class="paramref">currentState</code> will be listed as <xref href="osu.Framework.Input.StateChanges.ButtonStateChangeKind.Pressed" data-throw-if-not-resolved="false"></xref>.
Key velocities from <code class="paramref">currentState</code> always take precedence over velocities from <code class="paramref">previousState</code>.

## Fields

### <a id="osu_Framework_Input_StateChanges_MidiKeyInput_Velocities"></a> Velocities

A mapping of <xref href="osu.Framework.Input.MidiKey" data-throw-if-not-resolved="false"></xref>s to the velocities they were pressed or released with.

```csharp
public readonly IReadOnlyList<(MidiKey, byte)> Velocities
```

#### Field Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<\([MidiKey](osu.Framework.Input.MidiKey.md), [byte](https://learn.microsoft.com/dotnet/api/system.byte)\)\>

## Methods

### <a id="osu_Framework_Input_StateChanges_MidiKeyInput_Apply_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInputStateChangeHandler_"></a> Apply\(InputState, IInputStateChangeHandler\)

Applies input to an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.
This alters the <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> and propagates the change to an <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref>.

```csharp
public override void Apply(InputState state, IInputStateChangeHandler handler)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> to apply changes to.

`handler` [IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md)

The <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref> to handle changes to <code class="paramref">state</code>.

### <a id="osu_Framework_Input_StateChanges_MidiKeyInput_GetButtonStates_osu_Framework_Input_States_InputState_"></a> GetButtonStates\(InputState\)

Retrieves the <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> from a <xref href="osu.Framework.Input.StateChanges.MidiKeyInput" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override ButtonStates<MidiKey> GetButtonStates(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[MidiKey](osu.Framework.Input.MidiKey.md)\>

