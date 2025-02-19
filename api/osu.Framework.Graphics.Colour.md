# <a id="osu_Framework_Graphics_Colour"></a> Namespace osu.Framework.Graphics.Colour

### Structs

 [ColourInfo](osu.Framework.Graphics.Colour.ColourInfo.md)

ColourInfo contains information about the colours of all 4 vertices of a quad.
These colours are always stored in linear space.

 [SRGBColour](osu.Framework.Graphics.Colour.SRGBColour.md)

A wrapper struct around Color4 that takes care of converting between sRGB and linear colour spaces.
Internally this struct stores the colour in sRGB space, which is exposed by the <xref href="osu.Framework.Graphics.Colour.SRGBColour.SRGB" data-throw-if-not-resolved="false"></xref> member.
This struct converts to linear space by using the <xref href="osu.Framework.Graphics.Colour.SRGBColour.Linear" data-throw-if-not-resolved="false"></xref> member.

