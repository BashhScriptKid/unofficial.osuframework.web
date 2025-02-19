# <a id="osu_Framework_Graphics_Containers_Markdown_IMarkdownTextComponent"></a> Interface IMarkdownTextComponent

Namespace: [osu.Framework.Graphics.Containers.Markdown](osu.Framework.Graphics.Containers.Markdown.md)  
Assembly: osu.Framework.dll  

```csharp
[Cached(typeof(IMarkdownTextComponent), null)]
public interface IMarkdownTextComponent
```

#### Extension Methods

[ObjectExtensions.AsNonNull<IMarkdownTextComponent\>\(IMarkdownTextComponent?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<IMarkdownTextComponent\>\(IMarkdownTextComponent\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<IMarkdownTextComponent\>\(IMarkdownTextComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<IMarkdownTextComponent\>\(IMarkdownTextComponent\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<IMarkdownTextComponent, TChild\>\(IMarkdownTextComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<IMarkdownTextComponent, TChild\>\(IMarkdownTextComponent, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<IMarkdownTextComponent, TChild\>\(IMarkdownTextComponent, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<IMarkdownTextComponent\>\(IMarkdownTextComponent\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Methods

### <a id="osu_Framework_Graphics_Containers_Markdown_IMarkdownTextComponent_CreateSpriteText"></a> CreateSpriteText\(\)

Creates a <xref href="osu.Framework.Graphics.Sprites.SpriteText" data-throw-if-not-resolved="false"></xref> to display text within this <xref href="osu.Framework.Graphics.Containers.Markdown.IMarkdownTextFlowComponent" data-throw-if-not-resolved="false"></xref>.

```csharp
SpriteText CreateSpriteText()
```

#### Returns

 [SpriteText](osu.Framework.Graphics.Sprites.SpriteText.md)

The <xref href="osu.Framework.Graphics.Sprites.SpriteText" data-throw-if-not-resolved="false"></xref>.

#### Remarks

The <xref href="osu.Framework.Graphics.Sprites.SpriteText" data-throw-if-not-resolved="false"></xref> defined by the <xref href="osu.Framework.Graphics.Containers.Markdown.IMarkdownTextComponent" data-throw-if-not-resolved="false"></xref> resolved from dependencies is used by default,
but may be overridden via this method to provide additional styling local to this <xref href="osu.Framework.Graphics.Containers.Markdown.IMarkdownTextFlowComponent" data-throw-if-not-resolved="false"></xref>.

