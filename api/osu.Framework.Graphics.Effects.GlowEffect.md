# <a id="osu_Framework_Graphics_Effects_GlowEffect"></a> Class GlowEffect

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

Creates a glow around the drawable this effect gets applied to.

```csharp
public class GlowEffect : IEffect<BufferedContainer>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GlowEffect](osu.Framework.Graphics.Effects.GlowEffect.md)

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
[ObjectExtensions.AsNonNull<GlowEffect\>\(GlowEffect?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<GlowEffect\>\(GlowEffect\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<GlowEffect\>\(GlowEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<GlowEffect\>\(GlowEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<GlowEffect, TChild\>\(GlowEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<GlowEffect, TChild\>\(GlowEffect, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<GlowEffect, TChild\>\(GlowEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<GlowEffect\>\(GlowEffect\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Effects_GlowEffect_Blending"></a> Blending

The blending mode of the glow. Default is additive.

```csharp
public BlendingParameters Blending
```

#### Field Value

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

### <a id="osu_Framework_Graphics_Effects_GlowEffect_BlurSigma"></a> BlurSigma

The sigma value for the blur of the glow. This controls how spread out the glow is. Default is 5 in both X and Y.

```csharp
public Vector2 BlurSigma
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Effects_GlowEffect_Colour"></a> Colour

The color of the outline. Default is <xref href="osuTK.Graphics.Color4.White" data-throw-if-not-resolved="false"></xref>.

```csharp
public ColourInfo Colour
```

#### Field Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Effects_GlowEffect_PadExtent"></a> PadExtent

Whether to automatically pad by the glow extent such that no clipping occurs at the sides of the effect. Default is false.

```csharp
public bool PadExtent
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Effects_GlowEffect_Placement"></a> Placement

Whether to draw the glow <xref href="osu.Framework.Graphics.Containers.EffectPlacement.InFront" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Containers.EffectPlacement.Behind" data-throw-if-not-resolved="false"></xref> the glowing
<xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>. Default is <xref href="osu.Framework.Graphics.Containers.EffectPlacement.InFront" data-throw-if-not-resolved="false"></xref>.

```csharp
public EffectPlacement Placement
```

#### Field Value

 [EffectPlacement](osu.Framework.Graphics.Containers.EffectPlacement.md)

### <a id="osu_Framework_Graphics_Effects_GlowEffect_Strength"></a> Strength

The strength of the glow. A higher strength means that the glow fades outward slower. Default is 1.

```csharp
public float Strength
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Effects_GlowEffect_ApplyTo_osu_Framework_Graphics_Drawable_"></a> ApplyTo\(Drawable\)

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

