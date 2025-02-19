# <a id="osu_Framework_Graphics"></a> Namespace osu.Framework.Graphics

### Namespaces

 [osu.Framework.Graphics.Animations](osu.Framework.Graphics.Animations.md)

 [osu.Framework.Graphics.Audio](osu.Framework.Graphics.Audio.md)

 [osu.Framework.Graphics.Colour](osu.Framework.Graphics.Colour.md)

 [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)

 [osu.Framework.Graphics.Cursor](osu.Framework.Graphics.Cursor.md)

 [osu.Framework.Graphics.Effects](osu.Framework.Graphics.Effects.md)

 [osu.Framework.Graphics.Lines](osu.Framework.Graphics.Lines.md)

 [osu.Framework.Graphics.Performance](osu.Framework.Graphics.Performance.md)

 [osu.Framework.Graphics.Pooling](osu.Framework.Graphics.Pooling.md)

 [osu.Framework.Graphics.Primitives](osu.Framework.Graphics.Primitives.md)

 [osu.Framework.Graphics.Rendering](osu.Framework.Graphics.Rendering.md)

 [osu.Framework.Graphics.Shaders](osu.Framework.Graphics.Shaders.md)

 [osu.Framework.Graphics.Shapes](osu.Framework.Graphics.Shapes.md)

 [osu.Framework.Graphics.Sprites](osu.Framework.Graphics.Sprites.md)

 [osu.Framework.Graphics.Textures](osu.Framework.Graphics.Textures.md)

 [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)

 [osu.Framework.Graphics.UserInterface](osu.Framework.Graphics.UserInterface.md)

 [osu.Framework.Graphics.Video](osu.Framework.Graphics.Video.md)

 [osu.Framework.Graphics.Visualisation](osu.Framework.Graphics.Visualisation.md)

### Classes

 [BufferedDrawNode](osu.Framework.Graphics.BufferedDrawNode.md)

 [BufferedDrawNodeSharedData](osu.Framework.Graphics.BufferedDrawNodeSharedData.md)

Contains data which is shared between all <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref>s of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

 [Component](osu.Framework.Graphics.Component.md)

An updateable component that can be inserted into the draw hierarchy.
This is currently used as a marker for cases where nothing more than load, update, lifetime support and hierarchy presence are required.
Eventually this will be fleshed out (and the inheritance will be reversed to Drawable : Component).

 [DrawNode](osu.Framework.Graphics.DrawNode.md)

Contains all the information required to draw a single <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
A hierarchy of <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s is passed to the draw thread for rendering every frame.

 [Drawable](osu.Framework.Graphics.Drawable.md)

Drawables are the basic building blocks of a scene graph in this framework.
Anything that is visible or that the user interacts with has to be a Drawable.

For example:
 - Boxes
 - Sprites
 - Collections of Drawables

Drawables are always rectangular in shape in their local coordinate system,
which makes them quad-shaped in arbitrary (linearly transformed) coordinate systems.

 [DrawableExtensions](osu.Framework.Graphics.DrawableExtensions.md)

Holds extension methods for <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

 [FrameworkColour](osu.Framework.Graphics.FrameworkColour.md)

 [FrameworkFont](osu.Framework.Graphics.FrameworkFont.md)

 [Drawable.InvalidThreadForMutationException](osu.Framework.Graphics.Drawable.InvalidThreadForMutationException.md)

 [TexturedShaderDrawNode](osu.Framework.Graphics.TexturedShaderDrawNode.md)

 [TransformSequenceExtensions](osu.Framework.Graphics.TransformSequenceExtensions.md)

 [TransformableExtensions](osu.Framework.Graphics.TransformableExtensions.md)

 [Vector2Extensions](osu.Framework.Graphics.Vector2Extensions.md)

### Structs

 [BlendingParameters](osu.Framework.Graphics.BlendingParameters.md)

Contains information about how an <xref href="osu.Framework.Graphics.IDrawable" data-throw-if-not-resolved="false"></xref> should be blended into its destination.

 [Colour4](osu.Framework.Graphics.Colour4.md)

Represents an RGBA colour in the linear colour space, having colour components in the range 0-1.
Stored internally as a <xref href="System.Numerics.Vector4" data-throw-if-not-resolved="false"></xref> for performance.

 [DrawColourInfo](osu.Framework.Graphics.DrawColourInfo.md)

 [DrawInfo](osu.Framework.Graphics.DrawInfo.md)

 [MarginPadding](osu.Framework.Graphics.MarginPadding.md)

Holds data about the margin or padding of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
The margin describes the size of an empty area around its <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, while the padding describes the size of an empty area inside its container.

### Interfaces

 [IBufferedDrawable](osu.Framework.Graphics.IBufferedDrawable.md)

Interface for <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s which can be drawn by a <xref href="osu.Framework.Graphics.BufferedDrawNode" data-throw-if-not-resolved="false"></xref>.

 [ICompositeDrawNode](osu.Framework.Graphics.ICompositeDrawNode.md)

Interface for <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s which compose child <xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s.
<xref href="osu.Framework.Graphics.DrawNode" data-throw-if-not-resolved="false"></xref>s implementing this interface can be used in <xref href="osu.Framework.Graphics.Containers.CompositeDrawable" data-throw-if-not-resolved="false"></xref>s.

 [IDrawable](osu.Framework.Graphics.IDrawable.md)

Exposes various properties that are part of the public interface of <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
This interface should generally NOT be implemented by other classes than <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, but only used to
specify that an object is of type <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.
It is mostly useful in cases where you need to specify additional constraints on a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>, but also do not want to force inheriting from
any particular subclass of <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>.

 [ITexturedShaderDrawable](osu.Framework.Graphics.ITexturedShaderDrawable.md)

Interface for <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref>s which can be drawn by <xref href="osu.Framework.Graphics.TexturedShaderDrawNode" data-throw-if-not-resolved="false"></xref>s.

### Enums

 [Anchor](osu.Framework.Graphics.Anchor.md)

General enum to specify an "anchor" or "origin" point from the standard 9 points on a rectangle.
x and y counterparts can be accessed using bitwise flags.

 [Axes](osu.Framework.Graphics.Axes.md)

 [BlendingEquation](osu.Framework.Graphics.BlendingEquation.md)

 [BlendingMask](osu.Framework.Graphics.BlendingMask.md)

Represents colour component flags used for colour write mask during blending.

 [BlendingType](osu.Framework.Graphics.BlendingType.md)

 [Direction](osu.Framework.Graphics.Direction.md)

 [Easing](osu.Framework.Graphics.Easing.md)

See http://easings.net/ for more samples.

 [Edges](osu.Framework.Graphics.Edges.md)

 [FillMode](osu.Framework.Graphics.FillMode.md)

Controls the behavior of <xref href="osu.Framework.Graphics.Drawable.RelativeSizeAxes" data-throw-if-not-resolved="false"></xref> when it is set to <xref href="osu.Framework.Graphics.Axes.Both" data-throw-if-not-resolved="false"></xref>.

 [Invalidation](osu.Framework.Graphics.Invalidation.md)

Specifies which type of properties are being invalidated.

 [LoadState](osu.Framework.Graphics.LoadState.md)

Possible states of a <xref href="osu.Framework.Graphics.Drawable" data-throw-if-not-resolved="false"></xref> within the loading pipeline.

 [RotationDirection](osu.Framework.Graphics.RotationDirection.md)

