# <a id="osu_Framework_Graphics_Pooling_IDrawablePool"></a> Interface IDrawablePool

Namespace: [osu.Framework.Graphics.Pooling](osu.Framework.Graphics.Pooling.md)  
Assembly: osu.Framework.dll  

```csharp
public interface IDrawablePool
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IDrawablePool\>\(IDrawablePool?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IDrawablePool\>\(IDrawablePool\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IDrawablePool\>\(IDrawablePool\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IDrawablePool\>\(IDrawablePool\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IDrawablePool, TChild\>\(IDrawablePool, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IDrawablePool, TChild\>\(IDrawablePool, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IDrawablePool, TChild\>\(IDrawablePool, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IDrawablePool\>\(IDrawablePool\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Pooling_IDrawablePool_Get_System_Action_osu_Framework_Graphics_Pooling_PoolableDrawable__"></a> Get\(Action<PoolableDrawable\>\)

Get a drawable from this pool.

```csharp
PoolableDrawable Get(Action<PoolableDrawable> setupAction = null)
```

#### Parameters

`setupAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[PoolableDrawable](osu.Framework.Graphics.Pooling.PoolableDrawable.md)\>

An optional action to be performed on this drawable immediately after retrieval. Should generally be used to prepare the drawable into a usable state.

#### Returns

 [PoolableDrawable](osu.Framework.Graphics.Pooling.PoolableDrawable.md)

The drawable.

### <a id="osu_Framework_Graphics_Pooling_IDrawablePool_Return_osu_Framework_Graphics_Pooling_PoolableDrawable_"></a> Return\(PoolableDrawable\)

Return a drawable after use.

```csharp
void Return(PoolableDrawable pooledDrawable)
```

#### Parameters

`pooledDrawable` [PoolableDrawable](osu.Framework.Graphics.Pooling.PoolableDrawable.md)

The drwable to return. Should have originally come from this pool.

