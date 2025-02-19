# <a id="osu_Framework_Graphics_Effects_OutlineEffect"></a> Class OutlineEffect

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

Creates an outline around the drawable this effect gets applied to.

```csharp
public class OutlineEffect : IEffect<BufferedContainer>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OutlineEffect](osu.Framework.Graphics.Effects.OutlineEffect.md)

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
[ObjectExtensions.AsNonNull<OutlineEffect\>\(OutlineEffect?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<OutlineEffect\>\(OutlineEffect\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<OutlineEffect\>\(OutlineEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<OutlineEffect\>\(OutlineEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<OutlineEffect, TChild\>\(OutlineEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<OutlineEffect, TChild\>\(OutlineEffect, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<OutlineEffect, TChild\>\(OutlineEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<OutlineEffect\>\(OutlineEffect\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Effects_OutlineEffect_BlurSigma"></a> BlurSigma

The sigma value for the blur effect used to draw the outline. This controls over how many pixels the outline gets spread.
Default is <xref href="osuTK.Vector2.One" data-throw-if-not-resolved="false"></xref>.

```csharp
public Vector2 BlurSigma
```

#### Field Value

 Vector2

### <a id="osu_Framework_Graphics_Effects_OutlineEffect_Colour"></a> Colour

The color of the outline. Default is <xref href="osuTK.Graphics.Color4.Black" data-throw-if-not-resolved="false"></xref>.

```csharp
public ColourInfo Colour
```

#### Field Value

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

### <a id="osu_Framework_Graphics_Effects_OutlineEffect_PadExtent"></a> PadExtent

Whether to automatically pad by the blur extent such that no clipping occurs at the sides of the effect. Default is false.

```csharp
public bool PadExtent
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Effects_OutlineEffect_Strength"></a> Strength

The strength of the outline. A higher strength means that the blur effect used to draw the outline fades slower.
Default is 1.

```csharp
public float Strength
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="osu_Framework_Graphics_Effects_OutlineEffect_ApplyTo_osu_Framework_Graphics_Drawable_"></a> ApplyTo\(Drawable\)

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

