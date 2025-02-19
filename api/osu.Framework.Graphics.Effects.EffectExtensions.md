# <a id="osu_Framework_Graphics_Effects_EffectExtensions"></a> Class EffectExtensions

Namespace: [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)  
Assembly: osu.Framework.dll  

This class holds extension methods for effects.

```csharp
public static class EffectExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EffectExtensions](osu.Framework.Graphics.Effects.EffectExtensions.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_)

## Methods

### <a id="osu_Framework_Graphics_Effects_EffectExtensions_ApplyTo__1_osu_Framework_Graphics_Effects_IEffect___0__osu_Framework_Graphics_Drawable_System_Action___0__"></a> ApplyTo<T\>\(IEffect<T\>, Drawable, Action<T\>\)

Applies the given effect to the given drawable and optionally initializes the created drawable with the given initializationAction.

```csharp
public static T ApplyTo<T>(this IEffect<T> effect, Drawable drawable, Action<T> initializationAction = null) where T : Drawable
```

#### Parameters

`effect` [IEffect](osu.Framework.Graphics.Effects.IEffect\-1.md)<T\>

The effect to apply to the drawable.

`drawable` [Drawable](osu.Framework.Graphics.Drawable.md)

The drawable to apply the effect to.

`initializationAction` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<T\>

The action that should get called to initialize the created drawable before it is returned.

#### Returns

 T

The drawable created by applying the given effect to this drawable.

#### Type Parameters

`T` 

The type of the drawable that results from applying the given effect.

