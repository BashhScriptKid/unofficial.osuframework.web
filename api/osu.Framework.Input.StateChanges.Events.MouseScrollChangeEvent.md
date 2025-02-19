# <a id="osu_Framework_Input_StateChanges_Events_MouseScrollChangeEvent"></a> Class MouseScrollChangeEvent

Namespace: [osu.Framework.Input.StateChanges.Events](osu.Framework.Input.StateChanges.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class MouseScrollChangeEvent : InputStateChangeEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md) ← 
[MouseScrollChangeEvent](osu.Framework.Input.StateChanges.Events.MouseScrollChangeEvent.md)

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

[ObjectExtensions.AsNonNull<MouseScrollChangeEvent\>\(MouseScrollChangeEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseScrollChangeEvent\>\(MouseScrollChangeEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseScrollChangeEvent\>\(MouseScrollChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseScrollChangeEvent\>\(MouseScrollChangeEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseScrollChangeEvent, TChild\>\(MouseScrollChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseScrollChangeEvent, TChild\>\(MouseScrollChangeEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseScrollChangeEvent, TChild\>\(MouseScrollChangeEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseScrollChangeEvent\>\(MouseScrollChangeEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_Events_MouseScrollChangeEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInput_osuTK_Vector2_System_Boolean_"></a> MouseScrollChangeEvent\(InputState, IInput, Vector2, bool\)

```csharp
public MouseScrollChangeEvent(InputState state, IInput input, Vector2 lastScroll, bool isPrecise)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`input` [IInput](osu.Framework.Input.StateChanges.IInput.md)

`lastScroll` Vector2

`isPrecise` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="osu_Framework_Input_StateChanges_Events_MouseScrollChangeEvent_IsPrecise"></a> IsPrecise

Whether the change came from a device supporting precision scrolling.

```csharp
public readonly bool IsPrecise
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

In cases this is true, scroll events will generally map 1:1 to user's input, rather than incrementing in large "notches" (as expected of traditional scroll wheels).

### <a id="osu_Framework_Input_StateChanges_Events_MouseScrollChangeEvent_LastScroll"></a> LastScroll

The absolute value of scroll prior to this change.

```csharp
public readonly Vector2 LastScroll
```

#### Field Value

 Vector2

