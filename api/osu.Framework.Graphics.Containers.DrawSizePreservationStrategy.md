# <a id="osu_Framework_Graphics_Containers_DrawSizePreservationStrategy"></a> Enum DrawSizePreservationStrategy

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

Strategies used by <xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer" data-throw-if-not-resolved="false"></xref> to enforce its
<xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.TargetDrawSize" data-throw-if-not-resolved="false"></xref>.

```csharp
public enum DrawSizePreservationStrategy
```

#### Extension Methods

[ObjectExtensions.AsNonNull<DrawSizePreservationStrategy\>\(DrawSizePreservationStrategy\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<DrawSizePreservationStrategy\>\(DrawSizePreservationStrategy\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<DrawSizePreservationStrategy\>\(DrawSizePreservationStrategy, DrawSizePreservationStrategy\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<DrawSizePreservationStrategy\>\(DrawSizePreservationStrategy\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<DrawSizePreservationStrategy\>\(DrawSizePreservationStrategy\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<DrawSizePreservationStrategy, TChild\>\(DrawSizePreservationStrategy, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<DrawSizePreservationStrategy, TChild\>\(DrawSizePreservationStrategy, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<DrawSizePreservationStrategy, TChild\>\(DrawSizePreservationStrategy, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<DrawSizePreservationStrategy\>\(DrawSizePreservationStrategy\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Average = 2` 

Preserves the aspect ratio of all children while one axis is always larger and
the other always smaller than <xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.TargetDrawSize" data-throw-if-not-resolved="false"></xref>,
achieving a good compromise.



`Maximum = 1` 

Preserves the aspect ratio of all children while ensuring one of the
two axes matches <xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.TargetDrawSize" data-throw-if-not-resolved="false"></xref>
while the other is always smaller.



`Minimum = 0` 

Preserves the aspect ratio of all children while ensuring one of the
two axes matches <xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.TargetDrawSize" data-throw-if-not-resolved="false"></xref>
while the other is always larger.



`Separate = 3` 

Ensures <xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.TargetDrawSize" data-throw-if-not-resolved="false"></xref> is perfectly
matched while aspect ratio of children is disregarded.



