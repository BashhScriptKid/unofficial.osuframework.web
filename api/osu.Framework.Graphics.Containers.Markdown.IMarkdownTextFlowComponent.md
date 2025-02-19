# <a id="osu_Framework_Graphics_Containers_Markdown_IMarkdownTextFlowComponent"></a> Interface IMarkdownTextFlowComponent

Namespace: [osu.Framework.Graphics.Containers.Markdown](osu.Framework.Graphics.Containers.Markdown.md)  
Assembly: osu.Framework.dll  

```csharp
[Cached(Type = typeof(IMarkdownTextFlowComponent))]
public interface IMarkdownTextFlowComponent
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IMarkdownTextFlowComponent\>\(IMarkdownTextFlowComponent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IMarkdownTextFlowComponent\>\(IMarkdownTextFlowComponent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IMarkdownTextFlowComponent\>\(IMarkdownTextFlowComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IMarkdownTextFlowComponent\>\(IMarkdownTextFlowComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IMarkdownTextFlowComponent, TChild\>\(IMarkdownTextFlowComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IMarkdownTextFlowComponent, TChild\>\(IMarkdownTextFlowComponent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IMarkdownTextFlowComponent, TChild\>\(IMarkdownTextFlowComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IMarkdownTextFlowComponent\>\(IMarkdownTextFlowComponent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Containers_Markdown_IMarkdownTextFlowComponent_CreateTextFlow"></a> CreateTextFlow\(\)

Creates a <xref href="osu.Framework.Graphics.Containers.Markdown.MarkdownTextFlowContainer" data-throw-if-not-resolved="false"></xref> to display text within this <xref href="osu.Framework.Graphics.Containers.Markdown.IMarkdownTextFlowComponent" data-throw-if-not-resolved="false"></xref>.

```csharp
MarkdownTextFlowContainer CreateTextFlow()
```

#### Returns

 [MarkdownTextFlowContainer](osu.Framework.Graphics.Containers.Markdown.MarkdownTextFlowContainer.md)

The <xref href="osu.Framework.Graphics.Containers.Markdown.MarkdownTextFlowContainer" data-throw-if-not-resolved="false"></xref>.

#### Remarks

The <xref href="osu.Framework.Graphics.Containers.Markdown.MarkdownTextFlowContainer" data-throw-if-not-resolved="false"></xref> defined by the <xref href="osu.Framework.Graphics.Containers.Markdown.IMarkdownTextFlowComponent" data-throw-if-not-resolved="false"></xref> resolved from dependencies is used by default,
but may be overridden via this method to provide additional styling local to this <xref href="osu.Framework.Graphics.Containers.Markdown.IMarkdownTextFlowComponent" data-throw-if-not-resolved="false"></xref>.

