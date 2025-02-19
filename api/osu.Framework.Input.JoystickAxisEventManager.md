# <a id="osu_Framework_Input_JoystickAxisEventManager"></a> Class JoystickAxisEventManager

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public class JoystickAxisEventManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[JoystickAxisEventManager](osu.Framework.Input.JoystickAxisEventManager.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<JoystickAxisEventManager\>\(JoystickAxisEventManager?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<JoystickAxisEventManager\>\(JoystickAxisEventManager\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<JoystickAxisEventManager\>\(JoystickAxisEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<JoystickAxisEventManager\>\(JoystickAxisEventManager\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<JoystickAxisEventManager, TChild\>\(JoystickAxisEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<JoystickAxisEventManager, TChild\>\(JoystickAxisEventManager, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<JoystickAxisEventManager, TChild\>\(JoystickAxisEventManager, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<JoystickAxisEventManager\>\(JoystickAxisEventManager\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_JoystickAxisEventManager__ctor_osu_Framework_Input_JoystickAxisSource_"></a> JoystickAxisEventManager\(JoystickAxisSource\)

```csharp
public JoystickAxisEventManager(JoystickAxisSource source)
```

#### Parameters

`source` [JoystickAxisSource](osu.Framework.Input.JoystickAxisSource.md)

## Properties

### <a id="osu_Framework_Input_JoystickAxisEventManager_InputQueue"></a> InputQueue

The input queue.

```csharp
[NotNull]
protected IEnumerable<Drawable> InputQueue { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

## Methods

### <a id="osu_Framework_Input_JoystickAxisEventManager_HandleAxisChange_osu_Framework_Input_States_InputState_System_Single_System_Single_"></a> HandleAxisChange\(InputState, float, float\)

Handles axis value changing.

```csharp
public void HandleAxisChange(InputState state, float newValue, float lastValue)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The current <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

`newValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The new value for this axis.

`lastValue` [float](https://learn.microsoft.com/dotnet/api/system.single)

The last value for this axis.

### <a id="osu_Framework_Input_JoystickAxisEventManager_PropagateEvent_System_Collections_Generic_IEnumerable_osu_Framework_Graphics_Drawable__osu_Framework_Input_Events_UIEvent_"></a> PropagateEvent\(IEnumerable<Drawable\>, UIEvent\)

Triggers events on drawables in <code class="paramref">drawables</code> until it is handled.

```csharp
protected Drawable PropagateEvent(IEnumerable<Drawable> drawables, UIEvent e)
```

#### Parameters

`drawables` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

The drawables in the queue.

`e` [UIEvent](osu.Framework.Input.Events.UIEvent.md)

The event.

#### Returns

 [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable which handled the event or null if none.

