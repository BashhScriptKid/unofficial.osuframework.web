# <a id="osu_Framework_Graphics_FillMode"></a> Enum FillMode

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Controls the behavior of <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> when it is set to <xref href="osu.Framework.Graphics.Axes.Both" data-throw-if-not-resolved="false"></xref>.

```csharp
public enum FillMode
```

#### Extension Methods

[ObjectExtensions.AsNonNull<FillMode\>\(FillMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<FillMode\>\(FillMode\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<FillMode\>\(FillMode, FillMode\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<FillMode\>\(FillMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<FillMode\>\(FillMode\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<FillMode, TChild\>\(FillMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<FillMode, TChild\>\(FillMode, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<FillMode, TChild\>\(FillMode, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<FillMode\>\(FillMode\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`Fill = 1` 

Always maintains aspect ratio while filling the portion of the parent's size denoted by the relative size.
A relative size of 1 results in completely filling the parent by scaling the smaller axis of the drawable to fill the parent.



`Fit = 2` 

Always maintains aspect ratio while fitting into the portion of the parent's size denoted by the relative size.
A relative size of 1 results in fitting exactly into the parent by scaling the larger axis of the drawable to fit into the parent.



`Stretch = 0` 

Completely fill the parent with a relative size of 1 at the cost of stretching the aspect ratio (default).



