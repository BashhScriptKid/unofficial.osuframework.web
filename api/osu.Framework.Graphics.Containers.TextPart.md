# <a id="osu_Framework_Graphics_Containers_TextPart"></a> Class TextPart

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

A basic implementation of <xref href="osu.Framework.Graphics.Containers.ITextPart" data-throw-if-not-resolved="false"></xref>,
which automatically handles returning correct <xref href="osu.Framework.Graphics.Containers.TextPart.Drawables" data-throw-if-not-resolved="false"></xref>
and raising <xref href="osu.Framework.Graphics.Containers.TextPart.DrawablePartsRecreated" data-throw-if-not-resolved="false"></xref>.

```csharp
public abstract class TextPart : ITextPart
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextPart](osu.Framework.Graphics.Containers.TextPart.md)

#### Derived

[TextChunk<TSpriteText\>](osu.Framework.Graphics.Containers.TextChunk\-1.md), 
[TextNewLine](osu.Framework.Graphics.Containers.TextNewLine.md)

#### Implements

[ITextPart](osu.Framework.Graphics.Containers.ITextPart.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextPart\>\(TextPart?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextPart\>\(TextPart\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextPart\>\(TextPart\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextPart\>\(TextPart\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextPart, TChild\>\(TextPart, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextPart, TChild\>\(TextPart, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextPart, TChild\>\(TextPart, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextPart\>\(TextPart\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_TextPart__ctor"></a> TextPart\(\)

```csharp
protected TextPart()
```

## Properties

### <a id="osu_Framework_Graphics_Containers_TextPart_Drawables"></a> Drawables

The drawables which currently correspond to this text part.

```csharp
public IEnumerable<Drawable> Drawables { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

## Methods

### <a id="osu_Framework_Graphics_Containers_TextPart_CreateDrawablesFor_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> CreateDrawablesFor\(TextFlowContainer\)

Creates drawables representing the contents of this <xref href="osu.Framework.Graphics.Containers.TextPart" data-throw-if-not-resolved="false"></xref>,
to be appended to the <code class="paramref">textFlowContainer</code>.

```csharp
protected abstract IEnumerable<Drawable> CreateDrawablesFor(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_TextPart_RecreateDrawablesFor_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> RecreateDrawablesFor\(TextFlowContainer\)

Recreates the drawables for this text part, in order for them to be appended to the <code class="paramref">textFlowContainer</code>.

```csharp
public void RecreateDrawablesFor(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

### <a id="osu_Framework_Graphics_Containers_TextPart_DrawablePartsRecreated"></a> DrawablePartsRecreated

Raised when <xref href="osu.Framework.Graphics.Containers.ITextPart.Drawables" data-throw-if-not-resolved="false"></xref> is reconstructed (e.g. when the user language was changed).
Can be used by consumers to re-apply manual adjustments to the appearance of <xref href="osu.Framework.Graphics.Containers.ITextPart.Drawables" data-throw-if-not-resolved="false"></xref>.

```csharp
[CanBeNull]
public event Action<IEnumerable<Drawable>> DrawablePartsRecreated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>\>

