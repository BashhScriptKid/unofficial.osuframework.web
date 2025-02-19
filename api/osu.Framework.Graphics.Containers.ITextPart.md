# <a id="osu_Framework_Graphics_Containers_ITextPart"></a> Interface ITextPart

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Represents a part of text inside a <xref href="osu.Framework.Graphics.Containers.TextFlowContainer" data-throw-if-not-resolved="false"></xref>.
This implementation allows for the contents of a text part to be swapped out,
in order to support things like text localisation, for instance.

```csharp
public interface ITextPart
```

#### Extension Methods

[ObjectExtensions.AsNonNull<ITextPart\>\(ITextPart?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<ITextPart\>\(ITextPart\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<ITextPart\>\(ITextPart\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<ITextPart\>\(ITextPart\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<ITextPart, TChild\>\(ITextPart, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<ITextPart, TChild\>\(ITextPart, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<ITextPart, TChild\>\(ITextPart, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<ITextPart\>\(ITextPart\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Properties

### <a id="osu_Framework_Graphics_Containers_ITextPart_Drawables"></a> Drawables

The drawables which currently correspond to this text part.

```csharp
IEnumerable<Drawable> Drawables { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

## Methods

### <a id="osu_Framework_Graphics_Containers_ITextPart_RecreateDrawablesFor_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> RecreateDrawablesFor\(TextFlowContainer\)

Recreates the drawables for this text part, in order for them to be appended to the <code class="paramref">textFlowContainer</code>.

```csharp
void RecreateDrawablesFor(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

### <a id="osu_Framework_Graphics_Containers_ITextPart_DrawablePartsRecreated"></a> DrawablePartsRecreated

Raised when <xref href="osu.Framework.Graphics.Containers.ITextPart.Drawables" data-throw-if-not-resolved="false"></xref> is reconstructed (e.g. when the user language was changed).
Can be used by consumers to re-apply manual adjustments to the appearance of <xref href="osu.Framework.Graphics.Containers.ITextPart.Drawables" data-throw-if-not-resolved="false"></xref>.

```csharp
event Action<IEnumerable<Drawable>> DrawablePartsRecreated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>\>

