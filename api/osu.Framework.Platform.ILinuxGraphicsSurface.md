# <a id="osu_Framework_Platform_ILinuxGraphicsSurface"></a> Interface ILinuxGraphicsSurface

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

```csharp
public interface ILinuxGraphicsSurface
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ILinuxGraphicsSurface\>\(ILinuxGraphicsSurface?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ILinuxGraphicsSurface\>\(ILinuxGraphicsSurface\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ILinuxGraphicsSurface\>\(ILinuxGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ILinuxGraphicsSurface\>\(ILinuxGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ILinuxGraphicsSurface, TChild\>\(ILinuxGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ILinuxGraphicsSurface, TChild\>\(ILinuxGraphicsSurface, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ILinuxGraphicsSurface, TChild\>\(ILinuxGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ILinuxGraphicsSurface\>\(ILinuxGraphicsSurface\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Platform_ILinuxGraphicsSurface_DisplayHandle"></a> DisplayHandle

A pointer representing a handle to the display containing this window, provided by the operating system.
This is specific to X11/Wayland subsystems.

```csharp
nint DisplayHandle { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="osu_Framework_Platform_ILinuxGraphicsSurface_IsWayland"></a> IsWayland

Whether the current display server is Wayland.

```csharp
bool IsWayland { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

