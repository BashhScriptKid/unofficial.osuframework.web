# <a id="osu_Framework_Platform_IMetalGraphicsSurface"></a> Interface IMetalGraphicsSurface

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Represents Metal-specific graphics API provided by an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IMetalGraphicsSurface
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IMetalGraphicsSurface\>\(IMetalGraphicsSurface?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IMetalGraphicsSurface\>\(IMetalGraphicsSurface\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IMetalGraphicsSurface\>\(IMetalGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IMetalGraphicsSurface\>\(IMetalGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IMetalGraphicsSurface, TChild\>\(IMetalGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IMetalGraphicsSurface, TChild\>\(IMetalGraphicsSurface, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IMetalGraphicsSurface, TChild\>\(IMetalGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IMetalGraphicsSurface\>\(IMetalGraphicsSurface\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Platform_IMetalGraphicsSurface_CreateMetalView"></a> CreateMetalView\(\)

Creates an NSView backed with a Metal layer.

```csharp
nint CreateMetalView()
```

#### Returns

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

