# <a id="osu_Framework_Graphics_Cursor"></a> Namespace osu.Framework.Graphics.Cursor

### Classes

 [BasicContextMenuContainer](osu.Framework.Graphics.Cursor.BasicContextMenuContainer.md)

 [ContextMenuContainer](osu.Framework.Graphics.Cursor.ContextMenuContainer.md)

A container which manages a <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref>.
If a right-click happens on a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> that implements <xref href="osu.Framework.Graphics.Cursor.IHasContextMenu" data-throw-if-not-resolved="false"></xref> and exists as a child of the same <xref href="osu.Framework.Input.InputManager" data-throw-if-not-resolved="false"></xref> as this container,
a <xref href="osu.Framework.Graphics.UserInterface.Menu" data-throw-if-not-resolved="false"></xref> will be displayed with bottom-right origin at the right-clicked position.

 [CursorContainer](osu.Framework.Graphics.Cursor.CursorContainer.md)

 [CursorEffectContainer<TSelf, TTarget\>](osu.Framework.Graphics.Cursor.CursorEffectContainer\-2.md)

An abstract container type that handles positional input for many drawables of type <code class="typeparamref">TTarget</code>.

 [PopoverContainer](osu.Framework.Graphics.Cursor.PopoverContainer.md)

 [TooltipContainer.Tooltip](osu.Framework.Graphics.Cursor.TooltipContainer.Tooltip.md)

The default tooltip. Simply displays its text on a gray background and performs no easing.

 [TooltipContainer](osu.Framework.Graphics.Cursor.TooltipContainer.md)

Displays Tooltips for all its children that inherit from the <xref href="osu.Framework.Graphics.Cursor.IHasTooltip" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> interfaces. Keep in mind that only children with <xref href="osu.Framework.Graphics.Drawable.HandlePositionalInput" data-throw-if-not-resolved="false"></xref> set to true will be checked for their tooltips.

 [TouchLongPressFeedback](osu.Framework.Graphics.Cursor.TouchLongPressFeedback.md)

### Interfaces

 [IHasAppearDelay](osu.Framework.Graphics.Cursor.IHasAppearDelay.md)

A tooltip which provides a custom delay until it appears, override the <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref>-wide default.

 [IHasContextMenu](osu.Framework.Graphics.Cursor.IHasContextMenu.md)

 [IHasCustomTooltip](osu.Framework.Graphics.Cursor.IHasCustomTooltip.md)

Implementing this interface allows the implementing <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to display a custom tooltip if it is the child of a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref>.
Keep in mind that tooltips can only be displayed by a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> if the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> implementing <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> has <xref href="osu.Framework.Graphics.Drawable.HandlePositionalInput" data-throw-if-not-resolved="false"></xref> set to true.

 [IHasCustomTooltip<TContent\>](osu.Framework.Graphics.Cursor.IHasCustomTooltip\-1.md)

Implementing this interface allows the implementing <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to display a custom tooltip if it is the child of a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref>.
Keep in mind that tooltips can only be displayed by a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> if the <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> implementing <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> has <xref href="osu.Framework.Graphics.Drawable.HandlePositionalInput" data-throw-if-not-resolved="false"></xref> set to true.

 [IHasPopover](osu.Framework.Graphics.Cursor.IHasPopover.md)

Interface to be implemented by UI controls that show a <xref href="osu.Framework.Graphics.UserInterface.Popover" data-throw-if-not-resolved="false"></xref> on click.

 [IHasTooltip](osu.Framework.Graphics.Cursor.IHasTooltip.md)

Implementing this interface allows the implementing <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> to display a tooltip if it is the child of a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref>. The tooltip used is
dependent on the implementation of the <xref href="osu.Framework.Graphics.Cursor.TooltipContainer.CreateTooltip" data-throw-if-not-resolved="false"></xref> method of the <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> containing this <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

 [ITooltip](osu.Framework.Graphics.Cursor.ITooltip.md)

A tooltip that can be used in conjunction with a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> and/or <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> implementation.

 [ITooltip<T\>](osu.Framework.Graphics.Cursor.ITooltip\-1.md)

A tooltip that can be used in conjunction with a <xref href="osu.Framework.Graphics.Cursor.TooltipContainer" data-throw-if-not-resolved="false"></xref> and/or <xref href="osu.Framework.Graphics.Cursor.IHasCustomTooltip" data-throw-if-not-resolved="false"></xref> implementation.

 [ITooltipContentProvider](osu.Framework.Graphics.Cursor.ITooltipContentProvider.md)

Marker interface for interfaces that provide tooltip content.

