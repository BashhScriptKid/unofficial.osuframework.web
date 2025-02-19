# <a id="osu_Framework_Graphics_Containers_IConditionalFilterable"></a> Interface IConditionalFilterable

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Am <xref href="osu.Framework.Graphics.Containers.IFilterable" data-throw-if-not-resolved="false"></xref> that additionally allows specifying whether the item can be shown
based on additional criteria.
The item will be visible in a <xref href="osu.Framework.Graphics.Containers.SearchContainer" data-throw-if-not-resolved="false"></xref>
if and only if <xref href="osu.Framework.Graphics.Containers.IHasFilterTerms.FilterTerms" data-throw-if-not-resolved="false"></xref> match
and <xref href="osu.Framework.Graphics.Containers.IConditionalFilterable.CanBeShown" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

```csharp
public interface IConditionalFilterable : IFilterable, IHasFilterTerms
```

#### Implements

[IFilterable](osu.Framework.Graphics.Containers.IFilterable.md), 
[IHasFilterTerms](osu.Framework.Graphics.Containers.IHasFilterTerms.md)

#### Extension Methods

[ObjectExtensions.AsNonNull<IConditionalFilterable\>\(IConditionalFilterable?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IConditionalFilterable\>\(IConditionalFilterable\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IConditionalFilterable\>\(IConditionalFilterable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IConditionalFilterable\>\(IConditionalFilterable\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IConditionalFilterable, TChild\>\(IConditionalFilterable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IConditionalFilterable, TChild\>\(IConditionalFilterable, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IConditionalFilterable, TChild\>\(IConditionalFilterable, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IConditionalFilterable\>\(IConditionalFilterable\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Containers_IConditionalFilterable_CanBeShown"></a> CanBeShown

```csharp
IBindable<bool> CanBeShown { get; }
```

#### Property Value

 [IBindable](osu.Framework.Bindables.IBindable\-1.md)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

