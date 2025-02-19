# <a id="osu_Framework_Input_StateChanges_MousePositionRelativeInput"></a> Class MousePositionRelativeInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

Denotes a relative change of mouse position.
Pointing devices such as mice provide relative positional input.

```csharp
public class MousePositionRelativeInput : IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MousePositionRelativeInput](osu.Framework.Input.StateChanges.MousePositionRelativeInput.md)

#### Derived

[MousePositionRelativeInputFromPen](osu.Framework.Input.StateChanges.MousePositionRelativeInputFromPen.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<MousePositionRelativeInput\>\(MousePositionRelativeInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MousePositionRelativeInput\>\(MousePositionRelativeInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MousePositionRelativeInput\>\(MousePositionRelativeInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MousePositionRelativeInput\>\(MousePositionRelativeInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MousePositionRelativeInput, TChild\>\(MousePositionRelativeInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MousePositionRelativeInput, TChild\>\(MousePositionRelativeInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MousePositionRelativeInput, TChild\>\(MousePositionRelativeInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MousePositionRelativeInput\>\(MousePositionRelativeInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Input_StateChanges_MousePositionRelativeInput_Delta"></a> Delta

The change in position. This will be added to the current position.
When the current position is not valid, no changes will be made.

```csharp
public Vector2 Delta
```

#### Field Value

 Vector2

## Methods

### <a id="osu_Framework_Input_StateChanges_MousePositionRelativeInput_Apply_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInputStateChangeHandler_"></a> Apply\(InputState, IInputStateChangeHandler\)

Applies input to an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.
This alters the <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> and propagates the change to an <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Apply(InputState state, IInputStateChangeHandler handler)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> to apply changes to.

`handler` [IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md)

The <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref> to handle changes to <code class="paramref">state</code>.

