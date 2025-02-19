# <a id="osu_Framework_Graphics_Containers"></a> Namespace osu.Framework.Graphics.Containers

### Namespaces

 [osu.Framework.Graphics.Containers.Markdown](osu.Framework.Graphics.Containers.Markdown.md)

### Classes

 [AudioContainer](osu.Framework.Graphics.Containers.AudioContainer.md)

A container which exposes audio adjustments via <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

 [AudioContainer<T\>](osu.Framework.Graphics.Containers.AudioContainer\-1.md)

A container which exposes audio adjustments via <xref href="osu.Framework.Audio.IAggregateAudioAdjustment" data-throw-if-not-resolved="false"></xref>.

 [BasicScrollContainer](osu.Framework.Graphics.Containers.BasicScrollContainer.md)

 [BasicScrollContainer<T\>](osu.Framework.Graphics.Containers.BasicScrollContainer\-1.md)

 [BasicScrollContainer<T\>.BasicScrollbar](osu.Framework.Graphics.Containers.BasicScrollContainer\-1.BasicScrollbar.md)

 [BufferedContainer<T\>](osu.Framework.Graphics.Containers.BufferedContainer\-1.md)

A container that renders its children to an internal framebuffer, and then
blits the framebuffer to the screen, instead of directly rendering the children
to the screen. This allows otherwise impossible effects to be applied to the
appearance of the container at the cost of performance. Such effects include
uniform fading of children, blur, and other post-processing effects.

 [BufferedContainer](osu.Framework.Graphics.Containers.BufferedContainer.md)

A container that renders its children to an internal framebuffer, and then
blits the framebuffer to the screen, instead of directly rendering the children
to the screen. This allows otherwise impossible effects to be applied to the
appearance of the container at the cost of performance. Such effects include
uniform fading of children, blur, and other post-processing effects.
If all children are of a specific non-<xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> type, use the
generic version <xref href="osu.Framework.Graphics.Containers.BufferedContainer%601" data-throw-if-not-resolved="false"></xref>.

 [CompositeDrawable.ChildComparer](osu.Framework.Graphics.Containers.CompositeDrawable.ChildComparer.md)

 [CircularContainer](osu.Framework.Graphics.Containers.CircularContainer.md)

A container which is rounded (via automatic corner-radius and corner-exponent=2) on the shortest edge.

 [ClickableContainer](osu.Framework.Graphics.Containers.ClickableContainer.md)

 [CompositeComponent](osu.Framework.Graphics.Containers.CompositeComponent.md)

An updateable component that can be inserted into the draw hierarchy and has self-managed child components.
This is currently used as a marker for cases where nothing more than load, update, lifetime support and hierarchy presence are required.
Eventually this will be fleshed out (and the inheritance will be reversed to Drawable : Component).

 [CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)

A drawable consisting of a composite of child drawables which are
managed by the composite object itself. Transformations applied to
a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> are also applied to its children.
Additionally, <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>s support various effects, such as masking, edge effect,
padding, and automatic sizing depending on their children.

 [CompositeDrawable.CompositeDrawableDrawNode](osu.Framework.Graphics.Containers.CompositeDrawable.CompositeDrawableDrawNode.md)

A draw node responsible for rendering a <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref> and the <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s of its children.

 [Container<T\>](osu.Framework.Graphics.Containers.Container\-1.md)

A drawable which can have children added to it. Transformations applied to
a container are also applied to its children.
Additionally, containers support various effects, such as masking, edge effect,
padding, and automatic sizing depending on their children.

 [Container](osu.Framework.Graphics.Containers.Container.md)

A drawable which can have children added to it. Transformations applied to
a container are also applied to its children.
Additionally, containers support various effects, such as masking, edge effect,
padding, and automatic sizing depending on their children.
If all children are of a specific non-<xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> type, use the
generic version <xref href="osu.Framework.Graphics.Containers.Container%601" data-throw-if-not-resolved="false"></xref>.

 [ContainerExtensions](osu.Framework.Graphics.Containers.ContainerExtensions.md)

