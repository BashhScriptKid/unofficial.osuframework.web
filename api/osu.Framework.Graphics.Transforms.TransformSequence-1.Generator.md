# <a id="osu_Framework_Graphics_Transforms_TransformSequence_1_Generator"></a> Delegate TransformSequence<T\>.Generator

Namespace: [osu.Framework.Graphics.Transforms](osu.Framework.Graphics.Transforms.md)  
Assembly: osu.Framework.dll  

A delegate that generates a new <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> on a given <code class="paramref">origin</code>.

```csharp
public delegate TransformSequence<T> TransformSequence<T>.Generator(T origin)
```

#### Parameters

`origin` T

The origin to generate a <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref> for.

#### Returns

 [TransformSequence](osu.Framework.Graphics.Transforms.TransformSequence\-1.md)<T\>

The generated <xref href="osu.Framework.Graphics.Transforms.TransformSequence%601" data-throw-if-not-resolved="false"></xref>.

#### Extension Methods

[ObjectExtensions.AsNonNull<TransformSequence<T\>.Generator\>\(TransformSequence<T\>.Generator?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<TransformSequence<T\>.Generator\>\(TransformSequence<T\>.Generator\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<TransformSequence<T\>.Generator\>\(TransformSequence<T\>.Generator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<TransformSequence<T\>.Generator\>\(TransformSequence<T\>.Generator\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<TransformSequence<T\>.Generator, TChild\>\(TransformSequence<T\>.Generator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<TransformSequence<T\>.Generator, TChild\>\(TransformSequence<T\>.Generator, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<TransformSequence<T\>.Generator, TChild\>\(TransformSequence<T\>.Generator, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<TransformSequence<T\>.Generator\>\(TransformSequence<T\>.Generator\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

