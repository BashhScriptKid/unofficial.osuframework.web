# <a id="osu_Framework_Input_Bindings_IKeyBinding"></a> Interface IKeyBinding

Namespace: [osu.Framework.Input.Bindings](osu.Framework.Input.Bindings.md)  
Assembly: osu.Framework.dll  

A binding of a <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> to an action.

```csharp
public interface IKeyBinding
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IKeyBinding\>\(IKeyBinding?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[KeyBindingExtensions.GetAction<T\>\(IKeyBinding\)](osu.Framework.Input.Bindings.KeyBindingExtensions.md\#osu\_Framework\_Input\_Bindings\_KeyBindingExtensions\_GetAction\_\_1\_osu\_Framework\_Input\_Bindings\_IKeyBinding\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IKeyBinding\>\(IKeyBinding\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IKeyBinding\>\(IKeyBinding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IKeyBinding\>\(IKeyBinding\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IKeyBinding, TChild\>\(IKeyBinding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IKeyBinding, TChild\>\(IKeyBinding, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IKeyBinding, TChild\>\(IKeyBinding, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IKeyBinding\>\(IKeyBinding\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Input_Bindings_IKeyBinding_Action"></a> Action

The resultant action which is triggered by this binding.
Generally an enum type, but may also be an int representing an enum (converted via <xref href="osu.Framework.Input.Bindings.KeyBindingExtensions.GetAction%60%601(osu.Framework.Input.Bindings.IKeyBinding)" data-throw-if-not-resolved="false"></xref>

```csharp
object Action { get; set; }
```

#### Property Value

 [object](https://learn.microsoft.com/dotnet/api/system.object)

### <a id="osu_Framework_Input_Bindings_IKeyBinding_KeyCombination"></a> KeyCombination

The combination of keys which will trigger this binding.

```csharp
KeyCombination KeyCombination { get; set; }
```

#### Property Value

 [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