Holds extension methods for <xref href="osu.Framework.Graphics.Containers.Container%601" data-throw-if-not-resolved="false"></xref>.

 [CustomizableTextContainer](osu.Framework.Graphics.Containers.CustomizableTextContainer.md)

A <xref href="osu.Framework.Graphics.Containers.TextFlowContainer" data-throw-if-not-resolved="false"></xref> that supports adding icons into its text. Inherit from this class to define reusable custom placeholders for icons.

 [DelayedLoadUnloadWrapper](osu.Framework.Graphics.Containers.DelayedLoadUnloadWrapper.md)

 [DelayedLoadWrapper](osu.Framework.Graphics.Containers.DelayedLoadWrapper.md)

A container which asynchronously loads specified content.
Has the ability to delay the loading until it has been visible on-screen for a specified duration.
In order to benefit from delayed load, we must be inside a <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601" data-throw-if-not-resolved="false"></xref>.

 [Dimension](osu.Framework.Graphics.Containers.Dimension.md)

Defines the size of a row or column in a <xref href="osu.Framework.Graphics.Containers.GridContainer" data-throw-if-not-resolved="false"></xref>.

 [DrawSizePreservingFillContainer](osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.md)

A <xref href="osu.Framework.Graphics.Containers.Container" data-throw-if-not-resolved="false"></xref> filling its parent while preserving a given target
<xref href="osu.Framework.Graphics.Drawable.DrawSize" data-throw-if-not-resolved="false"></xref> according to a <xref href="osu.Framework.Graphics.Containers.DrawSizePreservationStrategy" data-throw-if-not-resolved="false"></xref>.
This is useful, for example, to automatically scale the user interface according to
the window resolution, or to provide automatic HiDPI display support.

 [FillFlowContainer<T\>](osu.Framework.Graphics.Containers.FillFlowContainer\-1.md)

A <xref href="osu.Framework.Graphics.Containers.FlowContainer%601" data-throw-if-not-resolved="false"></xref> that fills space by arranging its children
next to each other.
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> can be arranged horizontally, vertically, and in a
combined fashion, which is controlled by <xref href="osu.Framework.Graphics.Containers.FillFlowContainer%601.Direction" data-throw-if-not-resolved="false"></xref>.
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> are arranged from left-to-right if their
<xref href="osu.Framework.Graphics.Drawable.Anchor" data-throw-if-not-resolved="false"></xref> is to the left or centered horizontally.
They are arranged from right-to-left otherwise.
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> are arranged from top-to-bottom if their
<xref href="osu.Framework.Graphics.Drawable.Anchor" data-throw-if-not-resolved="false"></xref> is to the top or centered vertically.
They are arranged from bottom-to-top otherwise.

 [FillFlowContainer](osu.Framework.Graphics.Containers.FillFlowContainer.md)

A <xref href="osu.Framework.Graphics.Containers.FlowContainer%601" data-throw-if-not-resolved="false"></xref> that fills space by arranging its children
next to each other.
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> can be arranged horizontally, vertically, and in a
combined fashion, which is controlled by <xref href="osu.Framework.Graphics.Direction" data-throw-if-not-resolved="false"></xref>.
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> are arranged from left-to-right if their
<xref href="osu.Framework.Graphics.Drawable.Anchor" data-throw-if-not-resolved="false"></xref> is to the left or centered horizontally.
They are arranged from right-to-left otherwise.
<xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> are arranged from top-to-bottom if their
<xref href="osu.Framework.Graphics.Drawable.Anchor" data-throw-if-not-resolved="false"></xref> is to the top or centered vertically.
They are arranged from bottom-to-top otherwise.
If non-<xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref><xref href="osu.Framework.Graphics.Containers.Container%601.Children" data-throw-if-not-resolved="false"></xref> are desired, use
<xref href="osu.Framework.Graphics.Containers.FillFlowContainer%601" data-throw-if-not-resolved="false"></xref>.

 [FlowContainer<T\>](osu.Framework.Graphics.Containers.FlowContainer\-1.md)

