# <a id="osu_Framework_Input_StateChanges_MouseButtonInput"></a> Class MouseButtonInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class MouseButtonInput : ButtonInput<MouseButton>, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<MouseButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[MouseButtonInput](osu.Framework.Input.StateChanges.MouseButtonInput.md)

#### Derived

[MouseButtonInputFromPen](osu.Framework.Input.StateChanges.MouseButtonInputFromPen.md), 
[MouseButtonInputFromTouch](osu.Framework.Input.StateChanges.MouseButtonInputFromTouch.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

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

[ObjectExtensions.AsNonNull<MouseButtonInput\>\(MouseButtonInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<MouseButtonInput\>\(MouseButtonInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<MouseButtonInput\>\(MouseButtonInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<MouseButtonInput\>\(MouseButtonInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<MouseButtonInput, TChild\>\(MouseButtonInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<MouseButtonInput, TChild\>\(MouseButtonInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<MouseButtonInput, TChild\>\(MouseButtonInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<MouseButtonInput\>\(MouseButtonInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_MouseButtonInput__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Input_StateChanges_ButtonInputEntry_osuTK_Input_MouseButton___"></a> MouseButtonInput\(IEnumerable<ButtonInputEntry<MouseButton\>\>\)

```csharp
public MouseButtonInput(IEnumerable<ButtonInputEntry<MouseButton>> entries)
```

#### Parameters

`entries` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ButtonInputEntry](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)<MouseButton\>\>

### <a id="osu_Framework_Input_StateChanges_MouseButtonInput__ctor_osuTK_Input_MouseButton_System_Boolean_"></a> MouseButtonInput\(MouseButton, bool\)

```csharp
public MouseButtonInput(MouseButton button, bool isPressed)
```

#### Parameters

`button` MouseButton

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_StateChanges_MouseButtonInput__ctor_osu_Framework_Input_States_ButtonStates_osuTK_Input_MouseButton__osu_Framework_Input_States_ButtonStates_osuTK_Input_MouseButton__"></a> MouseButtonInput\(ButtonStates<MouseButton\>, ButtonStates<MouseButton\>\)

```csharp
public MouseButtonInput(ButtonStates<MouseButton> current, ButtonStates<MouseButton> previous)
```

#### Parameters

`current` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<MouseButton\>

`previous` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<MouseButton\>

## Methods

### <a id="osu_Framework_Input_StateChanges_MouseButtonInput_Apply_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInputStateChangeHandler_"></a> Apply\(InputState, IInputStateChangeHandler\)

Applies input to an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.
This alters the <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> and propagates the change to an <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref>.

```csharp
public override void Apply(InputState state, IInputStateChangeHandler handler)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> to apply changes to.

`handler` [IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md)

The <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref> to handle changes to <code class="paramref">state</code>.

### <a id="osu_Framework_Input_StateChanges_MouseButtonInput_GetButtonStates_osu_Framework_Input_States_InputState_"></a> GetButtonStates\(InputState\)

Retrieves the <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> from an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override ButtonStates<MouseButton> GetButtonStates(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<MouseButton\>

