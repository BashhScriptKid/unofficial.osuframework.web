# <a id="osu_Framework_Layout_InvalidationConditionDelegate"></a> Delegate InvalidationConditionDelegate

Namespace: [osu.Framework.Layout](osu.Framework.Layout.md)  
Assembly: osu.Framework.dll  

The delegate that provides extra conditions for an invalidation to occur.

```csharp
public delegate bool InvalidationConditionDelegate(Drawable source, Invalidation invalidation)
```

#### Parameters

`source` [Drawable](osu.Framework.Graphics.Drawable.md)

The <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to be invalidated.

`invalidation` [Invalidation](osu.Framework.Graphics.Invalidation.md)

The <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Extension Methods

[ObjectExtensions.AsNonNull<InvalidationConditionDelegate\>\(InvalidationConditionDelegate?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<InvalidationConditionDelegate\>\(InvalidationConditionDelegate\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<InvalidationConditionDelegate\>\(InvalidationConditionDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<InvalidationConditionDelegate\>\(InvalidationConditionDelegate\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<InvalidationConditionDelegate, TChild\>\(InvalidationConditionDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<InvalidationConditionDelegate, TChild\>\(InvalidationConditionDelegate, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<InvalidationConditionDelegate, TChild\>\(InvalidationConditionDelegate, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<InvalidationConditionDelegate\>\(InvalidationConditionDelegate\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