A container that can be used to fluently arrange its children.

 [FocusedOverlayContainer](osu.Framework.Graphics.Containers.FocusedOverlayContainer.md)

An overlay container that eagerly holds keyboard focus.

 [GridContainer](osu.Framework.Graphics.Containers.GridContainer.md)

A container which allows laying out <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s in a grid.

 [GridContainerContent](osu.Framework.Graphics.Containers.GridContainerContent.md)

A wrapper for the content of a <xref href="osu.Framework.Graphics.Containers.GridContainer" data-throw-if-not-resolved="false"></xref> that provides notifications when elements are changed.

 [VirtualisedListContainer<TData, TDrawable\>.ItemFlow](osu.Framework.Graphics.Containers.VirtualisedListContainer\-2.ItemFlow.md)

 [VirtualisedListContainer<TData, TDrawable\>.ItemRow](osu.Framework.Graphics.Containers.VirtualisedListContainer\-2.ItemRow.md)

 [LifetimeManagementContainer](osu.Framework.Graphics.Containers.LifetimeManagementContainer.md)

This container is optimized for when number of alive children is significantly smaller than number of all children.
Specifically, the time complexity of <xref href="osu.Framework.Graphics.Drawable.Update" data-throw-if-not-resolved="false"></xref> should be closer to
O(number of alive children + 1) rather than O(number of all children + 1) for typical frames.

 [ModelBackedDrawable<T\>](osu.Framework.Graphics.Containers.ModelBackedDrawable\-1.md)

Manages dynamically displaying a custom <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> based on a model object.
Useful for replacing <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s on the fly.

 [TextFlowContainer.NewLineContainer](osu.Framework.Graphics.Containers.TextFlowContainer.NewLineContainer.md)

 [OverlayContainer](osu.Framework.Graphics.Containers.OverlayContainer.md)

An element which starts hidden and can be toggled to visible.

 [RearrangeableListContainer<TModel\>](osu.Framework.Graphics.Containers.RearrangeableListContainer\-1.md)

A list container that enables its children to be rearranged via dragging.

 [RearrangeableListItem<TModel\>](osu.Framework.Graphics.Containers.RearrangeableListItem\-1.md)

An item of a <xref href="osu.Framework.Graphics.Containers.RearrangeableListContainer%601" data-throw-if-not-resolved="false"></xref>.

 [SafeAreaContainer](osu.Framework.Graphics.Containers.SafeAreaContainer.md)

An <xref href="osu.Framework.Graphics.Containers.Container" data-throw-if-not-resolved="false"></xref> that can also apply a padding based on the safe areas of the nearest cached <xref href="osu.Framework.Graphics.Containers.SafeAreaDefiningContainer" data-throw-if-not-resolved="false"></xref>.
Padding will only be applied if the contents of this container would otherwise intersect the safe area margins relative to the associated target container.

 [SafeAreaDefiningContainer](osu.Framework.Graphics.Containers.SafeAreaDefiningContainer.md)

A <xref href="osu.Framework.Graphics.Containers.Container" data-throw-if-not-resolved="false"></xref> that is automatically cached and provides a <xref href="osu.Framework.Bindables.BindableSafeArea" data-throw-if-not-resolved="false"></xref> representing
the desired safe area margins. Should be used in conjunction with child <xref href="osu.Framework.Graphics.Containers.SafeAreaContainer" data-throw-if-not-resolved="false"></xref>s.
The root of the scenegraph contains an instance of this container, with <xref href="osu.Framework.Bindables.BindableSafeArea" data-throw-if-not-resolved="false"></xref> automatically bound
to the host <xref href="osu.Framework.Platform.IWindow" data-throw-if-not-resolved="false"></xref>'s <xref href="osu.Framework.Platform.IWindow.SafeAreaPadding" data-throw-if-not-resolved="false"></xref>.

 [ScrollContainer<T\>](osu.Framework.Graphics.Containers.ScrollContainer\-1.md)

 [ScrollContainer<T\>.ScrollbarContainer](osu.Framework.Graphics.Containers.ScrollContainer\-1.ScrollbarContainer.md)

 [SearchContainer<T\>](osu.Framework.Graphics.Containers.SearchContainer\-1.md)

