# <a id="osu_Framework_Input"></a> Namespace osu.Framework.Input

### Namespaces

 [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)

 [osu.Framework.Input.Events](osu.Framework.Input.Events.md)

 [osu.Framework.Input.Handlers](osu.Framework.Input.Handlers.md)

 [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)

 [osu.Framework.Input.States](osu.Framework.Input.States.md)

### Classes

 [ButtonEventManager<TButton\>](osu.Framework.Input.ButtonEventManager\-1.md)

Manages state and events for a single button.

 [CustomInputManager](osu.Framework.Input.CustomInputManager.md)

An <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref> implementation which allows managing of <xref href="osu.Framework.Input.Handlers.InputHandler" data-throw-if-not-resolved="false"></xref>s manually.

 [InputManager](osu.Framework.Input.InputManager.md)

 [InputResampler](osu.Framework.Input.InputResampler.md)

Reduces cursor input to relevant nodes and corners that noticably affect the cursor path.
If the input is a raw/HD input this won't omit any input nodes.
Set SmoothRawInput to true to keep behaviour for HD inputs.

 [JoystickAxisEventManager](osu.Framework.Input.JoystickAxisEventManager.md)

 [JoystickButtonEventManager](osu.Framework.Input.JoystickButtonEventManager.md)

 [KeyEventManager](osu.Framework.Input.KeyEventManager.md)

Manages state events for a single key.

 [MidiKeyEventManager](osu.Framework.Input.MidiKeyEventManager.md)

 [MouseButtonEventManager](osu.Framework.Input.MouseButtonEventManager.md)

Manages state and events (click, drag and double-click) for a single mouse button.

 [PassThroughInputManager](osu.Framework.Input.PassThroughInputManager.md)

An <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref> with an ability to use parent <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref>'s input.

 [PlatformActionContainer](osu.Framework.Input.PlatformActionContainer.md)

Provides actions that are expected to have different key bindings per platform.
The framework will always contain one top-level instance of this class, but extra instances
can be created to handle events that should trigger specifically on a focused drawable.
Will send repeat events by default.

 [ReadableKeyCombinationProvider](osu.Framework.Input.ReadableKeyCombinationProvider.md)

 [TabletAuxiliaryButtonEventManager](osu.Framework.Input.TabletAuxiliaryButtonEventManager.md)

 [TabletPenButtonEventManager](osu.Framework.Input.TabletPenButtonEventManager.md)

 [TextInputSource](osu.Framework.Input.TextInputSource.md)

A source from which we can retrieve user text input.
Generally hides a native implementation from the game framework.

 [TextInputTypeExtensions](osu.Framework.Input.TextInputTypeExtensions.md)

 [TouchEventManager](osu.Framework.Input.TouchEventManager.md)

A manager that manages states and events for a single touch.

 [UserInputManager](osu.Framework.Input.UserInputManager.md)

### Structs

 [JoystickAxis](osu.Framework.Input.JoystickAxis.md)

 [TextInputProperties](osu.Framework.Input.TextInputProperties.md)

Represents a number of properties to consider during a text input session.

 [Touch](osu.Framework.Input.Touch.md)

Represents a touch structure that provides a touch source and current position.

### Interfaces

 [ICanSuppressKeyEventLogging](osu.Framework.Input.ICanSuppressKeyEventLogging.md)

An interface which suppresses logging of keyboard input events.
Useful for password fields, where user input should not be logged.

 [IFocusManager](osu.Framework.Input.IFocusManager.md)

 [IHandleGlobalKeyboardInput](osu.Framework.Input.IHandleGlobalKeyboardInput.md)

Denotes that this class handles keyboard input globally.

 [IRequireHighFrequencyMousePosition](osu.Framework.Input.IRequireHighFrequencyMousePosition.md)

Guarantees that a drawable will receive at least one OnMouseMove position update
per update frame (in addition to any input-triggered occurrences).

 [ISourceGeneratedHandleInputCache](osu.Framework.Input.ISourceGeneratedHandleInputCache.md)

### Enums

 [ConfineMouseMode](osu.Framework.Input.ConfineMouseMode.md)

 [FrameworkAction](osu.Framework.Input.FrameworkAction.md)

 [JoystickAxisSource](osu.Framework.Input.JoystickAxisSource.md)

 [JoystickButton](osu.Framework.Input.JoystickButton.md)

 [MidiKey](osu.Framework.Input.MidiKey.md)

 [PlatformAction](osu.Framework.Input.PlatformAction.md)

 [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

 [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

 [TextInputType](osu.Framework.Input.TextInputType.md)

 [TouchSource](osu.Framework.Input.TouchSource.md)

A collection of available touch sources used for touch input methods.

### Delegates

 [TextInputSource.ImeCompositionDelegate](osu.Framework.Input.TextInputSource.ImeCompositionDelegate.md)

Fired on a new IME composition.

