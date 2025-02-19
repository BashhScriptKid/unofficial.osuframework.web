# <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChildComparer"></a> Class CompositeDrawable.ChildComparer

Namespace: [osu.Framework.Graphics.Containers](osu.Framework.Graphics.Containers.md)  
Assembly: osu.Framework.dll  

```csharp
protected class CompositeDrawable.ChildComparer : IComparer<Drawable>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CompositeDrawable.ChildComparer](osu.Framework.Graphics.Containers.CompositeDrawable.ChildComparer.md)

#### Implements

[IComparer<Drawable\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icomparer\-1)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.AsNonNull<CompositeDrawable.ChildComparer\>\(CompositeDrawable.ChildComparer?\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_AsNonNull\_\_1\_\_\_0\_), 
[ExtensionMethods.GetDescription\(object\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetDescription\_System\_Object\_), 
[ExtensionMethods.GetLocalisableDescription<CompositeDrawable.ChildComparer\>\(CompositeDrawable.ChildComparer\)](osu.Framework.Extensions.ExtensionMethods.md\#osu\_Framework\_Extensions\_ExtensionMethods\_GetLocalisableDescription\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNotNull<CompositeDrawable.ChildComparer\>\(CompositeDrawable.ChildComparer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNotNull\_\_1\_\_\_0\_), 
[ObjectExtensions.IsNull<CompositeDrawable.ChildComparer\>\(CompositeDrawable.ChildComparer\)](osu.Framework.Extensions.ObjectExtensions.ObjectExtensions.md\#osu\_Framework\_Extensions\_ObjectExtensions\_ObjectExtensions\_IsNull\_\_1\_\_\_0\_), 
[ContainerExtensions.WithChild<CompositeDrawable.ChildComparer, TChild\>\(CompositeDrawable.ChildComparer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChild\_\_2\_\_\_0\_\_\_1\_), 
[ContainerExtensions.WithChildren<CompositeDrawable.ChildComparer, TChild\>\(CompositeDrawable.ChildComparer, IEnumerable<TChild\>\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_WithChildren\_\_2\_\_\_0\_System\_Collections\_Generic\_IEnumerable\_\_\_1\_\_), 
[ContainerExtensions.Wrap<CompositeDrawable.ChildComparer, TChild\>\(CompositeDrawable.ChildComparer, TChild\)](osu.Framework.Graphics.Containers.ContainerExtensions.md\#osu\_Framework\_Graphics\_Containers\_ContainerExtensions\_Wrap\_\_2\_\_\_0\_\_\_1\_), 
[EnumerableExtensions.Yield<CompositeDrawable.ChildComparer\>\(CompositeDrawable.ChildComparer\)](osu.Framework.Extensions.IEnumerableExtensions.EnumerableExtensions.md\#osu\_Framework\_Extensions\_IEnumerableExtensions\_EnumerableExtensions\_Yield\_\_1\_\_\_0\_)

## Constructors

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChildComparer__ctor_osu_Framework_Graphics_Containers_CompositeDrawable_"></a> ChildComparer\(CompositeDrawable\)

```csharp
public ChildComparer(CompositeDrawable owner)
```

#### Parameters

`owner` [CompositeDrawable](osu.Framework.Graphics.Containers.CompositeDrawable.md)

## Methods

### <a id="osu_Framework_Graphics_Containers_CompositeDrawable_ChildComparer_Compare_osu_Framework_Graphics_Drawable_osu_Framework_Graphics_Drawable_"></a> Compare\(Drawable, Drawable\)

Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.

```csharp
public int Compare(Drawable x, Drawable y)
```

#### Parameters

`x` [Drawable](osu.Framework.Graphics.Drawable.md)

The first object to compare.

`y` [Drawable](osu.Framework.Graphics.Drawable.md)

The second object to compare.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

A signed integer that indicates the relative values of <code class="paramref">x</code> and <code class="paramref">y</code>, as shown in the following table.  

 <table><thead><tr><th class="term"> Value</th><th class="description"> Meaning</th></tr></thead><tbody><tr><td class="term"> Less than zero</td><td class="description"><code class="paramref">x</code> is less than <code class="paramref">y</code>.</td></tr><tr><td class="term"> Zero</td><td class="description"><code class="paramref">x</code> equals <code class="paramref">y</code>.</td></tr><tr><td class="term"> Greater than zero</td><td class="description"><code class="paramref">x</code> is greater than <code class="paramref">y</code>.</td></tr></tbody></table>

