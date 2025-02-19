# <a id="osu_Framework_Input_Events_MidiUpEvent"></a> Class MidiUpEvent

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

```csharp
public class MidiUpEvent : MidiEvent
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[MidiEvent](osu.Framework.Input.Events.MidiEvent.md) ← 
[MidiUpEvent](osu.Framework.Input.Events.MidiUpEvent.md)

#### Inherited Members

[MidiEvent.Key](osu.Framework.Input.Events.MidiEvent.md\#osu\_Framework\_Input\_Events\_MidiEvent\_Key), 
[MidiEvent.Velocity](osu.Framework.Input.Events.MidiEvent.md\#osu\_Framework\_Input\_Events\_MidiEvent\_Velocity), 
[MidiEvent.IsPressed\(MidiKey\)](osu.Framework.Input.Events.MidiEvent.md\#osu\_Framework\_Input\_Events\_MidiEvent\_IsPressed\_osu\_Framework\_Input\_MidiKey\_), 
[MidiEvent.HasAnyKeyPressed](osu.Framework.Input.Events.MidiEvent.md\#osu\_Framework\_Input\_Events\_MidiEvent\_HasAnyKeyPressed), 
[MidiEvent.PressedKeys](osu.Framework.Input.Events.MidiEvent.md\#osu\_Framework\_Input\_Events\_MidiEvent\_PressedKeys), 
[MidiEvent.ToString\(\)](osu.Framework.Input.Events.MidiEvent.md\#osu\_Framework\_Input\_Events\_MidiEvent\_ToString), 
[UIEvent.CurrentState](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_CurrentState), 
[UIEvent.Target](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_Target), 
[UIEvent.ToLocalSpace\(Vector2\)](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ToLocalSpace\_osuTK\_Vector2\_), 
[UIEvent.ScreenSpaceMousePosition](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ScreenSpaceMousePosition), 
[UIEvent.MousePosition](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_MousePosition), 
[UIEvent.ControlPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ControlPressed), 
[UIEvent.AltPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_AltPressed), 
[UIEvent.ShiftPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ShiftPressed), 
[UIEvent.SuperPressed](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_SuperPressed), 
[UIEvent.ToString\(\)](osu.Framework.Input.Events.UIEvent.md\#osu\_Framework\_Input\_Events\_UIEvent\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MidiUpEvent\>\(MidiUpEvent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MidiUpEvent\>\(MidiUpEvent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MidiUpEvent\>\(MidiUpEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MidiUpEvent\>\(MidiUpEvent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MidiUpEvent, TChild\>\(MidiUpEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MidiUpEvent, TChild\>\(MidiUpEvent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MidiUpEvent, TChild\>\(MidiUpEvent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MidiUpEvent\>\(MidiUpEvent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_MidiUpEvent__ctor_osu_Framework_Input_States_InputState_osu_Framework_Input_MidiKey_"></a> MidiUpEvent\(InputState, MidiKey\)

```csharp
public MidiUpEvent(InputState state, MidiKey key)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`key` [MidiKey](osu.Framework.Input.MidiKey.md)

