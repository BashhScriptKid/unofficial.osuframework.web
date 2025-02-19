# <a id="osu_Framework_Graphics_Effects_IEffect_1"></a> Interface IEffect<T\>

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

Represents an effect that can be applied to a drawable.

```csharp
public interface IEffect<out T> where T : Drawable
```

#### Type Parameters

`T` 

The type of the drawable that is created as a result of applying the effect to a drawable.

#### Extension Methods

[EffectExtensions.ApplyTo<T\>\(IEffect<T\>, Drawable, Action<T\>\)](osu.Framework.Graphics.Effects.EffectExtensions.md\#osu\_Framework\_Graphics\_Effects\_EffectExtensions\_ApplyTo\_\_1\_osu\_Framework\_Graphics\_Effects\_IEffect\_\_\_0\_\_osu\_Framework\_Graphics\_Drawable\_System\_Action\_\_\_0\_\_), 
[ObjectExtensions.AsNonNull<IEffect<T\>\>\(IEffect<T\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IEffect<T\>\>\(IEffect<T\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IEffect<T\>\>\(IEffect<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IEffect<T\>\>\(IEffect<T\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IEffect<T\>, TChild\>\(IEffect<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IEffect<T\>, TChild\>\(IEffect<T\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IEffect<T\>, TChild\>\(IEffect<T\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IEffect<T\>\>\(IEffect<T\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Effects_IEffect_1_ApplyTo_osu_Framework_Graphics_Drawable_"></a> ApplyTo\(Drawable\)

Applies this effect to the given drawable.

```csharp
T ApplyTo(Drawable drawable)
```

#### Parameters

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to apply this effect to.

#### Returns

 T

A new drawable derived from the given drawable with the effect applied.

