# <a id="osu_Framework_Graphics_Effects_EdgeEffect"></a> Class EdgeEffect

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

An effect applied around the edge of the target drawable.

```csharp
public class EdgeEffect : IEffect<Container>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EdgeEffect](osu.Framework.Graphics.Effects.EdgeEffect.md)

#### Implements

[IEffect<Container\>](osu.Framework.Graphics.Effects.IEffect\-1.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[EffectExtensions.ApplyTo<Container\>\(IEffect<Container\>, Drawable, Action<Container\>\)](osu.Framework.Graphics.Effects.EffectExtensions.md\#osu\_Framework\_Graphics\_Effects\_EffectExtensions\_ApplyTo\_\_1\_osu\_Framework\_Graphics\_Effects\_IEffect\_\_\_0\_\_osu\_Framework\_Graphics\_Drawable\_System\_Action\_\_\_0\_\_), 
[ObjectExtensions.AsNonNull<EdgeEffect\>\(EdgeEffect?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<EdgeEffect\>\(EdgeEffect\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<EdgeEffect\>\(EdgeEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<EdgeEffect\>\(EdgeEffect\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<EdgeEffect, TChild\>\(EdgeEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<EdgeEffect, TChild\>\(EdgeEffect, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<EdgeEffect, TChild\>\(EdgeEffect, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<EdgeEffect\>\(EdgeEffect\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

### <a id="osu_Framework_Graphics_Effects_EdgeEffect_CornerRadius"></a> CornerRadius

Determines how large a radius is masked away around the corners. Default is 0.

```csharp
public float CornerRadius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="osu_Framework_Graphics_Effects_EdgeEffect_Parameters"></a> Parameters

The parameters of the edge effect.

```csharp
public EdgeEffectParameters Parameters
```

#### Field Value

 [EdgeEffectParameters](osu.Framework.Graphics.Effects.EdgeEffectParameters.md)

## Methods

### <a id="osu_Framework_Graphics_Effects_EdgeEffect_ApplyTo_osu_Framework_Graphics_Drawable_"></a> ApplyTo\(Drawable\)

Applies this effect to the given drawable.

```csharp
public Container ApplyTo(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to apply this effect to.

#### Returns

 [Container](osu.Framework.Graphics.Containers.Container.md)

A new drawable derived from the given drawable with the effect applied.

