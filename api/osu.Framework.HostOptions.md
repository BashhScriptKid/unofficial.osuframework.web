# <a id="osu_Framework_HostOptions"></a> Class HostOptions

Namespace: [osu.Framework](osu.Framework.md)  
Assembly: osu.Framework.dll  

Various configuration properties for a <xref href="osu.Framework.Host" data-throw-if-not-resolved="false"></xref>.

```csharp
public class HostOptions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HostOptions](osu.Framework.HostOptions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<HostOptions\>\(HostOptions?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<HostOptions\>\(HostOptions\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<HostOptions\>\(HostOptions\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<HostOptions\>\(HostOptions\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<HostOptions, TChild\>\(HostOptions, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<HostOptions, TChild\>\(HostOptions, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<HostOptions, TChild\>\(HostOptions, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<HostOptions\>\(HostOptions\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_HostOptions_BypassCompositor"></a> BypassCompositor

Whether to bypass the compositor. Defaults to <code>true</code>.

```csharp
public bool BypassCompositor { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

On Linux, the compositor re-buffers the application to apply various window effects,
increasing latency in the process. Thus it is a good idea for games to bypass it,
though normal applications would generally benefit from letting the window effects untouched. <br />
If the SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR environment variable is set, this property will have no effect.

### <a id="osu_Framework_HostOptions_FriendlyGameName"></a> FriendlyGameName

The friendly name of the game to be hosted. This is used to display the name to the user,
for example in the window title bar or in OS windows and prompts.

```csharp
public string FriendlyGameName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Remarks

If empty, GameHost will choose a default name based on the gameName.

### <a id="osu_Framework_HostOptions_IPCPipeName"></a> IPCPipeName

The IPC pipe name to bind. This should be shared by all instances of
an osu!framework app that want to perform inter-process communications.
See <xref href="osu.Framework.Platform.IIpcHost" data-throw-if-not-resolved="false"></xref> for more details on usage.

```csharp
public string? IPCPipeName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="osu_Framework_HostOptions_IPCPort"></a> IPCPort

Use <xref href="osu.Framework.HostOptions.IPCPipeName" data-throw-if-not-resolved="false"></xref> instead.

```csharp
[Obsolete("Use IPCPipeName instead.")]
public int? IPCPort { set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="osu_Framework_HostOptions_PortableInstallation"></a> PortableInstallation

Whether this is a portable installation. Will cause all game files to be placed alongside the executable, rather than in the standard data directory.

```csharp
public bool PortableInstallation { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

