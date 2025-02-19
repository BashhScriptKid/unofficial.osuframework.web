# <a id="osu_Framework_Platform_GraphicsSurfaceType"></a> Enum GraphicsSurfaceType

Namespace: [osu.Framework.Platform](osu.Framework.Platform.md)  
Assembly: osu.Framework.dll  

The graphics surface of an <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>.

```csharp
public enum GraphicsSurfaceType
```

#### Extension Methods

[ObjectExtensions.AsNonNull<GraphicsSurfaceType\>\(GraphicsSurfaceType\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GraphicsSurfaceType\>\(GraphicsSurfaceType\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<GraphicsSurfaceType\>\(GraphicsSurfaceType, GraphicsSurfaceType\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GraphicsSurfaceType\>\(GraphicsSurfaceType\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GraphicsSurfaceType\>\(GraphicsSurfaceType\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[SDL3Extensions.ToFlags\(GraphicsSurfaceType\)](osu.Framework.Platform.SDL3.SDL3Extensions.md\#osu\_Framework\_Platform\_SDL3\_SDL3Extensions\_ToFlags\_osu\_Framework\_Platform\_GraphicsSurfaceType\_), 
[SDL2Extensions.ToFlags\(GraphicsSurfaceType\)](osu.Framework.Platform.SDL2.SDL2Extensions.md\#osu\_Framework\_Platform\_SDL2\_SDL2Extensions\_ToFlags\_osu\_Framework\_Platform\_GraphicsSurfaceType\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<GraphicsSurfaceType, TChild\>\(GraphicsSurfaceType, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GraphicsSurfaceType, TChild\>\(GraphicsSurfaceType, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GraphicsSurfaceType, TChild\>\(GraphicsSurfaceType, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GraphicsSurfaceType\>\(GraphicsSurfaceType\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Direct3D11 = 3` 

A Direct3D11 graphics surface.



`Metal = 1` 

A Metal graphics surface. The window must implement <xref href="osu.Framework.Platform.IMetalGraphicsSurface" data-throw-if-not-resolved="false"></xref>.



`OpenGL = 0` 

An OpenGL graphics surface. The window must implement <xref href="osu.Framework.Platform.IOpenGLGraphicsSurface" data-throw-if-not-resolved="false"></xref>.



`Vulkan = 2` 

A Vulkan graphics surface.



