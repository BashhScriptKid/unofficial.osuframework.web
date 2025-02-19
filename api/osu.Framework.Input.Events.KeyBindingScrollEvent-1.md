# <a id="osu_Framework_Input_Events_KeyBindingScrollEvent_1"></a> Class KeyBindingScrollEvent<T\>

Namespace: [osu.Framework.Input.Events](osu.Framework.Input.Events.md)  
Assembly: osu.Framework.dll  

An event representing a change of a key binding's associated mouse wheel direction.

```csharp
public class KeyBindingScrollEvent<T> : KeyBindingEvent<T> where T : struct
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UIEvent](osu.Framework.Input.Events.UIEvent.md) ← 
[KeyBindingEvent<T\>](osu.Framework.Input.Events.KeyBindingEvent\-1.md) ← 
[KeyBindingScrollEvent<T\>](osu.Framework.Input.Events.KeyBindingScrollEvent\-1.md)

#### Inherited Members

[KeyBindingEvent<T\>.Action](osu.Framework.Input.Events.KeyBindingEvent\-1.md\#osu\_Framework\_Input\_Events\_KeyBindingEvent\_1\_Action), 
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

[ObjectExtensions.AsNonNull<KeyBindingScrollEvent<T\>\>\(KeyBindingScrollEvent<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<KeyBindingScrollEvent<T\>\>\(KeyBindingScrollEvent<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<KeyBindingScrollEvent<T\>\>\(KeyBindingScrollEvent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<KeyBindingScrollEvent<T\>\>\(KeyBindingScrollEvent<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<KeyBindingScrollEvent<T\>, TChild\>\(KeyBindingScrollEvent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<KeyBindingScrollEvent<T\>, TChild\>\(KeyBindingScrollEvent<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<KeyBindingScrollEvent<T\>, TChild\>\(KeyBindingScrollEvent<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<KeyBindingScrollEvent<T\>\>\(KeyBindingScrollEvent<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Events_KeyBindingScrollEvent_1__ctor_osu_Framework_Input_States_InputState__0_System_Single_System_Boolean_"></a> KeyBindingScrollEvent\(InputState, T, float, bool\)

```csharp
public KeyBindingScrollEvent(InputState state, T action, float amount, bool isPrecise = false)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

`action` T

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

`isPrecise` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Fields

### <a id="osu_Framework_Input_Events_KeyBindingScrollEvent_1_IsPrecise"></a> IsPrecise

Whether the change came from a device supporting precision scrolling.

```csharp
public readonly bool IsPrecise
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

In cases this is true, scroll events will generally map 1:1 to user's input, rather than incrementing in large "notches" (as expected of traditional scroll wheels).

### <a id="osu_Framework_Input_Events_KeyBindingScrollEvent_1_ScrollAmount"></a> ScrollAmount

The relative change in scroll associated with this event.

```csharp
public readonly float ScrollAmount
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

