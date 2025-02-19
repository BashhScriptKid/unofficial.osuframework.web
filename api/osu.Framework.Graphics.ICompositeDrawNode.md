# <a id="osu_Framework_Graphics_ICompositeDrawNode"></a> Interface ICompositeDrawNode

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Interface for <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s which compose child <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s.
<xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s implementing this interface can be used in <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>s.

```csharp
public interface ICompositeDrawNode
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ICompositeDrawNode\>\(ICompositeDrawNode?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ICompositeDrawNode\>\(ICompositeDrawNode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ICompositeDrawNode\>\(ICompositeDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ICompositeDrawNode\>\(ICompositeDrawNode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ICompositeDrawNode, TChild\>\(ICompositeDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ICompositeDrawNode, TChild\>\(ICompositeDrawNode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ICompositeDrawNode, TChild\>\(ICompositeDrawNode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ICompositeDrawNode\>\(ICompositeDrawNode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_ICompositeDrawNode_AddChildDrawNodes"></a> AddChildDrawNodes

Whether <xref href="osu.Framework.Graphics.ICompositeDrawNode.Children" data-throw-if-not-resolved="false"></xref> should be updated by the parenting <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>.

```csharp
bool AddChildDrawNodes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="osu_Framework_Graphics_ICompositeDrawNode_Children"></a> Children

The child <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s to draw.

```csharp
List<DrawNode>? Children { get; set; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[DrawNode](osu.Framework.Graphics.DrawNode.md)\>?