A container which automatically filters <xref href="osu.Framework.Graphics.Containers.IFilterable" data-throw-if-not-resolved="false"></xref> children based on a search term.
Re-filtering will only be performed when the <xref href="osu.Framework.Graphics.Containers.SearchContainer%601.SearchTerm" data-throw-if-not-resolved="false"></xref> changes, or
the layout of the container is invalidated.

 [SearchContainer](osu.Framework.Graphics.Containers.SearchContainer.md)

 [TabbableContainer<T\>](osu.Framework.Graphics.Containers.TabbableContainer\-1.md)

 [TabbableContainer](osu.Framework.Graphics.Containers.TabbableContainer.md)

 [TableColumn](osu.Framework.Graphics.Containers.TableColumn.md)

Defines a column of the <xref href="osu.Framework.Graphics.Containers.TableContainer" data-throw-if-not-resolved="false"></xref>.

 [TableContainer](osu.Framework.Graphics.Containers.TableContainer.md)

A container which tabulates <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s.

 [TextChunk<TSpriteText\>](osu.Framework.Graphics.Containers.TextChunk\-1.md)

Represents a plain chunk of text to be displayed in a text flow.

 [TextFlowContainer](osu.Framework.Graphics.Containers.TextFlowContainer.md)

A drawable text object that supports more advanced text formatting.

 [TextNewLine](osu.Framework.Graphics.Containers.TextNewLine.md)

 [TextPart](osu.Framework.Graphics.Containers.TextPart.md)

A basic implementation of <xref href="osu.Framework.Graphics.Containers.ITextPart" data-throw-if-not-resolved="false"></xref>,
which automatically handles returning correct <xref href="osu.Framework.Graphics.Containers.TextPart.Drawables" data-throw-if-not-resolved="false"></xref>
and raising <xref href="osu.Framework.Graphics.Containers.TextPart.DrawablePartsRecreated" data-throw-if-not-resolved="false"></xref>.

 [TextPartManual](osu.Framework.Graphics.Containers.TextPartManual.md)

An <xref href="osu.Framework.Graphics.Containers.ITextPart" data-throw-if-not-resolved="false"></xref> which utilises externally-provided drawables.
Will never recreate its contents or raise <xref href="osu.Framework.Graphics.Containers.TextPartManual.DrawablePartsRecreated" data-throw-if-not-resolved="false"></xref>.

 [VirtualisedListContainer<TData, TDrawable\>](osu.Framework.Graphics.Containers.VirtualisedListContainer\-2.md)

This class is an alternative to combined <xref href="osu.Framework.Graphics.Containers.ScrollContainer%601" data-throw-if-not-resolved="false"></xref> / <xref href="osu.Framework.Graphics.Containers.FlowContainer%601" data-throw-if-not-resolved="false"></xref> usage
for large lists (think thousands of items).
This class efficiently handles collection change events, as well as applies pooling to only allocate drawables for what is actually visible
on screen.
The trade-off is that every row has to have an estimated or fixed height so that layout can be estimated cheaply pre-emptively.

 [VisibilityContainer](osu.Framework.Graphics.Containers.VisibilityContainer.md)

A container which adds a basic visibility state.

### Structs

 [Container<T\>.Enumerator](osu.Framework.Graphics.Containers.Container\-1.Enumerator.md)

 [LifetimeBoundaryCrossedEvent](osu.Framework.Graphics.Containers.LifetimeBoundaryCrossedEvent.md)

Represents that the clock is crossed <xref href="osu.Framework.Graphics.Containers.LifetimeManagementContainer" data-throw-if-not-resolved="false"></xref>'s child lifetime boundary i.e. <xref href="osu.Framework.Graphics.Drawable.LifetimeStart" data-throw-if-not-resolved="false"></xref> or <xref href="osu.Framework.Graphics.Drawable.LifetimeEnd" data-throw-if-not-resolved="false"></xref>,

