# <a id="osu_Framework_Graphics_Containers_TextNewLine"></a> Class TextNewLine

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

```csharp
public class TextNewLine : TextPart, ITextPart
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextPart](osu.Framework.Graphics.Containers.TextPart.md) ← 
[TextNewLine](osu.Framework.Graphics.Containers.TextNewLine.md)

#### Implements

[ITextPart](osu.Framework.Graphics.Containers.ITextPart.md)

#### Inherited Members

[TextPart.Drawables](osu.Framework.Graphics.Containers.TextPart.md\#osu\_Framework\_Graphics\_Containers\_TextPart\_Drawables), 
[TextPart.DrawablePartsRecreated](osu.Framework.Graphics.Containers.TextPart.md\#osu\_Framework\_Graphics\_Containers\_TextPart\_DrawablePartsRecreated), 
[TextPart.RecreateDrawablesFor\(TextFlowContainer\)](osu.Framework.Graphics.Containers.TextPart.md\#osu\_Framework\_Graphics\_Containers\_TextPart\_RecreateDrawablesFor\_osu\_Framework\_Graphics\_Containers\_TextFlowContainer\_), 
[TextPart.CreateDrawablesFor\(TextFlowContainer\)](osu.Framework.Graphics.Containers.TextPart.md\#osu\_Framework\_Graphics\_Containers\_TextPart\_CreateDrawablesFor\_osu\_Framework\_Graphics\_Containers\_TextFlowContainer\_), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<TextNewLine\>\(TextNewLine?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextNewLine\>\(TextNewLine\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextNewLine\>\(TextNewLine\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextNewLine\>\(TextNewLine\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextNewLine, TChild\>\(TextNewLine, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextNewLine, TChild\>\(TextNewLine, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextNewLine, TChild\>\(TextNewLine, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextNewLine\>\(TextNewLine\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_TextNewLine__ctor_System_Boolean_"></a> TextNewLine\(bool\)

```csharp
public TextNewLine(bool indicatesNewParagraph)
```

#### Parameters

`indicatesNewParagraph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="osu_Framework_Graphics_Containers_TextNewLine_CreateDrawablesFor_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> CreateDrawablesFor\(TextFlowContainer\)

Creates drawables representing the contents of this <xref href="osu.Framework.Graphics.Containers.TextPart" data-throw-if-not-resolved="false"></xref>,
to be appended to the <code class="paramref">textFlowContainer</code>.

```csharp
protected override IEnumerable<Drawable> CreateDrawablesFor(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

