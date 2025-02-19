# <a id="osu_Framework_Graphics_Containers_TextChunk_1"></a> Class TextChunk<TSpriteText\>

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Represents a plain chunk of text to be displayed in a text flow.

```csharp
public class TextChunk<TSpriteText> : TextPart, ITextPart where TSpriteText : SpriteText, new()
```

#### Type Parameters

`TSpriteText` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextPart](osu.Framework.Graphics.Containers.TextPart.md) ← 
[TextChunk<TSpriteText\>](osu.Framework.Graphics.Containers.TextChunk\-1.md)

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

[ObjectExtensions.AsNonNull<TextChunk<TSpriteText\>\>\(TextChunk<TSpriteText\>?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextChunk<TSpriteText\>\>\(TextChunk<TSpriteText\>\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextChunk<TSpriteText\>\>\(TextChunk<TSpriteText\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextChunk<TSpriteText\>\>\(TextChunk<TSpriteText\>\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextChunk<TSpriteText\>, TChild\>\(TextChunk<TSpriteText\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextChunk<TSpriteText\>, TChild\>\(TextChunk<TSpriteText\>, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextChunk<TSpriteText\>, TChild\>\(TextChunk<TSpriteText\>, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextChunk<TSpriteText\>\>\(TextChunk<TSpriteText\>\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_TextChunk_1__ctor_osu_Framework_Localisation_LocalisableString_System_Boolean_System_Func__0__System_Action__0__"></a> TextChunk\(LocalisableString, bool, Func<TSpriteText\>, Action<TSpriteText\>?\)

```csharp
public TextChunk(LocalisableString text, bool newLineIsParagraph, Func<TSpriteText> creationFunc, Action<TSpriteText>? creationParameters = null)
```

#### Parameters

`text` [LocalisableString](osu.Framework.Localisation.LocalisableString.md)

`newLineIsParagraph` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`creationFunc` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<TSpriteText\>

`creationParameters` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TSpriteText\>?

## Methods

### <a id="osu_Framework_Graphics_Containers_TextChunk_1_CreateDrawablesFor_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> CreateDrawablesFor\(TextFlowContainer\)

Creates drawables representing the contents of this <xref href="osu.Framework.Graphics.Containers.TextPart" data-throw-if-not-resolved="false"></xref>,
to be appended to the <code class="paramref">textFlowContainer</code>.

```csharp
protected override IEnumerable<Drawable> CreateDrawablesFor(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_TextChunk_1_CreateDrawablesFor_System_String_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> CreateDrawablesFor\(string, TextFlowContainer\)

```csharp
protected virtual IEnumerable<Drawable> CreateDrawablesFor(string text, TextFlowContainer textFlowContainer)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

### <a id="osu_Framework_Graphics_Containers_TextChunk_1_CreateSpriteText_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> CreateSpriteText\(TextFlowContainer\)

```csharp
protected virtual TSpriteText CreateSpriteText(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

#### Returns

 TSpriteText

### <a id="osu_Framework_Graphics_Containers_TextChunk_1_SplitWords_System_String_"></a> SplitWords\(string\)

```csharp
protected string[] SplitWords(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

