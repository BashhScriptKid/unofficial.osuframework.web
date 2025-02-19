# <a id="osu_Framework_Graphics_Anchor"></a> Enum Anchor

Namespace: [osu.Framework.Graphics](osu.Framework.Graphics.md)  
Assembly: osu.Framework.dll  

General enum to specify an "anchor" or "origin" point from the standard 9 points on a rectangle.
x and y counterparts can be accessed using bitwise flags.

```csharp
[Flags]
public enum Anchor
```

#### Extension Methods

[ObjectExtensions.AsNonNull<Anchor\>\(Anchor\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<Anchor\>\(Anchor\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[EnumExtensions.HasFlagFast<Anchor\>\(Anchor, Anchor\)](osu.Framework.Extensions.EnumExtensions.EnumExtensions.md\#osu\_Framework\_Extensions\_EnumExtensions\_EnumExtensions\_HasFlagFast\_\_1\_\_\_0\_\_\_0\_), 
[ObjectExtensions.IsNotNull<Anchor\>\(Anchor\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<Anchor\>\(Anchor\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[AnchorExtensions.Opposite\(Anchor\)](osu.Framework.Extensions.AnchorExtensions.md\#osu\_Framework\_Extensions\_AnchorExtensions\_Opposite\_osu\_Framework\_Graphics\_Anchor\_), 
[AnchorExtensions.PositionOnQuad\(Anchor, Quad\)](osu.Framework.Extensions.AnchorExtensions.md\#osu\_Framework\_Extensions\_AnchorExtensions\_PositionOnQuad\_osu\_Framework\_Graphics\_Anchor\_osu\_Framework\_Graphics\_Primitives\_Quad\_), 
[LocalisableStringExtensions.ToLocalisableString\(IFormattable, string?\)](osu.Framework.Extensions.LocalisationExtensions.LocalisableStringExtensions.md\#osu\_Framework\_Extensions\_LocalisationExtensions\_LocalisableStringExtensions\_ToLocalisableString\_System\_IFormattable\_System\_String\_), 
[FormattableExtensions.ToString\(IFormattable, IFormatProvider\)](osu.Framework.Extensions.FormattableExtensions.md\#osu\_Framework\_Extensions\_FormattableExtensions\_ToString\_System\_IFormattable\_System\_IFormatProvider\_), 
[ContainerExtensions.WithChild<Anchor, TChild\>\(Anchor, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<Anchor, TChild\>\(Anchor, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<Anchor, TChild\>\(Anchor, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<Anchor\>\(Anchor\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Fields

`BottomCentre = 20` 

`BottomLeft = 12` 

`BottomRight = 36` 

`Centre = 18` 

`CentreLeft = 10` 

`CentreRight = 34` 

`Custom = 64` 

The user is manually updating the outcome, so we shouldn't.



`TopCentre = 17` 

`TopLeft = 9` 

`TopRight = 33` 

`x0 = 8` 

The horizontal counterpart is at "Left" position.



`x1 = 16` 

The horizontal counterpart is at "Centre" position.



`x2 = 32` 

The horizontal counterpart is at "Right" position.



`y0 = 1` 

The vertical counterpart is at "Top" position.



`y1 = 2` 

The vertical counterpart is at "Centre" position.



`y2 = 4` 

The vertical counterpart is at "Bottom" position.



