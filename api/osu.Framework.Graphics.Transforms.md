# <a id="osu_Framework_Graphics_Transforms"></a> Namespace osu.Framework.Graphics.Transforms

### Classes

 [Transform](osu.Framework.Graphics.Transforms.Transform.md)

 [Transform<TValue, T\>](osu.Framework.Graphics.Transforms.Transform\-2.md)

 [Transform<TValue, TEasing, T\>](osu.Framework.Graphics.Transforms.Transform\-3.md)

 [Transform<TValue\>](osu.Framework.Graphics.Transforms.Transform\-1.md)

 [TransformSequence<T\>](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)

A sequence of <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s all operating upon the same <xref href="osu.Framework.Graphics.Transforms.ITransformable" data-throw-if-not-resolved="false"></xref>
of type <code class="typeparamref">T</code>.
Exposes various operations to extend the sequence by additional <xref href="osu.Framework.Graphics.Transforms" data-throw-if-not-resolved="false"></xref> such as
delays, loops, continuations, and events.

 [Transformable](osu.Framework.Graphics.Transforms.Transformable.md)

A type of object which can have <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s operating upon it.
An implementer of this class must call <xref href="osu.Framework.Graphics.Transforms.Transformable.UpdateTransforms" data-throw-if-not-resolved="false"></xref> to
update and apply its <xref href="osu.Framework.Graphics.Transforms.Transform" data-throw-if-not-resolved="false"></xref>s.

### Structs

 [DefaultEasingFunction](osu.Framework.Graphics.Transforms.DefaultEasingFunction.md)

An easing function corresponding to one of the <xref href="osu.Framework.Graphics.Easing" data-throw-if-not-resolved="false"></xref> types.

### Interfaces

 [IEasingFunction](osu.Framework.Graphics.Transforms.IEasingFunction.md)

An interface for an easing function that is applied to <xref href="osu.Framework.Graphics.Transforms.Transform%601" data-throw-if-not-resolved="false"></xref>s.

 [ITransformSequence](osu.Framework.Graphics.Transforms.ITransformSequence.md)

 [ITransformable](osu.Framework.Graphics.Transforms.ITransformable.md)

### Delegates

 [TransformSequence<T\>.Generator](osu.Framework.Graphics.Transforms.TransformSequence\-1.Generator.md)

A delegate that generates a new <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> on a given <code class="paramref">origin</code>.

