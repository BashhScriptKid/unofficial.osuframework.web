# <a id="osu_Framework_Input_Bindings_KeyBinding"></a> Class KeyBinding

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

```csharp
public class KeyBinding : IKeyBinding
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[KeyBinding](osu.Framework.Input.Bindings.KeyBinding.md)

#### Implements

[IKeyBinding](osu.Framework.Input.Bindings.IKeyBinding.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<KeyBinding\>\(KeyBinding?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[KeyBindingExtensions.GetAction<T\>\(IKeyBinding\)](osu.Framework.Input.Bindings.KeyBindingExtensions.md\#osu\_Framework\_Input\_Bindings\_KeyBindingExtensions\_GetAction\_\_1\_osu\_Framework\_Input\_Bindings\_IKeyBinding\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<KeyBinding\>\(KeyBinding\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<KeyBinding\>\(KeyBinding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<KeyBinding\>\(KeyBinding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<KeyBinding, TChild\>\(KeyBinding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<KeyBinding, TChild\>\(KeyBinding, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<KeyBinding, TChild\>\(KeyBinding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<KeyBinding\>\(KeyBinding\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Input_Bindings_KeyBinding__ctor_osu_Framework_Input_Bindings_KeyCombination_System_Object_"></a> KeyBinding\(KeyCombination, object\)

Construct a new instance.

```csharp
public KeyBinding(KeyCombination keys, object action)
```

#### Parameters

`keys` [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

The combination of keys which will trigger this binding.

`action` [object](https://learn.microsoft.com/dotnet/api/system.object)

The resultant action which is triggered by this binding. Usually an enum type.

### <a id="osu_Framework_Input_Bindings_KeyBinding__ctor_osu_Framework_Input_Bindings_InputKey_System_Object_"></a> KeyBinding\(InputKey, object\)

Construct a new instance.

```csharp
public KeyBinding(InputKey key, object action)
```

#### Parameters

`key` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

The key which will trigger this binding.

`action` [object](https://learn.microsoft.com/dotnet/api/system.object)

The resultant action which is triggered by this binding. Usually an enum type.

### <a id="osu_Framework_Input_Bindings_KeyBinding__ctor"></a> KeyBinding\(\)

Constructor for derived classes that may require serialisation.

```csharp
public KeyBinding()
```

## Properties

### <a id="osu_Framework_Input_Bindings_KeyBinding_Action"></a> Action

The resultant action which is triggered by this binding.
Generally an enum type, but may also be an int representing an enum (converted via <xref href="osu.Framework.Input.Bindings.KeyBindingExtensions.GetAction%60%601(osu.Framework.Input.Bindings.IKeyBinding)" data-throw-if-not-resolved="false"></xref>

```csharp
public object Action { get; set; }
```

#### Property Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Input_Bindings_KeyBinding_KeyCombination"></a> KeyCombination

The combination of keys which will trigger this binding.

```csharp
public KeyCombination KeyCombination { get; set; }
```

#### Property Value

 [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

## Methods

### <a id="osu_Framework_Input_Bindings_KeyBinding_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

