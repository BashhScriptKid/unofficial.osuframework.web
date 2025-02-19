# <a id="osu_Framework_Graphics_Sprites"></a> Namespace osu.Framework.Graphics.Sprites

### Classes

 [FontAwesome.Brands](osu.Framework.Graphics.Sprites.FontAwesome.Brands.md)

 [BufferedContainerView<T\>](osu.Framework.Graphics.Sprites.BufferedContainerView\-1.md)

A view that displays the contents of a <xref href="osu.Framework.Graphics.Containers.BufferedContainer%601" data-throw-if-not-resolved="false"></xref>.

 [FontAwesome](osu.Framework.Graphics.Sprites.FontAwesome.md)

 [NineSliceSprite](osu.Framework.Graphics.Sprites.NineSliceSprite.md)

A <xref href="osu.Framework.Graphics.Sprites.Sprite" data-throw-if-not-resolved="false"></xref> that uses <a href="https://en.wikipedia.org/wiki/9-slice_scaling">9-slice scaling</a> to stretch a Texture.
When resizing a <xref href="osu.Framework.Graphics.Sprites.NineSliceSprite" data-throw-if-not-resolved="false"></xref>, the corners will remain unscaled.

    A                          B
  +---+----------------------+---+
C | 1 |          2           | 3 |
  +---+----------------------+---+
  |   |                      |   |
  | 4 |          5           | 6 |
  |   |                      |   |
  +---+----------------------+---+
D | 7 |          8           | 9 |
  +---+----------------------+---+

When changing the <xref href="osu.Framework.Graphics.Drawable.Width" data-throw-if-not-resolved="false"></xref>, areas 1, 4, 7, 3, 6, and 9 (A and B) will remain unscaled.
When changing the <xref href="osu.Framework.Graphics.Drawable.Height" data-throw-if-not-resolved="false"></xref>, areas 1, 2, 3, 7, 8, and 9 (C and D) will remain unscaled.

 [FontAwesome.Regular](osu.Framework.Graphics.Sprites.FontAwesome.Regular.md)

 [FontAwesome.Solid](osu.Framework.Graphics.Sprites.FontAwesome.Solid.md)

 [Sprite](osu.Framework.Graphics.Sprites.Sprite.md)

A sprite that displays its texture.

 [SpriteDrawNode](osu.Framework.Graphics.Sprites.SpriteDrawNode.md)

Draw node containing all necessary information to draw a <xref href="osu.Framework.Graphics.Sprites.Sprite" data-throw-if-not-resolved="false"></xref>.

 [SpriteIcon](osu.Framework.Graphics.Sprites.SpriteIcon.md)

A drawable representing an icon.
Uses <xref href="osu.Framework.IO.Stores.FontStore" data-throw-if-not-resolved="false"></xref> to perform character lookups.

 [SpriteText](osu.Framework.Graphics.Sprites.SpriteText.md)

A container for simple text rendering purposes. If more complex text rendering is required, use <xref href="osu.Framework.Graphics.Containers.TextFlowContainer" data-throw-if-not-resolved="false"></xref> instead.

### Structs

 [FontUsage](osu.Framework.Graphics.Sprites.FontUsage.md)

Represents a specific usage of a font.

 [IconUsage](osu.Framework.Graphics.Sprites.IconUsage.md)

Represents a specific usage of an icon.

### Interfaces

 [IHasLineBaseHeight](osu.Framework.Graphics.Sprites.IHasLineBaseHeight.md)

Objects implementing this interface have a line base height when used in a CustomizableTextContainer.

 [IHasText](osu.Framework.Graphics.Sprites.IHasText.md)

Interface for <xref href="osu.Framework.Graphics.IDrawable" data-throw-if-not-resolved="false"></xref> components that support reading and writing text.

