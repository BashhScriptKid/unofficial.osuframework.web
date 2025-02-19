# <a id="osu_Framework_Input_StateChanges_TabletAuxiliaryButtonInput"></a> Class TabletAuxiliaryButtonInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class TabletAuxiliaryButtonInput : ButtonInput<TabletAuxiliaryButton>, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<TabletAuxiliaryButton\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[TabletAuxiliaryButtonInput](osu.Framework.Input.StateChanges.TabletAuxiliaryButtonInput.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[ButtonInput<TabletAuxiliaryButton\>.Entries](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Entries), 
[ButtonInput<TabletAuxiliaryButton\>.GetButtonStates\(InputState\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_GetButtonStates\_osu\_Framework\_Input\_States\_InputState\_), 
[ButtonInput<TabletAuxiliaryButton\>.CreateEvent\(InputState, TabletAuxiliaryButton, ButtonStateChangeKind\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_CreateEvent\_osu\_Framework\_Input\_States\_InputState\_\_0\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonInput<TabletAuxiliaryButton\>.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TabletAuxiliaryButtonInput\>\(TabletAuxiliaryButtonInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TabletAuxiliaryButtonInput\>\(TabletAuxiliaryButtonInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TabletAuxiliaryButtonInput\>\(TabletAuxiliaryButtonInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TabletAuxiliaryButtonInput\>\(TabletAuxiliaryButtonInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TabletAuxiliaryButtonInput, TChild\>\(TabletAuxiliaryButtonInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TabletAuxiliaryButtonInput, TChild\>\(TabletAuxiliaryButtonInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TabletAuxiliaryButtonInput, TChild\>\(TabletAuxiliaryButtonInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TabletAuxiliaryButtonInput\>\(TabletAuxiliaryButtonInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_TabletAuxiliaryButtonInput__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Input_StateChanges_ButtonInputEntry_osu_Framework_Input_TabletAuxiliaryButton___"></a> TabletAuxiliaryButtonInput\(IEnumerable<ButtonInputEntry<TabletAuxiliaryButton\>\>\)

```csharp
public TabletAuxiliaryButtonInput(IEnumerable<ButtonInputEntry<TabletAuxiliaryButton>> entries)
```

#### Parameters

`entries` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ButtonInputEntry](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)<[TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)\>\>

### <a id="osu_Framework_Input_StateChanges_TabletAuxiliaryButtonInput__ctor_osu_Framework_Input_TabletAuxiliaryButton_System_Boolean_"></a> TabletAuxiliaryButtonInput\(TabletAuxiliaryButton, bool\)

```csharp
public TabletAuxiliaryButtonInput(TabletAuxiliaryButton button, bool isPressed)
```

#### Parameters

`button` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_StateChanges_TabletAuxiliaryButtonInput__ctor_osu_Framework_Input_States_ButtonStates_osu_Framework_Input_TabletAuxiliaryButton__osu_Framework_Input_States_ButtonStates_osu_Framework_Input_TabletAuxiliaryButton__"></a> TabletAuxiliaryButtonInput\(ButtonStates<TabletAuxiliaryButton\>, ButtonStates<TabletAuxiliaryButton\>\)

```csharp
public TabletAuxiliaryButtonInput(ButtonStates<TabletAuxiliaryButton> current, ButtonStates<TabletAuxiliaryButton> previous)
```

#### Parameters

`current` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)\>

`previous` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)\>

## Methods

### <a id="osu_Framework_Input_StateChanges_TabletAuxiliaryButtonInput_GetButtonStates_osu_Framework_Input_States_InputState_"></a> GetButtonStates\(InputState\)

Retrieves the <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> from an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override ButtonStates<TabletAuxiliaryButton> GetButtonStates(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<[TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)\>

