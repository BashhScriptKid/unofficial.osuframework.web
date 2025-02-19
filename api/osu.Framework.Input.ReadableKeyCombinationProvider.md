# <a id="osu_Framework_Input_ReadableKeyCombinationProvider"></a> Class ReadableKeyCombinationProvider

Namespace: [osu.Framework.Input](osu.Framework.Input.md)  
Assembly: osu.Framework.dll  

```csharp
public class ReadableKeyCombinationProvider
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ReadableKeyCombinationProvider](osu.Framework.Input.ReadableKeyCombinationProvider.md)

#### Derived

[SDL3ReadableKeyCombinationProvider](osu.Framework.Platform.SDL3.SDL3ReadableKeyCombinationProvider.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ReadableKeyCombinationProvider\>\(ReadableKeyCombinationProvider?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ReadableKeyCombinationProvider\>\(ReadableKeyCombinationProvider\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ReadableKeyCombinationProvider\>\(ReadableKeyCombinationProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ReadableKeyCombinationProvider\>\(ReadableKeyCombinationProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ReadableKeyCombinationProvider, TChild\>\(ReadableKeyCombinationProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ReadableKeyCombinationProvider, TChild\>\(ReadableKeyCombinationProvider, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ReadableKeyCombinationProvider, TChild\>\(ReadableKeyCombinationProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ReadableKeyCombinationProvider\>\(ReadableKeyCombinationProvider\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Input_ReadableKeyCombinationProvider_GetReadableKey_osu_Framework_Input_Bindings_InputKey_"></a> GetReadableKey\(InputKey\)

```csharp
protected virtual string GetReadableKey(InputKey key)
```

#### Parameters

`key` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Input_ReadableKeyCombinationProvider_GetReadableString_osu_Framework_Input_Bindings_KeyCombination_"></a> GetReadableString\(KeyCombination\)

Returns a human-readable string for a given <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref>.

```csharp
public string GetReadableString(KeyCombination c)
```

#### Parameters

`c` [KeyCombination](osu.Framework.Input.Bindings.KeyCombination.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> as a human-readable string.

#### Remarks

Consumers should subscribe to <xref href="osu.Framework.Input.ReadableKeyCombinationProvider.KeymapChanged" data-throw-if-not-resolved="false"></xref> and re-generate the readable <xref href="osu.Framework.Input.Bindings.KeyCombination" data-throw-if-not-resolved="false"></xref> when the keyboard layout changes.

### <a id="osu_Framework_Input_ReadableKeyCombinationProvider_KeymapChanged"></a> KeymapChanged

Invoked when the system keyboard layout has changed.

```csharp
public event Action KeymapChanged
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

