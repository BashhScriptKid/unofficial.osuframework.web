# <a id="osu_Framework_Input_Events_UIEvent"></a> Class UIEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

Denotes a UI event.
A UI event is produced for and can be handled by a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
While handling events, the <xref href="osu.Framework.Input.Events.UIEvent.Target" data-throw-if-not-resolved="false"></xref> is set to the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> which is handling the event.

```csharp
public abstract class UIEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md)

#### Derived

[FocusEvent](osu.Framework.Input.Events.FocusEvent.md), 
[FocusLostEvent](osu.Framework.Input.Events.FocusLostEvent.md), 
[JoystickEvent](osu.Framework.Input.Events.JoystickEvent.md), 
[KeyBindingEvent<T\>](osu.Framework.Input.Events.KeyBindingEvent\-1.md), 
[KeyboardEvent](osu.Framework.Input.Events.KeyboardEvent.md), 
[MidiEvent](osu.Framework.Input.Events.MidiEvent.md), 
[MouseEvent](osu.Framework.Input.Events.MouseEvent.md), 
[TabletEvent](osu.Framework.Input.Events.TabletEvent.md), 
[TouchEvent](osu.Framework.Input.Events.TouchEvent.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<UIEvent\>\(UIEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<UIEvent\>\(UIEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<UIEvent\>\(UIEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<UIEvent\>\(UIEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<UIEvent, TChild\>\(UIEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<UIEvent, TChild\>\(UIEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<UIEvent, TChild\>\(UIEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<UIEvent\>\(UIEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_UIEvent__ctor_osu_Framework_Input_States_InputState_"></a> UIEvent\(InputState\)

```csharp
protected UIEvent(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

## Fields

### <a id="osu_Framework_Input_Events_UIEvent_CurrentState"></a> CurrentState

The current input state.

```csharp
[NotNull]
public readonly InputState CurrentState
```

#### Field Value

 [InputState](osu.Framework.Input.States.InputState.md)

#### Remarks

This raw state should not be used for event handling if not really needed.
Instead, properties such as <xref href="osu.Framework.Input.Events.UIEvent.MousePosition" data-throw-if-not-resolved="false"></xref> and event data should be used.

### <a id="osu_Framework_Input_Events_UIEvent_Target"></a> Target

The current target <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> of this event.
This can be modified to reuse an instance many times.

```csharp
[CanBeNull]
public Drawable Target
```

#### Field Value

 [Drawable](osu.Framework.Graphics.Drawable.md)

## Properties

### <a id="osu_Framework_Input_Events_UIEvent_AltPressed"></a> AltPressed

Whether left or right alt key is pressed.

```csharp
public bool AltPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Events_UIEvent_ControlPressed"></a> ControlPressed

Whether left or right control key is pressed.

```csharp
public bool ControlPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Events_UIEvent_MousePosition"></a> MousePosition

The current mouse position in <xref href="osu.Framework.Input.Events.UIEvent.Target" data-throw-if-not-resolved="false"></xref>'s parent space.

```csharp
public Vector2 MousePosition { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Input_Events_UIEvent_ScreenSpaceMousePosition"></a> ScreenSpaceMousePosition

The current mouse position in screen space.

```csharp
public Vector2 ScreenSpaceMousePosition { get; }
```

#### Property Value

 Vector2

### <a id="osu_Framework_Input_Events_UIEvent_ShiftPressed"></a> ShiftPressed

Whether left or right shift key is pressed.

```csharp
public bool ShiftPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Events_UIEvent_SuperPressed"></a> SuperPressed

Whether left or right super key (Win key on Windows, or Command key on Mac) is pressed.

```csharp
public bool SuperPressed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Input_Events_UIEvent_ToLocalSpace_osuTK_Vector2_"></a> ToLocalSpace\(Vector2\)

Convert a coordinate to <xref href="osu.Framework.Input.Events.UIEvent.Target" data-throw-if-not-resolved="false"></xref>'s parent space.

```csharp
protected Vector2 ToLocalSpace(Vector2 screenSpacePosition)
```

#### Parameters

`screenSpacePosition` Vector2

#### Returns

 Vector2

### <a id="osu_Framework_Input_Events_UIEvent_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

