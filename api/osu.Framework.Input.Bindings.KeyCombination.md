# <a id="osu_Framework_Input_Bindings_KeyCombination"></a> Struct KeyCombination

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

Represent a combination of more than one <xref href="osu.Framework.Input.Bindings.InputKey" data-throw-if-not-resolved="false"></xref>s.

```csharp
public readonly struct KeyCombination : IEquatable<KeyCombination>
```

#### Implements

[IEquatable<KeyCombination\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<KeyCombination\>\(KeyCombination\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<KeyCombination\>\(KeyCombination\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<KeyCombination\>\(KeyCombination\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<KeyCombination\>\(KeyCombination\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<KeyCombination, TChild\>\(KeyCombination, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<KeyCombination, TChild\>\(KeyCombination, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<KeyCombination, TChild\>\(KeyCombination, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<KeyCombination\>\(KeyCombination\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Bindings_KeyCombination__ctor_System_Collections_Generic_ICollection_osu_Framework_Input_Bindings_InputKey__"></a> KeyCombination\(ICollection<InputKey\>?\)

Construct a new instance.

```csharp
public KeyCombination(ICollection<InputKey>? keys)
```

#### Parameters

`keys` [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<[InputKey](osu.Framework.Input.Bindings.InputKey.md)\>?

The keys.

### <a id="osu_Framework_Input_Bindings_KeyCombination__ctor_osu_Framework_Input_Bindings_InputKey___"></a> KeyCombination\(params InputKey\[\]\)

Construct a new instance.

```csharp
public KeyCombination(params InputKey[] keys)
```

#### Parameters

`keys` [InputKey](osu.Framework.Input.Bindings.InputKey.md)\[\]

The keys.

#### Remarks

This constructor is not optimized. Hot paths are assumed to use <xref href="osu.Framework.Input.Bindings.KeyCombination.FromInputState(osu.Framework.Input.States.InputState%2cSystem.Nullable%7bosuTK.Vector2%7d)" data-throw-if-not-resolved="false"></xref>.

### <a id="osu_Framework_Input_Bindings_KeyCombination__ctor_System_String_"></a> KeyCombination\(string\)

Construct a new instance from string representation provided by <xref href="osu.Framework.Input.Bindings.KeyCombination.ToString" data-throw-if-not-resolved="false"></xref>.

```csharp
public KeyCombination(string keys)
```

#### Parameters

`keys` [string](https://learn.microsoft.com/dotnet/api/system.string)

A comma-separated (KeyCode in integer) string representation of the keys.

#### Remarks

This constructor is not optimized. Hot paths are assumed to use <xref href="osu.Framework.Input.Bindings.KeyCombination.FromInputState(osu.Framework.Input.States.InputState%2cSystem.Nullable%7bosuTK.Vector2%7d)" data-throw-if-not-resolved="false"></xref>.

## Fields

### <a id="osu_Framework_Input_Bindings_KeyCombination_Keys"></a> Keys

The keys.

```csharp
public readonly ImmutableArray<InputKey> Keys
```

#### Field Value

 [ImmutableArray](https://learn.microsoft.com/dotnet/api/system.collections.immutable.immutablearray\-1)<[InputKey](osu.Framework.Input.Bindings.InputKey.md)\>

## Methods

### <a id="osu_Framework_Input_Bindings_KeyCombination_Equals_osu_Framework_Input_Bindings_KeyCombination_"></a> Equals\(KeyCombination\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public bool Equals(KeyCombination other)
```

#### Parameters

`other` [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Input_Bindings_KeyCombination_Equals_System_Object_"></a> Equals\(object?\)

Indicates whether this instance and a specified object are equal.

```csharp
public override bool Equals(object? obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">obj</code> and this instance are the same type and represent the same value; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromInputState_osu_Framework_Input_States_InputState_System_Nullable_osuTK_Vector2__"></a> FromInputState\(InputState, Vector2?\)

Construct a new instance from input state.

```csharp
public static KeyCombination FromInputState(InputState state, Vector2? scrollDelta = null)
```

#### Parameters

`state` [InputState](osu.Framework.Input.States.InputState.md)

The input state object.

`scrollDelta` Vector2?

Delta of scroller's position.

#### Returns

 [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

The new constructed <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> instance.

#### Remarks

This factory method is optimized and should be used for hot paths.

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromJoystickButton_osu_Framework_Input_JoystickButton_"></a> FromJoystickButton\(JoystickButton\)

```csharp
public static InputKey FromJoystickButton(JoystickButton button)
```

#### Parameters

`button` [JoystickButton](osu.Framework.Input.JoystickButton.md)

#### Returns

 [InputKey](osu.Framework.Input.Bindings.InputKey.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromKey_osuTK_Input_Key_"></a> FromKey\(Key\)

```csharp
public static InputKey FromKey(Key key)
```

#### Parameters

`key` Key

#### Returns

 [InputKey](osu.Framework.Input.Bindings.InputKey.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromMidiKey_osu_Framework_Input_MidiKey_"></a> FromMidiKey\(MidiKey\)

```csharp
public static InputKey FromMidiKey(MidiKey key)
```

#### Parameters

`key` [MidiKey](osu.Framework.Input.MidiKey.md)

#### Returns

 [InputKey](osu.Framework.Input.Bindings.InputKey.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromMouseButton_osuTK_Input_MouseButton_"></a> FromMouseButton\(MouseButton\)

```csharp
public static InputKey FromMouseButton(MouseButton button)
```

#### Parameters

`button` MouseButton

#### Returns

 [InputKey](osu.Framework.Input.Bindings.InputKey.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromScrollDelta_osuTK_Vector2_"></a> FromScrollDelta\(Vector2\)

```csharp
public static IEnumerable<InputKey> FromScrollDelta(Vector2 scrollDelta)
```

#### Parameters

`scrollDelta` Vector2

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[InputKey](osu.Framework.Input.Bindings.InputKey.md)\>

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromTabletAuxiliaryButton_osu_Framework_Input_TabletAuxiliaryButton_"></a> FromTabletAuxiliaryButton\(TabletAuxiliaryButton\)

```csharp
public static InputKey FromTabletAuxiliaryButton(TabletAuxiliaryButton auxiliaryButton)
```

#### Parameters

`auxiliaryButton` [TabletAuxiliaryButton](osu.Framework.Input.TabletAuxiliaryButton.md)

#### Returns

 [InputKey](osu.Framework.Input.Bindings.InputKey.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_FromTabletPenButton_osu_Framework_Input_TabletPenButton_"></a> FromTabletPenButton\(TabletPenButton\)

```csharp
public static InputKey FromTabletPenButton(TabletPenButton penButton)
```

#### Parameters

`penButton` [TabletPenButton](osu.Framework.Input.TabletPenButton.md)

#### Returns

 [InputKey](osu.Framework.Input.Bindings.InputKey.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for this instance.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A 32-bit signed integer that is the hash code for this instance.

### <a id="osu_Framework_Input_Bindings_KeyCombination_IsModifierKey_osu_Framework_Input_Bindings_InputKey_"></a> IsModifierKey\(InputKey\)

```csharp
public static bool IsModifierKey(InputKey key)
```

#### Parameters

`key` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Input_Bindings_KeyCombination_IsPressed_osu_Framework_Input_Bindings_KeyCombination_osu_Framework_Input_States_InputState_osu_Framework_Input_Bindings_KeyCombinationMatchingMode_"></a> IsPressed\(KeyCombination, InputState, KeyCombinationMatchingMode\)

Check whether the provided pressed keys are valid for this <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool IsPressed(KeyCombination pressedKeys, InputState inputState, KeyCombinationMatchingMode matchingMode)
```

#### Parameters

`pressedKeys` [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

The potential pressed keys for this <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref>.

`inputState` [InputState](osu.Framework.Input.States.InputState.md)

The current input state.

`matchingMode` [KeyCombinationMatchingMode](osu.Framework.Input.Bindings.KeyCombinationMatchingMode.md)

The method for handling exact key matches.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the pressedKeys keys are valid.

### <a id="osu_Framework_Input_Bindings_KeyCombination_ToString"></a> ToString\(\)

Get a string representation can be used with <xref href="osu.Framework.Input.Bindings.KeyCombination.%23ctor(System.String)" data-throw-if-not-resolved="false"></xref>.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The string representation.

## Operators

### <a id="osu_Framework_Input_Bindings_KeyCombination_op_Implicit_osu_Framework_Input_Bindings_InputKey__osu_Framework_Input_Bindings_KeyCombination"></a> implicit operator KeyCombination\(InputKey\)

```csharp
public static implicit operator KeyCombination(InputKey singleKey)
```

#### Parameters

`singleKey` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

#### Returns

 [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_op_Implicit_System_String__osu_Framework_Input_Bindings_KeyCombination"></a> implicit operator KeyCombination\(string\)

```csharp
public static implicit operator KeyCombination(string stringRepresentation)
```

#### Parameters

`stringRepresentation` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

### <a id="osu_Framework_Input_Bindings_KeyCombination_op_Implicit_osu_Framework_Input_Bindings_InputKey____osu_Framework_Input_Bindings_KeyCombination"></a> implicit operator KeyCombination\(InputKey\[\]\)

```csharp
public static implicit operator KeyCombination(InputKey[] keys)
```

#### Parameters

`keys` [InputKey](osu.Framework.Input.Bindings.InputKey.md)\[\]

#### Returns

 [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

