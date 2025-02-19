# <a id="osu_Framework_Graphics_Rendering_ClearInfo"></a> Struct ClearInfo

Namespace: [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)  
Assembly: osu.Framework.dll  

Information for how the current frame buffer should be cleared.

```csharp
public readonly struct ClearInfo
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<ClearInfo\>\(ClearInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ClearInfo\>\(ClearInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ClearInfo\>\(ClearInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ClearInfo\>\(ClearInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ClearInfo, TChild\>\(ClearInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ClearInfo, TChild\>\(ClearInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ClearInfo, TChild\>\(ClearInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ClearInfo\>\(ClearInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Rendering_ClearInfo__ctor_osuTK_Graphics_Color4_System_Double_System_Int32_"></a> ClearInfo\(Color4, double, int\)

```csharp
public ClearInfo(Color4 colour = default, double depth = 1, int stencil = 0)
```

#### Parameters

`colour` Color4

`depth` [double](https://learn.microsoft.com/dotnet/api/system.double)

`stencil` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Fields

### <a id="osu_Framework_Graphics_Rendering_ClearInfo_Colour"></a> Colour

The colour to write to the frame buffer.

```csharp
public readonly Color4 Colour
```

#### Field Value

 Color4

### <a id="osu_Framework_Graphics_Rendering_ClearInfo_Depth"></a> Depth

The depth to write to the frame buffer.

```csharp
public readonly double Depth
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="osu_Framework_Graphics_Rendering_ClearInfo_Stencil"></a> Stencil

The stencil value to write to the frame buffer.

```csharp
public readonly int Stencil
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="osu_Framework_Graphics_Rendering_ClearInfo_Default"></a> Default

The default clear properties, as defined by OpenGL.

```csharp
public static ClearInfo Default { get; }
```

#### Property Value

 [ClearInfo](osu.Framework.Graphics.Rendering.ClearInfo.md)

