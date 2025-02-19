# <a id="osu_Framework_Input_StateChanges_MousePositionAbsoluteInputFromTouch"></a> Class MousePositionAbsoluteInputFromTouch

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class MousePositionAbsoluteInputFromTouch : MousePositionAbsoluteInput, ISourcedFromTouch, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MousePositionAbsoluteInput](osu.Framework.Input.StateChanges.MousePositionAbsoluteInput.md) ← 
[MousePositionAbsoluteInputFromTouch](osu.Framework.Input.StateChanges.MousePositionAbsoluteInputFromTouch.md)

#### Implements

[ISourcedFromTouch](osu.Framework.Input.StateChanges.ISourcedFromTouch.md), 
[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[MousePositionAbsoluteInput.Position](osu.Framework.Input.StateChanges.MousePositionAbsoluteInput.md\#osu\_Framework\_Input\_StateChanges\_MousePositionAbsoluteInput\_Position), 
[MousePositionAbsoluteInput.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.MousePositionAbsoluteInput.md\#osu\_Framework\_Input\_StateChanges\_MousePositionAbsoluteInput\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MousePositionAbsoluteInputFromTouch\>\(MousePositionAbsoluteInputFromTouch?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MousePositionAbsoluteInputFromTouch\>\(MousePositionAbsoluteInputFromTouch\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MousePositionAbsoluteInputFromTouch\>\(MousePositionAbsoluteInputFromTouch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MousePositionAbsoluteInputFromTouch\>\(MousePositionAbsoluteInputFromTouch\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MousePositionAbsoluteInputFromTouch, TChild\>\(MousePositionAbsoluteInputFromTouch, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MousePositionAbsoluteInputFromTouch, TChild\>\(MousePositionAbsoluteInputFromTouch, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MousePositionAbsoluteInputFromTouch, TChild\>\(MousePositionAbsoluteInputFromTouch, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MousePositionAbsoluteInputFromTouch\>\(MousePositionAbsoluteInputFromTouch\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_MousePositionAbsoluteInputFromTouch__ctor_osu_Framework_Input_StateChanges_Events_TouchStateChangeEvent_"></a> MousePositionAbsoluteInputFromTouch\(TouchStateChangeEvent\)

```csharp
public MousePositionAbsoluteInputFromTouch(TouchStateChangeEvent touchEvent)
```

#### Parameters

`touchEvent` [TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

## Properties

### <a id="osu_Framework_Input_StateChanges_MousePositionAbsoluteInputFromTouch_TouchEvent"></a> TouchEvent

The source touch event.

```csharp
public TouchStateChangeEvent TouchEvent { get; }
```

#### Property Value

 [TouchStateChangeEvent](osu.Framework.Input.StateChanges.Events.TouchStateChangeEvent.md)

