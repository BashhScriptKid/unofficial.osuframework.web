# <a id="osu_Framework_Input_StateChanges_KeyboardKeyInput"></a> Class KeyboardKeyInput

Namespace: [osu.Framework.Input.StateChanges](osu.Framework.Input.StateChanges.md)  
Assembly: osu.Framework.dll  

```csharp
public class KeyboardKeyInput : ButtonInput<Key>, IInput
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ButtonInput<Key\>](osu.Framework.Input.StateChanges.ButtonInput\-1.md) ← 
[KeyboardKeyInput](osu.Framework.Input.StateChanges.KeyboardKeyInput.md)

#### Implements

[IInput](osu.Framework.Input.StateChanges.IInput.md)

#### Inherited Members

[ButtonInput<Key\>.Entries](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Entries), 
[ButtonInput<Key\>.GetButtonStates\(InputState\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_GetButtonStates\_osu\_Framework\_Input\_States\_InputState\_), 
[ButtonInput<Key\>.CreateEvent\(InputState, Key, ButtonStateChangeKind\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_CreateEvent\_osu\_Framework\_Input\_States\_InputState\_\_0\_osu\_Framework\_Input\_StateChanges\_ButtonStateChangeKind\_), 
[ButtonInput<Key\>.Apply\(InputState, IInputStateChangeHandler\)](osu.Framework.Input.StateChanges.ButtonInput\-1.md\#osu\_Framework\_Input\_StateChanges\_ButtonInput\_1\_Apply\_osu\_Framework\_Input\_States\_InputState\_osu\_Framework\_Input\_StateChanges\_IInputStateChangeHandler\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<KeyboardKeyInput\>\(KeyboardKeyInput?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<KeyboardKeyInput\>\(KeyboardKeyInput\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<KeyboardKeyInput\>\(KeyboardKeyInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<KeyboardKeyInput\>\(KeyboardKeyInput\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<KeyboardKeyInput, TChild\>\(KeyboardKeyInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<KeyboardKeyInput, TChild\>\(KeyboardKeyInput, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<KeyboardKeyInput, TChild\>\(KeyboardKeyInput, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<KeyboardKeyInput\>\(KeyboardKeyInput\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_StateChanges_KeyboardKeyInput__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Input_StateChanges_ButtonInputEntry_osuTK_Input_Key___"></a> KeyboardKeyInput\(IEnumerable<ButtonInputEntry<Key\>\>\)

```csharp
public KeyboardKeyInput(IEnumerable<ButtonInputEntry<Key>> entries)
```

#### Parameters

`entries` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ButtonInputEntry](osu.Framework.Input.StateChanges.ButtonInputEntry\-1.md)<Key\>\>

### <a id="osu_Framework_Input_StateChanges_KeyboardKeyInput__ctor_osuTK_Input_Key_System_Boolean_"></a> KeyboardKeyInput\(Key, bool\)

```csharp
public KeyboardKeyInput(Key button, bool isPressed)
```

#### Parameters

`button` Key

`isPressed` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_StateChanges_KeyboardKeyInput__ctor_osu_Framework_Input_States_ButtonStates_osuTK_Input_Key__osu_Framework_Input_States_ButtonStates_osuTK_Input_Key__"></a> KeyboardKeyInput\(ButtonStates<Key\>?, ButtonStates<Key\>?\)

```csharp
public KeyboardKeyInput(ButtonStates<Key>? current, ButtonStates<Key>? previous)
```

#### Parameters

`current` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<Key\>?

`previous` [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<Key\>?

## Methods

### <a id="osu_Framework_Input_StateChanges_KeyboardKeyInput_GetButtonStates_osu_Framework_Input_States_InputState_"></a> GetButtonStates\(InputState\)

Retrieves the <xref href="osu.Framework.Input.States.ButtonStates%601" data-throw-if-not-resolved="false"></xref> from an <xref href="osu.Framework.Input.States.InputState" data-throw-if-not-resolved="false"></xref>.

```csharp
protected override ButtonStates<Key> GetButtonStates(InputState state)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

#### Returns

 [ButtonStates](osu.Framework.Input.States.ButtonStates\-1.md)<Key\>

