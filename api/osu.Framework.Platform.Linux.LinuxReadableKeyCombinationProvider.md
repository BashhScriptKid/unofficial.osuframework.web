# <a id="osu_Framework_Platform_Linux_LinuxReadableKeyCombinationProvider"></a> Class LinuxReadableKeyCombinationProvider

Namespace: [osu.Framework.Platform.Linux](osu.Framework.Platform.Linux.md)  
Assembly: osu.Framework.dll  

```csharp
public class LinuxReadableKeyCombinationProvider : SDL3ReadableKeyCombinationProvider
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ReadableKeyCombinationProvider](osu.Framework.Input.ReadableKeyCombinationProvider.md) ← 
[SDL3ReadableKeyCombinationProvider](osu.Framework.Platform.SDL3.SDL3ReadableKeyCombinationProvider.md) ← 
[LinuxReadableKeyCombinationProvider](osu.Framework.Platform.Linux.LinuxReadableKeyCombinationProvider.md)

#### Inherited Members

[SDL3ReadableKeyCombinationProvider.GetReadableKey\(InputKey\)](osu.Framework.Platform.SDL3.SDL3ReadableKeyCombinationProvider.md\#osu\_Framework\_Platform\_SDL3\_SDL3ReadableKeyCombinationProvider\_GetReadableKey\_osu\_Framework\_Input\_Bindings\_InputKey\_), 
[SDL3ReadableKeyCombinationProvider.TryGetNameFromKeycode\(SDL\_Keycode, out string\)](osu.Framework.Platform.SDL3.SDL3ReadableKeyCombinationProvider.md\#osu\_Framework\_Platform\_SDL3\_SDL3ReadableKeyCombinationProvider\_TryGetNameFromKeycode\_SDL\_SDL\_Keycode\_System\_String\_\_), 
[ReadableKeyCombinationProvider.KeymapChanged](osu.Framework.Input.ReadableKeyCombinationProvider.md\#osu\_Framework\_Input\_ReadableKeyCombinationProvider\_KeymapChanged), 
[ReadableKeyCombinationProvider.GetReadableString\(KeyCombination\)](osu.Framework.Input.ReadableKeyCombinationProvider.md\#osu\_Framework\_Input\_ReadableKeyCombinationProvider\_GetReadableString\_osu\_Framework\_Input\_Bindings\_KeyCombination\_), 
[ReadableKeyCombinationProvider.GetReadableKey\(InputKey\)](osu.Framework.Input.ReadableKeyCombinationProvider.md\#osu\_Framework\_Input\_ReadableKeyCombinationProvider\_GetReadableKey\_osu\_Framework\_Input\_Bindings\_InputKey\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<LinuxReadableKeyCombinationProvider\>\(LinuxReadableKeyCombinationProvider?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<LinuxReadableKeyCombinationProvider\>\(LinuxReadableKeyCombinationProvider\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<LinuxReadableKeyCombinationProvider\>\(LinuxReadableKeyCombinationProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<LinuxReadableKeyCombinationProvider\>\(LinuxReadableKeyCombinationProvider\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<LinuxReadableKeyCombinationProvider, TChild\>\(LinuxReadableKeyCombinationProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<LinuxReadableKeyCombinationProvider, TChild\>\(LinuxReadableKeyCombinationProvider, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<LinuxReadableKeyCombinationProvider, TChild\>\(LinuxReadableKeyCombinationProvider, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<LinuxReadableKeyCombinationProvider\>\(LinuxReadableKeyCombinationProvider\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Platform_Linux_LinuxReadableKeyCombinationProvider_GetReadableKey_osu_Framework_Input_Bindings_InputKey_"></a> GetReadableKey\(InputKey\)

```csharp
protected override string GetReadableKey(InputKey key)
```

#### Parameters

`key` [InputKey](osu.Framework.Input.Bindings.InputKey.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="osu_Framework_Platform_Linux_LinuxReadableKeyCombinationProvider_TryGetNameFromKeycode_SDL_SDL_Keycode_System_String__"></a> TryGetNameFromKeycode\(SDL\_Keycode, out string\)

Provides overrides for some keys that we want displayed differently from SDL_GetKeyName().

```csharp
protected override bool TryGetNameFromKeycode(SDL_Keycode keycode, out string name)
```

#### Parameters

`keycode` SDL\_Keycode

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

Should be overriden per-platform to provide platform-specific names for applicable keys.

