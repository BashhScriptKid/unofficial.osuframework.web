# <a id="osu_Framework_Graphics_Containers_TextPartManual"></a> Class TextPartManual

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

An <xref href="osu.Framework.Graphics.Containers.ITextPart" data-throw-if-not-resolved="false"></xref> which utilises externally-provided drawables.
Will never recreate its contents or raise <xref href="osu.Framework.Graphics.Containers.TextPartManual.DrawablePartsRecreated" data-throw-if-not-resolved="false"></xref>.

```csharp
public class TextPartManual : ITextPart
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextPartManual](osu.Framework.Graphics.Containers.TextPartManual.md)

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

[ObjectExtensions.AsNonNull<TextPartManual\>\(TextPartManual?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TextPartManual\>\(TextPartManual\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TextPartManual\>\(TextPartManual\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TextPartManual\>\(TextPartManual\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TextPartManual, TChild\>\(TextPartManual, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TextPartManual, TChild\>\(TextPartManual, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TextPartManual, TChild\>\(TextPartManual, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TextPartManual\>\(TextPartManual\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_TextPartManual__ctor_System_Collections_Generic_IEnumerable_osu_Framework_Graphics_Drawable__"></a> TextPartManual\(IEnumerable<Drawable\>\)

```csharp
public TextPartManual(IEnumerable<Drawable> drawables)
```

#### Parameters

`drawables` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

## Properties

### <a id="osu_Framework_Graphics_Containers_TextPartManual_Drawables"></a> Drawables

The drawables which currently correspond to this text part.

```csharp
public IEnumerable<Drawable> Drawables { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>

## Methods

### <a id="osu_Framework_Graphics_Containers_TextPartManual_RecreateDrawablesFor_osu_Framework_Graphics_Containers_TextFlowContainer_"></a> RecreateDrawablesFor\(TextFlowContainer\)

Recreates the drawables for this text part, in order for them to be appended to the <code class="paramref">textFlowContainer</code>.

```csharp
public void RecreateDrawablesFor(TextFlowContainer textFlowContainer)
```

#### Parameters

`textFlowContainer` [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

### <a id="osu_Framework_Graphics_Containers_TextPartManual_DrawablePartsRecreated"></a> DrawablePartsRecreated

Raised when <xref href="osu.Framework.Graphics.Containers.ITextPart.Drawables" data-throw-if-not-resolved="false"></xref> is reconstructed (e.g. when the user language was changed).
Can be used by consumers to re-apply manual adjustments to the appearance of <xref href="osu.Framework.Graphics.Containers.ITextPart.Drawables" data-throw-if-not-resolved="false"></xref>.

```csharp
public event Action<IEnumerable<Drawable>> DrawablePartsRecreated
```

#### Event Type

 [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Drawable](osu.Framework.Graphics.Drawable.md)\>\>

