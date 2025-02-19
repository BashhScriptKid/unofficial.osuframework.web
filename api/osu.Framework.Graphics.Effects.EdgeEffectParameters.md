# <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters"></a> Struct EdgeEffectParameters

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

Parametrizes the appearance of an edge effect.

```csharp
public struct EdgeEffectParameters : IEquatable<EdgeEffectParameters>
```

#### Implements

[IEquatable<EdgeEffectParameters\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<EdgeEffectParameters\>\(EdgeEffectParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<EdgeEffectParameters\>\(EdgeEffectParameters\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<EdgeEffectParameters\>\(EdgeEffectParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<EdgeEffectParameters\>\(EdgeEffectParameters\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<EdgeEffectParameters, TChild\>\(EdgeEffectParameters, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<EdgeEffectParameters, TChild\>\(EdgeEffectParameters, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<EdgeEffectParameters, TChild\>\(EdgeEffectParameters, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<EdgeEffectParameters\>\(EdgeEffectParameters\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Colour"></a> Colour

Colour of the edge effect.

```csharp
public SRGBColour Colour
```

#### Field Value

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Hollow"></a> Hollow

Whether the inside of the EdgeEffect rectangle should be empty.

```csharp
public bool Hollow
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Offset"></a> Offset

Positional offset applied to the edge effect.
Useful for off-center shadows.

```csharp
public Vector2 Offset
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Radius"></a> Radius

How "thick" the edge effect is around the <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>. In other words: At what distance
from the <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>'s border the edge effect becomes fully invisible.

```csharp
public float Radius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Roundness"></a> Roundness

How round the edge effect should appear. Adds to the <xref href="osu.Framework.Graphics.Containers.CompositeDrawable.CornerRadius" data-throw-if-not-resolved="false"></xref>
of the corresponding <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>. Not to confuse with the <xref href="osu.Framework.Graphics.Effects.EdgeEffectParameters.Radius" data-throw-if-not-resolved="false"></xref>.

```csharp
public float Roundness
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Type"></a> Type

The type of the edge effect.

```csharp
public EdgeEffectType Type
```

#### Field Value

 [EdgeEffectType](osu.Framework.Graphics.Effects.EdgeEffectType.md)

## Methods

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_Equals_osu_Framework_Graphics_Effects_EdgeEffectParameters_"></a> Equals\(EdgeEffectParameters\)

Indicates whether the current object is equal to another object of the same type.

```csharp
public readonly bool Equals(EdgeEffectParameters other)
```

#### Parameters

`other` [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

An object to compare with this object.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the current object is equal to the <code class="paramref">other</code> parameter; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="osu_Framework_Graphics_Effects_EdgeEffectParameters_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override readonly string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

