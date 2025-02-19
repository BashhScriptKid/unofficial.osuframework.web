# <a id="osu_Framework_Layout"></a> Namespace osu.Framework.Layout

### Classes

 [LayoutMember](osu.Framework.Layout.LayoutMember.md)

A member that represents a part of the layout of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Can be invalidated according to state changes in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> (via <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags).

 [LayoutValue<T\>](osu.Framework.Layout.LayoutValue\-1.md)

A member that represents the validation state of a value in the layout of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Can be invalidated according to state changes in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> (via <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags), and validated when an up-to-date value is set.

 [LayoutValue](osu.Framework.Layout.LayoutValue.md)

A member that represents the validation state of the layout of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
Can be invalidated according to state changes in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> (via <xref href="osu.Framework.Graphics.Invalidation" data-throw-if-not-resolved="false"></xref> flags), and validated on-demand when the layout has been re-computed.

### Enums

 [InvalidationSource](osu.Framework.Layout.InvalidationSource.md)

Indicates the source of an invalidation of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

### Delegates

 [InvalidationConditionDelegate](osu.Framework.Layout.InvalidationConditionDelegate.md)

The delegate that provides extra conditions for an invalidation to occur.

