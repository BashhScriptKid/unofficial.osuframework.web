# <a id="osu_Framework_Input_StateChanges"></a> Namespace osu.Framework.Input.StateChanges

### Namespaces

 [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)

### Classes

 [ButtonInput<TButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md)

An abstract base class of an <xref href="osu.Framework.Input.StateChanges.IInput" data-throw-if-not-resolved="false"></xref> which denotes a list of button state changes (pressed or released).

 [JoystickAxisInput](osu.Framework.Input.StateChanges.JoystickAxisInput.md)

 [JoystickButtonInput](osu.Framework.Input.StateChanges.JoystickButtonInput.md)

 [KeyboardKeyInput](osu.Framework.Input.StateChanges.KeyboardKeyInput.md)

 [MidiKeyInput](osu.Framework.Input.StateChanges.MidiKeyInput.md)

Represents an input from a MIDI device.

 [MouseButtonInput](osu.Framework.Input.StateChanges.MouseButtonInput.md)

 [MouseButtonInputFromPen](osu.Framework.Input.StateChanges.MouseButtonInputFromPen.md)

 [MouseButtonInputFromTouch](osu.Framework.Input.StateChanges.MouseButtonInputFromTouch.md)

 [MousePositionAbsoluteInput](osu.Framework.Input.StateChanges.MousePositionAbsoluteInput.md)

Denotes an absolute change of mouse position.
Pointing devices such as tablets provide absolute input.

 [MousePositionAbsoluteInputFromPen](osu.Framework.Input.StateChanges.MousePositionAbsoluteInputFromPen.md)

 [MousePositionAbsoluteInputFromTouch](osu.Framework.Input.StateChanges.MousePositionAbsoluteInputFromTouch.md)

 [MousePositionRelativeInput](osu.Framework.Input.StateChanges.MousePositionRelativeInput.md)

Denotes a relative change of mouse position.
Pointing devices such as mice provide relative positional input.

 [MousePositionRelativeInputFromPen](osu.Framework.Input.StateChanges.MousePositionRelativeInputFromPen.md)

 [MouseScrollRelativeInput](osu.Framework.Input.StateChanges.MouseScrollRelativeInput.md)

Denotes a relative change of mouse scroll.
Pointing devices such as mice provide relative scroll input.

 [TabletAuxiliaryButtonInput](osu.Framework.Input.StateChanges.TabletAuxiliaryButtonInput.md)

 [TabletPenButtonInput](osu.Framework.Input.StateChanges.TabletPenButtonInput.md)

 [TouchInput](osu.Framework.Input.StateChanges.TouchInput.md)

Denotes a change of a touch input.

### Structs

 [ButtonInputEntry<TButton\>](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)

Denotes a button state.

### Interfaces

 [IInput](osu.Framework.Input.StateChanges.IInput.md)

Denotes an input from an <xref href="osu.Framework.Input.Handlers.InputHandler" data-throw-if-not-resolved="false"></xref>.

 [IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md)

An object which can handle <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> changes.

 [ISourcedFromPen](osu.Framework.Input.StateChanges.ISourcedFromPen.md)

Denotes a simulated mouse input that was made by a tablet/pen device.

 [ISourcedFromTouch](osu.Framework.Input.StateChanges.ISourcedFromTouch.md)

Denotes an input which was sourced from a touch event.
Generally used to mark when an alternate input was triggered from a touch source (ie. touch being emulated as a mouse).

### Enums

 [ButtonStateChangeKind](osu.Framework.Input.StateChanges.ButtonStateChangeKind.md)

Denotes a kind of change of a button state.

 [TabletPenDeviceType](osu.Framework.Input.StateChanges.TabletPenDeviceType.md)

