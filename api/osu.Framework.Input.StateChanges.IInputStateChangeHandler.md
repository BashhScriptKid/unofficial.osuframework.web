# <a id="osu_Framework_Input_StateChanges_IInputStateChangeHandler"></a> Interface IInputStateChangeHandler

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

An object which can handle <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> changes.

```csharp
public interface IInputStateChangeHandler
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IInputStateChangeHandler\>\(IInputStateChangeHandler?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IInputStateChangeHandler\>\(IInputStateChangeHandler\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IInputStateChangeHandler\>\(IInputStateChangeHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IInputStateChangeHandler\>\(IInputStateChangeHandler\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IInputStateChangeHandler, TChild\>\(IInputStateChangeHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IInputStateChangeHandler, TChild\>\(IInputStateChangeHandler, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IInputStateChangeHandler, TChild\>\(IInputStateChangeHandler, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IInputStateChangeHandler\>\(IInputStateChangeHandler\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Input_StateChanges_IInputStateChangeHandler_HandleInputStateChange_osu_Framework_Input_StateChanges_Events_InputStateChangeEvent_"></a> HandleInputStateChange\(InputStateChangeEvent\)

Handles an input state change event.

```csharp
void HandleInputStateChange(InputStateChangeEvent inputStateChange)
```

#### Parameters

`inputStateChange` [InputStateChangeEvent](osu.Framework.Input.StateChanges.Events.InputStateChangeEvent.md)

