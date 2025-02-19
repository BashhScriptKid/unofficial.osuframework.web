# <a id="osu_Framework_Graphics_Effects_BlurEffect"></a> Class BlurEffect

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

A blur effect that wraps a drawable in a <xref href="osu.Framework.Graphics.Containers.BufferedContainer" data-throw-if-not-resolved="false"></xref> which applies a blur effect to it.

```csharp
public class BlurEffect : IEffect<BufferedContainer>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BlurEffect](osu.Framework.Graphics.Effects.BlurEffect.md)

#### Implements

[IEffect<BufferedContainer\>](osu.Framework.Graphics.Effects.IEffect\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EffectExtensions.ApplyTo<BufferedContainer\>\(IEffect<BufferedContainer\>, Drawable, Action<BufferedContainer\>\)](osu.Framework.Graphics.Effects.EffectExtensions.md\#osu\_Framework\_Graphics\_Effects\_EffectExtensions\_ApplyTo\_\_1\_osu\_Framework\_Graphics\_Effects\_IEffect\_\_\_0\_\_osu\_Framework\_Graphics\_Drawable\_System\_Action\_\_\_0\_\_), 
[ObjectExtensions.AsNonNull<BlurEffect\>\(BlurEffect?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<BlurEffect\>\(BlurEffect\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<BlurEffect\>\(BlurEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<BlurEffect\>\(BlurEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<BlurEffect, TChild\>\(BlurEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<BlurEffect, TChild\>\(BlurEffect, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<BlurEffect, TChild\>\(BlurEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<BlurEffect\>\(BlurEffect\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Effects_BlurEffect_Blending"></a> Blending

The blending mode of the blur. Default is inheriting from the target drawable.

```csharp
public BlendingParameters Blending
```

#### Field Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_Effects_BlurEffect_Colour"></a> Colour

The colour of the blur. Default is <xref href="osuTK.Graphics.Color4.White" data-throw-if-not-resolved="false"></xref>.

```csharp
public ColourInfo Colour
```

#### Field Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Effects_BlurEffect_DrawOriginal"></a> DrawOriginal

Whether to draw the original target in addition to its blurred version.

```csharp
public bool DrawOriginal
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Effects_BlurEffect_PadExtent"></a> PadExtent

Whether to automatically pad by the blur extent such that no clipping occurs at the sides of the effect. Default is false.

```csharp
public bool PadExtent
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Effects_BlurEffect_Placement"></a> Placement

Whether to draw the blur in front or behind the original. Default is behind.

```csharp
public EffectPlacement Placement
```

#### Field Value

 [EffectPlacement](osu.Framework.Graphics.Containers.EffectPlacement.md)

### <a id="osu_Framework_Graphics_Effects_BlurEffect_Rotation"></a> Rotation

The rotation of the blur. Default is 0.

```csharp
public float Rotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Effects_BlurEffect_Sigma"></a> Sigma

The sigma of the blur. Default is (2, 2).

```csharp
public Vector2 Sigma
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Effects_BlurEffect_Strength"></a> Strength

The strength of the blur. Default is 1.

```csharp
public float Strength
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Effects_BlurEffect_ApplyTo_osu_Framework_Graphics_Drawable_"></a> ApplyTo\(Drawable\)

Applies this effect to the given drawable.

```csharp
public BufferedContainer ApplyTo(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to apply this effect to.

#### Returns

 [BufferedContainer](osu.Framework.Graphics.Containers.BufferedContainer.md)

A new drawable derived from the given drawable with the effect applied.

