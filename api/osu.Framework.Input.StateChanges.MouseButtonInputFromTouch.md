# <a id="osu_Framework_Input_StateChanges_MouseButtonInputFromTouch"></a> Class MouseButtonInputFromTouch

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class MouseButtonInputFromTouch : MouseButtonInput, ISourcedFromTouch, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<MouseButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[MouseButtonInput](osu.Framework.Input.StateChanges.MouseButtonInput.md) ← 
[MouseButtonInputFromTouch](osu.Framework.Input.StateChanges.MouseButtonInputFromTouch.md)

#### Implements

[ISourcedFromTouch](osu.Framework.Input.StateChanges.ISourcedFromTouch.md), 
[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[MouseButtonInput.GetButtonStates\(InputState\)](osu.Framework.Input.StateChanges.MouseButtonInput.md\#osu\_Framework\_Input\_StateChanges\_MouseButtonInput\_GetButtonStates\_osu\_Framework\_Input\_States\_InputState\_), 
[MouseButtonInput.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.MouseButtonInput.md\#osu\_Framework\_Input\_StateChanges\_MouseButtonInput\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[ButtonInput<MouseButton\>.Entries](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Entries), 
[ButtonInput<MouseButton\>.GetButtonStates\(InputState\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_GetButtonStates\_osu\_Framework\_Input\_States\_InputState\_), 
[ButtonInput<MouseButton\>.CreateEvent\(InputState, MouseButton, ButtonStateChangeKind\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_CreateEvent\_osu\_Framework\_Input\_States\_InputState\_\_0\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonInput<MouseButton\>.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MouseButtonInputFromTouch\>\(MouseButtonInputFromTouch?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseButtonInputFromTouch\>\(MouseButtonInputFromTouch\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseButtonInputFromTouch\>\(MouseButtonInputFromTouch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseButtonInputFromTouch\>\(MouseButtonInputFromTouch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseButtonInputFromTouch, TChild\>\(MouseButtonInputFromTouch, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseButtonInputFromTouch, TChild\>\(MouseButtonInputFromTouch, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseButtonInputFromTouch, TChild\>\(MouseButtonInputFromTouch, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseButtonInputFromTouch\>\(MouseButtonInputFromTouch\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_MouseButtonInputFromTouch__ctor_osuTK_Input_MouseButton_System_Boolean_osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_"></a> MouseButtonInputFromTouch\(MouseButton, bool, TouchStateChangeEvent\)

```csharp
public MouseButtonInputFromTouch(MouseButton button, bool isPressed, TouchStateChangeEvent touchEvent)
```

#### Parameters

`button` MouseButton

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`touchEvent` [TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

## Properties

### <a id="osu_Framework_Input_StateChanges_MouseButtonInputFromTouch_TouchEvent"></a> TouchEvent

The source touch event.

```csharp
public TouchStateChangeEvent TouchEvent { get; }
```

#### Property Value

 [TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

