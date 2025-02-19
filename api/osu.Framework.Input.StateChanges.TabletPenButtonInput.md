# <a id="osu_Framework_Input_StateChanges_TabletPenButtonInput"></a> Class TabletPenButtonInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class TabletPenButtonInput : ButtonInput<TabletPenButton>, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<TabletPenButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[TabletPenButtonInput](osu.Framework.Input.StateChanges.TabletPenButtonInput.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[ButtonInput<TabletPenButton\>.Entries](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Entries), 
[ButtonInput<TabletPenButton\>.GetButtonStates\(InputState\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_GetButtonStates\_osu\_Framework\_Input\_States\_InputState\_), 
[ButtonInput<TabletPenButton\>.CreateEvent\(InputState, TabletPenButton, ButtonStateChangeKind\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_CreateEvent\_osu\_Framework\_Input\_States\_InputState\_\_0\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonInput<TabletPenButton\>.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TabletPenButtonInput\>\(TabletPenButtonInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletPenButtonInput\>\(TabletPenButtonInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletPenButtonInput\>\(TabletPenButtonInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletPenButtonInput\>\(TabletPenButtonInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletPenButtonInput, TChild\>\(TabletPenButtonInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletPenButtonInput, TChild\>\(TabletPenButtonInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletPenButtonInput, TChild\>\(TabletPenButtonInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletPenButtonInput\>\(TabletPenButtonInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_TabletPenButtonInput__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Input_StateChanges_ButtonInputEntry_osu_Framework_Input_TabletPenButton___"></a> TabletPenButtonInput\(IEnumerable<ButtonInputEntry<TabletPenButton\>\>\)

```csharp
public TabletPenButtonInput(IEnumerable<ButtonInputEntry<TabletPenButton>> entries)
```

#### Parameters

`entries` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ButtonInputEntry](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)<[TabletPenButton](osu.Framework.Input.TabletPenButton.md)\>\>

### <a id="osu_Framework_Input_StateChanges_TabletPenButtonInput__ctor_osu_Framework_Input_TabletPenButton_System_Boolean_"></a> TabletPenButtonInput\(TabletPenButton, bool\)

```csharp
public TabletPenButtonInput(TabletPenButton button, bool isPressed)
```

#### Parameters

`button` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_StateChanges_TabletPenButtonInput__ctor_osu_Framework_Input_States_ButtonStates_osu_Framework_Input_TabletPenButton__osu_Framework_Input_States_ButtonStates_osu_Framework_Input_TabletPenButton__"></a> TabletPenButtonInput\(ButtonStates<TabletPenButton\>, ButtonStates<TabletPenButton\>\)

```csharp
public TabletPenButtonInput(ButtonStates<TabletPenButton> current, ButtonStates<TabletPenButton> previous)
```

#### Parameters

`current` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletPenButton](osu.Framework.Input.TabletPenButton.md)\>

`previous` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletPenButton](osu.Framework.Input.TabletPenButton.md)\>

## Methods

### <a id="osu_Framework_Input_StateChanges_TabletPenButtonInput_GetButtonStates_osu_Framework_Input_States_InputState_"></a> GetButtonStates\(InputState\)

Retrieves the <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> from an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override ButtonStates<TabletPenButton> GetButtonStates(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletPenButton](osu.Framework.Input.TabletPenButton.md)\>

