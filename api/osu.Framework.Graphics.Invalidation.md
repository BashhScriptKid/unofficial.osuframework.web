# <a id="osu_Framework_Graphics_Invalidation"></a> Enum Invalidation

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

Specifies which type of properties are being invalidated.

```csharp
[Flags]
public enum Invalidation
```

#### Extension Methods

[ObjectExtensions.AsNonNull<Invalidation\>\(Invalidation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Invalidation\>\(Invalidation\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<Invalidation\>\(Invalidation, Invalidation\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Invalidation\>\(Invalidation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Invalidation\>\(Invalidation\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<Invalidation, TChild\>\(Invalidation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Invalidation, TChild\>\(Invalidation, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Invalidation, TChild\>\(Invalidation, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Invalidation\>\(Invalidation\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`All = 63` 

All possible things are affected.



`Colour = 8` 

<xref href="osu.Framework.Graphics.Drawable.Colour" data-throw-if-not-resolved="false"></xref> has changed.



`DrawInfo = 1` 

<xref href="osu.Framework.Graphics.Drawable.DrawInfo" data-throw-if-not-resolved="false"></xref> has changed. No change to <xref href="osu.Framework.Graphics.Drawable.RequiredParentSizeToFit" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref>
is assumed unless indicated by additional flags.



`DrawNode = 16` 

<xref href="osu.Framework.Graphics.DrawNode.ApplyState" data-throw-if-not-resolved="false"></xref> has to be invoked on all old draw nodes.
This <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flag never propagates to children.



`DrawSize = 2` 

<xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref> has changed.



`Layout = 47` 

Only the layout flags.



`MiscGeometry = 4` 

Captures all other geometry changes than <xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref>, such as
<xref href="osu.Framework.Graphics.Drawable.Rotation" data-throw-if-not-resolved="false"></xref>, <xref href="osu.Framework.Graphics.Drawable.Shear" data-throw-if-not-resolved="false"></xref>, and <xref href="osu.Framework.Graphics.Drawable.DrawPosition" data-throw-if-not-resolved="false"></xref>.



`None = 0` 

No invalidation.



`Parent = 64` 

A <xref href="osu.Framework.Graphics.Drawable.Parent" data-throw-if-not-resolved="false"></xref> has changed.
Unlike other <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags, this propagates to all children regardless of their <xref href="osu.Framework.Graphics.Drawable.IsAlive" data-throw-if-not-resolved="false"></xref> state.



`Presence = 32` 

<xref href="osu.Framework.Graphics.Drawable.IsPresent" data-throw-if-not-resolved="false"></xref> has changed.



`RequiredParentSizeToFit = 6` 

<xref href="osu.Framework.Graphics.Drawable.RequiredParentSizeToFit" data-throw-if-not-resolved="false"></xref> has to be recomputed.



