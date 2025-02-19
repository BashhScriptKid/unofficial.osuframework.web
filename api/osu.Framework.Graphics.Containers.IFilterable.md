# <a id="osu_Framework_Graphics_Containers_IFilterable"></a> Interface IFilterable

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Implementing this interface in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> allows it to be filtered basing on provided search terms
when placed inside a <xref href="osu.Framework.Graphics.Containers.SearchContainer%601" data-throw-if-not-resolved="false"></xref>.

```csharp
public interface IFilterable : IHasFilterTerms
```

#### Implements

[IHasFilterTerms](osu.Framework.Graphics.Containers.IHasFilterTerms.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IFilterable\>\(IFilterable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IFilterable\>\(IFilterable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IFilterable\>\(IFilterable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IFilterable\>\(IFilterable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IFilterable, TChild\>\(IFilterable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IFilterable, TChild\>\(IFilterable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IFilterable, TChild\>\(IFilterable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IFilterable\>\(IFilterable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Containers_IFilterable_FilteringActive"></a> FilteringActive

Whether a filter is currently being performed.

```csharp
bool FilteringActive { set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_Containers_IFilterable_MatchingFilter"></a> MatchingFilter

Whether the current object is matching (ie. visible) given the current filter criteria of a parent.

```csharp
bool MatchingFilter { set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

