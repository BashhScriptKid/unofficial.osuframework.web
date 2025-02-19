# <a id="osu_Framework_Utils"></a> Namespace osu.Framework.Utils

### Classes

 [Blur](osu.Framework.Utils.Blur.md)

Helper methods for blur calculations.

 [General](osu.Framework.Utils.General.md)

 [HasOrderedElementsAttribute](osu.Framework.Utils.HasOrderedElementsAttribute.md)

Marker attribute for <xref href="System.Enum" data-throw-if-not-resolved="false"></xref> classes whose members are annotated with <xref href="osu.Framework.Utils.OrderAttribute" data-throw-if-not-resolved="false"></xref>.
Methods from the <xref href="osu.Framework.Extensions.EnumExtensions.EnumExtensions" data-throw-if-not-resolved="false"></xref> static class use the order defined with these attributes.

 [IncrementalBSplineBuilder](osu.Framework.Utils.IncrementalBSplineBuilder.md)

A class for incrementally building B-Spline paths from a series of linear points.
This can be used to obtain a B-Spline with a minimal number of control points for any
given set of linear input points, for example, a hand-drawn path.

 [Interpolation](osu.Framework.Utils.Interpolation.md)

 [MathUtils](osu.Framework.Utils.MathUtils.md)

 [NumberFormatter](osu.Framework.Utils.NumberFormatter.md)

Exposes functionality for formatting numbers.

 [OrderAttribute](osu.Framework.Utils.OrderAttribute.md)

Allows specifying ordering of <xref href="System.Enum" data-throw-if-not-resolved="false"></xref> members, separate from the actual enum values.
Only has an effect on members of <xref href="System.Enum" data-throw-if-not-resolved="false"></xref> classes annotated with <xref href="osu.Framework.Utils.HasOrderedElementsAttribute" data-throw-if-not-resolved="false"></xref>.

 [PathApproximator](osu.Framework.Utils.PathApproximator.md)

Helper methods to approximate a path by interpolating a sequence of control points.

 [Precision](osu.Framework.Utils.Precision.md)

Utility class to compare <xref href="System.Single" data-throw-if-not-resolved="false"></xref> or <xref href="System.Double" data-throw-if-not-resolved="false"></xref> values for equality.

 [RNG](osu.Framework.Utils.RNG.md)

Static utility class for random number generation.

 [SourceGeneratorUtils](osu.Framework.Utils.SourceGeneratorUtils.md)

A set of helper functions for source generators to use in order to simplify their work.

 [ThrowHelper](osu.Framework.Utils.ThrowHelper.md)

Helper class for throwing exceptions in isolated methods, for cases where method inlining is beneficial.
As throwing directly in that case causes JIT to disable inlining on the surrounding method.

 [Validation](osu.Framework.Utils.Validation.md)

### Structs

 [CircularArcProperties](osu.Framework.Utils.CircularArcProperties.md)

 [ConvexPolygonClipper<TClip, TSubject\>](osu.Framework.Utils.ConvexPolygonClipper\-2.md)

### Interfaces

 [IInterpolable<TValue\>](osu.Framework.Utils.IInterpolable\-1.md)

An interface that defines the interpolation of a value.

### Delegates

 [InterpolationFunc<TValue, TEasing\>](osu.Framework.Utils.InterpolationFunc\-2.md)