### Interfaces

 [IBufferedContainer](osu.Framework.Graphics.Containers.IBufferedContainer.md)

 [IConditionalFilterable](osu.Framework.Graphics.Containers.IConditionalFilterable.md)

Am <xref href="osu.Framework.Graphics.Containers.IFilterable" data-throw-if-not-resolved="false"></xref> that additionally allows specifying whether the item can be shown
based on additional criteria.
The item will be visible in a <xref href="osu.Framework.Graphics.Containers.SearchContainer" data-throw-if-not-resolved="false"></xref>
if and only if <xref href="osu.Framework.Graphics.Containers.IHasFilterTerms.FilterTerms" data-throw-if-not-resolved="false"></xref> match
and <xref href="osu.Framework.Graphics.Containers.IConditionalFilterable.CanBeShown" data-throw-if-not-resolved="false"></xref> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>.

 [IContainer](osu.Framework.Graphics.Containers.IContainer.md)

 [IContainerCollection<T\>](osu.Framework.Graphics.Containers.IContainerCollection\-1.md)

 [IContainerEnumerable<T\>](osu.Framework.Graphics.Containers.IContainerEnumerable\-1.md)

 [IFillFlowContainer](osu.Framework.Graphics.Containers.IFillFlowContainer.md)

 [IFilterable](osu.Framework.Graphics.Containers.IFilterable.md)

Implementing this interface in a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> allows it to be filtered basing on provided search terms
when placed inside a <xref href="osu.Framework.Graphics.Containers.SearchContainer%601" data-throw-if-not-resolved="false"></xref>.

 [IHasFilterTerms](osu.Framework.Graphics.Containers.IHasFilterTerms.md)

An interface to expose a number of keywords with the intent of helping a parent filter results.
See <xref href="osu.Framework.Graphics.Containers.IFilterable" data-throw-if-not-resolved="false"></xref> for an interface which adds a callback on matching keywords.

 [IHasFilterableChildren](osu.Framework.Graphics.Containers.IHasFilterableChildren.md)

 [ISafeArea](osu.Framework.Graphics.Containers.ISafeArea.md)

Containers that implement this interface act as a target for any child <xref href="osu.Framework.Graphics.Containers.SafeAreaContainer" data-throw-if-not-resolved="false"></xref>s.

 [IScrollContainer](osu.Framework.Graphics.Containers.IScrollContainer.md)

 [ITabbableContainer](osu.Framework.Graphics.Containers.ITabbableContainer.md)

This interface is used for recognizing <xref href="osu.Framework.Graphics.Containers.TabbableContainer%601" data-throw-if-not-resolved="false"></xref> of any type without reflection.

 [ITextPart](osu.Framework.Graphics.Containers.ITextPart.md)

Represents a part of text inside a <xref href="osu.Framework.Graphics.Containers.TextFlowContainer" data-throw-if-not-resolved="false"></xref>.
This implementation allows for the contents of a text part to be swapped out,
in order to support things like text localisation, for instance.

### Enums

 [DrawSizePreservationStrategy](osu.Framework.Graphics.Containers.DrawSizePreservationStrategy.md)

Strategies used by <xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer" data-throw-if-not-resolved="false"></xref> to enforce its
<xref href="osu.Framework.Graphics.Containers.DrawSizePreservingFillContainer.TargetDrawSize" data-throw-if-not-resolved="false"></xref>.

 [EffectPlacement](osu.Framework.Graphics.Containers.EffectPlacement.md)

 [FillDirection](osu.Framework.Graphics.Containers.FillDirection.md)

Represents the direction children of a <xref href="osu.Framework.Graphics.Containers.FillFlowContainer%601" data-throw-if-not-resolved="false"></xref> should be filled in.

 [GridSizeMode](osu.Framework.Graphics.Containers.GridSizeMode.md)

 [Visibility](osu.Framework.Graphics.Containers.Visibility.md)

