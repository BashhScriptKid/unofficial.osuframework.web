# <a id="osu_Framework_Graphics_DrawColourInfo"></a> Struct DrawColourInfo

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

```csharp
public struct DrawColourInfo : IEquatable<DrawColourInfo>
```

#### Implements

[IEquatable<DrawColourInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<DrawColourInfo\>\(DrawColourInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DrawColourInfo\>\(DrawColourInfo\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DrawColourInfo\>\(DrawColourInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DrawColourInfo\>\(DrawColourInfo\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<DrawColourInfo, TChild\>\(DrawColourInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DrawColourInfo, TChild\>\(DrawColourInfo, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DrawColourInfo, TChild\>\(DrawColourInfo, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DrawColourInfo\>\(DrawColourInfo\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_DrawColourInfo__ctor_System_Nullable_osu_Framework_Graphics_Colour_ColourInfo__System_Nullable_osu_Framework_Graphics_BlendingParameters__"></a> DrawColourInfo\(ColourInfo?, BlendingParameters?\)

```csharp
public DrawColourInfo(ColourInfo? colour = null, BlendingParameters? blending = null)
```

#### Parameters

`colour` [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)?

`blending` [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)?

## Fields

### <a id="osu_Framework_Graphics_DrawColourInfo_Blending"></a> Blending

```csharp
public BlendingParameters Blending
```

#### Field Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_DrawColourInfo_Colour"></a> Colour

```csharp
public ColourInfo Colour
```

#### Field Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

## Methods

### <a id="osu_Framework_Graphics_DrawColourInfo_Equals_osu_Framework_Graphics_DrawColourInfo_"></a> Equals\(DrawColourInfo\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(DrawColourInfo other)
```

#### Parameters

`other` [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

