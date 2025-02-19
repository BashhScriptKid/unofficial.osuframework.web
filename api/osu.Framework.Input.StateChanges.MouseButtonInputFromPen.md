# <a id="osu_Framework_Input_StateChanges_MouseButtonInputFromPen"></a> Class MouseButtonInputFromPen

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class MouseButtonInputFromPen : MouseButtonInput, ISourcedFromPen, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<MouseButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[MouseButtonInput](osu.Framework.Input.StateChanges.MouseButtonInput.md) ← 
[MouseButtonInputFromPen](osu.Framework.Input.StateChanges.MouseButtonInputFromPen.md)

#### Implements

[ISourcedFromPen](osu.Framework.Input.StateChanges.ISourcedFromPen.md), 
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

[ObjectExtensions.AsNonNull<MouseButtonInputFromPen\>\(MouseButtonInputFromPen?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseButtonInputFromPen\>\(MouseButtonInputFromPen\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseButtonInputFromPen\>\(MouseButtonInputFromPen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseButtonInputFromPen\>\(MouseButtonInputFromPen\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseButtonInputFromPen, TChild\>\(MouseButtonInputFromPen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseButtonInputFromPen, TChild\>\(MouseButtonInputFromPen, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseButtonInputFromPen, TChild\>\(MouseButtonInputFromPen, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseButtonInputFromPen\>\(MouseButtonInputFromPen\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_MouseButtonInputFromPen__ctor_System_Boolean_"></a> MouseButtonInputFromPen\(bool\)

```csharp
public MouseButtonInputFromPen(bool isPressed)
```

#### Parameters

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Properties

### <a id="osu_Framework_Input_StateChanges_MouseButtonInputFromPen_DeviceType"></a> DeviceType

The type of the tablet or pen device that made this input.

```csharp
public required TabletPenDeviceType DeviceType { get; init; }
```

#### Property Value

 [TabletPenDeviceType](osu.Framework.Input.StateChanges.TabletPenDeviceType.md)

