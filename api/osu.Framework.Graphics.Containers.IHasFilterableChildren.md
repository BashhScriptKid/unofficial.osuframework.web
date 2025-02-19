# <a id="osu_Framework_Graphics_Containers_IHasFilterableChildren"></a> Interface IHasFilterableChildren

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

```csharp
[Obsolete("IFilterable children are now looked up automatically. Implementors of this interface should implement IFilterable directly instead.")]
public interface IHasFilterableChildren : IFilterable, IHasFilterTerms
```

#### Implements

[IFilterable](osu.Framework.Graphics.Containers.IFilterable.md), 
[IHasFilterTerms](osu.Framework.Graphics.Containers.IHasFilterTerms.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IHasFilterableChildren\>\(IHasFilterableChildren?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IHasFilterableChildren\>\(IHasFilterableChildren\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IHasFilterableChildren\>\(IHasFilterableChildren\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IHasFilterableChildren\>\(IHasFilterableChildren\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IHasFilterableChildren, TChild\>\(IHasFilterableChildren, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IHasFilterableChildren, TChild\>\(IHasFilterableChildren, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IHasFilterableChildren, TChild\>\(IHasFilterableChildren, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IHasFilterableChildren\>\(IHasFilterableChildren\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Containers_IHasFilterableChildren_FilterableChildren"></a> FilterableChildren

List of children that can be filtered

```csharp
IEnumerable<IFilterable> FilterableChildren { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[IFilterable](osu.Framework.Graphics.Containers.IFilterable.md)\>

