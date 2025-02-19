# <a id="osu_Framework_Input_StateChanges_ButtonInput_1"></a> Class ButtonInput<TButton\>

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

An abstract base class of an <xref href="osu.Framework.Input.StateChanges.IInput" data-throw-if-not-resolved="false"></xref> which denotes a list of button state changes (pressed or released).

```csharp
public abstract class ButtonInput<TButton> : IInput where TButton : struct
```

#### Type Parameters

`TButton` 

The type of button.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<TButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md)

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

[ObjectExtensions.AsNonNull<ButtonInput<TButton\>\>\(ButtonInput<TButton\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ButtonInput<TButton\>\>\(ButtonInput<TButton\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ButtonInput<TButton\>\>\(ButtonInput<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ButtonInput<TButton\>\>\(ButtonInput<TButton\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ButtonInput<TButton\>, TChild\>\(ButtonInput<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ButtonInput<TButton\>, TChild\>\(ButtonInput<TButton\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ButtonInput<TButton\>, TChild\>\(ButtonInput<TButton\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ButtonInput<TButton\>\>\(ButtonInput<TButton\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Input_StateChanges_ButtonInputEntry__0___"></a> ButtonInput\(IEnumerable<ButtonInputEntry<TButton\>\>\)

```csharp
protected ButtonInput(IEnumerable<ButtonInputEntry<TButton>> entries)
```

#### Parameters

`entries` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ButtonInputEntry](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)<TButton\>\>

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1__ctor__0_System_Boolean_"></a> ButtonInput\(TButton, bool\)

Creates a <xref href="osu.Framework.Input.StateChanges.ButtonInput%601" data-throw-if-not-resolved="false"></xref> with a single <code class="typeparamref">TButton</code> state.

```csharp
protected ButtonInput(TButton button, bool isPressed)
```

#### Parameters

`button` TButton

The <code class="typeparamref">TButton</code> to add.

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

The state of <code class="paramref">button</code>.

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1__ctor_osu_Framework_Input_States_ButtonStates__0__osu_Framework_Input_States_ButtonStates__0__"></a> ButtonInput\(ButtonStates<TButton\>?, ButtonStates<TButton\>?\)

Creates a <xref href="osu.Framework.Input.StateChanges.ButtonInput%601" data-throw-if-not-resolved="false"></xref> from the difference of two <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref>.

```csharp
protected ButtonInput(ButtonStates<TButton>? current, ButtonStates<TButton>? previous)
```

#### Parameters

`current` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>?

The newer <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref>.

`previous` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>?

The older <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref>.

#### Remarks

Buttons that are pressed in <code class="paramref">previous</code> and not pressed in <code class="paramref">current</code> will be listed as <xref href="osu.Framework.Input.StateChanges.ButtonStateChangeKind.Released" data-throw-if-not-resolved="false"></xref>.
Buttons that are not pressed in <code class="paramref">previous</code> and pressed in <code class="paramref">current</code> will be listed as <xref href="osu.Framework.Input.StateChanges.ButtonStateChangeKind.Pressed" data-throw-if-not-resolved="false"></xref>.

## Fields

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1_Entries"></a> Entries

```csharp
public ImmutableArray<ButtonInputEntry<TButton>> Entries
```

#### Field Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[ButtonInputEntry](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)<TButton\>\>

## Methods

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1_Apply_osu_Framework_Input_States_InputState_osu_Framework_Input_StateChanges_IInputStateChangeHandler_"></a> Apply\(InputState, IInputStateChangeHandler\)

Applies input to an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.
This alters the <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> and propagates the change to an <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref>.

```csharp
public virtual void Apply(InputState state, IInputStateChangeHandler handler)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> to apply changes to.

`handler` [IInputStateChangeHandler](osu.Framework.Input.StateChanges.IInputStateChangeHandler.md)

The <xref href="osu.Framework.Input.StateChanges.IInputStateChangeHandler" data-throw-if-not-resolved="false"></xref> to handle changes to <code class="paramref">state</code>.

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1_CreateEvent_osu_Framework_Input_States_InputState__0_osu_Framework_Input_StateChanges_ButtonStateChangeKind_"></a> CreateEvent\(InputState, TButton, ButtonStateChangeKind\)

Create a <code class="typeparamref">TButton</code> state change event.

```csharp
protected virtual ButtonStateChangeEvent<TButton> CreateEvent(InputState state, TButton button, ButtonStateChangeKind kind)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref> which changed.

`button` TButton

The <code class="typeparamref">TButton</code> that changed.

`kind` [ButtonStateChangeKind](osu.Framework.Input.StateChanges.ButtonStateChangeKind.md)

The type of change that occurred on <code class="paramref">button</code>.

#### Returns

 [ButtonStateChangeEvent](osu.Framework.Input.StateChanges.Events.ButtonStateChangeEvent\-1.md)<TButton\>

### <a id="osu_Framework_Input_StateChanges_ButtonInput_1_GetButtonStates_osu_Framework_Input_States_InputState_"></a> GetButtonStates\(InputState\)

Retrieves the <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> from an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

```csharp
protected abstract ButtonStates<TButton> GetButtonStates(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<TButton\>

