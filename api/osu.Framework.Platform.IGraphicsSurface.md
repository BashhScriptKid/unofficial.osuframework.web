# <a id="osu_Framework_Platform_IGraphicsSurface"></a> Interface IGraphicsSurface

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

Represents the graphics API surface provided by an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IGraphicsSurface
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IGraphicsSurface\>\(IGraphicsSurface?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IGraphicsSurface\>\(IGraphicsSurface\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IGraphicsSurface\>\(IGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IGraphicsSurface\>\(IGraphicsSurface\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IGraphicsSurface, TChild\>\(IGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IGraphicsSurface, TChild\>\(IGraphicsSurface, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IGraphicsSurface, TChild\>\(IGraphicsSurface, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IGraphicsSurface\>\(IGraphicsSurface\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Platform_IGraphicsSurface_Type"></a> Type

The type of surface.

```csharp
GraphicsSurfaceType Type { get; }
```

#### Property Value

 [GraphicsSurfaceType](osu.Framework.Platform.GraphicsSurfaceType.md)

### <a id="osu_Framework_Platform_IGraphicsSurface_WindowHandle"></a> WindowHandle

A pointer representing a handle to this window, provided by the operating system.

```csharp
nint WindowHandle { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

## Methods

### <a id="osu_Framework_Platform_IGraphicsSurface_GetDrawableSize"></a> GetDrawableSize\(\)

Returns the drawable size of the window provided by the graphics backend.

```csharp
Size GetDrawableSize()
```

#### Returns

 [Size](https://learn.microsoft.com/dotnet/api/system.drawing.size)

### <a id="osu_Framework_Platform_IGraphicsSurface_Initialise"></a> Initialise\(\)

Performs an initialisation of the graphics backend after <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref> has been created.

```csharp
void Initialise()
```

